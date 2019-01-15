using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public static class PackageDB
    {
        // METHOD RETRIEVES ALL DATA ABOUT PACKAGE LIST
        public static DataTable getPackageList()
        {
            DataTable packageList = new DataTable();

            SqlConnection conn = DBConnection.getConnection();
                using (SqlCommand command = new SqlCommand("select * from Packages", conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    packageList.Load(reader);
                }

            return packageList;
        }

        // METHOD RETRIEVES MAX VALUE OF PACKAGE_ID TO INSERT IT INTO NEWLY CREATE PACAKGE
        public static int getMaxPackIdValue()
        {
            SqlConnection conn = null;
            int maxValue;
            try
            {
                conn = DBConnection.getConnection();
                    using (SqlCommand command =
                        new SqlCommand(("Select MAX(Packages.PackageId) from Packages"), conn))
                    {
                        conn.Open();
                        maxValue = (int)command.ExecuteScalar();
                    }
                return maxValue;
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

        // METHOD INSERTS DATA INTO PACKAGES TABLE
        public static void insertPackages(Package pack)
        {

            SqlConnection conn = null;

            // Create a query
            string query = @"INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission)
          VALUES (@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";

            // Insert data into DataBase
            try
            {
                conn = DBConnection.getConnection();
                    using (SqlCommand command =
                        new SqlCommand(query, conn))
                    {
                        conn.Open();
                        // Add values to query
                        command.Parameters.AddWithValue("@PkgName", pack.PackName);
                        command.Parameters.AddWithValue("@PkgStartDate", pack.PackStartDate);
                        command.Parameters.AddWithValue("@PkgEndDate", pack.PackEndDate);
                        command.Parameters.AddWithValue("@PkgDesc", pack.PackDesc);
                        command.Parameters.AddWithValue("@PkgBasePrice", pack.PackBasePrice);
                        command.Parameters.AddWithValue("@PkgAgencyCommission", pack.PackAgncyCommission);

                        // Execute Sql Command
                        command.ExecuteNonQuery();
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

        // METHOD UPDATES DATA IN PACKAGES TABLE
        public static void updatePackages(Package pack, int packId)
        {
            SqlConnection conn = null;

            // Create a query
            string query = @"UPDATE Packages
                             SET PkgName=@PkgName, PkgStartDate=@PkgStartDate, PkgEndDate=@PkgEndDate, 
                                 PkgDesc=@PkgDesc, PkgBasePrice=@PkgBasePrice, 
                                 PkgAgencyCommission=@PkgAgencyCommission
                             WHERE PackageId=" + Convert.ToString(packId);

            // Insert data into DataBase
            try
            {
                conn = DBConnection.getConnection();
                  using (SqlCommand command =
                     new SqlCommand(query, conn))
                  {
                      conn.Open();
                      // Add values to query
                      command.Parameters.AddWithValue("@PkgName", pack.PackName);
                      command.Parameters.AddWithValue("@PkgStartDate", pack.PackStartDate);
                      command.Parameters.AddWithValue("@PkgEndDate", pack.PackEndDate);
                      command.Parameters.AddWithValue("@PkgDesc", pack.PackDesc);
                      command.Parameters.AddWithValue("@PkgBasePrice", pack.PackBasePrice);
                      command.Parameters.AddWithValue("@PkgAgencyCommission", pack.PackAgncyCommission);
                      // Execute Sql Command
                      command.ExecuteNonQuery();
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
    } // End of Class
} // End of NameSpace
