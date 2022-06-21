using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_Create_PE_Jor   : Form
    {
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Create_PE_Jor()
        {
            InitializeComponent();
            creatDattable();
            creatDattable_1();
        }

        private void uC_AccBranch1_Load(object sender, EventArgs e)
        {
            showDetails();
            
        }



        private void showDetails()
        {


            ////==============================  احضار تفاصيل القيد =========================================================//
            try
            {
               

                DataTable dt_ = new DataTable();
                dt_.Clear();
                dt_ = dal.getDataTabl_1(@"select B.p_amount,A.kind,p.Payer_Name,a.branch_code,D.BRANCH_name,A.category_code,C.CAT_NAME,p.MAIN_MEZAN,MONTH(B.p_date)
                from P_expenses_T1 as A inner join P_expenses_T2 as B on A.id=B.id
                left join CATEGORY AS C ON A.category_code=C.CAT_CODE 
                inner join BRANCHS AS D ON A.branch_code=D.BRANCH_code 
                left join payer2 as P on P.acc_no = A.kind and P.branch_code=A.branch_code 
                inner join serial_no As S on A.branch_code = S.branch_code and S.ACC_YEAR='" + txtAcc_year.Text +
                    "' where A.branch_code = '" + Branch_.ID.Text + "' and acc_no_p like '" + Acc_.ID.Text + "%' and cast(p_date as date) between '" +
                    fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "'");

                if (dt_.Rows.Count > 0)
                {




                    dt.Clear();
                    int i = 0;
                    DataRow row = null;
                    foreach (DataRow r in dt_.Rows)
                    {

                        row = dt.NewRow();
                        row[0] = Convert.ToDecimal(dt_.Rows[i][0]).ToString("n" + dal.digits_);
                        row[1] = dt_.Rows[i][1].ToString();
                        row[2] = dt_.Rows[i][2].ToString();
                        row[3] = dt_.Rows[i][3].ToString();
                        row[4] = dt_.Rows[i][4].ToString();
                        row[5] = dt_.Rows[i][5].ToString();
                        row[6] = dt_.Rows[i][6].ToString();
                        row[7] = dt_.Rows[i][7].ToString();
                        row[8] = dt_.Rows[i][8].ToString();
                        dt.Rows.Add(row);
                        i = i + 1;
                    }

                    dGV_.DataSource = dt;
                    //resizeDG();
                    //total_inv();
                }
                else
                {
                    dGV_.DataSource = null;
                    dGV_.Rows.Clear();
                     }



                DataTable dt_1 = new DataTable();
                    dt_1.Clear();
                    dt_1 = dal.getDataTabl_1(@"select sum(p_amount),Acc_no_p,Payer_Name,branch_code,BRANCH_name,MAIN_MEZAN, Month_ from (select B.p_amount,A.Acc_no_p,p.Payer_Name,a.branch_code,D.BRANCH_name,A.category_code,C.CAT_NAME,p.MAIN_MEZAN,MONTH(B.p_date) as Month_
                from P_expenses_T1 as A inner join P_expenses_T2 as B on A.id=B.id
                left join CATEGORY AS C ON A.category_code=C.CAT_CODE 
                inner join BRANCHS AS D ON A.branch_code=D.BRANCH_code 
                left join payer2 as P on P.acc_no = A.kind and P.branch_code=A.branch_code 
                inner join serial_no As S on A.branch_code = S.branch_code and S.ACC_YEAR='"+txtAcc_year.Text+"' where A.branch_code = '"+Branch_.ID.Text+
                "' and acc_no_p like '"+Acc_.ID.Text+ "%' and cast(p_date as date) between '" + fromDate.Value.ToString("yyyy-MM-dd") + 
                "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' ) as X  group by Acc_no_p,Payer_Name,branch_code,BRANCH_name,MAIN_MEZAN, Month_");
                    if (dt_1.Rows.Count > 0)
                    {




                        dt1.Clear();
                        int ii = 0;
                        DataRow row_1 = null;
                        foreach (DataRow r in dt_1.Rows)
                        {

                            row_1 = dt1.NewRow();
                            row_1[0] = Convert.ToDecimal(dt_1.Rows[ii][0]).ToString("n" + dal.digits_);
                            row_1[1] = dt_1.Rows[ii][1].ToString();
                            row_1[2] = dt_1.Rows[ii][2].ToString();
                            row_1[3] = dt_1.Rows[ii][3].ToString();
                            row_1[4] = dt_1.Rows[ii][4].ToString();
                            row_1[5] = "1";
                            row_1[6] = "عام";
                            row_1[7] = dt_1.Rows[ii][5].ToString();
                            row_1[8] = dt_1.Rows[ii][6].ToString();
                            dt1.Rows.Add(row_1);
                            ii = ii + 1;
                        }

                        dGV_1.DataSource = dt1;
                        //resizeDG();





                    }
                   
                

                else
                {
                 dGV_1.DataSource = null;
                dGV_1.Rows.Clear();
                   }

                DataTable dt_ser = dal.getDataTabl_1(@"select main_daily_ser+1,daily_sn_ser+1 from serial_no where BRANCH_code= '" + Branch_.ID.Text + "' and ACC_YEAR='" + txtAcc_year.Text + "'");
                if (dt_ser.Rows.Count > 0)
                {
                    txtSerNo.Text = "M" + dt_ser.Rows[0][0].ToString();
                    Main_serNo.Text =  dt_ser.Rows[0][1].ToString();
                    mainSer.Text = dt_ser.Rows[0][0].ToString();

                }
                else
                {
                    txtSerNo.Clear();
                    Main_serNo.Clear();
                    mainSer.Clear();
                }

            }
            catch {
            }
        }

        void creatDattable()
        {
            dt.Columns.Add("مدين");
            dt.Columns.Add("كود الحساب");
            dt.Columns.Add("وصف الحساب");
            dt.Columns.Add("كود الفرع");
            dt.Columns.Add(" اسم الفرع");
            dt.Columns.Add("رقم التصنيف");
            dt.Columns.Add("التصنيف");
            dt.Columns.Add("كود الحساب الرئيسي");
            dt.Columns.Add("شهر الاستحقاق");

            dGV_.DataSource = dt;
        }


        void creatDattable_1()
        {
            dt1.Columns.Add(" دائن");
            dt1.Columns.Add("كود الحساب");
            dt1.Columns.Add("وصف الحساب");
            dt1.Columns.Add("كود الفرع");
            dt1.Columns.Add(" اسم الفرع");
            dt1.Columns.Add("رقم التصنيف");
            dt1.Columns.Add("التصنيف");
            dt1.Columns.Add("كود الحساب الرئيسي");
            dt1.Columns.Add("شهر الاستحقاق");


            dGV_1.DataSource = dt1;
        }



        private void btnReport_Click(object sender, EventArgs e)
        {

            DataTable dt_B = dal.getDataTabl_1(@"select * from BRANCHS where BRANCH_code= '" + Branch_.ID.Text + "' and T_final='1'");
            if (dt_B.Rows.Count > 0)
            {
                    showDetails();             
            }
            else
            {
                MessageBox.Show("يرجي اختيار الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }


         
           
        



        private void btnOption_Click(object sender, EventArgs e)
        {
           
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void toDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frm_PE_Jor_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddJor_Click(object sender, EventArgs e)
        {


            for (int i = 0; i <= dGV_.Rows.Count - 1; i++)
            {
                DataGridViewRow row_ = dGV_.Rows[i];
                dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, MAIN_MEZAN, meno, loh
            , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
            VALUES('" + txtAcc_year.Text + "','" + row_.Cells[1].Value.ToString() + "','" + Branch_.ID.Text + "','" +
                txtSerNo.Text + "','1','" + row_.Cells[7].Value.ToString() + "','" + row_.Cells[0].Value.ToString().ToDecimal() +
                "','0','" + row_.Cells[0].Value.ToString().ToDecimal() + "','" + toDate.Value.ToString("yyyy/MM/dd HH:mm:ss") + "','" +
                Main_serNo.Text + "','6','waled','اقفال مقدم شهر " + row_.Cells[2].Value.ToString() + "','0','" + row_.Cells[5].Value.ToString() +
                "','" + mainSer.Text + "')");
            }

            for (int i = 0; i <= dGV_1.Rows.Count - 1; i++)
            {
                DataGridViewRow row_1 = dGV_1.Rows[i];
                dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, MAIN_MEZAN, meno, loh
            , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
            VALUES('" + txtAcc_year.Text + "','" + row_1.Cells[1].Value.ToString() + "','" + Branch_.ID.Text + "','" +
                 txtSerNo.Text + "','1','" + row_1.Cells[7].Value.ToString() + "','0','" + row_1.Cells[0].Value.ToString().ToDecimal() +
                "','" + -row_1.Cells[0].Value.ToString().ToDecimal() + "','" + toDate.Value.ToString("yyyy/MM/dd HH:mm:ss") + "','" +
                Main_serNo.Text + "','6','waled','اقفال مقدم شهر " + row_1.Cells[2].Value.ToString() + "','0','" + row_1.Cells[5].Value.ToString() +
                "','" + mainSer.Text + "')");


            }
            dal.Execute_1(@"UPDATE serial_no SET main_daily_ser='" + mainSer.Text + "' , daily_sn_ser = '" + Main_serNo.Text + "' WHERE BRANCH_CODE=  '" + Branch_.ID.Text+ "' and ACC_YEAR='" + txtAcc_year.Text + "' ");

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {


            RPT.Form1 frm = new RPT.Form1();
            RPT.rpt_DailyEntry rpt_DailyEntry = new RPT.rpt_DailyEntry();
            rpt_DailyEntry.SetDataSource(dal.getDataTabl("GetDaily_transaction_", Properties.Settings.Default.BranchId, txtSerNo.Text));
            frm.crystalReportViewer1.ReportSource = rpt_DailyEntry;
            frm.ShowDialog();

        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
