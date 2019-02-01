using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public static class PackProdSupplierDB
    {
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

            DataTable dt = new DataTable();
            SqlConnection conn = null;
            // RETRIEVE DATA FROM DATABASE AND STORE IT IN DATATABLE
            try
            {
                conn = DBConnection.getConnection();
                using (SqlCommand command =
                    new SqlCommand((queryString + packIdIndex), conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                }
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
            ///+++++++++
            // Store retreived data into datatable and create a list
            List<PackProdSupplier> prodSuppliersList = new List<PackProdSupplier>();

            foreach (DataRow row in dt.Rows)
            {
                PackProdSupplier itemLine = new PackProdSupplier(row[0].ToString(), Convert.ToInt32(row[1]),
                                        row[2].ToString(), Convert.ToInt32(row[3]), Convert.ToInt32(row[4]));
                prodSuppliersList.Add(itemLine);
            }

            return prodSuppliersList;
        }

        // METHOD INSERTS DATA INTO PACKAGES_PRODUCTS_SUPPLIERS TABLE
        public static void insertPackages_Products_Suppliers(List<PackIdProdSupId> ppsi)
        {
            SqlConnection conn = null;
            // Create a query
            string query = @"INSERT INTO Packages_Products_Suppliers (PackageId, ProductSupplierId)
             VALUES (@PackageId, @ProductSupplierId)";

            // Insert data into DataBase
            try
            {
                conn = DBConnection.getConnection();
                  using (SqlCommand command =
                     new SqlCommand(query, conn))
                  {
                     conn.Open();
                     foreach (PackIdProdSupId item in ppsi)
                      {
                         // Add values to query
                         command.Parameters.AddWithValue("@PackageId", item.PackId);
                         command.Parameters.AddWithValue("@ProductSupplierId", item.ProdSupplierId);
                         // Execute Sql Command
                         command.ExecuteNonQuery();
                         command.Parameters.Clear();
                     }
                  }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // METHOD UPDATES DATA IN PACKAGES_PRODUCTS_SUPPLIERS TABLE
        public static void updatePackages_Products_Suppliers(List<PackIdProdSupId> ppsi, List<int> exstIndex)
        {
            int dif = ppsi.Count() - exstIndex.Count();

            string updateQuery = @"UPDATE Packages_Products_Suppliers 
                                   SET PackageId=@PackageId, ProductSupplierId=@ProductSupplierId
                                   WHERE PackageId =@PackageId
                                   AND ProductSupplierId=@OldProductSupplierId";
            string deleteQuery = @"DELETE FROM Packages_Products_Suppliers
                                   WHERE PackageId =@PackageId
                                   AND ProductSupplierId=@OldProductSupplierId";
            string addQuery = @"INSERT INTO Packages_Products_Suppliers (PackageId, ProductSupplierId)
                                   VALUES (@PackageId, @ProductSupplierId)";

            SqlConnection conn = null;
            try
            {
                conn = DBConnection.getConnection();
                    // Add values to query
                    // If number of lines in updated Data Grid View is Equal to Old one
                    if (dif == 0)
                    {
                        using (SqlCommand command = new SqlCommand(updateQuery, conn))
                        {
                            conn.Open();
                            for (int i = 0; i < dif; i++)
                            {
                                command.Parameters.AddWithValue("@PackageId", ppsi[i].PackId);
                                command.Parameters.AddWithValue("@ProductSupplierId", ppsi[i].ProdSupplierId);
                                command.Parameters.AddWithValue("@OldProductSupplierId", exstIndex[i]);
                                // Execute Sql Command
                                command.ExecuteNonQuery();
                                command.Parameters.Clear();
                            }
                        }
                    }
                    // If number of lines in updated Data Grid View is LESS THAN in Old one
                    else
                    {
                        conn.Open();
                        // Delete all existing rows 
                        using (SqlCommand command = new SqlCommand(deleteQuery, conn))
                        {
                            for (int i = 0; i < exstIndex.Count(); i++)
                            {
                                command.Parameters.AddWithValue("@PackageId", ppsi[0].PackId);
                                command.Parameters.AddWithValue("@OldProductSupplierId", exstIndex[i]);
                                // Execute Sql Command
                                command.ExecuteNonQuery();
                                command.Parameters.Clear();
                            }
                        }
                        // Add new rows
                        using (SqlCommand command = new SqlCommand(addQuery, conn))
                        {
                            for (int i = 0; i < ppsi.Count(); i++)
                            {
                                command.Parameters.AddWithValue("@PackageId", ppsi[i].PackId);
                                command.Parameters.AddWithValue("@ProductSupplierId", ppsi[i].ProdSupplierId);
                                // Execute Sql Command
                                command.ExecuteNonQuery();
                                command.Parameters.Clear();
                            }
                        }
                    }
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
    } // End of the class
} // End of the namespace
