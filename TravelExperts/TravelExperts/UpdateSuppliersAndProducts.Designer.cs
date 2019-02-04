namespace TravelExperts
{
    partial class UpdateSuppliersAndProducts
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
            this.view = new System.Windows.Forms.Button();
            this.productCurrent = new System.Windows.Forms.TextBox();
            this.supplierCurrent = new System.Windows.Forms.TextBox();
            this.productNew = new System.Windows.Forms.ComboBox();
            this.supplierNew = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.relationshipInitial = new System.Windows.Forms.ComboBox();
            this.productsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpertsDataSet = new TravelExperts.TravelExpertsDataSet();
            this.products_SuppliersTableAdapter = new TravelExperts.TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter();
            this.productsSuppliersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(129, 151);
            this.view.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(112, 35);
            this.view.TabIndex = 1;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.button1_Click);
            // 
            // productCurrent
            // 
            this.productCurrent.Enabled = false;
            this.productCurrent.Location = new System.Drawing.Point(281, 99);
            this.productCurrent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productCurrent.Name = "productCurrent";
            this.productCurrent.Size = new System.Drawing.Size(180, 26);
            this.productCurrent.TabIndex = 2;
            // 
            // supplierCurrent
            // 
            this.supplierCurrent.Enabled = false;
            this.supplierCurrent.Location = new System.Drawing.Point(491, 99);
            this.supplierCurrent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplierCurrent.Name = "supplierCurrent";
            this.supplierCurrent.Size = new System.Drawing.Size(180, 26);
            this.supplierCurrent.TabIndex = 3;
            // 
            // productNew
            // 
            this.productNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNew.FormattingEnabled = true;
            this.productNew.Location = new System.Drawing.Point(281, 214);
            this.productNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productNew.Name = "productNew";
            this.productNew.Size = new System.Drawing.Size(180, 28);
            this.productNew.TabIndex = 5;
            // 
            // supplierNew
            // 
            this.supplierNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierNew.FormattingEnabled = true;
            this.supplierNew.Location = new System.Drawing.Point(491, 214);
            this.supplierNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplierNew.Name = "supplierNew";
            this.supplierNew.Size = new System.Drawing.Size(180, 28);
            this.supplierNew.TabIndex = 6;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(559, 276);
            this.update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 42);
            this.update.TabIndex = 7;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(75, 42);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(166, 26);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Enter Relationship ID:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(281, 42);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(180, 26);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "Current Product:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(491, 42);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(180, 26);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "Current Supplier:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(281, 160);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(180, 26);
            this.textBox9.TabIndex = 12;
            this.textBox9.Text = "New Desired Product:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(491, 160);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(180, 26);
            this.textBox10.TabIndex = 13;
            this.textBox10.Text = "New Desired Supplier:";
            // 
            // relationshipInitial
            // 
            this.relationshipInitial.DataSource = this.productsSuppliersBindingSource;
            this.relationshipInitial.DisplayMember = "ProductSupplierId";
            this.relationshipInitial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relationshipInitial.FormattingEnabled = true;
            this.relationshipInitial.Location = new System.Drawing.Point(75, 95);
            this.relationshipInitial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.relationshipInitial.Name = "relationshipInitial";
            this.relationshipInitial.Size = new System.Drawing.Size(166, 28);
            this.relationshipInitial.TabIndex = 14;
            this.relationshipInitial.ValueMember = "ProductSupplierId";
            // 
            // productsSuppliersBindingSource
            // 
            this.productsSuppliersBindingSource.DataMember = "Products_Suppliers";
            this.productsSuppliersBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // products_SuppliersTableAdapter
            // 
            this.products_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // productsSuppliersBindingSource1
            // 
            this.productsSuppliersBindingSource1.DataMember = "Products_Suppliers";
            this.productsSuppliersBindingSource1.DataSource = this.travelExpertsDataSet;
            // 
            // UpdateSuppliersAndProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 407);
            this.Controls.Add(this.relationshipInitial);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.update);
            this.Controls.Add(this.supplierNew);
            this.Controls.Add(this.productNew);
            this.Controls.Add(this.supplierCurrent);
            this.Controls.Add(this.productCurrent);
            this.Controls.Add(this.view);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(160, 90);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateSuppliersAndProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UpdateSuppliersAndProducts";
            this.Load += new System.EventHandler(this.UpdateSuppliersAndProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.TextBox productCurrent;
        private System.Windows.Forms.TextBox supplierCurrent;
        private System.Windows.Forms.ComboBox productNew;
        private System.Windows.Forms.ComboBox supplierNew;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox relationshipInitial;
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource productsSuppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter products_SuppliersTableAdapter;
        private System.Windows.Forms.BindingSource productsSuppliersBindingSource1;
    }
}