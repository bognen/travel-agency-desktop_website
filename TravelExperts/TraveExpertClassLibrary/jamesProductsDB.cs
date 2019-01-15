using System;
using System.Collections.Generic;
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
        /// <returns>list of Products</returns>

        public static List<Products> GetProducts()
        {
            List<Products> Products = new List<Products>();
            Products pro;
            SqlConnection con = jamesDBConnect.getConnection();
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
        public static void AddCustomer()
        {
            bool success = false;
            SqlConnection con = jamesDBConnect.getConnection();
            string insertProducts = "INSERT INTO Products (ProdName) " +
                "VALUES(@ProdName)";

            SqlCommand cmd = new SqlCommand(insertProducts, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            
        }
        // method to put the customer data from text boxes into variables
    }
}
