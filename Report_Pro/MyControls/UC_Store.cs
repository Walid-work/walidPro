using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class UC_Store : UserControl
    {
       DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
       public int _x, _y,_width;
       public DataGridView dgv1;
       
        public UC_Store()
        {
            InitializeComponent();
        }

        private void UC_Branch_Load(object sender, EventArgs e)
        {

        
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
           // OnKeyUp(e);
        }

      

        private void get_desc()
        {
            try
            {
                DataTable dt_;
                if (Program.userID.ToLower() == "administrator")
                {
                    dt_ = dal.getDataTabl_1(@"select branch_name,WH_E_NAME,ACC_BRANCH from  wh_BRANCHES 
                      where t_final like '" + txtTfinal.Text + "%' and Branch_code='" + ID.Text + "'");
                }
                else
                {
                    dt_ = dal.getDataTabl_1(@"select A.branch_name,A.WH_E_NAME,A.ACC_BRANCH from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code
                      where b.User_id = '" + Program.userID.ToString() + "' and t_final like '" + txtTfinal.Text + "%' and A.Branch_code='" + ID.Text + "'");

                }
                //select branch_name,WH_E_NAME,ACC_BRANCH from wh_BRANCHES  where T_final like '" + txtTfinal.Text+"%' and Branch_code='" + ID.Text + "' ");
                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["branch_name"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["WH_E_NAME"].ToString();
                    }
                    txtAccBranch.Text= dt_.Rows[0]["ACC_BRANCH"].ToString();
                }
                else
                {

                    Desc.Clear();

                }
            }

            catch { }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            search_();
          //  OnClick(e);

        }




        private void search_()
        {
            //try
            //{
            dal.btnType = "Store";
            dgv1.Visible = true;
            dgv1.Location = new Point(_x, _y);
            dgv1.Width = _width;
            dgv1.Height = 150;
            //this.BringToFront();
            if (Properties.Settings.Default.lungh == "0")
                {
               

                if (Program.userID.ToLower() == "administrator")
                    {
                        dgv1.DataSource = dal.getDataTabl_1(@"select Branch_code,branch_name from  wh_BRANCHES 
                        where  t_final like '" + txtTfinal.Text + "%' and branch_name like '%" + Desc.Text + "%'");
                        //select Branch_code,branch_name from  wh_BRANCHES where t_final like '" + txtTfinal.Text+"%' and branch_name like '%" + Desc.Text + "'+'%'  ");
                    }
                    else
                    {
                        dgv1.DataSource = dal.getDataTabl_1(@"select A.Branch_code,A.branch_name from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code
                      where b.User_id = '" + Program.userID.ToString() + "' and t_final like '" + txtTfinal.Text + "%' and branch_name like '%" + Desc.Text + "%'");
                      //select Branch_code,branch_name from  wh_BRANCHES where t_final like '" + txtTfinal.Text+"%' and branch_name like '%" + Desc.Text + "'+'%'  ");
                    }

                }
                else
                {
                    if (Program.userID.ToLower() == "administrator")
                    {
                      dgv1.DataSource = dal.getDataTabl_1(@"select Branch_code,WH_E_NAME from  wh_BRANCHES 
                      where  t_final like '" + txtTfinal.Text + "%' and isnull(WH_E_NAME,'') like '%" + Desc.Text + "%'");

                    }
                    else
                    {
                      dgv1.DataSource = dal.getDataTabl_1(@"select A.Branch_code,A.WH_E_NAME from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code
                      where b.User_id = '" + Program.userID.ToString() + "' and t_final like '" + txtTfinal.Text + "%' and isnull(WH_E_NAME,'') like '%" + Desc.Text + "%'");
                        //select Branch_code,WH_E_NAME from wh_BRANCHES where t_final like '" + txtTfinal.Text + "%' and isnull(WH_E_NAME,'') like '%" + Desc.Text + "'+'%'  ");
                    }
                }
                    dgv1.Columns[0].Width = 72;
            //}
            //catch { }

        }

        private void Desc_KeyUp(object sender, KeyEventArgs e)
        {
           
            search_();
           // OnKeyUp(e);
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
           // this.Height = 26;
            this.SendToBack();
            //this.BackColor = Color.Red;
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {

            int ii = dgv1.CurrentCell.RowIndex;

            ID.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
            //Desc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
            get_desc();

            dgv1.Visible = false;
           // this.Height = 26;
            this.SendToBack();

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            get_desc();
          //  OnLoad(e);

        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Branch_Leave(object sender, EventArgs e)
        {
          //  dgv1.Visible = false;
          // // this.Height = 26;
          //  this.SendToBack();
          ////  this.BackColor = Color.Transparent;
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_;

                if (Program.userID.ToLower() == "administrator")
                {
                    dt_ = dal.getDataTabl_1(@"select branch_name,WH_E_NAME,ACC_BRANCH from  wh_BRANCHES
                where  t_final like '" + txtTfinal.Text + "%' and Branch_code='" + ID.Text + "'");
                    //select branch_name,WH_E_NAME,ACC_BRANCH from wh_BRANCHES  where T_final like '" + txtTfinal.Text + "%' and Branch_code='" + ID.Text + "' ");
                }
                else
                {
                    dt_ = dal.getDataTabl_1(@"select A.branch_name,A.WH_E_NAME,A.ACC_BRANCH from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code
                   where b.User_id = '" + Program.userID.ToString() + "' and t_final like '" + txtTfinal.Text + "%' and A.Branch_code='" + ID.Text + "'");
                    //select branch_name,WH_E_NAME,ACC_BRANCH from wh_BRANCHES  where T_final like '" + txtTfinal.Text + "%' and Branch_code='" + ID.Text + "' ");

                }
                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["branch_name"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["WH_E_NAME"].ToString();
                    }
                    txtAccBranch.Text = dt_.Rows[0]["ACC_BRANCH"].ToString();
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
