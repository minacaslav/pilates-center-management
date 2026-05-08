using Common.Domain;

namespace Client.GuiController
{
    internal class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance => instance ??= new MainCoordinator();

        private MainCoordinator()
        {
            evidencijaGuiController = new EvidencijaGuiController();
            clanGuiController = new ClanGuiController();
            treningGuiController = new TreningGuiController();
            //*...
        }

        private FrmMain frmMain;

        private EvidencijaGuiController evidencijaGuiController;
        private ClanGuiController clanGuiController;
        private TreningGuiController treningGuiController;

        internal void ShowFrmMain()
        {
            frmMain = new FrmMain();
            frmMain.AutoSize = true;
            frmMain.ShowDialog();

            LoginGuiController.Instance.ResetForm();
        }
        internal void ShowKreirajEvidenciju()
        {
            frmMain.ChangePanel(evidencijaGuiController.CreateKreirajEvidencijuPanel());
        }

        internal void ShowPretraziEvidencije()
        {
            frmMain.ChangePanel(evidencijaGuiController.CreatePretraziEvidencijePanel());
        }

        internal void ShowKreirajClana()
        {
            frmMain.ChangePanel(clanGuiController.CreateKreirajClanaPanel());
        }

        internal void ShowPretraziClanove()
        {
            frmMain.ChangePanel(clanGuiController.CreatePretraziClanovePanel());
        }
        internal void ShowDetaljiClana(Clan clan)
        {
            frmMain.ChangePanel(clanGuiController.CreateDetaljiClanaPanel(clan));
        }
        internal void ShowUbaciTrening()
        {
            frmMain.ChangePanel(treningGuiController.CreateUbaciTreningPanel());
        }
        internal void ShowDetaljiEvidencije(int idEvidencije)
        {
            frmMain.ChangePanel(evidencijaGuiController.CreateDetaljiEvidencijePanel(idEvidencije));
        }
        internal void OdjaviSe()
        {
            var result = MessageBox.Show("Потврдите одјаву са апликације:",
                                       "Одјава",
                                       MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                frmMain.Close();
            }
        }
    }
}