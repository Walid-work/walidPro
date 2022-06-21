using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_Monthly_TB : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Monthly_TB()
        {
            InitializeComponent();
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            RPT.rpt_Monthly_TB rpt = new RPT.rpt_Monthly_TB();
            rpt.SetDataSource(dal.getDataTabl_1(@"SELECT D.ACC_NO ,P.PAYER_NAME,FORMAT(g_date, 'MM-yyyy')  as Month_,SUM(D.meno-D.loh) as Value_ 
            FROM daily_transaction AS D INNER JOIN payer2 p ON P.ACC_NO=D.ACC_NO AND D.BRANCH_code=P.BRANCH_code
            where cast(g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") +
            "'and d.BRANCH_code like  (CASE WHEN (select t_final  from BRANCHS where BRANCH_code='" + UC_Branch.ID.Text + "')='1' then  '" + UC_Branch.ID.Text +
            "' else '" + UC_Branch.ID.Text + "%' end)  and  d.ACC_NO like '" + UC_Acc.ID.Text + "%' and d.COST_CENTER like '" + UC_cost.ID.Text +
            "%'and isnull(d.CAT_CODE,'')" +
            " like '" + UC_Catogry.ID.Text + "%' GROUP BY D.ACC_NO ,P.PAYER_NAME,FORMAT(g_date, 'MM-yyyy')"));
            crystalReportViewer1.ReportSource = rpt;

            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["name"].Text = " '" + UC_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["branchName"].Text = "'" + UC_Branch.Desc.Text + "'";


            Cursor.Current = Cursors.Default;
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible =true;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_Acc_Load(object sender, EventArgs e)
        {

        }
    }
}
