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
using Report_Pro.DAL;
using Report_Pro.MyControls;
using Report_Pro.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
  public partial class frm_rep_Fees : Form
  {
    private DataAccesslayer1 dal = new DataAccesslayer1();


        public frm_rep_Fees()
        { 
            InitializeComponent();
        }

    private void groupPanel2_Click(object sender, EventArgs e)
    {
    }

    private void btnReport_1_Click(object sender, EventArgs e)
    {
      this.groupPanel2.Visible = false;
      rpt_feesReport rptFeesReport = new rpt_feesReport();
      DataSet1 dataSet1 = new DataSet1();
      DataTable dataTable = new DataTable();
      DataTable dataTabl1 = this.dal.getDataTabl_1("select  C.Gr_Code,C.Gr_name," +
          "  SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and (A.acc_no like '321%' or A.acc_no like '33%') and A.acc_no not like '3302%' and A.Acc_no not in ('32135','32139','32163','32164')   and CAST(A.g_date as date) between '" + this.fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + this.toDate.Value.ToString("yyyy-MM-dd") + "' THEN  meno-loh else 0 END) as GA_ " +
          ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.acc_no like '322%' and A.Acc_no not in ('32235','32239','32263','32264','32268') and CAST(A.g_date as date) between '" + this.fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + this.toDate.Value.ToString("yyyy-MM-dd") + "' THEN  meno-loh else 0 END) as Sal_ " +
          ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and (A.acc_no like '34%' or A.Acc_no in ('32135','32139','32163','32164','32168','32235','32239','32263','32264','32268'))  and CAST(A.g_date as date) between '" + this.fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + this.toDate.Value.ToString("yyyy-MM-dd") + "' THEN  meno-loh else 0 END) as Indust_ " +
          ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and (A.acc_no like '321%' or A.acc_no like '33%') and A.acc_no not like '3302%' and A.Acc_no not in ('32135','32139','32163','32164') and CAST(A.g_date as date) between DATEADD(year, -1, '" + this.fromDate.Value.ToString("yyyy-MM-dd") + "') and DATEADD(year, -1, '" + this.toDate.Value.ToString("yyyy-MM-dd") + "') THEN  meno-loh else 0 END) as prev_GA_ " +
          ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and A.acc_no like '322%' and A.Acc_no not in ('32235','32239','32263','32264','32268') and CAST(A.g_date as date) between DATEADD(year, -1, '" + this.fromDate.Value.ToString("yyyy-MM-dd") + "') and DATEADD(year, -1, '" + this.toDate.Value.ToString("yyyy-MM-dd") + "') THEN  meno-loh else 0 END) as prev_Sal_ " +
          ", SUM(CASE WHEN B.Temp1 like '" + Acc_Group.ID.Text + "%' and (A.acc_no like '34%' or A.Acc_no in ('32135','32139','32163','32164','32168','32235','32239','32263','32264','32268')) and CAST(A.g_date as date) between DATEADD(year, -1, '" + this.fromDate.Value.ToString("yyyy-MM-dd") + "') and DATEADD(year, -1, '" + this.toDate.Value.ToString("yyyy-MM-dd") + "') THEN  meno-loh else 0 END) as prev_Indust_ " +
          ", c.Prev_no,d.Gr_name from daily_transaction  as A  inner join payer2 as b  on A.ACC_NO=B.ACC_NO and A.BRANCH_code = b.BRANCH_code inner join Wh_Costmers_Vendors_Group as C on b.Temp1 =C.Gr_Code inner join Wh_Costmers_Vendors_Group as D on C.Prev_no =D.Gr_Code where A.BRANCH_code like '" + this.txtBranch.ID.Text + "%'  group by  C.Gr_Code,C.Gr_name,c.Prev_no,d.Gr_name");
      dataSet1.Tables.Add(dataTabl1);
      dataSet1.WriteXmlSchema("schema1.xml");
      rptFeesReport.SetDataSource((DataSet) dataSet1);
      if (this.rdo1.Checked)
        rptFeesReport.ReportDefinition.Sections["Section3"].SectionFormat.EnableSuppress = true;
      else
        rptFeesReport.ReportDefinition.Sections["GroupHeaderSection1"].SectionFormat.EnableSuppress = true;
      this.crystalReportViewer1.ReportSource = (object) rptFeesReport;
      FormulaFieldDefinition formulaField1 = rptFeesReport.DataDefinition.FormulaFields["From_date"];
      DateTime dateTime = this.fromDate.Value;
      string str1 = "'" + dateTime.ToString("yyyy/MM/dd") + "'";
      formulaField1.Text = str1;
      FormulaFieldDefinition formulaField2 = rptFeesReport.DataDefinition.FormulaFields["To_Date"];
      dateTime = this.toDate.Value;
      string str2 = "'" + dateTime.ToString("yyyy/MM/dd") + "'";
      formulaField2.Text = str2;
      rptFeesReport.DataDefinition.FormulaFields["company_name"].Text = "'" + Settings.Default.head_txt + "'";
      rptFeesReport.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Settings.Default.Branch_txt + "'";
      rptFeesReport.DataDefinition.FormulaFields["Branch_"].Text = "'" + this.txtBranch.Desc.Text + "'";
      rptFeesReport.DataDefinition.FormulaFields["Acc_Group"].Text = "'" + this.Acc_Group.Desc.Text + "'";

    }

    private void btnOption_Click(object sender, EventArgs e) { this.groupPanel2.Visible = true; }

    private void btnReport_2_Click(object sender, EventArgs e)
    {
      this.groupPanel2.Visible = false;
      rpt_branches_summry rptBranchesSummry = new rpt_branches_summry();
      DataSet1 dataSet1 = new DataSet1();
      DataTable dataTable = new DataTable();
      DataTable dataTabl1 = this.dal.getDataTabl_1("select D.BRANCH_code,B.BRANCH_name,sum (case  when acc_no like '4%' and cast(g_date as date) between '" + fromDate.Value.ToString("yyyy/MM/dd") + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "'  then (loh-meno) end) as sales_  , sum (case  when (acc_no like '123%' or ACC_NO like '12708%') and cast(g_date as date)<'" + this.fromDate.Value.ToString("yyyy/MM/dd") + "'  then (meno-loh) end) as Cust_1  , sum (case  when (acc_no like '123%' or ACC_NO like '12708%') and cast(g_date as date)<='" + this.toDate.Value.ToString("yyyy/MM/dd") + "'  then (meno-loh) end) as Cust_2  , sum (case  when acc_no like '32%' and cast(g_date as date) between '" + this.fromDate.Value.ToString("yyyy/MM/dd") + "'  and '" + this.toDate.Value.ToString("yyyy/MM/dd") + "'   then (meno-loh) end) as fees_  , sum (case  when acc_no like '35%' and cast(g_date as date) between '" + this.fromDate.Value.ToString("yyyy/MM/dd") + "'  and '" + this.toDate.Value.ToString("yyyy/MM/dd") + "'   then (meno-loh) end) as purch_  ,sum (case  when acc_no like '121%' and cast(g_date as date) <= '" + this.toDate.Value.ToString("yyyy/MM/dd") + "'   then (meno-loh) end) as Cash_  from daily_transaction as D inner join BRANCHS As B on B.BRANCH_code=D.BRANCH_code  where D.BRANCH_code like '" + this.txtBranch.ID.Text + "%'   group by D.BRANCH_code,B.BRANCH_name");
      dataSet1.Tables.Add(dataTabl1);
      dataSet1.WriteXmlSchema("schema1.xml");
      rptBranchesSummry.SetDataSource((DataSet) dataSet1);
      this.crystalReportViewer1.ReportSource = (object) rptBranchesSummry;
    }

    private void labelX5_Click(object sender, EventArgs e)
    {

    }

    private void frm_rep_Fees_Load(object sender, EventArgs e)
    {
        Acc_Group.txtFinal.Text = "0";
    }

       }
}
