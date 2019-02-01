using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TravelExperts
{
    public class PackFormValidator
    {
        // CLASS CREATED TO STORE METHODS WHICH VALIDATE PACKAGE FORM INPUT BEFORE IT CAN BE
        // SAVED INTO DATABASE
        // DIMA BOGNEN
        // DEC - 27, 2018

        // Method checks if Agency Commision is less than Base Price
        public static bool checkCommission(TextBox tbPrice, TextBox tbCommission) {
            bool result = true;
            Decimal num;
            if (tbPrice.Text == null || tbPrice.Text == "")
            {
                result = false;
                MessageBox.Show("Price has to be FILLED");
                tbPrice.Focus();
            } else if (tbCommission.Text == null || tbCommission.Text == "") {
                result = false;
                MessageBox.Show("Commission has to be FILLED");
                tbCommission.Focus();
            } else if (!Decimal.TryParse(tbPrice.Text, out num))
            {
                result = false;
                MessageBox.Show("Price is supposed to be a number");
                tbPrice.Focus();
            }
            else if (!Decimal.TryParse(tbCommission.Text, out num))
            {
                result = false;
                MessageBox.Show("Commission is supposed to be a number");
                tbCommission.Focus();
            } else if (Convert.ToDecimal(tbPrice.Text) < 0)
            {
                result = false;
                MessageBox.Show("Price CANNOT be negative value");
                tbPrice.Focus();
            } else if (Convert.ToDecimal(tbCommission.Text) < 0)
            {
                result = false;
                MessageBox.Show("Commission CANNOT be negative value");
                tbCommission.Focus();
            }

            else if (Convert.ToDecimal(tbCommission.Text) > Convert.ToDecimal(tbPrice.Text)) {
                result = false;
                MessageBox.Show("Commission CANNOT be greater than a base price");
                tbCommission.Focus();
            }
            return result;
        }

        // Method checks if start date less than end date
        public static bool checkDates(DateTimePicker startDate, DateTimePicker endDate) {
            bool result=true;
            if (Convert.ToDateTime(startDate.Text) > Convert.ToDateTime(endDate.Text))
            {
                result = false;
                MessageBox.Show("A travel package's start date CANNOT be later than its end date");
                endDate.Focus();
            }
            return result;
        }

        // Method checks if Name and descripton field have been filled
        public static bool checkTextFields(TextBox tbName, TextBox tbDesc) {
            bool result = true;
            if (tbName.Text == null || tbName.Text == "")
            {
                result = false;
                MessageBox.Show("A travel package needs to have a descriptive name");
                tbName.Focus();
            }
            else if (tbDesc.Text == null || tbDesc.Text == "") {
                result = false;
                MessageBox.Show("Description is REQUIRED field");
                tbDesc.Focus();
            }
            return result;
        }

        //************************************************************************************
        // METHODS TO CHECK TABLE INSIDE THE FORM
        //************************************************************************************

        // Method checks if Product_sipplier DatagridView is not empty
        public static bool dgvIsNotEmpty(DataGridView dgv) {
            bool result = true;
            if (dgv.Columns.Count == 0) {
                result = false;
                MessageBox.Show("A package has to include at least one product");
                dgv.Focus();
            }
            return result;
        }

        // Method checks if Product_sipplier DatagridView is not empty
        public static bool dgvIsFilled(DataGridView dgv) {
            bool result = true;

            foreach (DataGridViewRow row in dgv.Rows) {
                foreach (DataGridViewCell cell in row.Cells) {
                    if (cell.Value == null || cell.Value == "") {
                        result = false;
                        MessageBox.Show("Information about Products and suppliers is NOT completed");
                        if (cell.Visible == true)
                        {
                            dgv.CurrentCell = cell;
                            dgv.BeginEdit(true);
                        }
                        break;
                    }
                }
            }
            return result;
        }

    } // end of class
} // end of namespace
