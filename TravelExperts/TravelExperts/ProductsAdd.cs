using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class ProductsAdd : Form
    {
        string name;

        public ProductsAdd()
        {
            InitializeComponent();
        }
        public Products products;

        private void button1_Click(object sender, EventArgs e)
        {
            int success = 0;
            if (txtProductName.Text == " ")
            {
                MessageBox.Show("A Name must be provided into the Product Name field");
            }
            else
            {
                name = txtProductName.Text;
            }

            success = jamesProductsDB.AddProducts(txtProductName.Text);

            if (success == 1)
            {
                MessageBox.Show("Data inserted Correctly");
            }
            else MessageBox.Show("Data was not inserted");
        }


        //private void putProductsData(Products products)
        //{
        //    if (txtProductName.Text == " ")
        //    {
        //        MessageBox.Show("A Name must be provided into the Product Name field");
        //    }
        //    else
        //    {
        //        name = txtProductName.Text;
        //    }
        //}
    }
}
