using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraveExpertClassLibrary;

namespace TravelExperts
{
    public partial class ProductsWithSuppliers : Form
    {
        static string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;
        public static ProductsWithSuppliers form;

        public ProductsWithSuppliers()
        {
            InitializeComponent();
        }

        private void ProductsWithSuppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Bookings' table. You can move, or remove it, as needed.
            // this.bookingsTableAdapter.Fill(this.travelExpertsDataSet.Bookings);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages_Products_Suppliers' table. You can move, or remove it, as needed.
            //this.packages_Products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Packages_Products_Suppliers);
            SupplierProduct.DataSource = DBHandler.getSuppliersAndProducts();
        }

        private void addlStripButton_Click(object sender, EventArgs e)
        {
            AddProductsWithSuppliers form = new AddProductsWithSuppliers();
            form.MdiParent = this.MdiParent;
            form.Show();
            this.Close();
        }

        private void editStripButton_Click(object sender, EventArgs e)
        {
            UpdateSuppliersAndProducts form = new UpdateSuppliersAndProducts();
            form.MdiParent = this.MdiParent;
            form.Show();
        }
    }
}
