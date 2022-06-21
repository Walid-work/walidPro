using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Report_Pro.CTR
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
            rpt_cash_transaction rpt = new rpt_cash_transaction();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            tabControl1.SelectedTab = tabItem1;
            dt1 = dal.getDataTabl_1(@"SELECT D.ACC_NO,P.Payer_name,D.BRANCH_code,
                    branch_name,ser_no,meno,loh,D.g_date,desc2 FROM daily_transaction as D  
                    inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code=p.BRANCH_code
                    inner join wh_BRANCHES As B on D.BRANCH_code = B.ACC_BRANCH
                    where B.BRANCH_code = '" + Branch.ID.Text + "' and  d.acc_no like '123%' and  convert(varchar,D.g_date,111)  between '" +
                    FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'CR' ");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
            rpt.DataDefinition.FormulaFields["Titel_"].Text = "'سندات قبض نقدية'";
            //rpt.DataDefinition.FormulaFields["branch_E_"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            crystalReportViewer1.ReportSource = rpt;

        }

        private void btn_bank_recet_Click(object sender, EventArgs e)
        {
            rpt_cash_transaction rpt = new rpt_cash_transaction();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();
            tabControl1.SelectedTab = tabItem1;
            dt1 = dal.getDataTabl_1(@"SELECT D.ACC_NO,P.Payer_name,D.BRANCH_code,
                    branch_name,ser_no,meno,loh,D.g_date,desc2 FROM daily_transaction as D  
                    inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code=p.BRANCH_code
                    inner join wh_BRANCHES As B on D.BRANCH_code = B.ACC_BRANCH
                   where B.BRANCH_code = '" + Branch.ID.Text + "' and   d.acc_no like '123%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'BR'");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_xml");
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
            rpt_cash_transaction rpt = new rpt_cash_transaction();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();
            tabControl1.SelectedTab = tabItem1;
            dt1 = dal.getDataTabl_1(@"SELECT D.ACC_NO,P.Payer_name,D.BRANCH_code,
                    branch_name,ser_no,meno,loh,D.g_date,desc2 FROM daily_transaction as D  
                    inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code=p.BRANCH_code
                    join wh_BRANCHES As B on D.BRANCH_code = B.ACC_BRANCH
                    where  B.BRANCH_code = '" + Branch.ID.Text + "'  and  d.acc_no like '122%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'CB'");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_xml");
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
            rpt_cash_transaction rpt = new rpt_cash_transaction();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();
            tabControl1.SelectedTab = tabItem1;
            dt1 = dal.getDataTabl_1(@"SELECT D.ACC_NO,P.Payer_name,D.BRANCH_code,
                    branch_name,ser_no,meno,loh,D.g_date,desc2 FROM daily_transaction as D  
                    inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code=p.BRANCH_code
                    join wh_BRANCHES As B on D.BRANCH_code = B.BRANCH_code          
            where  B.BRANCH_code = '" + Branch.ID.Text + "' and  d.acc_no like '32%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'CE'");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_xml");
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
            try
            {
                rpt_cash_sheet rpt = new rpt_cash_sheet();
                DataSet ds = new DataSet();
                DataTable dt_tr = new DataTable();
                tabControl1.SelectedTab = tabItem1;
                dt_tr = dal.getDataTabl_1(@"SELECT  branch_name, SUM(CASE WHEN  d.acc_no like '" + txtAcc.ID.Text + "%' and convert(varchar,D.g_date,111) > '1950-01-01' and convert(varchar,D.g_date,111) < '" + FromDate.Value.ToString("yyyy/MM/dd") + "'  THEN meno -loh ELSE 0 END) AS Begining_balance " +
                 ", (select sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100) + sum(D.TAX_OUT - D.TAX_IN) as Sales "+
                 "FROM wh_material_transaction As D " +
                 "inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code = D.Branch_code AND " +
                 "C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear " +
                 "where D.Branch_code = '" + Branch.ID.Text + "' and   D.TRANSACTION_CODE like 'xs%' and C.Payment_Type like '1%' " +
                 "and convert(varchar, D.g_date, 111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "') AS sales_ " +


                ", SUM(CASE WHEN d.acc_no like '123%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'CR'  THEN loh ELSE 0 END) AS cash_recet " +
                ", SUM(CASE WHEN d.acc_no like '123%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'BR'  THEN loh ELSE 0 END) AS bank_recet " +
                ", SUM(CASE WHEN d.acc_no like '" + txtAcc.ID.Text + "%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'CB'  THEN loh ELSE 0 END) AS bank_deposit " +
                ", SUM(CASE WHEN d.acc_no like '" + txtAcc.ID.Text + "%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'CE'  THEN loh ELSE 0 END) AS fees " +
                ", SUM(CASE WHEN d.acc_no like '" + txtAcc.ID.Text + "%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  and SOURCE_CODE like 'Xp%' THEN meno - loh ELSE 0 END) AS purchase_ " +
                ", SUM(CASE WHEN  d.acc_no like '" + txtAcc.ID.Text + "%' and convert(varchar,D.g_date,111) > '1950-01-01' and convert(varchar,D.g_date,111) <= '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  THEN meno -loh ELSE 0 END) AS End_balance " +
                "FROM daily_transaction as D "+
                "inner join wh_BRANCHES As B on D.BRANCH_code = B.ACC_BRANCH "+
                "inner join payer2 As P on D.Acc_no = P.acc_no and p.BRANCH_code = b.ACC_BRANCH "+
                "where B.BRANCH_code = '" + Branch.ID.Text + "' group by branch_name ");


                //", SUM(CASE WHEN d.acc_no like '" + txtCashNo.Text + "%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  and SOURCE_CODE like 'XS%' THEN meno - loh ELSE 0 END) AS sales_ " +

DataTable dt_detials = dal.getDataTabl_1(@"SELECT* FROM fund_Balance_Detials 
                                WHERE cast(G_date as date) ='" + ToDate.Value.ToString("yyyy-MM-dd") + "' and  branch_code = '" + Branch.ID.Text + "'");

                ds.Tables.Add(dt_tr);
                ds.Tables.Add(dt_detials);
                //ds.WriteXmlSchema("schema_xml");
                rpt.SetDataSource(ds);
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
                //rpt.DataDefinition.FormulaFields["Titel_"].Text = "'Expenses'";
                decimal balance_ = Convert.ToDecimal(dt_tr.Rows[0][1].ToString()) + Convert.ToDecimal(dt_tr.Rows[0][2].ToString()) + Convert.ToDecimal(dt_tr.Rows[0][3].ToString()) - Convert.ToDecimal(dt_tr.Rows[0][5].ToString()) - Convert.ToDecimal(dt_tr.Rows[0][6].ToString()) + Convert.ToDecimal(dt_tr.Rows[0][7].ToString());
                //MessageBox.Show(balance_.ToString());
                ToWord toWord = new ToWord(Math.Abs(Math.Round(balance_, dal.digits_)), currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["noToText"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";

                crystalReportViewer1.ReportSource = rpt;

            }
            catch { }


        }

        private void frm_cash_transaction_Load(object sender, EventArgs e)
        {
            //Branch.txtTfinal.Text = "1";
            Branch.ID.Text = Properties.Settings.Default.BranchId;
            
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

           

            getBalance();


        }


        private void getBalance()
        {
            try
            {

                DataTable dt_balance = new DataTable();
                dt_balance = dal.getDataTabl_1(@"SELECT  branch_name, 
                SUM(CASE WHEN  d.acc_no like '121%' and convert(varchar,D.g_date,111) > '1950-01-01' and convert(varchar,D.g_date,111) <= '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  THEN meno -loh ELSE 0 END) AS End_balance " +
                "FROM daily_transaction as D inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code = p.BRANCH_code " +
                "inner join wh_BRANCHES As B on D.BRANCH_code = B.BRANCH_code where B.BRANCH_code = '" + Branch.ID.Text + "' group by branch_name ");
                if (dt_balance.Rows.Count > 0)
                {
                    feesGrid1.txtBalance.Text = dt_balance.Rows[0][1].ToString();
                }
                else
                {
                    feesGrid1.txtBalance.Text = "0";
                }
            }
            catch { }

        }


        private void buttonX2_Click(object sender, EventArgs e)
        {
            rpt_Cash_Movment rpt = new rpt_Cash_Movment();
            DataSet ds = new DataSet();
            DataTable dt_tr = new DataTable();
            tabControl1.SelectedTab = tabItem1;
            dt_tr = dal.getDataTabl_1(@"SELECT  wh_short_name as branch_name, SUM(CASE WHEN  d.acc_no like '121%' and convert(varchar,D.g_date,111) > '1950-01-01' and cast(D.g_date as date) < '" + FromDate.Value.ToString("yyyy/MM/dd") + "'  THEN meno -loh ELSE 0 END) AS Begining_balance " +
           ", round(SUM(CASE WHEN d.acc_no like '123%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  and SOURCE_CODE like 'XS%' THEN meno - loh ELSE 0 END), 0) AS credit_sales " +

           ", SUM(CASE WHEN d.acc_no like '121%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  and SOURCE_CODE like 'XS%' THEN meno - loh ELSE 0 END) AS sales_ " +
            ", SUM(CASE WHEN d.acc_no like '123%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 in('CR','BR')  THEN loh ELSE 0 END) AS cash_recet " +
            ", SUM(CASE WHEN d.acc_no like '123%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'BR'  THEN loh ELSE 0 END) AS bank_recet " +
            ", SUM(CASE WHEN d.acc_no like '121%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'CB'  THEN loh ELSE 0 END)+SUM(CASE WHEN d.acc_no like '123%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 ='BR'  THEN loh ELSE 0 END) AS bank_deposit " +
            ", SUM(CASE WHEN d.acc_no like '121%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and Sanad_type2 = 'CE'  THEN loh ELSE 0 END) AS fees " +
            ", SUM(CASE WHEN d.acc_no like '121%' and convert(varchar,D.g_date,111) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  and SOURCE_CODE like 'Xp%' THEN loh-meno ELSE 0 END) AS purchase_ " +

            "FROM daily_transaction as D inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code = p.BRANCH_code " +
            "inner join wh_BRANCHES As B on D.BRANCH_code = B.BRANCH_code where B.notes='مبيعات' and  B.BRANCH_code like '" + Branch.ID.Text + "%' group by wh_short_name  ");
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

                crystalReportViewer1.ReportSource = rpt;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            DataTable dt_ = dal.getDataTabl_1(@"SELECT pass_id,Description,Password  FROM tblPassword where pass_id='pass2' and Password='" + textBox1.Text + "' ");
            if (dt_.Rows.Count > 0)
            {
                buttonX2.Visible = true;
                buttonX5.Visible = true;
                btn_ReportFundDetials.Visible = true;
            }
            else
            {
                buttonX2.Visible = false;
                buttonX5.Visible = false;
                btn_ReportFundDetials.Visible = false;
            }




        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frm_Cash_Receipt frm = new frm_Cash_Receipt();
            frm.ShowDialog();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frm_cash_transaction_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            //Frm_Config frm = new Frm_Config();
            //frm.ShowDialog();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            frm_Update_Sanadtype_2 frm = new frm_Update_Sanadtype_2();
            frm.ShowDialog();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {

            //frm_Print_invoice frm = new frm_Print_invoice();
            //frm.ShowDialog();
//           
           

            

        }

        private void btn_Balance_Deatials_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabItem2;
        }

        private void frm_cash_transaction_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void tabControlPanel2_Enter(object sender, EventArgs e)
        {
            getBalance();
        }

        private void Branch_Load(object sender, EventArgs e)
        {
            try
            {
                txtAcc.ID.Text = dal.GetCell_1(@"select Cash_acc_no from wh_BRANCHES where Branch_code = '" + Branch.ID.Text + "'").ToString();
            }
            catch
            {

            }
            getBalance();
            gettData_dt();
            feesGrid1.total_inv();
        }

        private void btnSaveDetials_Click(object sender, EventArgs e)
        {
            DataTable dt_getData = dal.getDataTabl_1(@"select * from fund_Balance_Detials where branch_code = '"+Branch.ID.Text+"' and cast(G_date as date)='"+ToDate.Value.ToString("yyyy-MM-dd")+"' ");
            if (dt_getData.Rows.Count > 0)
            {
                SqlCommand cmd = dal.sqlconn_1.CreateCommand();
                SqlTransaction trans;
                trans = dal.sqlconn_1.BeginTransaction();
                cmd.Connection = dal.sqlconn_1;
                cmd.Transaction = trans;
                try
                {
                    //cmd.CommandText = @"DELETE FROM fund_Balance_Detials WHERE branch_code='" + Branch.ID.Text + "' and cast (G_date as date )='" + ToDate.Value.ToString("yyyy-MM-dd") + "'";
                    cmd.CommandText = @"delete  FROM fund_Balance_Detials WHERE branch_code='" + Branch.ID.Text + "' and cast(G_date as date) = '" + ToDate.Value.ToString("yyyy-MM-dd") + "'";
                    cmd.ExecuteNonQuery();
                    foreach (FeesRow r in feesGrid1.flowLayoutPanel1.Controls)
                    {                    


                        if (r.txtamount.Value != 0 )
                        { 
                            if(r.txtDiscription.Text.Trim() == string.Empty)
                            {
                                MessageBox.Show(dal.rm.GetString("msgError") + "Description", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return ;
                            }
                            if (dal.IsDateTime( r.txt_R_Date.Text) == false)
                            {
                                MessageBox.Show(dal.rm.GetString("msgError") + "Date", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (r.txtType.Text.Trim() == string.Empty)
                            {
                                MessageBox.Show(dal.rm.GetString("msgError") + "Type", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            cmd.CommandText=@"INSERT INTO fund_Balance_Detials        
                            (branch_code,G_date,amount,type,descripstion,d_date,notes)
                            values ('" + Branch.ID.Text + "','" + ToDate.Value.ToString("yyyy/MM/dd") + "','" + r.txtamount.Text + "','" + r.txtType.Text + "','" + r.txtDiscription.Text + "','" + r.txt_R_Date.Value.ToString("yyyy/MM/dd") + "','" + r.txtNote.Text + "')";
                            cmd.ExecuteNonQuery();

                        }

                    }
                    trans.Commit();
                    MessageBox.Show(dal.rm.GetString("msgEdit", dal.cul), dal.rm.GetString("msgEdit_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dal.sqlconn_1.Close();
                }

            }
            else { 
                foreach (FeesRow r in feesGrid1.flowLayoutPanel1.Controls)
                {

                    if (r.txtamount.Value > 0 && r.txtDiscription.Text != string.Empty)
                    {
                        dal.Execute_1(@"INSERT INTO fund_Balance_Detials        
                            (branch_code,G_date,amount,type,descripstion,d_date,notes)
                            values ('" + Branch.ID.Text + "','" + ToDate.Value.ToString("yyyy/MM/dd") + "','" + r.txtamount.Text + "','" + r.txtType.Text + "','" + r.txtDiscription.Text + "','" + r.txt_R_Date.Value.ToString("yyyy/MM/dd") + "','" + r.txtNote.Text + "')");


                    }

                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            getlastData_dt();
                    }

        private void getlastData_dt()
        {
            DataTable dt_Copy = dal.getDataTabl_1(@"SELECT* FROM fund_Balance_Detials AS a
                                WHERE a.G_date = ( SELECT MAX(b.G_date)
                                FROM fund_Balance_Detials AS b
                                WHERE a.branch_code = b.branch_code) and  A.branch_code = '" + Branch.ID.Text + "'");
            feesGrid1.flowLayoutPanel1.Controls.Clear();
            if (dt_Copy.Rows.Count > 0)
            {
                int i = 0;
               
                foreach (DataRow row_ in dt_Copy.Rows)
                {


                    CTR.FeesRow rw = new CTR.FeesRow();
                    rw.Ser.Text = (i + 1).ToString();
                    rw.txtamount.Text = dt_Copy.Rows[i]["amount"].ToString();
                    rw.txtType.Text = dt_Copy.Rows[i]["type"].ToString();
                    rw.txtDiscription.Text = dt_Copy.Rows[i]["descripstion"].ToString();
                    rw.txt_R_Date.Text = dt_Copy.Rows[i]["d_date"].ToString();
                    rw.txtNote.Text = dt_Copy.Rows[i]["notes"].ToString();
                    feesGrid1.flowLayoutPanel1.Controls.Add(rw);
                    rw.KeyDown += feesGrid1.r_KeyDown;
                    rw.KeyUp += feesGrid1.r_KeyUP;
                    rw.Click += feesGrid1.r_Click;
                    rw.EnabledChanged += feesGrid1.r_TextChanged;
                    rw.MouseClick += feesGrid1.r_MouseClick;

                    i = i + 1;

                }
                CTR.FeesRow r = new CTR.FeesRow();
                feesGrid1.flowLayoutPanel1.Controls.Add(r);
                r.Ser.Text = (feesGrid1.flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                r.KeyDown += feesGrid1.r_KeyDown;
                r.KeyUp += feesGrid1.r_KeyUP;
                r.Click += feesGrid1.r_Click;
                r.EnabledChanged += feesGrid1.r_TextChanged;
                r.MouseClick += feesGrid1.r_MouseClick;

            }
            else
            {

                CTR.FeesRow r = new CTR.FeesRow();
                feesGrid1.flowLayoutPanel1.Controls.Add(r);
                r.Ser.Text = (feesGrid1.flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                r.KeyDown += feesGrid1.r_KeyDown;
                r.KeyUp += feesGrid1.r_KeyUP;
                r.Click += feesGrid1.r_Click;
                r.EnabledChanged += feesGrid1.r_TextChanged;
                r.MouseClick += feesGrid1.r_MouseClick;
              
            }

        }

        private void gettData_dt()
        {
            DataTable dt1 = dal.getDataTabl_1(@"SELECT * FROM fund_Balance_Detials 
                                WHERE cast(G_date as date) ='"+ToDate.Value.ToString("yyyy-MM-dd")+"' and  branch_code = '"+Branch.ID.Text+"'");

            feesGrid1.flowLayoutPanel1.Controls.Clear();
            if (dt1.Rows.Count > 0)
            {
                int i = 0;
               
                foreach (DataRow row_ in dt1.Rows)
                {


                    CTR.FeesRow rw = new CTR.FeesRow();
                    rw.Ser.Text = (i + 1).ToString();
                    rw.txtamount.Text = dt1.Rows[i]["amount"].ToString();
                    rw.txtType.Text = dt1.Rows[i]["type"].ToString();
                    rw.txtDiscription.Text = dt1.Rows[i]["descripstion"].ToString();
                    rw.txt_R_Date.Text = dt1.Rows[i]["d_date"].ToString();
                    rw.txtNote.Text = dt1.Rows[i]["notes"].ToString();
                    feesGrid1.flowLayoutPanel1.Controls.Add(rw);
                    rw.KeyDown += feesGrid1.r_KeyDown;
                    rw.KeyUp += feesGrid1.r_KeyUP;
                    rw.Click += feesGrid1.r_Click;
                    rw.EnabledChanged += feesGrid1.r_TextChanged;
                    rw.MouseClick += feesGrid1.r_MouseClick;
                    i = i + 1;

                }
                CTR.FeesRow r = new CTR.FeesRow();
                feesGrid1.flowLayoutPanel1.Controls.Add(r);
                r.Ser.Text = (feesGrid1.flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                r.KeyDown += feesGrid1.r_KeyDown;
                r.KeyUp += feesGrid1.r_KeyUP;
                r.Click += feesGrid1.r_Click;
                r.EnabledChanged += feesGrid1.r_TextChanged;
                r.MouseClick += feesGrid1.r_MouseClick;
            }
            else
            {
               
                CTR.FeesRow r = new CTR.FeesRow();
                feesGrid1.flowLayoutPanel1.Controls.Add(r);
                r.Ser.Text = (feesGrid1.flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                r.KeyDown += feesGrid1.r_KeyDown;
                r.KeyUp += feesGrid1.r_KeyUP;
                r.Click += feesGrid1.r_Click;
                r.EnabledChanged += feesGrid1.r_TextChanged;
                r.MouseClick += feesGrid1.r_MouseClick;
            }

        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {
            getBalance();
            gettData_dt();
            feesGrid1.total_inv();
        }

        private void Branch_DoubleClick(object sender, EventArgs e)
        {
            ////getBalance();
            //gettData_dt();
            //feesGrid1.total_inv();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            getBalance();
            gettData_dt();
            feesGrid1.total_inv();
        }

        private void btn_ReportFundDetials_Click(object sender, EventArgs e)
        {
            rpt_FundDetials rpt = new rpt_FundDetials();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();
            tabControl1.SelectedTab = tabItem1;
            dt1 = dal.getDataTabl_1(@"select * from 
                (SELECT   D.BRANCH_code,branch_name, SUM(CASE WHEN  d.acc_no like '121%' and convert(varchar,D.g_date,111) > '1950-01-01' and convert(varchar,D.g_date,111) <=  '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  THEN meno -loh ELSE 0 END) AS End_balance_ " +
                "FROM daily_transaction as D inner join payer2 As P on D.Acc_no = P.acc_no and D.BRANCH_code = p.BRANCH_code " +
                "inner join wh_BRANCHES As B on D.BRANCH_code = B.BRANCH_code  where B.notes='مبيعات' and  B.BRANCH_code like '" + Branch.ID.Text + "%'  group by D.BRANCH_code,branch_name )as Z " +
                "left join (SELECT  branch_code,G_date " +
                ", SUM(CASE WHEN  type like 'نقدي'  THEN amount ELSE 0 END) AS Cash_ " +
                ", SUM(CASE WHEN  type like 'شيكات'  THEN amount ELSE 0 END) AS Sheck_ " +
                ", SUM(CASE WHEN  type like 'سلف'  THEN amount ELSE 0 END) AS Advance_ " +
                ", SUM(CASE WHEN  type like 'فواتير'  THEN amount ELSE 0 END) AS invoices_ " +
                ", SUM(CASE WHEN  type like 'اخري'  THEN amount ELSE 0 END) AS Other_ " +
                "from fund_Balance_Detials where convert(varchar,g_date,111) = '" + ToDate.Value.ToString("yyyy/MM/dd") + "' " +
                "group by branch_code,G_date ) as X on X.branch_code = Z.BRANCH_code ");
              ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["pic_path"].Text = "'" + Application.StartupPath + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            //rpt.DataDefinition.FormulaFields["dgits_"].Text = "'" + dal.digits_ + "'";
            //rpt.DataDefinition.FormulaFields["Titel_"].Text = "'تقرير تفاصيل ارصدة صناديق الفروع'";
            ////rpt.DataDefinition.FormulaFields["branch_E_"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";

            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
