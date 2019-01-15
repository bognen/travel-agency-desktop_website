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

        public void pACKEGESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            PackagesList packagesList = new PackagesList();
            packagesList.MdiParent = this ;
            packagesList.Show();
          
        }

        public void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.MdiParent = this;
            productForm.Show();
        }

        public void sUPPLIERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.MdiParent = this;
            supplierForm.Show();
        }

        public void bOOKINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.MdiParent = this;
            bookingForm.Show();
        }

    }
}
