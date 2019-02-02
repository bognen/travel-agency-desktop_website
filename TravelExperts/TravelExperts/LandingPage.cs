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
            // Create a list of open forms and bool result 
            List<Form> openForms = new List<Form>();
            bool formIsNew = true;

            // Fill up a list of forms 
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            // Check if there is a the same form that user tries to open 
            foreach (Form f in openForms)
            {
                if (f.Name == "PackagesList")
                {
                    f.Focus();
                    formIsNew = false;
                }
            }

            // If form is not opened yet open a new one
            if (formIsNew == true)
            {
                PackagesList packagesList = new PackagesList();
                packagesList.MdiParent = this;
                packagesList.Show();
            }
        }

        public void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a list of open forms and bool result 
            List<Form> openForms = new List<Form>();
            bool formIsNew = true;

            // Fill up a list of forms 
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            // Check if there is a the same form that user tries to open 
            foreach (Form f in openForms)
            {
                if (f.Name == "ProductForm")
                {
                    f.Focus();
                    formIsNew = false;
                }
            }

            // If form is not opened yet open a new one
            if (formIsNew == true)
            {
                ProductForm productForm = new ProductForm();
                productForm.MdiParent = this;
                productForm.Show();
            }
        }

        public void bOOKINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.MdiParent = this;
            bookingForm.Show();
        }

        private void viewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a list of open forms and bool result 
            List<Form> openForms = new List<Form>();
            bool formIsNew = true;

            // Fill up a list of forms 
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            // Check if there is a the same form that user tries to open 
            foreach (Form f in openForms)
            {
                if (f.Name == "SupplierForm")
                {
                    f.Focus();
                    formIsNew = false;
                }
            }

            // If form is not opened yet open a new one
            if (formIsNew == true)
            {
                SupplierForm supplierForm = new SupplierForm();
                supplierForm.MdiParent = this;
                supplierForm.Show();
            }

        }

        private void addNewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a list of open forms and bool result 
            List<Form> openForms = new List<Form>();
            bool formIsNew = true;

            // Fill up a list of forms 
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            // Check if there is a the same form that user tries to open 
            foreach (Form f in openForms)
            {
                if (f.Name == "AddSupplierForm")
                {
                    f.Focus();
                    formIsNew = false;
                }
            }

            // If form is not opened yet open a new one
            if (formIsNew == true)
            {
                AddSupplierForm supplierForm = new AddSupplierForm();
                supplierForm.MdiParent = this;
                supplierForm.Show();
            }
        }

        private void productsWithSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a list of open forms and bool result 
            List<Form> openForms = new List<Form>();
            bool formIsNew = true;

            // Fill up a list of forms 
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            // Check if there is a the same form that user tries to open 
            foreach (Form f in openForms)
            {
                if (f.Name == "ProductsWithSuppliers")
                {
                    f.Focus();
                    formIsNew = false;
                }
            }

            // If form is not opened yet open a new one
            if (formIsNew == true)
            {
                ProductsWithSuppliers supplierForm  = new ProductsWithSuppliers();
                supplierForm.MdiParent = this;
                supplierForm.Show();
            }
        }
    }
}
