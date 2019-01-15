using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public static class jamesDBConnect
    {
        /// <summary>
        /// Database connection string class
        /// Author: James Cockriell
        /// Date: January 10/2018
        /// </summary>
        /// <returns></returns>

        public static SqlConnection getConnection()
        {
            string connectionString = @"Data Source=ELF8OOSD197846\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
