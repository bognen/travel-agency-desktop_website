using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraveExpertClassLibrary;

namespace TravelExperts
{
    public partial class BookingForm : Form
    {
        
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Bookings' table. You can move, or remove it, as needed.
            bookingDetails.DataSource = DBHandler.getPackageListBookings();

            //HIDE ID COLUMN
            bookingDetails.Columns[0].Visible = false;

            // EDIT APPEARANCE OF DATA GRID VIEW
            bookingDetails.Columns[1].HeaderText = "Itenerary Number";
            bookingDetails.Columns[2].HeaderText = "Start of Trip";
            bookingDetails.Columns[3].HeaderText = "End of Trip";
            bookingDetails.Columns[4].HeaderText = "Travel Path";
            bookingDetails.Columns[5].HeaderText = "Destination";
            bookingDetails.Columns[6].HeaderText = "Price";
            bookingDetails.Columns[7].HeaderText = "Commission";

            //HIDE MORE ID COLUMNS
            bookingDetails.Columns[8].Visible = false;
            bookingDetails.Columns[9].Visible = false;
            bookingDetails.Columns[10].Visible = false;
            bookingDetails.Columns[11].Visible = false;
            bookingDetails.Columns[12].Visible = false;
        }

    }
}
