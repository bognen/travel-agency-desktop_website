namespace TravelExperts
{
    partial class PackagesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackagesList));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.addlStripButton = new System.Windows.Forms.ToolStripButton();
            this.editStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteStripButton = new System.Windows.Forms.ToolStripButton();
            this.dgvPackageList = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addlStripButton,
            this.editStripButton,
            this.deleteStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(984, 35);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // addlStripButton
            // 
            this.addlStripButton.AutoSize = false;
            this.addlStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addlStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addlStripButton.Image")));
            this.addlStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addlStripButton.Name = "addlStripButton";
            this.addlStripButton.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.addlStripButton.Size = new System.Drawing.Size(32, 32);
            this.addlStripButton.Text = "ADD";
            this.addlStripButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addlStripButton.Click += new System.EventHandler(this.addlStripButton_Click);
            // 
            // editStripButton
            // 
            this.editStripButton.AutoSize = false;
            this.editStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editStripButton.Image")));
            this.editStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editStripButton.Name = "editStripButton";
            this.editStripButton.Size = new System.Drawing.Size(32, 32);
            this.editStripButton.Text = "EDIT  F2";
            this.editStripButton.Click += new System.EventHandler(this.editStripButton_Click);
            // 
            // deleteStripButton
            // 
            this.deleteStripButton.AutoSize = false;
            this.deleteStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteStripButton.Image")));
            this.deleteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteStripButton.Name = "deleteStripButton";
            this.deleteStripButton.Size = new System.Drawing.Size(32, 32);
            this.deleteStripButton.Text = "DELETE";
            // 
            // dgvPackageList
            // 
            this.dgvPackageList.AllowUserToAddRows = false;
            this.dgvPackageList.AllowUserToDeleteRows = false;
            this.dgvPackageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPackageList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPackageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackageList.Location = new System.Drawing.Point(8, 31);
            this.dgvPackageList.MultiSelect = false;
            this.dgvPackageList.Name = "dgvPackageList";
            this.dgvPackageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPackageList.Size = new System.Drawing.Size(964, 418);
            this.dgvPackageList.TabIndex = 2;
            this.dgvPackageList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPackageList_KeyDown);
            this.dgvPackageList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvPackageList_KeyPress);
            // 
            // PackagesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.dgvPackageList);
            this.Controls.Add(this.toolStrip2);
            this.Location = new System.Drawing.Point(200, 20);
            this.Name = "PackagesList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Packages List";
            this.Load += new System.EventHandler(this.PackagesForm_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton addlStripButton;
        private System.Windows.Forms.ToolStripButton editStripButton;
        private System.Windows.Forms.ToolStripButton deleteStripButton;
        private System.Windows.Forms.DataGridView dgvPackageList;
    }
}