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
            }

        }

        private void PackagesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
