using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.Group
{
    public partial class frm_BS_TB_Group : Form
    {
        string db1 = Properties.Settings.Default.Database_1;
        string btn_name;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_BS_TB_Group()
        {
            InitializeComponent();


            FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            ToDate.Value = DateTime.Today;

            DataGridView1.DataSource = null;
            DataGridView1.Rows.Clear();

            
        }

        private void frm_TB_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            panel3.Visible = true;
            crystalReportViewer1.Visible = false;
           try
            {

                string lvl = "";
                if (RBtnAll.Checked == true)
                { lvl = ""; }
                else if (RBtn1.Checked == true)
                { lvl = "0"; }
                else if (RBtn2.Checked == true)
                { lvl = "1"; }
                else if (RBtn3.Checked == true)
                { lvl = "2"; }
                else if (RBtn4.Checked == true)
                { lvl = "3"; }

                string bal = "1";
                if (RB1.Checked == true)
                { bal = "1"; }
                else if (RB2.Checked == true)
                { bal = "2"; }
                else if (RB3.Checked == true)
                { bal = "3"; }

                else if (RB4.Checked == true)
                { bal = "4"; }

                string Acc_Kind="";
                if (RB_All_Acc.Checked == true)
                { Acc_Kind = ""; }
                else if (RB_M_Acc.Checked==true)
                { Acc_Kind = "0"; }
                else if (RB_S_Acc.Checked == true)
                { Acc_Kind = "1"; }

          


                DataTable Tb_dt = dal.getDataTabl("Get_TB_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc.ID.Text, UC_Branch.ID.Text, lvl, bal,Acc_Kind,Properties.Settings.Default.closeAcc,db1);

                int B_rowscount = Tb_dt.Rows.Count;
                DataGridView1.Rows.Clear();
                DataGridView1.Rows.Add(B_rowscount);
                for (int i = 0; (i
                           <= (B_rowscount - 1)); i++)
                {


                    DataGridView1.Rows[i].Cells[0].Value = Tb_dt.Rows[i][0];
                    DataGridView1.Rows[i].Cells[1].Value = Tb_dt.Rows[i][2];
                    DataGridView1.Rows[i].Cells[2].Value = Tb_dt.Rows[i][3];
                    DataGridView1.Rows[i].Cells[3].Value = Tb_dt.Rows[i][4];
                    DataGridView1.Rows[i].Cells[4].Value = Tb_dt.Rows[i][8];
                    DataGridView1.Rows[i].Cells[5].Value = Tb_dt.Rows[i][9];
                    DataGridView1.Rows[i].Cells[6].Value = Tb_dt.Rows[i][10];
                    DataGridView1.Rows[i].Cells[7].Value = Tb_dt.Rows[i][11];

                }
                
                total_TB();

            }

            catch
            {
            }
            Cursor.Current = Cursors.Default;
           
        }

        void total_TB()
        {
            T_Bb.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[4].FormattedValue).ToString().ToDecimal()).Sum().ToString();
            T_Db.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[5].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[5].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            T_Cr.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[6].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            T_Eb.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[7].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[7].FormattedValue).ToString().ToDecimal()).Sum().ToString();

        }

   
        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

       
        private void btnReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            panel3.Visible = false;
            crystalReportViewer1.Visible = true;
            string lvl = "";
            if (RBtnAll.Checked == true)
            { lvl = ""; }
            if (RBtn1.Checked == true)
            { lvl = "0"; }
            if (RBtn2.Checked == true)
            { lvl = "1"; }
            if (RBtn3.Checked == true)
            { lvl = "2"; }
            if (RBtn4.Checked == true)
            { lvl = "3"; }

            string bal = "1";
            if (RB1.Checked == true)
            { bal = "1"; }
            if (RB2.Checked == true)
            { bal = "2"; }
            if (RB3.Checked == true)
            { bal = "3"; }

            if (RB4.Checked == true)
            { bal = "4"; }

            string Acc_Kind = "";
            string t_final = "0";
            if (RB_All_Acc.Checked == true)
            {
                Acc_Kind = "";
                t_final = "0";
            }
            else if (RB_M_Acc.Checked == true)
            {
                Acc_Kind = "0";
                t_final = "0";
            }
            else if (RB_S_Acc.Checked == true)
            {
                Acc_Kind = "1";
                t_final = "1";
            }


            Group.rpt_BS_TB_Group tb_rep = new Group.rpt_BS_TB_Group();

            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

  //          dt1 = dal.getDataTabl_1(@"select  p.Company,Co.com_name,P.Acc_no,p.PREV_NO,p.PAYER_NAME,p.payer_l_name,p.t_level,p.t_final,p.MAIN_NO,p.MAIN_MEZAN,p.BRANCH_code ,p.PAYER_NAME_1,p.payer_l_name_1
		//,sum(B_balance) as B_balance,SUM(db) as db,sum(cr) as cr,sum(B_balance+db-cr) as E_balance 
		//from 
		
		//(SELECT  t1.Company,t1.Acc_no ,t1.PREV_NO ,t1.PAYER_NAME ,t1.payer_l_name   ,t1.t_level ,t1.t_final ,t1.MAIN_NO ,t1.MAIN_MEZAN ,t1.BRANCH_code ,
		//t1.Acc_stoped ,t1.Max_Sales_Am ,t1.Credit_AGE ,t1.BRANCH_name ,t1.BRANCH_E_NAME ,t1.med_MEZAN ,P1.PAYER_NAME as PAYER_NAME_1 ,P1.payer_l_name as payer_l_name_1 ,t1.MEZANIA_ACC_NO
		//from 
		//( select p.*,B.BRANCH_name ,B.BRANCH_E_NAME
		//,ROW_NUMBER() OVER(PARTITION BY p.Acc_no,P.company ORDER BY p.acc_no,P.company) AS DuplicateCount
		//FROM GroupDB.dbo.payer2 As P inner join GroupDB.dbo.BRANCHS As B on P.BRANCH_code=B.BRANCH_code 
		//where B.BRANCH_code like '%')  as t1 
		//inner join GroupDB.dbo.payer2 As P1 on t1.MAIN_NO=P1.ACC_NO and t1.BRANCH_code=P1.BRANCH_code 
		//where    DuplicateCount=1    and t1.Acc_no like '%'   and (t1.t_level like '%' or t1.t_level<'10')
		//and t1.t_final  like '%'   and isnull(t1.Acc_stoped,'') like '%'  ) as p 

		//inner join GroupDB.dbo.companies_tbl as Co on Co.com_code=P.Company

		//inner join (SELECT D.ACC_NO  ,D.Company
		//,case when D.ACC_NO='"+ Properties.Settings.Default.closeAcc+
  //      "' then SUM(CASE WHEN  cast(D.g_date as date) < '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and (D.acc_no like'1%' or D.acc_no like'2%') THEN  (D.meno-D.loh)*C.End_Rate else 0 END) "+ 
  //      "+ (select SUM((D.meno-D.loh)*C.End_Rate) from GroupDB.dbo.daily_transaction AS D inner join  GroupDB.dbo.Currency_rate as C ON C.Currency_Code = D.Currency_Code  where cast(D.g_date as date) < '"+FromDate.Value.ToString("yyyy/MM/dd")+"'  and (D.acc_no like'3%' or D.acc_no like'4%')) "+
  //      "else SUM(CASE WHEN  cast(D.g_date as date) < '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and (D.acc_no like'1%' or D.acc_no like'2%') THEN  (D.meno-D.loh)*C.End_Rate else 0 END) end  AS B_balance " +
         
		//",SUM(CASE WHEN  cast(D.g_date as date) >= '"+FromDate.Value.ToString("yyyy/MM/dd")+"' and cast(D.g_date as date) <= '"+ToDate.Value.ToString("yyyy/MM/dd")+"'   THEN D.meno*C.End_Rate ELSE 0 END) AS Db "+ 
		//",SUM(CASE WHEN  cast(D.g_date as date) >= '"+FromDate.Value.ToString("yyyy/MM/dd")+"' and cast(D.g_date as date) <= '"+ToDate.Value.ToString("yyyy/MM/dd")+"' THEN D.loh*C.End_Rate ELSE 0 END) AS Cr "+
		//"From GroupDB.dbo.daily_transaction as D " +
		//"inner join  GroupDB.dbo.Currency_rate as C ON C.Currency_Code = D.Currency_Code " +
		//"where  D.BRANCH_code like '%' and D.acc_no like '%' " +
  //"group by D.ACC_NO,D.Company)  as b 	ON b.ACC_NO like (CASE WHEN p.t_final =0  then  p.ACC_NO+'%' else  p.Acc_no end) and p.company =  b.Company " +
  //"where P.med_mezan like '1101%' " +
  //"group by  p.Company,Co.com_name,p.Acc_no,p.PREV_NO,p.PAYER_NAME,p.payer_l_name,p.t_level,p.t_final,p.MAIN_NO,p.MAIN_MEZAN,p.BRANCH_code ,p.PAYER_NAME_1,p.payer_l_name_1");

            dt1 = dal.getDataTabl("GetBSTb",FromDate.Value.ToString("yyyy-MM-dd"), ToDate.Value.ToString("yyyy-MM-dd"),UC_Branch.ID.Text,Uc_BS_Acc.ID.Text);
            dt2 = dal.getDataTabl_1(@"SELECT T.G_date,T.acc_Code,M.Gr_name,M.Gr_E_name,T.desription,T.debit,T.credir,C.com_name,C.com_name_e,R.Average_Rate 
                        FROM  GroupDB.dbo.tbl1 As T 
                        inner join GroupDB.dbo.MEZANIA_ARBAH_CHART As M on M.Gr_Code = T.acc_Code
                        inner join GroupDB.dbo.companies_tbl As C on T.combany_code = C.com_code 
                        inner join GroupDB.dbo.Currency_rate As R on T.Currency_Code=R.Currency_Code
                        where T.acc_Code='" + Uc_BS_Acc.ID.Text + "' and   cast(T.G_Date as date)  between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and R.Currency_Year= '" + ToDate.Value.ToString("yyyy") + "'");
            dt3 = dal.getDataTabl_1("select * FROM GroupDB.dbo.MEZANIA_ARBAH_CHART  ");
            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);
            ds.Tables.Add(dt3);
            //ds.WriteXmlSchema("schema_Bs_Tb.xml");
            tb_rep.SetDataSource(ds);

            crystalReportViewer1.ReportSource = tb_rep;
            tb_rep.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            tb_rep.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            tb_rep.DataDefinition.FormulaFields["t_final"].Text = "'" + t_final + "'";
            tb_rep.DataDefinition.FormulaFields["Head_text"].Text = "'" + Uc_BS_Acc.Desc.Text+ "'";

            Cursor.Current = Cursors.Default;
        }
    }
}
