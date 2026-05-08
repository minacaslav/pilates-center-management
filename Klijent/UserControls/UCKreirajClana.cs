namespace Client.UserControls
{
    public partial class UCKreirajClana : UserControl
    {
        public UCKreirajClana()
        {
            InitializeComponent();
        }
        public TextBox TxtIme => txtIme;
        public TextBox TxtPrezime => txtPrezime;
        public TextBox TxtAdresa => txtAdresa;
        public TextBox TxtTelefon => txtTelefon;
        public TextBox TxtEmail => txtEmail;
        public TextBox TxtJMBG => txtJMBG;
        public ComboBox CmbStatus => cmbStatus;
        public ComboBox CmbTipClana => cmbTipClana;
        public DateTimePicker DtpDatumRodjenja => dtpDatumRodjenja;
        public Button BtnSacuvaj => btnSacuvaj;
        public Button BtnOcisti => btnOcisti;
        public Button BtnNazad => btnNazad;
    }
}
