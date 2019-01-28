using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraveExpertClassLibrary;

namespace TravelExperts
{
    public static class SuppliersFunctions
    {
        //Marko Jovanovic
        //Get suppliers

        public static List<Suppliers> GetSuppliers()
        {
            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

            List<Suppliers> Suppliers = new List<Suppliers>();
            Suppliers Sup;
            SqlConnection con = new SqlConnection(configString);
            string selectQuery = "SELECT SupplierId , SupName FROM Suppliers ORDER BY SupplierId asc";

            SqlCommand cmd = new SqlCommand(selectQuery, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sup = new Suppliers();
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
            string insertProducts = "INSERT INTO Products_Suppliers (SupplierId, ProductId) " +
                "VALUES(@SupplierId, @ProductId)";

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

        public static Products GetProductsAndSuppliersForUpdate(int ProductId)
        {
            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

            Products prod = null;
            SqlConnection con = new SqlConnection(configString);
            string selectStatement = "SELECT ProductID, ProdName " +
                                     "FROM Products " +
                                     "WHERE ProductId = @ProductId";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@ProductId", ProductId); // value comes from the method's argument
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read()) // found a customer
                {
                    prod = new Products();
                    prod.ProductId = (int)reader["ProductId"];
                    prod.ProdName = reader["ProdName"].ToString();
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
            return prod;
        }
    }
}
