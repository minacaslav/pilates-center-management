namespace Client.UserControls
{
    public partial class UCDetaljiEvidencije : UserControl
    {
        public UCDetaljiEvidencije()
        {
            InitializeComponent();
        }
        public TextBox TxtId => txtId;
        public TextBox TxtClan => txtClan;
        public TextBox TxtTrener => txtTrener;
        public TextBox TxtDatumPocetka => txtDatumPocetka;
        public TextBox TxtDatumZavrsetka => txtDatumZavrsetka;
        public TextBox TxtIznos => txtIznos;
        public ComboBox CmbStatus => cmbStatus;
        public TextBox TxtKomentar => txtKomentar;
        public Button BtnIzmeni => btnIzmeni;
        public Button BtnZapamti => btnZapamti;
        public Button BtnNazad => btnNazad;
    }
}

