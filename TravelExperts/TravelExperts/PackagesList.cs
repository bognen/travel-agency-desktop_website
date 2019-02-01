using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TravelExperts
{
    public partial class PackagesList : Form
    {
        // Varibles used inside and outside the class
        public int activeRow { get; set; }

        private string nameContains = null;
        private DateTime? startDateBegin = null;
        private DateTime? startDateFinish = null;
        private DateTime? endDateBegin = null;
        private DateTime? endDateFinish = null;

        public PackagesList()
        {
            InitializeComponent();
        }

        public void PackagesForm_Load(object sender, EventArgs e)
        {
            // Call just data source for dataGridView
            // Source has to be DATA TABLE

            dgvPackageList.DataSource = PackageDB.getPackageList(nameContains, startDateBegin, startDateFinish,
                endDateBegin, endDateFinish);

            //HIDE ID COLUMN
            dgvPackageList.Columns[0].Visible = false;
            dgvPackageList.Columns[7].Visible = false;

            // EDIT APPEARANCE OF DATA GRID VIEW
            dgvPackageList.Columns[0].HeaderText = "ID";
            dgvPackageList.Columns[1].HeaderText = "Name";
            dgvPackageList.Columns[1].Width = 130;
            dgvPackageList.Columns[2].HeaderText = "Start Date";
            dgvPackageList.Columns[2].Width = 100;
            dgvPackageList.Columns[3].HeaderText = "End Date";
            dgvPackageList.Columns[3].Width = 100;
            dgvPackageList.Columns[4].HeaderText = "Description";
            dgvPackageList.Columns[5].Width = 310;
            dgvPackageList.Columns[5].HeaderText = "Base Price";
            dgvPackageList.Columns[5].Width = 90;
            dgvPackageList.Columns[6].HeaderText = "Commission";
            dgvPackageList.Columns[6].Width = 110;

            // SET BOLD FONT FOR COLUMN HEADERS
            dgvPackageList.Columns[1].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Bold);
            dgvPackageList.Columns[2].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Bold);
            dgvPackageList.Columns[3].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Bold);
            dgvPackageList.Columns[4].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Bold);
            dgvPackageList.Columns[5].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Bold);
            dgvPackageList.Columns[6].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Bold);

            // DATE FORMAT IN DATE COLUMNS
            dgvPackageList.Columns[2].DefaultCellStyle.Format = "dd-MMM-yyyy";
            dgvPackageList.Columns[3].DefaultCellStyle.Format = "dd-MMM-yyyy";

            // NUMBER FORMAT IN PRICE COLUMNS
            dgvPackageList.Columns[5].DefaultCellStyle.Format = "N2";
            dgvPackageList.Columns[6].DefaultCellStyle.Format = "N2";

            // SET READ ONLY TO CERTAIN COLUMNS 
            dgvPackageList.Columns[1].ReadOnly = true;
            dgvPackageList.Columns[2].ReadOnly = true;
            dgvPackageList.Columns[3].ReadOnly = true;
            dgvPackageList.Columns[4].ReadOnly = true;
            dgvPackageList.Columns[5].ReadOnly = true;
            dgvPackageList.Columns[6].ReadOnly = true;

            dgvPackageList.CurrentCell = dgvPackageList.Rows[this.activeRow].Cells[1];
        }

        //*****************************************************************************//
        // *** STRIP MENU BUTTONS *** //
        //*****************************************************************************//

        // Strip Menu ADD button
        private void addlStripButton_Click(object sender, EventArgs e)
        {
            // prepare 
            DataGridViewRow rowstring = null;

            PackagesForm packForm = new PackagesForm(rowstring);
            packForm.MdiParent = this.MdiParent;
            packForm.Show();
        }

        // Strip Menu EDIT button
        private void editStripButton_Click(object sender, EventArgs e)
        {
           // Store current row in variable
            DataGridViewRow rowstring = dgvPackageList.CurrentRow;

            // Send the row to a new form
            PackagesForm packForm = new PackagesForm(rowstring);
            packForm.MdiParent = this.MdiParent;
            packForm.Show();
        }

        // Press Enter Handler
        private void dgvPackageList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {               
                // Store current row in variable
                DataGridViewRow rowstring = dgvPackageList.CurrentRow;

                // Send the row to a new form
                PackagesForm packForm = new PackagesForm(rowstring);
                packForm.MdiParent = this.MdiParent;
                packForm.Show();
            }
        }
        
        // MethodBelow prevents Row change on Enter button
        private void dgvPackageList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int col = dgvPackageList.CurrentCell.ColumnIndex;
                int row = dgvPackageList.CurrentCell.RowIndex;

                if (col < dgvPackageList.ColumnCount - 1) {
                    col++;
                } else {
                    col = 0;
                    row++;
                }

                if (row == dgvPackageList.RowCount)
                    dgvPackageList.Rows.Add();

                dgvPackageList.CurrentCell = dgvPackageList[col, row];
                e.Handled = true;
            }
        }

        private void dgvPackageList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Store current row in variable
            DataGridViewRow rowstring = dgvPackageList.CurrentRow;

            // Send the row to a new form
            PackagesForm packForm = new PackagesForm(rowstring);
            packForm.MdiParent = this.MdiParent;
            packForm.Show();
        }

        // User clicks FILTER button
        private void filterButton_Click(object sender, EventArgs e)
        {
            PackFilter packFilter = new PackFilter(nameContains, startDateBegin, startDateFinish,
                endDateBegin, endDateFinish);
            if (packFilter.ShowDialog() == DialogResult.Yes) {
                nameContains = packFilter.txtNameCont.Text;
                // Check START DATE BEGIN
                if (DateTime.Compare(packFilter.dtpStartDateBegin.Value.Date, Constants.MINDATE.Date) == 0) {
                    startDateBegin = null; 
                } else {
                    startDateBegin = packFilter.dtpStartDateBegin.Value;
                }
                // Check START DATE FINISH
                if (DateTime.Compare(packFilter.dtpStartDateFinish.Value.Date, Constants.MAXDATE.Date) == 0) { 
                    startDateFinish = null;
                } else {
                    startDateFinish = packFilter.dtpStartDateFinish.Value;
                }
                // Check END DATE BEGIN 
                if (DateTime.Compare(packFilter.dtpEndDateBegin.Value.Date, Constants.MINDATE.Date) == 0) {
                    endDateBegin = null;
                } else {
                    endDateBegin = packFilter.dtpEndDateBegin.Value;
                }
                // Check END DATE FINISH
                if (DateTime.Compare(packFilter.dtpEndDateFinish.Value.Date, Constants.MAXDATE.Date) == 0) {
                    endDateFinish = null;
                } else { endDateFinish = packFilter.dtpEndDateFinish.Value; }

                // Check if at least ONE out of FIVE conditions is not null make CANCEL FILTER button enable
                if (nameContains != "" || startDateBegin != null || startDateFinish != null ||
                    endDateBegin != null || endDateFinish != null) {
                    cancelFilter.Enabled = true;
                }

                // Display updated List of Packages
                dgvPackageList.DataSource = PackageDB.getPackageList(nameContains, startDateBegin, startDateFinish,
                endDateBegin, endDateFinish);
            }
        }

        // User clicks CANCEL FILTER button
        private void cancelFilter_Click(object sender, EventArgs e)
        {
            // NUll down all conditions and display updated List of Packages
            nameContains = null;
            startDateBegin = null;
            startDateFinish = null;
            endDateBegin = null;
            endDateFinish = null;
            dgvPackageList.DataSource = PackageDB.getPackageList(nameContains, startDateBegin, startDateFinish,
                    endDateBegin, endDateFinish);

            // Disable this button
            cancelFilter.Enabled = false;
        }
    } //end of the class
} // end of Namespace
