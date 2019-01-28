using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraveExpertClassLibrary;

namespace TravelExperts
{
    public partial class UpdateSuppliersAndProducts : Form
    {
        List<ProductsSuppliers> Suppliers = new List<ProductsSuppliers>();

        public UpdateSuppliersAndProducts()
        {
            InitializeComponent();
        }

        private void UpdateSuppliersAndProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products_Suppliers' table. You can move, or remove it, as needed.
            //this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);

            //DISPLAYS THE DATA IN TEH FORM
            relationshipInitial.DataSource = SuppliersFunctions.GetRelations();
            relationshipInitial.DisplayMember = "ProductSupplierId";
            relationshipInitial.ValueMember = "ProductSupplierId";

            productNew.DataSource = jamesProductsDB.GetProducts();
            productNew.DisplayMember = "ProdName";
            productNew.ValueMember = "ProductId";

            supplierNew.DataSource = SuppliersFunctions.GetSuppliers();
            supplierNew.ValueMember = "SupplierId";
            supplierNew.DisplayMember = "SupName";

            //productCurrent.Source = SuppliersFunctions.GetRelations();
            //productCurrent.Text = 

            //supplierCurrent.Text =
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            ProductsSuppliers info = new ProductsSuppliers();

            info = SuppliersFunctions.GetTwoValues(Convert.ToInt32(relationshipInitial.Text));

            productCurrent.Text = info.ProdName;
            supplierCurrent.Text = info.SupName;
        }

        private void update_Click(object sender, EventArgs e)
        {
            int yay = 0;
            yay = SuppliersFunctions.GetProductsAndSuppliersForUpdate(Convert.ToInt32(relationshipInitial.SelectedValue), Convert.ToInt32(productNew.SelectedValue), Convert.ToInt32(supplierNew.SelectedValue));

            if (yay == 1) MessageBox.Show("Update Successful");         
            else MessageBox.Show("Update Unsuccessful please try again");
        }
    }
}
