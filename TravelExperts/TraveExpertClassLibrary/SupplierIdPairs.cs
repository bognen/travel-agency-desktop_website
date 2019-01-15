using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public class SupplierIdPairs
    {

        // Public properties
        public string Supplier { get; set; } // It is display member
        public int SupplierId { get; set; }  // It is value member

        // Class constoructor
        public SupplierIdPairs(string supplierName, int supplierId) {
            this.Supplier = supplierName;
            this.SupplierId = supplierId;
        }

        // method returns supplierName as a string
        public string supplierIdPairName() {
            return Supplier;
        }
    }
}
