using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace TravelExperts
{
    public static class DBHandler
    {
        // Variables needed for different methods within this class
        static string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

        public static DataTable getPackageList() {
            DataTable packageList = new DataTable();
            
            using (SqlConnection conn = new SqlConnection(configString)) {
                using (SqlCommand command = new SqlCommand("select * from Packages", conn)) {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    packageList.Load(reader);
                }
            }
            return packageList;
        }

        // METHOD WHICH RETRIEVES DATA FROM DATABASE AND RETURNS LIST PACK-PROD-SUPPLIERS TO A FORM
        public static List<PackProdSupplier> getProdSuppliersForDGV(int packIdIndex)
        {
            string queryString = @"select Products.ProdName, Products.ProductId, 
                                          Suppliers.SupName, Suppliers.SupplierId, 
                                          Products_Suppliers.ProductSupplierId
                   from Packages_Products_Suppliers
                       Inner Join Packages on Packages.PackageId = Packages_Products_Suppliers.PackageId
                       Inner Join Products_Suppliers on Products_Suppliers.ProductSupplierId = Packages_Products_Suppliers.ProductSupplierId
                       Inner Join Products on Products.ProductId = Products_Suppliers.ProductId
                       Inner Join Suppliers on Suppliers.SupplierId = Products_Suppliers.SupplierId
                   where Packages.PackageId =";


            // Store retreived data into datatable and create a list
            DataTable packageProdSupplList = retreiveData(queryString,packIdIndex);
            List<PackProdSupplier> prodSuppliersList = new List<PackProdSupplier>();

            foreach (DataRow row in packageProdSupplList.Rows)
            {
                PackProdSupplier itemLine = new PackProdSupplier(row[0].ToString(), Convert.ToInt32(row[1]),
                                        row[2].ToString(), Convert.ToInt32(row[3]), Convert.ToInt32(row[4]));
                prodSuppliersList.Add(itemLine);
            }

            return prodSuppliersList;
        }
       
        // METHOD RETURNS LIST OF SUPPLIER-ID PAIRS TO POPULATE COMBOBOX
        public static List<SupplierIdPairs> supplierIdPairsList(int prodID)
        {
            DataTable suppliersDT = new DataTable();
            string supplierIdPairsQuery = @"select Suppliers.SupName, Suppliers.SupplierId
                            from Products_Suppliers
                            inner join Suppliers on Suppliers.SupplierId=Products_Suppliers.SupplierId
                            where Products_Suppliers.ProductId=";
            
            suppliersDT = retreiveData(supplierIdPairsQuery,prodID);

            // Create a list to store supplier-Id pairs
            List<SupplierIdPairs> pairs = new List<SupplierIdPairs>();

            // Store data from data table in the list
            foreach (DataRow row in suppliersDT.Rows)
            {
                SupplierIdPairs pair = new SupplierIdPairs(row[0].ToString(), Convert.ToInt32(row[1]));
                pairs.Add(pair);
            }
            return pairs;
        }

        //*** METHOD TO RETRIVE A PRODUCT_SUPPLIER_ID BASE ON PROD_ID AND SUPPLIER_ID
        public static string getNewProdSupplierId(string prodId, string supplierId)
        {
            SqlConnection conn = null;
            string newProdSupplierId;
            try
            {
                using (conn = new SqlConnection(configString))
                {
                    using (SqlCommand command =
                        new SqlCommand((@"select Products_Suppliers.ProductSupplierId from Products_Suppliers
                            where Products_Suppliers.ProductId =" + prodId +
                            "and Products_Suppliers.SupplierId =" + supplierId), conn))
                    {
                        conn.Open();
                        int intSupplierId = 0;
                       intSupplierId = (int)command.ExecuteScalar();
                       newProdSupplierId = Convert.ToString(intSupplierId);
                    }
                }
                
                return newProdSupplierId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //*** METHOD WHICH RETEIVES DATA FROM DB USING INDEX PARAMETER AND QUERY STRING AND RETURNS DATATABLE
        private static DataTable retreiveData(string myQuery,int index) {
            DataTable dt = new DataTable();
            SqlConnection conn = null;
            // RETRIEVE DATA FROM DATABASE AND STORE IT IN DATATABLE
            try
            {
                using (conn = new SqlConnection(configString))
                {
                    using (SqlCommand command =
                        new SqlCommand((myQuery + index), conn))
                    {
                        conn.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        dt.Load(reader);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //***********FOR TEMPORARY FORM*********
        public static DataTable temporaryProducts() {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(configString))
            {
                using (SqlCommand command = new SqlCommand("select * from Products", conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }
    } // end of class
} // end of namespace
