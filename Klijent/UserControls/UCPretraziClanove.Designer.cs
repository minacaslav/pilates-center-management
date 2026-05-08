namespace Client.UserControls
{
    partial class UCPretraziClanove
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtEmail;
        private ComboBox cmbTipClana;
        private ComboBox cmbStatus;
        private Button btnPretrazi;
        private Button btnResetuj;
        private Button btnKreirajNovog;
        private DataGridView dgvClanovi;
        private Label lblRezultati;

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
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtEmail = new TextBox();
            cmbTipClana = new ComboBox();
            cmbStatus = new ComboBox();
            btnPretrazi = new Button();
            btnResetuj = new Button();
            btnKreirajNovog = new Button();
            dgvClanovi = new DataGridView();
            lblRezultati = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClanovi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Име:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Презиме:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Е-пошта:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(250, 20);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Тип члана:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(250, 60);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 4;
            label5.Text = "Статус:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(120, 20);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(120, 23);
            txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(120, 60);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(120, 23);
            txtPrezime.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(120, 23);
            txtEmail.TabIndex = 2;
            // 
            // cmbTipClana
            // 
            cmbTipClana.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipClana.Location = new Point(350, 20);
            cmbTipClana.Name = "cmbTipClana";
            cmbTipClana.Size = new Size(150, 23);
            cmbTipClana.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(350, 60);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(150, 23);
            cmbStatus.TabIndex = 4;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(520, 20);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(100, 30);
            btnPretrazi.TabIndex = 5;
            btnPretrazi.Text = "Претражи";
            // 
            // btnResetuj
            // 
            btnResetuj.Location = new Point(520, 60);
            btnResetuj.Name = "btnResetuj";
            btnResetuj.Size = new Size(100, 30);
            btnResetuj.TabIndex = 6;
            btnResetuj.Text = "Ресетуј";
            // 
            // btnKreirajNovog
            // 
            btnKreirajNovog.Location = new Point(520, 100);
            btnKreirajNovog.Name = "btnKreirajNovog";
            btnKreirajNovog.Size = new Size(100, 30);
            btnKreirajNovog.TabIndex = 7;
            btnKreirajNovog.Text = "Креирај новог";
            // 
            // dgvClanovi
            // 
            dgvClanovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClanovi.Location = new Point(20, 150);
            dgvClanovi.Name = "dgvClanovi";
            dgvClanovi.ReadOnly = true;
            dgvClanovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClanovi.Size = new Size(1134, 358);
            dgvClanovi.TabIndex = 8;
            // 
            // lblRezultati
            // 
            lblRezultati.Location = new Point(984, 511);
            lblRezultati.Name = "lblRezultati";
            lblRezultati.Size = new Size(170, 20);
            lblRezultati.TabIndex = 9;
            lblRezultati.Text = "Пронађено записа: 0";
            lblRezultati.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UCPretraziClanove
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblRezultati);
            Controls.Add(dgvClanovi);
            Controls.Add(btnKreirajNovog);
            Controls.Add(btnResetuj);
            Controls.Add(btnPretrazi);
            Controls.Add(cmbStatus);
            Controls.Add(cmbTipClana);
            Controls.Add(txtEmail);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCPretraziClanove";
            Size = new Size(1185, 586);
            ((System.ComponentModel.ISupportInitialize)dgvClanovi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
