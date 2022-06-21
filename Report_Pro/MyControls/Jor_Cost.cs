using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class Jor_Cost : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Jor_Cost()
        {
            InitializeComponent();
        }

     
        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        

      

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

       

        private void ID_TextChanged_1(object sender, EventArgs e)
        {
            //get_desc();
        }

        private void ID_Enter(object sender, EventArgs e)
        {
           
        }

        private void Desc_KeyUp(object sender, KeyEventArgs e)
        {
           // search_();
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
        }

        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select Cost_name  FROM COST_CENTER where COST_CODE = '" + ID.Text + "'");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0][0].ToString();
                }
                else
                { Desc.Text = ""; }
            }
            catch { }
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select Cost_name  FROM COST_CENTER where COST_CODE = '" + ID.Text + "'");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0][0].ToString();
                }
                else
                { Desc.Text = "";
                    ID.Text = "";
                }
            }
            catch { }
        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void UC_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)27) {
            //    MessageBox.Show("hhhhhhhhhhhhh");
            //}


        }

        private void UC_cost_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }
    }
}
