using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class Jor_Acc : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string branchID = "";
        public Jor_Acc()
        {
            InitializeComponent();
        }

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            get_desc();
            OnKeyDown(e);
        }

        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1(@"select A.PAYER_NAME,A.payer_l_name from payer2 As A 
                   where A.ACC_NO= '" + ID.Text + "'  and A.BRANCH_code like '" + branchID + "'+'%' and A.t_final = 1 ");


                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["PAYER_NAME"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["payer_l_name"].ToString();
                    }
                   
                }
                else
                {

                    Desc.Clear();
                }
            }
            catch { }
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1(@"select A.PAYER_NAME,A.payer_l_name from payer2 As A 
                   where A.ACC_NO= '" + ID.Text + "'  and A.BRANCH_code like '" + branchID + "'+'%' and A.t_final = 1 ");


                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["PAYER_NAME"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["payer_l_name"].ToString();
                    }

                }
                else
                {
                    ID.Clear();
                    Desc.Clear();
                }

            }
            catch { }

        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
            OnKeyUp(e);
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            //get_desc();
            //OnLoad(e);
        }

        private void Jor_Acc_Load(object sender, EventArgs e)
        {

        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
