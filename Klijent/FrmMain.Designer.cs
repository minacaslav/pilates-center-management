namespace Client
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            evidencijaClanarineToolStripMenuItem = new ToolStripMenuItem();
            kreirajEvidencijuToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            clanToolStripMenuItem = new ToolStripMenuItem();
            kreirajClanaToolStripMenuItem = new ToolStripMenuItem();
            prikaziClanaToolStripMenuItem = new ToolStripMenuItem();
            ubaciTreningToolStripMenuItem = new ToolStripMenuItem();
            odjaviSeToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblWelcome = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(219, 112, 147);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { evidencijaClanarineToolStripMenuItem, clanToolStripMenuItem, ubaciTreningToolStripMenuItem, odjaviSeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1379, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // evidencijaClanarineToolStripMenuItem
            // 
            evidencijaClanarineToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kreirajEvidencijuToolStripMenuItem, toolStripMenuItem1 });
            evidencijaClanarineToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            evidencijaClanarineToolStripMenuItem.ForeColor = Color.White;
            evidencijaClanarineToolStripMenuItem.Name = "evidencijaClanarineToolStripMenuItem";
            evidencijaClanarineToolStripMenuItem.Size = new Size(183, 24);
            evidencijaClanarineToolStripMenuItem.Text = "Евиденција чланарине";
            // 
            // kreirajEvidencijuToolStripMenuItem
            // 
            kreirajEvidencijuToolStripMenuItem.Name = "kreirajEvidencijuToolStripMenuItem";
            kreirajEvidencijuToolStripMenuItem.Size = new Size(247, 26);
            kreirajEvidencijuToolStripMenuItem.Text = "Креирај евиденцију";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(247, 26);
            toolStripMenuItem1.Text = "Претражи евиденције";
            // 
            // clanToolStripMenuItem
            // 
            clanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kreirajClanaToolStripMenuItem, prikaziClanaToolStripMenuItem });
            clanToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clanToolStripMenuItem.ForeColor = Color.White;
            clanToolStripMenuItem.Name = "clanToolStripMenuItem";
            clanToolStripMenuItem.Size = new Size(58, 24);
            clanToolStripMenuItem.Text = "Члан";
            // 
            // kreirajClanaToolStripMenuItem
            // 
            kreirajClanaToolStripMenuItem.Name = "kreirajClanaToolStripMenuItem";
            kreirajClanaToolStripMenuItem.Size = new Size(225, 26);
            kreirajClanaToolStripMenuItem.Text = "Креирај члана";
            // 
            // prikaziClanaToolStripMenuItem
            // 
            prikaziClanaToolStripMenuItem.Name = "prikaziClanaToolStripMenuItem";
            prikaziClanaToolStripMenuItem.Size = new Size(225, 26);
            prikaziClanaToolStripMenuItem.Text = "Претражи чланове";
            // 
            // ubaciTreningToolStripMenuItem
            // 
            ubaciTreningToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ubaciTreningToolStripMenuItem.ForeColor = Color.White;
            ubaciTreningToolStripMenuItem.Name = "ubaciTreningToolStripMenuItem";
            ubaciTreningToolStripMenuItem.Size = new Size(127, 24);
            ubaciTreningToolStripMenuItem.Text = "Убаци тренинг";
            // 
            // odjaviSeToolStripMenuItem
            // 
            odjaviSeToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            odjaviSeToolStripMenuItem.ForeColor = Color.White;
            odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            odjaviSeToolStripMenuItem.Size = new Size(90, 24);
            odjaviSeToolStripMenuItem.Text = "Одјави се";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(245, 248, 250);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 30);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1379, 788);
            mainPanel.TabIndex = 1;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(219, 112, 147);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus, lblWelcome, toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 818);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1379, 26);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(70, 70, 70);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(80, 20);
            lblStatus.Text = "PilatesApp";
            // 
            // lblWelcome
            // 
            lblWelcome.ForeColor = Color.FromArgb(70, 70, 70);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(1243, 20);
            lblWelcome.Spring = true;
            lblWelcome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 20);
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 250);
            ClientSize = new Size(1379, 844);
            Controls.Add(mainPanel);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PilatesApp - Главни мени";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem evidencijaClanarineToolStripMenuItem;
        private ToolStripMenuItem kreirajEvidencijuToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem clanToolStripMenuItem;
        private ToolStripMenuItem ubaciTreningToolStripMenuItem;
        private ToolStripMenuItem odjaviSeToolStripMenuItem;
        private ToolStripMenuItem kreirajClanaToolStripMenuItem;
        private ToolStripMenuItem prikaziClanaToolStripMenuItem;
        private Panel mainPanel;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblWelcome;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }

    public class CustomMenuRenderer : ToolStripProfessionalRenderer
    {
        public CustomMenuRenderer() : base(new CustomColorTable()) { }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 100, 150)), e.Item.ContentRectangle);
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = e.Item.Selected ? Color.White : Color.Black;
            base.OnRenderItemText(e);
        }
    }

    public class CustomColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(50, 100, 150); }
        }

        public override Color MenuItemBorder
        {
            get { return Color.FromArgb(70, 130, 180); }
        }

        public override Color MenuStripGradientBegin
        {
            get { return Color.FromArgb(245, 248, 250); }
        }

        public override Color MenuStripGradientEnd
        {
            get { return Color.FromArgb(245, 248, 250); }
        }

        public override Color ToolStripDropDownBackground
        {
            get { return Color.White; }
        }
    }
}