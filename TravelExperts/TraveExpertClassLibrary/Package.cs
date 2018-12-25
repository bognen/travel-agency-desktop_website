using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public class Package
    {
        // Public properties
        public string PackName { get; set; } 
        public DateTime PackStartDate { get; set; }
        public DateTime PackEndDate { get; set; }
        public string PackDesc { get; set; }
        public decimal PackBasePrice { get; set; }
        public decimal PackAgncyCommission { get; set; }


        // Class constoructor
        public Package(string packname, DateTime packstartdate, DateTime packenddate, 
            string packdesc, decimal packbaseprice, decimal packagncycommission)
        {
            this.PackName = packname;
            this.PackStartDate = packstartdate;
            this.PackEndDate = packenddate;
            this.PackDesc = packdesc;
            this.PackBasePrice = packbaseprice;
            this.PackAgncyCommission = packagncycommission;
        }
    }
}
