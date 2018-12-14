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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void pACKEGESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackagesForm packagesForm = new PackagesForm();
            packagesForm.MdiParent = this ;
            packagesForm.Show();
        }

        private void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.MdiParent = this;
            productForm.Show();
        }

        private void sUPPLIERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.MdiParent = this;
            supplierForm.Show();
        }
    }
}
