namespace TravelExperts
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.addlStripButton = new System.Windows.Forms.ToolStripButton();
            this.editStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.travelExpertsDataSet = new TravelExperts.TravelExpertsDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new TravelExperts.TravelExpertsDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new TravelExperts.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addlStripButton,
            this.editStripButton,
            this.deleteStripButton,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(401, 54);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 51);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AffiliationsTableAdapter = null;
            this.tableAdapterManager.AgenciesTableAdapter = null;
            this.tableAdapterManager.AgentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingDetailsTableAdapter = null;
            this.tableAdapterManager.BookingsTableAdapter = null;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.CreditCardsTableAdapter = null;
            this.tableAdapterManager.Customers_RewardsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.FeesTableAdapter = null;
            this.tableAdapterManager.Packages_Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.PackagesTableAdapter = null;
            this.tableAdapterManager.Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RegionsTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.SupplierContactsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TripTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TravelExperts.TravelExpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(335, 373);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 442);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(200, 90);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton addlStripButton;
        private System.Windows.Forms.ToolStripButton editStripButton;
        private System.Windows.Forms.ToolStripButton deleteStripButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TravelExpertsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private TravelExpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}