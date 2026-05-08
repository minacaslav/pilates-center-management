using Client.GuiController;

namespace Client
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginGuiController.Instance.ShowFrmLogin();
        }
    }
}