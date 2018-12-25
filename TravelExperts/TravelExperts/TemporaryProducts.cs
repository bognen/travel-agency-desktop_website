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
    public partial class TemporaryProducts : Form
    {
        // Variable to investigate global variables
        bool openedFromPack = false;

        public TemporaryProducts(bool fromPackForm)
        {
            InitializeComponent();
            // If any value was passed, change value of global boolean
            if (fromPackForm == true) {
                openedFromPack = true;
            }

            //*************/
            // Can try to use this to determine a modal window
            if (this.Modal == true) { }
        }

        private void TemporaryProducts_Load(object sender, EventArgs e)
        {
            // if the form was opened from Pack form  SELECT button is vosible
            // otherwise it is not
            if (openedFromPack == true)
            {
                btnSelect.Visible = true;
            }
            else {
                btnSelect.Visible = false;
            }

            TempDGV.DataSource = DBHandler.temporaryProducts();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
