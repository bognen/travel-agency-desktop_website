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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.filterButton = new System.Windows.Forms.ToolStripButton();
            this.cancelFilter = new System.Windows.Forms.ToolStripButton();
            this.dgvPackageList = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addlStripButton,
            this.editStripButton,
            this.deleteStripButton,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.filterButton,
            this.cancelFilter});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1114, 31);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // addlStripButton
            // 
            this.addlStripButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.addlStripButton.AutoSize = false;
            this.addlStripButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addlStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addlStripButton.Image")));
            this.addlStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addlStripButton.Name = "addlStripButton";
            this.addlStripButton.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.addlStripButton.Size = new System.Drawing.Size(60, 31);
            this.addlStripButton.Text = " Add";
            this.addlStripButton.Click += new System.EventHandler(this.addlStripButton_Click);
            // 
            // editStripButton
            // 
            this.editStripButton.AutoSize = false;
            this.editStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editStripButton.Image")));
            this.editStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editStripButton.Name = "editStripButton";
            this.editStripButton.Size = new System.Drawing.Size(40, 31);
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
            this.deleteStripButton.Size = new System.Drawing.Size(40, 31);
            this.deleteStripButton.Text = "DELETE";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // filterButton
            // 
            this.filterButton.AutoSize = false;
            this.filterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filterButton.Image = ((System.Drawing.Image)(resources.GetObject("filterButton.Image")));
            this.filterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(40, 31);
            this.filterButton.Text = "Filer";
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // cancelFilter
            // 
            this.cancelFilter.AutoSize = false;
            this.cancelFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelFilter.Enabled = false;
            this.cancelFilter.Image = ((System.Drawing.Image)(resources.GetObject("cancelFilter.Image")));
            this.cancelFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelFilter.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.cancelFilter.Name = "cancelFilter";
            this.cancelFilter.Size = new System.Drawing.Size(40, 31);
            this.cancelFilter.Text = "Cancel Filter";
            this.cancelFilter.Click += new System.EventHandler(this.cancelFilter_Click);
            // 
            // dgvPackageList
            // 
            this.dgvPackageList.AllowUserToAddRows = false;
            this.dgvPackageList.AllowUserToDeleteRows = false;
            this.dgvPackageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPackageList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPackageList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPackageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackageList.Location = new System.Drawing.Point(13, 36);
            this.dgvPackageList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPackageList.MultiSelect = false;
            this.dgvPackageList.Name = "dgvPackageList";
            this.dgvPackageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPackageList.Size = new System.Drawing.Size(1082, 409);
            this.dgvPackageList.TabIndex = 2;
            this.dgvPackageList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackageList_CellDoubleClick);
            this.dgvPackageList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPackageList_KeyDown);
            this.dgvPackageList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvPackageList_KeyPress);
            // 
            // PackagesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 461);
            this.Controls.Add(this.dgvPackageList);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(200, 90);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PackagesList";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
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
        public System.Windows.Forms.DataGridView dgvPackageList;
        private System.Windows.Forms.ToolStripButton filterButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cancelFilter;
    }
}