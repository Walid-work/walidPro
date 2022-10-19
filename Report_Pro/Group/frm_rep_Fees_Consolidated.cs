// Decompiled with JetBrains decompiler
// Type: Report_Pro.RPT.frm_rep_Fees
// Assembly: Report_Pro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 39327453-3C78-42DC-8027-AE7037A66322
// Assembly location: C:\Users\Walid\Desktop\Report_Pro.exe

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using DevExpress.XtraReports.UI;
using Report_Pro.DAL;
using Report_Pro.MyControls;
using Report_Pro.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
using System.Windows.Forms;

namespace Report_Pro.Group
{
  public partial class frm_rep_Fees_Consolidated : Form
  {
    private DataAccesslayer1 dal = new DataAccesslayer1();


        public frm_rep_Fees_Consolidated()
        { 
            InitializeComponent();
        }

    private void groupPanel2_Click(object sender, EventArgs e)
    {
    }

    private void btnReport_1_Click(object sender, EventArgs e)
    {
      this.groupPanel2.Visible = false;
      RPT.DataSet1 dataSet1 = new RPT.DataSet1();
      DataTable dataTable = new DataTable();
            DataTable dataTabl1 = this.dal.getDataTabl_1(@"select C.Gr_Code,C.Gr_name
          , SUM(CASE WHEN  A.Company='01'   and A.acc_no like '34%'                             THEN  (meno-loh)* isnull(E.Average_Rate,1) else 0 END) as T_Indust
          , SUM(CASE WHEN  A.Company = '01' and (A.acc_no like '32%'   or A.acc_no like '33%')  THEN  (meno-loh)* isnull(E.Average_Rate,1) else 0 END) as T_GA
          , SUM(CASE WHEN  A.Company='02'   and (A.acc_no like '32%'   or A.acc_no like '33%')  THEN  (meno-loh)* isnull(E.Average_Rate,1) else 0 END) as Q_GA_SAR
          , SUM(CASE WHEN  A.Company='03'   and (A.acc_no like '32%'   or A.acc_no like '33%')  THEN  (meno-loh)* isnull(E.Average_Rate,1) else 0 END) as K_GA_SAR
          , SUM(CASE WHEN  A.Company='04'   and (A.acc_no like '32%'   or A.acc_no like '33%')  THEN  (meno-loh)* isnull(E.Average_Rate,1) else 0 END) as B_GA_SAR
          , SUM(CASE WHEN  A.Company='07'   and (A.acc_no like '32%'   or A.acc_no like '33%')  THEN  (meno-loh)* isnull(E.Average_Rate,1) else 0 END) as O_GA_SAR
          , SUM(CASE WHEN  A.Company='05'   and (A.acc_no like '34%'   or A.acc_no like '33%')  THEN  (meno-loh)* isnull(E.Average_Rate,1) else 0 END) as Trans_SAR 
          , SUM(CASE WHEN  A.Company='06'   and (A.acc_no like '31%'   or A.acc_no like '33%')  THEN  (meno-loh)* isnull(E.Average_Rate,1) else 0 END) as F_GA 
          , SUM(CASE WHEN  A.Company='06'   and A.acc_no like '32%'                             THEN  (meno-loh)* isnull(E.Average_Rate,1) else 0 END) as F_Indust 
          , c.Prev_no,d.Gr_name 
          from GroupDB.dbo.daily_transaction  as A
          inner join GroupDB.dbo.payer2 as b  on A.ACC_NO=B.ACC_NO and A.BRANCH_code = b.BRANCH_code 
          inner join GroupDB.dbo.Wh_Costmers_Vendors_Group as C on b.Temp1 =C.Gr_Code 
          inner join GroupDB.dbo.Wh_Costmers_Vendors_Group as D on C.Prev_no =D.Gr_Code 
          inner join GroupDB.dbo.Currency_rate as E on E.Currency_Code = A.Currency_Code and  E.Currency_Year = '" + toDate.Value.ToString("yy") +

          "'where B.Temp1 like '" + Acc_Group.ID.Text + "%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + 
          "' and A.BRANCH_code like '%'  group by  C.Gr_Code,C.Gr_name,c.Prev_no,d.Gr_name");
      dataSet1.Tables.Add(dataTabl1);
      //dataSet1.WriteXmlSchema("schema1.xml");
      Reports.rpt_Fees_Consolidated rpt = new Reports.rpt_Fees_Consolidated();
            rpt.DataSource = dataSet1;
            rpt.ShowPreview();
            rpt.lbl_Branch.Text = txtBranch.Desc.Text;
            rpt.lbl_Group.Text = Acc_Group.Desc.Text;
            rpt.lbl_FromDate.Text = fromDate.Value.ToShortDateString();
            rpt.lbl_ToDate.Text = toDate.Value.ToShortDateString();

        }

        private void btnOption_Click(object sender, EventArgs e) { this.groupPanel2.Visible = true; }

    private void btnReport_2_Click(object sender, EventArgs e)
    {
                this.groupPanel2.Visible = false;
            RPT.DataSet1 dataSet1 = new RPT.DataSet1();
                DataTable dt_1 = new DataTable();
                DataTable dt_2 = new DataTable();
                dt_1 = dal.getDataTabl_1(@"select  c.Prev_no,d.Gr_name 
          , SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.Company='Trading' and A.acc_no like '34%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  meno-loh else 0 END) as T_Indust " +
              ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.Company = 'Trading' and A.acc_no like '32%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  meno - loh else 0 END) as T_GA " +
              ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.Company = 'Trading' and A.acc_no like '33%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  meno - loh else 0 END) as T_F " +
              ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.Company='Qatar' and (A.acc_no like '32%' or A.acc_no like '33%') and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (meno-loh)*e.Average_Rate else 0 END) as Q_GA_SAR " +
              ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.Company='Kuwait' and (A.acc_no like '32%' or A.acc_no like '33%') and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (meno-loh)*e.Average_Rate else 0 END) as K_GA_SAR " +
              ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.Company='Bahrain' and (A.acc_no like '32%' or A.acc_no like '33%') and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (meno-loh)*e.Average_Rate else 0 END) as B_GA_SAR " +
              ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.Company='Oman' and (A.acc_no like '32%' or A.acc_no like '33%') and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (meno-loh)*e.Average_Rate else 0 END) as O_GA_SAR " +
              ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.Company='Transportation' and (A.acc_no like '34%' or A.acc_no like '33%') and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (meno-loh)*e.Average_Rate else 0 END) as Trans_SAR " +
              ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.Company='factory' and (A.acc_no like '31%' or A.acc_no like '33%') and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (meno-loh)*e.Average_Rate else 0 END) as F_GA " +
              ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.Company='factory' and A.acc_no like '32%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (meno-loh)*e.Average_Rate else 0 END) as F_Indust " +





              " from GroupDB.dbo.daily_transaction  as A " +
              "inner join GroupDB.dbo.payer2 as b  on A.ACC_NO=B.ACC_NO and A.BRANCH_code = b.BRANCH_code " +
              "inner join GroupDB.dbo.Wh_Costmers_Vendors_Group as C on b.Temp1 =C.Gr_Code " +
              "inner join GroupDB.dbo.Wh_Costmers_Vendors_Group as D on C.Prev_no =D.Gr_Code " +
              "inner join GroupDB.dbo.Currency_tbl as E on e.Currency_Code = a.Currency_Code " +
              "where A.BRANCH_code like '%'  group by  c.Prev_no,d.Gr_name");


                dt_2 = dal.getDataTabl_1(@"select 
               SUM(CASE WHEN  A.Company = 'Trading' and A.acc_no like '4%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (loh - meno) else 0 END) as T_R " +
              ", SUM(CASE WHEN  A.Company='Qatar' and A.acc_no like '4%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (loh - meno)*e.Average_Rate else 0 END) as Q_R " +
              ", SUM(CASE WHEN  A.Company='Kuwait' and A.acc_no like '4%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (loh - meno)*e.Average_Rate else 0 END) as K_R " +
              ", SUM(CASE WHEN  A.Company='Bahrain' and A.acc_no like '4%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (loh - meno)*e.Average_Rate else 0 END) as B_R " +
              ", SUM(CASE WHEN  A.Company='Oman' and A.acc_no like '4%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (loh - meno)*e.Average_Rate else 0 END) as O_R " +
              ", SUM(CASE WHEN  A.Company='Transportation' and A.acc_no like '4%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (loh - meno)*e.Average_Rate else 0 END) as Trans_R " +
              ", SUM(CASE WHEN  A.Company='factory' and A.acc_no like '4%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  (loh - meno)*e.Average_Rate else 0 END) as F_R " +
              ", SUM(CASE WHEN A.Company = 'Trading' and A.ACC_NO like '123998%' and SOURCE_CODE like 'xs%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  meno - loh else 0 END) as T_S_R " +
              ", SUM(CASE WHEN A.Company = 'factory' and A.ACC_NO = '120200001' and SOURCE_CODE like 'xs%' and CAST(A.g_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  meno - loh else 0 END) as F_S_R " +



              " from GroupDB.dbo.daily_transaction  as A " +
              "inner join GroupDB.dbo.Currency_tbl as E on e.Currency_Code = a.Currency_Code " +
              "where A.BRANCH_code like '%' ");


                dataSet1.Tables.Add(dt_1);
                dataSet1.Tables.Add(dt_2);
                dataSet1.WriteXmlSchema("schema1.xml");
            RPT.rpt_Fees_Consolidated rpt = new RPT.rpt_Fees_Consolidated();
            rpt.SetDataSource(dataSet1);
            crystalReportViewer1.ReportSource = rpt;
                //Reports.rpt_Fees_Consolidated rpt = new Reports.rpt_Fees_Consolidated();
                //rpt.DataSource = dataSet1;
                //rpt.ShowPreview();

                //if (Properties.Settings.Default.lungh == "0")
                //{
                //    rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
                //    rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
                //    rpt.pram1.Value = 0;
                //}
                //else
                //{
                //    rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
                //    rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;
                //    rpt.pram1.Value = 1;
                //}

                //rpt.lbl_Branch.Text = txtBranch.Desc.Text;
                //rpt.lbl_Group.Text = Acc_Group.Desc.Text;
                //rpt.lbl_FromDate.Text = fromDate.Value.ToShortDateString();
                //rpt.lbl_ToDate.Text = toDate.Value.ToShortDateString();

            }


            private void labelX5_Click(object sender, EventArgs e)
    {

    }

    private void frm_rep_Fees_Load(object sender, EventArgs e)
    {
        Acc_Group.txtFinal.Text = "0";

          fromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            toDate.Value = DateTime.Today;
        }

       }
}
