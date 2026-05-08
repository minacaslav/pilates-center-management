using Common.Communication;
using Common.Domain;
using System.Data;

namespace Client.UserControls
{
    public partial class UCkreirajEvidencijaClanarine : UserControl
    {
        private List<StavkaEvidencijeClanarine> stavke;
        private DataTable dataTableStavke;

        public UCkreirajEvidencijaClanarine()
        {
            InitializeComponent();
            stavke = new List<StavkaEvidencijeClanarine>();
            InicijalizujDataTableStavke();
            UcitajPodatke();
            PostaviEventHandlers();
            dtpDatumPocetka.Value = DateTime.Today;
            AzurirajDatumZavrsetka();
        }

        private void InicijalizujDataTableStavke()
        {
            dataTableStavke = new DataTable();
            dataTableStavke.Columns.Add("Rb", typeof(int));
            dataTableStavke.Columns.Add("Трајање (недеље)", typeof(int));
            dataTableStavke.Columns.Add("Цена по недељи", typeof(decimal));
            dataTableStavke.Columns.Add("Износ ставке", typeof(decimal));
            dataTableStavke.Columns.Add("Начин плаћања", typeof(string));
            dataTableStavke.Columns.Add("Статус уплате", typeof(string));
            dgvStavke.DataSource = dataTableStavke;
        }
        private void UcitajPodatke()
        {
            try
            {
                Response treneriResponse = Communication.Instance.VratiListuSviTrener();
                cmbTrainer.DataSource = (List<Trener>)treneriResponse.Result;

                Response clanoviResponse = Communication.Instance.VratiListuSviClan();
                cmbMember.DataSource = (List<Clan>)clanoviResponse.Result;

                Response tipoviResponse = Communication.Instance.VratiListuSviTipClanarine();
                cmbMembershipType.DataSource = (List<TipClanarine>)tipoviResponse.Result;

                cmbNacinPlacanja.DataSource = Enum.GetValues(typeof(NacinPlacanja))
                    .Cast<NacinPlacanja>()
                    .Select(np => new { Text = np.ToString(), Value = np })
                    .ToList();
                cmbNacinPlacanja.DisplayMember = "Text";
                cmbNacinPlacanja.ValueMember = "Value";

                cmbStatusUplate.DataSource = Enum.GetValues(typeof(StatusUplate))
                    .Cast<StatusUplate>()
                    .Select(su => new { Text = su.ToString(), Value = su })
                    .ToList();
                cmbStatusUplate.DisplayMember = "Text";
                cmbStatusUplate.ValueMember = "Value";

                AzurirajPrikazStavki();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при учитавању података: {ex.Message}");
            }
        }
        private void PostaviEventHandlers()
        {
            btnSave.Click += BtnSave_Click!;
            btnDodajStavku.Click += BtnDodajStavku_Click!;
            btnReset.Click += BtnReset_Click!;
            cmbMembershipType.SelectedIndexChanged += cmbMembershipType_SelectedIndexChanged!;
            numTrajanjeUNedeljama.ValueChanged += numTrajanjeUNedeljama_ValueChanged!;
            dtpDatumPocetka.ValueChanged += DtpDatumPocetka_ValueChanged!;
        }

        private void cmbMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AzurirajCenuPoTipuClanarine();
        }
        private void numTrajanjeUNedeljama_ValueChanged(object sender, EventArgs e)
        {
            // Можете додати логику ако је потребно
        }
        private void DtpDatumPocetka_ValueChanged(object sender, EventArgs e)
        {
            AzurirajDatumZavrsetka();
        }
        private void AzurirajDatumZavrsetka()
        {
            int ukupnoNedelja = stavke.Sum(s => s.TrajanjeUNedeljama);
            DateTime datumZavrsetka = dtpDatumPocetka.Value.AddDays(ukupnoNedelja * 7);
            txtDatumZavrsetka.Text = datumZavrsetka.ToString("dd.MM.yyyy");
        }
        private void AzurirajCenuPoTipuClanarine()
        {
            if (cmbMembershipType.SelectedItem is TipClanarine selektovaniTip)
                txtCena.Text = selektovaniTip.Cena.ToString("F2");
            else
                txtCena.Text = "0";
        }
        private void AzurirajPrikazStavki()
        {
            dataTableStavke.Rows.Clear();
            int rb = 1;

            foreach (var stavka in stavke)
            {
                dataTableStavke.Rows.Add(
                    rb++,
                    stavka.TrajanjeUNedeljama,
                    stavka.Cena.ToString("F2"),
                    stavka.IznosStavke.ToString("F2"),
                    stavka.NacinPlacanja.ToString(),
                    stavka.StatusUplate.ToString()
                );
            }

            AzurirajDatumZavrsetka();
        }
        private void AzurirajUkupanIznos()
        {
            float ukupanIznos = stavke.Sum(s => s.IznosStavke);
            txtUkupanIznos.Text = ukupanIznos.ToString("F2");
        }

        private void BtnDodajStavku_Click(object sender, EventArgs e)
        {
            if (!ValidirajStavku(out List<string> greske))
            {
                MessageBox.Show(string.Join("\n", greske), "Грешке при уносу ставке", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selektovaniTip = (TipClanarine)cmbMembershipType.SelectedItem!;
                int trajanje = (int)numTrajanjeUNedeljama.Value;
                float iznosStavke = (float)(trajanje * selektovaniTip.Cena);

                StavkaEvidencijeClanarine stavka = new StavkaEvidencijeClanarine
                {
                    TrajanjeUNedeljama = trajanje,
                    Cena = (float)selektovaniTip.Cena,
                    IznosStavke = iznosStavke,
                    NacinPlacanja = (NacinPlacanja)cmbNacinPlacanja.SelectedValue!,
                    StatusUplate = (StatusUplate)cmbStatusUplate.SelectedValue!,
                    IdTipClanarine = selektovaniTip.IdTipClanarine,
                    TipClanarine = selektovaniTip,
                    DatumKreiranja = DateTime.Now
                };

                stavke.Add(stavka);
                AzurirajPrikazStavki();
                AzurirajUkupanIznos();
                AzurirajDatumZavrsetka();
                OcistiPoljaStavke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при додавању ставке: {ex.Message}");
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidirajEvidenciju(out List<string> greske))
                {
                    MessageBox.Show(string.Join("\n", greske), "Грешке при креирању евиденције", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Trener selektovaniTrener = (Trener)cmbTrainer.SelectedItem!;
                Clan selektovaniClan = (Clan)cmbMember.SelectedItem!;

                if (selektovaniTrener == null || selektovaniClan == null)
                {
                    MessageBox.Show("Морате одабрати тренера и члана!");
                    return;
                }

                EvidencijaClanarine evidencija = new EvidencijaClanarine
                {
                    DatumPocetka = dtpDatumPocetka.Value,
                    DatumZavrsetka = DateTime.Parse(txtDatumZavrsetka.Text),
                    StatusEvidencije = StatusEvidencije.Aktivan,
                    UkupanIznos = stavke.Sum(s => s.IznosStavke),
                    Komentar = "",
                    IdClan = selektovaniClan.IdClan,
                    IdTrener = selektovaniTrener.IdTrener,
                    StavkeEvidencijeClanarine = stavke
                };

                Response response = Communication.Instance.KreirajEvidencijaClanarine(evidencija);

                if (response.ExceptionMessage == null)
                {
                    MessageBox.Show("Систем је запамтио евиденцију чланарине.");
                    ResetujFormu();
                }
                else
                {

                    MessageBox.Show($"Систем не може да креира евиденцију чланарине");
                    //MessageBox.Show($"Грешка: {response.ExceptionMessage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Систем не може да креира евиденцију чланарине");
                //MessageBox.Show($"Грешка при креирању: {ex.Message}");
            }
        }

        private bool ValidirajEvidenciju(out List<string> greske)
        {
            greske = new List<string>();

            if (cmbTrainer.SelectedItem == null)
                greske.Add("Морате изабрати тренера.");

            if (cmbMember.SelectedItem == null)
                greske.Add("Морате изабрати члана.");

            if (stavke.Count == 0)
                greske.Add("Евиденција мора да садржи бар једну ставку.");

            return greske.Count == 0;
        }
        private bool ValidirajStavku(out List<string> greske)
        {
            greske = new List<string>();

            if (cmbMembershipType.SelectedItem == null)
                greske.Add("Морате изабрати тип чланарине.");

            if (numTrajanjeUNedeljama.Value <= 0)
                greske.Add("Трајање мора бити веће од 0.");

            if (cmbNacinPlacanja.SelectedItem == null)
                greske.Add("Морате изабрати начин плаћања.");

            if (cmbStatusUplate.SelectedItem == null)
                greske.Add("Морате изабрати статус уплате.");

            return greske.Count == 0;
        }
        private void OcistiPoljaStavke() => numTrajanjeUNedeljama.Value = 1;
        private void BtnReset_Click(object sender, EventArgs e) => ResetujFormu();
        private void ResetujFormu()
        {
            try
            {
                stavke.Clear();
                dataTableStavke.Rows.Clear();

                cmbTrainer.SelectedIndex = -1;
                cmbMember.SelectedIndex = -1;
                cmbMembershipType.SelectedIndex = -1;
                cmbNacinPlacanja.SelectedIndex = -1;
                cmbStatusUplate.SelectedIndex = -1;

                numTrajanjeUNedeljama.Value = 1;

                txtCena.Text = "0";
                txtUkupanIznos.Text = "0";

                dtpDatumPocetka.Value = DateTime.Today;
                txtDatumZavrsetka.Text = "";

                cmbTrainer.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при ресетовању форме: {ex.Message}");
            }
        }
    }
}
