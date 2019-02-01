using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraveExpertClassLibrary
{
    public class Supplier
    {
        public Supplier() { }

        public Supplier(string v) { }

        public int SupplierId { get; set; }

        public string SupName { get; set; }

        // Class constoructor
        public Supplier(string supplierName, int supplierId)
        {
            this.SupName = supplierName;
            this.SupplierId = supplierId;
        }
    }
}
