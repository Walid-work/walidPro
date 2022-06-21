using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_Conslidated_Reports : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Conslidated_Reports()
        {
            InitializeComponent();
        }

        private void btn_CashMovment_Click(object sender, EventArgs e)
        {
            RPT.Form1 frm = new RPT.Form1();
            CTR.rpt_Cash_Movment rpt = new CTR.rpt_Cash_Movment();
            DataSet ds = new DataSet();
            DataTable dt_tr = new DataTable();
            dt_tr = dal.getDataTabl_1(@"SELECT  branch_short_name as branch_name, SUM(CASE WHEN  d.acc_no like '121%' and convert(varchar,D.g_date,111) > '1950-01-01' and cast(D.g_date as date) < '" + FromDate.Value.ToString("yyyy/MM/dd") + "'  THEN meno -loh ELSE 0 END) AS Begining_balance " +
           ", round(SUM(CASE WHEN d.acc_no like '123%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  and SOURCE_CODE like 'XS%' THEN meno - loh ELSE 0 END), 0) AS credit_sales " +

           ", SUM(CASE WHEN d.acc_no like '121%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  and SOURCE_CODE like 'XS%' THEN meno - loh ELSE 0 END) AS sales_ " +
            ", SUM(CASE WHEN d.acc_no like '123%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 in('CR','BR')  THEN loh ELSE 0 END) AS cash_recet " +
            ", SUM(CASE WHEN d.acc_no like '123%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'BR'  THEN loh ELSE 0 END) AS bank_recet " +
            ", SUM(CASE WHEN d.acc_no like '121%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'CB'  THEN loh ELSE 0 END)+SUM(CASE WHEN d.acc_no like '123%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 ='BR'  THEN loh ELSE 0 END) AS bank_deposit " +
            ", SUM(CASE WHEN d.acc_no like '121%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'CE'  THEN loh ELSE 0 END) AS fees " +
            ", SUM(CASE WHEN d.acc_no like '121%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  and SOURCE_CODE like 'Xp%' THEN loh-meno ELSE 0 END) AS purchase_ " +

            "FROM GroupDB.dbo.daily_transaction as D " +
            "inner join GroupDB.dbo.payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code = p.BRANCH_code " +
            "inner join GroupDB.dbo.Branchs As B on D.BRANCH_code = B.BRANCH_code where B.notes='مبيعات' and  B.BRANCH_code like '" + Branch.ID.Text + "%' group by branch_short_name  ");
            ds.Tables.Add(dt_tr);
            //ds.WriteXmlSchema("schema_xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
            //rpt.DataDefinition.FormulaFields["Titel_"].Text = "'Expenses'";
            decimal balance_;
            if (dt_tr.Rows.Count > 0)
            {
                balance_ = Convert.ToDecimal(dt_tr.Rows[0][1].ToString()) + Convert.ToDecimal(dt_tr.Rows[0][2].ToString()) + Convert.ToDecimal(dt_tr.Rows[0][3].ToString()) - Convert.ToDecimal(dt_tr.Rows[0][5].ToString()) - Convert.ToDecimal(dt_tr.Rows[0][6].ToString()) + Convert.ToDecimal(dt_tr.Rows[0][7].ToString());
            }
            else
            {
                balance_ = 0;
            }
            //MessageBox.Show(balance_.ToString());
            //ToWord toWord = new ToWord(Math.Abs(Math.Round(balance_, dal.digits_)), currencies[currencyNo]);
            //rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";

            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();


        }
    }
}
