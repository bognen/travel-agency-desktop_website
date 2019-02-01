using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraveExpertClassLibrary
{
    class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source = ELF8OOSD197838\SQLEXPRESS;" +
                                              "Initial Catalog = TravelExperts;" +
                                              "Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
