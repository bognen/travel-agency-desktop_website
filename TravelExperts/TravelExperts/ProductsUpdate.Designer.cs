namespace TravelExperts
{
    partial class ProductsUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.lblProdName = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Id:";
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(182, 38);
            this.txtProdId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(116, 26);
            this.txtProdId.TabIndex = 1;
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(382, 34);
            this.btnGetProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(112, 35);
            this.btnGetProducts.TabIndex = 2;
            this.btnGetProducts.Text = "Get Product";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(38, 119);
            this.lblProdName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(136, 24);
            this.lblProdName.TabIndex = 3;
            this.lblProdName.Text = "Product Name:";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(182, 119);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(312, 26);
            this.txtProdName.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(344, 172);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 55);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ProductsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 291);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.btnGetProducts);
            this.Controls.Add(this.txtProdId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(160, 90);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductsUpdate";
            this.Text = "Update Products";
            this.Load += new System.EventHandler(this.ProductsUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Button btnUpdate;
    }
}