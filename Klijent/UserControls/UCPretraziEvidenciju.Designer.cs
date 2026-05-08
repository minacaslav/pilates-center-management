namespace Client.UserControls
{
    partial class UCPretraziEvidenciju
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cmbTipPretrage;
        private ComboBox cmbTrener;
        private ComboBox cmbTipClanarine;
        private ComboBox cmbStatus;
        private TextBox txtImeClana;
        private TextBox txtPrezimeClana;
        private TextBox txtEmailClana;
        private Button btnPretrazi;
        private Button btnResetuj;
        private Button btnPretraziClanove;
        private Button btnDetaljnaPretraga;
        private DataGridView dgvEvidencije;
        private DateTimePicker dtpDatumOd;
        private DateTimePicker dtpDatumDo;
        private Label lblRezultati;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;

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
            cmbTipPretrage = new ComboBox();
            cmbTrener = new ComboBox();
            cmbTipClanarine = new ComboBox();
            cmbStatus = new ComboBox();
            btnPretrazi = new Button();
            btnResetuj = new Button();
            btnDetaljnaPretraga = new Button();
            dgvEvidencije = new DataGridView();
            dtpDatumOd = new DateTimePicker();
            dtpDatumDo = new DateTimePicker();
            lblRezultati = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtImeClana = new TextBox();
            txtPrezimeClana = new TextBox();
            txtEmailClana = new TextBox();
            btnPretraziClanove = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvEvidencije).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // cmbTipPretrage
            // 
            cmbTipPretrage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipPretrage.Location = new Point(150, 20);
            cmbTipPretrage.Name = "cmbTipPretrage";
            cmbTipPretrage.Size = new Size(200, 28);
            cmbTipPretrage.TabIndex = 0;
            // 
            // cmbTrener
            // 
            cmbTrener.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrener.Enabled = false;
            cmbTrener.Location = new Point(46, 35);
            cmbTrener.Name = "cmbTrener";
            cmbTrener.Size = new Size(321, 28);
            cmbTrener.TabIndex = 1;
            // 
            // cmbTipClanarine
            // 
            cmbTipClanarine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipClanarine.Enabled = false;
            cmbTipClanarine.Location = new Point(46, 33);
            cmbTipClanarine.Name = "cmbTipClanarine";
            cmbTipClanarine.Size = new Size(321, 28);
            cmbTipClanarine.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Enabled = false;
            cmbStatus.Location = new Point(829, 183);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 28);
            cmbStatus.TabIndex = 16;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(20, 285);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(200, 30);
            btnPretrazi.TabIndex = 5;
            btnPretrazi.Text = "Претражи";
            // 
            // btnResetuj
            // 
            btnResetuj.Location = new Point(235, 285);
            btnResetuj.Name = "btnResetuj";
            btnResetuj.Size = new Size(100, 30);
            btnResetuj.TabIndex = 13;
            btnResetuj.Text = "Ресетуј";
            // 
            // btnDetaljnaPretraga
            // 
            btnDetaljnaPretraga.Enabled = false;
            btnDetaljnaPretraga.Location = new Point(829, 223);
            btnDetaljnaPretraga.Name = "btnDetaljnaPretraga";
            btnDetaljnaPretraga.Size = new Size(200, 30);
            btnDetaljnaPretraga.TabIndex = 17;
            btnDetaljnaPretraga.Text = "Претражи по евиденцији";
            btnDetaljnaPretraga.Click += btnDetaljnaPretraga_Click;
            // 
            // dgvEvidencije
            // 
            dgvEvidencije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvidencije.ColumnHeadersHeight = 29;
            dgvEvidencije.Location = new Point(20, 321);
            dgvEvidencije.Name = "dgvEvidencije";
            dgvEvidencije.ReadOnly = true;
            dgvEvidencije.RowHeadersWidth = 51;
            dgvEvidencije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvidencije.Size = new Size(1048, 254);
            dgvEvidencije.TabIndex = 6;
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Checked = false;
            dtpDatumOd.Enabled = false;
            dtpDatumOd.Location = new Point(829, 103);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.ShowCheckBox = true;
            dtpDatumOd.Size = new Size(200, 27);
            dtpDatumOd.TabIndex = 14;
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Checked = false;
            dtpDatumDo.Enabled = false;
            dtpDatumDo.Location = new Point(829, 143);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.ShowCheckBox = true;
            dtpDatumDo.Size = new Size(200, 27);
            dtpDatumDo.TabIndex = 15;
            // 
            // lblRezultati
            // 
            lblRezultati.Location = new Point(908, 285);
            lblRezultati.Name = "lblRezultati";
            lblRezultati.Size = new Size(160, 33);
            lblRezultati.TabIndex = 7;
            lblRezultati.Text = "Пронађено записа: 0";
            lblRezultati.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 8;
            label1.Text = "Претрага по:";
            // 
            // label6
            // 
            label6.Location = new Point(729, 106);
            label6.Name = "label6";
            label6.Size = new Size(90, 24);
            label6.TabIndex = 18;
            label6.Text = "Датум од:";
            // 
            // label7
            // 
            label7.Location = new Point(729, 146);
            label7.Name = "label7";
            label7.Size = new Size(90, 24);
            label7.TabIndex = 19;
            label7.Text = "Датум до:";
            // 
            // label8
            // 
            label8.Location = new Point(729, 186);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 20;
            label8.Text = "Статус:";
            // 
            // txtImeClana
            // 
            txtImeClana.Location = new Point(534, 108);
            txtImeClana.Name = "txtImeClana";
            txtImeClana.Size = new Size(150, 27);
            txtImeClana.TabIndex = 18;
            // 
            // txtPrezimeClana
            // 
            txtPrezimeClana.Location = new Point(534, 148);
            txtPrezimeClana.Name = "txtPrezimeClana";
            txtPrezimeClana.Size = new Size(150, 27);
            txtPrezimeClana.TabIndex = 19;
            // 
            // txtEmailClana
            // 
            txtEmailClana.Location = new Point(534, 188);
            txtEmailClana.Name = "txtEmailClana";
            txtEmailClana.Size = new Size(150, 27);
            txtEmailClana.TabIndex = 20;
            // 
            // btnPretraziClanove
            // 
            btnPretraziClanove.Location = new Point(521, 228);
            btnPretraziClanove.Name = "btnPretraziClanove";
            btnPretraziClanove.Size = new Size(163, 30);
            btnPretraziClanove.TabIndex = 21;
            btnPretraziClanove.Text = "Претражи по члану";
            // 
            // label9
            // 
            label9.Location = new Point(454, 111);
            label9.Name = "label9";
            label9.Size = new Size(70, 24);
            label9.TabIndex = 22;
            label9.Text = "Име:";
            // 
            // label10
            // 
            label10.Location = new Point(6, 81);
            label10.Name = "label10";
            label10.Size = new Size(82, 24);
            label10.TabIndex = 23;
            label10.Text = "Презиме:";
            // 
            // label11
            // 
            label11.Location = new Point(454, 191);
            label11.Name = "label11";
            label11.Size = new Size(70, 24);
            label11.TabIndex = 24;
            label11.Text = "Е-пошта:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(440, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 198);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Члан:";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(713, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(346, 198);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Евиденција чланарине:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbTrener);
            groupBox3.Location = new Point(20, 71);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(403, 90);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Тренер:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cmbTipClanarine);
            groupBox4.Location = new Point(20, 178);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(403, 90);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Тип чланарине:";
            // 
            // UCPretraziEvidenciju
            // 
            Controls.Add(cmbTipPretrage);
            Controls.Add(cmbStatus);
            Controls.Add(btnPretrazi);
            Controls.Add(btnResetuj);
            Controls.Add(btnDetaljnaPretraga);
            Controls.Add(dgvEvidencije);
            Controls.Add(dtpDatumOd);
            Controls.Add(dtpDatumDo);
            Controls.Add(lblRezultati);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtImeClana);
            Controls.Add(txtPrezimeClana);
            Controls.Add(txtEmailClana);
            Controls.Add(btnPretraziClanove);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Name = "UCPretraziEvidenciju";
            Size = new Size(1090, 643);
            ((System.ComponentModel.ISupportInitialize)dgvEvidencije).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}
