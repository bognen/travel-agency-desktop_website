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
        public static DataTable getPackageList() {
            DataTable packageList = new DataTable();
            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(configString)) {
                using (SqlCommand command = new SqlCommand("select * from Packages", conn)) {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    packageList.Load(reader);
                }
            }
            return packageList;
        }

        

            public static DataTable getPackageListBookings()
        {
            DataTable packageList = new DataTable();
            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(configString))
            {
                using (SqlCommand command = new SqlCommand("select * from BookingDetails", conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    packageList.Load(reader);
                }
            }
            return packageList;
        }

        public static DataTable getPackageProdSuppliers(int packIdIndex)
            { 
            DataTable packageProdSupplList = new DataTable();

            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(configString))
            {
                using (SqlCommand command = 
                    new SqlCommand((@"select Products.ProdName, Products.ProductId, Suppliers.SupName, Suppliers.SupplierId 
                            from Packages_Products_Suppliers
                            Inner Join Packages on Packages.PackageId=Packages_Products_Suppliers.PackageId
                            Inner Join Products_Suppliers on Products_Suppliers.ProductSupplierId = Packages_Products_Suppliers.ProductSupplierId
                            Inner Join Products on Products.ProductId=Products_Suppliers.ProductId
                            Inner Join Suppliers on Suppliers.SupplierId=Products_Suppliers.SupplierId
                            where Packages.PackageId=" + packIdIndex), conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    packageProdSupplList.Load(reader);
                }
            }


            return packageProdSupplList;
        }

    }

}
