using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_cash_transaction : Form
    {
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        int currencyNo = 2;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_cash_transaction()
        {
            InitializeComponent();
        }

        private void btn_cash_recet_Click(object sender, EventArgs e)
        {
            RPT.rpt_cash_transaction rpt = new RPT.rpt_cash_transaction();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT D.ACC_NO,P.Payer_name,D.BRANCH_code,
                    branch_name,ser_no,meno,loh,D.g_date,desc2 FROM daily_transaction as D  
                    inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code=p.BRANCH_code
                    join wh_BRANCHES As B on D.BRANCH_code = B.BRANCH_code
                    where D.BRANCH_code like '" + Branch.ID.Text + "%' and  d.acc_no like '123%' and cast(D.g_date as date ) between '" + 
                    FromDate.Value.ToString("yyyy-MM-dd")+ "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'CR' ");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
            rpt.DataDefinition.FormulaFields["Titel_"].Text = "'سندات قبض نقدية'";
            //rpt.DataDefinition.FormulaFields["branch_E_"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";

            crystalReportViewer1.ReportSource = rpt;


        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_bank_recet_Click(object sender, EventArgs e)
        {
            RPT.rpt_cash_transaction rpt = new RPT.rpt_cash_transaction();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT D.ACC_NO,P.Payer_name,D.BRANCH_code,
                    branch_name,ser_no,meno,loh,D.g_date,desc2 FROM daily_transaction as D  
                    inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code=p.BRANCH_code
                    join wh_BRANCHES As B on D.BRANCH_code = B.BRANCH_code
                    where D.BRANCH_code like '" + Branch.ID.Text + "%' and   d.acc_no like '123%' and cast(D.g_date as date ) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'BR'");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
            rpt.DataDefinition.FormulaFields["Titel_"].Text = "'سندات قبض بنوك'";
            //rpt.DataDefinition.FormulaFields["branch_E_"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";

            crystalReportViewer1.ReportSource = rpt;
        }

        private void btn_bank_deposit_Click(object sender, EventArgs e)
        {
              RPT.rpt_cash_transaction rpt = new RPT.rpt_cash_transaction();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT D.ACC_NO,P.Payer_name,D.BRANCH_code,
                    branch_name,ser_no,meno,loh,D.g_date,desc2 FROM daily_transaction as D  
                    inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code=p.BRANCH_code
                    join wh_BRANCHES As B on D.BRANCH_code = B.BRANCH_code
                    where  D.BRANCH_code like '" + Branch.ID.Text + "%'  and  d.acc_no like '121%' and cast(D.g_date as date ) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'CB'");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
            rpt.DataDefinition.FormulaFields["Titel_"].Text = "'ايداعات بنكية من الصندوق'";
            //rpt.DataDefinition.FormulaFields["branch_E_"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";

            crystalReportViewer1.ReportSource = rpt;
        }

        private void btn_fees_Click(object sender, EventArgs e)
        {
            RPT.rpt_cash_transaction rpt = new RPT.rpt_cash_transaction();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT D.ACC_NO,P.Payer_name,D.BRANCH_code,
                    branch_name,ser_no,meno,loh,D.g_date,desc2 FROM daily_transaction as D  
                    inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code=p.BRANCH_code
                    join wh_BRANCHES As B on D.BRANCH_code = B.BRANCH_code
where  D.BRANCH_code like '" + Branch.ID.Text + "%' and  d.acc_no like '121%' and cast(D.g_date as date ) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'CE'");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
            rpt.DataDefinition.FormulaFields["Titel_"].Text = "'المصاريف'";
            ////rpt.DataDefinition.FormulaFields["branch_E_"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";

            crystalReportViewer1.ReportSource = rpt;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            RPT.rpt_cash_sheet rpt = new RPT.rpt_cash_sheet();
            DataSet ds = new DataSet();
            DataTable dt_tr = new DataTable();
            dt_tr = dal.getDataTabl_1(@"SELECT  branch_name, SUM(CASE WHEN  d.acc_no like '121%' and cast(D.g_date as date) > '1950-01-01' and cast(D.g_date as date) < '" + FromDate.Value.ToString("yyyy-MM-dd") + "'  THEN meno -loh ELSE 0 END) AS Begining_balance "+
            ", SUM(CASE WHEN d.acc_no like '121%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "'  and SOURCE_CODE like 'XS%' THEN meno - loh ELSE 0 END) AS sales_ "+
            ", SUM(CASE WHEN d.acc_no like '123%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'CR'  THEN loh ELSE 0 END) AS cash_recet " +
            ", SUM(CASE WHEN d.acc_no like '123%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'BR'  THEN loh ELSE 0 END) AS bank_recet " +
            ", SUM(CASE WHEN d.acc_no like '121%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'CB'  THEN loh ELSE 0 END) AS bank_deposit " +
            ", SUM(CASE WHEN d.acc_no like '121%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'CE'  THEN loh ELSE 0 END) AS fees " +
            ", SUM(CASE WHEN d.acc_no like '121%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "'  and SOURCE_CODE like 'Xp%' THEN meno - loh ELSE 0 END) AS purchase_ "+

            "FROM daily_transaction as D inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code = p.BRANCH_code "+
            "inner join wh_BRANCHES As B on D.BRANCH_code = B.BRANCH_code where B.BRANCH_code like '"+Branch.ID.Text+"%' group by branch_name ");

            ds.Tables.Add(dt_tr);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
            //rpt.DataDefinition.FormulaFields["Titel_"].Text = "'Expenses'";
            decimal balance_ = dt_tr.Rows[0][1].ToString().ToDecimal() + dt_tr.Rows[0][2].ToString().ToDecimal() + dt_tr.Rows[0][3].ToString().ToDecimal()-dt_tr.Rows[0][5].ToString().ToDecimal() - dt_tr.Rows[0][6].ToString().ToDecimal() + dt_tr.Rows[0][7].ToString().ToDecimal();
            //MessageBox.Show(balance_.ToString());
            ToWord toWord = new ToWord(Math.Abs(Math.Round(balance_, dal.digits_)), currencies[currencyNo]);
            rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";

            crystalReportViewer1.ReportSource = rpt;


        }

        private void frm_cash_transaction_Load(object sender, EventArgs e)
        {
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.s));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Bahrain));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Oman));

            switch (Properties.Settings.Default.Currency)
            {
                case "s":
                    currencyNo = 2;
                    break;
                case "BH":
                    currencyNo = 5;
                    break;
                case "OM":
                    currencyNo = 6;
                    break;
                case "DR":
                    currencyNo = 1;
                    break;
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            RPT.rpt_Cash_Movment rpt = new RPT.rpt_Cash_Movment();
            DataSet ds = new DataSet();
            DataTable dt_tr = new DataTable();
            dt_tr = dal.getDataTabl_1(@"SELECT  branch_name, SUM(CASE WHEN  d.acc_no like '121%' and cast(D.g_date as date) > '1950-01-01' and cast(D.g_date as date) < '" + FromDate.Value.ToString("yyyy-MM-dd") + "'  THEN meno -loh ELSE 0 END) AS Begining_balance " +
            ", SUM(CASE WHEN d.acc_no like '121%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "'  and SOURCE_CODE like 'XS%' THEN meno - loh ELSE 0 END) AS sales_ " +
            ", SUM(CASE WHEN d.acc_no like '123%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'CR'  THEN loh ELSE 0 END) AS cash_recet " +
            ", SUM(CASE WHEN d.acc_no like '123%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'BR'  THEN loh ELSE 0 END) AS bank_recet " +
            ", SUM(CASE WHEN d.acc_no like '121%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'CB'  THEN loh ELSE 0 END) AS bank_deposit " +
            ", SUM(CASE WHEN d.acc_no like '121%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and Sanad_type2 = 'CE'  THEN loh ELSE 0 END) AS fees " +
            ", SUM(CASE WHEN d.acc_no like '121%' and cast(D.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "'  and SOURCE_CODE like 'Xp%' THEN meno - loh ELSE 0 END) AS purchase_ " +

            "FROM daily_transaction as D inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code = p.BRANCH_code " +
            "inner join wh_BRANCHES As B on D.BRANCH_code = B.BRANCH_code where B.BRANCH_code like '" + Branch.ID.Text + "%' group by branch_name  ");

            ds.Tables.Add(dt_tr);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
            //rpt.DataDefinition.FormulaFields["Titel_"].Text = "'Expenses'";
            decimal balance_ = dt_tr.Rows[0][1].ToString().ToDecimal() + dt_tr.Rows[0][2].ToString().ToDecimal() + dt_tr.Rows[0][3].ToString().ToDecimal() - dt_tr.Rows[0][5].ToString().ToDecimal() - dt_tr.Rows[0][6].ToString().ToDecimal() + dt_tr.Rows[0][7].ToString().ToDecimal();
            //MessageBox.Show(balance_.ToString());
            //ToWord toWord = new ToWord(Math.Abs(Math.Round(balance_, dal.digits_)), currencies[currencyNo]);
            //rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";

            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
