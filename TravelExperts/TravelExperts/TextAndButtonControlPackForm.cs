using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    class TextAndButtonControlPackForm : UserControl
    {
        private TextBox textbox1;
        private Button button1;
        private DataGridView datagridview;
        private DataGridViewRow rowstring;


       public TextAndButtonControlPackForm()
        {
            this.textbox1 = new TextBox();
            this.Controls.Add(this.textbox1);
            this.button1 = new Button();
            this.Controls.Add(this.button1);
            this.renderControl();
            this.button1.Click += new EventHandler(button1_Click);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();

            if (pf.ShowDialog() == DialogResult.Yes ) {                
                               
                // Get values from selected row in TemporaryTable 
                DataGridViewRow prodRow = pf.dataGridView1.CurrentRow;

                // Set new values to two cells
                this.rowstring.Cells[0].Value = prodRow.Cells[1].Value;
                this.rowstring.Cells[1].Value = prodRow.Cells[0].Value;
                // Change focus to the third cell "SUPPLIER"
                this.datagridview.CurrentCell = this.rowstring.Cells[2];
            }

        }

        public override string  Text
        {
            get { return this.textbox1.Text; }
            set { this.textbox1.Text = value; }
        }
        public DataGridView dataGridView
        {
            get { return datagridview; }
            set { datagridview = value; }
        }
        public DataGridViewRow rowString
        {
            get { return rowstring; }
            set { rowstring = value; }
        }
        public string ButtonText
        {
            get { return this.button1.Text; }
            set { this.button1.Text = "..."; }
        }

        public void renderControl()
        {
            int btnWidth = 25;
            this.textbox1.Location = new Point(0, 0);
            this.textbox1.Width = this.Width- btnWidth;
            this.textbox1.Height = this.Height;
            this.textbox1.ReadOnly = true;
            this.textbox1.BackColor = Color.White;

            this.button1.Location = new Point(this.Width - btnWidth);
            this.button1.FlatStyle = FlatStyle.Standard;
            this.button1.MaximumSize = new Size(btnWidth, int.MaxValue);
            this.button1.Height = this.Height;
            this.button1.Text = "...";
            this.button1.Font = new Font(button1.Font.FontFamily, 8);
        }
    }
}
