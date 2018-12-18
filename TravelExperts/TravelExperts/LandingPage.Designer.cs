namespace TravelExperts
{
    partial class MainPage
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pACKEGESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUPPLIERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKINGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(182, 462);
            this.panelMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.pACKEGESToolStripMenuItem,
            this.sUPPLIERSToolStripMenuItem,
            this.pRODUCTSToolStripMenuItem,
            this.bOOKINGSToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(182, 206);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.AutoSize = false;
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // pACKEGESToolStripMenuItem
            // 
            this.pACKEGESToolStripMenuItem.AutoSize = false;
            this.pACKEGESToolStripMenuItem.Name = "pACKEGESToolStripMenuItem";
            this.pACKEGESToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.pACKEGESToolStripMenuItem.Text = "PACKAGES";
            this.pACKEGESToolStripMenuItem.Click += new System.EventHandler(this.pACKEGESToolStripMenuItem_Click);
            // 
            // sUPPLIERSToolStripMenuItem
            // 
            this.sUPPLIERSToolStripMenuItem.AutoSize = false;
            this.sUPPLIERSToolStripMenuItem.Name = "sUPPLIERSToolStripMenuItem";
            this.sUPPLIERSToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.sUPPLIERSToolStripMenuItem.Text = "SUPPLIERS";
            this.sUPPLIERSToolStripMenuItem.Click += new System.EventHandler(this.sUPPLIERSToolStripMenuItem_Click);
            // 
            // pRODUCTSToolStripMenuItem
            // 
            this.pRODUCTSToolStripMenuItem.AutoSize = false;
            this.pRODUCTSToolStripMenuItem.Name = "pRODUCTSToolStripMenuItem";
            this.pRODUCTSToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.pRODUCTSToolStripMenuItem.Text = "PRODUCTS";
            this.pRODUCTSToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTSToolStripMenuItem_Click);
            // 
            // bOOKINGSToolStripMenuItem
            // 
            this.bOOKINGSToolStripMenuItem.AutoSize = false;
            this.bOOKINGSToolStripMenuItem.Name = "bOOKINGSToolStripMenuItem";
            this.bOOKINGSToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.bOOKINGSToolStripMenuItem.Text = "BOOKINGS";
            this.bOOKINGSToolStripMenuItem.Click += new System.EventHandler(this.bOOKINGSToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Travel Experts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pACKEGESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUPPLIERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKINGSToolStripMenuItem;
    }
}

