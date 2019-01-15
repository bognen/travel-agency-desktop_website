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
                Supplier pair = new Supplier(row[0].ToString(), Convert.ToInt32(row[1]));
                pairs.Add(pair);
            }
            return pairs;
        }
    }
}
