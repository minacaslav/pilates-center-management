namespace Client.UserControls
{
    public partial class UCPretraziClanove : UserControl
    {
        public UCPretraziClanove()
        {
            InitializeComponent();
        }
        public TextBox TxtIme => txtIme;
        public TextBox TxtPrezime => txtPrezime;
        public TextBox TxtEmail => txtEmail;
        public ComboBox CmbTipClana => cmbTipClana;
        public ComboBox CmbStatus => cmbStatus;
        public Button BtnPretrazi => btnPretrazi;
        public Button BtnResetuj => btnResetuj;
        public Button BtnKreirajNovog => btnKreirajNovog;
        public DataGridView DgvClanovi => dgvClanovi;
        public Label LblRezultati => lblRezultati;
    }
}
