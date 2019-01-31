using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraveExpertClassLibrary;

namespace TravelExperts
{
    public static class SupplierDB
    {
        // Andy Gao
        public static List<Supplier> GetSupplier()
        {
            // Prepares a empty list of suppliers 
            List<Supplier> supplierlist = new List<Supplier>();
            Supplier sup;

            // Connect to Sql Server
            SqlConnection con = TravelExpertsDB.GetConnection();

            // Define the select command in alphabetical order
            string selectStatement = "SELECT * " +
                                     "FROM Suppliers " +
                                     "ORDER BY SupName";

            // Prepare for executing select query
            SqlCommand cmd = new SqlCommand(selectStatement, con);

            // Try and catch any unspecified errors 
            try
            {
                // Open connection
                con.Open();

                // Read and execute Sql command
                SqlDataReader reader = cmd.ExecuteReader();
                //Supplier supp;

                // While reading - add each supplier into the list
                while (reader.Read())
                {
                    sup = new Supplier();
                    sup.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    sup.SupName = reader["SupName"].ToString();
                    supplierlist.Add(sup);
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
            return supplierlist;
        }

        /// <summary>
        /// Add Supplier
        /// </summary>
        public static int AddSupplier(string supp)
        {
            int successful = 0;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Suppliers (SupplierId, SupName) " +
                                     "VALUES ((SELECT TOP 1 SupplierId FROM Suppliers ORDER BY 1 desc) + 1, @SupName)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@SupName", supp);
            
            try
            {
                con.Open();
                successful = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return successful;
        }

        // Edit Supplier
        public static bool EditSupplier(Supplier newSup, Supplier oldSup)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Suppliers " +
                                     "SET SupName = @NewSupName " +
                                     "WHERE SupName = @OldSupName";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@NewSupName", newSup.SupName);
            cmd.Parameters.AddWithValue("@OldSupName", oldSup.SupName);
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
