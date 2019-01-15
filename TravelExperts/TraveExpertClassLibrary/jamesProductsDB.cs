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
        /// This is a class utilizing the properties to get products values from the database, and place them in a new list object
        /// Author: James Cockriell
        /// Date: January 10/2019
        /// </summary>
        /// <returns>list of Products</returns>

        public static List<Products> GetProducts()
        {
            List<Products> Products = new List<Products>();
            Products pro;
            SqlConnection con = jamesDBConnect.getConnection();
            string selectQuery = "SELECT ProductId, ProdName FROM Products ORDER BY ProductId ASC ";

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
    }
}
