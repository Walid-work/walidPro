using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.Group
{
    public partial class frmAgeReport_Group : frm_ReportMaster
    {

        string btn_name;
        string M_than="0";
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        



        public frmAgeReport_Group()
        {
            InitializeComponent();
            
           

        }

        public override void Report()
        {
            this.Cursor = Cursors.WaitCursor;

            if (rAll.Checked == true)
            { M_than = "0"; }
            else if (rM_30.Checked == true)
            { M_than = "30"; }
            else if (rM_60.Checked == true)
            { M_than = "60"; }
            else if (rM_90.Checked == true)
            { M_than = "90"; }
            else if (rM_120.Checked == true)
            { M_than = "120"; }
            else if (rM_150.Checked == true)
            { M_than = "150"; }
            else if (rM_180.Checked == true)
            { M_than = "180"; }


            RPT.AgeReport rpt = new RPT.AgeReport();

            DataTable dt_age = dal.getDataTabl_1(@"use GroupDB select a.acc_no,b.PAYER_NAME,a.BRANCH_code,c.BRANCH_name
		,SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN (meno - loh) *isnull(R.End_Rate,1) ELSE 0 END) AS Ending_balance " +
        ", SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')>=0  and DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')<=30  THEN meno *isnull(R.End_Rate,1)  ELSE 0 END) AS '1-30' " +
        ",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')>=31  and DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')<=60  THEN meno *isnull(R.End_Rate,1)  ELSE 0 END) AS '31-60' " +
        ",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')>=61  and DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')<=90  THEN meno *isnull(R.End_Rate,1)  ELSE 0 END) AS '61-90' " +
        ",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')>=91  and DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')<=120 THEN meno *isnull(R.End_Rate,1)  ELSE 0 END) AS '91-120' " +
        ",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')>=121 and DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')<=150 THEN meno *isnull(R.End_Rate,1)  ELSE 0 END) AS '121-250' " +
        ",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')>=151 and DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')<=180 THEN meno *isnull(R.End_Rate,1)  ELSE 0 END) AS '151-180' " +
        ",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd") + "')>=181  THEN meno *isnull(R.End_Rate,1)    ELSE 0 END) AS more180    " +
        "from daily_transaction as A  " +
        "inner join payer2 as B on A.ACC_NO=b.ACC_NO and a.BRANCH_code=b.BRANCH_code " +
        "inner join BRANCHS as C on A.BRANCH_code=c.BRANCH_code " +
        " left Join  Currency_rate as R on R.Currency_Code = A.Currency_Code  and  R.Currency_Year = '" + ToDate.Value.ToString("yy") + "'  " +
      "where A.ACC_NO like '" + Uc_Acc.ID.Text +
      "%' and ISNULL(A.COST_CENTER,'') like '" + Uc_Cost.ID.Text +
      "%'  and a.BRANCH_code like '" + Uc_Branch.ID.Text +
      "%'  and ISNULL(A.CAT_CODE,'') like '" + Uc_Catogry.ID.Text +
      "%'group by a.ACC_NO,b.PAYER_NAME,a.BRANCH_code,c.BRANCH_name");

            rpt.SetDataSource(dt_age);
            // rpt.SetDataSource(dal.getDataTabl("AgeReport_",FromDate.Value.Date,ToDate.Value.Date,Uc_Acc.ID.Text,Uc_Cost.ID.Text,Uc_Catogry.ID.Text,Uc_Branch.ID.Text,dal.db1));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["M_"].Text = "'" + M_than + "'";
            rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            rpt.DataDefinition.FormulaFields["Date_"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = " '" + Uc_Acc.Desc.Text + "'";
            groupPanel1.Visible = false;
            this.Cursor = Cursors.Default;

            base.Report();
        }


        public override void Option()
        {
            groupPanel1.Visible = true;
            base.Option();
        }


        private void Report_btn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (rAll.Checked == true)
            { M_than = "0"; }
            else if (rM_30.Checked == true)
            { M_than = "30"; }
            else if (rM_60.Checked == true)
            { M_than = "60"; }
            else if (rM_90.Checked == true)
            { M_than = "90"; }
            else if (rM_120.Checked == true)
            { M_than = "120"; }
            else if (rM_150.Checked == true)
            { M_than = "150"; }
            else if (rM_180.Checked == true)
            { M_than = "180"; }


            RPT.AgeReport rpt = new RPT.AgeReport();

            DataTable dt_age = dal.getDataTabl_1(@"use main_acc_wh select a.acc_no,b.PAYER_NAME,a.BRANCH_code,c.BRANCH_name
		,SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance " +
        ", SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd")+"')>=0 and DATEDIFF(Day,CAST(g_date as date ),'"+ ToDate.Value.ToString("yyyy-MM-dd")+"')<=30  THEN meno    ELSE 0 END) AS '1-30' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ ToDate.Value.ToString("yyyy-MM-dd")+"')>=31 and DATEDIFF(Day,CAST(g_date as date ),'"+ ToDate.Value.ToString("yyyy-MM-dd")+ "')<=60  THEN meno    ELSE 0 END) AS '31-60' " +
        ",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd")+"')>=61 and DATEDIFF(Day,CAST(g_date as date ),'"+ ToDate.Value.ToString("yyyy-MM-dd")+ "')<=90  THEN meno    ELSE 0 END) AS '61-90' " +
        ",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd")+"')>=91 and DATEDIFF(Day,CAST(g_date as date ),'"+ ToDate.Value.ToString("yyyy-MM-dd")+ "')<=120  THEN meno    ELSE 0 END) AS '91-120' " +
        ",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd")+"')>=121 and DATEDIFF(Day,CAST(g_date as date ),'"+ ToDate.Value.ToString("yyyy-MM-dd")+ "')<=150  THEN meno    ELSE 0 END) AS '121-250' " +
        ",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd")+"')>=151 and DATEDIFF(Day,CAST(g_date as date ),'"+ ToDate.Value.ToString("yyyy-MM-dd")+ "')<=180  THEN meno    ELSE 0 END) AS '151-180' " +
        ",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'" + ToDate.Value.ToString("yyyy-MM-dd")+"')>=181  THEN meno    ELSE 0 END) AS more180    " +
  "from daily_transaction as A  " +
      "inner join payer2 as B on A.ACC_NO=b.ACC_NO and a.BRANCH_code=b.BRANCH_code " +
      "inner join BRANCHS as C on A.BRANCH_code=c.BRANCH_code " +
      "where A.ACC_NO like '"+Uc_Acc.ID.Text+
      "%' and ISNULL(A.COST_CENTER,'') like '"+Uc_Cost.ID.Text+
      "%'  and a.BRANCH_code like '"+Uc_Branch.ID.Text+
      "%'  and ISNULL(A.CAT_CODE,'') like '"+Uc_Catogry.ID.Text+
      "%'group by a.ACC_NO,b.PAYER_NAME,a.BRANCH_code,c.BRANCH_name");

            rpt.SetDataSource (dt_age);
           // rpt.SetDataSource(dal.getDataTabl("AgeReport_",FromDate.Value.Date,ToDate.Value.Date,Uc_Acc.ID.Text,Uc_Cost.ID.Text,Uc_Catogry.ID.Text,Uc_Branch.ID.Text,dal.db1));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["M_"].Text = "'"+M_than+"'";
            rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            rpt.DataDefinition.FormulaFields["Date_"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = " '" + Uc_Acc.Desc.Text + "'";
            groupPanel1.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }


       
       

        private void Branch_name_MultilineChanged(object sender, EventArgs e)
        {
           
        }

        

       

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }



     
      

      


      

        private void frm_statment_Rpt_Load(object sender, EventArgs e)
        {
            FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            ToDate.Value = DateTime.Today;
        }

      
        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgeReport_Load(object sender, EventArgs e)
        {

        }

        private void buttonX5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (rAll.Checked == true)
            { M_than = "0"; }
            else if (rM_30.Checked == true)
            { M_than = "30"; }
            else if (rM_60.Checked == true)
            { M_than = "60"; }
            else if (rM_90.Checked == true)
            { M_than = "90"; }
            else if (rM_120.Checked == true)
            { M_than = "120"; }
            else if (rM_150.Checked == true)
            { M_than = "150"; }
            else if (rM_180.Checked == true)
            { M_than = "180"; }


            RPT.Supp_AgeReport rpt = new RPT.Supp_AgeReport();
            rpt.SetDataSource(dal.getDataTabl_1(@"select A.*,p.PAYER_NAME from ( select acc_no
		,SUM(CASE WHEN cast(g_date as date) <= '"+ToDate.Value.ToString("yyyy/MM/dd")+"' THEN loh - meno ELSE 0 END) AS Ending_balance "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=0 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=30  THEN loh    ELSE 0 END) AS '1-30' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=31 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=60  THEN loh    ELSE 0 END) AS '31-60' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=61 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=90  THEN loh    ELSE 0 END) AS '61-90' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=91 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=120  THEN loh    ELSE 0 END) AS '91-120' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=121 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=150  THEN loh    ELSE 0 END) AS '121-250' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=151 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=180  THEN loh    ELSE 0 END) AS '151-180' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=181  THEN loh    ELSE 0 END) AS more180 "+
	    " from daily_transaction  where ACC_NO like '"+Uc_Acc.ID.Text+"%'	 group by ACC_NO  ) as A  "+
	    "inner join ( select * from ( select   acc_no ,PAYER_NAME "+
        ",ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount "+
        "from payer2 ) as B where b.DuplicateCount =1) as P on P.ACC_NO =a.ACC_NO order by A.ACC_NO"));
            //, FromDate.Value.Date, ToDate.Value.Date, Uc_Acc.ID.Text, Uc_Cost.ID.Text, Uc_Catogry.ID.Text, Uc_Branch.ID.Text, dal.db1));



            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["M_"].Text = "'" + M_than + "'";
            rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            rpt.DataDefinition.FormulaFields["Date_"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = " '" + Uc_Acc.Desc.Text + "'";
            groupPanel1.Visible = false;
            this.Cursor = Cursors.Default;


        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void Uc_Catogry_Load(object sender, EventArgs e)
        {

        }

        private void Uc_Acc_Click(object sender, EventArgs e)
        {
            Uc_Acc.x = Uc_Acc.Location.X+Uc_Acc.Width;
            Uc_Acc.y = Uc_Acc.Location.Y+100;
            //PL.frm_SearchAcc frm = new PL.frm_SearchAcc();
            //frm.ShowDialog();
            //if (Properties.Settings.Default.lungh == "0")
            //{
            //    frm.x_ = Uc_Acc.x;// Uc_Acc.x - frm.Width;
            //    frm.y_ = Uc_Acc.y;
            //}
            //else
            //{
            //    frm.x_ = Uc_Acc.x;
            //    frm.y_ = Uc_Acc.y;
            //    //  frm.Location = new Point(x, y);
            //}

            
            //frm.BringToFront();

            //Uc_Acc.ID.Text = frm.DGV1.CurrentRow.Cells[0].Value.ToString();

            //Uc_Acc.ID.Focus();
        }

        private void Uc_Branch_Load(object sender, EventArgs e)
        {
            Uc_Acc.branchID.Text = Uc_Branch.ID.Text;
        }
    }
       
}
