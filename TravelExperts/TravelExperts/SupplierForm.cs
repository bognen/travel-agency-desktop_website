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
    public partial class SupplierForm : Form
    {
        bool loaded = false;
        SupplierDetails supplierdetail = new SupplierDetails();
        List<Supplier> suppliers = new List<Supplier>();

        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            int supplierId = Convert.ToInt32(supplierNameComboBox.SelectedValue);
            supplierdetail = SupplierDetailsDB.GetSupplierDetails(supplierId);
            LoadSupplierComboBox();
            supplierNameTextBox.Visible = false;
            saveModifyButton.Visible = false;
            cancelButton.Visible = false;
        }

        // Andy Gao
        private void LoadSupplierComboBox()
        {
            try
            {
                suppliers = SupplierDB.GetSupplier();

                supplierNameComboBox.ValueMember = "SupplierId";
                supplierNameComboBox.DisplayMember = "SupName";
                supplierNameComboBox.DataSource = suppliers;

                supplierIDTextBox.Text = supplierNameComboBox.SelectedValue.ToString();
                DisplaySupplierDetails();

                loaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Andy Gao
        private void supplierNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                try
                {
                    int supplierId = Convert.ToInt32(supplierNameComboBox.SelectedValue);

                    supplierdetail = SupplierDetailsDB.GetSupplierDetails(supplierId);
                    DisplaySupplierDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                try
                {
                    // Receive supplierID from combobox selection
                    string supplierId = supplierNameComboBox.Text;

                    // Add details to supplierdetail 
                    supplierdetail = SupplierDetailsDB.GetSupplierDetailInfo(supplierId);

                    // Display in corresponding texts
                    DisplaySupplierDetails();
                    supplierIDTextBox.Text = supplierNameComboBox.SelectedValue.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        // Andy Gao
        private void DisplaySupplierDetails()
        {
            if (supplierdetail != null)
            {
                firstNameTextBox.Text = supplierdetail.SupConFirstName;
                lastNameTextBox.Text = supplierdetail.SupConLastName;
                addressTextBox.Text = supplierdetail.SupConAddress;
                cityTextBox.Text = supplierdetail.SupConCity;
                provTextBox.Text = supplierdetail.SupConProv;
                countryTextBox.Text = supplierdetail.SupConCountry;
                postalTextBox.Text = supplierdetail.SupConPostal;
                phoneTextBox.Text = supplierdetail.SupConBusPhone;
                faxTextBox.Text = supplierdetail.SupConFax;
                emailTextBox.Text = supplierdetail.SupConEmail;
                urlTextBox.Text = supplierdetail.SupConURL;
            }
            else
            {
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                addressTextBox.Text = "";
                cityTextBox.Text = "";
                provTextBox.Text = "";
                countryTextBox.Text = "";
                postalTextBox.Text = "";
                phoneTextBox.Text = "";
                faxTextBox.Text = "";
                emailTextBox.Text = "";
                urlTextBox.Text = "";
            }
        }

        // Andy Gao
        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddSupplierForm addsupplierform = new AddSupplierForm();
            addsupplierform.Show();
            this.Hide();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            // Display changes
            addNewButton.Visible = false;
            supplierNameComboBox.Visible = false;
            supplierNameTextBox.Visible = true;
            supplierNameTextBox.Focus();
            saveModifyButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void saveModifyButton_Click(object sender, EventArgs e)
        {

            // Check if null
            if (supplierNameTextBox.Text == null || supplierNameTextBox.Text == "")
            {
                MessageBox.Show("Supplier Name must not be empty!");
            }
            else
            {
                // Retrieve input
                Supplier changedsupplier = new Supplier();
                Supplier oldsupplier = new Supplier();
                changedsupplier.SupName = supplierNameTextBox.Text.ToString();
                changedsupplier.SupplierId = Convert.ToInt32(supplierNameComboBox.SelectedValue);
                oldsupplier.SupName = supplierNameComboBox.Text;
                oldsupplier.SupplierId = Convert.ToInt32(supplierNameComboBox.SelectedValue);

                DialogResult dr = MessageBox.Show("Confirm your changes: " + oldsupplier.SupName + 
                    " to " + changedsupplier.SupName, "Confirm Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);


                if (dr == DialogResult.Yes)
                {
                    // Update in database
                    SupplierDB.EditSupplier(changedsupplier, oldsupplier);
                    MessageBox.Show("Your Change is saved!");

                    // Display Changes
                    addNewButton.Visible = true;
                    supplierNameComboBox.Visible = true;
                    supplierNameTextBox.Visible = false;
                    saveModifyButton.Visible = false;
                    cancelButton.Visible = false;
                    LoadSupplierComboBox();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            addNewButton.Visible = true;
            supplierNameComboBox.Visible = true;
            supplierNameTextBox.Visible = false;
            saveModifyButton.Visible = false;
            cancelButton.Visible = false;
            LoadSupplierComboBox();
        }
    }
}
