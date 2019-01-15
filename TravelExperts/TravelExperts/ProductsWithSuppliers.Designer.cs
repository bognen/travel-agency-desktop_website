namespace TravelExperts
{
    partial class ProductsWithSuppliers
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
            this.packagesProductsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpertsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpertsDataSet = new TravelExperts.TravelExpertsDataSet();
            this.packages_Products_SuppliersTableAdapter = new TravelExperts.TravelExpertsDataSetTableAdapters.Packages_Products_SuppliersTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new TravelExperts.TravelExpertsDataSetTableAdapters.ProductsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagesProductsSuppliersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.packageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSupplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // packagesProductsSuppliersBindingSource
            // 
            this.packagesProductsSuppliersBindingSource.DataMember = "Packages_Products_Suppliers";
            this.packagesProductsSuppliersBindingSource.DataSource = this.travelExpertsDataSetBindingSource;
            // 
            // travelExpertsDataSetBindingSource
            // 
            this.travelExpertsDataSetBindingSource.DataSource = this.travelExpertsDataSet;
            this.travelExpertsDataSetBindingSource.Position = 0;
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packages_Products_SuppliersTableAdapter
            // 
            this.packages_Products_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.travelExpertsDataSetBindingSource;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packageIdDataGridViewTextBoxColumn,
            this.productSupplierIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.packagesProductsSuppliersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(247, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 398);
            this.dataGridView2.TabIndex = 1;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.travelExpertsDataSetBindingSource;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            // 
            // packagesProductsSuppliersBindingSource1
            // 
            this.packagesProductsSuppliersBindingSource1.DataMember = "Packages_Products_Suppliers";
            this.packagesProductsSuppliersBindingSource1.DataSource = this.travelExpertsDataSetBindingSource;
            // 
            // packageIdDataGridViewTextBoxColumn
            // 
            this.packageIdDataGridViewTextBoxColumn.DataPropertyName = "PackageId";
            this.packageIdDataGridViewTextBoxColumn.HeaderText = "PackageId";
            this.packageIdDataGridViewTextBoxColumn.Name = "packageIdDataGridViewTextBoxColumn";
            // 
            // productSupplierIdDataGridViewTextBoxColumn
            // 
            this.productSupplierIdDataGridViewTextBoxColumn.DataPropertyName = "ProductSupplierId";
            this.productSupplierIdDataGridViewTextBoxColumn.HeaderText = "ProductSupplierId";
            this.productSupplierIdDataGridViewTextBoxColumn.Name = "productSupplierIdDataGridViewTextBoxColumn";
            // 
            // ProductsWithSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductsWithSuppliers";
            this.Text = "ProductsWithSuppliers";
            this.Load += new System.EventHandler(this.ProductsWithSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource travelExpertsDataSetBindingSource;
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesProductsSuppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.Packages_Products_SuppliersTableAdapter packages_Products_SuppliersTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TravelExpertsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSupplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource packagesProductsSuppliersBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsBindingSource1;
    }
}