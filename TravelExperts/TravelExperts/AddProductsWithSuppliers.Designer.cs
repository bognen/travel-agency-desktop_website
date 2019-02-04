namespace TravelExperts
{
    partial class AddProductsWithSuppliers
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProductBox = new System.Windows.Forms.ComboBox();
            this.packagesProductsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpertsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpertsDataSet = new TravelExperts.TravelExpertsDataSet();
            this.SuppliersBox = new System.Windows.Forms.ComboBox();
            this.packages_Products_SuppliersTableAdapter = new TravelExperts.TravelExpertsDataSetTableAdapters.Packages_Products_SuppliersTableAdapter();
            this.productsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_SuppliersTableAdapter = new TravelExperts.TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new TravelExperts.TravelExpertsDataSetTableAdapters.ProductsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new Product with Supplier:";
            // 
            // ProductBox
            // 
            this.ProductBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.packagesProductsSuppliersBindingSource, "PackageId", true));
            this.ProductBox.FormattingEnabled = true;
            this.ProductBox.Location = new System.Drawing.Point(329, 65);
            this.ProductBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(180, 28);
            this.ProductBox.TabIndex = 1;
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
            // SuppliersBox
            // 
            this.SuppliersBox.FormattingEnabled = true;
            this.SuppliersBox.Location = new System.Drawing.Point(572, 65);
            this.SuppliersBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersBox.Name = "SuppliersBox";
            this.SuppliersBox.Size = new System.Drawing.Size(180, 28);
            this.SuppliersBox.TabIndex = 2;
            // 
            // packages_Products_SuppliersTableAdapter
            // 
            this.packages_Products_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // productsSuppliersBindingSource
            // 
            this.productsSuppliersBindingSource.DataMember = "Products_Suppliers";
            this.productsSuppliersBindingSource.DataSource = this.travelExpertsDataSetBindingSource;
            // 
            // products_SuppliersTableAdapter
            // 
            this.products_SuppliersTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 106);
            this.button1.TabIndex = 3;
            this.button1.Text = "Make New Product With Supplier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProductsWithSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SuppliersBox);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(160, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddProductsWithSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SupplierAdd";
            this.Load += new System.EventHandler(this.AddProductsWithSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductBox;
        private System.Windows.Forms.ComboBox SuppliersBox;
        private System.Windows.Forms.BindingSource travelExpertsDataSetBindingSource;
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesProductsSuppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.Packages_Products_SuppliersTableAdapter packages_Products_SuppliersTableAdapter;
        private System.Windows.Forms.BindingSource productsSuppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter products_SuppliersTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TravelExpertsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}