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
    public partial class frm_statment_Rpt : frm_ReportMaster
    {
        string db1 = Properties.Settings.Default.Database_1;
        string btn_name;
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        int currencyNo = 2;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_statment_Rpt()
        {
            InitializeComponent();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

        public override void Report()
        {
            base.Report();



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





            if (Properties.Settings.Default.lungh == "0")
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dt = new DataTable();
                dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "", db1);
                if (dt.Rows.Count <= 0 && UC_cost1.ID.Text == string.Empty && UC_Catogry1.ID.Text == string.Empty)
                {
                    MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "1", db1).Rows.Count <= 0)
                {
                    print_acc_all_A();
                }
                else
                {
                    print_acc_A();
                }
            }
            // English print
            else
            {

                this.Cursor = Cursors.WaitCursor;
                DataTable dt = new DataTable();
                dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "", db1);
                if (dt.Rows.Count <= 0 && UC_cost1.ID.Text == string.Empty && UC_Catogry1.ID.Text == string.Empty)
                {
                    MessageBox.Show("No account was chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "1", db1).Rows.Count <= 0)
                {
                    print_all_E();
                }
                else
                {
                    print_acc_E();
                }



            }


        }



        private void Report_btn_Click(object sender, EventArgs e)
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





            if (Properties.Settings.Default.lungh == "0")
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dt = new DataTable();
                dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "", db1);
                if (dt.Rows.Count <= 0 && UC_cost1.ID.Text == string.Empty && UC_Catogry1.ID.Text == string.Empty)
                {
                    MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "1", db1).Rows.Count <= 0)
                {
                    print_acc_all_A();
                }
                else
                {
                    print_acc_A();
                }
            }
            // English print
            else
            {

                this.Cursor = Cursors.WaitCursor;
                DataTable dt = new DataTable();
                dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "", db1);
                if (dt.Rows.Count <= 0 && UC_cost1.ID.Text == string.Empty && UC_Catogry1.ID.Text == string.Empty)
                {
                    MessageBox.Show("No account was chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "1", db1).Rows.Count <= 0)
                {
                    print_all_E();
                }
                else
                {
                    print_acc_E();
                }



            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void print_acc_E()
        {
            RPT.Statment_acc_E rpt = new RPT.Statment_acc_E();
            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            if (chB_1.Checked == true)
            {
                dt1 = (dal.getDataTabl("acc_statment_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1));
                dt2 = (dal.getDataTabl("begin_statment_balance_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.Value.Date, UC_Branch.ID.Text, db1, Properties.Settings.Default.Currency));
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "'" + chB_1.Text + "'";
            }
            else
            {
                dt1 = (dal.getDataTabl("acc_statment_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1));
                dt2 = (dal.getDataTabl("begin_statment_balance_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.MinDate, UC_Branch.ID.Text, db1, Properties.Settings.Default.Currency));
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";
            }

            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);

            //ds.WriteXmlSchema("schema1.xml");

            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            this.Cursor = Cursors.Default;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("dd/MM/yyyy") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
            rpt.DataDefinition.FormulaFields["Acc_No"].Text = " '" + UC_Acc1.ID.Text + "'";
            rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc1.ID.Text + "'+' - '+'" + UC_Acc1.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Cost_No"].Text = "'" + UC_cost1.ID.Text + "'";
            rpt.DataDefinition.FormulaFields["Cost_name"].Text = "'" + UC_cost1.ID.Text + "'+' - '+'" + UC_cost1.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Cat_NO"].Text = "'" + UC_Catogry1.ID.Text + "'";
            rpt.DataDefinition.FormulaFields["Cat_Name"].Text = "'" + UC_Catogry1.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
            rpt.DataDefinition.FormulaFields["branch_name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";

            ToWord toWord = new ToWord(Math.Abs(Math.Round(dt2.Rows[0][1].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
            rpt.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";

            groupPanel1.Visible = false;

        }

        private void print_all_E()
        {
            DataTable dt_ch = new DataTable();

            dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                inner join (select  acc_no
                , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
            "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
            " from daily_transaction  group by ACC_NO ) As A " +
            " on P.ACC_NO=A.ACC_NO " +
            " where p.ACC_NO like '" + UC_Acc1.ID.Text + "%' and A.Ending_balance<>0) As X where X.DuplicateCount=1");


            foreach (DataRow dr in dt_ch.Rows)
            {


                RPT.Statment_acc_E rpt = new RPT.Statment_acc_E();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();

                if (chB_1.Checked == true)
                {
                    dt1 = (dal.getDataTabl("acc_statment_", FromDate.Value.Date, ToDate.Value.Date, dr[0].ToString(), UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1));
                    dt2 = (dal.getDataTabl("begin_statment_balance_", FromDate.Value.Date, ToDate.Value.Date, dr[0].ToString(), UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.Value.Date, UC_Branch.ID.Text, db1, Properties.Settings.Default.Currency));
                    rpt.DataDefinition.FormulaFields["OB_studs"].Text = "'" + chB_1.Text + "'";
                }
                else
                {
                    dt1 = dal.getDataTabl("acc_statment_", FromDate.Value.Date, ToDate.Value.Date, dr[0].ToString(), UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1);
                    dt2 = (dal.getDataTabl("begin_statment_balance_", FromDate.Value.Date, ToDate.Value.Date, dr[0].ToString(), UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.MinDate, UC_Branch.ID.Text, db1, Properties.Settings.Default.Currency));
                    rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";
                }
                ds.Tables.Add(dt1);
                ds.Tables.Add(dt2);

                //ds.WriteXmlSchema("schema1.xml");
                rpt.SetDataSource(ds);

                //crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["Acc_No"].Text = " '" + dr[0].ToString() + "'";
                rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + dr[0].ToString() + "'+' - '+ '" + dr[2].ToString() + "'";
                rpt.DataDefinition.FormulaFields["Cost_No"].Text = "'" + UC_cost1.ID.Text + "'";
                rpt.DataDefinition.FormulaFields["Cost_name"].Text = "'" + UC_cost1.ID.Text + "'+' - '+'" + UC_cost1.Desc.Text + "'";
                rpt.DataDefinition.FormulaFields["Cat_NO"].Text = "'" + UC_Catogry1.ID.Text + "'";
                rpt.DataDefinition.FormulaFields["Cat_Name"].Text = "'" + UC_Catogry1.Desc.Text + "'";
                rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
                rpt.DataDefinition.FormulaFields["branch_name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
                rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
                ToWord toWord = new ToWord(Math.Abs(Math.Round(dt2.Rows[0][1].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";

                rpt.PrintOptions.PrinterName = Properties.Settings.Default.Report_P;
                rpt.PrintToPrinter(1, false, 0, 15);

                groupPanel1.Visible = false;

            }
        }
        private void print_acc_A()

        {
            RPT.Statment_acc rpt = new RPT.Statment_acc();
            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            if (chB_1.Checked == true)
            {
                dt1 = (dal.getDataTabl("acc_statment_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1));
                dt2 = (dal.getDataTabl("begin_statment_balance_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.Value.Date, UC_Branch.ID.Text, db1, Properties.Settings.Default.Currency));
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "'" + chB_1.Text + "'";
            }
            else
            {
                dt1 = (dal.getDataTabl("acc_statment_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1));
                dt2 = (dal.getDataTabl("begin_statment_balance_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.MinDate, UC_Branch.ID.Text, db1, Properties.Settings.Default.Currency));
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";
            }




            // MessageBox.Show(dt2.Rows[0][0].ToString());

            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);




            ////ds.WriteXmlSchema("schema1.xml");

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
            if (dt2.Rows.Count > 0)
            {
                ToWord toWord = new ToWord(Math.Abs(Math.Round(dt2.Rows[0][2].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";
            }
            else
            {
                ToWord toWord = new ToWord(0, currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";

            }
            groupPanel1.Visible = false;

        }

        private void print_acc_all_A()
        {
            DataTable dt_ch = new DataTable();

            //dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
            //inner join (select  acc_no
            //, SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
            //"' THEN meno - loh ELSE 0 END) AS Ending_balance" +
            //" from daily_transaction  group by ACC_NO ) As A " +
            //" on P.ACC_NO=A.ACC_NO " +
            //" where p.ACC_NO like '" + UC_Acc1.ID.Text + "%' and A.Ending_balance<>0) As X where X.DuplicateCount=1");

            //foreach (DataRow dr in dt_ch.Rows)
            //{


            RPT.Statment_acc_Main rpt = new RPT.Statment_acc_Main();
            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            //and A.BRANCH_code like(CASE WHEN (select t_final  from BRANCHS where BRANCH_code= '"+UC_Branch.ID.Text+ "')= '1' then '" + UC_Branch.ID.Text + "' else  '" + UC_Branch.ID.Text + "%' end)
            if (chB_1.Checked == true)
            {
                dt1 = (dal.getDataTabl_1(@"		select A.*,P.PAYER_NAME,P.payer_l_name,B.branch_name,C.CAT_NAME,S.COST_name,S.COST_E_NAME
                    from daily_transaction as A inner join  payer2 as P on P.ACC_NO = A.ACC_NO and P.BRANCH_code = A.BRANCH_code
                    inner join  wh_BRANCHES as B on  B.BRANCH_code = A.BRANCH_code
                    left join  CATEGORY As C on  C.CAT_CODE = A.CAT_CODE
                    left join  COST_CENTER as S on S.COST_CODE = A.COST_CENTER
                    where cast(A.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "'  and '" + ToDate.Value.ToString("yyyy-MM-dd") +
                "' and  A.ACC_NO like '" + UC_Acc1.ID.Text + "%' and ISNULL(A.COST_CENTER, '') like '" + UC_cost1.ID.Text +
                "%' and ISNULL(A.CAT_CODE, '')  like '" + UC_Catogry1.ID.Text +
           "%' and A.BRANCH_code like (CASE WHEN (select t_final  from BRANCHS where BRANCH_code='" + UC_Branch.ID.Text + "')='1' then '" + UC_Branch.ID.Text + "' else  '" + UC_Branch.ID.Text + "%' end)  order by A.G_date"));

                //order by A.G_date
                //where cast(A.g_date as date) between '" + FromDate.Value.ToString("yyyy-MM-dd") + "'  and '" + ToDate.Value.ToString("yyyy-MM-dd") +
                //"' and  A.ACC_NO like '" +  UC_Acc1.ID.Text + "%' and ISNULL(A.COST_CENTER, '') like '" + UC_cost1.ID.Text +
                //"%' and ISNULL(A.CAT_CODE, '')  like '" + UC_Catogry1.ID.Text + "%'  order by A.G_date"));

                //dt2 = (dal.getDataTabl_1(@"select  A.acc_no,
                //SUM(CASE WHEN cast(A.g_date as date) > '" + FromDate.Value.ToString("yyyy-MM-dd") + "'  and cast(A.g_date as date) < '" + FromDate.Value.ToString("yyyy-MM-dd") +"'  THEN meno - loh ELSE 0 END) AS  Begining_balance " +
                //",SUM(CASE WHEN cast(A.g_date as date) >= '" + FromDate.Value.ToString("yyyy-MM-dd") + "'  and cast(A.g_date as date) <=  '" + ToDate.Value.ToString("yyyy-MM-dd") + "'  THEN meno - loh ELSE 0 END) AS Ending_balance " +
                //", SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') >=0 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') <=30  THEN meno    ELSE 0 END) AS '1-30'" +
                //",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') >= 31 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') <= 60  THEN meno    ELSE 0 END) AS '31-60' " +
                //",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') >= 61 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') <= 90  THEN meno    ELSE 0 END) AS '61-90' " +
                //",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') >= 91 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') <= 120  THEN meno    ELSE 0 END) AS '91-120' " +
                //",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') >= 121 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') <= 150  THEN meno    ELSE 0 END) AS '121-250' " +
                //",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') >= 151 and DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') <= 180  THEN meno    ELSE 0 END) AS '151-180' " +
                //",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ), '" + ToDate.Value.ToString("yyyy-MM-dd") +"') >= 181  THEN meno    ELSE 0 END) AS 'more180'" +

                // ",ReportDB.dbo.Tafkeet(ABS(SUM(CASE WHEN cast(A.g_date as date) >= '" + FromDate.Value.ToString("yyyy-MM-dd") + "' and cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END)), '" + Properties.Settings.Default.Currency + "') "+

                //"from daily_transaction as A " +
                //"where A.ACC_NO like '"+ UC_Acc1.ID.Text + "%' and ISNULL(A.COST_CENTER,'') like '" +UC_cost1.ID.Text+ "%' and ISNULL(A.CAT_CODE,'')  like '"+UC_Catogry1.ID.Text+ "%' and  A.BRANCH_code like (CASE WHEN (select t_final  from BRANCHS where BRANCH_code='"+
                //UC_Branch.ID.Text+"')='1' then '" + UC_Branch.ID.Text + "' else  '"+ UC_Branch.ID.Text+"%' end) group by   A.ACC_NO"));

                //rpt.DataDefinition.FormulaFields["OB_studs"].Text = "'" + chB_1.Text + "'";
                //rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
                //rpt.DataDefinition.FormulaFields["branch_name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";

            }
            else
            {
                dt1 = dal.getDataTabl("acc_statment_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1);
                dt2 = (dal.getDataTabl("begin_statment_balance_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.MinDate, UC_Branch.ID.Text, db1, Properties.Settings.Default.Currency));
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";
            }




            // MessageBox.Show(dt2.Rows[0][0].ToString());

            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);




            //ds.WriteXmlSchema("schema1.xml");

            rpt.SetDataSource(ds);

            //crystalReportViewer1.ReportSource = rpt;
            this.Cursor = Cursors.Default;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Acc_No"].Text = " '" + UC_Acc1.ID.Text + "'";
            //rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + dr[1].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Cost_No"].Text = "'" + UC_cost1.ID.Text + "'";
            rpt.DataDefinition.FormulaFields["Cost_name"].Text = "'" + UC_cost1.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Cat_NO"].Text = "'" + UC_Catogry1.ID.Text + "'";
            rpt.DataDefinition.FormulaFields["Cat_Name"].Text = "'" + UC_Catogry1.Desc.Text + "'";
            // rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            //rpt.DataDefinition.FormulaFields["branch_name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            //rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
            if (dt2.Rows.Count > 0)
            {
                ToWord toWord = new ToWord(Math.Abs(Math.Round(dt2.Rows[0][2].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";
            }
            //rpt.PrintOptions.PrinterName = Properties.Settings.Default.Report_P;
            //rpt.PrintToPrinter(1, false, 0, 15);
            crystalReportViewer1.ReportSource = rpt;
            groupPanel1.Visible = false;

            //}

        }








        private void frm_statment_Rpt_Load(object sender, EventArgs e)
        {
            FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            ToDate.Value = DateTime.Today;

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

            // date_period.Value = date_period.MinDate;
        }




        private void chB_1_CheckedChanged(object sender, EventArgs e)
        {
            //if (chB_1.Checked == true)
            //{
            //    date_period.Value = new DateTime(FromDate.Value.Year, 1, 1);
            //}
            //else
            //{
            //    date_period.Value = date_period.MinDate;
            //}
        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            //if (chB_1.Checked == true)
            //{
            //    date_period.Value = new DateTime(FromDate.Value.Year, 1, 1);
            //}
            //else
            //{
            //    date_period.Value = date_period.MinDate;
            //}
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            // this.Cursor = Cursors.WaitCursor;
            // DataTable dt = new DataTable();
            // dt = dal.getDataTabl("GetAcc", UC_Branch.ID.Text, UC_Acc1.ID.Text, "1");
            // if (dt.Rows.Count <= 0)
            // {
            //     MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     return;
            // }

            // RPT.Vat_Statment_acc rpt = new RPT.Vat_Statment_acc();
            //     DataSet1 ds = new DataSet1();
            //     DataTable dt1 = new DataTable();
            //     DataTable dt2 = new DataTable();

            //if(chB_1.Checked==true)
            // {
            //      dt1 = (dal.getDataTabl("acc_statment", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text));
            //      dt2 = (dal.getDataTabl("begin_statment_balance", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.Value.Date));
            //      rpt.DataDefinition.FormulaFields["OB_studs"].Text = "'" + chB_1.Text+ "'";
            //}
            // else
            // {
            //      dt1 = (dal.getDataTabl("acc_statment", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text));
            //      dt2 = (dal.getDataTabl("begin_statment_balance", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.MinDate));
            //      rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";
            //}




            // // MessageBox.Show(dt2.Rows[0][0].ToString());

            //     ds.Tables.Add(dt1);
            //     ds.Tables.Add(dt2);




            //     //ds.WriteXmlSchema("schema1.xml");

            //     rpt.SetDataSource(ds);
            //     crystalReportViewer1.ReportSource = rpt;
            //     this.Cursor = Cursors.Default;
            //     rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            //     rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            //     rpt.DataDefinition.FormulaFields["Acc_No"].Text = " '" + UC_Acc1.ID.Text + "'";
            //     rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc1.Desc.Text + "'";
            //     rpt.DataDefinition.FormulaFields["Cost_No"].Text = "'" + UC_cost1.ID.Text + "'";
            //     rpt.DataDefinition.FormulaFields["Cost_name"].Text = "'" + UC_cost1.Desc.Text + "'";
            //     rpt.DataDefinition.FormulaFields["Cat_NO"].Text = "'" + UC_Catogry1.ID.Text + "'";
            //     rpt.DataDefinition.FormulaFields["Cat_Name"].Text = "'" + UC_Catogry1.Desc.Text + "'";

            //     groupPanel1.Visible = false;

        }


        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "1", db1);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RPT.Statment_acc_Age rpt = new RPT.Statment_acc_Age();
            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            if (chB_1.Checked == true)
            {
                dt1 = (dal.getDataTabl("acc_statment_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1));
                dt2 = (dal.getDataTabl("begin_statment_balance_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.Value.Date, UC_Branch.ID.Text, db1, Properties.Settings.Default.Currency));
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "'" + chB_1.Text + "'";
            }
            else
            {
                dt1 = (dal.getDataTabl("acc_statment_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1));
                dt2 = (dal.getDataTabl("begin_statment_balance_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.MinDate, UC_Branch.ID.Text, db1, Properties.Settings.Default.Currency));
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";
            }




            // MessageBox.Show(dt2.Rows[0][0].ToString());

            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);




            ////ds.WriteXmlSchema("schema1.xml");

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

            groupPanel1.Visible = false;


        }

        private void UC_Acc_Load(object sender, EventArgs e)
        {

        }

        private void UC_cost1_Load(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void uC_Branch1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "", db1);
            if (dt.Rows.Count <= 0 && UC_cost1.ID.Text == string.Empty && UC_Catogry1.ID.Text == string.Empty)
            {
                MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                RPT.AgeReport rpt = new RPT.AgeReport();



                rpt.SetDataSource(dal.getDataTabl("AgeReport_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1));
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;

                groupPanel1.Visible = false;


            }

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "", db1);
            if (dt.Rows.Count <= 0 && UC_cost1.ID.Text == string.Empty && UC_Catogry1.ID.Text == string.Empty)
            {
                MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "1", db1).Rows.Count <= 0)
            {
                RPT.rpt_Confirmation rpt = new RPT.rpt_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();


                dt1 = (dal.getDataTabl("acc_statment_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1));
                dt2 = (dal.getDataTabl("begin_statment_balance_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.MinDate, UC_Branch.ID.Text, db1, Properties.Settings.Default.Currency));
                DataTable dt_currency = dal.getDataTabl_1("SELECT *  FROM " + dal.db1 + ".dbo.Wh_Currency where Currency_code = '" + Properties.Settings.Default.Currency.ToString() + "'");
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";





                // MessageBox.Show(dt2.Rows[0][0].ToString());

                ds.Tables.Add(dt1);
                ds.Tables.Add(dt2);
                ds.Tables.Add(dt_currency);




                //ds.WriteXmlSchema("schema1.xml");

                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;
                //rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["Acc_No"].Text = " '" + UC_Acc1.ID.Text + "'";
                rpt.DataDefinition.FormulaFields["Acc_Name"].Text = "'" + UC_Acc1.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Cost_No"].Text = "'" + UC_cost1.ID.Text + "'";
                //rpt.DataDefinition.FormulaFields["Cost_name"].Text = "'" + UC_cost1.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Cat_NO"].Text = "'" + UC_Catogry1.ID.Text + "'";
                //rpt.DataDefinition.FormulaFields["Cat_Name"].Text = "'" + UC_Catogry1.Desc.Text + "'";

                groupPanel1.Visible = false;

            }

            else
            {
                RPT.rpt_Confirmation rpt = new RPT.rpt_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();


                dt1 = (dal.getDataTabl("acc_statment_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, UC_Branch.ID.Text, db1));
                dt2 = (dal.getDataTabl("begin_statment_balance_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc1.ID.Text, UC_cost1.ID.Text, UC_Catogry1.ID.Text, FromDate.MinDate, UC_Branch.ID.Text, db1, Properties.Settings.Default.Currency));
                DataTable dt_currency = dal.getDataTabl_1("SELECT *  FROM " + dal.db1 + ".dbo.Wh_Currency where Currency_code = '" + Properties.Settings.Default.Currency + "'");
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";





                // MessageBox.Show(dt2.Rows[0][0].ToString());

                ds.Tables.Add(dt1);
                ds.Tables.Add(dt2);
                ds.Tables.Add(dt_currency);





                //ds.WriteXmlSchema("schema1.xml");

                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;
                //rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["Acc_No"].Text = " '" + UC_Acc1.ID.Text + "'";
                rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc1.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Cost_No"].Text = "'" + UC_cost1.ID.Text + "'";
                //rpt.DataDefinition.FormulaFields["Cost_name"].Text = "'" + UC_cost1.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Cat_NO"].Text = "'" + UC_Catogry1.ID.Text + "'";
                //rpt.DataDefinition.FormulaFields["Cat_Name"].Text = "'" + UC_Catogry1.Desc.Text + "'";

                groupPanel1.Visible = false;

            }
        }

        private void UC_Branch_Load(object sender, EventArgs e)
        {
            UC_Acc1.branchID.Text = UC_Branch.ID.Text;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "", db1);
            if (dt.Rows.Count <= 0 && UC_cost1.ID.Text == string.Empty && UC_Catogry1.ID.Text == string.Empty)
            {
                MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "1", db1).Rows.Count <= 0)
            {
                RPT.rpt_BH_Confirmation rpt = new rpt_BH_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();

                dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "'  THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + UC_Acc1.ID.Text + "' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";


                ds.Tables.Add(dt1);

                //ds.WriteXmlSchema("schema1.xml");

                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["Acc_Name"].Text = "'" + UC_Acc1.Desc.Text + "'";

                groupPanel1.Visible = false;

            }

            else
            {
                RPT.rpt_BH_Confirmation rpt = new RPT.rpt_BH_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + UC_Acc1.ID.Text + "' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";

                ds.Tables.Add(dt1);

                //ds.WriteXmlSchema("schema1.xml");

                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc1.Desc.Text + "'";

                groupPanel1.Visible = false;

            }
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "", db1);
            if (dt.Rows.Count <= 0 && UC_cost1.ID.Text == string.Empty && UC_Catogry1.ID.Text == string.Empty)
            {
                MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc1.ID.Text, "", "", "1", db1).Rows.Count <= 0)
            {
                RPT.rpt_BH_Confirmation rpt = new rpt_BH_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();

                dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "'  THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO like '" + UC_Acc1.ID.Text + "%' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";


                ds.Tables.Add(dt1);

                //ds.WriteXmlSchema("schema1.xml");

                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["Acc_Name"].Text = "'" + UC_Acc1.Desc.Text + "'";

                groupPanel1.Visible = false;

            }

            else
            {
                RPT.rpt_BH_Confirmation rpt = new RPT.rpt_BH_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + UC_Acc1.ID.Text + "' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";

                ds.Tables.Add(dt1);

                //ds.WriteXmlSchema("schema1.xml");

                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc1.Desc.Text + "'";

                groupPanel1.Visible = false;

            }
        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {

        }

        public override void Option()
        {
                  base.Option();
            groupPanel1.Visible = true;
        }

    }
}
