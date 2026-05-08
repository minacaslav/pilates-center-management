namespace Client.UserControls
{
    partial class UCUbaciTrening
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
            groupBox = new GroupBox();
            lblTip = new Label();
            btnUbaci = new Button();
            cmbTip = new ComboBox();
            rtxtOpis = new RichTextBox();
            txtNaziv = new TextBox();
            lblOpis = new Label();
            lblNaziv = new Label();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(lblTip);
            groupBox.Controls.Add(btnUbaci);
            groupBox.Controls.Add(cmbTip);
            groupBox.Controls.Add(rtxtOpis);
            groupBox.Controls.Add(txtNaziv);
            groupBox.Controls.Add(lblOpis);
            groupBox.Controls.Add(lblNaziv);
            groupBox.Location = new Point(3, 4);
            groupBox.Margin = new Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 4, 3, 4);
            groupBox.Size = new Size(981, 616);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Додавање тренинга";
            groupBox.Enter += groupBox_Enter;
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Location = new Point(89, 148);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(106, 20);
            lblTip.TabIndex = 6;
            lblTip.Text = "Тип тренинга:";
            // 
            // btnUbaci
            // 
            btnUbaci.Location = new Point(230, 464);
            btnUbaci.Margin = new Padding(3, 4, 3, 4);
            btnUbaci.Name = "btnUbaci";
            btnUbaci.Size = new Size(177, 31);
            btnUbaci.TabIndex = 5;
            btnUbaci.Text = "Убаци тренинг";
            btnUbaci.UseVisualStyleBackColor = true;
            // 
            // cmbTip
            // 
            cmbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTip.FormattingEnabled = true;
            cmbTip.Location = new Point(230, 144);
            cmbTip.Margin = new Padding(3, 4, 3, 4);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(219, 28);
            cmbTip.TabIndex = 4;
            // 
            // rtxtOpis
            // 
            rtxtOpis.Location = new Point(230, 199);
            rtxtOpis.Margin = new Padding(3, 4, 3, 4);
            rtxtOpis.Name = "rtxtOpis";
            rtxtOpis.Size = new Size(580, 240);
            rtxtOpis.TabIndex = 3;
            rtxtOpis.Text = "";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(230, 87);
            txtNaziv.Margin = new Padding(3, 4, 3, 4);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(219, 27);
            txtNaziv.TabIndex = 2;
            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Location = new Point(139, 203);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(48, 20);
            lblOpis.TabIndex = 1;
            lblOpis.Text = "Опис:";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(135, 91);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(55, 20);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Назив:";
            // 
            // UCUbaciTrening
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCUbaciTrening";
            Size = new Size(987, 624);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Label lblTip;
        private Button btnUbaci;
        private ComboBox cmbTip;
        private RichTextBox rtxtOpis;
        private TextBox txtNaziv;
        private Label lblOpis;
        private Label lblNaziv;

        public TextBox TxtNaziv => txtNaziv;
        public ComboBox CmbTip => cmbTip;
        public RichTextBox RtxtOpis => rtxtOpis;
        public Button BtnUbaci => btnUbaci;
    }
}
