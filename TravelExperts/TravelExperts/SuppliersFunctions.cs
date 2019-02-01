using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public static class SuppliersFunctions
    {
        //Marko Jovanovic
        //Get suppliers

        public static List<Supplier> GetSuppliers()
        {
            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

            List<Supplier> Suppliers = new List<Supplier>();
            Supplier Sup;
            SqlConnection con = new SqlConnection(configString);
            string selectQuery = "SELECT SupplierId , SupName FROM Suppliers ORDER BY SupplierId asc";

            SqlCommand cmd = new SqlCommand(selectQuery, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sup = new Supplier();
                    Sup.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    Sup.SupName = (string)reader["SupName"];
                    Suppliers.Add(Sup);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return Suppliers;
        }

        public static List<ProductsSuppliers> GetRelations()
        {
            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

            List<ProductsSuppliers> Suppliers = new List<ProductsSuppliers>();
            ProductsSuppliers Sup;
            SqlConnection con = new SqlConnection(configString);
            string selectQuery = " select ProductSupplierId, ProductId, SupplierId from dbo.Products_Suppliers";

            SqlCommand cmd = new SqlCommand(selectQuery, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sup = new ProductsSuppliers();
                    Sup.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);
                    if (reader["ProductId"] == DBNull.Value)
                    {
                        Sup.ProductId = null;
                    }
                    else
                    {
                        Sup.ProductId = Convert.ToInt32(reader["ProductId"]);
                    }

                    if (reader["SupplierId"] == DBNull.Value)
                    {
                        Sup.SupplierId = null;
                    }
                    else
                    {
                        Sup.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    }
                    //Sup.ProductId = Convert.ToInt32(reader["ProductId"]);
                    //Sup.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    Suppliers.Add(Sup);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return Suppliers;
        }

        public static ProductsSuppliers GetTwoValues(int ProdSupID)
        {
            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

            //List<ProductsSuppliers> InfoList = new List<ProductsSuppliers>();
            ProductsSuppliers info = new ProductsSuppliers();
            SqlConnection con = new SqlConnection(configString);
            string selectQuery = " select ProdName, SupName from dbo.Products_Suppliers ps " +
                "join Products p on ps.ProductId = p.ProductId " +
                "join Suppliers s on ps.SupplierId = s.SupplierId " +
                "where ProductSupplierId = @ProductSupplierId";

            SqlCommand cmd = new SqlCommand(selectQuery, con);
            cmd.Parameters.AddWithValue("@ProductSupplierId", ProdSupID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    info.ProdName = Convert.ToString(reader["ProdName"]);
                    info.SupName = Convert.ToString(reader["SupName"]);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return info;
        }

        public static int AddSuppliers(int product, int supplier)
        {
            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;
            int success = 0;

            SqlConnection con = new SqlConnection(configString);

            //++ Dima Bognen
            // Jan 31, 2019 
            // Changed SQL query so it doesn't insert duplicate values 
            //string insertProducts = "INSERT INTO Products_Suppliers (SupplierId, ProductId) " +
            //                        "VALUES(@SupplierId, @ProductId)";

            string insertProducts = "INSERT INTO Products_Suppliers(ProductId, SupplierId) " +
                                    "SELECT @ProductId, @SupplierId " +
                                    "WHERE NOT EXISTS(SELECT * FROM Products_Suppliers " +
                                    "WHERE  ProductId = @ProductId  AND SupplierId = @SupplierId)";
            // -- Dima Bognen, End of change

            SqlCommand cmd = new SqlCommand(insertProducts, con);
            cmd.Parameters.AddWithValue("@ProductId", product);
            cmd.Parameters.AddWithValue("@SupplierId", supplier);
            try
            {
                con.Open();
                success = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            
            finally
            {
                con.Close();
            }
            return success;
        }

        public static int GetProductsAndSuppliersForUpdate(int RelationId, int Product, int Supplier)
        {

            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

            int success = 0;
            SqlConnection con = new SqlConnection(configString);

            //++ Dima Bognen
            // Jan 31, 2019 
            // Changed SQL query so it doesn't update duplicate values 
            //string selectStatement = "UPDATE Products_Suppliers " +
            //                         "SET ProductId = @ProductId, SupplierId = @SupplierId " +
            //                         "WHERE ProductSupplierId = @ProductSupplierId";

            string selectStatement = "UPDATE Products_Suppliers " +
                               "SET ProductId = @ProductId, SupplierId = @SupplierId " +
                               "WHERE NOT EXISTS(SELECT * FROM Products_Suppliers " +
                               "WHERE  ProductId = ProductId  AND SupplierId = @SupplierId) " +
                               "AND ProductSupplierId = @ProductSupplierId";
            //-- Dima Bognen - End Of Change

            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@ProductSupplierId", RelationId); // value comes from the method's argument
            cmd.Parameters.AddWithValue("@SupplierId", Supplier);
            cmd.Parameters.AddWithValue("@ProductId", Product);
            try
            {
                con.Open();
                success = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
            return success;
        }
    }
}
