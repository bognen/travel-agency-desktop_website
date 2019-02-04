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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pACKEGESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUPPLIERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsWithSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKINGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 86);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(6);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(153, 767);
            this.panelMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.pACKEGESToolStripMenuItem,
            this.sUPPLIERSToolStripMenuItem,
            this.pRODUCTSToolStripMenuItem,
            this.productsWithSuppliersToolStripMenuItem,
            this.bOOKINGSToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(151, 250);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.AutoSize = false;
            this.hOMEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // pACKEGESToolStripMenuItem
            // 
            this.pACKEGESToolStripMenuItem.AutoSize = false;
            this.pACKEGESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pACKEGESToolStripMenuItem.Name = "pACKEGESToolStripMenuItem";
            this.pACKEGESToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.pACKEGESToolStripMenuItem.Text = "PACKAGES";
            this.pACKEGESToolStripMenuItem.Click += new System.EventHandler(this.pACKEGESToolStripMenuItem_Click);
            // 
            // sUPPLIERSToolStripMenuItem
            // 
            this.sUPPLIERSToolStripMenuItem.AutoSize = false;
            this.sUPPLIERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSupplierToolStripMenuItem,
            this.addNewSupplierToolStripMenuItem});
            this.sUPPLIERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sUPPLIERSToolStripMenuItem.Name = "sUPPLIERSToolStripMenuItem";
            this.sUPPLIERSToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.sUPPLIERSToolStripMenuItem.Text = "SUPPLIERS";
            // 
            // viewSupplierToolStripMenuItem
            // 
            this.viewSupplierToolStripMenuItem.Name = "viewSupplierToolStripMenuItem";
            this.viewSupplierToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.viewSupplierToolStripMenuItem.Text = "View Supplier";
            this.viewSupplierToolStripMenuItem.Click += new System.EventHandler(this.viewSupplierToolStripMenuItem_Click);
            // 
            // addNewSupplierToolStripMenuItem
            // 
            this.addNewSupplierToolStripMenuItem.Name = "addNewSupplierToolStripMenuItem";
            this.addNewSupplierToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addNewSupplierToolStripMenuItem.Text = "Add New Supplier";
            this.addNewSupplierToolStripMenuItem.Click += new System.EventHandler(this.addNewSupplierToolStripMenuItem_Click);
            // 
            // pRODUCTSToolStripMenuItem
            // 
            this.pRODUCTSToolStripMenuItem.AutoSize = false;
            this.pRODUCTSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pRODUCTSToolStripMenuItem.Name = "pRODUCTSToolStripMenuItem";
            this.pRODUCTSToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.pRODUCTSToolStripMenuItem.Text = "PRODUCTS";
            this.pRODUCTSToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTSToolStripMenuItem_Click);
            // 
            // productsWithSuppliersToolStripMenuItem
            // 
            this.productsWithSuppliersToolStripMenuItem.AutoSize = false;
            this.productsWithSuppliersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.productsWithSuppliersToolStripMenuItem.Name = "productsWithSuppliersToolStripMenuItem";
            this.productsWithSuppliersToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.productsWithSuppliersToolStripMenuItem.Text = "PRODUCTS - SUPPLIERS";
            this.productsWithSuppliersToolStripMenuItem.Click += new System.EventHandler(this.productsWithSuppliersToolStripMenuItem_Click);
            // 
            // bOOKINGSToolStripMenuItem
            // 
            this.bOOKINGSToolStripMenuItem.AutoSize = false;
            this.bOOKINGSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bOOKINGSToolStripMenuItem.Name = "bOOKINGSToolStripMenuItem";
            this.bOOKINGSToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.bOOKINGSToolStripMenuItem.Text = "BOOKINGS";
            this.bOOKINGSToolStripMenuItem.Click += new System.EventHandler(this.bOOKINGSToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1219, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainPage";
            this.Text = "Travel Experts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pACKEGESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUPPLIERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKINGSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsWithSuppliersToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

