using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class list_H_price : Form
    {
        //BL.Cls_PO PO = new BL.Cls_PO();
        //purchase_order_Frm po_orders = new purchase_order_Frm();
        public list_H_price()
        {
            InitializeComponent();
            //if (Properties.Settings.Default.lungh == "0")
            //{

            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            //{
            //    //store autosized widths
            //    int colw = dataGridView1.Columns[i].Width;
            //    //remove autosizing
            //    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //    //set width to calculated by autosize
            //    dataGridView1.Columns[i].Width = colw;
            //}
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.dataGridView1.Columns[1].Width = 200;
            //this.dataGridView1.Columns[2].Width = 200;
            //this.dataGridView1.Columns[3].Width = 100;
            //this.dataGridView1.Columns[4].Width = 80;
            //this.dataGridView1.Columns[5].Width = 80;
            //this.dataGridView1.Columns[6].Width = 120;

            if (Properties.Settings.Default.lungh == "0")
            {
                this.dataGridView1.Columns[2].Visible = false;
                this.dataGridView1.Columns[0].HeaderText = "الصنف";
                this.dataGridView1.Columns[1].HeaderText = "العميل";
                this.dataGridView1.Columns[2].HeaderText = "customers";
                this.dataGridView1.Columns[3].HeaderText = "رقم";
                this.dataGridView1.Columns[4].HeaderText = "الكمية";
                this.dataGridView1.Columns[5].HeaderText = "السعر";
                this.dataGridView1.Columns[6].HeaderText = "التاريخ";

            }
            else
            {

                this.dataGridView1.Columns[1].Visible = false;
                this.dataGridView1.Columns[0].HeaderText = "Vendor ID";
                this.dataGridView1.Columns[1].HeaderText = "اسم لمورد";
                this.dataGridView1.Columns[2].HeaderText = "Vendor Name";
                this.dataGridView1.Columns[3].HeaderText = "PO NO";
                this.dataGridView1.Columns[4].HeaderText = "Qty";
                this.dataGridView1.Columns[5].HeaderText = "Price";
                this.dataGridView1.Columns[6].HeaderText = "Date";

            }

        }

        private void list_H_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
