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
        // GLOBALVARIABLE WHICH CHECKS IF IT IS A NEW FORM
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
        
        //*******************************************************************************//
        //  PART NEEDED TO CREATE A CUSTOM CONTROL
        //*******************************************************************************//
        // Create new control
        TextAndButtonControlPackForm txtbtn = new TextAndButtonControlPackForm();
        // Number of the COLUMN which to apply custom control
        int colIndex = 0;

        void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == colIndex && e.RowIndex > -1 && e.RowIndex != this.dgvPackProdSuppl.NewRowIndex)
            {
                Rectangle rect = this.dgvPackProdSuppl.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                this.txtbtn.Location = rect.Location;
                this.txtbtn.Size = rect.Size;
                this.txtbtn.Text = this.dgvPackProdSuppl.CurrentCell.Value.ToString();
                // Retreive whole ROW where click happened
                this.txtbtn.rowString = this.dgvPackProdSuppl.CurrentRow;
                // Retreive whole data Grid View
                this.txtbtn.dataGridView = this.dgvPackProdSuppl;

                this.txtbtn.ButtonText = "...";
                this.txtbtn.renderControl();
                this.txtbtn.Visible = true;
            }
        }
        void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colIndex && e.RowIndex > -1 && e.RowIndex != this.dgvPackProdSuppl.NewRowIndex)
            {
               // this.dgvPackProdSuppl.CurrentCell.Value = this.txtbtn.Text;
                this.txtbtn.Visible = false;
            }
        }
        //*******************************************************************************//
        //  END OF CUSTOM CONTROL PART
        //*******************************************************************************//

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

            //**************************************************************************
            //****** ADD CUSTOM BUTTON CONTROL
            //**************************************************************************

            this.txtbtn = new TextAndButtonControlPackForm();
            this.txtbtn.Visible = false;
            this.dgvPackProdSuppl.Controls.Add(this.txtbtn);
         
            //Handle the cellbeginEdit event to show the usercontrol in the cell while editing
            this.dgvPackProdSuppl.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgv_CellBeginEdit);

            //Handle the cellEndEdit event to update the cell value
            this.dgvPackProdSuppl.CellEndEdit += new DataGridViewCellEventHandler(dgv_CellEndEdit);
            //**************************************************************************
            //****** END OF CUSTOM BUTTON CONTROL
            //**************************************************************************
        }

        // METHOD HANDLES CELL CHANGES IN DATAGRIDVIEW
        private void dgvPackProdSuppl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Clrear Suppliers combobox on change of SupplierID
            if (e.ColumnIndex == 1)
            {
                //Make a Supplier
                dgvPackProdSuppl.Rows[e.RowIndex].Cells[2].Value = null;
                
                // Create a list of possiple values to populate a combox
                List<SupplierIdPairs> supplierIdPairs =
                    PackProdSupplier.createSupplierIdPairsList(Convert.ToInt32(dgvPackProdSuppl.Rows[e.RowIndex].Cells[1].Value));
                ((DataGridViewComboBoxCell)dgvPackProdSuppl.Rows[e.RowIndex].
                    Cells[2]).DataSource = supplierIdPairs;
                ((DataGridViewComboBoxCell)dgvPackProdSuppl.Rows[e.RowIndex].
                    Cells[2]).DisplayMember = "Supplier";
                ((DataGridViewComboBoxCell)dgvPackProdSuppl.Rows[e.RowIndex].
                    Cells[2]).ValueMember = "SupplierId";
            }

            // Change SupplierID on change of Supplier
            if (e.ColumnIndex == 2) {
                if (dgvPackProdSuppl.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value =
                        dgvPackProdSuppl.Rows[e.RowIndex].Cells[2].Value;
                }
                else {
                    dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value = null;
                }
            }

            // Change ProdSupplierID on change of SupplierID
            if (e.ColumnIndex == 3)
            {
                if (dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    string prodId = Convert.ToString(dgvPackProdSuppl.Rows[e.RowIndex].Cells[1].Value);
                    string supplierId = Convert.ToString(dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value);
                    dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value =
                        DBHandler.getNewProdSupplierId(prodId, supplierId);
                }
                else {
                    dgvPackProdSuppl.Rows[e.RowIndex].Cells[3].Value = null;
                }
            }
        }

        // METOD HELPS TO SAVE VALUE IN CELL WHICH HASN'T LOST FOCUS 
        private void dgvPackProdSuppl_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPackProdSuppl.IsCurrentCellDirty)
            {
                dgvPackProdSuppl.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
