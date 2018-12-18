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
            int packageID = Convert.ToInt32(txtId.Text);
            dgvPackProdSuppl.DataSource = DBHandler.getPackageProdSuppliers(packageID);

            //***  Table apperance
            //HIDE ID COLUMN
            dgvPackProdSuppl.Columns[0].Visible = false;

            // EDIT APPEARANCE OF DATA GRID VIEW
            dgvPackProdSuppl.Columns[0].HeaderText = "Package ID";
            dgvPackProdSuppl.Columns[1].HeaderText = "Product";
            dgvPackProdSuppl.Columns[2].HeaderText = "Supplier";


            // Variable to Retrive MS SQL Qeury
            //int packageID = Convert.ToInt32(txtId.Text);
            //DataTable packProdSup = DBHandler.getPackageProdSuppliers(packageID);
            //List<DataRow> packProdSupList = packProdSup.AsEnumerable().ToList();


            //// Move data to a custom class
            //foreach (DataRow row in packProdSup.Rows)
            //{
            //    lbl lbl = new lbl();
            //    lbl.Name = row["name"].ToString();
            //    lbl.Gender = row["gender"].ToString();
            //    lbl.Contact = row["contactno"].ToString();

            //    stringList.add(lbl);
            //}


            //// Store values from DataTable
            //string products = string.Join(",", packProdSupList.Select(c => c[0].ToString()).ToArray());
            //string productIds = string.Join(",", packProdSupList.Select(c => c[1].ToString()).ToArray());
            //string suppliers = string.Join(",", packProdSupList.Select(c => c[2].ToString()).ToArray());
            //string supplierIds = string.Join(",", packProdSupList.Select(c => c[3].ToString()).ToArray());
            //MessageBox.Show(products);
            //MessageBox.Show(productIds);
            //MessageBox.Show(suppliers);
            //MessageBox.Show(supplierIds);

            //// Create a DataGridView
            //DataGridViewTextBoxColumn product = new DataGridViewTextBoxColumn();
            //DataGridViewTextBoxColumn productId = new DataGridViewTextBoxColumn();
            //DataGridViewComboBoxColumn supplier = new DataGridViewComboBoxColumn();
            //DataGridViewTextBoxColumn supplierId = new DataGridViewTextBoxColumn();
            ////col.DataPropertyName = "3";

            //// Set column properties
            //product.HeaderText = "Product";
            //dgvPackProdSuppl.Columns.Add(product);
            //productId.HeaderText = "Product ID";
            //dgvPackProdSuppl.Columns.Add(productId);
            //supplier.HeaderText = "Supplier";
            //dgvPackProdSuppl.Columns.Add(supplier);
            //supplierId.HeaderText = "SupplierID";
            //dgvPackProdSuppl.Columns.Add(supplierId);

            //// Loop through list generated from data table to populate DataGridView
            //dgvPackProdSuppl.Rows.Add("", "", "");


        }
    }
}
