using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

using Outlook = Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Data.SqlClient;

namespace Report_Pro.PL
{
    public partial class frm_Exchange_Materials : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();
        Int32 m;

        public string clos_type;
        string btntype = "0";
        string frmType = "ADD";
        string BranchCode_ = Properties.Settings.Default.BranchId;
        
        public frm_Exchange_Materials()
        {
            InitializeComponent();


            txt_InvSM.Text = Program.salesman;
            userID.Text = Program.userID;
            txt_cyear.Text = DateTime.Now.ToString("yy");
            txt_InvDate.Text = DateTime.Today.ToString("yyyy/MM/dd hh:mm:ss");


        }

        private void tabControlPanel2_Click(object sender, EventArgs e)
        {
            DataTable dt_R = dal.getDataTabl_1(@"select A.Ser_no,A.Branch_code,A.Transaction_code, A.Cyear ,A.G_date,A.ITEM_NO,B.descr,isnull(A.R_Qty,0) - isnull(Qty_out, 0) as balance
                        ,B.Descr_eng,Br.branch_name ,Br.WH_E_NAME
                        FROM R_Qutation_Transaction As A
                        inner join wh_main_master as B on B.item_no = A.ITEM_NO
                        inner join  wh_BRANCHES as Br on Br.Branch_code = A.Branch_code
						inner join  R_Qutation As C on A.Branch_code = C.Branch_code and A.Transaction_code = C.TRANSACTION_CODE and A.Cyear = C.Cyear and A.Ser_no = C.SER_NO
                        where A.Transaction_code = 'rm'
                        and(A.R_Qty - isnull(Qty_out, 0)) > 0 
                        and C.Acc_no ='"+BranchCode_+"'");

            int rowscount = dt_R.Rows.Count;
            dgv_R.Rows.Clear();
            if (rowscount > 0)
            {

                dgv_R.Rows.Add(rowscount);
                for (int i = 0; i <= (rowscount - 1); i++)
                {

                    dgv_R.Rows[i].Cells[0].Value = dt_R.Rows[i]["Ser_no"];
                    dgv_R.Rows[i].Cells[1].Value = dt_R.Rows[i]["G_date"];
                    dgv_R.Rows[i].Cells[2].Value = dt_R.Rows[i]["Branch_code"];
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        dgv_R.Rows[i].Cells[3].Value = dt_R.Rows[i]["branch_name"];
                        dgv_R.Rows[i].Cells[5].Value = dt_R.Rows[i]["descr"];
                    }
                    else
                    {
                        dgv_R.Rows[i].Cells[3].Value = dt_R.Rows[i]["WH_E_NAME"];
                        dgv_R.Rows[i].Cells[5].Value = dt_R.Rows[i]["Descr_eng"];
                    }
                        dgv_R.Rows[i].Cells[4].Value = dt_R.Rows[i]["ITEM_NO"];
                    
                    dgv_R.Rows[i].Cells[6].Value = dt_R.Rows[i]["balance"];
                }
            }
        }


        private void dGV_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void clear_texts()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;

                    else
                        func(control.Controls);
            };

            func(Controls);
            dt.Clear();

        }











        private void groupPanel6_Click(object sender, EventArgs e)
        {

        }

        private void Uc_Branch_Load(object sender, EventArgs e)
        {
            //   uc_Supplier1.branchID.Text = Uc_Branch.ID.Text;
            if (frmType == "ADD")
            {
                DataTable dt_br = dal.getDataTabl("Get_branch_Name_", requset_Branch.ID.Text, dal.db1);

                if (dt_br.Rows.Count > 0)
                {

                    txt_MainNote.Text = dt_br.Rows[0][28].ToString();
                    Cost_Center.txtBranch.Text = requset_Branch.ID.Text;
                    getJorSer();
                }
            }
        }

        private void getJorSer()
        {
            DataTable serDb = dal.getDataTabl_1("select isnull(OPO+1,1) FROM wh_Serial where Branch_code='" + Branch.ID.Text + "' and Cyear='" + txt_InvDate.Value.ToString("yy") + "' ");
            if (serDb.Rows.Count > 0)
            {
                txt_serNo.Text = serDb.Rows[0][0].ToString();
            }
            else
            {
                txt_serNo.Text="1";

            }


        }

        private void BNew_Click(object sender, EventArgs e)
        {
            clear_texts();
            getJorSer();
            requset_Branch.ID.Text = Properties.Settings.Default.BranchId;
            //BSave.Enabled = true;

        }



        private void BSave_Click(object sender, EventArgs e)
        {
            Assembly a = Assembly.Load("Report_Pro");
            ResourceManager rm = new ResourceManager("Report_Pro.RPT.login_frm", a);

            if (requset_Branch.ID.Text == string.Empty)
            {
                MessageBox.Show(rm.GetString("txtMes"), rm.GetString("MesH"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (delivry_Grid1.flowLayoutPanel1.Controls.Count < 1)
            {
                MessageBox.Show(rm.GetString("txtMes"), rm.GetString("MesH"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            add_I_RM();
        }




        private void add_I_RM()
        {
            SqlCommand cmd = dal.sqlconn_1.CreateCommand();
            SqlTransaction trans;
            trans = dal.sqlconn_1.BeginTransaction();
            cmd.Connection = dal.sqlconn_1;
            cmd.Transaction = trans;
            try
            {

                                             
                cmd.CommandText = @"INSERT INTO wh_inv_data 
			        (Ser_no ,Branch_code,Transaction_code
                    ,Cyear,Sanad_no,G_date
                    ,ACC_TYPE,Acc_no,Acc_Branch_code
                    ,Other_branch_code,Payment_Type,Sales_man_Id
                    ,acc_serial_no,Po_no,User_id
                    ,Inv_Notes,Second_Payment_User)

                    VALUES ('" + txt_serNo.Text + "','" + Branch.ID.Text + "','" + txt_transaction_code.Text + "','" +
                    txt_InvDate.Value.ToString("yy") + "','" + requset_Ser.Text + "','" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                    "'A','"+Cost_Center.txtAcc.Text+"','" + Branch.txtAccBranch.Text + "','" +
                    requset_Branch.ID.Text + "','2','" + Cost_Center.ID.Text + "','" +
                    AccSer_No.Text + "','    ','" + userID.Text + "','" +
                    txt_MainNote.Text + "','" + txtStoreMan.ID.Text + "')";

                cmd.ExecuteNonQuery();

                foreach (MyControls.Delivry_Row r in delivry_Grid1.flowLayoutPanel1.Controls)
                {
                    if (r.txt_Code.Text.Trim() != string.Empty && r.qty.Value > 0)
                    {

                        cmd.CommandText = @"insert into wh_material_transaction 
                        (SER_NO,Branch_code,TRANSACTION_CODE
                         ,Cyear,SANAD_NO,ITEM_NO
                        ,QTY_ADD,QTY_TAKE,Qty_Sales_Holding_balance,Qry_Purch_holding_balance,Return_Qty,total_disc,DISC_R,DISC_R2,DISC_R3
                        ,G_DATE,Unit
                        ,model,Local_Price,USER_ID
                        ,main_counter,balance) 
                         VALUES('" + txt_serNo.Text + "','" + Branch.ID.Text + "','" + txt_transaction_code.Text + 
                         "','" + txt_InvDate.Value.ToString("yy") + "','"+requset_Ser.Text+ "','" + r.txt_Code.Text + 
                         "','0','" + r.qty.Text.ToDecimal() +"','0','0','0','0','0','0','0','" + 
                         txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + r.txtUnit.Text + 
                         "','" + Convert.ToString(r.txtModel.SelectedValue) + "','" + r.txtCost.Text.ToDecimal() + "','" + userID.Text + 
                         "',('" + r.Ser.Value + "')-1,'"+r.txtBalance.Text.ToDecimal()+"')";

                        cmd.ExecuteNonQuery();
                        //DataTable dt_r = dal.getDataTabl_1(@"select ser_no from  R_Qutation_Transaction where SER_NO ='" + requset_Ser.Text + "' and TRANSACTION_code='RM' and ITEM_NO='" + r.txt_Code.Text + "' and Cyear='" + Request_Year.Text + "'");
                        //if (dt_r.Rows.Count > 0)
                        //{
                            cmd.CommandText = @"update R_Qutation_Transaction set Qty_Out = (select isnull (Qty_Out,0) From R_Qutation_Transaction  where SER_NO ='" + requset_Ser.Text + "' and TRANSACTION_code='RM' and ITEM_NO='" + r.txt_Code.Text + "' and Cyear='" + Request_Year.Text + "' and Branch_code= '"+requset_Branch.ID.Text+"') + '" + r.qty.Value +
                            "', R_balance = (select isnull (R_Qty,0) - isnull (Qty_Out,0) From R_Qutation_Transaction  where SER_NO ='" + requset_Ser.Text + "' and TRANSACTION_code='RM' and ITEM_NO='" + r.txt_Code.Text + "' and Cyear='" + Request_Year.Text + "' and Branch_code= '" + requset_Branch.ID.Text + "') - '" + r.qty.Value +
                            "' where SER_NO ='" + requset_Ser.Text + "' and TRANSACTION_code='RM' and ITEM_NO='" + r.txt_Code.Text + "' and Cyear='" + Request_Year.Text + "' and Branch_code= '" + requset_Branch.ID.Text + "'";
                            cmd.ExecuteNonQuery();
                        //}
                        //SELECT BALANCE, local_cost FROM wh_main_master where item_no = '"+item_No+"'
                        cmd.CommandText = @"update wh_main_master set BALANCE = (SELECT isnull(BALANCE,0) From VIEW_balance where item_no ='" + r.txt_Code.Text + "' and Branch_code = '"+ Branch.ID.Text + "') -'" + r.qty.Value +"'";
                        cmd.ExecuteNonQuery();

                    }
                }


                cmd.CommandText = @" IF EXISTS(SELECT OPO From wh_Serial where Branch_code='" + Branch.ID.Text
                   + "' and Cyear= '" + txt_InvDate.Value.ToString("yy") +
                   "' ) BEGIN   Update wh_Serial set OPO ='" + txt_serNo.Text + "'  where Branch_code='" + Branch.ID.Text
                   + "' and Cyear= '" + txt_InvDate.Value.ToString("yy") +
                   "' END ELSE BEGIN  INSERT wh_Serial (Branch_code, Cyear, OPO)" +
                   "VALUES ('"+ Branch.ID.Text+ "','" + txt_InvDate.Value.ToString("yy") + "','" + txt_serNo.Text + "')END ";



                //cmd.CommandText = @"Update wh_Serial set OPO ='" + txt_serNo.Text + "'  where Branch_code='" + requset_Branch.ID.Text
                //   + "' and Cyear= '" + txt_InvDate.Value.ToString("yy") + "' ";
                cmd.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("تم الحفظ بنجاح", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dal.sqlconn_1.Close();
            }

        }



     

        private void btnOk_Click(object sender, EventArgs e)
        {
            //frmType = "EDIT";

            //DataTable dt_RQ = dal.getDataTabl_1(@"select A.Ser_no,A.Branch_code,A.Transaction_code, A.Cyear ,A.G_date,A.Cost_center,A.user_id,A.R_person
            //            ,A.C_Notes,A.Acc_no,B.ITEM_NO,B.Item_Description,B.R_unit,B.R_Weight,B.R_Qty,b.R_balance,B.R_totalWeight ,m.descr
            //            ,m.Descr_eng,m.Weight,m.Unit,Br.branch_name as Acc_Name,Br.WH_E_NAME as Acc_Name_E
            //            ,B2.branch_name,B2.WH_E_NAME FROM R_Qutation As A 
            //            inner join R_Qutation_Transaction As B
            //            on a.Branch_code = b.Branch_code and a.Transaction_code = b.TRANSACTION_CODE and a.Cyear = b.Cyear and a.Ser_no = b.SER_NO
            //            inner join  wh_main_master as M on m.item_no = b.ITEM_NO 
            //            inner join  wh_BRANCHES as Br on Br.Branch_code = a.Branch_code 
            //            inner join wh_BRANCHES as B2 on B2.Branch_code = a.Acc_no 
            //            where A.ser_no = '" + txtSearch.Text + "' and a.Transaction_code = '" + txt_transaction_code.Text + "' and A.Branch_code='" + Search_Branch.ID.Text + "'");

            //if (dt_RQ.Rows.Count > 0)
            //{


            //    txt_serNo.Text = dt_RQ.Rows[0]["Ser_no"].ToString();
            //    requset_Branch.ID.Text = dt_RQ.Rows[0]["Branch_code"].ToString();
            //    txt_InvDate.Text = dt_RQ.Rows[0]["G_date"].ToString();
            //    Cost_Center.ID.Text = dt_RQ.Rows[0]["Cost_center"].ToString();

            //    txt_MainNote.Text = dt_RQ.Rows[0]["C_Notes"].ToString();
            //    txtStoreMan.ID.Text = dt_RQ.Rows[0]["R_person"].ToString();
            //    Branch.ID.Text = dt_RQ.Rows[0]["Acc_no"].ToString();
            //    delivry_Grid1.txtCo_Code.Text = Branch.ID.Text.Substring(0, 1);
            //    int i = 0;
            //    delivry_Grid1.flowLayoutPanel1.Controls.Clear();

            //    foreach (DataRow r in dt_RQ.Rows)
            //    {

            //        MyControls.Delivry_Row row = new MyControls.Delivry_Row();
            //        row.txt_Code.Text = dt_RQ.Rows[i]["ITEM_NO"].ToString();
            //        if (Properties.Settings.Default.lungh == "0")
            //        {
            //            row.TxtDesc.Text = dt_RQ.Rows[i]["Descr"].ToString();
            //        }
            //        else
            //        {
            //            row.TxtDesc.Text = dt_RQ.Rows[i]["Descr_eng"].ToString();
            //        }
            //        row.txtNote.Text = dt_RQ.Rows[i]["Item_Description"].ToString();
            //        row.txtUnit.Text = dt_RQ.Rows[i]["R_unit"].ToString();
            //        row.Weight_.Text = dt_RQ.Rows[i]["R_Weight"].ToString().ToDecimal().ToString("N3");
            //        row.qty.Text = dt_RQ.Rows[i]["R_Qty"].ToString().ToDecimal().ToString("N0");
            //        row.totWeight.Text = dt_RQ.Rows[i]["R_totalWeight"].ToString().ToDecimal().ToString("N1");
            //        row.txtBalance.Text = dt_RQ.Rows[i]["R_balance"].ToString().ToDecimal().ToString("N3");

            //        row.Co_code = delivry_Grid1.txtCo_Code.Text;

            //        delivry_Grid1.flowLayoutPanel1.Controls.Add(row);

            //        row.KeyDown += delivry_Grid1.r_KeyDown;
            //        row.KeyUp += delivry_Grid1.r_KeyUP;
            //        row.Enter += delivry_Grid1.r_Enter;
            //        row.Click += delivry_Grid1.r_Click;

            //        i = i + 1;
            //    }




            //}
            //else
            //{
            //    MessageBox.Show("تاكد من الرقم", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

       

        private void Uc_Branch_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt_br = dal.getDataTabl("Get_branch_Name_", requset_Branch.ID.Text, dal.db1);

            if (dt_br.Rows.Count > 0)
            {

                getJorSer();
            }
        }

       
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            RPT.Form1 frm = new RPT.Form1();

            RPT.rpt_Supplay_Matrails rpt = new RPT.rpt_Supplay_Matrails();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@" select A.Ser_no, A.Sanad_no,A.Branch_code,A.Transaction_code, A.Cyear ,A.G_date,A.Sales_man_Id,A.user_id,A.Second_Payment_User
                        ,A.Inv_Notes,A.Acc_no,A.Other_branch_code,B.ITEM_NO,B.G_ITEM_NO,B.Unit,B.QTY_ADD,B.QTY_TAKE,B.Local_Price,B.balance
						,M.descr
                        ,M.Descr_eng,M.Weight
						,Br.branch_name as Acc_Name,Br.WH_E_NAME as Acc_Name_E
                        ,B2.branch_name,B2.WH_E_NAME
						,C1.COST_name,C1.COST_E_NAME,C2.COST_name as RP,C2.COST_E_NAME as RP_E
                        FROM wh_inv_data As A
                        inner join wh_material_transaction As B
                        on a.Branch_code = b.Branch_code and a.Transaction_code = b.TRANSACTION_CODE and a.Cyear = b.Cyear and a.Ser_no = b.SER_NO
                        inner join  wh_main_master as M on M.item_no = B.ITEM_NO
                        inner join  wh_BRANCHES as Br on Br.Branch_code = a.Branch_code
                        left join wh_BRANCHES as B2 on B2.Branch_code = A.Other_branch_code
						left join COST_CENTER as C1 on C1.COST_CODE=A.Sales_man_Id
			            left join COST_CENTER as C2 on C2.COST_CODE=A.Second_Payment_User
            where A.ser_no = '" + txt_serNo.Text + "' and a.Transaction_code = '" + txt_transaction_code.Text + "' and A.Branch_code='" + Branch.ID.Text + "' and A.Cyear='"+txt_cyear.Text+"' ");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.DataDefinition.FormulaFields["Co_Name_E"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
            rpt.DataDefinition.FormulaFields["Branch_E_"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            rpt.SetDataSource(ds);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.WindowState = FormWindowState.Maximized;

            frm.ShowDialog();

        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            RPT.Form1 frm = new RPT.Form1();

            RPT.rpt_R_Qutation rpt = new RPT.rpt_R_Qutation();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT A.*,b.*,m.descr,m.Descr_eng,m.Weight,m.Unit,Br.branch_name,Br.WH_E_NAME,
            p.PAYER_NAME,p.payer_l_name FROM " + dal.db1 + ".dbo.R_Qutation As A " +
            "inner join  " + dal.db1 + ".dbo.R_Qutation_Transaction As B" +
            " on a.Branch_code = b.Branch_code and a.Transaction_code = b.TRANSACTION_CODE and a.Cyear = b.Cyear and a.Ser_no = b.SER_NO " +
            "inner join  " + dal.db1 + ".dbo.wh_main_master as M on m.item_no = b.ITEM_NO " +
            "inner join  " + dal.db1 + ".dbo.wh_BRANCHES as Br on Br.Branch_code = a.Branch_code " +
            "inner join  " + dal.db1 + ".dbo.payer2 as P on P.acc_no = a.acc_no and p.branch_code = a.branch_code " +
            "where A.ser_no = '" + txt_serNo.Text + "' and a.Transaction_code = '" + txt_transaction_code.Text + "'");
            ds.Tables.Add(dt1);
            ////ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["Co_Name_E"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
            rpt.DataDefinition.FormulaFields["Branch_E_"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";

            frm.crystalReportViewer1.ReportSource = rpt;
            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, (Application.StartupPath + "\\attachment.pdf"));
            Outlook.Application oApp = new Outlook.Application();
            Outlook.MailItem email = (Outlook.MailItem)(oApp.CreateItem(Outlook.OlItemType.olMailItem));
            email.To = "";
            //email.Attachments.Add(Application.StartupPath + "\\attachment.pdf");
            email.Subject = "Material Request : " + this.txt_serNo.Text;
            email.Display(true);


        }




        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_R_Qutaion_Load(object sender, EventArgs e)
        {
            

           Branch.ID.Text = Properties.Settings.Default.BranchId;

            Cost_Center.txtMain.Text = "4";
            Cost_Center.txt_Tfinl.Text = "1";

            txtStoreMan.txtMain.Text = "3";
            txtStoreMan.txt_Tfinl.Text = "1";
            getJorSer();
        }

        private void Spacil_Chb_CheckedChanged(object sender, EventArgs e)
        {
            //if (Spacil_Chb.Checked == true)
            //{
            //    Spacil_Chb.BackColor = Color.Yellow;
            //}
            //else
            //{
            //    Spacil_Chb.BackColor = Color.Transparent;
            //}
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void Supply_Branch_Load(object sender, EventArgs e)
        {
            if (Branch.ID.Text.Trim() != string.Empty)
            {
                delivry_Grid1.txtCo_Code.Text = Branch.ID.Text.Substring(0, 1);
            }
            else
            {
                delivry_Grid1.txtCo_Code.Clear();
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_R_DoubleClick(object sender, EventArgs e)
        {
            string ser_ = dgv_R.CurrentRow.Cells["Ser_no"].Value.ToString();
            string r_branch = dgv_R.CurrentRow.Cells["Branch_Code"].Value.ToString();


            DataTable dt_RQ = dal.getDataTabl_1(@"select A.Ser_no,A.Branch_code,A.Transaction_code, A.Cyear ,A.G_date,A.Cost_center,A.user_id,A.R_person
                        ,A.C_Notes,A.Acc_no,B.ITEM_NO,B.Item_Description,B.R_unit,B.R_Weight,B.R_Qty,b.R_balance,B.R_totalWeight ,m.descr
                        ,m.Descr_eng,m.Weight,m.Unit,Br.branch_name as Acc_Name,Br.WH_E_NAME as Acc_Name_E
                        ,B2.branch_name,B2.WH_E_NAME FROM R_Qutation As A 
                        inner join R_Qutation_Transaction As B
                        on a.Branch_code = b.Branch_code and a.Transaction_code = b.TRANSACTION_CODE and a.Cyear = b.Cyear and a.Ser_no = b.SER_NO
                        inner join  wh_main_master as M on m.item_no = b.ITEM_NO 
                        inner join  wh_BRANCHES as Br on Br.Branch_code = a.Branch_code 
                        inner join wh_BRANCHES as B2 on B2.Branch_code = a.Acc_no 
                        where A.ser_no = '" + ser_ + "' and a.Transaction_code = 'RM' and A.Acc_no='" + BranchCode_+ "' and A.Branch_code ='"+r_branch+"' ");

            if (dt_RQ.Rows.Count > 0)
            {


                requset_Ser.Text = dt_RQ.Rows[0]["Ser_no"].ToString();
                requset_Branch.ID.Text = dt_RQ.Rows[0]["Branch_code"].ToString();
                //txt_InvDate.Text = dt_RQ.Rows[0]["G_date"].ToString();
                Cost_Center.ID.Text = dt_RQ.Rows[0]["Cost_center"].ToString();

                txt_MainNote.Text = dt_RQ.Rows[0]["C_Notes"].ToString();
                //txtStoreMan.ID.Text = dt_RQ.Rows[0]["R_person"].ToString();
                //Branch.ID.Text = dt_RQ.Rows[0]["Acc_no"].ToString();
                Request_Year.Text= dt_RQ.Rows[0]["cyear"].ToString();
                delivry_Grid1.txtCo_Code.Text = Branch.ID.Text.Substring(0, 1);
                int i = 0;
                delivry_Grid1.flowLayoutPanel1.Controls.Clear();

                foreach (DataRow r in dt_RQ.Rows)
                {

                    MyControls.Delivry_Row row = new MyControls.Delivry_Row();
                    row.txt_Code.Text = dt_RQ.Rows[i]["ITEM_NO"].ToString();


                    if (Properties.Settings.Default.lungh == "0")
                    {
                        row.TxtDesc.Text = dt_RQ.Rows[i]["Descr"].ToString();
                    }
                    else
                    {
                        row.TxtDesc.Text = dt_RQ.Rows[i]["Descr_eng"].ToString();
                    }
                    row.txtNote.Text = dt_RQ.Rows[i]["Item_Description"].ToString();
                    row.txtUnit.Text = dt_RQ.Rows[i]["R_unit"].ToString();
                    row.Weight_.Text = dt_RQ.Rows[i]["R_Weight"].ToString().ToDecimal().ToString("N3");
                    row.qty.Text = dt_RQ.Rows[i]["R_balance"].ToString().ToDecimal().ToString("N0");
                    //row.totWeight.Text = dt_RQ.Rows[i]["R_totalWeight"].ToString().ToDecimal().ToString("N1");
                    //row.txtBalance.Text = dt_RQ.Rows[i]["R_balance"].ToString().ToDecimal().ToString("N3");

                    row.Co_code = delivry_Grid1.txtCo_Code.Text;
                    row.get_cost_balance(dt_RQ.Rows[i]["ITEM_NO"].ToString(), BranchCode_);
                    //row.Width = delivry_Grid1.flowLayoutPanel1.Width;
                    delivry_Grid1.flowLayoutPanel1.Controls.Add(row);
                    

                    row.KeyDown += delivry_Grid1.r_KeyDown;
                    row.KeyUp += delivry_Grid1.r_KeyUP;
                    row.Enter += delivry_Grid1.r_Enter;
                    row.Click += delivry_Grid1.r_Click;

                    i = i + 1;
                }

                delivry_Grid1.total_inv();



            }
            else
            {
                MessageBox.Show("تاكد من الرقم", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            PL.frmSerch frm = new PL.frmSerch();
            frm.lblHead.Text = "Enter Sanad No.";
            frm.ShowDialog();
            if (frm.Close_Type == 1)
            {

                DataTable dt_RQ = dal.getDataTabl_1(@" select A.Ser_no, A.Sanad_no,A.Branch_code,A.Transaction_code, A.Cyear ,A.G_date,A.Sales_man_Id,A.user_id,A.Second_Payment_User
                        ,A.Inv_Notes,A.Acc_no,A.Other_branch_code,B.ITEM_NO,B.G_ITEM_NO,B.Unit,B.QTY_ADD,B.QTY_TAKE,B.Local_Price,B.balance
						,M.descr
                        ,M.Descr_eng,M.Weight
						,Br.branch_name as Acc_Name,Br.WH_E_NAME as Acc_Name_E
                        ,B2.branch_name,B2.WH_E_NAME
                        FROM wh_inv_data As A
                        inner join wh_material_transaction As B
                        on a.Branch_code = b.Branch_code and a.Transaction_code = b.TRANSACTION_CODE and a.Cyear = b.Cyear and a.Ser_no = b.SER_NO
                        inner join  wh_main_master as M on M.item_no = B.ITEM_NO
                        inner join  wh_BRANCHES as Br on Br.Branch_code = a.Branch_code
                        left join wh_BRANCHES as B2 on B2.Branch_code = A.Other_branch_code
                        where A.ser_no = '" + frm.txtSearch.t.Text + "' and a.Transaction_code = 'opo' and A.Branch_code = '"+BranchCode_+"' and A.Cyear = '21'");

                if (dt_RQ.Rows.Count > 0)
                {


                    txt_serNo.Text = dt_RQ.Rows[0]["Ser_no"].ToString();
                    Branch.ID.Text = dt_RQ.Rows[0]["Branch_code"].ToString();
                    txt_InvDate.Text = dt_RQ.Rows[0]["G_date"].ToString();
                    Cost_Center.ID.Text = dt_RQ.Rows[0]["Sales_man_Id"].ToString();
                    txt_MainNote.Text = dt_RQ.Rows[0]["Inv_Notes"].ToString();
                    txtStoreMan.ID.Text = dt_RQ.Rows[0]["Second_Payment_User"].ToString();
                    requset_Branch.ID.Text = dt_RQ.Rows[0]["Other_branch_code"].ToString();
                    requset_Ser.Text = dt_RQ.Rows[0]["Sanad_no"].ToString();
                    delivry_Grid1.txtCo_Code.Text = Branch.ID.Text.Substring(0, 1);
                    int i = 0;
                    delivry_Grid1.flowLayoutPanel1.Controls.Clear();

                    foreach (DataRow r in dt_RQ.Rows)
                    {

                        MyControls.Delivry_Row row = new MyControls.Delivry_Row();
                        row.txt_Code.Text = dt_RQ.Rows[i]["ITEM_NO"].ToString();
                        if (Properties.Settings.Default.lungh == "0")
                        {
                            row.TxtDesc.Text = dt_RQ.Rows[i]["Descr"].ToString();
                        }
                        else
                        {
                            row.TxtDesc.Text = dt_RQ.Rows[i]["Descr_eng"].ToString();
                        }
                        row.txtNote.Text = dt_RQ.Rows[i]["G_ITEM_NO"].ToString();
                        row.txtUnit.Text = dt_RQ.Rows[i]["Unit"].ToString();
                        row.Weight_.Text = dt_RQ.Rows[i]["Weight"].ToString().ToDecimal().ToString("N3");
                        row.qty.Text = dt_RQ.Rows[i]["QTY_TAKE"].ToString().ToDecimal().ToString("N0");
                        row.txtCost.Text = dt_RQ.Rows[i]["Local_Price"].ToString().ToDecimal().ToString("N"+dal.digits_);
                        row.totWeight.Text = (dt_RQ.Rows[i]["QTY_TAKE"].ToString().ToDecimal()* dt_RQ.Rows[i]["Weight"].ToString().ToDecimal()).ToString("N3");
                        row.txtBalance.Text = dt_RQ.Rows[i]["balance"].ToString().ToDecimal().ToString("N1");

                        row.Co_code = delivry_Grid1.txtCo_Code.Text;

                        delivry_Grid1.flowLayoutPanel1.Controls.Add(row);

                        row.KeyDown += delivry_Grid1.r_KeyDown;
                        row.KeyUp += delivry_Grid1.r_KeyUP;
                        row.Enter += delivry_Grid1.r_Enter;
                        row.Click += delivry_Grid1.r_Click;

                        i = i + 1;
                    }

                    delivry_Grid1.total_inv();


                }
                else
                {
                    MessageBox.Show("تاكد من الرقم", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

        }
    }
}
