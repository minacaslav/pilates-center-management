using Client.GuiController;

namespace Client
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            btnLogin.Click += LoginGuiController.Instance.Login!;
        }

        public bool Validation()
        {
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;

            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;

            var isValid = true;

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.BackColor = Color.FromArgb(255, 200, 200);
                txtEmail.BorderStyle = BorderStyle.FixedSingle;
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.BackColor = Color.FromArgb(255, 200, 200);
                txtPassword.BorderStyle = BorderStyle.FixedSingle;
                isValid = false;
            }
            return isValid;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
