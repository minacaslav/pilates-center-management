namespace Client.UserControls
{
    partial class UCKreirajClana
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtAdresa;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private TextBox txtJMBG;
        private ComboBox cmbStatus;
        private ComboBox cmbTipClana;
        private DateTimePicker dtpDatumRodjenja;
        private Button btnSacuvaj;
        private Button btnOcisti;
        private Button btnNazad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtAdresa = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            txtJMBG = new TextBox();
            cmbStatus = new ComboBox();
            cmbTipClana = new ComboBox();
            dtpDatumRodjenja = new DateTimePicker();
            btnSacuvaj = new Button();
            btnOcisti = new Button();
            btnNazad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(50, 43);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Име:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(50, 72);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Презиме:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(50, 136);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Датум рођења:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(50, 165);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Адреса:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(50, 201);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 4;
            label5.Text = "Контакт телефон:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(50, 233);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 5;
            label6.Text = "Е-пошта:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Location = new Point(50, 270);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 6;
            label7.Text = "Статус:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(50, 313);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 7;
            label8.Text = "Тип члана:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Location = new Point(50, 101);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 8;
            label9.Text = "JMBG:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(160, 43);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(200, 23);
            txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(160, 72);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(200, 23);
            txtPrezime.TabIndex = 1;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(160, 165);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(200, 23);
            txtAdresa.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(160, 198);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 23);
            txtTelefon.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 233);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtJMBG
            // 
            txtJMBG.Location = new Point(160, 101);
            txtJMBG.Name = "txtJMBG";
            txtJMBG.Size = new Size(200, 23);
            txtJMBG.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(160, 270);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 23);
            cmbStatus.TabIndex = 6;
            // 
            // cmbTipClana
            // 
            cmbTipClana.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipClana.Location = new Point(160, 310);
            cmbTipClana.Name = "cmbTipClana";
            cmbTipClana.Size = new Size(200, 23);
            cmbTipClana.TabIndex = 7;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(160, 136);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(200, 23);
            dtpDatumRodjenja.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(50, 360);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(100, 30);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Сачувај";
            // 
            // btnOcisti
            // 
            btnOcisti.Location = new Point(160, 360);
            btnOcisti.Name = "btnOcisti";
            btnOcisti.Size = new Size(100, 30);
            btnOcisti.TabIndex = 9;
            btnOcisti.Text = "Очисти";
            // 
            // btnNazad
            // 
            btnNazad.Location = new Point(270, 360);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(90, 30);
            btnNazad.TabIndex = 10;
            btnNazad.Text = "Назад";
            // 
            // UCKreirajClana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNazad);
            Controls.Add(btnOcisti);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbTipClana);
            Controls.Add(cmbStatus);
            Controls.Add(txtJMBG);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdresa);
            Controls.Add(dtpDatumRodjenja);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCKreirajClana";
            Size = new Size(511, 476);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
