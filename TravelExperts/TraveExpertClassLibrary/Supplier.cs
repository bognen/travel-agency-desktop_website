using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public class Supplier
    {

        // Public properties
        public string SupplierName { get; set; } // It is display member
        public int SupplierId { get; set; }  // It is value member

        // Class constoructor
        public Supplier(string supplierName, int supplierId)
        {
            this.SupplierName = supplierName;
            this.SupplierId = supplierId;
        }
    }
}
