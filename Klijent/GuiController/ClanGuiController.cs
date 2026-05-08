using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System.Data;
using Status = Common.Domain.Status;

namespace Client.GuiController
{
    public class ClanGuiController
    {
        private UCPretraziClanove pretraziUC;
        private UCKreirajClana kreirajUC;
        private UCDetaljiClana detaljiUC;
        private DataTable dataTableClanovi;
        private List<Clan> clanovi;
        private List<TipClana> tipoviClanova;
        private Clan trenutniClan;
        internal Control CreateKreirajClanaPanel()
        {
            kreirajUC = new UCKreirajClana();
            UcitajPodatkeZaKreiranje();
            PostaviEventHandlersZaKreiranje();
            return kreirajUC;
        }

        internal Control CreatePretraziClanovePanel()
        {
            pretraziUC = new UCPretraziClanove();
            InicijalizujTabeluZaPrikazClanova();
            UcitajPodatkeZaFiltere();
            PostaviEventHandlersZaPretragu();
            return pretraziUC;
        }

        internal Control CreateDetaljiClanaPanel(Clan clan)
        {
            detaljiUC = new UCDetaljiClana();
            trenutniClan = clan;
            UcitajPodatkeZaDetalje();
            PostaviEventHandlersZaDetalje();
            return detaljiUC;
        }


        #region Kreiranje Clana
        private void UcitajPodatkeZaKreiranje()
        {
            try
            {
                Response tipoviResponse = Communication.Instance.VratiListuSviTipClana();
                tipoviClanova = (List<TipClana>)tipoviResponse.Result;
                kreirajUC.CmbTipClana.DataSource = tipoviClanova;
                kreirajUC.CmbTipClana.DisplayMember = "Naziv";
                kreirajUC.CmbTipClana.ValueMember = "IdTipClana";

                kreirajUC.CmbStatus.Items.AddRange(new string[] { "Aktivan", "Neaktivan", "Suspendovan" });
                kreirajUC.CmbStatus.SelectedIndex = 0;
                kreirajUC.DtpDatumRodjenja.Value = DateTime.Now.AddYears(-18);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при учитавању података: {ex.Message}");
            }
        }

        private void PostaviEventHandlersZaKreiranje()
        {
            kreirajUC.BtnSacuvaj.Click += OnSacuvajClana!;
            kreirajUC.BtnOcisti.Click += OnOcistiFormu!;
            kreirajUC.BtnNazad.Click += OnNazadSaKreiranja!;
        }

        private void OnSacuvajClana(object sender, EventArgs e)
        {
            if (!ValidirajUnos())
                return;

            try
            {
                TipClana tipClana = (TipClana)kreirajUC.CmbTipClana.SelectedItem!;

                var noviClan = new Clan
                {
                    Ime = kreirajUC.TxtIme.Text.Trim(),
                    Prezime = kreirajUC.TxtPrezime.Text.Trim(),
                    JMBG = kreirajUC.TxtJMBG.Text.Trim(),
                    DatumRodjenja = DateOnly.FromDateTime(kreirajUC.DtpDatumRodjenja.Value),
                    Adresa = kreirajUC.TxtAdresa.Text.Trim(),
                    KontaktTelefon = kreirajUC.TxtTelefon.Text.Trim(),
                    Email = kreirajUC.TxtEmail.Text.Trim(),
                    Status = (Common.Domain.Status)kreirajUC.CmbStatus.SelectedIndex,
                    TipClana = (TipClana)kreirajUC.CmbTipClana.SelectedItem!,
                    IdTipClana = tipClana.IdTipClana
                };

                Response response = Communication.Instance.KreirajClan(noviClan);

                MessageBox.Show($"Систем је запамтио члана.",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //MessageBox.Show($"Члан {noviClan.Ime} {noviClan.Prezime} је успешно креиран!","Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnOcistiFormu(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Систем не може да креира члана", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show($"Грешка при креирању члана: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidirajUnos()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(kreirajUC.TxtIme.Text))
            {
                kreirajUC.TxtIme.BackColor = Color.FromArgb(255, 200, 200);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(kreirajUC.TxtPrezime.Text))
            {
                kreirajUC.TxtPrezime.BackColor = Color.FromArgb(255, 200, 200);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(kreirajUC.TxtJMBG.Text))
            {
                kreirajUC.TxtJMBG.BackColor = Color.FromArgb(255, 200, 200);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(kreirajUC.TxtTelefon.Text))
            {
                kreirajUC.TxtTelefon.BackColor = Color.FromArgb(255, 200, 200);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(kreirajUC.TxtAdresa.Text))
            {
                kreirajUC.TxtAdresa.BackColor = Color.FromArgb(255, 200, 200);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(kreirajUC.TxtEmail.Text) || !kreirajUC.TxtEmail.Text.Contains("@"))
            {
                kreirajUC.TxtEmail.BackColor = Color.FromArgb(255, 200, 200);
                valid = false;
            }

            if (kreirajUC.DtpDatumRodjenja.Value > DateTime.Now.AddYears(-16))
            {
                MessageBox.Show("Члан мора имати најмање 16 година");
                valid = false;
            }
            return valid;
        }

        private void OnOcistiFormu(object sender, EventArgs e)
        {
            kreirajUC.TxtIme.Text = "";
            kreirajUC.TxtPrezime.Text = "";
            kreirajUC.TxtAdresa.Text = "";
            kreirajUC.TxtTelefon.Text = "";
            kreirajUC.TxtEmail.Text = "";

            kreirajUC.TxtIme.BackColor = Color.White;
            kreirajUC.TxtPrezime.BackColor = Color.White;
            kreirajUC.TxtEmail.BackColor = Color.White;
            kreirajUC.TxtJMBG.BackColor = Color.White;
            kreirajUC.TxtAdresa.BackColor = Color.White;
            kreirajUC.TxtTelefon.BackColor = Color.White;

            kreirajUC.DtpDatumRodjenja.Value = DateTime.Now.AddYears(-18);
            kreirajUC.CmbStatus.SelectedIndex = 0;
            if (kreirajUC.CmbTipClana.Items.Count > 0)
                kreirajUC.CmbTipClana.SelectedIndex = 0;
        }
        private void OnKreirajNovogClana(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowKreirajClana();
        }
        private void OnNazadSaKreiranja(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowPretraziClanove();
        }
        #endregion

        #region Pretraga Clanova
        private void InicijalizujTabeluZaPrikazClanova()
        {
            dataTableClanovi = new DataTable();

            dataTableClanovi.Columns.Add("ID", typeof(int));
            dataTableClanovi.Columns.Add("Име", typeof(string));
            dataTableClanovi.Columns.Add("Презиме", typeof(string));
            dataTableClanovi.Columns.Add("Е-пошта", typeof(string));
            dataTableClanovi.Columns.Add("Телефон", typeof(string));
            dataTableClanovi.Columns.Add("Тип члана", typeof(string));
            dataTableClanovi.Columns.Add("Статус", typeof(string));
            dataTableClanovi.Columns.Add("Адреса", typeof(string));

            pretraziUC.DgvClanovi.DataSource = dataTableClanovi;
        }

        private void UcitajPodatkeZaFiltere()
        {
            try
            {
                Response tipoviResponse = Communication.Instance.VratiListuSviTipClana();
                pretraziUC.CmbTipClana.DataSource = (List<TipClana>)tipoviResponse.Result;
                pretraziUC.CmbTipClana.DisplayMember = "Naziv";
                pretraziUC.CmbTipClana.ValueMember = "IdTipClana";

                pretraziUC.CmbStatus.Items.AddRange(new string[]
                {
                    "Сви статуси",
                    "Активан",
                    "Неактиван",
                    "Суспендован"
                });
                pretraziUC.CmbStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при учитавању података: {ex.Message}");
            }
        }

        private void PostaviEventHandlersZaPretragu()
        {
            pretraziUC.BtnPretrazi.Click += OnPretraziClanove!;
            pretraziUC.BtnResetuj.Click += OnResetujPretragu!;
            pretraziUC.BtnKreirajNovog.Click += OnKreirajNovogClana!;
            pretraziUC.DgvClanovi.CellDoubleClick += OnDupliKlikNaTabeli!;
        }

        private void OnPretraziClanove(object sender, EventArgs e)
        {
            try
            {
                var kriterijum = new Clan
                {
                    Ime = pretraziUC.TxtIme.Text.Trim(),
                    Prezime = pretraziUC.TxtPrezime.Text.Trim(),
                    Email = pretraziUC.TxtEmail.Text.Trim()
                };

                //tip clana
                if (pretraziUC.CmbTipClana.SelectedItem is TipClana tipClana)
                {
                    kriterijum.TipClana = tipClana;
                    kriterijum.IdTipClana = tipClana.IdTipClana;
                }
                else
                {
                    kriterijum.IdTipClana = 0;
                }

                //status
                if (pretraziUC.CmbStatus.SelectedIndex > 0)
                {
                    kriterijum.Status = (Common.Domain.Status)(pretraziUC.CmbStatus.SelectedIndex - 1);
                }

                Response response = Communication.Instance.VratiListuSviClanPoKriterijumu(kriterijum);

                if (response.ExceptionMessage == null)
                {
                    clanovi = (List<Clan>)response.Result;
                    PopuniTabeluClanovima(clanovi);

                    if (clanovi.Count == 0)
                    {
                        MessageBox.Show("Систем не може да нађе чланови по задатим критеријумима", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Нема пронађених чланова по задатим критеријумима","Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Систем је нашао чланове по задатим критеријумима", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show($"Систем је нашао {clanovi.Count} чланова по задатим критеријумима", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Систем не може да нађе чланови по задатим критеријумима", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //MessageBox.Show($"Грешка при претрази: {response.ExceptionMessage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Систем не може да нађе чланови по задатим критеријумима", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //MessageBox.Show($"Грешка при претрази: {ex.Message}");
            }
        }

        private void PopuniTabeluClanovima(List<Clan> listaClanova)
        {
            dataTableClanovi.Rows.Clear();

            foreach (var clan in listaClanova)
            {
                dataTableClanovi.Rows.Add(
                    clan.IdClan,
                    clan.Ime,
                    clan.Prezime,
                    clan.Email,
                    clan.KontaktTelefon,
                    clan.TipClana?.Naziv ?? "",
                    clan.Status.ToString(),
                    clan.Adresa
                );
            }

            pretraziUC.LblRezultati.Text = $"Пронађено записа: {listaClanova.Count}";
        }

        private void OnResetujPretragu(object sender, EventArgs e)
        {
            pretraziUC.TxtIme.Text = "";
            pretraziUC.TxtPrezime.Text = "";
            pretraziUC.TxtEmail.Text = "";
            pretraziUC.CmbTipClana.SelectedIndex = -1;
            pretraziUC.CmbStatus.SelectedIndex = 0;
            dataTableClanovi.Rows.Clear();
            pretraziUC.LblRezultati.Text = "Пронађено записа: 0";
            clanovi = null!;
        }
        private void OnDupliKlikNaTabeli(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < pretraziUC.DgvClanovi.Rows.Count)
            {
                var selectedRow = pretraziUC.DgvClanovi.Rows[e.RowIndex];
                int idClana = (int)selectedRow.Cells["ID"].Value;

                var clan = clanovi?.FirstOrDefault(c => c.IdClan == idClana);
                if (clan != null)
                {
                    MessageBox.Show($"Систем је нашао члана", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainCoordinator.Instance.ShowDetaljiClana(clan);
                    //*
                }
                else
                {
                    MessageBox.Show("Систем не може да нађе члана.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Detalji Clana
        private void UcitajPodatkeZaDetalje()
        {
            try
            {
                Response tipoviResponse = Communication.Instance.VratiListuSviTipClana();
                var tipoviClanova = (List<TipClana>)tipoviResponse.Result;

                detaljiUC.CmbTipClana.DataSource = tipoviClanova;
                detaljiUC.CmbTipClana.DisplayMember = "Naziv";
                detaljiUC.CmbTipClana.ValueMember = "IdTipClana";

                detaljiUC.CmbStatus.Items.AddRange(new string[] {
                    "Aktivan", "Neaktivan", "Suspendovan"
                });

                if (trenutniClan != null)
                {
                    detaljiUC.LblIdClan.Text = $"ID члана: {trenutniClan.IdClan}";
                    detaljiUC.TxtIme.Text = trenutniClan.Ime;
                    detaljiUC.TxtPrezime.Text = trenutniClan.Prezime;
                    detaljiUC.TxtJMBG.Text = trenutniClan.JMBG;
                    detaljiUC.DtpDatumRodjenja.Value = trenutniClan.DatumRodjenja.ToDateTime(TimeOnly.MinValue);
                    detaljiUC.TxtAdresa.Text = trenutniClan.Adresa;
                    detaljiUC.TxtTelefon.Text = trenutniClan.KontaktTelefon;
                    detaljiUC.TxtEmail.Text = trenutniClan.Email;
                    detaljiUC.CmbStatus.SelectedIndex = (int)trenutniClan.Status;

                    foreach (TipClana tip in detaljiUC.CmbTipClana.Items)
                    {
                        if (tip.IdTipClana == trenutniClan.IdTipClana)
                        {
                            detaljiUC.CmbTipClana.SelectedItem = tip;
                            break;
                        }
                    }

                    detaljiUC.TxtJMBG.Enabled = false;
                    detaljiUC.TxtJMBG.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при учитавању података: {ex.Message}");
            }
        }

        private void PostaviEventHandlersZaDetalje()
        {
            detaljiUC.BtnSacuvaj.Click += OnSacuvajPromene!;
            detaljiUC.BtnOdustani.Click += OnOdustani!;
            detaljiUC.BtnObrisi.Click += OnObrisiClana!;

            detaljiUC.TxtIme.TextChanged += OnValidirajPolje!;
            detaljiUC.TxtPrezime.TextChanged += OnValidirajPolje!;
            detaljiUC.TxtEmail.TextChanged += OnValidirajPolje!;
            detaljiUC.TxtTelefon.TextChanged += OnValidirajPolje!;
            detaljiUC.TxtAdresa.TextChanged += OnValidirajPolje!;
        }

        private void OnValidirajPolje(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.BackColor = Color.FromArgb(255, 200, 200);
                }
                else
                {
                    textBox.BackColor = Color.White;
                }
            }
        }

        private void OnSacuvajPromene(object sender, EventArgs e)
        {
            if (!ValidirajDetalje())
                return;

            try
            {
                var tipClana = (TipClana)detaljiUC.CmbTipClana.SelectedItem!;

                trenutniClan.Ime = detaljiUC.TxtIme.Text.Trim();
                trenutniClan.Prezime = detaljiUC.TxtPrezime.Text.Trim();
                trenutniClan.DatumRodjenja = DateOnly.FromDateTime(detaljiUC.DtpDatumRodjenja.Value);
                trenutniClan.Adresa = detaljiUC.TxtAdresa.Text.Trim();
                trenutniClan.KontaktTelefon = detaljiUC.TxtTelefon.Text.Trim();
                trenutniClan.Email = detaljiUC.TxtEmail.Text.Trim();
                trenutniClan.Status = (Status)detaljiUC.CmbStatus.SelectedIndex;
                trenutniClan.TipClana = tipClana;
                trenutniClan.IdTipClana = tipClana.IdTipClana;

                Response response = Communication.Instance.PromeniClan(trenutniClan);

                MessageBox.Show($"Систем је запамтио члана.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show($"Промене за члана {trenutniClan.Ime} {trenutniClan.Prezime} су успешно сачуване!","Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainCoordinator.Instance.ShowPretraziClanove();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Систем не може да запамти члана", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show($"Грешка при чувању промена: {ex.Message}","Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnOdustani(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Да ли сте сигурни да желите да одустанете од промена?",
                "Одустани", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MainCoordinator.Instance.ShowPretraziClanove();
            }
        }

        private void OnObrisiClana(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Да ли сте сигурни да желите да обришете члана {trenutniClan.Ime} {trenutniClan.Prezime}?\n\nОва акција је неповратна!",
                "Брисање члана", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Response response = Communication.Instance.ObrisiClan(trenutniClan);

                    MessageBox.Show($"Систем је обрисао члана.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show($"Члан {trenutniClan.Ime} {trenutniClan.Prezime} је успешно обрисан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainCoordinator.Instance.ShowPretraziClanove();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Систем не може да обрише члана.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show($"{ex.Message}","Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidirajDetalje()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(detaljiUC.TxtIme.Text))
            {
                detaljiUC.TxtIme.BackColor = Color.FromArgb(255, 200, 200);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(detaljiUC.TxtPrezime.Text))
            {
                detaljiUC.TxtPrezime.BackColor = Color.FromArgb(255, 200, 200);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(detaljiUC.TxtTelefon.Text))
            {
                detaljiUC.TxtTelefon.BackColor = Color.FromArgb(255, 200, 200);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(detaljiUC.TxtAdresa.Text))
            {
                detaljiUC.TxtAdresa.BackColor = Color.FromArgb(255, 200, 200);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(detaljiUC.TxtEmail.Text) || !detaljiUC.TxtEmail.Text.Contains("@"))
            {
                detaljiUC.TxtEmail.BackColor = Color.FromArgb(255, 200, 200);
                valid = false;
            }

            if (detaljiUC.DtpDatumRodjenja.Value > DateTime.Now.AddYears(-16))
            {
                MessageBox.Show("Члан мора имати најмање 16 година");
                valid = false;
            }

            if (!valid)
            {
                MessageBox.Show("Молимо попуните сва обавезна поља исправно.",
                    "Неисправни подаци", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return valid;
        }
        #endregion

    }
}