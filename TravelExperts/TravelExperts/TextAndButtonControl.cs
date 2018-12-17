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
    class TextAndButtonControl : UserControl
    {
        private TextBox textbox1;
        private Button button1;
        private int id;
        private DataGridViewRow rowstring;

        public TextAndButtonControl()
        {
            this.textbox1 = new TextBox();
            this.Controls.Add(this.textbox1);
            this.button1 = new Button();
            this.Controls.Add(this.button1);
            this.renderControl();
            this.button1.Click += new EventHandler(button1_Click);
        }

        void button1_Click(object sender, EventArgs e)
        {
            // 
            foreach (DataGridViewCell cell in this.rowString.Cells)
            {
                MessageBox.Show(string.Format("{0}", cell.Value));
            }
            MessageBox.Show("Sambuka");
        }

        public string Text
        {
            get { return this.textbox1.Text; }
            set { this.textbox1.Text = value; }
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }
        public DataGridViewRow rowString
        {
            get { return rowstring; }
            set { rowstring = value; }
        }
        public string ButtonText
        {
            get { return this.button1.Text; }
            set { this.button1.Text = value; }
        }

        public void renderControl()
        {
            this.textbox1.Location = new Point(0, 0);
            this.textbox1.Width = 5 * this.Width / 6;
            this.textbox1.Height = this.Height;
            this.textbox1.ReadOnly = false;

            this.button1.Location = new Point(5 * this.Width / 6, 0);
            this.button1.FlatStyle = FlatStyle.Standard;
            this.button1.Width = this.Width / 6;
            this.button1.Height = this.Height;
            this.button1.Text = "...";
        }
    }
}
