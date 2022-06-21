using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class Delivry_Grid : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Delivry_Grid()
        {
            InitializeComponent();
           
        }

      

        private void Inv_Grid_KeyDown(object sender, KeyEventArgs e)
        {


            

            if (e.KeyCode == Keys.Enter)
            {
                int index = flowLayoutPanel1.Controls.GetChildIndex(ActiveControl);

                foreach (MyControls.Delivry_Row inv_r in flowLayoutPanel1.Controls)
                {

                    inv_r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(inv_r) + 1).ToString();
                    

                    if (flowLayoutPanel1.Controls.Count - 1 == index)
                    {
                        if (inv_r.txt_Code.Text == string.Empty)
                        {
                            inv_r.Dispose();

                        }


                        MyControls.Delivry_Row r = new MyControls.Delivry_Row();
                        flowLayoutPanel1.Controls.Add(r);
                        r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                        r.Co_code = txtCo_Code.Text;
                        r.txt_Code.Focus();
                        r.KeyDown += r_KeyDown;
                        r.KeyUp += r_KeyUP;
                        r.Enter += r_Enter;
                        r.Click += r_Click;
                    }
                    else if (flowLayoutPanel1.Controls.GetChildIndex(inv_r) == index+1)
                    {
                        inv_r.txt_Code.Focus();
                    }
                    else { }
                }
             


            }
        }



        public void r_Enter(object sender, EventArgs e)
        {
            base.OnEnter(e);
        }

       

        private void Inv_Grid_Load(object sender, EventArgs e)
        {


            MyControls.Delivry_Row r = new MyControls.Delivry_Row();
            flowLayoutPanel1.Controls.Add(r);
            r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();

            
            r.KeyDown += r_KeyDown;
            r.DoubleClick += r_DoubleClick;
            r.KeyUp += r_KeyUP;
            r.Click += r_Click;

            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.AutoScroll = true;


         


        }


      
        public void r_KeyUP(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            base.OnKeyUp(e);
        }

      

        public void r_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            base.OnKeyDown(e);
        }

        public void r_DoubleClick(object sender, EventArgs e)
        {

            base.OnDoubleClick(e);
        }


        public void r_Click(object sender, EventArgs e)
        {

            base.OnClick(e);
        }

        private void flowLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
            PL.frm_search_items frm = new PL.frm_search_items();
            frm.ShowDialog();
        }

       

        private void Acc_Vat_Rate_TextChanged(object sender, EventArgs e)
        {
            //foreach (MyControls.Inv_Row r in flowLayoutPanel1.Controls)
            //{
            //    r.VatAccRate.Text = txtAccVat_Rate.Text.ToDecimal().ToString();
            //    r.VatValue.Text = ((r.VatRate.Text.ToDecimal() <= r.VatAccRate.Text.ToDecimal() ? r.VatRate.Text : r.VatAccRate.Text).ToDecimal() * r.Txtvalue.Text.ToDecimal()).ToString("N" + dal.digits_);

            //}
        }

        public void total_inv()
        {

            totalQty.Text =
               (from MyControls.Delivry_Row row in flowLayoutPanel1.Controls
                where row.qty.Text != string.Empty
                select Convert.ToDouble(row.qty.Text)).Sum().ToString("n0");

            txt_SubTot.Text =
              (from MyControls.Delivry_Row row in flowLayoutPanel1.Controls
               where row.qty.Text != string.Empty && row.txtCost.Text != string.Empty
               select Convert.ToDouble(row.qty.Text)* Convert.ToDouble(row.txtCost.Text)).Sum().ToString("n" + dal.digits_);

            // txt_TotDisc.Text =
            // (from MyControls.Inv_Row row in flowLayoutPanel1.Controls
            //  where row.TxtDisc.Text != string.Empty
            //  select Convert.ToDouble(row.TxtDisc.Text)).Sum().ToString("n"+dal.digits_);

            // txtNetTotal.Text =
            //  (from MyControls.Inv_Row row in flowLayoutPanel1.Controls
            //   where row.Txtvalue.Text != string.Empty
            //   select Convert.ToDouble(row.Txtvalue.Text)).Sum().ToString("n" + dal.digits_);

            totalWeight.Text =
              (from MyControls.Delivry_Row row in flowLayoutPanel1.Controls
               where row.totWeight.Text != string.Empty
               select Convert.ToDouble(row.totWeight.Text)).Sum().ToString("n3");

            //txtTotalVAT.Text =
            //  (from MyControls.Inv_Row row in flowLayoutPanel1.Controls
            //   where row.VatValue.Text != string.Empty
            //   select Convert.ToDouble(row.VatValue.Text)).Sum().ToString("n" + dal.digits_);

            //txtNetValue.Text = (txtNetTotal.Text.ToDecimal() + txtTotalVAT.Text.ToDecimal()).ToString("n" + dal.digits_);



        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            
            total_inv();
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
           
            total_inv();
            if (flowLayoutPanel1.Controls.Count < 1 && txtAccVat_Rate.Text=="1")
            {
                MyControls.Delivry_Row r = new MyControls.Delivry_Row();
                flowLayoutPanel1.Controls.Add(r);
                r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                r.Co_code = txtCo_Code.Text;
                r.KeyDown += r_KeyDown;
                r.DoubleClick += r_DoubleClick;
                r.KeyUp += r_KeyUP;
                r.Click += r_Click;

            }
            txtAccVat_Rate.Clear();
            foreach(MyControls.Delivry_Row r in flowLayoutPanel1.Controls)
            {
                r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();

            }
        }

        private void Inv_Grid_KeyUp(object sender, KeyEventArgs e)
        {
            total_inv();
        }

      

 

        private void Inv_Grid_Click(object sender, EventArgs e)
        {
            txtAccVat_Rate.Text = "1";
            



        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void labelX12_Click(object sender, EventArgs e)
        {

        }

        private void labelX23_Click(object sender, EventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCo_Code_TextChanged(object sender, EventArgs e)
        {

            foreach (MyControls.Delivry_Row r in flowLayoutPanel1.Controls)
            {
                r.Co_code = txtCo_Code.Text;

            }
        }
    }
}
