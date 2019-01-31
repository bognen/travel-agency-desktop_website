using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraveExpertClassLibrary
{
    // CLASS IS USED TO FORM AND USE PAIRS OF PACKAGE_Id AND PRODUCT_SUPPLIER_Id
    // CLASS IS CREATED IN PACKAGE_FORM form AND USED IN DB HANDLER
    // DEC 24, 2018
    // DIMA BOGNEN
    public class PackIdProdSupId
    {
        // Public properties
        public int PackId { get; set; }
        public int ProdSupplierId { get; set; }

        // Class constoructor
        public PackIdProdSupId(int packid, int prodsupplierid)
        {
            this.PackId = packid;
            this.ProdSupplierId = prodsupplierid;
        }
    }
}
