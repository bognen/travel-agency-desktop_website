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
        // Global variable
        bool itIsNewForm = true;
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
                itIsNewForm = false;
            }
        }

        private void PackagesForm_Load(object sender, EventArgs e)
        {
            if (itIsNewForm == false)
            {
            // Create a DataGridView
            DataGridViewTextBoxColumn product = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn productId = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn supplier = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn supplierId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn productSupplierId = new DataGridViewTextBoxColumn();

            // Set column properties
            product.HeaderText = "Product";
            dgvPackProdSuppl.Columns.Add(product);
            productId.HeaderText = "Product ID";
            dgvPackProdSuppl.Columns.Add(productId);
            supplier.HeaderText = "Supplier";
            dgvPackProdSuppl.Columns.Add(supplier);
            supplierId.HeaderText = "SupplierID";
            dgvPackProdSuppl.Columns.Add(supplierId);
            productSupplierId.HeaderText = "ProdSupplID";
            dgvPackProdSuppl.Columns.Add(productSupplierId);

            // Create a list of PackProdSupplkiers
            List<PackProdSupplier> packProdSupList = DBHandler.getProdSuppliersForDGV(Convert.ToInt32(txtId.Text));


            // Loop through list generated from data table to populate DataGridView
            string[] splitLine = new string[5];

                foreach (PackProdSupplier line in packProdSupList)
                {
                    // variable to break list line into array
                    splitLine = line.PackProdSupplierToString().Split(',');

                    // Create a list of possiple values to populate a combox
                    List<SupplierIdPairs> supplierIdPairs =
                        PackProdSupplier.createSupplierIdPairsList(Convert.ToInt32(splitLine[1]));

                    // Find index of right element
                    int indOfRightElement = supplierIdPairs.IndexOf(supplierIdPairs.Where(p =>
                                p.SupplierId == Convert.ToInt32(splitLine[3])).FirstOrDefault());

                    // Store values from DataTable
                    DataGridViewRow dgvRow = new DataGridViewRow();

                    dgvRow.Cells.Add(new DataGridViewTextBoxCell());
                    dgvRow.Cells.Add(new DataGridViewTextBoxCell());
                    dgvRow.Cells.Add(new DataGridViewComboBoxCell());
                    dgvRow.Cells.Add(new DataGridViewTextBoxCell());
                    dgvRow.Cells.Add(new DataGridViewTextBoxCell());

                    dgvRow.Cells[0].Value = splitLine[0];
                    dgvRow.Cells[1].Value = splitLine[1];
                    ((DataGridViewComboBoxCell)dgvRow.Cells[2]).DataSource = supplierIdPairs;
                    ((DataGridViewComboBoxCell)dgvRow.Cells[2]).DisplayMember = "Supplier";
                    ((DataGridViewComboBoxCell)dgvRow.Cells[2]).ValueMember = "SupplierId";
                    ((DataGridViewComboBoxCell)dgvRow.Cells[2]).Value =
                                supplierIdPairs[indOfRightElement].SupplierId;

                    dgvRow.Cells[3].Value = splitLine[3];
                    dgvRow.Cells[4].Value = splitLine[4];

                    dgvPackProdSuppl.Rows.Add(dgvRow);
                }
            }
        }

        private void dgvPackProdSuppl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Change SupplierID on change of Supplier
            if (e.ColumnIndex == 2) {
                dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value =
                    dgvPackProdSuppl.Rows[e.RowIndex].Cells[2].Value;
            }

            // Change ProdSupplierID on change of SupplierID
            if (e.ColumnIndex == 3)
            {
                string prodId = Convert.ToString(dgvPackProdSuppl.Rows[e.RowIndex].Cells[1].Value);
                string supplierId = Convert.ToString(dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value);
                dgvPackProdSuppl.Rows[e.RowIndex].Cells[4].Value = 
                    DBHandler.getNewProdSupplierId(prodId, supplierId);     
            }
        }
    }
}
