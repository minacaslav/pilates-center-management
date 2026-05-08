namespace Client.UserControls
{
    partial class UCkreirajEvidencijaClanarine
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbTrainer = new ComboBox();
            cmbMember = new ComboBox();
            cmbMembershipType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            groupBoxStavke = new GroupBox();
            numTrajanjeUNedeljama = new NumericUpDown();
            cmbNacinPlacanja = new ComboBox();
            cmbStatusUplate = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCena = new TextBox();
            btnDodajStavku = new Button();
            groupBoxPrikazStavki = new GroupBox();
            dgvStavke = new DataGridView();
            label8 = new Label();
            txtUkupanIznos = new TextBox();
            label9 = new Label();
            dtpDatumPocetka = new DateTimePicker();
            label10 = new Label();
            txtDatumZavrsetka = new TextBox();
            groupBoxStavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTrajanjeUNedeljama).BeginInit();
            groupBoxPrikazStavki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // cmbTrainer
            // 
            cmbTrainer.FormattingEnabled = true;
            cmbTrainer.Location = new Point(197, 120);
            cmbTrainer.Name = "cmbTrainer";
            cmbTrainer.Size = new Size(267, 23);
            cmbTrainer.TabIndex = 0;
            // 
            // cmbMember
            // 
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(197, 156);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(267, 23);
            cmbMember.TabIndex = 1;
            // 
            // cmbMembershipType
            // 
            cmbMembershipType.FormattingEnabled = true;
            cmbMembershipType.Location = new Point(197, 214);
            cmbMembershipType.Name = "cmbMembershipType";
            cmbMembershipType.Size = new Size(267, 23);
            cmbMembershipType.TabIndex = 2;
            cmbMembershipType.SelectedIndexChanged += cmbMembershipType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 123);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 3;
            label1.Text = "Изаберите тренера:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 159);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 4;
            label2.Text = "Изаберите члана:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 217);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 5;
            label3.Text = "Изаберите тип чланарине:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(31, 443);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 52);
            btnSave.TabIndex = 6;
            btnSave.Text = "Креирај евиденцију";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(215, 443);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 52);
            btnReset.TabIndex = 11;
            btnReset.Text = "Ресетуј форму";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // groupBoxStavke
            // 
            groupBoxStavke.Controls.Add(numTrajanjeUNedeljama);
            groupBoxStavke.Controls.Add(cmbNacinPlacanja);
            groupBoxStavke.Controls.Add(cmbStatusUplate);
            groupBoxStavke.Controls.Add(label7);
            groupBoxStavke.Controls.Add(label6);
            groupBoxStavke.Controls.Add(label5);
            groupBoxStavke.Controls.Add(label4);
            groupBoxStavke.Controls.Add(txtCena);
            groupBoxStavke.Controls.Add(btnDodajStavku);
            groupBoxStavke.Location = new Point(33, 243);
            groupBoxStavke.Name = "groupBoxStavke";
            groupBoxStavke.Size = new Size(431, 180);
            groupBoxStavke.TabIndex = 7;
            groupBoxStavke.TabStop = false;
            groupBoxStavke.Text = "Додавање ставке";
            // 
            // numTrajanjeUNedeljama
            // 
            numTrajanjeUNedeljama.Location = new Point(203, 30);
            numTrajanjeUNedeljama.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTrajanjeUNedeljama.Name = "numTrajanjeUNedeljama";
            numTrajanjeUNedeljama.Size = new Size(120, 23);
            numTrajanjeUNedeljama.TabIndex = 8;
            numTrajanjeUNedeljama.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numTrajanjeUNedeljama.ValueChanged += numTrajanjeUNedeljama_ValueChanged;
            // 
            // cmbNacinPlacanja
            // 
            cmbNacinPlacanja.FormattingEnabled = true;
            cmbNacinPlacanja.Location = new Point(203, 110);
            cmbNacinPlacanja.Name = "cmbNacinPlacanja";
            cmbNacinPlacanja.Size = new Size(200, 23);
            cmbNacinPlacanja.TabIndex = 7;
            // 
            // cmbStatusUplate
            // 
            cmbStatusUplate.FormattingEnabled = true;
            cmbStatusUplate.Location = new Point(203, 70);
            cmbStatusUplate.Name = "cmbStatusUplate";
            cmbStatusUplate.Size = new Size(200, 23);
            cmbStatusUplate.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 113);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 5;
            label7.Text = "Начин плаћања:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 73);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 4;
            label6.Text = "Статус уплате:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 32);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 3;
            label5.Text = "Трајање у недељама:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 150);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 2;
            label4.Text = "Цена по недељи:";
            // 
            // txtCena
            // 
            txtCena.Enabled = false;
            txtCena.Location = new Point(203, 147);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(120, 23);
            txtCena.TabIndex = 1;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.Location = new Point(329, 147);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(75, 23);
            btnDodajStavku.TabIndex = 0;
            btnDodajStavku.Text = "Додај";
            btnDodajStavku.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrikazStavki
            // 
            groupBoxPrikazStavki.Controls.Add(dgvStavke);
            groupBoxPrikazStavki.Location = new Point(470, 98);
            groupBoxPrikazStavki.Name = "groupBoxPrikazStavki";
            groupBoxPrikazStavki.Size = new Size(648, 324);
            groupBoxPrikazStavki.TabIndex = 8;
            groupBoxPrikazStavki.TabStop = false;
            groupBoxPrikazStavki.Text = "Ставке евиденције";
            // 
            // dgvStavke
            // 
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Dock = DockStyle.Fill;
            dgvStavke.Location = new Point(3, 19);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.RowHeadersWidth = 51;
            dgvStavke.Size = new Size(642, 302);
            dgvStavke.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(473, 437);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 9;
            label8.Text = "Укупан износ:";
            // 
            // txtUkupanIznos
            // 
            txtUkupanIznos.Enabled = false;
            txtUkupanIznos.Location = new Point(564, 434);
            txtUkupanIznos.Name = "txtUkupanIznos";
            txtUkupanIznos.Size = new Size(120, 23);
            txtUkupanIznos.TabIndex = 10;
            txtUkupanIznos.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(95, 191);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 12;
            label9.Text = "Датум почетка:";
            // 
            // dtpDatumPocetka
            // 
            dtpDatumPocetka.Format = DateTimePickerFormat.Short;
            dtpDatumPocetka.Location = new Point(197, 185);
            dtpDatumPocetka.Name = "dtpDatumPocetka";
            dtpDatumPocetka.Size = new Size(267, 23);
            dtpDatumPocetka.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(776, 437);
            label10.Name = "label10";
            label10.Size = new Size(105, 15);
            label10.TabIndex = 14;
            label10.Text = "Датум завршетка:";
            // 
            // txtDatumZavrsetka
            // 
            txtDatumZavrsetka.Enabled = false;
            txtDatumZavrsetka.Location = new Point(887, 434);
            txtDatumZavrsetka.Name = "txtDatumZavrsetka";
            txtDatumZavrsetka.Size = new Size(228, 23);
            txtDatumZavrsetka.TabIndex = 15;
            // 
            // UCkreirajEvidencijaClanarine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtUkupanIznos);
            Controls.Add(label8);
            Controls.Add(groupBoxPrikazStavki);
            Controls.Add(groupBoxStavke);
            Controls.Add(btnSave);
            Controls.Add(btnReset);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbMembershipType);
            Controls.Add(cmbMember);
            Controls.Add(cmbTrainer);
            Controls.Add(label9);
            Controls.Add(dtpDatumPocetka);
            Controls.Add(label10);
            Controls.Add(txtDatumZavrsetka);
            Name = "UCkreirajEvidencijaClanarine";
            Size = new Size(1214, 630);
            groupBoxStavke.ResumeLayout(false);
            groupBoxStavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTrajanjeUNedeljama).EndInit();
            groupBoxPrikazStavki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTrainer;
        private ComboBox cmbMember;
        private ComboBox cmbMembershipType;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Button btnReset;
        private GroupBox groupBoxStavke;
        private NumericUpDown numTrajanjeUNedeljama;
        private ComboBox cmbNacinPlacanja;
        private ComboBox cmbStatusUplate;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtCena;
        private Button btnDodajStavku;
        private GroupBox groupBoxPrikazStavki;
        private DataGridView dgvStavke;
        private Label label8;
        private TextBox txtUkupanIznos;
        private DateTimePicker dtpDatumPocetka;
        private TextBox txtDatumZavrsetka;


        // Public properties
        public ComboBox CmbTrainer { get => cmbTrainer; set => cmbTrainer = value; }
        public ComboBox CmbMember { get => cmbMember; set => cmbMember = value; }
        public ComboBox CmbMembershipType { get => cmbMembershipType; set => cmbMembershipType = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Button BtnSave { get => btnSave; set => btnSave = value; }
        public Button BtnReset { get => btnReset; set => btnReset = value; }
        public NumericUpDown NumTrajanjeUNedeljama { get => numTrajanjeUNedeljama; set => numTrajanjeUNedeljama = value; }
        public ComboBox CmbNacinPlacanja { get => cmbNacinPlacanja; set => cmbNacinPlacanja = value; }
        public ComboBox CmbStatusUplate { get => cmbStatusUplate; set => cmbStatusUplate = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public Button BtnDodajStavku { get => btnDodajStavku; set => btnDodajStavku = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public TextBox TxtUkupanIznos { get => txtUkupanIznos; set => txtUkupanIznos = value; }
        public DateTimePicker DtpDatumPocetka { get => dtpDatumPocetka; set => dtpDatumPocetka = value; }
        public TextBox TxtDatumZavrsetka { get => txtDatumZavrsetka; set => txtDatumZavrsetka = value; }
    }
}
