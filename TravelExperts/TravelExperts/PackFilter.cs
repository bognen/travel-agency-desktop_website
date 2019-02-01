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
    // FORM CREATED TO FILTER LIST OF PACKAGES
    // DIMA BOGNEN
    // JAN - 24, 2019

    public partial class PackFilter : Form
    {
        public PackFilter(string packName, DateTime? startDateBegin, DateTime? startDateFinish,
            DateTime? endDateBegin, DateTime? endDateFinish)
        {
            InitializeComponent();
            txtNameCont.Text = packName;
            if (startDateBegin == null){
                dtpStartDateBegin.Value = Constants.MINDATE;
                dtpStartDateBegin.CustomFormat = "  ";                
            }
            else {
                dtpStartDateBegin.Value = startDateBegin.Value;
            }

            if (startDateFinish == null) {
                dtpStartDateFinish.Value = Constants.MAXDATE;
                dtpStartDateFinish.CustomFormat = "  ";
            }
            else {
                dtpStartDateFinish.Value = startDateFinish.Value;
            }

            if (endDateBegin == null) {
                dtpEndDateBegin.Value = Constants.MINDATE;
                dtpEndDateBegin.CustomFormat = "  ";
            } else {
                dtpEndDateBegin.Value = endDateBegin.Value;
            }

            if (endDateFinish==null) {
                dtpEndDateFinish.Value = Constants.MAXDATE;
                dtpEndDateFinish.CustomFormat = "  ";
            } else {
                dtpEndDateFinish.Value = endDateFinish.Value; }
        }

        // User clicks APPLY button
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (PackFilterValidator.checkStartDates(dtpStartDateBegin, dtpStartDateFinish) && 
                PackFilterValidator.checkStartDates(dtpEndDateBegin, dtpEndDateFinish)) {
                this.DialogResult = DialogResult.Yes;
            }
        }

        //***********************************************************************//
        //***EVENTS WHICH HANDLE DATETIME PICKERS GET FOCUSED (START EDITING)***//
        //***********************************************************************//

        // START_DATE_BEGIN gets focus
        private void dtpStartDateBegin_Enter(object sender, EventArgs e)
        {
            DateTime dateInCell = dtpStartDateBegin.Value;
            if (DateTime.Compare(dateInCell.Date, Constants.MINDATE.Date) == 0)
            {
                dtpStartDateBegin.Value = DateTime.Today;
                dtpStartDateBegin.CustomFormat = "dd MMM yyyy";
            }
            else {
                dtpStartDateBegin.Value = dateInCell;
                dtpStartDateBegin.CustomFormat = "dd MMM yyyy";
            }
        }

        // START_DATE_FINISH gets focus
        private void dtpStartDateFinish_Enter(object sender, EventArgs e)
        {
            DateTime dateInCell = dtpStartDateFinish.Value;
            if (DateTime.Compare(dateInCell.Date, Constants.MAXDATE.Date) == 0)
            {
                dtpStartDateFinish.Value = DateTime.Today;
                dtpStartDateFinish.CustomFormat = "dd MMM yyyy";
            }
            else
            {
                dtpStartDateFinish.Value = dateInCell;
                dtpStartDateFinish.CustomFormat = "dd MMM yyyy";
            }
        }

        // END_DATE_BEGIN gets focus
        private void dtpEndDateBegin_Enter(object sender, EventArgs e)
        {
            DateTime dateInCell = dtpEndDateBegin.Value;
            if (DateTime.Compare(dateInCell.Date, Constants.MINDATE.Date) == 0)
            {
                dtpEndDateBegin.Value = DateTime.Today;
                dtpEndDateBegin.CustomFormat = "dd MMM yyyy";
            }
            else
            {
                dtpEndDateBegin.Value = dateInCell;
                dtpEndDateBegin.CustomFormat = "dd MMM yyyy";
            }
        }

        // END_DATE_FINISH gets focus
        private void dtpEndDateFinish_Enter(object sender, EventArgs e)
        {
            DateTime dateInCell = dtpEndDateFinish.Value;
            if (DateTime.Compare(dateInCell.Date, Constants.MAXDATE.Date) == 0)
            {
                dtpEndDateFinish.Value = DateTime.Today;
                dtpEndDateFinish.CustomFormat = "dd MMM yyyy";
            }
            else
            {
                dtpEndDateFinish.Value = dateInCell;
                dtpEndDateFinish.CustomFormat = "dd MMM yyyy";
            }
        }

        //***********************************************************************//
        //***EVENTS WHICH HANDLE WHEN USER CLICKS ***//
        //***********************************************************************//

        // User clicks DELETE button for START_DATE_BEGIN
        private void dtpStartDateBegin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtpStartDateBegin.Focused)
                {
                    dtpStartDateBegin.Value = Constants.MINDATE;
                    dtpStartDateBegin.CustomFormat = "  ";
                }

            }
        }

        // User clicks DELETE button for START_DATE_FINISH
        private void dtpStartDateFinish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtpStartDateFinish.Focused)
                {
                    dtpStartDateFinish.Value = Constants.MAXDATE;
                    dtpStartDateFinish.CustomFormat = "  ";
                }

            }
        }

        // User clicks DELETE button for END_DATE_BEGIN
        private void dtpEndDateBegin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtpEndDateBegin.Focused)
                {
                    dtpEndDateBegin.Value = Constants.MINDATE;
                    dtpEndDateBegin.CustomFormat = "  ";
                }

            }
        }

        // User clicks DELETE button for END_DATE_FINISH
        private void dtpEndDateFinish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtpEndDateFinish.Focused)
                {
                    dtpEndDateFinish.Value = Constants.MAXDATE;
                    dtpEndDateFinish.CustomFormat = "  ";
                }

            }
        }
    } // end of the class
} // end of thenamespace
