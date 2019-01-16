using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public static class jamesProductsDB
    {
        /// <summary>
        /// This class is used for updating and adding records in the database
        /// Author: James Cockriell
        /// Date: January 10/2019
        /// </summary>

        static string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

        // gets a list of Products from the database to display in a datagrid view
        public static List<Products> GetProducts()
        {
            List<Products> Products = new List<Products>();
            Products pro;           
            SqlConnection con = new SqlConnection(configString);
            string selectQuery = "SELECT ProductId , ProdName FROM Products ORDER BY ProductId asc";

            SqlCommand cmd = new SqlCommand(selectQuery, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pro = new Products();
                    pro.ProductId = (int)reader["ProductId"];
                    pro.ProdName = (string)reader["ProdName"];
                    Products.Add(pro);
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
                return Products;            
        }


        //add a new product to the products, products_supplier table
        public static int AddProducts(string prod)
        {
            int success = 0;
            SqlConnection con = new SqlConnection(configString);
            string insertProducts = "INSERT INTO Products (ProdName) " +
                "VALUES(@ProdName)";

            SqlCommand cmd = new SqlCommand(insertProducts, con);
            cmd.Parameters.AddWithValue("@prodName", prod);
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

