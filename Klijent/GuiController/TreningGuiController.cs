using Client.UserControls;
using Common.Domain;
using System.Diagnostics;

namespace Client.GuiController
{
    internal class TreningGuiController
    {
        private UCUbaciTrening ucTrening;

        internal Control CreateUbaciTreningPanel()
        {
            ucTrening = new UCUbaciTrening();

            ucTrening.CmbTip.DataSource = Enum.GetValues(typeof(TipTreninga));

            ucTrening.BtnUbaci.Click += KreirajTrening!;

            return ucTrening;
        }

        private void KreirajTrening(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ucTrening.TxtNaziv.Text))
                {
                    MessageBox.Show("Морате унети назив тренинга!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(ucTrening.RtxtOpis.Text))
                {
                    ucTrening.RtxtOpis.Text = "/";
                }

                if (ucTrening.CmbTip.SelectedItem == null)
                {
                    MessageBox.Show("Морате изабрати тип тренинга!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Trening trening = new Trening
                {
                    Naziv = ucTrening.TxtNaziv.Text.Trim(),
                    Opis = ucTrening.RtxtOpis.Text.Trim(),
                    TipTreninga = (TipTreninga)ucTrening.CmbTip.SelectedItem
                };

                Communication.Instance.UbaciTrening(trening);
                MessageBox.Show("Систем је запамтио тренинг.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainCoordinator.Instance.ShowUbaciTrening();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Систем не може да запамти тренинг.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
        }
    }
}