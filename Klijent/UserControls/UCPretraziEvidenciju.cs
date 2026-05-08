namespace Client.UserControls
{
    public partial class UCPretraziEvidenciju : UserControl
    {
        public UCPretraziEvidenciju()
        {
            InitializeComponent();
        }
        public ComboBox CmbTipPretrage => cmbTipPretrage;
        public ComboBox CmbTrener => cmbTrener;
        public ComboBox CmbTipClanarine => cmbTipClanarine;
        public ComboBox CmbStatus => cmbStatus;
        public TextBox TxtImeClana => txtImeClana;
        public TextBox TxtPrezimeClana => txtPrezimeClana;
        public TextBox TxtEmailClana => txtEmailClana;
        public Button BtnPretrazi => btnPretrazi;
        public Button BtnResetuj => btnResetuj;
        public Button BtnPretraziClanove => btnPretraziClanove;
        public Button BtnDetaljnaPretraga => btnDetaljnaPretraga;
        public DataGridView DgvEvidencije => dgvEvidencije;
        public DateTimePicker DtpDatumOd => dtpDatumOd;
        public DateTimePicker DtpDatumDo => dtpDatumDo;
        public Label LblRezultati => lblRezultati;

        private void btnDetaljnaPretraga_Click(object sender, EventArgs e)
        {

        }
    }
}
