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
    public partial class Uc_AccountOptions : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string btnKind = "";
        public Uc_AccountOptions()
        {
            InitializeComponent();


            cmb_DimCategory.DataSource = dal.getDataTabl_1(@"select * FROM Wh_Unit_dim");
            cmb_DimCategory.DisplayMember = "Wh_Unit_dim";
            cmb_DimCategory.ValueMember = "Wh_Unit_dim";
            cmb_DimCategory.SelectedIndex = -1;
        }

        private void Uc_StoreOptions_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void setDgvLocation(int _x ,int _y)
        {
            if (Properties.Settings.Default.lungh == "0")
            {
                dgv1.Location = new Point(_x-AccountDesc.Width, _y+20);

            }
            else
            {
                dgv1.Location = new Point(_x - AccountID.Width, _y + 20);

            }
        }
        private void search_(string btn,string MainID)
        {
            //try
            //{

            dgv1.Visible = true;
            //   this.Height = 150;
            // this.BringToFront();
            if (btn == "account")
            {
                btnKind = "account";
                setDgvLocation(btnAccount.Location.X, btnAccount.Location.Y);
                dgv1.DataSource = dal.getDataTabl_1("select ACC_NO,PAYER_NAME from payer2 where (PAYER_NAME like '%" + AccountDesc.Text + "%' or isnull(payer_l_name,'') like '%" + AccountDesc.Text + "%'  )and ( Acc_No like '" + MainID + "%' or  Acc_No like '" + txtAccCash.Text + "') and BRANCH_code like '" + branchID.Text + "%'  and t_final like '" + txtFinal.Text + "%' ORDER BY acc_no ");
            }
            else if (btn == "LcAccount")
            {
                btnKind = "LcAccount";
                setDgvLocation(btnLcAccount.Location.X, btnLcAccount.Location.Y);
                dgv1.DataSource = dal.getDataTabl_1("select ACC_NO,PAYER_NAME from payer2 where (PAYER_NAME like '%" + LcAccountDesc.Text + "%' or isnull(payer_l_name,'') like '%" + LcAccountDesc.Text + "%'  )and ( Acc_No like '" + MainID + "%' or  Acc_No like '" + txtAccCash.Text + "') and BRANCH_code like '" + branchID.Text + "%'  and t_final like '" + txtLcAccFinal.Text + "%' ORDER BY acc_no ");
            }

            else if (btn == "store")
            {
                btnKind = "store";
                setDgvLocation(btnStore.Location.X , btnStore.Location.Y);

                if (Properties.Settings.Default.lungh == "0")
                {
                    if (Program.userID.ToLower() == "administrator")
                    {
                        dgv1.DataSource = dal.getDataTabl_1(@"select Branch_code,branch_name from  wh_BRANCHES 
                        where  t_final like '" + txtStoreFinal.Text + "%' and branch_name like '%" + StoreDesc.Text + "%'");
                        //select Branch_code,branch_name from  wh_BRANCHES where t_final like '" + txtTfinal.Text+"%' and branch_name like '%" + Desc.Text + "'+'%'  ");
                    }
                    else
                    {
                        dgv1.DataSource = dal.getDataTabl_1(@"select A.Branch_code,A.branch_name from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code
                      where b.User_id = '" + Program.userID.ToString() + "' and t_final like '" + txtStoreFinal.Text + "%' and branch_name like '%" + StoreDesc.Text + "%'");
                        //select Branch_code,branch_name from  wh_BRANCHES where t_final like '" + txtTfinal.Text+"%' and branch_name like '%" + Desc.Text + "'+'%'  ");
                    }

                }
                else
                {
                    if (Program.userID.ToLower() == "administrator")
                    {
                        dgv1.DataSource = dal.getDataTabl_1(@"select Branch_code,WH_E_NAME from  wh_BRANCHES 
                      where  t_final like '" + txtStoreFinal.Text + "%' and isnull(WH_E_NAME,'') like '%" + StoreDesc.Text + "%'");

                    }
                    else
                    {
                        dgv1.DataSource = dal.getDataTabl_1(@"select A.Branch_code,A.WH_E_NAME from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code
                      where b.User_id = '" + Program.userID.ToString() + "' and t_final like '" + txtStoreFinal.Text + "%' and isnull(WH_E_NAME,'') like '%" + StoreDesc.Text + "%'");
                        //select Branch_code,WH_E_NAME from wh_BRANCHES where t_final like '" + txtTfinal.Text + "%' and isnull(WH_E_NAME,'') like '%" + Desc.Text + "'+'%'  ");
                    }
                }
            }

            else if (btn=="group1")
            {
                btnKind = "group1";
                setDgvLocation(btnGroup1.Location.X, btnGroup1.Location.Y);
                dgv1.DataSource = dal.getDataTabl_1("SELECT group_code,Group_name FROM wh_Groups where Group_name like '%" + GroupDesc1.Text + "'+'%'  ");
               
            }
            else if (btn == "group2")
            {
                btnKind = "group2";
                setDgvLocation(btnGroup2.Location.X, btnGroup2.Location.Y);
                dgv1.DataSource = dal.getDataTabl_1("SELECT group_code,Group_name FROM wh_Groups where Group_name like '%" + GroupDesc2.Text + "'+'%'  ");

            }

            dgv1.Columns[0].Width = 72;
            //}
            //catch { }

        }


        private void get_desc(string btn,string MainID,string Final)
        {
            if (btn == "account")
            {
                DataTable dt_ = dal.getDataTabl_1(@"select A.PAYER_NAME,A.payer_l_name,
                    B.MAIN_KM_CODE as V_PurchCode ,B.MAIN_KM_DESC as V_PurchDesc,
                    C.MAIN_KM_CODE as V_SalesCode,C.MAIN_KM_DESC as V_SalesDesc,
                    D.KM_RATIO as V_PurchRatio,
                    E.KM_RATIO as V_SalesRatio,
                    isnull(A.KM_CODE,'1') as KM_CODE
                    from payer2 As A 
                   left join KM_MAIN_ACC_CODE As B on isnull(A.KM_CODE_Purch,21)=B.MAIN_KM_CODE
				   left join KM_MAIN_ACC_CODE As C on isnull(A.KM_CODE_Sales,11)=C.MAIN_KM_CODE
				   left join KM_ACC_CODE As D on B.KM_CODE=D.KM_CODE
				   left join KM_ACC_CODE As E on C.KM_CODE=E.KM_CODE
                   where A.ACC_NO= '" + AccountID.Text + "'  and (A.acc_no like '" + MainID + "%' or A.acc_no like '" + txtAccCash.Text + "')   and A.BRANCH_code like '" + branchID.Text + "%' and A.t_final like '" + Final + "%' ");


                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        AccountDesc.Text = dt_.Rows[0]["PAYER_NAME"].ToString();
                    }
                    else
                    {
                        AccountDesc.Text = dt_.Rows[0]["payer_l_name"].ToString();
                    }
                    KM_Code_Purch.Text = dt_.Rows[0]["V_PurchCode"].ToString();
                    KM_Desc_Purch.Text = dt_.Rows[0]["V_PurchDesc"].ToString();
                    KM_Ratio_Purch.Text = dt_.Rows[0]["V_PurchRatio"].ToString();
                    KM_Code_Sales.Text = dt_.Rows[0]["V_SalesCode"].ToString();
                    KM_Desc_Sales.Text = dt_.Rows[0]["V_SalesDesc"].ToString();
                    KM_Ratio_Sales.Text = dt_.Rows[0]["V_SalesRatio"].ToString();
                    txtKMCode.Text = dt_.Rows[0]["KM_CODE"].ToString();
                }
                else
                {

                    AccountDesc.Clear();
                    KM_Code_Purch.Clear();
                    KM_Desc_Purch.Clear();
                    KM_Ratio_Purch.Clear();
                    KM_Code_Sales.Clear();
                    KM_Desc_Sales.Clear();
                    KM_Ratio_Sales.Clear();
                    txtKMCode.Clear();
                }
            }

           else if (btn == "LcAccount")
            {
                DataTable dt_ = dal.getDataTabl_1(@"select A.PAYER_NAME,A.payer_l_name,
                    B.MAIN_KM_CODE as V_PurchCode ,B.MAIN_KM_DESC as V_PurchDesc,
                    C.MAIN_KM_CODE as V_SalesCode,C.MAIN_KM_DESC as V_SalesDesc,
                    D.KM_RATIO as V_PurchRatio,
                    E.KM_RATIO as V_SalesRatio,
                    isnull(A.KM_CODE,'1') as KM_CODE
                    from payer2 As A 
                   left join KM_MAIN_ACC_CODE As B on isnull(A.KM_CODE_Purch,21)=B.MAIN_KM_CODE
				   left join KM_MAIN_ACC_CODE As C on isnull(A.KM_CODE_Sales,11)=C.MAIN_KM_CODE
				   left join KM_ACC_CODE As D on B.KM_CODE=D.KM_CODE
				   left join KM_ACC_CODE As E on C.KM_CODE=E.KM_CODE
                   where A.ACC_NO= '" + LcAccountID.Text + "'  and (A.acc_no like '" + MainID + "%' or A.acc_no like '" + txtAccCash.Text + "')   and A.BRANCH_code like '" + branchID.Text + "%' and A.t_final like '" + Final + "%' ");


                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        LcAccountDesc.Text = dt_.Rows[0]["PAYER_NAME"].ToString();
                    }
                    else
                    {
                        LcAccountDesc.Text = dt_.Rows[0]["payer_l_name"].ToString();
                    }
                }
                else
                {

                    LcAccountDesc.Clear();
                }
            }



            else if (btn == "store")
            {
                DataTable dt_;
                if (Program.userID.ToLower() == "administrator")
                {
                    dt_ = dal.getDataTabl_1(@"select branch_name,WH_E_NAME,ACC_BRANCH from  wh_BRANCHES 
                      where t_final like '" + txtStoreFinal.Text + "%' and Branch_code='" + StoreID.Text + "'");
                }
                else
                {
                    dt_ = dal.getDataTabl_1(@"select A.branch_name,A.WH_E_NAME,A.ACC_BRANCH from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code
                      where b.User_id = '" + Program.userID.ToString() + "' and t_final like '" + txtStoreFinal.Text + "%' and A.Branch_code='" + StoreID.Text + "'");

                }
                //select branch_name,WH_E_NAME,ACC_BRANCH from wh_BRANCHES  where T_final like '" + txtTfinal.Text+"%' and Branch_code='" + ID.Text + "' ");
                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        StoreDesc.Text = dt_.Rows[0]["branch_name"].ToString();
                    }
                    else
                    {
                        StoreDesc.Text = dt_.Rows[0]["WH_E_NAME"].ToString();
                    }
                    branchID.Text = dt_.Rows[0]["ACC_BRANCH"].ToString();
                }
                else
                {

                    StoreDesc.Clear();
                    branchID.Clear();

                }

            }

            else if(btn == "group1")
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT group_code,Group_name FROM wh_Groups where group_code = '" + GroupID1.Text + "' ");
                if (GroupID1.Text != "" && dt_.Rows.Count > 0)
                {
                    GroupID1.Text = dt_.Rows[0][0].ToString();
                    GroupDesc1.Text = dt_.Rows[0][1].ToString();
                }
                else
                {

                    GroupDesc1.Clear();

                }
            }

            else if (btn == "group2")
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT group_code,Group_name FROM wh_Groups where group_code = '" + GroupID2.Text + "' ");
                if (GroupID2.Text != "" && dt_.Rows.Count > 0)
                {
                    GroupID2.Text = dt_.Rows[0][0].ToString();
                    GroupDesc2.Text = dt_.Rows[0][1].ToString();
                }
                else
                {

                    GroupDesc2.Clear();

                }
            }


        }




        public void leaveID(string btn, string MainID, string Final)
        {
            if (btn == "account")
            {
                DataTable dt_ = dal.getDataTabl_1(@"select A.PAYER_NAME,A.payer_l_name,
                    B.MAIN_KM_CODE as V_PurchCode ,B.MAIN_KM_DESC as V_PurchDesc,
                    C.MAIN_KM_CODE as V_SalesCode,C.MAIN_KM_DESC as V_SalesDesc,
                    D.KM_RATIO as V_PurchRatio,
                    E.KM_RATIO as V_SalesRatio
                    from payer2 As A 
                   left join KM_MAIN_ACC_CODE As B on isnull(A.KM_CODE_Purch,21)=B.MAIN_KM_CODE
				   left join KM_MAIN_ACC_CODE As C on isnull(A.KM_CODE_Sales,11)=C.MAIN_KM_CODE
				   left join KM_ACC_CODE As D on B.KM_CODE=D.KM_CODE
				   left join KM_ACC_CODE As E on C.KM_CODE=E.KM_CODE
                   where A.ACC_NO= '" + AccountID.Text + "'  and (A.acc_no like '" + MainID + "%' or  A.acc_no like '" + txtAccCash.Text + "') and A.BRANCH_code like '" + branchID.Text + "'+'%' and A.t_final like '" + Final + "%' ");

                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        AccountDesc.Text = dt_.Rows[0]["PAYER_NAME"].ToString();
                    }
                    else
                    {
                        AccountDesc.Text = dt_.Rows[0]["payer_l_name"].ToString();
                    }
                    KM_Code_Purch.Text = dt_.Rows[0]["V_PurchCode"].ToString();
                    KM_Desc_Purch.Text = dt_.Rows[0]["V_PurchDesc"].ToString();
                    KM_Ratio_Purch.Text = dt_.Rows[0]["V_PurchRatio"].ToString();
                    KM_Code_Sales.Text = dt_.Rows[0]["V_SalesCode"].ToString();
                    KM_Desc_Sales.Text = dt_.Rows[0]["V_SalesDesc"].ToString();
                    KM_Ratio_Sales.Text = dt_.Rows[0]["V_SalesRatio"].ToString();
                }
                else
                {
                    AccountID.Clear();
                    AccountDesc.Clear();
                    KM_Code_Purch.Clear();
                    KM_Desc_Purch.Clear();
                    KM_Ratio_Purch.Clear();
                    KM_Code_Sales.Clear();
                    KM_Desc_Sales.Clear();
                    KM_Ratio_Sales.Clear();
                }

            }
            else if (btn=="store")
            {
                DataTable dt_;

                if (Program.userID.ToLower() == "administrator")
                {
                    dt_ = dal.getDataTabl_1(@"select branch_name,WH_E_NAME,ACC_BRANCH from  wh_BRANCHES
                where  t_final like '" + txtStoreFinal.Text + "%' and Branch_code='" + StoreID.Text + "'");
                    //select branch_name,WH_E_NAME,ACC_BRANCH from wh_BRANCHES  where T_final like '" + txtTfinal.Text + "%' and Branch_code='" + ID.Text + "' ");
                }
                else
                {
                    dt_ = dal.getDataTabl_1(@"select A.branch_name,A.WH_E_NAME,A.ACC_BRANCH from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code
                   where b.User_id = '" + Program.userID.ToString() + "' and t_final like '" + Final + "%' and A.Branch_code='" + StoreID.Text + "'");
                    //select branch_name,WH_E_NAME,ACC_BRANCH from wh_BRANCHES  where T_final like '" + txtTfinal.Text + "%' and Branch_code='" + ID.Text + "' ");

                }
                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        StoreDesc.Text = dt_.Rows[0]["branch_name"].ToString();
                    }
                    else
                    {
                        StoreDesc.Text = dt_.Rows[0]["WH_E_NAME"].ToString();
                    }
                    branchID.Text = dt_.Rows[0]["ACC_BRANCH"].ToString();
                }
                else
                {
                    StoreID.Clear();
                    StoreDesc.Clear();
                    branchID.Clear();

                }

                 dt_ = dal.getDataTabl_1(@"select A.PAYER_NAME,A.payer_l_name,
                    B.MAIN_KM_CODE as V_PurchCode ,B.MAIN_KM_DESC as V_PurchDesc,
                    C.MAIN_KM_CODE as V_SalesCode,C.MAIN_KM_DESC as V_SalesDesc,
                    D.KM_RATIO as V_PurchRatio,
                    E.KM_RATIO as V_SalesRatio
                    from payer2 As A 
                   left join KM_MAIN_ACC_CODE As B on isnull(A.KM_CODE_Purch,21)=B.MAIN_KM_CODE
				   left join KM_MAIN_ACC_CODE As C on isnull(A.KM_CODE_Sales,11)=C.MAIN_KM_CODE
				   left join KM_ACC_CODE As D on B.KM_CODE=D.KM_CODE
				   left join KM_ACC_CODE As E on C.KM_CODE=E.KM_CODE
                   where A.ACC_NO= '" + AccountID.Text + "'  and (A.acc_no like '" + txtMainAcc.Text + "%' or  A.acc_no like '" + txtAccCash.Text + "') and A.BRANCH_code like '" + branchID.Text + "'+'%' and A.t_final like '" + txtFinal.Text + "%' ");

                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        AccountDesc.Text = dt_.Rows[0]["PAYER_NAME"].ToString();
                    }
                    else
                    {
                        AccountDesc.Text = dt_.Rows[0]["payer_l_name"].ToString();
                    }
                    KM_Code_Purch.Text = dt_.Rows[0]["V_PurchCode"].ToString();
                    KM_Desc_Purch.Text = dt_.Rows[0]["V_PurchDesc"].ToString();
                    KM_Ratio_Purch.Text = dt_.Rows[0]["V_PurchRatio"].ToString();
                    KM_Code_Sales.Text = dt_.Rows[0]["V_SalesCode"].ToString();
                    KM_Desc_Sales.Text = dt_.Rows[0]["V_SalesDesc"].ToString();
                    KM_Ratio_Sales.Text = dt_.Rows[0]["V_SalesRatio"].ToString();
                }
                else
                {
                    AccountID.Clear();
                    AccountDesc.Clear();
                    KM_Code_Purch.Clear();
                    KM_Desc_Purch.Clear();
                    KM_Ratio_Purch.Clear();
                    KM_Code_Sales.Clear();
                    KM_Desc_Sales.Clear();
                    KM_Ratio_Sales.Clear();
                }




            }
            else if (btn == "LcAccount")
           {
                DataTable dt_ = dal.getDataTabl_1(@"select A.PAYER_NAME,A.payer_l_name,
                    B.MAIN_KM_CODE as V_PurchCode ,B.MAIN_KM_DESC as V_PurchDesc,
                    C.MAIN_KM_CODE as V_SalesCode,C.MAIN_KM_DESC as V_SalesDesc,
                    D.KM_RATIO as V_PurchRatio,
                    E.KM_RATIO as V_SalesRatio
                    from payer2 As A 
                   left join KM_MAIN_ACC_CODE As B on isnull(A.KM_CODE_Purch,21)=B.MAIN_KM_CODE
				   left join KM_MAIN_ACC_CODE As C on isnull(A.KM_CODE_Sales,11)=C.MAIN_KM_CODE
				   left join KM_ACC_CODE As D on B.KM_CODE=D.KM_CODE
				   left join KM_ACC_CODE As E on C.KM_CODE=E.KM_CODE
                   where A.ACC_NO= '" + LcAccountID.Text + "'  and (A.acc_no like '" + MainID + "%' or  A.acc_no like '" + txtAccCash.Text + "') and A.BRANCH_code like '" + branchID.Text + "'+'%' and A.t_final like '" + Final + "%' ");

                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        LcAccountDesc.Text = dt_.Rows[0]["PAYER_NAME"].ToString();
                    }
                    else
                    {
                        LcAccountDesc.Text = dt_.Rows[0]["payer_l_name"].ToString();
                    }
                                 }
                else
                {
                    LcAccountID.Clear();
                    LcAccountDesc.Clear();
                   }


            }

        }



        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            int ii = dgv1.CurrentCell.RowIndex;
            if (btnKind == "account")
            {
            AccountID.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
            AccountDesc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
                AccountID.Focus();
            }

            else if (btnKind == "LcAccount")
            {
                LcAccountID.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
                LcAccountDesc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
                LcAccountID.Focus();
            }


            else if (btnKind == "store")
            {
                StoreID.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
                StoreDesc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
                StoreID.Focus();
            }

            else if (btnKind == "group1")
            {
                GroupID1.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
                GroupDesc1.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
                GroupID1.Focus();
            }
            else if (btnKind == "group2")
            {
                GroupID2.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
                GroupDesc2.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
                GroupID2.Focus();
            }






            dgv1.Visible = false;
            //this.Height = 22;
            //this.SendToBack();

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            search_("account",txtMainAcc.Text);
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            search_("store","");
        }

        private void StoreID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
        }

        private void AccountID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
        }

        private void GroupID1_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
        }

        private void GroupID2_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
        }

        private void AccountID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc("account",txtMainAcc.Text,txtFinal.Text);
        }

        private void AccountID_Leave(object sender, EventArgs e)
        {
            leaveID("account",txtMainAcc.Text,txtFinal.Text);
        }

        private void AccountID_TextChanged(object sender, EventArgs e)
        {
            get_desc("account", txtMainAcc.Text, txtFinal.Text);
        }

        private void StoreID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc("store","",txtStoreFinal.Text);
        }

        private void StoreID_Leave(object sender, EventArgs e)
        {
            leaveID("store","",txtStoreFinal.Text);
        }

        private void StoreID_TextChanged(object sender, EventArgs e)
        {
            get_desc("store","", txtStoreFinal.Text);
        }

        private void StoreDesc_KeyUp(object sender, KeyEventArgs e)
        {
            search_("store","");
        }

        private void AccountDesc_KeyUp(object sender, KeyEventArgs e)
        {
            search_("account",txtMainAcc.Text);
        }

        private void GroupID1_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc("group1","","");
        }

        private void GroupID1_TextChanged(object sender, EventArgs e)
        {
            get_desc("group1", "", "");
        }

        private void GroupID2_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc("group2","","");

        }

        private void GroupID2_TextChanged(object sender, EventArgs e)
        {
            get_desc("group2","","");

        }

        private void btnGroup1_Click(object sender, EventArgs e)
        {
            search_("group1","");
        }

        private void btnGroup2_Click(object sender, EventArgs e)
        {
            search_("group2","");
        }

        private void GroupDesc1_KeyUp(object sender, KeyEventArgs e)
        {
            search_("group1","");

        }

        private void GroupDesc2_KeyUp(object sender, KeyEventArgs e)
        {
            search_("group2","");

        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //PL.frm_search_items frm = new PL.frm_search_items();
            //frm.ShowDialog();
            //if (frm.clos_ == 1)
            //{
            //    ItemID1.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
            //}
            //ItemID1.Focus();
            //}
            //catch { }

            uc_SearchItem1.Visible = true;
          //  uc_SearchItem1.Dock = DockStyle.Fill;
           // this.Dock = DockStyle.Fill;
            //this.BringToFront();

        }

        private void Uc_StoreOptions_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void uc_SearchItem1_DoubleClick(object sender, EventArgs e)
        {
            if (uc_SearchItem1.dGV_pro_list.SelectedRows.Count > 0)
            {
                if (uc_SearchItem1.ch_SaveSearch.Checked == true)
                {
                    ItemID1.Text = uc_SearchItem1.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();

                }
                else
                {
                    ItemID1.Text = uc_SearchItem1.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                    dal.ClearTextBoxes_uc(uc_SearchItem1);

                }
                uc_SearchItem1.Visible = false;
                ItemID1.Focus();


                //if (Properties.Settings.Default.lungh == "0")
                //{
                //    this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                //}
                //else
                //{
                //    this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                //}
                // this.Dock = DockStyle.None;
            }
        }

        private void ItemID1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                get_ItemDesc();
                OnKeyDown(e);
            }

        }


        private void get_ItemDesc()
        {
            //try
            //{
                DataTable dt_ = dal.getDataTabl_1("SELECT item_no,descr,Descr_eng,isnull(Weight,0) as Weight,Unit,isnull(sale_price,0) as sale_price,local_cost,UnitLenth,Unitwidth,UnitDepth " +
                    ",isnull(KM_CODE,'1') as KM_CODE,(select top 1 vat_ratio from VAT_RATIO_MASTER where  date_of_vat <= '" + DateTime.Today.ToString("yyyy-MM-dd") + "'  order by date_of_vat desc) as VatRatio " +
                    "FROM wh_main_master where item_no = '" + ItemID1.Text + "' or factory_no= '" + ItemID1.Text + "' ");
                if (ItemID1.Text != "" && dt_.Rows.Count > 0)
                {


                    ItemID1.Text = dt_.Rows[0]["item_no"].ToString();
                    itemWeight.Value = Convert.ToDouble(dt_.Rows[0]["Weight"].ToString());
                    itemPrice.Value = Convert.ToDouble(dt_.Rows[0]["sale_price"].ToString());
                    itemUnit.Text = dt_.Rows[0]["Unit"].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        ItemDesc1.Text = dt_.Rows[0]["descr"].ToString();
                    }
                    else
                    {
                        ItemDesc1.Text = dt_.Rows[0]["Descr_eng"].ToString();
                    }
                    txtCost.Text = dt_.Rows[0]["local_cost"].ToString().ToDecimal().ToString();
                    txtLenth.Text = dt_.Rows[0]["UnitLenth"].ToString().ToDecimal().ToString();
                    txtWidth.Text = dt_.Rows[0]["Unitwidth"].ToString().ToDecimal().ToString();
                    txtDepth.Text = dt_.Rows[0]["UnitDepth"].ToString().ToDecimal().ToString();
                    txtItemVat.Text = dt_.Rows[0]["VatRatio"].ToString().ToDecimal().ToString("N0");
                    txtKmItem.Text = dt_.Rows[0]["KM_CODE"].ToString().ToDecimal().ToString("N0");
                    
                }
                else
                {

                    ItemDesc1.Clear();
                    itemWeight.Value = 0;
                    itemPrice.Value = 0;
                    itemUnit.Clear();
                    txtCost.Value = 0;
                    txtLenth.Value = 0;
                    txtWidth.Value = 0;
                    txtDepth.Value = 0;
                    itemUnit.Text = "";
                   btnItem1.PerformClick();

                }
            //}

            //catch { }
        }

        private void ItemID1_Leave(object sender, EventArgs e)
        {
            if (ItemID1.Text.Trim() != string.Empty)
            {
                get_ItemDesc();
            }
        }

        private void LcAccountID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;

        }

        private void LcAccountID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc("LcAccount", txtMainLcAcc.Text, txtLcAccFinal.Text);
        }

        private void LcAccountID_Leave(object sender, EventArgs e)
        {
            leaveID("LcAccount",txtMainLcAcc.Text,txtLcAccFinal.Text);
        }

        private void LcAccountID_TextChanged(object sender, EventArgs e)
        {
            get_desc("LcAccount", txtMainLcAcc.Text, txtLcAccFinal.Text);
        }

        private void btnLcAccount_Click(object sender, EventArgs e)
        {
            search_("LcAccount",txtMainLcAcc.Text);
        }

        private void LcAccountDesc_KeyUp(object sender, KeyEventArgs e)
        {
            search_("LcAccount",txtMainLcAcc.Text);
        }
    }
}
