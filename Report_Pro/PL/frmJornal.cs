using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
using System.Globalization;

using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Specialized;




namespace Report_Pro.PL
{
    public partial class frmJornal : Form
    {
        string savtype = "0";
        string btntype = "0";
        Int32 m;


        public DataTable dt_jor = new DataTable();

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        Dates date_ = new Dates();
        public frmJornal()
        {
            InitializeComponent();


            creatDattable();
            //dGV_Item.EnableHeadersVisualStyles = false;
            resizeDG();




            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = Properties.Settings.Default.DateFormate;
            try
            {
                DataTable dtCurrntdate_ = dal.getDataTabl_1("select FORMAT ('" + dateTimePicker1.Value.ToShortDateString() + "', 'dd/MM/yyyy', 'ar-SA' )");
                mTxt_H.Text = dtCurrntdate_.Rows[0][0].ToString();
                mTxt_H.Mask = "00/00/0000";
            }
            catch { }

            txtSer_code.Text = "X1";
            txtSanad_type.Text = "6";
            getJorSer();

            savtype = "0";
            //creatDattable();
            //  resizeDG();

        }



        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void dateTimeInput1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{


            //    try
            //    {

            //        DataTable dtCurrntdate_ = dal.getDataTabl("convertdate_G", dateTimePicker1.Value);
            //        mTxt_H.Text = dtCurrntdate_.Rows[0][0].ToString();
            //        mTxt_H.Mask = "00/00/0000";

            //    }


            //    catch
            //    //(Exception ex)
            //    {
            //        //MessageBox.Show(ex.Message);
            //    }

            //    mTxt_H.Focus();
            //}
        }


        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                dateTimePicker1.Text = date_.HijriToGreg(mTxt_H.Text, "");
                //    try
                //    {
                //        dateTimePicker1.Text = HijriToGreg(mTxt_H.Text);

                //        //DataTable dtCurrntdate_ = dal.getDataTabl("convertdate_h",  mTxt_H.Text);
                //        //dateTimePicker1.Text = dtCurrntdate_.Rows[0][0].ToString();

                //    }
                //    catch
                //    //(Exception ex)
                //    {
                //        //MessageBox.Show(ex.Message);
                //    }
            }
        }









        void resizeDG()
        {
            dGV_Item.Columns[0].Width = txt_Db.Width;
            dGV_Item.Columns[1].Width = txt_Cr.Width;
            dGV_Item.Columns[2].Width = txtAcc.ID.Width;
            dGV_Item.Columns[3].Width = txtAcc.Desc.Width;
            dGV_Item.Columns[4].Width = txt_Desc.Width;
            dGV_Item.Columns[5].Width = txtCost.ID.Width;
            dGV_Item.Columns[6].Width = txtCost.Desc.Width;
            dGV_Item.Columns[7].Width = txtCatogry.ID.Width;
            dGV_Item.Columns[8].Width = txtCatogry.Desc.Width;

            foreach (DataGridViewRow row in this.dGV_Item.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                dGV_Item.EnableHeadersVisualStyles = false;


            }
        }





        void total_inv()
        {
            totalDebit.Text =
                (from DataGridViewRow row in dGV_Item.Rows
                 where row.Cells[2].FormattedValue.ToString() != string.Empty
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[0].FormattedValue).ToString().ToDecimal()).Sum().ToString();
            totalCredit.Text =
               (from DataGridViewRow row in dGV_Item.Rows
                where row.Cells[2].FormattedValue.ToString() != string.Empty
                //select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();
                select (row.Cells[1].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            txtdiff.Text = ((Convert.ToDecimal(totalDebit.Text) - Convert.ToDecimal(totalCredit.Text)).ToString());

            if (Convert.ToDecimal(totalDebit.Text).ToString() == Convert.ToDecimal(totalCredit.Text).ToString())
            {
                pictureBox2.Image = global::Report_Pro.Properties.Resources.Ok_icon;
            }
            else
            {
                pictureBox2.Image = global::Report_Pro.Properties.Resources.Cross_icon1;

            }

        }









        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.dGV_Item.SelectedRows.Count > 0)
            {
                dGV_Item.Rows.RemoveAt(this.dGV_Item.SelectedRows[0].Index);
                total_inv();
                foreach (DataGridViewRow row in this.dGV_Item.Rows)
                {
                    row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                }
            }
        }



        private void BtnDelRow_Click(object sender, EventArgs e)
        {
            if (this.dGV_Item.SelectedRows.Count > 0)
            {
                dGV_Item.Rows.RemoveAt(this.dGV_Item.SelectedRows[0].Index);
                total_inv();
                foreach (DataGridViewRow row in this.dGV_Item.Rows)
                {
                    row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                }
            }
        }




        void Update_M_Transaction()
        {
            string cyear = dateTimePicker1.Value.Year.ToString();

            dal.Execute("Update_M_Transaction", cyear, Properties.Settings.Default.CoId, Properties.Settings.Default.BranchId, txtSerNo.Text.ToString(), totalDebit.Value, totalCredit.Value, dateTimePicker1.Value, mTxt_H.Text.ToString(), txtMainNote.Text.ToString(),
            Main_serNo.Text.ToString(), txtSanad_type.Text, txtSer_code.Text, Program.userID, Main_serNo.Text, "", "", "", "", "",
            "", "", "", "");

        }

        void Add_M_transaction()
        {
            string cyear = dateTimePicker1.Value.Year.ToString();

            dal.Execute("Add_M_transaction", cyear, Properties.Settings.Default.CoId, Properties.Settings.Default.BranchId, txtSerNo.Text.ToString(), totalDebit.Value, totalCredit.Value, dateTimePicker1.Value, mTxt_H.Text.ToString(), txtMainNote.Text.ToString(),
            Main_serNo.Text.ToString(), txtSanad_type.Text, txtSer_code.Text, Program.userID, Main_serNo.Text, "", "", "", "", "",
            "", "", "", "");

        }

        void Add_D_transaction()
        {
            for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            {
                DataGridViewRow DgRow = dGV_Item.Rows[i];
                if (dGV_Item.Rows[i].Cells[2].Value != null)
                {
                    if (dGV_Item.Rows[i].Cells[0].Value == null)
                    {
                        dGV_Item.Rows[i].Cells[0].Value = 0;
                    }

                    if (dGV_Item.Rows[i].Cells[1].Value == null)
                    {
                        dGV_Item.Rows[i].Cells[1].Value = 0;
                    }

                    dal.Execute_1(@"insert into daily_transaction (ACC_YEAR,ACC_NO,BRANCH_code,ser_no,COST_CENTER
                , meno, loh, balance, h_date, g_date
                , sanad_no, SANAD_TYPE, user_name, desc2, POASTING,notes
                , CAT_CODE, MAIN_SER_NO) Value ('" + txt_Cyear.Text + "','" + DgRow.Cells[2].Value.ToString() + "', '" +
                    Properties.Settings.Default.BranchId + "','" + txtSerNo.Text.ToString() + "','" + Convert.ToString(DgRow.Cells[5].Value) + "','" +
                    DgRow.Cells[0].Value.ToString().ToDecimal() + "','" + DgRow.Cells[1].Value.ToString().ToDecimal() + "','" +
                    (DgRow.Cells[0].Value.ToString().ToDecimal() - DgRow.Cells[1].Value.ToString().ToDecimal()) + "','" +
                    mTxt_H.Text.ToString() + "','" +
                    dateTimePicker1.Value + "','" +
                    Main_serNo.Text + "','" +
                    txtSanad_type.Text + "','" +
                    Program.userID + "','" +
                    dGV_Item.Rows[i].Cells[4].Value.ToString() + "','0','" +
                    txtMainNote.Text + "','" +
                    Convert.ToString(DgRow.Cells[7].Value) + "','" +
                    Main_serNo.Text + "')");

                }

            }
        }


        void update_D_transaction()
        {
            string cyear = dateTimePicker1.Value.Year.ToString();
            dal.Execute("updatedetials", cyear, Properties.Settings.Default.CoId, Properties.Settings.Default.BranchId, txtSerNo.Text.ToString());
        }


        void delete_D_transaction()
        {
            dal.Execute("delete_D_transaction", txt_Cyear.Text, Properties.Settings.Default.BranchId, txtSerNo.Text.ToString());
        }


        private void getJorSer()
        {

            this.txtSerNo.Text = "M" + dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) from serial_no where BRANCH_CODE='" + Properties.Settings.Default.BranchId
                     + "' and ACC_YEAR= '" + txt_Cyear.Text + "'").Rows[0][0].ToString().PadLeft(4, '0');

            this.Main_serNo.Text = dal.getDataTabl_1(@"select isnull(daily_sn_ser+1,1) from serial_no where BRANCH_CODE='" + Properties.Settings.Default.BranchId
                 + "' and ACC_YEAR= '" + txt_Cyear.Text + "' ").Rows[0][0].ToString();//.PadLeft(4, '0');




            //DataTable dt_;


            //dt_ = dal.getDataTabl("Get_main_daily_ser", Properties.Settings.Default.BranchId, txt_Cyear.Text.ToString());
            //if (dt_.Rows.Count > 0)
            //{
            //    string StrId = dt_.Rows[0][0].ToString();
            //    // dal.getDataTabl("MaxDaliySer_1", Properties.Settings.Default.CoId, Properties.Settings.Default.BranchId, txtSer_code.Text);
            //    //txtSerNo.Text = "M" + StrId.ToString().PadLeft(5, '0');
            //    //Main_serNo.Text = StrId;
            //    txtSerNo.Text = StrId;
            //    Main_serNo.Text = StrId;
            //}

            //else
            //{
            //    //txtSerNo.Text = "M" + "1".PadLeft(5, '0');
            //    //Main_serNo.Text = "1";
            //    txtSerNo.Text = "1";
            //    Main_serNo.Text = "1";
            //}
        }


        private void getCloseJorSer()
        {

            this.txtSerNo.Text = "C" + dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + Properties.Settings.Default.BranchId
                     + "' and Cyear= '" + txt_Cyear.Text + "' and doc_Id =  'CENT'").Rows[0][0].ToString().PadLeft(4, '0');

            this.Main_serNo.Text = dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + Properties.Settings.Default.BranchId
                 + "' and Cyear= '" + txt_Cyear.Text + "' and doc_Id =  'CENT'").Rows[0][0].ToString();//.PadLeft(4, '0');

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = true;

        }


        private void showDetails()
        {


            ////==============================  احضار تفاصيل القيد =========================================================//
            int count_ = 0;
            DataTable dt_ = new DataTable();
            dt_.Clear();
            //dt_ = dal.getDataTabl("GetDaily_transaction", Properties.Settings.Default.BranchId, txtsearch.Text);
            dt_ = dal.getDataTabl_1(@"SELECT D.*,P.PAYER_NAME,C.COST_name,T.CAT_NAME,U.USER_NAME
                FROM daily_transaction as D
                inner join payer2 as P on P.ACC_NO=D.ACC_NO and P.BRANCH_code=D.BRANCH_code
                left join COST_CENTER  as C on C.COST_CODE=D.COST_CENTER
                left join CATEGORY as T on T.CAT_CODE=D.CAT_CODE
                inner join wh_USERS as U on U.USER_ID=D.user_name
                where  D.BRANCH_code='" + Properties.Settings.Default.BranchId + "' and D.ser_no='" + txtsearch.Text + "' order by sorting_ser");
            if (dt_.Rows.Count > 0)
            {
                txtSerNo.Text = dt_.Rows[0][3].ToString();
                mTxt_H.Text = dt_.Rows[0][11].ToString();
                dateTimePicker1.Text = dt_.Rows[0][12].ToString();
                Main_serNo.Text = dt_.Rows[0][13].ToString();
                txtSanad_type.Text = dt_.Rows[0][14].ToString();
                txt_sp_ser.Text = dt_.Rows[0][15].ToString();
                txtMainNote.Text = dt_.Rows[0][31].ToString();
                txt_Cyear.Text = dt_.Rows[0][0].ToString();



                dt_jor.Clear();
                int i = 0;
                DataRow row = null;
                foreach (DataRow r in dt_.Rows)
                {

                    row = dt_jor.NewRow();
                    row[0] = Convert.ToDecimal(dt_.Rows[i]["meno"]).ToString("n" + dal.digits_);
                    row[1] = Convert.ToDecimal(dt_.Rows[i]["loh"]).ToString("n" + dal.digits_);
                    row[2] = dt_.Rows[i]["acc_no"].ToString();
                    row[3] = dt_.Rows[i]["PAYER_NAmE"].ToString();
                    row[4] = dt_.Rows[i]["desc2"].ToString();
                    row[5] = dt_.Rows[i]["COST_CENTER"].ToString();
                    row[6] = dt_.Rows[i]["COST_name"].ToString();
                    row[7] = dt_.Rows[i]["CAT_CODE"].ToString();
                    row[8] = dt_.Rows[i]["CAT_NAME"].ToString();
                    //row[9] =  Convert.ToDecimal(dt_.Rows[i][70]).ToString("n" + dal.digits_);
                    //row[10]  = dt_.Rows[i][71].ToString();
                    //row[11]  = dt_.Rows[i][72].ToString();
                    //row[12]  = dt_.Rows[i][73].ToString();
                    //row[13]  = dt_.Rows[i][74].ToString();

                    //row[8] = dt_.Rows[i][7];
                    //row[9] = dt_.Rows[i][2];


                    dt_jor.Rows.Add(row);
                    i = i + 1;
                }

                dGV_Item.DataSource = dt_jor;
                resizeDG();
                total_inv();

            }


            else
            {
                MessageBox.Show(" رقم القيد غير موجود .... فضلا تأكد من الرقم ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsearch.Focus();
                txtsearch.SelectAll();
            }

        }



        private void GetcloseJor()
        {


            ////==============================  احضار تفاصيل القيد =========================================================//
            int count_ = 0;
            DataTable dt_ = new DataTable();
            dt_.Clear();
            dt_ = dal.getDataTabl("Get_CloseJor", date_close.MinDate, date_close.Value.Date, "", Properties.Settings.Default.BranchId, "", "1", "");
            if (dt_.Rows.Count > 0)
            {
                //txtSerNo.Text = dt_.Rows[0][3].ToString();
                //mTxt_H.Text = dt_.Rows[0][11].ToString();
                dateTimePicker1.Value = date_close.Value.Date;
                //Main_serNo.Text = dt_.Rows[0][13].ToString();
                //txtSanad_type.Text = dt_.Rows[0][14].ToString();
                //txt_sp_ser.Text = dt_.Rows[0][15].ToString();
                //txtMainNote.Text = dt_.Rows[0][31].ToString();
                txt_Cyear.Text = "cy";



                dt_jor.Clear();
                int i = 0;
                DataRow row = null;
                foreach (DataRow r in dt_.Rows)
                {

                    row = dt_jor.NewRow();
                    row[0] = Convert.ToDecimal(dt_.Rows[i][0]).ToString("n" + dal.digits_);
                    row[1] = Convert.ToDecimal(dt_.Rows[i][1]).ToString("n" + dal.digits_);
                    row[2] = dt_.Rows[i][2].ToString();
                    row[3] = dt_.Rows[i][3].ToString();
                    row[4] = "اقفال الرصيد";
                    row[5] = "";
                    row[6] = "";
                    row[7] = "1";
                    row[8] = "";
                    row[9] = 0;
                    row[10] = "";
                    row[11] = "";
                    row[12] = "";
                    row[13] = "";

                    //row[8] = dt_.Rows[i][7];
                    //row[9] = dt_.Rows[i][2];


                    dt_jor.Rows.Add(row);
                    i = i + 1;
                }

                dGV_Item.DataSource = dt_jor;
                resizeDG();
                total_inv();

            }


            else
            {
                MessageBox.Show(" رقم القيد غير موجود .... فضلا تأكد من الرقم ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsearch.Focus();
                txtsearch.SelectAll();
            }

        }



        private void btn_Cancl_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            groupBox1.Visible = false;
        }

        private void txtSerNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtsearch.Text != string.Empty)
            {
                btn_Srearch.Focus();
            }
        }




        private void BNew_Click(object sender, EventArgs e)
        {
            txt_docId.Text = "JOR";
            savtype = "0";
            dateTimePicker1.Value = DateTime.Now;
            txtsearch.Clear();
            groupBox1.Visible = false;
            txtMainNote.Clear();
            txtSerNo.Clear();
            Main_serNo.Clear();
            txt_sp_ser.Clear();
            getJorSer();
            dt_jor.Clear();
            dGV_Item.DataSource = null;
            BSave.Enabled = true;
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1("select ser_no,MAIN_SER_NO from daily_transaction WHERE BRANCH_code='" + Properties.Settings.Default.BranchId + "' and ser_no='" + txtSerNo.Text + "'");

            if (dt_.Rows.Count > 0)
            {
                SqlCommand cmd = dal.sqlconn_1.CreateCommand();
                SqlTransaction trans;
                trans = dal.sqlconn_1.BeginTransaction();
                cmd.Connection = dal.sqlconn_1;
                cmd.Transaction = trans;
                try
                {


                    cmd.CommandText = @"Delete from daily_transaction where Ser_no = '" + txtSerNo.Text + "' and Branch_code = '" + Properties.Settings.Default.BranchAccID + "'  and ACC_YEAR = '" + txt_Cyear.Text + "' ";
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
                    {
                        DataGridViewRow DgRow = dGV_Item.Rows[i];
                        if (dGV_Item.Rows[i].Cells[2].Value != null)
                        {
                            if (dGV_Item.Rows[i].Cells[0].Value == null)
                            {
                                dGV_Item.Rows[i].Cells[0].Value = 0;
                            }

                            if (dGV_Item.Rows[i].Cells[1].Value == null)
                            {
                                dGV_Item.Rows[i].Cells[1].Value = 0;
                            }

                            cmd.CommandText = @"insert into daily_transaction (ACC_YEAR,ACC_NO,BRANCH_code,ser_no,COST_CENTER
                            , meno, loh, balance, h_date, g_date
                            , sanad_no, SANAD_TYPE, user_name, desc2, POASTING,notes
                            , CAT_CODE, MAIN_SER_NO) Values ('" + txt_Cyear.Text + "','" + DgRow.Cells[2].Value.ToString() + "', '" +
                             Properties.Settings.Default.BranchAccID + "','" + txtSerNo.Text.ToString() + "','" + Convert.ToString(DgRow.Cells[5].Value) + "','" +
                            DgRow.Cells[0].Value.ToString().ToDecimal() + "','" + DgRow.Cells[1].Value.ToString().ToDecimal() + "','" +
                            (DgRow.Cells[0].Value.ToString().ToDecimal() - DgRow.Cells[1].Value.ToString().ToDecimal()) + "','" +
                            mTxt_H.Text.ToString() + "','" +
                            dateTimePicker1.Value.ToString("yyyy/MM/dd HH: mm:ss") + "','" +
                            Main_serNo.Text + "','" +
                            txtSanad_type.Text + "','" +
                            Program.userID + "','" +
                            dGV_Item.Rows[i].Cells[4].Value.ToString() + "','0','" +
                            txtMainNote.Text + "','" +
                            Convert.ToString(DgRow.Cells[7].Value) + "','" +
                            Main_serNo.Text + "')";

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

            else
            {

                SqlCommand cmd = dal.sqlconn_1.CreateCommand();
                SqlTransaction trans;
                trans = dal.sqlconn_1.BeginTransaction();
                cmd.Connection = dal.sqlconn_1;
                cmd.Transaction = trans;
                try
                {



                    for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
                    {
                        DataGridViewRow DgRow = dGV_Item.Rows[i];
                        if (dGV_Item.Rows[i].Cells[2].Value != null)
                        {
                            if (dGV_Item.Rows[i].Cells[0].Value == null)
                            {
                                dGV_Item.Rows[i].Cells[0].Value = 0;
                            }

                            if (dGV_Item.Rows[i].Cells[1].Value == null)
                            {
                                dGV_Item.Rows[i].Cells[1].Value = 0;
                            }
                            getJorSer();

                            cmd.CommandText = @"insert into daily_transaction (ACC_YEAR,ACC_NO,BRANCH_code,ser_no,COST_CENTER
                            , meno, loh, balance, h_date, g_date
                            , sanad_no, SANAD_TYPE, user_name, desc2, POASTING,notes
                            , CAT_CODE, MAIN_SER_NO) Values ('" + txt_Cyear.Text + "','" + DgRow.Cells[2].Value.ToString() + "', '" +
                             Properties.Settings.Default.BranchAccID + "','" + txtSerNo.Text.ToString() + "','" + Convert.ToString(DgRow.Cells[5].Value) + "','" +
                            DgRow.Cells[0].Value.ToString().ToDecimal() + "','" + DgRow.Cells[1].Value.ToString().ToDecimal() + "','" +
                            (DgRow.Cells[0].Value.ToString().ToDecimal() - DgRow.Cells[1].Value.ToString().ToDecimal()) + "','" +
                            mTxt_H.Text.ToString() + "','" +
                            dateTimePicker1.Value + "','" +
                            Main_serNo.Text + "','" +
                            txtSanad_type.Text + "','" +
                            Program.userID + "','" +
                            dGV_Item.Rows[i].Cells[4].Value.ToString() + "','0','" +
                            txtMainNote.Text + "','" +
                            Convert.ToString(DgRow.Cells[7].Value) + "','" +
                            Main_serNo.Text + "')";

                            cmd.ExecuteNonQuery();

                        }

                    }

                    cmd.CommandText = @"UPDATE serial_no SET daily_sn_ser='" + Main_serNo.Text + "' , main_daily_ser = '" + txtSerNo.Text + "' WHERE BRANCH_CODE=  '" + Properties.Settings.Default.BranchAccID + "' and ACC_YEAR='" + txt_Cyear.Text + "' ";
                    cmd.ExecuteNonQuery();

                    trans.Commit();
                    MessageBox.Show(dal.rm.GetString("msgSave", dal.cul), dal.rm.GetString("msgSave_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

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



        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            if (savtype == "1")
            {
                total_inv();
                if (totalDebit.Value <= 0 || totalCredit.Value <= 0 || totalDebit.Value != totalCredit.Value)
                {
                    MessageBox.Show("تأكد من توازن القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Update_M_Transaction();
                //update_D_transaction();
                delete_D_transaction();
                Add_D_transaction();
                //dal.Execute("clear_daily_transaction_Frist");

                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BSave.Enabled = false;
                savtype = "1";

            }

        }

        private void BtnPrint_Click_1(object sender, EventArgs e)
        {

            RPT.Form1 frm = new RPT.Form1();

            RPT.rpt_DailyEntry rpt_DailyEntry = new RPT.rpt_DailyEntry();
            rpt_DailyEntry.SetDataSource(dal.getDataTabl_1(@"SELECT D.*,P.PAYER_NAME,C.COST_name,T.CAT_NAME,U.USER_NAME
                FROM daily_transaction as D
                inner join payer2 as P on P.ACC_NO=D.ACC_NO and P.BRANCH_code=D.BRANCH_code
                left join COST_CENTER  as C on C.COST_CODE=D.COST_CENTER
                left join CATEGORY as T on T.CAT_CODE=D.CAT_CODE
                inner join wh_USERS as U on U.USER_ID=D.user_name
                where  D.BRANCH_code='" + Properties.Settings.Default.BranchId + "' and D.ser_no='" + txtSerNo.Text + "' order by sorting_ser"));

            rpt_DailyEntry.DataDefinition.FormulaFields["branchCode"].Text = "'" + txtBranchCode.Text + "'";
            rpt_DailyEntry.DataDefinition.FormulaFields["branchName"].Text = "'" + txtBranchName.Text + "'";
            rpt_DailyEntry.DataDefinition.FormulaFields["companyName"].Text = "'" + Properties.Settings.Default.head_txt + "'";

            frm.crystalReportViewer1.ReportSource = rpt_DailyEntry;
            frm.ShowDialog();

        }

        private void BSearch_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtsearch.Focus();

        }

        private void BExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Srearch_Click(object sender, EventArgs e)
        {
            // txt_docId.Text = "JOR";
            //dGV_Item.Rows.Clear();
            //dGV_Item.RowCount = 20;
            foreach (DataGridViewRow row in dGV_Item.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
            }
            clear_texts();
            showDetails();

            savtype = "1";
            // BSave.Enabled = false;

        }

        private void dGV_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtAccId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }





        private void BtnCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void dTime_1_Leave(object sender, EventArgs e)
        {

            //try
            //{
            //    DataTable dtCurrntdate_ = dal.getDataTabl_1("select FORMAT ( '"+ dateTimePicker1.Value+"', 'dd/MM/yyyy', 'ar-SA' )" );
            //    mTxt_H.Text = dtCurrntdate_.Rows[0][0].ToString();
            //    mTxt_H.Mask = "00/00/0000";
            //}


            //catch { }

        }

        private void dGV_Item_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dGV_Item.CurrentCell.RowIndex;
                int j = dGV_Item.CurrentCell.ColumnIndex;
                //-------------------------------------------------------------------//
                if (j == 2)
                {
                    //=============================================================//
                    if (dGV_Item.Rows[i].Cells[2].Value != null)
                    {
                        DataTable dt = new DataTable();
                        dt = dal.getDataTabl("GetAcc", Properties.Settings.Default.BranchId, dGV_Item.Rows[i].Cells[2].Value.ToString(), "1");
                        if (dt.Rows.Count > 0)
                        {
                            dGV_Item.Rows[i].Cells[3].Value = dt.Rows[0][7].ToString();
                        }
                        else

                        {
                            dGV_Item.Rows[i].Cells[2].Value = null;
                            dGV_Item.Rows[i].Cells[3].Value = null;

                            PL.frmSearchAcc F = new frmSearchAcc();
                            F.radioTransaction.Checked = true;
                            F.ShowDialog();

                            int ii = F.DGV1.CurrentCell.RowIndex;


                            dGV_Item.Rows[i].Cells[2].Value = F.DGV1.Rows[ii].Cells[0].Value;
                            dGV_Item.Rows[i].Cells[3].Value = F.DGV1.Rows[ii].Cells[1].Value;

                            dGV_Item.Rows[i].Cells[9].Value = F.DGV1.Rows[ii].Cells[5].Value;
                            dGV_Item.Rows[i].Cells[10].Value = F.DGV1.Rows[ii].Cells[6].Value;
                            dGV_Item.Rows[i].Cells[11].Value = F.DGV1.Rows[ii].Cells[7].Value;
                            dGV_Item.Rows[i].Cells[12].Value = F.DGV1.Rows[ii].Cells[8].Value;
                        }
                    }
                    else
                    {
                        dGV_Item.Rows[i].Cells[2].Value = null;
                        dGV_Item.Rows[i].Cells[3].Value = null;
                        PL.frmSearchAcc F = new frmSearchAcc();
                        F.ShowDialog();

                        int ii = F.DGV1.CurrentCell.RowIndex;


                        dGV_Item.Rows[i].Cells[2].Value = F.DGV1.Rows[ii].Cells[0].Value;
                        dGV_Item.Rows[i].Cells[3].Value = F.DGV1.Rows[ii].Cells[1].Value;

                        dGV_Item.Rows[i].Cells[9].Value = F.DGV1.Rows[ii].Cells[5].Value;
                        dGV_Item.Rows[i].Cells[10].Value = F.DGV1.Rows[ii].Cells[6].Value;
                        dGV_Item.Rows[i].Cells[11].Value = F.DGV1.Rows[ii].Cells[7].Value;
                        dGV_Item.Rows[i].Cells[12].Value = F.DGV1.Rows[ii].Cells[8].Value;




                    }
                    //====================================================================//

                    var iCol = dGV_Item.CurrentCell.ColumnIndex;
                    var iRow = dGV_Item.CurrentCell.RowIndex;
                    if (iCol == dGV_Item.Columns.Count - 2)
                    {
                        if (iRow < dGV_Item.Rows.Count - 1)
                        {
                            dGV_Item.CurrentCell = dGV_Item[0, iRow + 1];
                        }
                    }
                    else
                    {
                        if (iRow < dGV_Item.Rows.Count - 1)
                        {
                            SendKeys.Send("{up}");
                        }

                        dGV_Item.CurrentCell = dGV_Item[iCol + 2, iRow];
                    }
                }
                else
                {
                    var iCol = dGV_Item.CurrentCell.ColumnIndex;
                    var iRow = dGV_Item.CurrentCell.RowIndex;
                    if (iCol == dGV_Item.Columns.Count - 2)
                    {
                        if (iRow < dGV_Item.Rows.Count - 1)
                        {
                            dGV_Item.CurrentCell = dGV_Item[0, iRow + 1];

                        }
                    }
                    else
                    {
                        if (iRow < dGV_Item.Rows.Count - 1)
                        {
                            SendKeys.Send("{up}");
                        }

                        dGV_Item.CurrentCell = dGV_Item[iCol + 1, iRow];
                    }
                }
                //---------------------------------------------------------------------//


                //"""""""""""""""""""""" تصفير الدائن اذا كان المدين اكبر من الصفر  والعكس """"""""""""""""//
                if (j == 0)
                {
                    if (dGV_Item.Rows[i].Cells[0].Value.ToString().ToDecimal() > 0)
                    {
                        dGV_Item.Rows[i].Cells[1].Value = 0;
                    }
                }
                if (j == 1)
                {
                    if (dGV_Item.Rows[i].Cells[1].Value.ToString().ToDecimal() > 0)
                    {
                        dGV_Item.Rows[i].Cells[0].Value = 0;
                    }
                }

                //""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""//


                total_inv();
            }
            catch
            {
            }
        }

        private void dGV_Item_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F3)
            {
                btntype = "0";
                //dGV_Item.Focus();
                m = dGV_Item.CurrentRow.Index;


                try
                {
                    //DataTable itemdata_ = dal.getDataTabl("get_product_name", dGV_Item.CurrentRow.Cells[0].Value.ToString(), Properties.Settings.Default.CoId);
                    txt_Db.Text = dGV_Item.CurrentRow.Cells[0].Value.ToString();
                    txt_Cr.Text = dGV_Item.CurrentRow.Cells[1].Value.ToString();
                    txtAcc.ID.Text = dGV_Item.CurrentRow.Cells[2].Value.ToString();
                    //txt_accName.Text = dGV_Item.CurrentRow.Cells[3].Value.ToString();
                    txt_Desc.Text = dGV_Item.CurrentRow.Cells[4].Value.ToString();
                    txtCost.ID.Text = dGV_Item.CurrentRow.Cells[5].Value.ToString();
                    txtCost.Desc.Text = dGV_Item.CurrentRow.Cells[6].Value.ToString();
                    txtCatogry.ID.Text = dGV_Item.CurrentRow.Cells[7].Value.ToString();
                    txtCatogry.Desc.Text = dGV_Item.CurrentRow.Cells[8].Value.ToString();
                    txt_docValue.Text = dGV_Item.CurrentRow.Cells[9].Value.ToString();
                    txt_Supp.Text = dGV_Item.CurrentRow.Cells[10].Value.ToString();
                    txt_docNo.Text = dGV_Item.CurrentRow.Cells[11].Value.ToString();
                    txt_docDate.Text = dGV_Item.CurrentRow.Cells[12].Value.ToString();
                    txt_VatNo.Text = dGV_Item.CurrentRow.Cells[13].Value.ToString();
                    txt_Db.Focus();
                }
                catch
                {
                    return;
                }



            }

        }

        private void dGV_Item_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= TextboxNumeric_KeyPress;
            if ((int)(((System.Windows.Forms.DataGridView)(sender)).CurrentCell.ColumnIndex) == 0 ||
               dGV_Item.CurrentCell.ColumnIndex == 1)
            {
                e.Control.KeyPress += TextboxNumeric_KeyPress;
            }


        }

        private void TextboxNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool nonNumberEntered = true;
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == DecimalSeparator)
            {
                nonNumberEntered = false;
            }

            if (nonNumberEntered)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void frmJornal_Load(object sender, EventArgs e)
        {
            txtBranchCode.Text = Properties.Settings.Default.BranchAccID;
            txtBranchName.Text = dal.GetCell_1("select BRANCH_name from BRANCHS where BRANCH_code='" + Properties.Settings.Default.BranchAccID + "' ").ToString();
            foreach (DataGridViewRow row in dGV_Item.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
            }
            mTxt_H.Text = date_.GregToHijri(dateTimePicker1.Text);
        }

        private void PersistentDataGridViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmJornal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //            // Save column state data
            //            // including order, column width and whether or not the column is visible
            //            StringCollection stringCollection = new StringCollection();
            //#if true    // 2009/03/26:  This is the fix for the column order issue reported by Kevin Van Puyvelde
            //            int i = 0;
            //            foreach (DataGridViewColumn column in this.dGV_Item.Columns)
            //            {
            //                stringCollection.Add(string.Format(
            //                    "{0},{1},{2},{3}",
            //                    column.DisplayIndex.ToString("D2"), // Column order fix
            //                    column.Width,
            //                    column.Visible,
            //                    i++));
            //            }
            //#else       // *** This is the old code
            //            foreach(DataGridViewColumn column in this.contractorsDataGridView.Columns) {
            //                stringCollection.Add(string.Format(
            //                    "{0},{1},{2}",
            //                    column.DisplayIndex,
            //                    column.Width,
            //                    column.Visible));
            //            }
            //#endif
            //            Properties.Settings.Default.DGVFC_frmJornal = stringCollection;

            //            // Save location and size data
            //            // RestoreBounds remembers normal position if minimized or maximized
            //            if (this.WindowState == FormWindowState.Normal)
            //            {
            //                Properties.Settings.Default.DGVFL_frmJornal = this.Location;
            //                Properties.Settings.Default.DGVFS_frmJornal = this.Size;
            //            }
            //            else
            //            {
            //                Properties.Settings.Default.DGVFL_frmJornal = this.RestoreBounds.Location;
            //                Properties.Settings.Default.DGVFS_frmJornal = this.RestoreBounds.Size;
            //            }

            //            // Save the data
            //            Properties.Settings.Default.Save();
        }

        private void dGV_Item_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }













        private void labelX31_Click(object sender, EventArgs e)
        {

        }

        private void txt_classId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (VATBox.Checked == true)
                {
                    txt_Supp.Focus();
                }
                else
                {
                    btnEnter.Focus();
                    //total_inv();

                    //if (btntype == "0")
                    //{
                    //    addrow_new();
                    //    btntype = "0";
                    //    txt_Db.Focus();


                    //}
                    //else if (btntype == "1")
                    //{
                    //    editrow();
                    //    btntype = "0";
                    //    txt_Db.Focus();
                    //}
                }
            }
        }

        void addrow_new()
        {


            DataRow r = dt_jor.NewRow();
            r[0] = txt_Db.Text;
            r[1] = txt_Cr.Text;
            r[2] = txtAcc.ID.Text;
            r[3] = txtAcc.Desc.Text;
            r[4] = txt_Desc.Text;
            r[5] = txtCost.ID.Text;
            r[6] = txtCost.Desc.Text;
            r[7] = txtCatogry.ID.Text;
            r[8] = txtCatogry.Desc.Text;
            //r[9] = txt_docValue.Text;
            //r[10] = txt_Supp.Text;
            //r[11] = txt_docNo.Text;
            //r[12] = txt_docDate.Text;
            //r[13] = txt_VatNo.Text;
            dt_jor.Rows.Add(r);

            dGV_Item.DataSource = dt_jor;
            dGV_Item.CurrentCell = dGV_Item.Rows[dGV_Item.Rows.Count - 1].Cells[0];


            clear_texts();

            total_inv();
            resizeDG();
        }

        void editrow()
        {
            dGV_Item.Rows[m].Cells[0].Value = txt_Db.Text;
            dGV_Item.Rows[m].Cells[1].Value = txt_Cr.Text;
            dGV_Item.Rows[m].Cells[2].Value = txtAcc.ID.Text;
            dGV_Item.Rows[m].Cells[3].Value = txtAcc.Desc.Text;
            dGV_Item.Rows[m].Cells[4].Value = txt_Desc.Text;
            dGV_Item.Rows[m].Cells[5].Value = txtCost.ID.Text;
            dGV_Item.Rows[m].Cells[6].Value = txtCost.Desc.Text;
            dGV_Item.Rows[m].Cells[7].Value = txtCatogry.ID.Text;
            dGV_Item.Rows[m].Cells[8].Value = txtCatogry.Desc.Text;
            //dGV_Item.Rows[m].Cells[9].Value = txt_docValue.Text;
            //dGV_Item.Rows[m].Cells[10].Value = txt_Supp.Text;
            //dGV_Item.Rows[m].Cells[11].Value = txt_docNo.Text;
            //dGV_Item.Rows[m].Cells[12].Value = txt_docDate.Text;
            //dGV_Item.Rows[m].Cells[13].Value = txt_VatNo.Text;

            total_inv();
            clear_texts();

            resizeDG();

        }



        void clear_texts()
        {
            txt_Db.Value = 0;
            txt_Cr.Value = 0;
            txtAcc.ID.Clear();
            txtAcc.Desc.Clear();
            txt_Desc.Clear();
            txtCost.ID.Clear();
            txtCost.Desc.Clear();
            txtCatogry.ID.Clear();
            txtCatogry.Desc.Clear();
            txt_docValue.Value = 0;
            txt_Supp.Clear();
            txt_VatNo.Text = "";
            txt_docDate.Text = "";
            txt_docNo.Clear();

        }


        void creatDattable()
        {
            dt_jor.Columns.Add("مدين");
            dt_jor.Columns.Add(" دائن");
            dt_jor.Columns.Add(" كود الحساب");
            dt_jor.Columns.Add(" اسم الحساب");
            dt_jor.Columns.Add("البيان");
            dt_jor.Columns.Add(" كود الكلفة");
            dt_jor.Columns.Add("مركز الكلفة");
            dt_jor.Columns.Add("رقم التصنيف");
            dt_jor.Columns.Add("التصنيف");
            //dt_jor.Columns.Add("قيمة الفاتورة");
            //dt_jor.Columns.Add("المورد");
            //dt_jor.Columns.Add("رقم الفاتورة");
            //dt_jor.Columns.Add("تاريخ الفاتورة");
            //dt_jor.Columns.Add("الرقم الضريبي");
            dGV_Item.DataSource = dt_jor;
            //dGV_Item.Columns[7].Visible = false;
            //dGV_Item.Columns[8].Visible = false;
        }

        private void labelX30_Click(object sender, EventArgs e)
        {

        }

        private void dGV_Item_DoubleClick(object sender, EventArgs e)
        {
            btntype = "1";
            m = dGV_Item.CurrentRow.Index;
            try
            {
                //DataTable itemdata_ = dal.getDataTabl("get_product_name", dGV_Item.CurrentRow.Cells[0].Value.ToString(), Properties.Settings.Default.CoId);
                txt_Db.Text = dGV_Item.CurrentRow.Cells[0].Value.ToString();
                txt_Cr.Text = dGV_Item.CurrentRow.Cells[1].Value.ToString();
                txtAcc.ID.Text = dGV_Item.CurrentRow.Cells[2].Value.ToString();
                txtAcc.Desc.Text = dGV_Item.CurrentRow.Cells[3].Value.ToString();
                txt_Desc.Text = dGV_Item.CurrentRow.Cells[4].Value.ToString();
                txtCost.ID.Text = dGV_Item.CurrentRow.Cells[5].Value.ToString();
                txtCost.Desc.Text = dGV_Item.CurrentRow.Cells[6].Value.ToString();
                txtCatogry.ID.Text = dGV_Item.CurrentRow.Cells[7].Value.ToString();
                txtCatogry.Desc.Text = dGV_Item.CurrentRow.Cells[8].Value.ToString();
                //txt_docValue.Text = dGV_Item.CurrentRow.Cells[9].Value.ToString();
                //txt_Supp.Text = dGV_Item.CurrentRow.Cells[10].Value.ToString();
                //txt_docNo.Text = dGV_Item.CurrentRow.Cells[11].Value.ToString();
                //txt_docDate.Text = dGV_Item.CurrentRow.Cells[12].Value.ToString();
                //txt_VatNo.Text = dGV_Item.CurrentRow.Cells[13].Value.ToString();
                txt_Db.Focus();
            }
            catch
            {
                return;
            }
        }

        private void txt_accNo_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void txt_Db_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txt_Db.Text.ToDecimal() != 0)
                {
                    txt_Cr.Text = "0";
                    txt_Cr.Focus();
                }
                else
                {
                    txt_Cr.Focus();
                }

            }
        }

        private void txt_Cr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txt_Cr.Text.ToDecimal() != 0)
                {
                    txt_Db.Text = "0";
                    txtAcc.ID.Focus();
                }

                else
                {
                    txtAcc.ID.Focus();
                }

            }
        }

        private void txt_Db_KeyUp(object sender, KeyEventArgs e)
        {




        }

        private void txt_Db_Leave(object sender, EventArgs e)
        {
            if (txt_Db.Text.ToDecimal() != 0)
            {
                txt_Cr.Text = "0";

            }

        }

        private void txt_Cr_Leave(object sender, EventArgs e)
        {
            if (txt_Cr.Text.ToDecimal() != 0)
            {
                txt_Db.Text = "0";

            }

        }

        private void txt_Desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCost.ID.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                txt_Desc.Text = dGV_Item.Rows[dGV_Item.Rows.Count - 1].Cells[4].Value.ToString();
            }
        }

        private void txt_costId_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //string V =
            //    s.Replace(" ", "").Length



            if ((txt_Db.Value > 0 || txt_Cr.Value > 0) && txtAcc.ID.Text != "")

            {
                total_inv();

                if (btntype == "0")
                {
                    addrow_new();
                    btntype = "0";
                    txt_Db.Focus();


                }
                else if (btntype == "1")
                {
                    editrow();
                    btntype = "0";
                    txt_Db.Focus();
                }
            }
            else
            {
                MessageBox.Show("تأكد من البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_Supp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_docValue.Focus();
            }
        }

        private void txt_docNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_docDate.Focus();
            }
        }

        private void txt_docDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_VatNo.Focus();
                txt_VatNo.SelectAll();
            }
        }


        private void txt_docValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_docNo.Focus();
            }
        }

        private void mTxt_H_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                DataTable dtCurrntdate_ = dal.getDataTabl("convertdate_H", mTxt_H.Text);
                dateTimePicker1.Text = dtCurrntdate_.Rows[0][0].ToString();

            }
            catch
            {

            }
        }



        private void txt_VatNo_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.Focus();
            }

        }

        private void frmJornal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                btntype = "0";
                dGV_Item.Focus();
                m = dGV_Item.CurrentRow.Index;

                try
                {
                    DataTable itemdata_ = dal.getDataTabl("get_product_name", dGV_Item.CurrentRow.Cells[0].Value.ToString(), Properties.Settings.Default.CoId);
                    txt_Db.Text = dGV_Item.CurrentRow.Cells[0].Value.ToString();
                    txt_Cr.Text = dGV_Item.CurrentRow.Cells[1].Value.ToString();
                    txtAcc.ID.Text = dGV_Item.CurrentRow.Cells[2].Value.ToString();
                    txtAcc.Desc.Text = dGV_Item.CurrentRow.Cells[3].Value.ToString();
                    txt_Desc.Text = dGV_Item.CurrentRow.Cells[4].Value.ToString();
                    txtCost.ID.Text = dGV_Item.CurrentRow.Cells[5].Value.ToString();
                    txtCost.Desc.Text = dGV_Item.CurrentRow.Cells[6].Value.ToString();
                    txtCatogry.ID.Text = dGV_Item.CurrentRow.Cells[7].Value.ToString();
                    txtCatogry.Desc.Text = dGV_Item.CurrentRow.Cells[8].Value.ToString();
                    txt_docValue.Text = dGV_Item.CurrentRow.Cells[9].Value.ToString().ToDecimal().ToString();
                    txt_Supp.Text = dGV_Item.CurrentRow.Cells[10].Value.ToString();
                    txt_docNo.Text = dGV_Item.CurrentRow.Cells[11].Value.ToString();
                    txt_docDate.Text = dGV_Item.CurrentRow.Cells[12].Value.ToString();
                    txt_VatNo.Text = dGV_Item.CurrentRow.Cells[13].Value.ToString();

                }
                catch
                {
                    return;
                }

                txt_Db.Focus();
            }


        }



        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            txt_docId.Text = "CENT";
            getCloseJorSer();
            GetcloseJor();
        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void labelX28_Click(object sender, EventArgs e)
        {

        }

        private void labelX17_Click(object sender, EventArgs e)
        {

        }

        private void labelX15_Click(object sender, EventArgs e)
        {

        }

        private void txtAcc_Load(object sender, EventArgs e)
        {

        }

        private void txtAcc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtAcc.ID.Text != string.Empty)
            {
                if (txtCatogry.ID.Text == "")
                {
                    txtCatogry.ID.Text = "1";
                }
                txt_Desc.Focus();


            }
        }

        private void txtCost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCost.ID.Text != string.Empty)
                {
                    txtCatogry.ID.Focus();

                }

            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HD_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mTxt_H_Click(object sender, EventArgs e)
        {
            mTxt_H.Focus();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mTxt_H.Text = date_.GregToHijri(dateTimePicker1.Text);

            }
        }

        private void VATBox_CheckedChanged(object sender, EventArgs e)
        {
            if (VATBox.Checked)
            {
                gpVAT.Visible = true;
            }
            else
            {
                gpVAT.Visible = false;

            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtAcc_Load_1(object sender, EventArgs e)
        {

        }

        private void groupPanel4_Click(object sender, EventArgs e)
        {

        }

        private void txt_Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAcc_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtAcc.ID.Text.Trim() != string.Empty)
            {
                txt_Desc.Focus();
            }
        }

        private void txtCost_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCost.Text.Trim() != string.Empty)
            {
                txtCatogry.ID.Focus();
            }
        }

        private void txtCatogry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.Focus();

            }
        }
    }
}

