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
    public partial class frm_Update_custom_no : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        public frm_Update_custom_no()
        {
            InitializeComponent();

            comboBox1.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            comboBox1.SelectedItem = DateTime.Now.Year;

        }

        private void frm_Update_custom_no_Load(object sender, EventArgs e)
        {
           // dal.Execute("updat_custom_no", txt_inv_no.Text, Convert.ToString(cmb_transaction.SelectedValue), Convert.ToString(cmb_Branch.SelectedValue), txt_custom_date.Value.ToShortDateString, txt_custom_no.Text);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dal.Execute("updat_custom_no_", txt_inv_no.Text, txtTransaction.ID.Text, txtBranch.ID.Text, txt_custom_date.Value.Date, txt_custom_no.Text, comboBox1.Text.Substring(comboBox1.Text.Length - 2),dal.db1);
            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_inv_no.Clear();
            txt_custom_no.Clear();
            txt_inv_no.Focus();
           
        }

        private void txt_inv_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_inv_no.Text != string.Empty)
            {
                txt_custom_no.Focus();
                txt_custom_no.SelectAll();
            

            DataTable dt_ = dal.getDataTabl_1(@"select isnull(NetAmount,0) as NetAmount ,Storing_Expire_Date,CUSTOM_NO,G_date from wh_inv_data 
       where Ser_no='" + txt_inv_no.Text+"' and Transaction_code ='" + txtTransaction.ID.Text+"' and Branch_code='"+ txtBranch.ID.Text+"' and Cyear='" + comboBox1.Text.Substring(comboBox1.Text.Length - 2)+"'");

            inv_amount.Text = Convert.ToDecimal(dt_.Rows[0][0]).ToString("N2");

            txt_custom_no.Text = dt_.Rows[0][2].ToString();
            inv_date.Text = dt_.Rows[0][3].ToString();
            }

        }

        private void txt_custom_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_custom_no.Text != string.Empty)
            {
                txt_custom_date.Focus();
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
            //try
            //{
                          //}
            //catch
            //{ }

        }

        private void txt_custom_date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
