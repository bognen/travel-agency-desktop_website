﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TravelExperts
{
    public partial class PackagesList : Form
    {
        public PackagesList()
        {
            InitializeComponent();
        }
        //*******************************************************************************//
        //  PART NEEDED TO CREATE A CUSTOM CONTROL
        //*******************************************************************************//

        // Create new control
        TextAndButtonControl txtbtn = new TextAndButtonControl();
        // Number of COLUMN to apply custom control
        int colIndex = 1;

        // How the cell will look like before we start editing
        void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == colIndex && e.RowIndex > -1 && e.RowIndex != this.dgvPackageList.NewRowIndex)
            {
                Rectangle textRect = e.CellBounds;
                textRect.Width -= e.CellBounds.Width / 6;
                Rectangle btnRect = e.CellBounds;
                btnRect.X += textRect.Width;
                btnRect.Width = e.CellBounds.Width / 6;

                e.Paint(textRect, DataGridViewPaintParts.All);
                ControlPaint.DrawButton(e.Graphics, btnRect, ButtonState.Normal);
                StringFormat formater = new StringFormat();
                formater.Alignment = StringAlignment.Center;
                e.Graphics.DrawString("...", e.CellStyle.Font, new SolidBrush(e.CellStyle.ForeColor), btnRect, formater);
                e.Handled = true;
            }
        }
        void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == colIndex && e.RowIndex > -1 && e.RowIndex != this.dgvPackageList.NewRowIndex)
            {
                Rectangle rect = this.dgvPackageList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                this.txtbtn.Location = rect.Location;
                this.txtbtn.Size = rect.Size;
                this.txtbtn.Text = this.dgvPackageList.CurrentCell.Value.ToString();
                // Retreive ID
                this.txtbtn.Id = Convert.ToInt32(dgvPackageList.CurrentRow.Cells[0].Value);
                // Retreive whole ROW
                this.txtbtn.rowString = this.dgvPackageList.CurrentRow;
                this.txtbtn.ButtonText = "...";
                this.txtbtn.renderControl();
                this.txtbtn.Visible = true;
            }
        }
        void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colIndex && e.RowIndex > -1 && e.RowIndex != this.dgvPackageList.NewRowIndex)
            {
               // this.dgvPackageList.CurrentCell.Value = this.txtbtn.Text;
                this.txtbtn.Visible = false;
            }
        }
        void dgv_Scroll(object sender, ScrollEventArgs e)

        {
            if (this.txtbtn.Visible == true)
            {
                Rectangle r = this.dgvPackageList.GetCellDisplayRectangle(
                    this.dgvPackageList.CurrentCell.ColumnIndex,
                    this.dgvPackageList.CurrentCell.RowIndex,
                    true);
                this.txtbtn.Location = r.Location;
                this.txtbtn.Size = r.Size;
            }
        }

        private void PackagesForm_Load(object sender, EventArgs e)
        {
            // Call just data source for dataGridView
            // Source has to be DATA TABLE

            dgvPackageList.DataSource = DBHandler.getPackageList();

            //HIDE ID COLUMN
            dgvPackageList.Columns[0].Visible = false;

            // EDIT APPEARANCE OF DATA GRID VIEW
            dgvPackageList.Columns[0].HeaderText = "ID";
            dgvPackageList.Columns[1].HeaderText = "Name";
            dgvPackageList.Columns[2].HeaderText = "Start Date";
            dgvPackageList.Columns[3].HeaderText = "End Date";
            dgvPackageList.Columns[4].HeaderText = "Description";
            dgvPackageList.Columns[5].HeaderText = "Base Price";
            dgvPackageList.Columns[6].HeaderText = "Commission";

            // NUMBER FORMAT IN PRICE COLUMNS
            dgvPackageList.Columns[5].DefaultCellStyle.Format = "N2";
            dgvPackageList.Columns[6].DefaultCellStyle.Format = "N2";


            //****** ADD THREE BUTTON CONTROL
            this.txtbtn = new TextAndButtonControl();
            this.txtbtn.Visible = false;
            this.dgvPackageList.Controls.Add(this.txtbtn);

            //Handle the cellbeginEdit event to show the usercontrol in the cell while editing
            this.dgvPackageList.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgv_CellBeginEdit);

            //Handle the cellEndEdit event to update the cell value
            this.dgvPackageList.CellEndEdit += new DataGridViewCellEventHandler(dgv_CellEndEdit);
        }
    }
}
