namespace Server
{
    partial class FrmServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblTitle = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(46, 139, 87);
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatAppearance.MouseDownBackColor = Color.FromArgb(163, 193, 173);
            btnStart.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 228, 160);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(162, 104);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(275, 74);
            btnStart.TabIndex = 0;
            btnStart.Text = "Покрени сервер";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(224, 33, 138);
            btnStop.Cursor = Cursors.Hand;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatAppearance.MouseDownBackColor = Color.FromArgb(219, 112, 147);
            btnStop.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 203);
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(162, 199);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(275, 75);
            btnStop.TabIndex = 1;
            btnStop.Text = "Заустави сервер";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(225, 235, 245);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 378);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(633, 26);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(70, 70, 70);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(162, 20);
            lblStatus.Text = "Сервер није покренут";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(82, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(444, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Покретање Сервера Пилатес центра";
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            ClientSize = new Size(633, 404);
            Controls.Add(lblTitle);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(statusStrip);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmServer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PilatesApp - Сервер";
            Load += FrmServer_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private Label lblTitle;
    }
}