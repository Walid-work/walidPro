using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
////using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_Update_invoiceData : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Update_invoiceData()
        {
            InitializeComponent();

            comboBox1.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            comboBox1.SelectedItem = DateTime.Now.Year;

            cmb_Branch.DataSource = dal.getDataTabl("Get_branch_","",dal.db1);
            cmb_Branch.DisplayMember = "branch_name";
            cmb_Branch.ValueMember = "Branch_code";
            cmb_Branch.SelectedValue = "A1112";


           cmb_transaction.DataSource = dal.getDataTabl("Get_transacton_",dal.db1);
           cmb_transaction.DisplayMember = "INV_NAME";
           cmb_transaction.ValueMember = "INV_CODE";
           cmb_transaction.SelectedValue = "xpc";
        }

        private void frm_Update_custom_no_Load(object sender, EventArgs e)
        {
           // dal.Execute("updat_custom_no", txt_inv_no.Text, Convert.ToString(cmb_transaction.SelectedValue), Convert.ToString(cmb_Branch.SelectedValue), txt_custom_date.Value.ToShortDateString, txt_custom_no.Text);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            dal.Execute_1(@"update main_acc_wh.dbo.wh_inv_data set G_date='" + G_date.Value.ToString("yyyy/MM/dd") + "', inv_Date='" + invDate.Value.ToString("yyyy/MM/dd") + "',inv_NO='" + invNo.Text + "',COSTMER_K_M_NO='" + txt_VatNo.Text + "',Cash_costomer_name='" + txt_Supp.Text + "'" +
                "  where  Ser_no ='" + txt_inv_no.Text + "' and Transaction_code ='" + Convert.ToString(cmb_transaction.SelectedValue) + "' and Branch_code ='" + Convert.ToString(cmb_Branch.SelectedValue) + "' and Cyear ='" + comboBox1.Text.Substring(comboBox1.Text.Length - 2) + "'");
           
            dal.Execute_1(@"  update main_acc_wh.dbo.wh_material_transaction set G_date='" + G_date.Value.ToString("yyyy/MM/dd") + "' where  Ser_no ='" + txt_inv_no.Text + "' and Transaction_code ='" +
                Convert.ToString(cmb_transaction.SelectedValue) + "' and Branch_code ='" + Convert.ToString(cmb_Branch.SelectedValue) + "' and Cyear ='" + comboBox1.Text.Substring(comboBox1.Text.Length - 2) + "'");

            dal.Execute_1(@" update main_acc_wh.dbo.daily_transaction set G_date='" + G_date.Value.ToString("yyyy/MM/dd") + "' where  ser_no ='" + acc_ser.Text + "' and Branch_code ='" + Convert.ToString(cmb_Branch.SelectedValue) + "'");


            //dal.Execute("updat_custom_no", txt_inv_no.Text, Convert.ToString(cmb_transaction.SelectedValue), Convert.ToString(cmb_Branch.SelectedValue), invDate.Value.Date, invNo.Text, comboBox1.Text.Substring(comboBox1.Text.Length - 2));
            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_inv_no.Clear();
            invNo.Clear();
            txt_inv_no.Focus();
           
        }

        private void txt_inv_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_inv_no.Text != string.Empty)
            {
                invNo.Focus();
                invNo.SelectAll();
            }
        }

        private void txt_custom_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && invNo.Text != string.Empty)
            {
                invDate.Focus();
            }
        }

        private void txt_custom_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
            }
        }

        private void frm_Update_custom_no_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void txt_inv_no_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                DataTable dt_ =dal.getDataTabl_1(@"select  inv_date, Inv_No, G_date,Cash_costomer_name,COSTMER_K_M_NO,acc_serial_no from main_acc_wh.dbo.wh_inv_data 
                 where Ser_no ='" + txt_inv_no.Text+"' and Transaction_code ='"+ Convert.ToString(cmb_transaction.SelectedValue)+"' and Branch_code ='"+ Convert.ToString(cmb_Branch.SelectedValue)+"' and Cyear ='"+ comboBox1.Text.Substring(comboBox1.Text.Length - 2)+"'");
               
                    
                //    DataTable dt_ = dal.getDataTabl("get_Inv_Data", txt_inv_no.Text, Convert.ToString(cmb_transaction.SelectedValue), Convert.ToString(cmb_Branch.SelectedValue), comboBox1.Text.Substring(comboBox1.Text.Length - 2));
                ////  MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


              
                invNo.Text = dt_.Rows[0][1].ToString();
                invDate.Text = dt_.Rows[0][0].ToString();
              
                txt_Supp.Text= dt_.Rows[0][3].ToString();
                txt_VatNo.Text = dt_.Rows[0][4].ToString();
                G_date.Text =dt_.Rows[0][2].ToString();
                acc_ser.Text = dt_.Rows[0][5].ToString();

            }
            catch
            { }

        }

        private void labelX12_Click(object sender, EventArgs e)
        {

        }

        private void inv_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void invNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void inv_date_Click(object sender, EventArgs e)
        {

        }

        private void invDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void new_G_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_inv_no_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
