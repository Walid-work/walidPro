using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_PE_Jor : Form
    {
        DataTable dt = new DataTable();
        DataTable dt_P_Jor = new DataTable();
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_PE_Jor()
        {
            InitializeComponent();
            //creatDattable();
            creatDattable_1();
            resizeDG();
        }

        private void uC_AccBranch1_Load(object sender, EventArgs e)
        {

        }



        private void showDetails()
        {


            ////==============================  احضار تفاصيل القيد =========================================================//
     
            DataTable dt_ = new DataTable();
            dt_.Clear();
            dt_ = dal.getDataTabl_1(@"select X.*,p1.MAIN_MEZAN as p_MAIN_MEZAN,p1.Payer_Name as Payer_Name_1,S.main_daily_ser+1 as daily_ser,
            S.daily_sn_ser+1 as M_daily_ser from (select A.*,B.P_ser,B.p_date,B.P_days,B.p_amount,B.p_year,B.p_Quarter,
            D.BRANCH_name,C.CAT_NAME,p.Payer_Name,p.MAIN_MEZAN as MAIN_MEZAN ,COST_name
            from P_expenses_T1 as A inner join P_expenses_T2 as B on A.id=B.id 
            left join CATEGORY AS C ON A.category_code=C.CAT_CODE 
            inner join BRANCHS AS D ON A.branch_code=D.BRANCH_code
            left join payer2 as P on P.acc_no = A.Kind and P.branch_code=A.branch_code 
			inner join COST_CENTER as CS on CS.COST_CODE=A.costCode 

            where isnull(Recorded,0)<>1 and A.branch_code like '" + Branch_.ID.Text + "%'  and acc_no_p like '"+Acc_.ID.Text+"%' and cast(p_date as date) between '" +
            fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "'  and A.id like case when '"+txtID.Text+"' = ''  then '%' else '"+txtID.Text+"' end ) As X " +
            "left join payer2 as P1 on P1.acc_no = X.Acc_no_P and P1.branch_code=X.branch_code" +
            " inner join serial_no As S on X.branch_code = S.branch_code and S.ACC_YEAR='"+ txtAcc_year.Text+"' ");

            if (dt_.Rows.Count > 0)
            {



                dt_P_Jor.Clear();
                DataRow row = null;
                for (int i = 0; i <= dt_.Rows.Count - 1; i++)
                {

                    DataRow row_ = dt_.Rows[i];
                    row = dt_P_Jor.NewRow();
                    row[0] = Convert.ToDecimal(dt_.Rows[i]["p_amount"]).ToString("n" + dal.digits_);
                    row[1] = 0;
                    row[2] = dt_.Rows[i]["kind"].ToString();
                    row[3] = dt_.Rows[i]["Payer_Name"].ToString();
                    row[4] = "اقفال " + dt_.Rows[i]["descr"].ToString() + " - " + DateTime.Parse(dt_.Rows[i]["p_Date"].ToString()).ToString("yyyy/MM");
                    row[5] = dt_.Rows[i]["costCode"].ToString();
                    row[6] = dt_.Rows[i]["COST_name"].ToString();
                    row[7] = dt_.Rows[i]["category_code"].ToString();
                    row[8] = dt_.Rows[i]["CAT_NAME"].ToString();
                    row[9] = dt_.Rows[i]["MAIN_MEZAN"].ToString();
                    row[10] = dt_.Rows[i]["id"].ToString();
                    row[11] = dt_.Rows[i]["P_ser"].ToString();

                    dt_P_Jor.Rows.Add(row);
                    i = i++;
                }

                for (int i = 0; i <= dt_.Rows.Count - 1; i++)
                {

                    DataRow row_ = dt_.Rows[i];
                    row = dt_P_Jor.NewRow();
                    row[0] = 0;
                    row[1] = Convert.ToDecimal(dt_.Rows[i]["p_amount"]).ToString("n" + dal.digits_);
                    row[2] = dt_.Rows[i]["Acc_no_p"].ToString();
                    row[3] = dt_.Rows[i]["Payer_Name_1"].ToString();
                    row[4] = "اقفال " + dt_.Rows[i]["descr"].ToString() + " - " + DateTime.Parse(dt_.Rows[i]["p_Date"].ToString()).ToString("yyyy/MM");
                    row[5] = dt_.Rows[i]["costCode"].ToString();
                    row[6] = dt_.Rows[i]["COST_name"].ToString();
                    row[7] = dt_.Rows[i]["category_code"].ToString();
                    row[8] = dt_.Rows[i]["CAT_NAME"].ToString();
                    row[9] = dt_.Rows[i]["p_MAIN_MEZAN"].ToString();
                    row[10] = dt_.Rows[i]["id"].ToString();
                    row[11] = dt_.Rows[i]["P_ser"].ToString();

                    dt_P_Jor.Rows.Add(row);
                    i = i++;
                }

                dGV_Item.DataSource = dt_P_Jor;


            }


            else
            {
                MessageBox.Show(" لا يوجد استحقاق للفترة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //void creatDattable()
        //{
        //    dt.Columns.Add("كود الفرع");
        //    dt.Columns.Add(" اسم الفرع");
        //    dt.Columns.Add(" تاريخ الاستحقاق");
        //    dt.Columns.Add(" المبلغ");
        //    dt.Columns.Add("رقم التصنيف");
        //    dt.Columns.Add("التصنيف");
        //    dt.Columns.Add("حساب المصروف");
        //    dt.Columns.Add("وصف حساب المصروف");
        //    dt.Columns.Add("المصروف الرئيسي");
        //    dt.Columns.Add("حساب المقدم");
        //    dt.Columns.Add("وصف حساب المقدم");
        //    dt.Columns.Add("المقدم الرئيسي");
        //    dt.Columns.Add("رقم القيد");
        //    dt.Columns.Add("رقم السند");
        //    dt.Columns.Add("الرقم الرئيسي");
        //    dt.Columns.Add("رقم التكلفة");
        //    dt.Columns.Add("وصف التكلفة");
        //    dt.Columns.Add("مسلسل");
        //    dt.Columns.Add("رقم الدفعة");

        //    dGV_.DataSource = dt;
        //}
        void resizeDG()
        {
            dGV_Item.Columns[0].Width = 80;
            dGV_Item.Columns[1].Width = 80;
            dGV_Item.Columns[2].Width = 90;
            dGV_Item.Columns[3].Width = 150;
            dGV_Item.Columns[4].Width = 250;
            dGV_Item.Columns[5].Width = 50;
            dGV_Item.Columns[6].Width = 140;
            dGV_Item.Columns[7].Width = 50;
            dGV_Item.Columns[8].Width = 140;

            foreach (DataGridViewRow row in this.dGV_Item.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                dGV_Item.EnableHeadersVisualStyles = false;


            }
        }


        void creatDattable_1()
        {
            dt_P_Jor.Columns.Add("مدين");
            dt_P_Jor.Columns.Add(" دائن");
            dt_P_Jor.Columns.Add(" كود الحساب");
            dt_P_Jor.Columns.Add(" اسم الحساب");
            dt_P_Jor.Columns.Add("البيان");
            dt_P_Jor.Columns.Add(" كود الكلفة");
            dt_P_Jor.Columns.Add("مركز الكلفة");
            dt_P_Jor.Columns.Add("رقم التصنيف");
            dt_P_Jor.Columns.Add("التصنيف");
            dt_P_Jor.Columns.Add("كود الحساب الرئيسي");
            dt_P_Jor.Columns.Add("مسلسل");
            dt_P_Jor.Columns.Add("رقم الدفعة");
            dGV_Item.DataSource = dt_P_Jor;
            dGV_Item.Columns[9].Visible = false;
            dGV_Item.Columns[10].Visible = false;
            dGV_Item.Columns[11].Visible = false;
        }


        private void btnReport_Click(object sender, EventArgs e)
        {
            if (Branch_.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" فضلا اختر الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            getJorSer();
            showDetails();

            DataTable dt_ = dal.getDataTabl_1(@"SELECT pass_id,Description,Password  FROM tblPassword where pass_id='pass3' and Password='" + txtpass.Text + "' ");
            if (dt_.Rows.Count > 0)
            {
                if (dGV_Item.Rows.Count > 0 && txtpass.Text == dt_.Rows[0]["Password"].ToString())
                {
                    btn_AddJor.Enabled = true;
                    buttonX2.Enabled = true;
                }
                else
                {
                    btn_AddJor.Enabled = false;
                    buttonX2.Enabled = false;
                }
            }
            else
            {
                btn_AddJor.Enabled = false;
                buttonX2.Enabled = false;
            }
            total_inv();
            resizeDG();


        }

      
        private void frm_PE_Jor_Load(object sender, EventArgs e)
        {
            Branch_.txtFinal.Text = "1";
        }


        private void getJorSer()
        {

            this.txtSerNo.Text = "M" + dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) from serial_no where BRANCH_CODE='" + Branch_.ID.Text
                     + "' and ACC_YEAR= '" + txtAcc_year.Text + "'").Rows[0][0].ToString().PadLeft(4, '0');

            this.Main_serNo.Text = dal.getDataTabl_1(@"select isnull(daily_sn_ser+1,1) from serial_no where BRANCH_CODE='" + Branch_.ID.Text
                 + "' and ACC_YEAR= '" + txtAcc_year.Text + "' ").Rows[0][0].ToString();//.PadLeft(4, '0');


        }

        private void btn_AddJor_Click(object sender, EventArgs e)
        {
            int JorSer;
            getJorSer();
            total_inv();
                        if (totalDebit.Value <= 0 || totalCredit.Value <= 0 || totalDebit.Value != totalCredit.Value)
                        {
                            MessageBox.Show("تأكد من توازن القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                       
                      

                        if (txtSerNo.Text.Contains('M'))
                        {
                            var Jor_ser = txtSerNo.Text.Split('M');
                            JorSer = Convert.ToInt32(Jor_ser[1]);
                        }
                        
                        else
                        {
                            JorSer = Convert.ToInt32(txtSerNo.Text);
                        }

            for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            {
                DataGridViewRow row_ = dGV_Item.Rows[i];
                dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no,MAIN_MEZAN, COST_CENTER, meno, loh
                , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                VALUES('" + txtAcc_year.Text + "','" + row_.Cells[2].Value.ToString() + "','" + Branch_.ID.Text + "','" +
                txtSerNo.Text + "','"+ row_.Cells[9].Value.ToString() + "','" + row_.Cells[5].Value.ToString() + "','" + row_.Cells[0].Value.ToString().ToDecimal() +
                "','"+row_.Cells[1].Value.ToString().ToDecimal() +"','" + row_.Cells[0].Value.ToString()+"','" + toDate.Value.ToString("yyyy/MM/dd HH:mm:ss") + "','" +
                Main_serNo.Text + "','6','" + Program.userID + "','" + row_.Cells[4].Value.ToString() + "','0','" + row_.Cells[7].Value.ToString() +
                "','" + JorSer + "')");

                dal.Execute_1(@"UPDATE P_expenses_T2 SET Recorded='1',Jor_No='"+ txtSerNo.Text+"' WHERE id=  '" + row_.Cells[10].Value.ToString() + "' and P_ser='" + row_.Cells[11].Value.ToString() + "' ");

            }

            dal.Execute_1(@"UPDATE serial_no SET daily_sn_ser='" + Main_serNo.Text + "' , main_daily_ser = '" + JorSer + "' WHERE BRANCH_CODE=  '" + Branch_.ID.Text + "' and ACC_YEAR='" + txtAcc_year.Text + "' ");

            MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         btn_AddJor.Enabled = false;
                      
                   
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


        private void buttonX1_Click(object sender, EventArgs e)
        {
            frm_Create_PE_Jor frm = new frm_Create_PE_Jor();
            frm.ShowDialog();
            //RPT.Form1 frm = new RPT.Form1();
            //RPT.rpt_DailyEntry rpt_DailyEntry = new RPT.rpt_DailyEntry();
            //rpt_DailyEntry.SetDataSource(dal.getDataTabl("GetDaily_transaction_", Properties.Settings.Default.BranchId, txtSerNo.Text));
            //frm.crystalReportViewer1.ReportSource = rpt_DailyEntry;
            //frm.ShowDialog();

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            {
                DataGridViewRow row_ = dGV_Item.Rows[i];
                dal.Execute_1(@"UPDATE P_expenses_T2 SET Recorded='1',Jor_No='N' WHERE id=  '" + row_.Cells[10].Value.ToString() + "' and P_ser='" + row_.Cells[11].Value.ToString() + "' ");

            }
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            {
                DataGridViewRow row_ = dGV_Item.Rows[i];
                dal.Execute_1(@"UPDATE P_expenses_T2 SET Recorded=NULL,Jor_No=NULL WHERE id=  '" + row_.Cells[10].Value.ToString() + "' and P_ser='" + row_.Cells[11].Value.ToString() + "' ");

            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1(@"SELECT pass_id,Description,Password  FROM tblPassword where pass_id='pass3' and Password='" + txtpass.Text + "' ");
            if (dt_.Rows.Count > 0)
            {
                if (dGV_Item.Rows.Count > 0 && txtpass.Text == dt_.Rows[0]["Password"].ToString())
                {
                    btn_AddJor.Enabled = true;
                    buttonX2.Enabled = true;
                }
                else
                {
                    btn_AddJor.Enabled = false;
                    buttonX2.Enabled = false;
                }
            }
            else
            {
                btn_AddJor.Enabled = false;
                buttonX2.Enabled = false;
            }
        }
    }
}
