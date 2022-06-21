using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_statment_Many_Rpt: Form
    {
        string db1 = Properties.Settings.Default.Database_1;
        string btn_name;
                List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        int currencyNo = 2;
        DAL.DataAccesslayer1 dal=new DAL.DataAccesslayer1();
        public frm_statment_Many_Rpt()
        {
            InitializeComponent();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }



       

        private void buttonX9_Click(object sender, EventArgs e)
        {
            RPT.Statment_acc rpt = new RPT.Statment_acc();
            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

           

            dt1 = (dal.getDataTabl_1(@"select A.*, P.PAYER_NAME, P.payer_l_name
            , B.branch_name, C.CAT_NAME, S.COST_name, S.COST_E_NAME
            from daily_transaction as A
            inner join  payer2 as P on P.ACC_NO = A.ACC_NO and P.BRANCH_code = A.BRANCH_code
            inner join  wh_BRANCHES as B on  B.BRANCH_code = A.BRANCH_code
            left join  CATEGORY As C on  C.CAT_CODE = A.CAT_CODE
            left join  COST_CENTER as S on S.COST_CODE = A.COST_CENTER
            where cast(A.g_date as date) between '" + FromDate.Value.ToString("yyyy/MM/dd") + 
            "'  and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  and  A.ACC_NO in ('"+uC_Acc2.ID.Text+ "','" + uC_Acc3.ID.Text + "','" + uC_Acc4.ID.Text + "','" + uC_Acc5.ID.Text + "','" + UC_Acc1.ID.Text + "')" +
            " and ISNULL(A.CAT_CODE, '')  like '%' and  A.BRANCH_code like '%' order by A.G_date"));

                dt2 = (dal.getDataTabl_1(@"select 
      
		SUM(CASE WHEN cast(A.g_date as date) > '" + FromDate.Value.ToString("yyyy/MM/dd") + "'  and cast(A.g_date as date) < '" + FromDate.Value.ToString("yyyy/MM/dd") + "'  THEN meno - loh ELSE 0 END) AS  Begining_balance" +
  "        , SUM(CASE WHEN cast(A.g_date as date) >= '" + FromDate.Value.ToString("yyyy/MM/dd") + "'  and cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy/MM/dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
  "		,SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') >=0 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') <=30  THEN meno    ELSE 0 END) AS '1-30'" +
  "		,SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') >=31 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') <=60  THEN meno    ELSE 0 END) AS '31-60'" +
  "		,SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') >=61 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') <=90  THEN meno    ELSE 0 END) AS '61-90'" +
  "		,SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') >=91 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') <=120  THEN meno    ELSE 0 END) AS '91-120'" +
  "		,SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') >=121 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') <=150  THEN meno    ELSE 0 END) AS '121-250'" +
  "		,SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') >=151 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') <=180  THEN meno    ELSE 0 END) AS '151-180'" +
  "		,SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy/MM/dd") + "') >=181  THEN meno    ELSE 0 END) AS 'more180'" +
  "    from daily_transaction as A   " +
  "where A.ACC_NO in ('" + uC_Acc2.ID.Text + "','" + uC_Acc3.ID.Text + "','" + uC_Acc4.ID.Text + "','" + uC_Acc5.ID.Text + "','" + UC_Acc1.ID.Text + "') and ISNULL(A.COST_CENTER,'') like '%" + UC_cost1.ID.Text + "%' and ISNULL(A.CAT_CODE,'')  like '%" + UC_Catogry1.ID.Text + "%' and  A.BRANCH_code like '" + UC_Branch.ID.Text + "%'"));

     rpt.DataDefinition.FormulaFields["OB_studs"].Text = "'" + chB_1.Text + "'";
          
            
            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);




            //ds.WriteXmlSchema("schema1.xml");

            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            this.Cursor = Cursors.Default;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Acc_No"].Text = " '" + UC_Acc1.ID.Text + "'";
            rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc1.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Cost_No"].Text = "'" + UC_cost1.ID.Text + "'";
            rpt.DataDefinition.FormulaFields["Cost_name"].Text = "'" + UC_cost1.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Cat_NO"].Text = "'" + UC_Catogry1.ID.Text + "'";
            rpt.DataDefinition.FormulaFields["Cat_Name"].Text = "'" + UC_Catogry1.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            rpt.DataDefinition.FormulaFields["branch_name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";

          
            groupPanel1.Visible = false;


        }

        private void frm_statment_Rpt_Load(object sender, EventArgs e)
        {

        }
    }
}
