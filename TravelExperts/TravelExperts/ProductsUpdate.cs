using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class ProductsUpdate : Form
    {
        /// <summary>
        /// Update Products page 
        /// Author: James Cockriell
        /// Date: January 20/19
        /// </summary>

        public ProductsUpdate()
        {
            InitializeComponent();
        }

        private void ProductsUpdate_Load(object sender, EventArgs e)
        {
            this.ClearControls();
        }

        private Products products;

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            if(txtProdId.Text == "")
            {
                MessageBox.Show("Please Enter Product Id");
            }
            else
            {
                int productID = Convert.ToInt32(txtProdId.Text);
                //jamesProductsDB.GetProductsForUpdate(ProductID);
                this.GetACustomer(productID);
                if(products == null)
                {
                    MessageBox.Show("No product found with this Id." +
                        "Please try again.", "Product not found");
                    this.ClearControls();
                }
            }

            this.DisplayProductName();
        }

        private void GetACustomer(int productID)
        {
            try
            {
                products = jamesProductsDB.GetProductsForUpdate(productID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
 
        }

        private void ClearControls()
        {
            txtProdId.Text = "";
            txtProdName.Text = "";
            lblProdName.Visible = false;
            btnUpdate.Visible = false;
        }

        private void DisplayProductName()
        {
            if(products == null)
            {
                txtProdName.Text = "";
            }
            else
            {
                lblProdName.Visible = true;
                btnUpdate.Visible = true;
                btnGetProducts.Visible = false;
                txtProdId.ReadOnly = true;
                txtProdName.Text = products.ProdName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Products newProducts = new Products();

            // passing the id value from the old product list to the new product list. (prod id does not change)
            newProducts.ProductId = products.ProductId;

            // this might not be the way to do this
            newProducts.ProdName = txtProdName.Text;
            try
            {
                // update an old customer (UpdateProducts returns a bool value)
                if(!jamesProductsDB.UpdateProducts(products, newProducts))
                {
                    MessageBox.Show("Database Error, Another user may have " +
                        "tried updating that customer.");
                    this.DialogResult = DialogResult.Retry;
                }
                else
                {
                    products = newProducts;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}
