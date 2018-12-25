using System;
using System.Collections.Generic;
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
            dgv.Columns.Add(product);
            productId.HeaderText = "Product ID";
            dgv.Columns.Add(productId);
            supplier.HeaderText = "Supplier";
            supplier.FlatStyle = FlatStyle.Flat;
            dgv.Columns.Add(supplier);
            supplierId.HeaderText = "SupplierID";
            dgv.Columns.Add(supplierId);
            productSupplierId.HeaderText = "ProdSupplID";
            dgv.Columns.Add(productSupplierId);

            // Make three columns invisible for technical purposes
            productId.Visible = false;
            supplierId.Visible = false;
            productSupplierId.Visible = false;

        }
    }
}
