using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.CTR
{
    public partial class FeesGrid : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        int clic_index;
        public FeesGrid()
        {
            InitializeComponent();
        }

        private void FeesGrid_Load(object sender, EventArgs e)
        {


            FeesRow r = new FeesRow();
            flowLayoutPanel1.Controls.Add(r);
            r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();


            r.KeyDown += r_KeyDown;
            //r.DoubleClick += r_DoubleClick;
            r.KeyUp += r_KeyUP;
            r.Click += r_Click;
            r.EnabledChanged += r_TextChanged;
            r.MouseClick += r_MouseClick;

            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.AutoScroll = true;


            groupPanel1.AutoScroll = false;
            groupPanel1.VerticalScroll.Enabled = false;
            groupPanel1.AutoScroll = true;


            
           



        }

        public void r_KeyUP(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            base.OnKeyUp(e);
        }



        public void r_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            base.OnKeyDown(e);
        }

        public void total_inv()
        {

            totalAmount.Text =
               (from FeesRow row in flowLayoutPanel1.Controls
                where row.txtamount.Text != string.Empty
                select Convert.ToDouble(row.txtamount.Text)).Sum().ToString("n2");
            txtDiff.Value = txtBalance.Value - totalAmount.Value;

        }

        private void FeesGrid_KeyUp(object sender, KeyEventArgs e)
        {
            total_inv();
         
        }

        private void FeesGrid_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                int index = flowLayoutPanel1.Controls.GetChildIndex(ActiveControl);

                foreach (FeesRow inv_r in flowLayoutPanel1.Controls)
                {

                    inv_r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(inv_r) + 1).ToString();

                    if (flowLayoutPanel1.Controls.Count - 1 == index)
                    {
                        if (inv_r.txtamount.Text == string.Empty)
                        {
                            inv_r.Dispose();

                        }


                        FeesRow r = new FeesRow();
                        flowLayoutPanel1.Controls.Add(r);
                        r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                        r.txtamount.Focus();
                        r.KeyDown += r_KeyDown;
                        r.KeyUp += r_KeyUP;
                        r.Click += r_Click;
                        r.EnabledChanged += r_TextChanged;
                        r.MouseClick += r_MouseClick;
                    }
                    else if (flowLayoutPanel1.Controls.GetChildIndex(inv_r) == index + 1)
                    {

                        inv_r.txtamount.Focus();
                    }
                    else { }
                }
            }
        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        private void txtDiff_ValueChanged(object sender, EventArgs e)
        {
            if (txtDiff.Value != 0)
            {
                txtDiff.BackColor = Color.Red;
            }
            else
            {
                txtDiff.BackColor = Color.Green;
            }
        }

        private void btnSaveDetials_Click(object sender, EventArgs e)
        {
          

        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {

           
            if (flowLayoutPanel1.Controls.Count < 1 && txtRemove.Text=="1")
            {
               CTR.FeesRow r = new CTR.FeesRow();
                flowLayoutPanel1.Controls.Add(r);
                r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                r.KeyDown += r_KeyDown;
                r.KeyUp += r_KeyUP;
                r.Click += r_Click;
                r.EnabledChanged += r_TextChanged;
                r.MouseClick += r_MouseClick;
            }
            txtRemove.Clear();
            foreach (CTR.FeesRow r in flowLayoutPanel1.Controls)
            {
                r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();

            }
        }

        public void r_Click(object sender, EventArgs e)
        {

            base.OnClick(e);
        }

        public void r_TextChanged(object sender, EventArgs e)
        {

            base.OnTextChanged(e);
        }

        public void r_MouseClick(object sender, MouseEventArgs e)
        {

            base.OnMouseClick(e);
        }


        private void FeesGrid_Click(object sender, EventArgs e)
        {
            txtRemove.Text = "1";
           
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupPanel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void FeesGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                clic_index = flowLayoutPanel1.Controls.GetChildIndex(ActiveControl);
            }
           
        }

        private void cmsAddRow_Click(object sender, EventArgs e)
        {
            FeesRow r = new FeesRow();
             flowLayoutPanel1.Controls.Add(r);
            flowLayoutPanel1.Controls.SetChildIndex(r, clic_index);
           // r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
            r.txtamount.Focus();
            r.KeyDown += r_KeyDown;
            r.KeyUp += r_KeyUP;
            r.Click += r_Click;
            r.EnabledChanged += r_TextChanged;
            r.MouseClick += r_MouseClick;

            foreach (CTR.FeesRow rw in flowLayoutPanel1.Controls)
            {
                rw.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(rw) + 1).ToString();

            }
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void cmsDeleteRow_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.RemoveAt(clic_index);
        }

        private void cmsRows_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
