using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public class PackProdSupplier
    {
        //Private variables
        private string product;
        private string productId;
        private string supplier;
        private string sypplierId;

        // Public properties
        public string Product { get; set; }
        public string ProductId { get; set; }
        public string Supplier { get; set; }
        public string SupplierId { get; set; }

        public PackProdSupplier(string product, string productId, string supplier, string supplierId) {
            this.Product = product;
            this.ProductId = productId;
            this.Supplier = supplier;
            this.SupplierId = supplierId;
        }

        public override string ToString() {
            return Product.ToString()+ ","+ProductId.ToString()+","+ Supplier.ToString()+
                ","+SupplierId.ToString();
        }
    }
}
