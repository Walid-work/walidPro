using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_PE_rpt : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_PE_rpt()
        {
            InitializeComponent();
        }

        private void uC_AccBranch1_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string closed_ = "";
            if (rdoAll.Checked == true)
            {
                closed_ = "";
            }
            else
            {
                closed_ = "1";
            }

            DataTable dt_ = dal.getDataTabl_1("select X.*,p1.Payer_Name from (select A.*,B.P_ser,B.p_date,B.P_days,B.p_amount,B.p_year,B.p_Quarter,D.BRANCH_name,C.CAT_NAME,p.Payer_Name from P_expenses_T1 as A inner join P_expenses_T2 as B on A.id=B.id " +
         "left join CATEGORY AS C ON A.category_code=C.CAT_CODE " +
         "inner join BRANCHS AS D ON A.branch_code=D.BRANCH_code " +
         "left join payer2 as P on P.acc_no = A.Kind and P.branch_code=A.branch_code " +
         "where isnull(B.Recorded,0)  not like  '"+closed_+"'  and  A.branch_code like '" + Branch_.ID.Text+"%' and cast(p_date as date) between '" + 
         fromDate.Value.ToString("yyyy-MM-dd")+"' and '"+toDate.Value.ToString("yyyy-MM-dd")+"') As X " +
         "left join payer2 as P1 on P1.acc_no = X.Acc_no_P and P1.branch_code=X.branch_code ");

            DataSet ds_ = new DataSet();
            ds_.Tables.Add(dt_);
            // RPT.rpt_PE_Expensses rpt = new RPT.rpt_PE_Expensses();
            Reports.rpt_PExpenssBalance rpt = new Reports.rpt_PExpenssBalance();
            rpt.DataSource = ds_;
            crystalReportViewer1.ReportSource = rpt;

            ds_.WriteXmlSchema("schema1.xml");
            groupPanel2.Visible = false;
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupPanel2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1(@"select B.branch_code, B.BRANCH_name,T1.Acc_no_p,P.PAYER_NAME,T1.descr,T1.category_code,C.CAT_NAME
            ,Sum(isnull(T2.p_amount,0)) as P_Amount
            ,Sum(isnull(C_amount,0)) as C_Amount
            ,SUM(isnull(T2.p_amount,0)-isnull(T2.C_amount,0)) as Balance
            from P_expenses_T1 as T1 
            inner join P_expenses_T2 as T2 on T1.id =T2.id
            inner join BRANCHS as B on T1.branch_code=B.BRANCH_code
            inner join payer2 as P on p.Acc_no = T1.Acc_no_p and P.Branch_Code=T1.branch_code
            left join category as C on C.CAT_CODE=T1.category_code
            group by B.branch_code, B.BRANCH_name,T1.Acc_no_p,P.PAYER_NAME,T1.descr,T1.category_code,C.CAT_NAME ");

            DataSet ds_ = new DataSet();
            ds_.Tables.Add(dt_);
            Reports.rpt_PExpenssBalance rpt = new Reports.rpt_PExpenssBalance();
            rpt.DataSource = ds_;
            rpt.ShowPreview();

            //ds_.WriteXmlSchema("schema_rpt.xml");
        }
    }
}
