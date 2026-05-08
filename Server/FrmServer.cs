namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;

        public FrmServer()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            btnStart.BackColor = Color.FromArgb(150, 150, 150);
            btnStop.BackColor = Color.FromArgb(210, 80, 70);

            lblStatus.Text = "Сервер је покренут";
            lblStatus.ForeColor = Color.FromArgb(0, 100, 0);

            //MessageBox.Show("Сервер је покренут!");
            server.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            btnStop.BackColor = Color.FromArgb(150, 150, 150);
            btnStart.BackColor = Color.FromArgb(100, 175, 100);

            lblStatus.Text = "Сервер је заустављен";
            lblStatus.ForeColor = Color.FromArgb(150, 0, 0);

            //MessageBox.Show("Сервер је заустављен!");
            server.Stop();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {

        }
    }
}
