using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using jorRow;

using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class jorDebit : UserControl
    {
        int clic_index;
        int txtRemove = 0;
        public jorDebit()

        {
            InitializeComponent();
        }
 
                private void UserControl2_Load(object sender, EventArgs e)
        {
            //foreach (Jor_Row r in flowLayoutPanel1.Controls)
            //{
            jorRow.Jor_Row r = new  jorRow.Jor_Row();
            //   MyControls.Jor_Row r = new MyControls.Jor_Row();
            r.Width = flowLayoutPanel1.Width;
                flowLayoutPanel1.Controls.Add(r);
              //  flowLayoutPanel1.SuspendLayout();


                r.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
            //}


            r.KeyDown += r_KeyDown;
            r.KeyUp += r_KeyUP;
            r.Click += r_Click;
            r.KeyPress += r_KeyPress;
            r.DoubleClick += r_DoubleClick;


            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.AutoScroll = true;



        }



        public void r_KeyUP(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            base.OnKeyUp(e);
        }

        public void r_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        public void r_DoubleClick(object sender, EventArgs e)
        {
            base.OnDoubleClick(e);
        }

        public void r_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        private void r_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }




            private void c_Load(object sender, EventArgs e)
        {
            gettotDb();
        }
        private void c_click(object sender, EventArgs e)
        {

            //var add = new Jor_Row();
            //flowLayoutPanel1.Controls.Add(add);
            //foreach (Jor_Row ctl in flowLayoutPanel1.Controls)
            //{
            //    ctl.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(ctl) + 1).ToString();
            //}

            
            //gettotDb();
        }

        public void gettotDb()
        {
            double totDb = 0;
            double totCr = 0;
            foreach (jorRow.Jor_Row c in flowLayoutPanel1.Controls)
            {

                totDb += c.txtDb.d.Value;
                txtTotalDb.Value = totDb;
                totCr += c.txtCr.d.Value;
                txtTotalCr.Value = totCr;
                txtDiff.Value = totDb - totCr;


            }
        }

        private void AddTextChangedHandler(Control parent)
        {
           
            foreach (Jor_Row c in flowLayoutPanel1.Controls)
            {
               
                    c.txtDb.d.ValueChanged += new EventHandler(c_Load);
                c.Click+= new EventHandler(c_click);
            }
        }

        private void jorDebit_KeyDown(object sender, KeyEventArgs e)
        {
            
           if (e.KeyCode == Keys.Enter)
            {
              int index = flowLayoutPanel1.Controls.GetChildIndex(ActiveControl);

             foreach (jorRow.Jor_Row JRow  in flowLayoutPanel1.Controls)
              {

                    JRow.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(JRow) + 1).ToString();

                if (flowLayoutPanel1.Controls.Count - 1 == index)
                    {
                        if (JRow.txtDb.d.Value == 0 && JRow.txtCr.d.Value == 0)
                        {
                            JRow.Dispose();

                        }


                        jorRow.Jor_Row r  = new jorRow.Jor_Row();
                        flowLayoutPanel1.Controls.Add(r);
                        r.Width = flowLayoutPanel1.Width;
                        r.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();

                        r.KeyDown += r_KeyDown;
                        r.KeyUp += r_KeyUP;
                        r.Click += r_Click;
                        r.KeyPress += r_KeyPress;
                        r.DoubleClick += r_DoubleClick;

                    }
                    else if (flowLayoutPanel1.Controls.GetChildIndex(JRow) == index + 1)
                    {

                        JRow.txtDb.Focus();
                    }
                    else { }
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                
            }
        }

        private void jorDebit_KeyUp(object sender, KeyEventArgs e)
        {
            gettotDb();
        }

        private void jorDebit_Click(object sender, EventArgs e)
        {
            clic_index = flowLayoutPanel1.Controls.GetChildIndex(ActiveControl);
            string txtdesc = "";
            foreach (jorRow.Jor_Row ctr in flowLayoutPanel1.Controls)
                {
                if (flowLayoutPanel1.Controls.GetChildIndex(ctr) == clic_index)
                {
                    txtdesc = ctr.txtDescription.t.Text;

                }
                if (flowLayoutPanel1.Controls.GetChildIndex(ctr) == clic_index + 1)
                    {
                        ctr.txtDescription.t.Text = txtdesc;
                    ctr.txtDescription.Focus();
                    }
                }
            }




        private void copyLine()
        {
            clic_index = flowLayoutPanel1.Controls.GetChildIndex(ActiveControl);
            double db = 0;
            double cr = 0;
            string accid = "";
            string desc = "";
            string catID = "";
            string CostID = "";
            string doc = "";
            string date_ = "";
            string vatID = "";
            string acc2 = "";
            string balnce_ = "";

            foreach (jorRow.Jor_Row ctr in flowLayoutPanel1.Controls)
                {

                    if (flowLayoutPanel1.Controls.GetChildIndex(ctr) == clic_index)
                    {
                        db = ctr.txtDb.d.Value;
                        cr = ctr.txtCr.d.Value;
                        accid = ctr.Acc_.ID.Text;
                        //accN  ame = ctr.txt.t.Text;
                        desc = ctr.txtDescription.t.Text;
                        catID = ctr.txtCat.ID.Text;
                        CostID = ctr.txtCost.ID.Text;
                        doc = ctr.txtDocument.t.Text;
                        date_ = ctr.txtDocDate.Text;
                        vatID = ctr.txtVatNo.t.Text;
                        acc2 = ctr.txtAcc_2.t.Text;
                        balnce_ = ctr.txtBalance.t.Text;


                    }
                }

                jorRow.Jor_Row r = new jorRow.Jor_Row();
                flowLayoutPanel1.Controls.Add(r);
                r.Width = flowLayoutPanel1.Width;
                flowLayoutPanel1.Controls.SetChildIndex(r, clic_index + 1);

                r.txtDb.d.Value = db;
                r.txtCr.d.Value = cr;
                r.Acc_.ID.Text = accid;
                r.txtDescription.t.Text = desc;
                r.txtCat.ID.Text = catID;
                r.txtCost.ID.Text = CostID;
                r.txtDocument.t.Text = doc;
                r.txtDocDate.Text = date_;
                r.txtVatNo.t.Text = vatID;
                r.txtAcc_2.t.Text = acc2;
                r.txtBalance.t.Text = balnce_;
                r.txtDb.Focus();

                r.KeyDown += r_KeyDown;
                r.KeyUp += r_KeyUP;
                r.Click += r_Click;
                r.KeyPress += r_KeyPress;
                r.DoubleClick += r_DoubleClick;


                foreach (jorRow.Jor_Row rw in flowLayoutPanel1.Controls)
                {
                    rw.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(rw) + 1).ToString();

                }

            }

        
    
        private void jorDebit_DoubleClick(object sender, EventArgs e)
        {
            
            copyLine();
        }

        private void jorDebit_Enter(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Enter(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void jorDebit_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void jorDebit_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                txtRemove= 1;
                clic_index = flowLayoutPanel1.Controls.GetChildIndex(ActiveControl);

            }
            catch { }
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count < 1 && txtRemove == 1)
            {
                jorRow.Jor_Row r = new jorRow.Jor_Row();
                flowLayoutPanel1.Controls.Add(r);
                r.Width = flowLayoutPanel1.Width;
                r.KeyDown += r_KeyDown;
                r.KeyUp += r_KeyUP;
                r.Click += r_Click;
                r.KeyPress += r_KeyPress;
                r.DoubleClick += r_DoubleClick;

            }
            txtRemove =0;
            foreach (jorRow.Jor_Row r in flowLayoutPanel1.Controls)
            {
                r.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();

            }
            gettotDb();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            try
            {
                flowLayoutPanel1.Controls.RemoveAt(clic_index);
            }
            catch { }
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void jor_Row1_Load(object sender, EventArgs e)
        {

        }
    }
}
