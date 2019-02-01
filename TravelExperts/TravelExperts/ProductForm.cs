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

            DataGridViewColumn id = dataGridView1.Columns[0];
            DataGridViewColumn name = dataGridView1.Columns[1];

            id.HeaderText = "ID";
            name.HeaderText = "Product";

        }

        // load the ProductsAdd form when the add button is clicked
        private void addlStripButton_Click(object sender, EventArgs e)
        {
            ProductsAdd productAddForm = new ProductsAdd();
            productAddForm.Show();
        }

        // load the updateCustomer form
        private void editStripButton_Click(object sender, EventArgs e)
        {
            ProductsUpdate productUpdateForm = new ProductsUpdate();
            productUpdateForm.Show();
        }

        // update datagrid view
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = ProductList;

            dataGridView1.DataSource = jamesProductsDB.GetProducts();
        }

        //++ Dima Bognen
        // Jan 31, 2019
        // Method Added to respond when the form is called from Package Form as a Modal
        // Returns Value of Current row to packages
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Modal == true) {
                this.DialogResult = DialogResult.Yes;
            }
        }
        // End of Added Method
        // -- Dima Bognen
    }
}
