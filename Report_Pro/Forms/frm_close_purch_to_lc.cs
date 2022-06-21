using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Report_Pro.Forms
{
    public partial class frm_close_purch_to_lc:frm_Master
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        DataTable dt1;
        public frm_close_purch_to_lc()
        {
            InitializeComponent();
        }

        private void frm_close_purch_to_lc_Load(object sender, EventArgs e)
        {
            Uc_AccBranch.ID.Text = Properties.Settings.Default.BranchAccID;
            getJorSer();
        }






        private void getData()
        {



           


                dt1 = dal.getDataTabl_1(@"SELECT ACC_NO,ser_no,cast(g_date as date) as g_date,desc2,loh-meno as amount,Sp_Inv_No,isnull(INv_NO,'') as INv_NO,in_date,LC_NO FROM daily_transaction 
                    where Acc_no = '" + Uc_Vendor.ID.Text + "'  and SOURCE_CODE like 'xp%'  and ISNULL(inv_no ,'0')='0' and BRANCH_code = '" + Uc_AccBranch.ID.Text +
                       "' and Sp_Inv_No like '" + txtSearchByDelevry.Text + "%'  order by Sp_Inv_No ");




                int B_rowscount = dt1.Rows.Count;
                dgv1.Rows.Clear();
                dgv1.Rows.Add(B_rowscount);
                for (int i = 0; (i <= (B_rowscount - 1)); i++)
                {
                    dgv1.Rows[i].Cells[0].Value = dt1.Rows[i]["ser_no"];
                    dgv1.Rows[i].Cells[1].Value = dt1.Rows[i]["g_date"];
                    dgv1.Rows[i].Cells[2].Value = dt1.Rows[i]["desc2"];
                    dgv1.Rows[i].Cells[3].Value = dt1.Rows[i]["amount"].ToString().ToDecimal().ToString("N2");
                    dgv1.Rows[i].Cells[4].Value = dt1.Rows[i]["Sp_Inv_No"];
                }

                Get_Total();

               
        }




        


        private void btn_GetData_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void dgv1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgv2.Rows.Count - 1; i++)
            {
                if (dgv2.Rows[i].Cells[4].Value.ToString() == dgv1.CurrentRow.Cells[4].Value.ToString())
                {
                    MessageBox.Show("هذا الاستلام مضاف من قبل", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            
            int n1 = dgv2.Rows.Add();
            dgv2.Rows[n1].Cells[0].Value = dgv1.CurrentRow.Cells[0].Value.ToString();
            dgv2.Rows[n1].Cells[1].Value = dgv1.CurrentRow.Cells[1].Value.ToString();
            dgv2.Rows[n1].Cells[2].Value = dgv1.CurrentRow.Cells[2].Value.ToString();
            dgv2.Rows[n1].Cells[3].Value = dgv1.CurrentRow.Cells[3].Value.ToString();
            dgv2.Rows[n1].Cells[4].Value = dgv1.CurrentRow.Cells[4].Value.ToString();
            dgv1.Rows.RemoveAt(this.dgv1.CurrentRow.Index);

            Get_Total();
        
        }

        private void dgv2_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count > 0)
            {
                int n1 = dgv1.Rows.Add();
                dgv1.Rows[n1].Cells[0].Value = dgv2.CurrentRow.Cells[0].Value.ToString();
                dgv1.Rows[n1].Cells[1].Value = dgv2.CurrentRow.Cells[1].Value.ToString();
                dgv1.Rows[n1].Cells[2].Value = dgv2.CurrentRow.Cells[2].Value.ToString();
                dgv1.Rows[n1].Cells[3].Value = dgv2.CurrentRow.Cells[3].Value.ToString();
                dgv1.Rows[n1].Cells[4].Value = dgv2.CurrentRow.Cells[4].Value.ToString();
                dgv2.Rows.RemoveAt(this.dgv2.CurrentRow.Index);
                Get_Total();
            }
        }
        private void Get_Total()
        {
            txt_totalAmount.Text =
                         (from DataGridViewRow row in dgv1.Rows
                          where row.Cells[0].FormattedValue.ToString() != string.Empty
                          select (row.Cells[3].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            txt_totalAmount_1.Text =
             (from DataGridViewRow row in dgv2.Rows
              where row.Cells[0].FormattedValue.ToString() != string.Empty
              select (row.Cells[3].FormattedValue).ToString().ToDecimal()).Sum().ToString();


        }

        private void dgv1_SortStringChanged(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = dt1;

        }

        private void txt_Sup_inv_KeyUp(object sender, KeyEventArgs e)
        {
            getData();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (Uc_AccBranch.ID.Text.Trim() != string.Empty && Uc_Vendor.ID.Text.Trim() != string.Empty
                && Uc_Lc.ID.Text.Trim() != string.Empty && dal.IsDateTime(txt_vend_inv_date.Text)
                && txt_vend_inv_no.Text.Trim() != string.Empty && txt_totalAmount_1.Value > 0)
            {
                int JorSer;
                getJorSer();
                if (txtSerNo.Text.Contains('M'))
                {
                    var Jor_ser = txtSerNo.Text.Split('M');
                    JorSer = Convert.ToInt32(Jor_ser[1]);
                }

                else
                {
                    JorSer = Convert.ToInt32(txtSerNo.Text);
                }

                string desc_1 = "تحويل قيمة فاتورة رقم " + txt_vend_inv_no.Text + " الي حساب اعتماد رقم " + Uc_Lc.ID.Text;
                string desc_2 = "قيمة فاتورة رقم " + txt_vend_inv_no.Text + " من حساب المورد رقم " + Uc_Vendor.ID.Text;
                dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no,MAIN_MEZAN, COST_CENTER, meno, loh
                , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO,inv_no,inv_date)
                VALUES('" + txtAcc_year.Text + "','" + Uc_Vendor.ID.Text + "','" + Uc_AccBranch.ID.Text + "','" +
                    txtSerNo.Text + "','','1','" + txt_totalAmount_1.Value +
                    "','0','" + txt_totalAmount_1.Value + "','" + txt_entryDate.Value.ToString("yyyy/MM/dd HH:mm:ss") + "','" +
                    Main_serNo.Text + "','6','" + Program.userID + "','"+desc_1+"','0','1','" + JorSer + "','" + txt_vend_inv_no.Text + "','" + txt_vend_inv_date.Value.ToString("yyyy/MM/dd HH:mm:ss") + "')");

                dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no,MAIN_MEZAN, COST_CENTER, meno, loh
                , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                VALUES('" + txtAcc_year.Text + "','" + Uc_Lc.ID.Text + "','" + Uc_AccBranch.ID.Text + "','" +
                   txtSerNo.Text + "','','1','0','" + txt_totalAmount_1.Value +
                   "','" + -txt_totalAmount_1.Value + "','" + txt_entryDate.Value.ToString("yyyy/MM/dd HH:mm:ss") + "','" +
                   Main_serNo.Text + "','6','" + Program.userID + "','" + desc_2 + "','0','1','" + JorSer + "')");

                dal.Execute_1(@"UPDATE serial_no SET daily_sn_ser='" + Main_serNo.Text + "' , main_daily_ser = '" + JorSer + "' WHERE BRANCH_CODE=  '" + Uc_AccBranch.ID.Text + "' and ACC_YEAR='" + txtAcc_year.Text + "' ");


                for (int i = 0; i <= dgv2.Rows.Count - 1; i++)
                {
                    DataGridViewRow row_ = dgv2.Rows[i];
                    dal.Execute_1(@"UPDATE daily_transaction SET inv_no='"+txt_vend_inv_no.Text+ "',inv_date='" + txt_vend_inv_date.Value.ToString("yyyy/MM/dd HH:mm:ss") + "' WHERE ser_no=  '" + row_.Cells[0].Value.ToString() + "' and ACC_NO='" + Uc_Vendor.ID.Text + "' ");

                }




                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تأكد من البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void getJorSer()
        {
            DataTable dt_jorSer = dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) as _ser,isnull(daily_sn_ser+1,1) as _mainSer from serial_no where BRANCH_CODE='" + Uc_AccBranch.ID.Text
                     + "' and ACC_YEAR= '" + txtAcc_year.Text + "'");
            if (dt_jorSer.Rows.Count > 0)
            {
                txtSerNo.Text = "M" +dt_jorSer.Rows[0]["_ser"].ToString().PadLeft(4, '0');
                Main_serNo.Text = dt_jorSer.Rows[0]["_mainSer"].ToString();
            }
            else
            {
                txtSerNo.Text = "";
                 Main_serNo.Text = "";
            }

            //Main_serNo.Text = dal.getDataTabl_1(@"select isnull(daily_sn_ser+1,1) from serial_no where BRANCH_CODE='" + Uc_AccBranch.ID.Text
            //     + "' and ACC_YEAR= '" + txtAcc_year.Text + "' ").Rows[0][0].ToString();//.PadLeft(4, '0');


        }

        private void Uc_AccBranch_Load(object sender, EventArgs e)
        {
            getJorSer();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void btn_Added_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv1.SelectedRows)
            {


                for (int i = 0; i <= dgv2.Rows.Count - 1; i++)
                {
                    if (dgv2.Rows[i].Cells[4].Value.ToString() == r.Cells[4].Value.ToString())
                    {
                        MessageBox.Show("هذا الاستلام مضاف من قبل", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                int n1 = dgv2.Rows.Add();
                dgv2.Rows[n1].Cells[0].Value = r.Cells[0].Value.ToString();
                dgv2.Rows[n1].Cells[1].Value = r.Cells[1].Value.ToString();
                dgv2.Rows[n1].Cells[2].Value = r.Cells[2].Value.ToString();
                dgv2.Rows[n1].Cells[3].Value = r.Cells[3].Value.ToString();
                dgv2.Rows[n1].Cells[4].Value = dgv1.CurrentRow.Cells[4].Value.ToString();
                dgv1.Rows.RemoveAt(r.Index);

                Get_Total();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow r in dgv2.SelectedRows)
                {

                    int n1 = dgv1.Rows.Add();
                    dgv1.Rows[n1].Cells[0].Value = dgv2.CurrentRow.Cells[0].Value.ToString();
                    dgv1.Rows[n1].Cells[1].Value = dgv2.CurrentRow.Cells[1].Value.ToString();
                    dgv1.Rows[n1].Cells[2].Value = dgv2.CurrentRow.Cells[2].Value.ToString();
                    dgv1.Rows[n1].Cells[3].Value = dgv2.CurrentRow.Cells[3].Value.ToString();
                    dgv1.Rows[n1].Cells[4].Value = dgv2.CurrentRow.Cells[4].Value.ToString();
                    dgv2.Rows.RemoveAt(this.dgv2.CurrentRow.Index);
                    Get_Total();
                }
            }
        }
    }  
}
