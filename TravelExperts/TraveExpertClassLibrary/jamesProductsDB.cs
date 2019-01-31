using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraveExpertClassLibrary;

namespace TraveExpertClassLibrary
{
    public static class jamesProductsDB
    {
        /// <summary>
        /// This class is used for updating and adding records in the database
        /// Author: James Cockriell
        /// Date: January 10/2019
        /// </summary>

        static string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

        // gets a list of Products from the database to display in the datagrid view on the ProductForm.cs page
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

        // get the initial info from the Products table to display into the products update form
        public static Products GetProductsForUpdate(int ProductId)
        {
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

        // update products table
        public static bool UpdateProducts(Products oldProd, Products newProd)
        {
            SqlConnection con = new SqlConnection(configString);
            string updateStatement = "UPDATE Products " +
                "SET ProdName = @NewProdName " +
                "WHERE ProductId = @OldProductId " +
                "AND ProdName = @OldProdName";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@NewProdName", newProd.ProdName);
            cmd.Parameters.AddWithValue("@OldProductId", oldProd.ProductId);
            cmd.Parameters.AddWithValue("@OldProdName", oldProd.ProdName);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}    

