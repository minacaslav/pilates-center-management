namespace Client.UserControls
{
    public partial class UCDetaljiClana : UserControl
    {
        public UCDetaljiClana()
        {
            InitializeComponent();
        }
        public TextBox TxtIme => txtIme;
        public TextBox TxtPrezime => txtPrezime;
        public TextBox TxtJMBG => txtJMBG;
        public DateTimePicker DtpDatumRodjenja => dtpDatumRodjenja;
        public TextBox TxtAdresa => txtAdresa;
        public TextBox TxtTelefon => txtTelefon;
        public TextBox TxtEmail => txtEmail;
        public ComboBox CmbStatus => cmbStatus;
        public ComboBox CmbTipClana => cmbTipClana;
        public Button BtnSacuvaj => btnSacuvaj;
        public Button BtnOdustani => btnOdustani;
        public Button BtnObrisi => btnObrisi;
        public Label LblIdClan => lblIdClan;
    }
}
