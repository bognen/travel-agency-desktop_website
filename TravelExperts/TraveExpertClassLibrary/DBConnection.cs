using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraveExpertClassLibrary
{
    public static class DBConnection
    {
        public static SqlConnection getConnection() {
            string configString = ConfigurationManager.ConnectionStrings["TravelExperts"].ConnectionString;
            SqlConnection conn = new SqlConnection(configString);
            return conn;
        }
    }
}
