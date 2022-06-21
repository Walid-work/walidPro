using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class Uc_Customer : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Uc_Customer()
        {
            InitializeComponent();
        }

       

        private void ID_TextChanged(object sender, EventArgs e)
        {
            get_desc();
        
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
           
            }

        private void get_desc()
        {
            //try
            //{
                string Acc_main = (dal.getDataTabl("Get_Main_acc", Properties.Settings.Default.BranchId, dal.db1)).Rows[0][0].ToString();
                string Acc_cash = (dal.getDataTabl("Get_Main_acc", Properties.Settings.Default.BranchId, dal.db1)).Rows[0][2].ToString();
                DataTable dt_ = dal.getDataTabl("GetAcc_", branchID.Text.ToString(), ID.Text,Acc_main,Acc_cash, "1", dal.db1);
                if (dt_.Rows.Count >= 1)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0][7].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0][8].ToString();
                    }
                }
                else
                {

                    Desc.Clear();

                }
            //}
            //catch { }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            search_();

        }

        private void search_()
        {
            try
            {
                dgv1.Visible = true;
                this.Height = 130;
                this.BringToFront();
                string Acc_main = (dal.getDataTabl("Get_Main_acc", Properties.Settings.Default.BranchId, dal.db1)).Rows[0][0].ToString();
                string Acc_cash = (dal.getDataTabl("Get_Main_acc", Properties.Settings.Default.BranchId, dal.db1)).Rows[0][2].ToString();
                dgv1.DataSource = dal.getDataTabl_1("select ACC_NO,PAYER_NAME,adress from  " + dal.db1 + ".dbo.payer2 where PAYER_NAME like '%" + Desc.Text + "%' and BRANCH_code like '" + branchID.Text + "%' and  ( Acc_no like '" + Acc_main + "%' OR Acc_no like '" + Acc_cash+ "%') ORDER BY acc_no ");
                dgv1.Columns[0].Width = 50;
            }
            catch { }

        }

        private void Desc_KeyUp(object sender, KeyEventArgs e)
        {
            search_();
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {

            int ii = dgv1.CurrentCell.RowIndex;

            ID.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
            Desc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();

            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ID_TextChanged_1(object sender, EventArgs e)
        {
            get_desc();
            OnLoad(e);
        }

        private void UC_Acc_Leave(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();

        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Acc_Load(object sender, EventArgs e)
        {

        }

        private void branchID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Leave(object sender, EventArgs e)
        {
            try
            {
                string Acc_main = (dal.getDataTabl("Get_Main_acc", Properties.Settings.Default.BranchId, dal.db1)).Rows[0][0].ToString();
                string Acc_cash = (dal.getDataTabl("Get_Main_acc", Properties.Settings.Default.BranchId, dal.db1)).Rows[0][2].ToString();
                DataTable dt_ = dal.getDataTabl("GetAcc_", branchID.Text.ToString(), ID.Text, Acc_main, Acc_cash, "1", dal.db1);
                if (dt_.Rows.Count >= 1)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0][7].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0][8].ToString();
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
    }
}

