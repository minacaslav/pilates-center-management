using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System.Data;
using System.Globalization;

namespace Client.GuiController
{
    public class EvidencijaGuiController
    {
        private UCPretraziEvidenciju pretraziUC;
        private UCDetaljiEvidencije detaljiUC;
        private DataTable dataTableEvidencije;
        private List<EvidencijaClanarine> evidencije;
        private List<EvidencijaClanarine> filtriraneEvidencije;
        private List<Clan> trenutniClanovi;
        private EvidencijaClanarine selektovanaEvidencija;

        internal Control CreateKreirajEvidencijuPanel()
        {
            return new UCkreirajEvidencijaClanarine();
        }
        internal Control CreatePretraziEvidencijePanel()
        {
            pretraziUC = new UCPretraziEvidenciju();
            InicijalizujTabeluZaPrikazEvidencija();
            UcitajPodatkeZaFiltere();
            PostaviEventHandlers();
            OnemoguciSveFilterKontrole();

            return pretraziUC;
        }
        internal Control CreateDetaljiEvidencijePanel(int idEvidencije)
        {
            detaljiUC = new UCDetaljiEvidencije();
            UcitajPodatkeZaDetaljeEvidencije(idEvidencije);
            MessageBox.Show("Систем је нашао евиденцију чланарине.");
            return detaljiUC;
        }

        #region Inicijalizacija i Konfiguracija
        private void InicijalizujTabeluZaPrikazEvidencija()
        {
            dataTableEvidencije = new DataTable();

            dataTableEvidencije.Columns.Add("ID евиденције", typeof(int));
            dataTableEvidencije.Columns.Add("Члан", typeof(string));
            dataTableEvidencije.Columns.Add("Тренер", typeof(string));
            dataTableEvidencije.Columns.Add("Датум почетка", typeof(DateTime));
            dataTableEvidencije.Columns.Add("Датум завршетка", typeof(DateTime));
            dataTableEvidencije.Columns.Add("Статус", typeof(string));
            dataTableEvidencije.Columns.Add("Износ", typeof(decimal));
            dataTableEvidencije.Columns.Add("Коментар", typeof(string));

            pretraziUC.DgvEvidencije.DataSource = dataTableEvidencije;
        }
        private void UcitajPodatkeZaFiltere()
        {
            try
            {
                Response treneriResponse = Communication.Instance.VratiListuSviTrener();
                pretraziUC.CmbTrener.DataSource = (List<Trener>)treneriResponse.Result;

                Response tipoviResponse = Communication.Instance.VratiListuSviTipClanarine();
                pretraziUC.CmbTipClanarine.DataSource = (List<TipClanarine>)tipoviResponse.Result;

                pretraziUC.CmbTipPretrage.Items.AddRange(new string[]
                {
                    "Тренер",
                    "Члан",
                    "Тип чланарине",
                    "Евиденција чланарине"
                });

                pretraziUC.CmbStatus.Items.AddRange(new string[]
                {
                    "Сви статуси",
                    "Активан",
                    "Неактиван",
                    "Отказан",
                    "Истекао"
                });
                pretraziUC.CmbStatus.SelectedIndex = 0;

                pretraziUC.DtpDatumOd.Value = DateTime.Now.AddMonths(-1);
                pretraziUC.DtpDatumDo.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при учитавању података: {ex.Message}");
            }
        }
        private void PostaviEventHandlers()
        {
            pretraziUC.CmbTipPretrage.SelectedIndexChanged += OnPromenaKriterijuma!;
            pretraziUC.CmbTrener.SelectedIndexChanged += OnSelectedTipPretrage!;
            pretraziUC.CmbTipClanarine.SelectedIndexChanged += OnSelectedTipPretrage!;
            pretraziUC.BtnResetuj.Click += ResetujFormuZaPretragu!;
            pretraziUC.BtnPretraziClanove.Click += PretraziClanovePoKriterijumima!;
            pretraziUC.BtnDetaljnaPretraga.Click += IzvrsiOsnovnuPretragu!;
            pretraziUC.BtnPretrazi.Click += OnClickZaPrikazDetalja!;
            pretraziUC.DgvEvidencije.CellDoubleClick += OnDupliKlikNaTabeli!;
        }
        #endregion

        #region Logika Pretrage Evidencija
        private void OnPromenaKriterijuma(object sender, EventArgs e)
        {
            OnemoguciSveFilterKontrole();
            evidencije = null!;

            switch (pretraziUC.CmbTipPretrage.SelectedIndex)
            {
                case 0: // Trener
                    pretraziUC.CmbTrener.Enabled = true;
                    break;
                case 1: // Clan
                    pretraziUC.TxtImeClana.Enabled = true;
                    pretraziUC.TxtPrezimeClana.Enabled = true;
                    pretraziUC.TxtEmailClana.Enabled = true;
                    pretraziUC.BtnPretraziClanove.Enabled = true;
                    break;
                case 2: // Tip clanarine
                    pretraziUC.CmbTipClanarine.Enabled = true;
                    break;
                case 3: // EvC
                    OmoguciPretraguPoEvidenciji();
                    break;
            }
        }
        private void OnSelectedTipPretrage(object sender, EventArgs e)
        {
            if (pretraziUC.CmbTipPretrage.SelectedIndex == -1) return;

            string tipPretrage = pretraziUC.CmbTipPretrage.SelectedItem?.ToString()!;

            if ((sender == pretraziUC.CmbTrener && tipPretrage == "Тренер") ||
                (sender == pretraziUC.CmbTipClanarine && tipPretrage == "Тип чланарине"))
            {
                if (sender is ComboBox comboBox && comboBox.SelectedIndex != -1)
                {
                    IzvrsiOsnovnuPretragu(sender, e);
                }
            }
        }
        private void IzvrsiOsnovnuPretragu(object sender, EventArgs e)
        {
            try
            {
                Response response = null!;

                switch (pretraziUC.CmbTipPretrage.SelectedIndex)
                {
                    case 0: // Trener
                        if (pretraziUC.CmbTrener.SelectedItem is Trener trener)
                            response = Communication.Instance.VratiListuEvidencijaClanarinePoTreneru(trener);
                        break;
                    case 1: // Clan //PretraziClanove
                        return;
                    case 2: // Tip clanarine
                        if (pretraziUC.CmbTipClanarine.SelectedItem is TipClanarine tip)
                            response = Communication.Instance.VratiListuEvidencijaClanarinePoTipuClanarine(tip);
                        break;
                    case 3: // Detaljna pretraga
                        response = IzvrsiPretraguPoEvidenciji();
                        break;
                }

                if (response != null && response.ExceptionMessage == null)
                {
                    evidencije = (List<EvidencijaClanarine>)response.Result;
                    evidencije = PopuniReferentnePodatke(evidencije);

                    if (evidencije.Count == 0)
                    {
                        MessageBox.Show("Систем не може да нађе евиденције чланарине по задатим критеријумима",
                            "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        PopuniTabeluEvidencijama(evidencije);
                        MessageBox.Show("Систем је нашао евиденције чланарине по задатим критеријумима",
                            "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Систем не може да нађе евиденције чланарине по задатим критеријумима", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show($"Грешка при претрази: {ex.Message}");
            }
        }
        private Response IzvrsiPretraguPoEvidenciji()
        {
            try
            {
                var kriterijum = new EvidencijaClanarine();

                if (pretraziUC.DtpDatumOd.Checked)
                {
                    kriterijum.DatumPocetka = pretraziUC.DtpDatumOd.Value;
                }

                if (pretraziUC.DtpDatumDo.Checked)
                {
                    kriterijum.DatumZavrsetka = pretraziUC.DtpDatumDo.Value;
                }

                if (pretraziUC.CmbStatus.SelectedIndex > 0)
                {
                    kriterijum.StatusEvidencije = (StatusEvidencije)(pretraziUC.CmbStatus.SelectedIndex - 1);
                }

                Response response = Communication.Instance.VratiListuEvidencijaClanarinePoEvidenciji(kriterijum);
                return response;
            }
            catch (Exception ex)
            {
                return new Response { ExceptionMessage = ex.Message };
            }
        }
        private void PretraziClanovePoKriterijumima(object sender, EventArgs e)
        {
            try
            {
                if (!ProveriUnosZaClana())
                    return;

                var kriterijum = new Clan
                {
                    Ime = pretraziUC.TxtImeClana.Text,
                    Prezime = pretraziUC.TxtPrezimeClana.Text,
                    Email = pretraziUC.TxtEmailClana.Text
                };

                Response response = Communication.Instance.VratiListuSviClanPoKriterijumu(kriterijum);

                if (response.ExceptionMessage == null)
                {
                    trenutniClanovi = (List<Clan>)response.Result;

                    if (trenutniClanovi.Count == 0)
                    {
                        MessageBox.Show("Нема пронађених чланова по задатим критеријумима");
                    }
                    else
                    {
                        PretraziEvidencijePoClanovima(trenutniClanovi);
                    }
                }
                else
                {
                    MessageBox.Show("Нема пронађених чланова по задатим критеријумима");
                    //MessageBox.Show($"Грешка при претрази чланова: {response.ExceptionMessage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нема пронађених чланова по задатим критеријумима");
                //MessageBox.Show($"Грешка при претрази чланова: {ex.Message}");
            }
        }

        private bool ProveriUnosZaClana()
        {
            pretraziUC.TxtImeClana.BackColor = Color.White;
            pretraziUC.TxtPrezimeClana.BackColor = Color.White;
            pretraziUC.TxtEmailClana.BackColor = Color.White;

            if (String.IsNullOrEmpty(pretraziUC.TxtImeClana.Text) ||
                String.IsNullOrEmpty(pretraziUC.TxtPrezimeClana.Text) ||
                String.IsNullOrEmpty(pretraziUC.TxtEmailClana.Text))
            {
                MessageBox.Show("Молимо попуните сва поља за члана");

                if (String.IsNullOrEmpty(pretraziUC.TxtImeClana.Text))
                    pretraziUC.TxtImeClana.BackColor = Color.FromArgb(255, 200, 200);

                if (String.IsNullOrEmpty(pretraziUC.TxtPrezimeClana.Text))
                    pretraziUC.TxtPrezimeClana.BackColor = Color.FromArgb(255, 200, 200);

                if (String.IsNullOrEmpty(pretraziUC.TxtEmailClana.Text))
                    pretraziUC.TxtEmailClana.BackColor = Color.FromArgb(255, 200, 200);

                return false;
            }

            return true;
        }

        private void PretraziEvidencijePoClanovima(List<Clan> clanovi)
        {
            try
            {
                List<EvidencijaClanarine> sveEvidencije = new List<EvidencijaClanarine>();

                foreach (var clan in clanovi)
                {
                    Response response = Communication.Instance.VratiListuEvidencijaClanarinePoClanu(clan);

                    if (response != null && response.ExceptionMessage == null)
                    {
                        var evidencijeZaClana = (List<EvidencijaClanarine>)response.Result;
                        sveEvidencije.AddRange(evidencijeZaClana);
                    }
                }

                evidencije = sveEvidencije;
                evidencije = PopuniReferentnePodatke(evidencije);

                if (evidencije.Count == 0)
                {
                    MessageBox.Show("Систем не може да нађе евиденцијe чланаринa по задатим критеријумима",
                        "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    PopuniTabeluEvidencijama(evidencije);
                    MessageBox.Show($"Систем је нашао евиденцијe чланаринa по задатим критеријумима",
                        "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Систем не може да нађе евиденцијe чланаринa по задатим критеријумима",
                    "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void PopuniTabeluEvidencijama(List<EvidencijaClanarine> listaEvidencija)
        {
            dataTableEvidencije.Rows.Clear();

            foreach (var evidencija in listaEvidencija)
            {
                dataTableEvidencije.Rows.Add(
                    evidencija.IdEvidencijaClanarine,
                    evidencija.Clan != null ? $"{evidencija.Clan.Ime} {evidencija.Clan.Prezime}" : "",
                    evidencija.Trener != null ? $"{evidencija.Trener.Ime} {evidencija.Trener.Prezime}" : "",
                    evidencija.DatumPocetka,
                    evidencija.DatumZavrsetka.HasValue ? (object)evidencija.DatumZavrsetka.Value : DBNull.Value,
                    evidencija.StatusEvidencije.ToString(),
                    evidencija.UkupanIznos,
                    evidencija.Komentar ?? ""
                );
            }

            pretraziUC.LblRezultati.Text = $"Пронађено записа: {listaEvidencija.Count}";
        }
        #endregion

        #region Upravljanje Kontrolama Pretrage
        private void OnemoguciSveFilterKontrole()
        {
            pretraziUC.CmbTrener.Enabled = false;
            pretraziUC.CmbTipClanarine.Enabled = false;

            pretraziUC.TxtImeClana.Enabled = false;
            pretraziUC.TxtPrezimeClana.Enabled = false;
            pretraziUC.TxtEmailClana.Enabled = false;
            pretraziUC.BtnPretraziClanove.Enabled = false;

            pretraziUC.TxtImeClana.BackColor = Color.White;
            pretraziUC.TxtPrezimeClana.BackColor = Color.White;
            pretraziUC.TxtEmailClana.BackColor = Color.White;

            OnemoguciPretraguPoEvidenciji();

            pretraziUC.CmbTrener.SelectedIndex = -1;
            pretraziUC.CmbTipClanarine.SelectedIndex = -1;
            pretraziUC.TxtImeClana.Text = "";
            pretraziUC.TxtPrezimeClana.Text = "";
            pretraziUC.TxtEmailClana.Text = "";
        }
        private void OnemoguciPretraguPoEvidenciji()
        {
            pretraziUC.DtpDatumOd.Enabled = false;
            pretraziUC.DtpDatumDo.Enabled = false;
            pretraziUC.CmbStatus.Enabled = false;
            pretraziUC.BtnDetaljnaPretraga.Enabled = false;

            pretraziUC.DtpDatumOd.Checked = false;
            pretraziUC.DtpDatumDo.Checked = false;
            pretraziUC.CmbStatus.SelectedIndex = 0;

            pretraziUC.DtpDatumOd.Value = DateTime.Now.AddMonths(-1);
            pretraziUC.DtpDatumDo.Value = DateTime.Now;
        }
        private void OmoguciPretraguPoEvidenciji()
        {
            pretraziUC.DtpDatumOd.Enabled = true;
            pretraziUC.DtpDatumDo.Enabled = true;
            pretraziUC.CmbStatus.Enabled = true;
            pretraziUC.BtnDetaljnaPretraga.Enabled = true;
        }
        private void ResetujFormuZaPretragu(object sender, EventArgs e)
        {
            OnemoguciSveFilterKontrole();
            dataTableEvidencije.Rows.Clear();
            pretraziUC.LblRezultati.Text = "Пронађено записа: 0";
            evidencije = null!;
            trenutniClanovi = null!;
            pretraziUC.CmbTipPretrage.SelectedIndex = -1;

            pretraziUC.DtpDatumOd.Value = DateTime.Now.AddMonths(-1);
            pretraziUC.DtpDatumDo.Value = DateTime.Now;
            pretraziUC.DtpDatumOd.Checked = false;
            pretraziUC.DtpDatumDo.Checked = false;
        }
        #endregion

        #region DetaljiEvidencije
        private void UcitajPodatkeZaDetaljeEvidencije(int idEvidencije)
        {
            try
            {
                selektovanaEvidencija = evidencije?.FirstOrDefault(e => e.IdEvidencijaClanarine == idEvidencije)!;

                if (selektovanaEvidencija == null)
                {
                    var kriterijum = new EvidencijaClanarine { IdEvidencijaClanarine = idEvidencije };
                    Response response = Communication.Instance.VratiListuEvidencijaClanarinePoEvidenciji(kriterijum);

                    if (response != null && response.ExceptionMessage == null)
                    {
                        var lista = (List<EvidencijaClanarine>)response.Result;
                        selektovanaEvidencija = lista.FirstOrDefault()!;
                    }
                }

                if (selektovanaEvidencija != null)
                {
                    PopuniKontroleDetaljima(selektovanaEvidencija);
                }
                else
                {
                    MessageBox.Show("Систем не може да нађе евиденцију чланарине.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при учитавању детаља: {ex.Message}");
            }
        }
        private void OnClickZaPrikazDetalja(object sender, EventArgs e)
        {
            if (pretraziUC.DgvEvidencije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Молимо изаберите евиденцију из табеле.");
                return;
            }

            var selectedRow = pretraziUC.DgvEvidencije.SelectedRows[0];
            int idEvidencije = (int)selectedRow.Cells["ID евиденције"].Value;

            MainCoordinator.Instance.ShowDetaljiEvidencije(idEvidencije);
        }
        private void OnDupliKlikNaTabeli(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = pretraziUC.DgvEvidencije.Rows[e.RowIndex];
                    int idEvidencije = (int)selectedRow.Cells["ID евиденције"].Value;
                    MainCoordinator.Instance.ShowDetaljiEvidencije(idEvidencije);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Морате изабрати валидно поље у табели.");
                throw;
            }

        }
        private void PopuniKontroleDetaljima(EvidencijaClanarine evidencija)
        {
            detaljiUC.TxtId.Text = evidencija.IdEvidencijaClanarine.ToString();
            detaljiUC.TxtClan.Text = evidencija.Clan != null ? $"{evidencija.Clan.Ime} {evidencija.Clan.Prezime}" : "";
            detaljiUC.TxtTrener.Text = evidencija.Trener != null ? $"{evidencija.Trener.Ime} {evidencija.Trener.Prezime}" : "";
            detaljiUC.TxtDatumPocetka.Text = evidencija.DatumPocetka.ToString("dd.MM.yyyy");
            detaljiUC.TxtDatumZavrsetka.Text = evidencija.DatumZavrsetka.HasValue ?
                evidencija.DatumZavrsetka.Value.ToString("dd.MM.yyyy") : "";
            detaljiUC.TxtIznos.Text = evidencija.UkupanIznos.ToString("C", new CultureInfo("sr-RS"));

            detaljiUC.CmbStatus.Items.Clear();
            detaljiUC.CmbStatus.Items.AddRange(new string[]
            {
                "Активан",
                "Неактиван",
                "Отказан",
                "Истекао"
            });

            detaljiUC.CmbStatus.SelectedIndex = (int)evidencija.StatusEvidencije;

            detaljiUC.TxtKomentar.Text = evidencija.Komentar ?? "";

            detaljiUC.BtnIzmeni.Click += OnPokretanjeIzmene!;
            detaljiUC.BtnZapamti.Click += OnCuvanjeIzmena!;
            detaljiUC.BtnNazad.Click += OnPovratakNaPretragu!;
        }
        private void OnPokretanjeIzmene(object sender, EventArgs e)
        {
            detaljiUC.CmbStatus.Enabled = true;
            detaljiUC.TxtKomentar.Enabled = true;

            detaljiUC.BtnIzmeni.Enabled = false;
            detaljiUC.BtnZapamti.Enabled = true;
        }
        private void OnCuvanjeIzmena(object sender, EventArgs e)
        {
            try
            {
                selektovanaEvidencija.StatusEvidencije = (StatusEvidencije)detaljiUC.CmbStatus.SelectedIndex;
                selektovanaEvidencija.Komentar = detaljiUC.TxtKomentar.Text;

                Response response = Communication.Instance.PromeniEvidencijaClanarine(selektovanaEvidencija);

                if (response.ExceptionMessage == null)
                {
                    MessageBox.Show("Систем је запамтио евиденцију чланарине.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    detaljiUC.CmbStatus.Enabled = false;
                    detaljiUC.TxtKomentar.Enabled = false;
                    detaljiUC.BtnIzmeni.Enabled = true;
                    detaljiUC.BtnZapamti.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"Систем не може да запамти евиденцију чланарине", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show($"Грешка при чувању промена: {response.ExceptionMessage}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Грешка при чувању промена: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Систем не може да запамти евиденцију чланарине", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OnPovratakNaPretragu(object sender, EventArgs e) => MainCoordinator.Instance.ShowPretraziEvidencije();
        #endregion


        private List<EvidencijaClanarine> PopuniReferentnePodatke(List<EvidencijaClanarine> evidencije)
        {
            try
            {
                var sviTreneri = (List<Trener>)pretraziUC.CmbTrener.DataSource!;
                var sviClanovi = trenutniClanovi ?? UcitajSveClanove();

                foreach (var evidencija in evidencije)
                {
                    if (evidencija.IdTrener > 0)
                    {
                        var trener = sviTreneri.FirstOrDefault(t => t.IdTrener == evidencija.IdTrener);
                        if (trener != null) evidencija.Trener = trener;
                    }

                    if (evidencija.IdClan > 0)
                    {
                        var clan = sviClanovi.FirstOrDefault(c => c.IdClan == evidencija.IdClan);
                        if (clan != null) evidencija.Clan = clan;
                    }
                }

                return evidencije;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при попуњавању података: {ex.Message}");
                return evidencije;
            }
        }
        private List<Clan> UcitajSveClanove()
        {
            try
            {
                Response response = Communication.Instance.VratiListuSviClan();
                return response.ExceptionMessage == null ? (List<Clan>)response.Result : new List<Clan>();
            }
            catch
            {
                return new List<Clan>();
            }
        }

    }
}