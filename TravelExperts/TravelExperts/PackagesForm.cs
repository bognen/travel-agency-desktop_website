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
    public partial class PackagesForm : Form
    {
        public PackagesForm(DataGridViewRow rowstring)
        {
            InitializeComponent();

            // Assign values passed from another form
            if (rowstring != null)
            {
                txtId.Text = string.Format("{0}", rowstring.Cells[0].Value);
                txtName.Text = string.Format("{0}", rowstring.Cells[1].Value);
                tpStartDate.Text = string.Format("{0}", rowstring.Cells[2].Value);
                tpEndDate.Text = string.Format("{0}", rowstring.Cells[3].Value);
                txtDesc.Text = string.Format("{0}", rowstring.Cells[4].Value);
                txtBasePrice.Text = string.Format("{0:n}", rowstring.Cells[5].Value);
                txtAgComm.Text = string.Format("{0:n}", rowstring.Cells[6].Value);
            }
        }

        private void PackagesForm_Load(object sender, EventArgs e)
        {
            //int packageID = Convert.ToInt32(txtId.Text);
            //dgvPackProdSuppl.DataSource = DBHandler.getPackageProdSuppliers(packageID);

            ////***  Table apperance
            ////HIDE ID COLUMN
            //dgvPackProdSuppl.Columns[0].Visible = false;

            //// EDIT APPEARANCE OF DATA GRID VIEW
            //dgvPackProdSuppl.Columns[0].HeaderText = "Package ID";
            //dgvPackProdSuppl.Columns[1].HeaderText = "Product";
            //dgvPackProdSuppl.Columns[2].HeaderText = "Supplier";


            // Variable to Retrive MS SQL Qeury
            int packageID = Convert.ToInt32(txtId.Text);
            DataTable packProdSup = DBHandler.getPackageProdSuppliers(packageID);
            List<PackProdSupplier> packProdSupList = new List<PackProdSupplier>();
            
            // Move data to a custom class
            foreach (DataRow row in packProdSup.Rows)
            {
                PackProdSupplier itemLine = new PackProdSupplier(row[0].ToString(), row[1].ToString(),
                                                                row[2].ToString(), row[3].ToString());
                packProdSupList.Add(itemLine);
            }

            // Create a DataGridView
            DataGridViewTextBoxColumn product = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn productId = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn supplier = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn supplierId = new DataGridViewTextBoxColumn();

            // Set column properties
            product.HeaderText = "Product";
            dgvPackProdSuppl.Columns.Add(product);
            productId.HeaderText = "Product ID";
            dgvPackProdSuppl.Columns.Add(productId);
            supplier.HeaderText = "Supplier";
            dgvPackProdSuppl.Columns.Add(supplier);
            supplierId.HeaderText = "SupplierID";
            dgvPackProdSuppl.Columns.Add(supplierId);

            // Store values from DataTable

            //messagebox.show(products);
            //messagebox.show(productids);
            //messagebox.show(suppliers);
            //messagebox.show(supplierids);

            // Loop through list generated from data table to populate DataGridView
            string[] splitLine = new string[4];

            foreach (PackProdSupplier line in packProdSupList)
            {
                splitLine = line.ToString().Split(',');
                dgvPackProdSuppl.Rows.Add(splitLine[0], splitLine[1], "", splitLine[3]);
            }
        }
    }
}
