namespace Client.UserControls
{
    partial class UCDetaljiEvidencije
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;

        private TextBox txtId;
        private TextBox txtClan;
        private TextBox txtTrener;
        private TextBox txtDatumPocetka;
        private TextBox txtDatumZavrsetka;
        private TextBox txtIznos;

        private ComboBox cmbStatus;
        private TextBox txtKomentar;

        private Button btnIzmeni;
        private Button btnZapamti;
        private Button btnNazad;

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
            txtId = new TextBox();
            txtClan = new TextBox();
            txtTrener = new TextBox();
            txtDatumPocetka = new TextBox();
            txtDatumZavrsetka = new TextBox();
            txtIznos = new TextBox();
            cmbStatus = new ComboBox();
            txtKomentar = new TextBox();
            btnIzmeni = new Button();
            btnZapamti = new Button();
            btnNazad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 0;
            label1.Text = "Детаљи евиденције";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "ID евиденције:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Члан:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 130);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Тренер:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 160);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 4;
            label5.Text = "Датум почетка:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 190);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 5;
            label6.Text = "Датум завршетка:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 220);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 6;
            label7.Text = "Износ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 250);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 7;
            label8.Text = "Статус:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 280);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 8;
            label9.Text = "Коментар:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(150, 67);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 9;
            // 
            // txtClan
            // 
            txtClan.Enabled = false;
            txtClan.Location = new Point(150, 97);
            txtClan.Name = "txtClan";
            txtClan.ReadOnly = true;
            txtClan.Size = new Size(300, 23);
            txtClan.TabIndex = 10;
            // 
            // txtTrener
            // 
            txtTrener.Enabled = false;
            txtTrener.Location = new Point(150, 127);
            txtTrener.Name = "txtTrener";
            txtTrener.ReadOnly = true;
            txtTrener.Size = new Size(300, 23);
            txtTrener.TabIndex = 11;
            // 
            // txtDatumPocetka
            // 
            txtDatumPocetka.Enabled = false;
            txtDatumPocetka.Location = new Point(150, 157);
            txtDatumPocetka.Name = "txtDatumPocetka";
            txtDatumPocetka.ReadOnly = true;
            txtDatumPocetka.Size = new Size(200, 23);
            txtDatumPocetka.TabIndex = 12;
            // 
            // txtDatumZavrsetka
            // 
            txtDatumZavrsetka.Enabled = false;
            txtDatumZavrsetka.Location = new Point(150, 187);
            txtDatumZavrsetka.Name = "txtDatumZavrsetka";
            txtDatumZavrsetka.ReadOnly = true;
            txtDatumZavrsetka.Size = new Size(200, 23);
            txtDatumZavrsetka.TabIndex = 13;
            // 
            // txtIznos
            // 
            txtIznos.Enabled = false;
            txtIznos.Location = new Point(150, 217);
            txtIznos.Name = "txtIznos";
            txtIznos.ReadOnly = true;
            txtIznos.Size = new Size(200, 23);
            txtIznos.TabIndex = 14;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Enabled = false;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(150, 247);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 23);
            cmbStatus.TabIndex = 15;
            // 
            // txtKomentar
            // 
            txtKomentar.Enabled = false;
            txtKomentar.Location = new Point(150, 277);
            txtKomentar.Multiline = true;
            txtKomentar.Name = "txtKomentar";
            txtKomentar.Size = new Size(320, 80);
            txtKomentar.TabIndex = 16;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(150, 380);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(100, 30);
            btnIzmeni.TabIndex = 17;
            btnIzmeni.Text = "Измени";
            // 
            // btnZapamti
            // 
            btnZapamti.Enabled = false;
            btnZapamti.Location = new Point(260, 380);
            btnZapamti.Name = "btnZapamti";
            btnZapamti.Size = new Size(100, 30);
            btnZapamti.TabIndex = 18;
            btnZapamti.Text = "Запамти";
            // 
            // btnNazad
            // 
            btnNazad.Location = new Point(370, 380);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(100, 30);
            btnNazad.TabIndex = 19;
            btnNazad.Text = "Назад";
            // 
            // UCDetaljiEvidencije
            // 
            Controls.Add(btnNazad);
            Controls.Add(btnZapamti);
            Controls.Add(btnIzmeni);
            Controls.Add(txtKomentar);
            Controls.Add(cmbStatus);
            Controls.Add(txtIznos);
            Controls.Add(txtDatumZavrsetka);
            Controls.Add(txtDatumPocetka);
            Controls.Add(txtTrener);
            Controls.Add(txtClan);
            Controls.Add(txtId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCDetaljiEvidencije";
            Size = new Size(1167, 524);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
