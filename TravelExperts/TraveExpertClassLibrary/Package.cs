using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public class Package
    {
        // Class constoructor
        public Package() { }

        // Public properties
        public string PackName { get; set; } 
        public DateTime PackStartDate { get; set; }
        public DateTime PackEndDate { get; set; }
        public string PackDesc { get; set; }
        public decimal PackBasePrice { get; set; }
        public decimal PackAgncyCommission { get; set; }

        public string PkgImage { get; set; }



    }
}
