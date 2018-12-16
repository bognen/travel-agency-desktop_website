using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace TravelExperts
{
    public static class DBHandler
    {
        public static DataTable getPackageList() {
            DataTable packageList = new DataTable();
            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(configString)) {
                using (SqlCommand command = new SqlCommand("select * from Packages", conn)) {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    packageList.Load(reader);
                }
            }
            return packageList;
        }
    }
}
