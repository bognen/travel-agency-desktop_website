using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraveExpertClassLibrary
{
    public static class SupplierDetailsDB
    {
        // Displaying supplier details based on supplierID
        public static SupplierDetails GetSupplierDetails(int supplierId)
        {
            SupplierDetails supd = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT SupConFirstName, " +
                                     "SupConLastName, " +
                                     "SupConCompany, " +
                                     "SupConAddress, " +
                                     "SupConCity, " +
                                     "SupConProv, " +
                                     "SupConPostal, " +
                                     "SupConCountry, " +
                                     "SupConBusPhone, " +
                                     "SupConFax, " +
                                     "SupConEmail, " +
                                     "SupplierId " +
                                     "FROM SupplierContacts " +
                                     "WHERE SupplierId = @SupplierId";
            SqlCommand cmd = new SqlCommand(selectStatement, con);

            // Value comes from the method's argument
            cmd.Parameters.AddWithValue("@SupplierId", supplierId);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);

                if (reader.Read())
                {
                    supd = new SupplierDetails();

                    supd.SupConFirstName = reader["SupConFirstName"] as string;
                    supd.SupConLastName = reader["SupConLastName"].ToString();
                    supd.SupConCompany = reader["SupConCompany"].ToString();
                    supd.SupConAddress = reader["SupConAddress"].ToString();
                    supd.SupConCity = reader["SupConCity"].ToString();
                    supd.SupConProv = reader["SupConProv"].ToString();
                    supd.SupConPostal = reader["SupConPostal"].ToString();
                    supd.SupConCountry = reader["SupConCountry"].ToString();
                    supd.SupConBusPhone = reader["SupConBusPhone"].ToString();
                    supd.SupConFax = reader["SupConFax"].ToString();
                    supd.SupConEmail = reader["SupConEmail"].ToString();
                    supd.SupplierId = reader["SupplierId"] as int? ?? default(int);
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
            return supd;
        }

        /// <summary>
        /// Using a SupplierID input, this method finds the associated details and stores it in a SupplierDetails object
        /// </summary>
        public static SupplierDetails GetSupplierDetailInfo(string name)
        {
            SupplierDetails supd = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT SupConFirstName, " +
                                     "SupConLastName, " +
                                     "SupConCompany, " +
                                     "SupConAddress, " +
                                     "SupConCity, " +
                                     "SupConProv, " +
                                     "SupConPostal, " +
                                     "SupConCountry, " +
                                     "SupConBusPhone, " +
                                     "SupConFax, " +
                                     "SupConEmail, " +
                                     "SupConURL, " +
                                     "sc.SupplierId " +
                                     "FROM SupplierContacts sc " +
                                     "JOIN Suppliers s on sc.SupplierId = s.SupplierId " +
                                     "WHERE SupName = @SupName";
            SqlCommand cmd = new SqlCommand(selectStatement, con);

            // Value comes from the method's argument
            cmd.Parameters.AddWithValue("@SupName", name);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);

                if (reader.Read())
                {
                    supd = new SupplierDetails();

                    supd.SupConFirstName = reader["SupConFirstName"].ToString();
                    supd.SupConLastName = reader["SupConLastName"].ToString();
                    supd.SupConCompany = reader["SupConCompany"].ToString();
                    supd.SupConAddress = reader["SupConAddress"].ToString();
                    supd.SupConCity = reader["SupConCity"].ToString();
                    supd.SupConProv = reader["SupConProv"].ToString();
                    supd.SupConPostal = reader["SupConPostal"].ToString();
                    supd.SupConCountry = reader["SupConCountry"].ToString();
                    supd.SupConBusPhone = reader["SupConBusPhone"].ToString();
                    supd.SupConFax = reader["SupConFax"].ToString();
                    supd.SupConEmail = reader["SupConEmail"].ToString();
                    supd.SupConURL = reader["SupConURL"].ToString();
                    supd.SupplierId = reader["SupplierId"] as int? ?? default(int);
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
            return supd;
        }

        /// <summary>
        /// Updating Supplier details based on supplierID
        /// </summary>
        public static bool UpdateSupplier(SupplierDetails oldSupp, SupplierDetails newSupp)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE SupplierContacts " +
                                     "SET SupConFirstName = @NewFirstName, " +
                                     "    SupConLastName = @NewLastName, " +
                                     "    SupConCompany = @NewCompany, " +
                                     "    SupConAddress = @NewAddress, " +
                                     "    SupConCity = @NewCity, " +
                                     "    SupConProv = @NewProv, " +
                                     "    SupConPostal = @NewPostal, " +
                                     "    SupConCountry = @NewCountry, " +
                                     "    SupConBusPhone = @NewBusPhone, " +
                                     "    SupConFax = @NewFax, " +
                                     "    SupConEmail = @NewEmail, " +
                                     "    SupConURL = @NewURL " +
                                     "WHERE SupplierId = @OldSupplierId " +
                                     "AND SupConFirstName = @OldFirstName " +
                                     "AND SupConLastName = @OldLastName " +
                                     "AND SupConCompany = @OldCompany " +
                                     "AND SupConAddress = @OldAddress " +
                                     "AND SupConCity = @OldCity " +
                                     "AND SupConProv = @OldProv " +
                                     "AND SupConPostal = @OldPostal " +
                                     "AND SupConCountry = @OldCountry " +
                                     "AND SupConBusPhone = @OldBusPhone " +
                                     "AND SupConFax = @OldFax " +
                                     "AND SupConEmail = @OldEmail " +
                                     "AND SupConURL = @OldURL";
            SqlCommand cmd = new SqlCommand(updateStatement, con);

            cmd.Parameters.AddWithValue("@NewFirstName", newSupp.SupConFirstName);
            cmd.Parameters.AddWithValue("@NewLastName", newSupp.SupConLastName);
            cmd.Parameters.AddWithValue("@NewCompany", newSupp.SupConCompany);
            cmd.Parameters.AddWithValue("@NewAddress", newSupp.SupConAddress);
            cmd.Parameters.AddWithValue("@NewCity", newSupp.SupConCity);
            cmd.Parameters.AddWithValue("@NewProv", newSupp.SupConProv);
            cmd.Parameters.AddWithValue("@NewPostal", newSupp.SupConPostal);
            cmd.Parameters.AddWithValue("@NewCountry", newSupp.SupConCountry);
            cmd.Parameters.AddWithValue("@NewBusPhone", newSupp.SupConBusPhone);
            cmd.Parameters.AddWithValue("@NewFax", newSupp.SupConFax);
            cmd.Parameters.AddWithValue("@NewEmail", newSupp.SupConEmail);
            cmd.Parameters.AddWithValue("@NewURL", newSupp.SupConURL);

            cmd.Parameters.AddWithValue("@OldFirstName", oldSupp.SupConFirstName);
            cmd.Parameters.AddWithValue("@OldLastName", oldSupp.SupConLastName);
            cmd.Parameters.AddWithValue("@OldCompany", oldSupp.SupConCompany);
            cmd.Parameters.AddWithValue("@OldAddress", oldSupp.SupConAddress);
            cmd.Parameters.AddWithValue("@OldCity", oldSupp.SupConCity);
            cmd.Parameters.AddWithValue("@OldProv", oldSupp.SupConProv);
            cmd.Parameters.AddWithValue("@OldPostal", oldSupp.SupConPostal);
            cmd.Parameters.AddWithValue("@OldCountry", oldSupp.SupConCountry);
            cmd.Parameters.AddWithValue("@OldBusPhone", oldSupp.SupConBusPhone);
            cmd.Parameters.AddWithValue("@OldFax", oldSupp.SupConFax);
            cmd.Parameters.AddWithValue("@OldEmail", oldSupp.SupConEmail);
            cmd.Parameters.AddWithValue("@OldURLa", oldSupp.SupConURL);

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
