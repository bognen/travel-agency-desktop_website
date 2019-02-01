using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    // CLASS CREATED TO STORE METHODS WHICH VALIDATE PACKAGE FILTER INPUT BEFORE
    // IT RETREIVES DATA FROM DB
    // DIMA BOGNEN
    // JAN - 24, 2019
    public class PackFilterValidator
    {
        public static bool checkStartDates(DateTimePicker startDate, DateTimePicker endDate)
        {
            bool result = true;
            if (Convert.ToDateTime(startDate.Value) > Convert.ToDateTime(endDate.Value))
            {
                result = false;
                MessageBox.Show("First date CANNOT be greater than the second");
                endDate.Focus();
            }
            return result;
        }
        public static bool checkToFromDates(DateTimePicker startDate, DateTimePicker endDate)
        {
            bool result = true;
            if (Convert.ToDateTime(startDate.Value) > Convert.ToDateTime(endDate.Value))
            {
                result = false;
                MessageBox.Show("Start date CANNOT be greater than the end date");
                endDate.Focus();
            }
            return result;
        }
    }
}
