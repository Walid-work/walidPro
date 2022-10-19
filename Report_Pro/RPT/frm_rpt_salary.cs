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
    public partial class frm_rpt_salary : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_rpt_salary()
        {
            InitializeComponent();
        }

        private void الفرع_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            
                      
           DataTable dt_rpt=dal.getDataTabl_1(@"SELECT MONTH(D.g_date) as month
        ,isnull(D.CAT_CODE, 0) as cat_code,c.CAT_NAME,D.BRANCH_code,B.BRANCH_name
        ,SUM(CASE WHEN  D.ACC_NO in ('32101', '32201', '34201')  THEN D.meno - D.loh  ELSE 0 END) AS B_Salary
        , SUM(CASE WHEN  D.ACC_NO in ('32102', '32202', '34202')  THEN D.meno - D.loh  ELSE 0 END) AS OverTime
        , SUM(CASE WHEN  D.ACC_NO in ('32103', '32203', '34203')  THEN D.meno - D.loh  ELSE 0 END) AS bounse
        , SUM(CASE WHEN  D.ACC_NO in ('32104', '32204', '34210')  THEN D.meno - D.loh  ELSE 0 END) AS iasha
        , SUM(CASE WHEN  D.ACC_NO in ('32105', '32205', '34204')  THEN D.meno - D.loh  ELSE 0 END) AS transport
        , SUM(CASE WHEN  D.ACC_NO in ('32106', '32206', '34207')  THEN D.meno - D.loh  ELSE 0 END) AS sakan
        , SUM(CASE WHEN  D.ACC_NO in ('32169', '32269', '34236')  THEN D.meno - D.loh  ELSE 0 END) AS schoolFess
        , SUM(CASE WHEN  D.ACC_NO in ('32177', '32277', '34242')  THEN D.meno - D.loh  ELSE 0 END) AS insurance
        , SUM(CASE WHEN  D.ACC_NO in ('32107', '32207', '34208')  THEN D.meno - D.loh  ELSE 0 END) AS vacation  
        , SUM(CASE WHEN  D.ACC_NO in ('32108', '32208', '34209')  THEN D.meno - D.loh  ELSE 0 END) AS tickets 
        , SUM(CASE WHEN  D.ACC_NO in ('32176', '32276', '34276')  THEN D.meno - D.loh  ELSE 0 END) AS Morafiqen
        , SUM(CASE WHEN  D.ACC_NO in ('23309')  THEN D.meno - D.loh  ELSE 0 END) AS T_bank
        , SUM(CASE WHEN  D.ACC_NO like '127021%' and loh between 1 and 2000 THEN D.loh  ELSE 0 END) AS loans
        FROM daily_transaction as D
        left join CATEGORY as C on c.CAT_CODE = D.CAT_CODE
        inner join BRANCHS as B on B.BRANCH_code = D.BRANCH_code
        where CAST(D.g_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd")+ "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
        "' and D.CAT_CODE like '"+Catogry.ID.Text+ "%' and D.BRANCH_code like '" + AccBranch.ID.Text +
        "%' and D.ACC_NO like '" + Acc.ID.Text +"%' group by MONTH(D.g_date),isnull(D.CAT_CODE, 0),c.CAT_NAME,d.BRANCH_code,B.BRANCH_name " +
        "order by MONTH(D.g_date),cat_code");
        ds.Tables.Add(dt_rpt);
        ds.WriteXmlSchema("schema1.xml");
      

           if(radioGroup1.EditValue.Equals("0"))
            {
                RPT.rpt_salary rpt = new RPT.rpt_salary();
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + AccBranch.Desc.Text + "'";

            }
           else if (radioGroup1.EditValue.Equals("1"))
            {
                RPT.rpt_salary_ByEmp rpt = new RPT.rpt_salary_ByEmp();
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + AccBranch.Desc.Text + "'";

            }

            groupPanel1.Visible = false;


        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            RPT.rpt_salary rpt = new RPT.rpt_salary();

            DataTable dt_rpt = dal.getDataTabl_1(@"SELECT MONTH(D.g_date) as month
        ,isnull(D.CAT_CODE, 0) as cat_code,c.CAT_NAME,D.BRANCH_code,B.BRANCH_name
        ,SUM(CASE WHEN  D.ACC_NO in ('34601', '32201', '34201')  THEN D.meno - D.loh  ELSE 0 END) AS B_Salary
        , SUM(CASE WHEN  D.ACC_NO in ('34602', '32202', '34202')  THEN D.meno - D.loh  ELSE 0 END) AS OverTime
        , SUM(CASE WHEN  D.ACC_NO in ('34603', '32203', '34203')  THEN D.meno - D.loh  ELSE 0 END) AS bounse
        , SUM(CASE WHEN  D.ACC_NO in ('34604', '32204', '34210')  THEN D.meno - D.loh  ELSE 0 END) AS iasha
        , SUM(CASE WHEN  D.ACC_NO in ('34605', '32205', '34204')  THEN D.meno - D.loh  ELSE 0 END) AS transport
        , SUM(CASE WHEN  D.ACC_NO in ('34606', '32206', '34207')  THEN D.meno - D.loh  ELSE 0 END) AS sakan
       , SUM(CASE WHEN  D.ACC_NO in ('34669', '32269', '34236')  THEN D.meno - D.loh  ELSE 0 END) AS schoolFess
        , SUM(CASE WHEN  D.ACC_NO in ('2339')  THEN D.meno - D.loh  ELSE 0 END) AS T_bank
        , SUM(CASE WHEN  D.ACC_NO like '127021%' and loh between 1 and 2000 THEN D.loh  ELSE 0 END) AS loans
        FROM daily_transaction as D
        left join CATEGORY as C on c.CAT_CODE = D.CAT_CODE
        inner join BRANCHS as B on B.BRANCH_code = D.BRANCH_code
        where CAST(D.g_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
         "' and D.CAT_CODE like '" + Catogry.ID.Text + "%' and D.BRANCH_code like '" + AccBranch.ID.Text +
         "%' and D.ACC_NO like '" + Acc.ID.Text + "%' group by MONTH(D.g_date),isnull(D.CAT_CODE, 0),c.CAT_NAME,d.BRANCH_code,B.BRANCH_name " +
         "order by MONTH(D.g_date),cat_code");
            ds.Tables.Add(dt_rpt);
            //ds.WriteXmlSchema("schema1.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + AccBranch.Desc.Text + "'";

            groupPanel1.Visible = false;

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            RPT.rpt_salary rpt = new RPT.rpt_salary();

            DataTable dt_rpt = dal.getDataTabl_1(@"SELECT MONTH(D.g_date) as month
        ,isnull(D.CAT_CODE, 0) as cat_code,c.CAT_NAME,D.BRANCH_code,B.BRANCH_name
        ,SUM(CASE WHEN  D.ACC_NO in ('310101', '320101')  THEN D.meno - D.loh  ELSE 0 END) AS B_Salary
        , SUM(CASE WHEN  D.ACC_NO in ('310102', '320102')  THEN D.meno - D.loh  ELSE 0 END) AS OverTime
        , SUM(CASE WHEN  D.ACC_NO in ('310103', '320103')  THEN D.meno - D.loh  ELSE 0 END) AS bounse
        , SUM(CASE WHEN  D.ACC_NO in ( '320108')  THEN D.meno - D.loh  ELSE 0 END) AS iasha
        , SUM(CASE WHEN  D.ACC_NO in ('310104', '320104')  THEN D.meno - D.loh  ELSE 0 END) AS transport
        , SUM(CASE WHEN  D.ACC_NO in ('310105', '320105')  THEN D.meno - D.loh  ELSE 0 END) AS sakan
       , SUM(CASE WHEN  D.ACC_NO in ('310540')  THEN D.meno - D.loh  ELSE 0 END) AS schoolFess
       , SUM(CASE WHEN  D.ACC_NO in ('230310')  THEN D.meno - D.loh  ELSE 0 END) AS T_bank
        , SUM(CASE WHEN  D.ACC_NO like '120501%' and loh between 1 and 2000 THEN D.loh  ELSE 0 END) AS loans
        FROM daily_transaction as D
        left join CATEGORY as C on c.CAT_CODE = D.CAT_CODE
        inner join BRANCHS as B on B.BRANCH_code = D.BRANCH_code
        where CAST(D.g_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
         "' and D.CAT_CODE like '" + Catogry.ID.Text + "%' and D.BRANCH_code like '" + AccBranch.ID.Text +
         "%' and D.ACC_NO like '" + Acc.ID.Text + "%' group by MONTH(D.g_date),isnull(D.CAT_CODE, 0),c.CAT_NAME,d.BRANCH_code,B.BRANCH_name " +
         "order by MONTH(D.g_date),cat_code");
            ds.Tables.Add(dt_rpt);
            //ds.WriteXmlSchema("schema1.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + AccBranch.Desc.Text + "'";

            groupPanel1.Visible = false;
        }
    }
}
