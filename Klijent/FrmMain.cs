using Client.GuiController;

namespace Client
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            SetupMenuEvents();
            UpdateWelcomeMessage("Добродошли у PilatesApp");
        }

        private void SetupMenuEvents()
        {
            kreirajEvidencijuToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowKreirajEvidenciju();
            toolStripMenuItem1.Click += (s, e) => MainCoordinator.Instance.ShowPretraziEvidencije();

            kreirajClanaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowKreirajClana();
            prikaziClanaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPretraziClanove();

            ubaciTreningToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowUbaciTrening();

            odjaviSeToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.OdjaviSe();
        }

        public void ChangePanel(Control newPanel)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(newPanel);
            newPanel.Dock = DockStyle.Fill;
        }

        public void UpdateWelcomeMessage(string message)
        {
            lblWelcome.Text = message;
        }

        public void UpdateStatus(string status)
        {
            lblStatus.Text = status;
        }

        private void тренингToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void креирајЧланаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
