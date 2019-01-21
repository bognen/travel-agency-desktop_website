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
    public partial class updateProducts : Form
    {
        public updateProducts()
        {
            InitializeComponent();
        }
        private Products products;

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            // get the ProductId from textbox and put it into GetProductsUpdate method on jamesProductsDB
            int ProductId = Convert.ToInt32(txtProdID);
            try
            {
                products = jamesProductsDB.GetProductsUpdate(ProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
            //int customerID = Convert.ToInt32(txtCustomerID.Text);
            //this.GetCustomer(customerID);
            //if (customer == null)
            //{
            //    MessageBox.Show("No customer found with this ID. " +
            //         "Please try again.", "Customer Not Found");
            //    this.ClearControls();
            //}
            //else
            //    this.DisplayCustomer();
        }
}
