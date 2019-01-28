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
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        List<Supplier> suppliers = new List<Supplier>();

        // Andy Gao
        private void addButton_Click(object sender, EventArgs e)
        {
            string supplierinput;

            // Check if input is null
            if (supplierNameTextBox.Text == null || supplierNameTextBox.Text == "")
            {
                MessageBox.Show("Supplier Name must be filled!");
            }
            else
            {
                // Retrieve input
                supplierinput = Convert.ToString(supplierNameTextBox.Text.ToUpper());
                suppliers = SupplierDB.GetSupplier();

                // Check if Supplier is already in system
                foreach (Supplier supplier in suppliers)
                {
                    if (supplier.SupName == supplierinput)
                    {
                        MessageBox.Show("This supplier is already in the system.");
                        break;
                    }
                }

                // Successful input
                int success = SupplierDB.AddSupplier(supplierinput);
                if (success == 1)
                {
                    MessageBox.Show("Supplier is successfully added!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        // Andy Gao
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
