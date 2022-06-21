

using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
using System.IO;

using System.Text;
using System.Windows.Forms;

using Outlook = Microsoft.Office.Interop.Outlook;
using CrystalDecisions.CrystalReports.Engine;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.DataProcessing;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace Report_Pro.RPT
{
    public partial class frm_Confirmation : Form
    {
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        int currencyNo=2;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Confirmation()
        {
            InitializeComponent();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {
          
    

        }

        private DataTable  GetCurrncy()
        {
            DataTable dt = dal.getDataTabl_1(@"SELECT Currency_Code,Currency_Name,Change_Factor,User_Id,G_date,Currency_Name_e FROM Wh_Currency where Currency_Code = '" + Properties.Settings.Default.Currency + "'");
            return dt;
        }
        private DataTable GetUser()
        {
            DataTable dt = dal.getDataTabl_1(@"SELECT USER_ID,USER_NAME,Title,Title_E FROM wh_USERS where USER_ID = '" + Program.userID + "'");
            return dt;
        }

        private void RB3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            string bal = "1";
            if (RB1.Checked == true)
            { bal = "1"; }
            if (RB2.Checked == true)
            { bal = "2"; }
            if (RB3.Checked == true)
            { bal = "3"; }



            this.Cursor = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "", dal.db1);
            if (dt.Rows.Count <= 0 )
            {
                MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "1", dal.db1).Rows.Count <= 0)
            {

                DataTable dt_ch = new DataTable();
                groupPanel1.Visible = false;

                if (RB1.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' ) As X where X.DuplicateCount=1 ");
                }
                else if (RB2.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance<>0) As X where X.DuplicateCount=1");
                }
                else if (RB3.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                                       "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                                       " from daily_transaction  group by ACC_NO ) As A " +
                                       " on P.ACC_NO=A.ACC_NO " +
                                       " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance=0) As X where X.DuplicateCount=1 ");

                }

                foreach (DataRow dr in dt_ch.Rows)
                {

                    RPT.rpt_BH_Confirmation rpt = new RPT.rpt_BH_Confirmation();
                    DataSet1 ds = new DataSet1();
                    DataTable dt1 = new DataTable();



                    //dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and where A.ACC_NO = '" + dr[0].ToString() + "' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                    dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" + dr[0].ToString() +
                        "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");

                    rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";

                    ds.Tables.Add(dt1);

                  //  //ds.WriteXmlSchema("schema1.xml");

                    rpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = rpt;
                    this.Cursor = Cursors.Default;
                    rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                    rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc.Desc.Text + "'";
                    rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";

                   
                    ToWord toWord = new ToWord(Math.Abs(Math.Round(dt1.Rows[0][3].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);

                    rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";

                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.Report_P;
                    rpt.PrintToPrinter(1,false,0,15);


                    rpt.Close();
                    rpt.Dispose();
                }

            }

            else
            {
                RPT.rpt_BH_Confirmation rpt = new RPT.rpt_BH_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                //dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + UC_Acc.ID.Text + "' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" +UC_Acc.ID.Text +
                       "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");


                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";

                ds.Tables.Add(dt1);

                ////ds.WriteXmlSchema("schema1.xml");

                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                this.Cursor = Cursors.Default;
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc.Desc.Text + "'";
                rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";

                ToWord toWord = new ToWord(Math.Abs(Math.Round(dt1.Rows[0][3].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";

                groupPanel1.Visible = false;

            }



        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
          
                string bal = "1";
                if (RB1.Checked == true)
                { bal = "1"; }
                if (RB2.Checked == true)
                { bal = "2"; }
                if (RB3.Checked == true)
                { bal = "3"; }


                this.Cursor = Cursors.WaitCursor;
                DataTable dt = new DataTable();
                dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "", dal.db1);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //====== بداية طباعة الكل =========================
            if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "1", dal.db1).Rows.Count <= 0)

            {
                
               
                DataTable dt_ch = new DataTable();
                if (RB1.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount 
                    from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance  " +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' ) As X where X.DuplicateCount=1 ");
                }
                else if (RB2.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance " +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance<>0) As X where X.DuplicateCount=1");
                }
                else if (RB3.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount 
                    from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance  " +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance=0) As X where X.DuplicateCount=1 ");

                }

                foreach (DataRow dr in dt_ch.Rows)
                {
                    Reports.rpt_Confirmation rpt = new Reports.rpt_Confirmation();
                    DataTable dt1 = new DataTable();
                    DataSet1 ds = new DataSet1();


                    dt1 = dal.getDataTabl_1(@" select x.com_code,X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance 
                      from (select p.ACC_NO,LEFT(p.BRANCH_code,1) as com_code , SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A " +
                      "inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code " +
                      "where A.ACC_NO ='" + dr[0].ToString() + "' group by p.ACC_NO,LEFT(p.BRANCH_code,1)) as X " +
                      "inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 " +
                      "on x.ACC_NO=p2.acc_no " +
                      "where p2.DuplicateCount=1");

                    DataTable dt_Co = dal.getDataTabl_1(@"select * from Wh_Oiner_Comp where Company_No='"+dt1.Rows[0]["com_code"] +"'  ");

                   // ds.Tables.Add(dt1);
                    //ds.Tables.Add(dt_Co);
                    ////ds.WriteXmlSchema("schema1.xml");
                   // rpt.DataSource = ds;
                    Cursor = Cursors.Default;

                    rpt.toDate.Value = ToDate.Value.ToString("dd/MM/yyyy");
                    rpt.CoName.Value = Properties.Settings.Default.head_txt;
                    rpt.CoName_E.Value = Properties.Settings.Default.head_txt_EN;
                    rpt.balance_.Value = dt1.Rows[0]["Ending_balance"].ToString().ToDecimal().ToString("N" + dal.digits_);

                    if (dt1.Rows[0]["Ending_balance"].ToString().ToDecimal() > 0)
                    {
                        rpt.statusA.Text = "مدين بمبلغ";
                        rpt.lbl_1.Text = "مستحق ل"+ Properties.Settings.Default.head_txt;

                        rpt.statusE.Text = "Debit with";
                        rpt.lbl_2.Text = "Payable to " + Properties.Settings.Default.head_txt_EN;

                    }
                    else
                    {
                        rpt.statusA.Text = "دائن بمبلغ";
                        rpt.lbl_1.Text = "مستحق علي " + Properties.Settings.Default.head_txt;

                        rpt.statusE.Text = "Credit with";
                        rpt.lbl_2.Text = "Receivable from " + Properties.Settings.Default.head_txt_EN;

                    }


                    rpt.txtNameA.Text = dt1.Rows[0]["PAYER_NAME"].ToString();
                    rpt.txtNameE.Text = dt1.Rows[0]["payer_l_name"].ToString();
                    rpt.txtAccNo.Text = dt1.Rows[0]["Acc_no"].ToString();

                    using (MemoryStream ms_stamp = new MemoryStream((Byte[])dt_Co.Rows[0]["stamp_pic"]))
                    {
                     //   rpt.Pic2.Image = Image.FromStream(ms_stamp);
                    }
                    using (MemoryStream ms_Hpic = new MemoryStream((Byte[])dt_Co.Rows[0]["h_pic"]))
                    {
                        rpt.PicH.Image = Image.FromStream(ms_Hpic);
                    }
                    using (MemoryStream ms_Fpic = new MemoryStream((Byte[])dt_Co.Rows[0]["f_pic"]))
                    {
                        rpt.picF.Image = Image.FromStream(ms_Fpic);
                    }


                    rpt.lblUserPosition.Text = GetUser().Rows[0]["Title"].ToString();
                    rpt.lblUserName_e.Text = GetUser().Rows[0]["USER_NAME"].ToString();
                    rpt.lblUserPosition_e.Text = GetUser().Rows[0]["Title_e"].ToString();
                    rpt.lblCurrency.Text = GetCurrncy().Rows[0]["Currency_Name"].ToString();
                    rpt.lblCurrency_1.Text = GetCurrncy().Rows[0]["Currency_Name_e"].ToString();
                    ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt1.Rows[0]["Ending_balance"].ToString())), currencies[currencyNo]);
                    rpt.lblNoToText.Text = toWord.ConvertToEnglish().ToString();
                    rpt.lblNoToText_A.Text = toWord.ConvertToArabic().ToString();
                    
                    //string reportPath = "c:\\Temp\\Test.pdf";
                    //PdfExportOptions pdfOptions = rpt.ExportOptions.Pdf;
                    //pdfOptions.PasswordSecurityOptions.PermissionsPassword = "123";
                    //pdfOptions.DocumentOptions.Application = "Test Application";
                    //pdfOptions.DocumentOptions.Author = "DX Documentation Team";
                    //pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF";
                    //pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString();
                    //pdfOptions.DocumentOptions.Subject = "Document Subject";
                    //pdfOptions.DocumentOptions.Title = "Document Title";
                    //rpt.ExportToPdf(reportPath, pdfOptions);

                    rpt.Print();
      
                }
                groupPanel1.Visible = false;
            }
            //====== نهاية طباعة الكل =========================

            //====== بداية طباعة المصادقات الفردية =========================

            else
            {
                Reports.rpt_Confirmation rpt = new Reports.rpt_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                
                dt1 = dal.getDataTabl_1(@" select x.com_code,X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO,LEFT(p.BRANCH_code,1) as com_code , SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance " +
                        "from daily_transaction as A " +
                        "inner join payer2 as P " +
                        "on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code " +
                        "where A.ACC_NO ='" + UC_Acc.ID.Text +
                       "' group by p.ACC_NO ,LEFT(p.BRANCH_code,1)) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");

                DataTable dt_Co = dal.getDataTabl_1(@"select * from Wh_Oiner_Comp where Company_No='" + dt1.Rows[0]["com_code"] + "'  ");

                //ds.Tables.Add(dt1);
                //ds.Tables.Add(dt_Co);
                //rpt.DataSource = ds;
                ////ds.WriteXmlSchema("schema1.xml");
                Cursor = Cursors.Default;
                rpt.toDate.Value = ToDate.Value.ToString("dd/MM/yyyy");
                rpt.CoName.Value = Properties.Settings.Default.head_txt;
                rpt.CoName_E.Value = Properties.Settings.Default.head_txt_EN;
                rpt.balance_.Value = dt1.Rows[0]["Ending_balance"].ToString().ToDecimal().ToString("N" + dal.digits_);

                if (dt1.Rows[0]["Ending_balance"].ToString().ToDecimal() > 0)
                {
                    rpt.statusA.Text = "مدين بمبلغ";
                    rpt.lbl_1.Text = "مستحق ل" + Properties.Settings.Default.head_txt;

                    rpt.statusE.Text = "Debit with";
                    rpt.lbl_2.Text = "Payable to " + Properties.Settings.Default.head_txt_EN;

                }
                else
                {
                    rpt.statusA.Text = "دائن بمبلغ";
                    rpt.lbl_1.Text = "مستحق علي " + Properties.Settings.Default.head_txt;

                    rpt.statusE.Text = "Credit with";
                    rpt.lbl_2.Text = "Receivable from " + Properties.Settings.Default.head_txt_EN;

                }


                rpt.txtNameA.Text = dt1.Rows[0]["PAYER_NAME"].ToString();
                rpt.txtNameE.Text = dt1.Rows[0]["payer_l_name"].ToString();
                rpt.txtAccNo.Text = dt1.Rows[0]["Acc_no"].ToString();


                using (MemoryStream mStream = new MemoryStream((Byte[])dt_Co.Rows[0]["stamp_pic"]))
                {
                    rpt.Pic2.Image = Image.FromStream(mStream);
                }

                using (MemoryStream ms_Hpic = new MemoryStream((Byte[])dt_Co.Rows[0]["h_pic"]))
                {
                    rpt.PicH.Image = Image.FromStream(ms_Hpic);
                }
                using (MemoryStream ms_Fpic = new MemoryStream((Byte[])dt_Co.Rows[0]["f_pic"]))
                {
                    rpt.picF.Image = Image.FromStream(ms_Fpic);
                }



                rpt.lblUserName.Text = GetUser().Rows[0]["USER_NAME"].ToString();
                rpt.lblUserPosition.Text = GetUser().Rows[0]["Title"].ToString();
                rpt.lblUserName_e.Text = GetUser().Rows[0]["USER_NAME"].ToString();
                rpt.lblUserPosition_e.Text = GetUser().Rows[0]["Title_e"].ToString();
                rpt.lblCurrency.Text = GetCurrncy().Rows[0]["Currency_Name"].ToString();
                rpt.lblCurrency_1.Text = GetCurrncy().Rows[0]["Currency_Name_e"].ToString();

                ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt1.Rows[0]["Ending_balance"].ToString())), currencies[currencyNo]);
                rpt.lblNoToText.Text = toWord.ConvertToEnglish().ToString();
                rpt.lblNoToText_A.Text = toWord.ConvertToArabic().ToString();
                //string reportPath = "c:\\Temp\\Test.pdf";
                //PdfExportOptions pdfOptions = rpt.ExportOptions.Pdf;
                //pdfOptions.PasswordSecurityOptions.PermissionsPassword = "123";
                //pdfOptions.DocumentOptions.Application = "Test Application";
                //pdfOptions.DocumentOptions.Author = "DX Documentation Team";
                //pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF";
                //pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString();
                //pdfOptions.DocumentOptions.Subject = "Document Subject";
                //pdfOptions.DocumentOptions.Title = "Document Title";
                //rpt.ExportToPdf(reportPath, pdfOptions);
                rpt.ShowPreview();
                groupPanel1.Visible = false;

            }



            }

        private void frm_Confirmation_Load(object sender, EventArgs e)
        {
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.s));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Bahrain));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Oman));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Qatar));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Kuwait));

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
                case "QR":
                    currencyNo = 7;
                    break;
                case "KD":
                    currencyNo = 8;
                    break;
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           
                string bal = "1";
                if (RB1.Checked == true)
                { bal = "1"; }
                if (RB2.Checked == true)
                { bal = "2"; }
                if (RB3.Checked == true)
                { bal = "3"; }



                this.Cursor = Cursors.WaitCursor;
                DataTable dt = new DataTable();
                dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "", dal.db1);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "1", dal.db1).Rows.Count <= 0)
            {

                DataTable dt_ch = new DataTable();


                if (RB1.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' ) As X where X.DuplicateCount=1 ");
                }
                else if (RB2.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance<>0) As X where X.DuplicateCount=1");
                }
                else if (RB3.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                                       "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                                       " from daily_transaction  group by ACC_NO ) As A " +
                                       " on P.ACC_NO=A.ACC_NO " +
                                       " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance=0) As X where X.DuplicateCount=1 ");

                }

                FolderBrowserDialog fd1 = new FolderBrowserDialog();

                // Show the FolderBrowserDialog.
                DialogResult result = fd1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string folderName = fd1.SelectedPath;
                }
                else
                {
                    return;
                }

                   
                foreach (DataRow dr in dt_ch.Rows)
                    {

                    string fName = "";
                    if (dr[2].ToString() == "")
                    {
                        fName=dr[1].ToString();
                    }
                    else
                    {
                        fName = dr[2].ToString();
                    }
                    RPT.rpt_BH_Confirmation rpt = new rpt_BH_Confirmation();
                        DataSet1 ds = new DataSet1();
                        DataTable dt1 = new DataTable();
                        //dt1 = dal.getDataTabl_1(@"select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + dr[0].ToString() + "' group by p.ACC_NO");
                       dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" + dr[0].ToString() +
                        "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");

                        rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";
                        ds.Tables.Add(dt1);
                       // //ds.WriteXmlSchema("schema1.xml");
                        rpt.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = rpt;

                    ToWord toWord = new ToWord(Math.Abs(Math.Round(dt1.Rows[0][3].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
                    rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";

                    rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                    rpt.DataDefinition.FormulaFields["Acc_Name"].Text = "'" + UC_Acc.Desc.Text + "'";
                    rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";
                    //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, ());
                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, (fd1.SelectedPath + "\\" + fName + ".pdf"));
                    //rpt.PrintOptions.PrinterName = Properties.Settings.Default.Report_P;
                    //rpt.PrintToPrinter(1, false, 0, 15);

                    this.Cursor = Cursors.Default;
                     
                        groupPanel1.Visible = false;
                    rpt.Close();
                    rpt.Dispose();
                    }
                
                                }

                else
                {
                    RPT.rpt_BH_Confirmation rpt = new RPT.rpt_BH_Confirmation();
                    DataSet1 ds = new DataSet1();
                    DataTable dt1 = new DataTable();



                    //dt1 = dal.getDataTabl_1(@"select p.ACC_NO,p.PAYER_NAME,p.payer_l_name, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + UC_Acc.ID.Text + "' group by p.ACC_NO, p.PAYER_NAME, p.payer_l_name");
                dt1 = dal.getDataTabl_1(@"
                        select X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance from 
                        (select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO ='" + UC_Acc.ID.Text + 
                         "' group by p.ACC_NO) as X inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 on x.ACC_NO=p2.acc_no where p2.DuplicateCount=1");

                rpt.DataDefinition.FormulaFields["OB_studs"].Text = "";

                    ds.Tables.Add(dt1);

                    ////ds.WriteXmlSchema("schema1.xml");

                    rpt.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = rpt;
                    this.Cursor = Cursors.Default;
                    rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("dd/MM/yyyy") + "'";
                    rpt.DataDefinition.FormulaFields["Acc_name"].Text = " '" + UC_Acc.Desc.Text + "'";
                    rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";

                    groupPanel1.Visible = false;

                }



            }
//--+++++----+++++
        private void buttonX2_Click(object sender, EventArgs e)
        {

            string bal = "1";
            if (RB1.Checked == true)
            { bal = "1"; }
            if (RB2.Checked == true)
            { bal = "2"; }
            if (RB3.Checked == true)
            { bal = "3"; }



            this.Cursor = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "", dal.db1);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FolderBrowserDialog fd1 = new FolderBrowserDialog();

            DialogResult result = fd1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = fd1.SelectedPath;
            }
            else
            {
                return;
            }

            if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "1", dal.db1).Rows.Count <= 0)
            {

                DataTable dt_ch = new DataTable();


                if (RB1.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' ) As X where X.DuplicateCount=1 ");
                }
                else if (RB2.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                    "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                    " from daily_transaction  group by ACC_NO ) As A " +
                    " on P.ACC_NO=A.ACC_NO " +
                    " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance<>0) As X where X.DuplicateCount=1");
                }
                else if (RB3.Checked)
                {
                    dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                                       "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                                       " from daily_transaction  group by ACC_NO ) As A " +
                                       " on P.ACC_NO=A.ACC_NO " +
                                       " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance=0) As X where X.DuplicateCount=1 ");

                }


                groupPanel1.Visible = false;

                foreach (DataRow dr in dt_ch.Rows)
                {




                    string fName = "";
                    if (dr[2].ToString() == "")
                    {
                        fName = dr["acc_no"].ToString() + " - " + dr[1].ToString();
                        string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                        Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
                        fName = r.Replace(fName, "");

                    }
                    else
                    {
                        fName = dr["acc_no"].ToString() + " - " + dr[2].ToString();
                        string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                        Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
                        fName = r.Replace(fName, "");
                        //fName = dr["acc_no"].ToString() + " - " + dr[2].ToString().Replace('/', '-');
                    }
                    Reports.rpt_Confirmation rpt = new Reports.rpt_Confirmation();
                    //DataSet1 ds = new DataSet1();
                    DataTable dt1 = new DataTable();
                    //dt1 = dal.getDataTabl_1(@"select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + dr[0].ToString() + "' group by p.ACC_NO");
                    dt1 = dal.getDataTabl_1(@" select x.com_code,X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance 
                      from (select p.ACC_NO,LEFT(p.BRANCH_code,1) as com_code , SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A " +
                        "inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code " +
                        "where A.ACC_NO ='" + dr[0].ToString() + "' group by p.ACC_NO,LEFT(p.BRANCH_code,1)) as X " +
                        "inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 " +
                        "on x.ACC_NO=p2.acc_no " +
                        "where p2.DuplicateCount=1");


                    DataTable dt_Co = dal.getDataTabl_1(@"select * from Wh_Oiner_Comp where Company_No='" + dt1.Rows[0]["com_code"] + "'  ");

                    //ds.Tables.Add(dt1);
                    //ds.Tables.Add(dt_Co);
                    ////ds.WriteXmlSchema("schema1.xml");
                    //       rpt.DataSource = ds;
                    Cursor = Cursors.Default;
                    rpt.toDate.Value = ToDate.Value.ToString("dd/MM/yyyy");
                    rpt.CoName.Value = Properties.Settings.Default.head_txt;
                    rpt.CoName_E.Value = Properties.Settings.Default.head_txt_EN;
                    rpt.balance_.Value = dt1.Rows[0]["Ending_balance"].ToString().ToDecimal().ToString("N" + dal.digits_);

                    if (dt1.Rows[0]["Ending_balance"].ToString().ToDecimal() > 0)
                    {
                        rpt.statusA.Text = "مدين بمبلغ";
                        rpt.lbl_1.Text = "مستحق ل" + Properties.Settings.Default.head_txt;

                        rpt.statusE.Text = "Debit with";
                        rpt.lbl_2.Text = "Payable to " + Properties.Settings.Default.head_txt_EN;

                    }
                    else
                    {
                        rpt.statusA.Text = "دائن بمبلغ";
                        rpt.lbl_1.Text = "مستحق علي " + Properties.Settings.Default.head_txt;

                        rpt.statusE.Text = "Credit with";
                        rpt.lbl_2.Text = "Receivable from " + Properties.Settings.Default.head_txt_EN;

                    }


                    rpt.txtNameA.Text = dt1.Rows[0]["PAYER_NAME"].ToString();
                    rpt.txtNameE.Text = dt1.Rows[0]["payer_l_name"].ToString();
                    rpt.txtAccNo.Text = dt1.Rows[0]["Acc_no"].ToString();


                    //if (dt_Co.Rows[0]["stamp_pic"] == null)
                    //{
                    //    rpt.Pic2.Image = null;
                    //}
                    //else
                    //{

                    try
                    {
                        using (MemoryStream mStream = new MemoryStream((Byte[])dt_Co.Rows[0]["stamp_pic"]))
                        {
                            rpt.Pic2.Image = Image.FromStream(mStream);
                        }
                    }
                    catch (Exception)
                    {

                        rpt.Pic2.Image = null; 
                    }

                
           
                    
                   
                    using (MemoryStream ms_Hpic = new MemoryStream((Byte[])dt_Co.Rows[0]["h_pic"]))
                    {
                        rpt.PicH.Image = Image.FromStream(ms_Hpic);
                    }
                    using (MemoryStream ms_Fpic = new MemoryStream((Byte[])dt_Co.Rows[0]["f_pic"]))
                    {
                        rpt.picF.Image = Image.FromStream(ms_Fpic);
                    }



                    rpt.lblUserName.Text = GetUser().Rows[0]["USER_NAME"].ToString();
                    rpt.lblUserPosition.Text = GetUser().Rows[0]["Title"].ToString();
                    rpt.lblUserName_e.Text = GetUser().Rows[0]["USER_NAME"].ToString();
                    rpt.lblUserPosition_e.Text = GetUser().Rows[0]["Title_e"].ToString();
                    rpt.lblCurrency.Text = GetCurrncy().Rows[0]["Currency_Name"].ToString();
                    rpt.lblCurrency_1.Text = GetCurrncy().Rows[0]["Currency_Name_e"].ToString();

                    ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt1.Rows[0]["Ending_balance"].ToString())), currencies[currencyNo]);
                    rpt.lblNoToText.Text = toWord.ConvertToEnglish().ToString();
                    rpt.lblNoToText_A.Text = toWord.ConvertToArabic().ToString();
                    
                    string reportPath = fd1.SelectedPath + "\\" + fName + ".pdf";

                    PdfExportOptions pdfOptions = rpt.ExportOptions.Pdf;
                    pdfOptions.PasswordSecurityOptions.PermissionsPassword = "walidpdf";
                    pdfOptions.DocumentOptions.Application = "Test Application";
                    pdfOptions.DocumentOptions.Author = "DX Documentation Team";
                    pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF";
                    pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString();
                    pdfOptions.DocumentOptions.Subject = "Document Subject";
                    pdfOptions.DocumentOptions.Title = "Document Title";
                    rpt.ExportToPdf(reportPath, pdfOptions);
                }
            }

            else
            {
                Reports.rpt_Confirmation rpt = new Reports.rpt_Confirmation();
                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();

                groupPanel1.Visible = false;

                  string fName = UC_Acc.ID.Text + " - " + UC_Acc.Desc.Text;
                        string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                        Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
                        fName = r.Replace(fName, "");
                                                                     
                      dt1 = dal.getDataTabl_1(@" select x.com_code,X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance 
                      from (select p.ACC_NO,LEFT(p.BRANCH_code,1) as com_code , SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A " +
                        "inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code " +
                        "where A.ACC_NO ='" +UC_Acc.ID.Text + "' group by p.ACC_NO,LEFT(p.BRANCH_code,1)) as X " +
                        "inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 " +
                        "on x.ACC_NO=p2.acc_no " +
                        "where p2.DuplicateCount=1");


                    DataTable dt_Co = dal.getDataTabl_1(@"select * from Wh_Oiner_Comp where Company_No='" + dt1.Rows[0]["com_code"] + "'  ");

                   // ds.Tables.Add(dt1);
                 //   ds.Tables.Add(dt_Co);
                    ////ds.WriteXmlSchema("schema1.xml");
               //     rpt.DataSource = ds;
                    Cursor = Cursors.Default;
                    rpt.toDate.Value = ToDate.Value.ToString("dd/MM/yyyy");
                    rpt.CoName.Value = Properties.Settings.Default.head_txt;
                    rpt.CoName_E.Value = Properties.Settings.Default.head_txt_EN;
                    rpt.balance_.Value = dt1.Rows[0]["Ending_balance"].ToString().ToDecimal().ToString("N" + dal.digits_);

                if (dt1.Rows[0]["Ending_balance"].ToString().ToDecimal() > 0)
                {
                    rpt.statusA.Text = "مدين بمبلغ";
                    rpt.lbl_1.Text = "مستحق ل" + Properties.Settings.Default.head_txt;

                    rpt.statusE.Text = "Debit with";
                    rpt.lbl_2.Text = "Payable to " + Properties.Settings.Default.head_txt_EN;

                }
                else
                {
                    rpt.statusA.Text = "دائن بمبلغ";
                    rpt.lbl_1.Text = "مستحق علي " + Properties.Settings.Default.head_txt;

                    rpt.statusE.Text = "Credit with";
                    rpt.lbl_2.Text = "Receivable from " + Properties.Settings.Default.head_txt_EN;

                }

                rpt.txtNameA.Text = dt1.Rows[0]["PAYER_NAME"].ToString();
                    rpt.txtNameE.Text = dt1.Rows[0]["payer_l_name"].ToString();
                    rpt.txtAccNo.Text = dt1.Rows[0]["Acc_no"].ToString();

                using (MemoryStream mStream = new MemoryStream((Byte[])dt_Co.Rows[0]["stamp_pic"]))
                {
                    rpt.Pic2.Image = Image.FromStream(mStream);
                }

                using (MemoryStream ms_Hpic = new MemoryStream((Byte[])dt_Co.Rows[0]["h_pic"]))
                {
                    rpt.PicH.Image = Image.FromStream(ms_Hpic);
                }
                using (MemoryStream ms_Fpic = new MemoryStream((Byte[])dt_Co.Rows[0]["f_pic"]))
                {
                    rpt.picF.Image = Image.FromStream(ms_Fpic);
                }


                rpt.lblUserName.Text = GetUser().Rows[0]["USER_NAME"].ToString();
                    rpt.lblUserPosition.Text = GetUser().Rows[0]["Title"].ToString();
                    rpt.lblUserName_e.Text = GetUser().Rows[0]["USER_NAME"].ToString();
                    rpt.lblUserPosition_e.Text = GetUser().Rows[0]["Title_e"].ToString();
                    rpt.lblCurrency.Text = GetCurrncy().Rows[0]["Currency_Name"].ToString();
                    rpt.lblCurrency_1.Text = GetCurrncy().Rows[0]["Currency_Name_e"].ToString();

                    ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt1.Rows[0]["Ending_balance"].ToString())), currencies[currencyNo]);
                    rpt.lblNoToText.Text = toWord.ConvertToEnglish().ToString();
                    rpt.lblNoToText_A.Text = toWord.ConvertToArabic().ToString();
                    string reportPath = fd1.SelectedPath + "\\" + fName + ".pdf";
                    PdfExportOptions pdfOptions = rpt.ExportOptions.Pdf;
                    pdfOptions.PasswordSecurityOptions.PermissionsPassword = "walidpdf";
                    pdfOptions.DocumentOptions.Application = "Test Application";
                    pdfOptions.DocumentOptions.Author = "DX Documentation Team";
                    pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF";
                    pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString();
                    pdfOptions.DocumentOptions.Subject = "Document Subject";
                    pdfOptions.DocumentOptions.Title = "Document Title";
                    rpt.ExportToPdf(reportPath, pdfOptions);
                }
            MessageBox.Show("تم تصدير المستندات بنجاح", "تصدير", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }




        //================================================================//
        private void btn_Email_Click(object sender, EventArgs e)
        {

            

                string bal = "1";
                if (RB1.Checked == true)
                { bal = "1"; }
                if (RB2.Checked == true)
                { bal = "2"; }
                if (RB3.Checked == true)
                { bal = "3"; }



                this.Cursor = Cursors.WaitCursor;
                DataTable dt = new DataTable();
                dt = dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "", dal.db1);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("لم يتم اختيار حساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FolderBrowserDialog fd1 = new FolderBrowserDialog();

                DialogResult result = fd1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string folderName = fd1.SelectedPath;
                }
                else
                {
                    return;
                }

                if (dal.getDataTabl("GetAcc_", UC_Branch.ID.Text, UC_Acc.ID.Text, "", "", "1", dal.db1).Rows.Count <= 0)
                {

                    DataTable dt_ch = new DataTable();


                    if (RB1.Checked)
                    {
                        dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                        "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                        " from daily_transaction  group by ACC_NO ) As A " +
                        " on P.ACC_NO=A.ACC_NO " +
                        " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' ) As X where X.DuplicateCount=1 ");
                    }
                    else if (RB2.Checked)
                    {
                        dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                        "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                        " from daily_transaction  group by ACC_NO ) As A " +
                        " on P.ACC_NO=A.ACC_NO " +
                        " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance<>0) As X where X.DuplicateCount=1");
                    }
                    else if (RB3.Checked)
                    {
                        dt_ch = dal.getDataTabl_1(@"select * from (select p.acc_no,PAYER_NAME,payer_l_name,A.Ending_balance ,ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount from payer2 As P
                    inner join (select  acc_no
                    , SUM(CASE WHEN cast(g_date as date) >= '" + ToDate.MinDate.ToString("yyyy-MM-dd") + "' and cast(g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") +
                                           "' THEN meno - loh ELSE 0 END) AS Ending_balance" +
                                           " from daily_transaction  group by ACC_NO ) As A " +
                                           " on P.ACC_NO=A.ACC_NO " +
                                           " where p.ACC_NO like '" + UC_Acc.ID.Text + "%' and A.Ending_balance=0) As X where X.DuplicateCount=1 ");

                    }


                    groupPanel1.Visible = false;

                    foreach (DataRow dr in dt_ch.Rows)
                    {
                    string fName = "";
                    if (dr[2].ToString() == "")
                    {
                        fName = dr["acc_no"].ToString() + " - " + dr[1].ToString();
                        string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                        Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
                        fName = r.Replace(fName, "");

                    }
                    else
                    {
                        fName = dr["acc_no"].ToString() + " - " + dr[2].ToString();
                        string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                        Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
                        fName = r.Replace(fName, "");
                        //fName = dr["acc_no"].ToString() + " - " + dr[2].ToString().Replace('/', '-');
                    }

                    Reports.rpt_Confirmation rpt = new Reports.rpt_Confirmation();
                        //DataSet1 ds = new DataSet1();
                        DataTable dt1 = new DataTable();
                        //dt1 = dal.getDataTabl_1(@"select p.ACC_NO, SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from " + dal.db1 + ".dbo.daily_transaction as A inner join " + dal.db1 + ".dbo.payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code where A.ACC_NO = '" + dr[0].ToString() + "' group by p.ACC_NO");
                        dt1 = dal.getDataTabl_1(@" select x.com_code,X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance 
                      from (select p.ACC_NO,LEFT(p.BRANCH_code,1) as com_code , SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A " +
                            "inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code " +
                            "where A.ACC_NO ='" + dr[0].ToString() + "' group by p.ACC_NO,LEFT(p.BRANCH_code,1)) as X " +
                            "inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 " +
                            "on x.ACC_NO=p2.acc_no " +
                            "where p2.DuplicateCount=1");


                        DataTable dt_Co = dal.getDataTabl_1(@"select * from Wh_Oiner_Comp where Company_No='" + dt1.Rows[0]["com_code"] + "'  ");

                        //ds.Tables.Add(dt1);
                        //ds.Tables.Add(dt_Co);
                        ////ds.WriteXmlSchema("schema1.xml");
                        //       rpt.DataSource = ds;
                        Cursor = Cursors.Default;
                        rpt.toDate.Value = ToDate.Value.ToString("dd/MM/yyyy");
                        rpt.CoName.Value = Properties.Settings.Default.head_txt;
                        rpt.CoName_E.Value = Properties.Settings.Default.head_txt_EN;
                        rpt.balance_.Value = dt1.Rows[0]["Ending_balance"].ToString().ToDecimal().ToString("N" + dal.digits_);

                    if (dt1.Rows[0]["Ending_balance"].ToString().ToDecimal() > 0)
                    {
                        rpt.statusA.Text = "مدين بمبلغ";
                        rpt.lbl_1.Text = "مستحق ل" + Properties.Settings.Default.head_txt;

                        rpt.statusE.Text = "Debit with";
                        rpt.lbl_2.Text = "Payable to " + Properties.Settings.Default.head_txt_EN;

                    }
                    else
                    {
                        rpt.statusA.Text = "دائن بمبلغ";
                        rpt.lbl_1.Text = "مستحق علي " + Properties.Settings.Default.head_txt;

                        rpt.statusE.Text = "Credit with";
                        rpt.lbl_2.Text = "Receivable from " + Properties.Settings.Default.head_txt_EN;

                    }

                    rpt.txtNameA.Text = dt1.Rows[0]["PAYER_NAME"].ToString();
                        rpt.txtNameE.Text = dt1.Rows[0]["payer_l_name"].ToString();
                        rpt.txtAccNo.Text = dt1.Rows[0]["Acc_no"].ToString();

                        using (MemoryStream mStream = new MemoryStream((Byte[])dt_Co.Rows[0]["stamp_pic"]))
                        {
                            rpt.Pic2.Image = Image.FromStream(mStream);
                        }

                        using (MemoryStream ms_Hpic = new MemoryStream((Byte[])dt_Co.Rows[0]["h_pic"]))
                        {
                            rpt.PicH.Image = Image.FromStream(ms_Hpic);
                        }
                        using (MemoryStream ms_Fpic = new MemoryStream((Byte[])dt_Co.Rows[0]["f_pic"]))
                        {
                            rpt.picF.Image = Image.FromStream(ms_Fpic);
                        }



                        rpt.lblUserName.Text = GetUser().Rows[0]["USER_NAME"].ToString();
                        rpt.lblUserPosition.Text = GetUser().Rows[0]["Title"].ToString();
                        rpt.lblUserName_e.Text = GetUser().Rows[0]["USER_NAME"].ToString();
                        rpt.lblUserPosition_e.Text = GetUser().Rows[0]["Title_e"].ToString();
                        rpt.lblCurrency.Text = GetCurrncy().Rows[0]["Currency_Name"].ToString();
                        rpt.lblCurrency_1.Text = GetCurrncy().Rows[0]["Currency_Name_e"].ToString();

                        ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt1.Rows[0]["Ending_balance"].ToString())), currencies[currencyNo]);
                        rpt.lblNoToText.Text = toWord.ConvertToEnglish().ToString();
                        rpt.lblNoToText_A.Text = toWord.ConvertToArabic().ToString();
                        string reportPath = fd1.SelectedPath + "\\" + fName + ".pdf";
                        PdfExportOptions pdfOptions = rpt.ExportOptions.Pdf;
                        pdfOptions.PasswordSecurityOptions.PermissionsPassword = "walidpdf";
                        pdfOptions.DocumentOptions.Application = "Test Application";
                        pdfOptions.DocumentOptions.Author = "DX Documentation Team";
                        pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF";
                        pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString();
                        pdfOptions.DocumentOptions.Subject = "Document Subject";
                        pdfOptions.DocumentOptions.Title = "Document Title";
                        rpt.ExportToPdf(reportPath, pdfOptions);
                    }
                }

                else
                {
                    Reports.rpt_Confirmation rpt = new Reports.rpt_Confirmation();
                    DataSet1 ds = new DataSet1();
                    DataTable dt1 = new DataTable();

                    groupPanel1.Visible = false;
                string fName = UC_Acc.ID.Text + " - " + UC_Acc.Desc.Text;
                string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
                fName = r.Replace(fName, "");

                dt1 = dal.getDataTabl_1(@" select x.com_code,X.Acc_no,p2.PAYER_NAME,p2.payer_l_name,X.Ending_balance 
                      from (select p.ACC_NO,LEFT(p.BRANCH_code,1) as com_code , SUM(CASE WHEN cast(A.g_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' THEN meno - loh ELSE 0 END) AS Ending_balance from daily_transaction as A " +
                        "inner join payer2 as P on a.ACC_NO = p.ACC_NO and a.BRANCH_code = p.BRANCH_code " +
                        "where A.ACC_NO ='" + UC_Acc.ID.Text + "' group by p.ACC_NO,LEFT(p.BRANCH_code,1)) as X " +
                        "inner join (select acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount from payer2 ) as p2 " +
                        "on x.ACC_NO=p2.acc_no " +
                        "where p2.DuplicateCount=1");


                    DataTable dt_Co = dal.getDataTabl_1(@"select * from Wh_Oiner_Comp where Company_No='" + dt1.Rows[0]["com_code"] + "'  ");

                    // ds.Tables.Add(dt1);
                    //   ds.Tables.Add(dt_Co);
                    ////ds.WriteXmlSchema("schema1.xml");
                    //     rpt.DataSource = ds;
                    Cursor = Cursors.Default;
                    rpt.toDate.Value = ToDate.Value.ToString("dd/MM/yyyy");
                    rpt.CoName.Value = Properties.Settings.Default.head_txt;
                    rpt.CoName_E.Value = Properties.Settings.Default.head_txt_EN;
                    rpt.balance_.Value = dt1.Rows[0]["Ending_balance"].ToString().ToDecimal().ToString("N" + dal.digits_);
                if (dt1.Rows[0]["Ending_balance"].ToString().ToDecimal() > 0)
                {
                    rpt.statusA.Text = "مدين بمبلغ";
                    rpt.lbl_1.Text = "مستحق ل" + Properties.Settings.Default.head_txt;

                    rpt.statusE.Text = "Debit with";
                    rpt.lbl_2.Text = "Payable to " + Properties.Settings.Default.head_txt_EN;

                }
                else
                {
                    rpt.statusA.Text = "دائن بمبلغ";
                    rpt.lbl_1.Text = "مستحق علي " + Properties.Settings.Default.head_txt;

                    rpt.statusE.Text = "Credit with";
                    rpt.lbl_2.Text = "Receivable from " + Properties.Settings.Default.head_txt_EN;

                }

                rpt.txtNameA.Text = dt1.Rows[0]["PAYER_NAME"].ToString();
                    rpt.txtNameE.Text = dt1.Rows[0]["payer_l_name"].ToString();
                    rpt.txtAccNo.Text = dt1.Rows[0]["Acc_no"].ToString();

                    using (MemoryStream mStream = new MemoryStream((Byte[])dt_Co.Rows[0]["stamp_pic"]))
                    {
                        rpt.Pic2.Image = Image.FromStream(mStream);
                    }

                    using (MemoryStream ms_Hpic = new MemoryStream((Byte[])dt_Co.Rows[0]["h_pic"]))
                    {
                        rpt.PicH.Image = Image.FromStream(ms_Hpic);
                    }
                    using (MemoryStream ms_Fpic = new MemoryStream((Byte[])dt_Co.Rows[0]["f_pic"]))
                    {
                        rpt.picF.Image = Image.FromStream(ms_Fpic);
                    }


                    rpt.lblUserName.Text = GetUser().Rows[0]["USER_NAME"].ToString();
                    rpt.lblUserPosition.Text = GetUser().Rows[0]["Title"].ToString();
                    rpt.lblUserName_e.Text = GetUser().Rows[0]["USER_NAME"].ToString();
                    rpt.lblUserPosition_e.Text = GetUser().Rows[0]["Title_e"].ToString();
                    rpt.lblCurrency.Text = GetCurrncy().Rows[0]["Currency_Name"].ToString();
                    rpt.lblCurrency_1.Text = GetCurrncy().Rows[0]["Currency_Name_e"].ToString();

                    ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt1.Rows[0]["Ending_balance"].ToString())), currencies[currencyNo]);
                    rpt.lblNoToText.Text = toWord.ConvertToEnglish().ToString();
                    rpt.lblNoToText_A.Text = toWord.ConvertToArabic().ToString();
                    string reportPath = fd1.SelectedPath + "\\" + fName + ".pdf";
                    PdfExportOptions pdfOptions = rpt.ExportOptions.Pdf;
                    pdfOptions.PasswordSecurityOptions.PermissionsPassword = "walidpdf";
                    pdfOptions.DocumentOptions.Application = "Test Application";
                    pdfOptions.DocumentOptions.Author = "DX Documentation Team";
                    pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF";
                    pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString();
                    pdfOptions.DocumentOptions.Subject = "Document Subject";
                    pdfOptions.DocumentOptions.Title = "Document Title";
                // rpt.ExportToPdf(reportPath, pdfOptions);
                  rpt.CreateDocument();
                Outlook.Application oApp = new Outlook.Application();
                Outlook.MailItem oMsg = (Outlook.MailItem)(oApp.CreateItem(Outlook.OlItemType.olMailItem));

                MemoryStream mem = new MemoryStream();
                rpt.ExportToPdf(mem);
                //mem.Seek(0, SeekOrigin.Begin);
               
                oMsg.To = "";
                oMsg.Subject = "Test";
               // oMsg.BodyFormat = Outlook.OlBodyFormat.olFormatHTML;
               
                //oMsg.HTMLBody = "Veuillez trouver ci-joint:" + "<br />" + oMsg.HTMLBody;
                oMsg.Attachments.Add(mem);
                oMsg.Display(true);

            }
            MessageBox.Show("تم تصدير المستندات بنجاح", "تصدير", MessageBoxButtons.OK, MessageBoxIcon.Information);


          

           



        }

        }
    }
