using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelExperts
{
    public partial class EditSupplier : Form
    {
        SqlConnection con = new SqlConnection("Data Source = ELF8OOSD197838\\SQLEXPRESS; Initial Catalog = TravelExperts; Integrated Security = True");

        public EditSupplier()
        {
            InitializeComponent();
        }

        
        private void EditSupplier_Load(object sender, EventArgs e)
        {
            // Link database with combobox 
            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand("SELECT SupName from Suppliers", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("SupName", typeof(string));
                dt.Load(reader);
                supplierNameComboBox.ValueMember = "SupName";
                supplierNameComboBox.DataSource = dt;
                con.Close();

                while (reader.Read())
                {
                    string sname = reader.GetString(reader.GetOrdinal("name"));
                    string sSurname = reader.GetString(reader.GetOrdinal("surname"));
                    string sAge = reader.GetString(reader.GetOrdinal("age"));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void supplierNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
