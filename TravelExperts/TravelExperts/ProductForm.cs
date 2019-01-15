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
    /// <summary>
    /// Main form page for james's application, also displays data from the products page in the database
    /// Author: James Cockriell
    /// January: 10/2019
    /// </summary>
    public partial class ProductForm : Form
    {
        List<Products> ProductList = jamesProductsDB.GetProducts();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
           // add data from ProductList into the datagrid view on form load
            dataGridView1.DataSource = ProductList;

        }

        // load the ProductsAdd form when the add button is clicked
        private void addlStripButton_Click(object sender, EventArgs e)
        {
            ProductsAdd productAddForm = new ProductsAdd();
            productAddForm.Show();
        }
    }
}
