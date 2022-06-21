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
    public partial class frm_Internal_RM : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();
        Int32 m;

        public string clos_type;
        string btntype = "0";
        string frmType="ADD";

        public frm_Internal_RM()
        {
            InitializeComponent();
           
                      

            
        }

        private void tabControlPanel2_Click(object sender, EventArgs e)
        {

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
                DataTable dt_br = dal.getDataTabl("Get_branch_Name_", Uc_Branch.ID.Text, dal.db1);

                if (dt_br.Rows.Count > 0)
                {
                  
                    txt_MainNote.Text = dt_br.Rows[0][28].ToString();
                    uC_cost1.txtBranch.Text = Uc_Branch.txtAccBranch.Text;
                    getJorSer();
                }
            }
        }

        private void getJorSer()
        {
            DataTable serDb = dal.getDataTabl_1("select isnull(MR+1,1) FROM wh_Serial where Branch_code='" + Uc_Branch.ID.Text + "' and Cyear='" + txt_InvDate.Value.ToString("yy") + "' ");
            if (serDb.Rows.Count > 0)
            {
                txt_serNo.Text = serDb.Rows[0][0].ToString();
            }
            else
            {
                txt_serNo.Clear();

            }


        }

        private void BNew_Click(object sender, EventArgs e)
        {
            clear_texts();
            getJorSer();
            Uc_Branch.ID.Text = Properties.Settings.Default.BranchId;
            //BSave.Enabled = true;
           
        }

      

        private void BSave_Click(object sender, EventArgs e)
        {
            Assembly a = Assembly.Load("Report_Pro");
            ResourceManager rm = new ResourceManager("Report_Pro.RPT.login_frm", a);
       
            if (Uc_Branch.ID.Text == string.Empty)
            {
                MessageBox.Show(rm.GetString("txtMes"), rm.GetString("MesH"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (delivry_Grid1.flowLayoutPanel1.Controls.Count<1)
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
                    cmd.CommandText = @"INSERT INTO R_Qutation(Ser_no,Branch_code ,Transaction_code ,Cyear,G_date,Cost_center,user_id,R_person,Acc_no)
                    VALUES('" + txt_serNo.Text+"','"+Uc_Branch.ID.Text+"','"+txt_transaction_code.Text+"','" + txt_InvDate.Value.ToString("yy") + "','" + 
                    txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss")+"','"+uC_cost1.ID.Text+"','"+userID.Text+"','"+txtRequst_p.ID.Text+"','"+ Supply_Branch.ID.Text +"')";

                    cmd.ExecuteNonQuery();

                foreach (MyControls.Delivry_Row r in delivry_Grid1.flowLayoutPanel1.Controls)
                {
                    if (r.txt_Code.Text.Trim() != string.Empty && r.qty.Value > 0)
                    {
                        cmd.CommandText = @" INSERT INTO R_Qutation_Transaction (SER_NO,Branch_code,TRANSACTION_CODE,Cyear,G_DATE
                    ,ITEM_NO,Item_Description,R_unit,R_Weight,R_Qty,R_balance,R_totalWeight,main_counter,R_cost)
                    VALUES('" + txt_serNo.Text + "','" + Uc_Branch.ID.Text + "','" + txt_transaction_code.Text + "','" +
                        txt_InvDate.Value.ToString("yy") + "','" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + r.txt_Code.Text + "','" +
                        r.txtNote.Text + "','" + r.txtUnit.Text + "','" + r.Weight_.Text + "','" + r.qty.Text + "','" + r.txtBalance.Text + "','" + r.totWeight.Text + "',('"+ r.Ser.Value +"')-1),'"+r.txtCost.Value+"'";

                        cmd.ExecuteNonQuery();
                    }
                }


                cmd.CommandText = @"Update wh_Serial set MR ='" + txt_serNo.Text + "'  where Branch_code='" + Uc_Branch.ID.Text
                   + "' and Cyear= '" + txt_InvDate.Value.ToString("yy") + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحفظ بنجاح", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                trans.Commit();

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



        private void BSearch_Click(object sender, EventArgs e)
        {

           
          
        }

        
     

        private void Uc_Branch_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt_br = dal.getDataTabl("Get_branch_Name_", Uc_Branch.ID.Text, dal.db1);

            if (dt_br.Rows.Count > 0)
            {
               
                getJorSer();
            }
        }

        

      
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            RPT.Form1 frm = new RPT.Form1();

            RPT.rpt_R_Matrails rpt = new RPT.rpt_R_Matrails();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT A.*,b.*,m.descr,m.Descr_eng,m.Weight,m.Unit,Br.branch_name,Br.WH_E_NAME,
            p.branch_name as PAYER_NAME,P.WH_E_NAME as payer_l_name,C1.COST_name,C1.COST_E_NAME,C2.COST_name as RP,C2.COST_E_NAME as RP_E 
			FROM R_Qutation As A 
            inner join R_Qutation_Transaction As B 
             on a.Branch_code = b.Branch_code and a.Transaction_code = b.TRANSACTION_CODE and a.Cyear = b.Cyear and a.Ser_no = b.SER_NO 
            inner join wh_main_master as M on m.item_no = b.ITEM_NO 
            inner join wh_BRANCHES as Br on Br.Branch_code = a.Branch_code 
            inner join wh_BRANCHES as P on P.Branch_code = a.acc_no 
			left join COST_CENTER as C1 on C1.COST_CODE=A.Cost_center
			inner join COST_CENTER as C2 on C2.COST_CODE=A.R_person
            where A.ser_no = '" + txt_serNo.Text + "' and a.Transaction_code = '" + txt_transaction_code.Text + "' and A.Branch_code='" + Uc_Branch.ID.Text + "'");
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
            p.PAYER_NAME,p.payer_l_name FROM "+dal.db1+".dbo.R_Qutation As A " +
            "inner join  "+dal.db1+".dbo.R_Qutation_Transaction As B" +
            " on a.Branch_code = b.Branch_code and a.Transaction_code = b.TRANSACTION_CODE and a.Cyear = b.Cyear and a.Ser_no = b.SER_NO " +
            "inner join  "+dal.db1+".dbo.wh_main_master as M on m.item_no = b.ITEM_NO " +
            "inner join  "+dal.db1+".dbo.wh_BRANCHES as Br on Br.Branch_code = a.Branch_code " +
            "inner join  "+dal.db1+".dbo.payer2 as P on P.acc_no = a.acc_no and p.branch_code = a.branch_code " +
            "where A.ser_no = '"+txt_serNo.Text+ "' and a.Transaction_code = '"+txt_transaction_code.Text+"'");
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
          

            Uc_Branch.ID.Text = Properties.Settings.Default.BranchId;

            uC_cost1.txtMain.Text = "4";
            uC_cost1.txt_Tfinl.Text = "1";

            txtRequst_p.txtMain.Text = "3";
            txtRequst_p.txt_Tfinl.Text = "1";
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
            if (Supply_Branch.ID.Text.Trim() != string.Empty)
            {
                delivry_Grid1.txtCo_Code.Text = Supply_Branch.ID.Text.Substring(0, 1);
            }
            else { delivry_Grid1.txtCo_Code.Clear();
            }
        }

        private void labelX10_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            PL.frmSerch frm = new PL.frmSerch();
            frm.lblHead.Text = "Enter Request No.";
            frm.ShowDialog();
            if (frm.Close_Type == 1)
            {
                frmType = "EDIT";

                DataTable dt_RQ = dal.getDataTabl_1(@"select A.Ser_no,A.Branch_code,A.Transaction_code, A.Cyear ,A.G_date,A.Cost_center,A.user_id,A.R_person
                        ,A.C_Notes,A.Acc_no,B.ITEM_NO,B.Item_Description,B.R_unit,B.R_Weight,B.R_Qty,b.R_balance,B.R_totalWeight ,B.R_cost,m.descr
                        ,m.Descr_eng,m.Weight,m.Unit,Br.branch_name as Acc_Name,Br.WH_E_NAME as Acc_Name_E
                        ,B2.branch_name,B2.WH_E_NAME FROM R_Qutation As A 
                        inner join R_Qutation_Transaction As B
                        on a.Branch_code = b.Branch_code and a.Transaction_code = b.TRANSACTION_CODE and a.Cyear = b.Cyear and a.Ser_no = b.SER_NO
                        inner join  wh_main_master as M on m.item_no = b.ITEM_NO 
                        inner join  wh_BRANCHES as Br on Br.Branch_code = a.Branch_code 
                        inner join wh_BRANCHES as B2 on B2.Branch_code = a.Acc_no 
                        where A.ser_no = '" + frm.txtSearch.Text + "' and a.Transaction_code = '" + txt_transaction_code.Text + "' and A.Branch_code='" + Uc_Branch.ID.Text + "'");

                if (dt_RQ.Rows.Count > 0)
                {


                    txt_serNo.Text = dt_RQ.Rows[0]["Ser_no"].ToString();
                    Uc_Branch.ID.Text = dt_RQ.Rows[0]["Branch_code"].ToString();
                    txt_InvDate.Text = dt_RQ.Rows[0]["G_date"].ToString();
                    uC_cost1.ID.Text = dt_RQ.Rows[0]["Cost_center"].ToString();

                    txt_MainNote.Text = dt_RQ.Rows[0]["C_Notes"].ToString();
                    txtRequst_p.ID.Text = dt_RQ.Rows[0]["R_person"].ToString();
                    Supply_Branch.ID.Text = dt_RQ.Rows[0]["Acc_no"].ToString();
                    delivry_Grid1.txtCo_Code.Text = Supply_Branch.ID.Text.Substring(0, 1);

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
                        row.qty.Text = dt_RQ.Rows[i]["R_Qty"].ToString().ToDecimal().ToString("N0");
                        row.totWeight.Text = dt_RQ.Rows[i]["R_totalWeight"].ToString().ToDecimal().ToString("N1");
                        row.txtBalance.Text = dt_RQ.Rows[i]["R_balance"].ToString().ToDecimal().ToString("N3");
                        row.Co_code = delivry_Grid1.txtCo_Code.Text;
                        row.txtCost.Text = dt_RQ.Rows[i]["R_cost"].ToString().ToDecimal().ToString("N3");
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

        private void txt_InvSM_Click(object sender, EventArgs e)
        {

        }
    }


}
