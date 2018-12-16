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
        public PackagesList()
        {
            InitializeComponent();
        }

        private void PackagesForm_Load(object sender, EventArgs e)
        {
            // Call just data source for dataGridView
            // Source has to be DATA TABLE

            dgvPackageList.DataSource = DBHandler.getPackageList();

            //HIDE ID COLUMN
            dgvPackageList.Columns[0].Visible = false;

            // EDIT APPEARANCE OF DATA GRID VIEW
            dgvPackageList.Columns[0].HeaderText = "ID";
            dgvPackageList.Columns[1].HeaderText = "Name";
            dgvPackageList.Columns[2].HeaderText = "Start Date";
            dgvPackageList.Columns[3].HeaderText = "End Date";
            dgvPackageList.Columns[4].HeaderText = "Description";
            dgvPackageList.Columns[5].HeaderText = "Base Price";
            dgvPackageList.Columns[6].HeaderText = "Commission";

            // NUMBER FORMAT IN PRICE COLUMNS
            dgvPackageList.Columns[5].DefaultCellStyle.Format = "N2";
            dgvPackageList.Columns[6].DefaultCellStyle.Format = "N2";
        }
    }
}
