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
    public partial class AddProductsWithSuppliers : Form
    {
        string supplier;
        string product;


        public AddProductsWithSuppliers()
        {
            InitializeComponent();
        }

        private void AddProductsWithSuppliers_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            //// TODO: This line of code loads data into the 'travelExpertsDataSet.Products_Suppliers' table. You can move, or remove it, as needed.
            //this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);
            //// TODO: This line of code loads data into the 'travelExpertsDataSet.Packages_Products_Suppliers' table. You can move, or remove it, as needed.
            //this.packages_Products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Packages_Products_Suppliers);
            ProductBox.DataSource = jamesProductsDB.GetProducts();
            
            ProductBox.DisplayMember = "ProdName";
            ProductBox.ValueMember = "ProductId";

            SuppliersBox.DataSource = SuppliersFunctions.GetSuppliers();
            SuppliersBox.ValueMember = "SupplierId";
            SuppliersBox.DisplayMember = "SupName";

            //((DataGridViewComboBoxCell)dgvRow.Cells[2]).Value =
            //            supplierIdPairs[indOfRightElement].SupplierId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int success = 0;
            if (ProductBox.Text == " ")
            {
                MessageBox.Show("Please Select a Product");
            }
            else if (SuppliersBox.Text == " ")
            {
                MessageBox.Show("Please select a Supplier");
            }
            else
            {
               product = ProductBox.Text;
               supplier = SuppliersBox.Text;
            }

            success = SuppliersFunctions.AddSuppliers(Convert.ToInt32(ProductBox.SelectedValue), Convert.ToInt32(SuppliersBox.SelectedValue));

            if (success == 1)
            {
                MessageBox.Show("Data inserted Correctly");

                ProductsWithSuppliers form = new ProductsWithSuppliers();
                form.MdiParent = this.MdiParent;
                form.Show();
                this.Close();
            }
            else MessageBox.Show("Data was not inserted. It already exists");

            this.Close();
        }
    }
}
