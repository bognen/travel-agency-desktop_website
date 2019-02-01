using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    class TravelExpertsDB
    {
        // Probably Andy uses this 
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source = ELF8OOSD197841\SQLEXPRESS;" +
                                              "Initial Catalog = TravelExperts;" +
                                              "Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
