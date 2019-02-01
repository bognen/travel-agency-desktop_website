using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public static class FormHandler
    {
        // CLASS CREATED TO STORE NETHODS WHICH HANDLE ACTIONS ON FORMS
        // DIMA BOGNEN
        // DEC - 24, 2018

        //*************************************************************//
        //*** METHOD CREATES DATAGRIDVIEW IN PACKAGES_FORM  ***//
        //*************************************************************//
        public static void createProdSupplTable(DataGridView dgv) {
            // Create a DataGridView
            DataGridViewTextBoxColumn product = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn productId = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn supplier = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn supplierId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn productSupplierId = new DataGridViewTextBoxColumn();

            // Set column properties
            product.HeaderText = "Product";
            product.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 11.75F, FontStyle.Bold);
            dgv.Columns.Add(product);
            productId.HeaderText = "Product ID";
            dgv.Columns.Add(productId);
            supplier.HeaderText = "Supplier";
            supplier.FlatStyle = FlatStyle.Flat;
            supplier.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 11.75F, FontStyle.Bold);
            dgv.Columns.Add(supplier);
            supplierId.HeaderText = "SupplierID";
            dgv.Columns.Add(supplierId);
            productSupplierId.HeaderText = "ProdSupplID";
            dgv.Columns.Add(productSupplierId);

            // Make three columns invisible for technical purposes
            productId.Visible = false;
            supplierId.Visible = false;
            productSupplierId.Visible = false;

            // Set sizes of colums
            product.Width = 120;
            supplier.Width = 350;
        }

        //*************************************************************//
        //*** METHOD REFRESHES PACKAGE LIST FORM  ***//
        //*************************************************************//
        public static void upDatePackList(int packId) {

            List<Form> openForms = new List<Form>();

            foreach(Form f in Application.OpenForms)          
                openForms.Add(f);

            foreach (Form f in openForms)
            {              
                if (f.Name == "PackagesList")
                {
                    // declare int for row ID
                    int rowId=0;
                    // if the name of the form is packageList
                    // parse form class object to PackageList object

                    PackagesList pl = new PackagesList();
                    pl = (PackagesList)f;

                    for (int i=0; i< pl.dgvPackageList.Rows.Count; i++) {
                        int checkedId = Convert.ToInt32(pl.dgvPackageList.Rows[i].Cells[0].Value);
                        if (checkedId == packId) {
                            rowId = i;
                        }
                    }
                    pl.activeRow = rowId;
                    pl.PackagesForm_Load(null,null);
                }
            }
        }

        //*************************************************************//
        //*** METHOD DETECTES CHANGES IN PACKAGES_FORM  ***//
        //*************************************************************//
        public static void captureChanges(PackagesForm packForm) {
            packForm.txtName.TextChanged += new System.EventHandler(txtDesc_TextChanged);
            packForm.txtBasePrice.TextChanged += new System.EventHandler(txtDesc_TextChanged);
            packForm.txtAgComm.TextChanged += new System.EventHandler(txtDesc_TextChanged);
            packForm.txtDesc.TextChanged += new System.EventHandler(txtDesc_TextChanged);
            packForm.tpStartDate.TextChanged += new System.EventHandler(txtDesc_TextChanged);
            packForm.tpEndDate.TextChanged += new System.EventHandler(txtDesc_TextChanged);
            packForm.imgDescription.TextChanged += new System.EventHandler(txtDesc_TextChanged);

            packForm.dgvPackProdSuppl.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(txtDesc_TextChanged);
            packForm.dgvPackProdSuppl.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(txtDesc_TextChanged);
            packForm.dgvPackProdSuppl.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(txtDesc_TextChanged);

            void txtDesc_TextChanged(object sender, EventArgs e)
            {
                packForm.Text = "Package Form [Changed]*";
                Globals.packageIsChanged = true;
            }
        }
    } // end of class
} // end of name space
