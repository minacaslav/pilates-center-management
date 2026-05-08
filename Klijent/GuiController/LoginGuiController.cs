using Common.Communication;
using Common.Domain;
using System.Net.Sockets;

namespace Client.GuiController
{
    public class LoginGuiController
    {

        private static LoginGuiController instance;
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGuiController();
                }
                return instance;
            }
        }
        private LoginGuiController()
        {
        }

        private FrmLogin frmLogin;

        internal void ShowFrmLogin()
        {
            try
            {
                if (!Communication.Instance.IsConnected())
                    Communication.Instance.Connect();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                frmLogin = new FrmLogin();
                frmLogin.AutoSize = true;
                Application.Run(frmLogin);
            }
            catch (SocketException)
            {
                MessageBox.Show("Није могуће успоставити комуникацију са сервером, покушајте касније.");
            }
        }

        public void ResetForm()
        {
            if (frmLogin != null)
            {
                frmLogin.TxtEmail.Text = "";
                frmLogin.TxtPassword.Text = "";
                frmLogin.Visible = true;
            }
        }

        public void Login(object sender, EventArgs e)
        {
            if (!frmLogin.Validation())
            {
                MessageBox.Show("Молимо попуните сва поља.");
                return;
            }

            Trener trener = new Trener
            {
                Email = frmLogin.TxtEmail.Text,
                Lozinka = frmLogin.TxtPassword.Text,
            };

            try
            {
                Response response = Communication.Instance.Login(trener);

                if (response == null)
                    throw new Exception();



                if (response.ExceptionMessage == null)
                {
                    MessageBox.Show("Корисничко име и шифра су исправни.",
                              "Потврда",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                    frmLogin.Visible = false;
                    MainCoordinator.Instance.ShowFrmMain();
                }
                else
                {
                    MessageBox.Show("Корисничко име и шифра нису исправни.");
                    //MessageBox.Show(response.ExceptionMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не може да се отвори главна форма и мени.");
                return;
            }
        }
    }
}