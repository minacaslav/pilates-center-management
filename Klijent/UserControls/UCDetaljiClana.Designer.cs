namespace Client.UserControls
{
    partial class UCDetaljiClana
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxOsnovniPodaci;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtJMBG;
        private DateTimePicker dtpDatumRodjenja;

        private GroupBox groupBoxKontaktPodaci;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAdresa;
        private TextBox txtTelefon;
        private TextBox txtEmail;

        private GroupBox groupBoxStatus;
        private Label label8;
        private Label label9;
        private ComboBox cmbStatus;
        private ComboBox cmbTipClana;

        private Button btnSacuvaj;
        private Button btnOdustani;
        private Button btnObrisi;
        private Label lblIdClan;

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
            groupBoxOsnovniPodaci = new GroupBox();
            dtpDatumRodjenja = new DateTimePicker();
            label4 = new Label();
            txtJMBG = new TextBox();
            label3 = new Label();
            txtPrezime = new TextBox();
            label2 = new Label();
            txtIme = new TextBox();
            label1 = new Label();
            groupBoxKontaktPodaci = new GroupBox();
            txtEmail = new TextBox();
            label7 = new Label();
            txtTelefon = new TextBox();
            label6 = new Label();
            txtAdresa = new TextBox();
            label5 = new Label();
            groupBoxStatus = new GroupBox();
            cmbTipClana = new ComboBox();
            label9 = new Label();
            cmbStatus = new ComboBox();
            label8 = new Label();
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            btnObrisi = new Button();
            lblIdClan = new Label();
            groupBoxOsnovniPodaci.SuspendLayout();
            groupBoxKontaktPodaci.SuspendLayout();
            groupBoxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOsnovniPodaci
            // 
            groupBoxOsnovniPodaci.Controls.Add(dtpDatumRodjenja);
            groupBoxOsnovniPodaci.Controls.Add(label4);
            groupBoxOsnovniPodaci.Controls.Add(txtJMBG);
            groupBoxOsnovniPodaci.Controls.Add(label3);
            groupBoxOsnovniPodaci.Controls.Add(txtPrezime);
            groupBoxOsnovniPodaci.Controls.Add(label2);
            groupBoxOsnovniPodaci.Controls.Add(txtIme);
            groupBoxOsnovniPodaci.Controls.Add(label1);
            groupBoxOsnovniPodaci.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxOsnovniPodaci.Location = new Point(18, 30);
            groupBoxOsnovniPodaci.Margin = new Padding(3, 2, 3, 2);
            groupBoxOsnovniPodaci.Name = "groupBoxOsnovniPodaci";
            groupBoxOsnovniPodaci.Padding = new Padding(3, 2, 3, 2);
            groupBoxOsnovniPodaci.Size = new Size(401, 135);
            groupBoxOsnovniPodaci.TabIndex = 0;
            groupBoxOsnovniPodaci.TabStop = false;
            groupBoxOsnovniPodaci.Text = "Основни подаци";
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(176, 106);
            dtpDatumRodjenja.Margin = new Padding(3, 2, 3, 2);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(219, 23);
            dtpDatumRodjenja.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(18, 109);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 6;
            label4.Text = "Датум рођења:";
            // 
            // txtJMBG
            // 
            txtJMBG.Location = new Point(176, 76);
            txtJMBG.Margin = new Padding(3, 2, 3, 2);
            txtJMBG.Name = "txtJMBG";
            txtJMBG.Size = new Size(219, 23);
            txtJMBG.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(18, 79);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "ЈМБГ:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(176, 46);
            txtPrezime.Margin = new Padding(3, 2, 3, 2);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(219, 23);
            txtPrezime.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(18, 49);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Презиме:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(176, 16);
            txtIme.Margin = new Padding(3, 2, 3, 2);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(219, 23);
            txtIme.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Име:";
            // 
            // groupBoxKontaktPodaci
            // 
            groupBoxKontaktPodaci.Controls.Add(txtEmail);
            groupBoxKontaktPodaci.Controls.Add(label7);
            groupBoxKontaktPodaci.Controls.Add(txtTelefon);
            groupBoxKontaktPodaci.Controls.Add(label6);
            groupBoxKontaktPodaci.Controls.Add(txtAdresa);
            groupBoxKontaktPodaci.Controls.Add(label5);
            groupBoxKontaktPodaci.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxKontaktPodaci.Location = new Point(18, 180);
            groupBoxKontaktPodaci.Margin = new Padding(3, 2, 3, 2);
            groupBoxKontaktPodaci.Name = "groupBoxKontaktPodaci";
            groupBoxKontaktPodaci.Padding = new Padding(3, 2, 3, 2);
            groupBoxKontaktPodaci.Size = new Size(401, 112);
            groupBoxKontaktPodaci.TabIndex = 1;
            groupBoxKontaktPodaci.TabStop = false;
            groupBoxKontaktPodaci.Text = "Контакт подаци";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(176, 83);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(18, 86);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 4;
            label7.Text = "Е-пошта:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(176, 53);
            txtTelefon.Margin = new Padding(3, 2, 3, 2);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(219, 23);
            txtTelefon.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(18, 56);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 2;
            label6.Text = "Контакт телефон:";
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(176, 23);
            txtAdresa.Margin = new Padding(3, 2, 3, 2);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(219, 23);
            txtAdresa.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(18, 26);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 0;
            label5.Text = "Адреса:";
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Controls.Add(cmbTipClana);
            groupBoxStatus.Controls.Add(label9);
            groupBoxStatus.Controls.Add(cmbStatus);
            groupBoxStatus.Controls.Add(label8);
            groupBoxStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxStatus.Location = new Point(18, 296);
            groupBoxStatus.Margin = new Padding(3, 2, 3, 2);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Padding = new Padding(3, 2, 3, 2);
            groupBoxStatus.Size = new Size(401, 87);
            groupBoxStatus.TabIndex = 2;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Статус и тип";
            // 
            // cmbTipClana
            // 
            cmbTipClana.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipClana.Location = new Point(176, 46);
            cmbTipClana.Margin = new Padding(3, 2, 3, 2);
            cmbTipClana.Name = "cmbTipClana";
            cmbTipClana.Size = new Size(219, 23);
            cmbTipClana.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(18, 49);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 2;
            label9.Text = "Тип члана:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(176, 19);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(219, 23);
            cmbStatus.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(18, 22);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 0;
            label8.Text = "Статус:";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(314, 398);
            btnSacuvaj.Margin = new Padding(3, 2, 3, 2);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(105, 26);
            btnSacuvaj.TabIndex = 9;
            btnSacuvaj.Text = "Сачувај промене";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(132, 398);
            btnOdustani.Margin = new Padding(3, 2, 3, 2);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(105, 26);
            btnOdustani.TabIndex = 10;
            btnOdustani.Text = "Одустани";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(18, 398);
            btnObrisi.Margin = new Padding(3, 2, 3, 2);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(105, 26);
            btnObrisi.TabIndex = 11;
            btnObrisi.Text = "Обриши";
            btnObrisi.UseVisualStyleBackColor = true;
            // 
            // lblIdClan
            // 
            lblIdClan.AutoSize = true;
            lblIdClan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIdClan.Location = new Point(18, 8);
            lblIdClan.Name = "lblIdClan";
            lblIdClan.Size = new Size(59, 15);
            lblIdClan.TabIndex = 3;
            lblIdClan.Text = "ID члана:";
            // 
            // UCDetaljiClana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblIdClan);
            Controls.Add(btnObrisi);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(groupBoxStatus);
            Controls.Add(groupBoxKontaktPodaci);
            Controls.Add(groupBoxOsnovniPodaci);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCDetaljiClana";
            Size = new Size(438, 435);
            groupBoxOsnovniPodaci.ResumeLayout(false);
            groupBoxOsnovniPodaci.PerformLayout();
            groupBoxKontaktPodaci.ResumeLayout(false);
            groupBoxKontaktPodaci.PerformLayout();
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
