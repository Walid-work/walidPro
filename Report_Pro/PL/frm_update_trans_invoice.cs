using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_update_trans_invoice : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        public frm_update_trans_invoice()
        {
            InitializeComponent();
        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt_ = dal.getDataTabl("Get_Purch_inv_", txtInv.Text, UC_Transaction.ID.Text);
                if (dt_.Rows.Count > 0)
                {
                    Uc_Acc.ID.Text = dt_.Rows[0][2].ToString();
                    txtSuppVatNo.Text = dt_.Rows[0][4].ToString();
                    txtSuppInv.Text = dt_.Rows[0][5].ToString();
                    txtSuppDate.Text = dt_.Rows[0][6].ToString();
                    txtAmount.Value = Convert.ToDouble(dt_.Rows[0][7].ToString());
                    txtVat.Value = Convert.ToDouble(dt_.Rows[0][8].ToString());
                    txtTotalAmount.Value = Convert.ToDouble(dt_.Rows[0][7].ToString()) + Convert.ToDouble(dt_.Rows[0][8].ToString());
                    txtCashSupp.Text = dt_.Rows[0][10].ToString();
                }
                else
                {
                    //UC_Transaction.ID.Clear();
                    txtInv.Clear();
                    Uc_Acc.ID.Clear();
                    txtSuppVatNo.Text ="";
                    txtSuppInv.Text ="";
                    txtSuppDate.Text ="";
                    txtAmount.Value = 0;
                    txtVat.Value = 0;
                    txtTotalAmount.Value = 0;
                    txtCashSupp.Text ="";
                }
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
            }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            dal.Execute_1("Update cust_acc_wh.dbo.wh_inv_data set COSTMER_K_M_NO= '"+txtSuppVatNo.Text+ "', Cash_costomer_name='" + txtCashSupp.Text + "' where Transaction_code='"+ UC_Transaction.ID.Text+"' and Ser_no='"+ txtInv.Text+"' ");
        }
    }
}
