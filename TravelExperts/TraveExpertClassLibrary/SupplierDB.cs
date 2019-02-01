using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public static class SupplierDB
    {
        // Andy Gao
        public static List<Supplier> GetSupplier()
        {
            // Prepares a empty list of Supplier 
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

        // Dima Bognen
        // METHOD RETURNS LIST OF SUPPLIERS PAIRS TO POPULATE COMBOBOX
        public static List<Supplier> supplierIdPairsList(int prodID)
        {
            SqlConnection conn = null;
            DataTable suppliersDT = new DataTable();
            string supplierIdPairsQuery = @"select Suppliers.SupName, Suppliers.SupplierId
                            from Products_Suppliers
                            inner join Suppliers on Suppliers.SupplierId=Products_Suppliers.SupplierId
                            where Products_Suppliers.ProductId=";
            try
            {
                conn = DBConnection.getConnection();
                using (SqlCommand command =
                    new SqlCommand((supplierIdPairsQuery + prodID), conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    suppliersDT.Load(reader);
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

            // Create a list to store supplier-Id pairs
            List<Supplier> pairs = new List<Supplier>();

            // Store data from data table in the list
            foreach (DataRow row in suppliersDT.Rows)
            {
                Supplier pair = new Supplier();
                pair.SupName = row[0].ToString();
                pair.SupplierId = Convert.ToInt32(row[1]);
                pairs.Add(pair);
            }
            return pairs;
        }
    } // end of the class
} //end of the namepace
