using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.CTR
{
    public partial class frm_CloseCustomerPayment : frm_Master
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        public frm_CloseCustomerPayment()
        {
            InitializeComponent();

            txtStore_ID.Text = Properties.Settings.Default.BranchId;
        }

        private void Btn_NonPayInvoice_Click(object sender, EventArgs e)
        {
            if (Acc_Cr.ID.Text.Trim() != string.Empty)
            {
                DataTable dt_inv = dal.getDataTabl_1(@"select x.Ser_no,x.Branch_code,x.Transaction_code,x.G_date,x.Acc_no,x.Acc_Branch_code,x.Payment_Type
                ,x.Inv_no,x.Inv_date,x.Po_no,x.Inv_Notes,Return_reson,Reten_Notes,x.NetAmount,x.K_M_Credit_TAX,isnull(x.PanyedAmount,0) as paidAmount,x.InvoiceAmount,isnull(y.returnAmount,0) as returnAmount,(x.InvoiceAmount+isnull(y.returnAmount,0)) as Balance

                 from( SELECT Ser_no,Branch_code,Transaction_code,G_date,Acc_no,Acc_Branch_code,Payment_Type
                ,Inv_no,Inv_date,Po_no,NetAmount,K_M_Credit_TAX,PanyedAmount,(NetAmount+K_M_Credit_TAX-isnull(PanyedAmount,0)) as InvoiceAmount,Inv_Notes
                 FROM  wh_inv_data  where Transaction_code ='xsd') as x

                 left join ( SELECT Ser_no,Branch_code,Transaction_code,G_date,Acc_no,Acc_Branch_code,Payment_Type
                ,Inv_no,Inv_date,Inv_Notes,Return_reson,Reten_Notes,sum(NetAmount) as NetAmount ,sum(K_M_Debit_TAX) as K_M_Debit_TAX,sum((isnull(NetAmount,0)- isnull(K_M_Debit_TAX,0))) as returnAmount
                FROM  wh_inv_data where Transaction_code in('xsr','xst') group by  Ser_no,Branch_code,Transaction_code,G_date,Acc_no,Acc_Branch_code,Payment_Type
                ,Inv_no,Inv_date,Inv_Notes,Return_reson,Reten_Notes) as Y
                  on x.Acc_no = y.Acc_no and x.Branch_code = y.Branch_code  and x.Ser_no =y.Inv_no and cast(x.G_date as date ) = cast(y.Inv_date as date ) and x.Payment_Type = y.Payment_Type

                where x.acc_no = '" + Acc_Cr.ID.Text + "' and x.Branch_code = '" + txtStore_ID.Text + "' and x.InvoiceAmount +isnull(y.returnAmount,0)<>0");
                if (dt_inv.Rows.Count > 0)
                {
                    int B_rowscount = dt_inv.Rows.Count;

                    dgv1.Rows.Clear();
                    dgv1.Rows.Add(B_rowscount);
                    for (int i = 0; i <= (B_rowscount - 1); i++)
                    {


                        dgv1.Rows[i].Cells[0].Value = dt_inv.Rows[i]["Ser_no"];
                        dgv1.Rows[i].Cells[1].Value = dt_inv.Rows[i]["G_date"];
                        dgv1.Rows[i].Cells[2].Value = dt_inv.Rows[i]["Po_no"];
                        dgv1.Rows[i].Cells[3].Value = dt_inv.Rows[i]["InvoiceAmount"];
                        dgv1.Rows[i].Cells[4].Value = dt_inv.Rows[i]["paidAmount"];
                        dgv1.Rows[i].Cells[5].Value = dt_inv.Rows[i]["returnAmount"];
                        dgv1.Rows[i].Cells[6].Value = dt_inv.Rows[i]["Balance"];


                    }
                }


                DataTable dt_balance = dal.getDataTabl_1(@"select sum(meno-loh) as Balance from daily_transaction  where acc_no = '" + Acc_Cr.ID.Text + "'  and BRANCH_code ='" + txtStore_ID.Text + "' ");
              if (dt_balance.Rows.Count > 0)
                {
                    txtAcountBal.Text = dt_balance.Rows[0]["Balance"].ToString().ToDecimal().ToString("N"+dal.digits_);
                }

            }
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgv2.Rows.Count - 1; i++)
            {
                if (dgv2.Rows[i].Cells[0].Value.ToString() == dgv1.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("الفاتورة مضافة من قبل", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            int n1 = dgv2.Rows.Add();
            dgv2.Rows[n1].Cells[0].Value = dgv1.CurrentRow.Cells[0].Value.ToString();
            dgv2.Rows[n1].Cells[1].Value = dgv1.CurrentRow.Cells[1].Value.ToString();
            dgv2.Rows[n1].Cells[2].Value = dgv1.CurrentRow.Cells[2].Value.ToString();
            dgv2.Rows[n1].Cells[3].Value = dgv1.CurrentRow.Cells[3].Value.ToString();
            dgv2.Rows[n1].Cells[4].Value = dgv1.CurrentRow.Cells[4].Value.ToString();
            dgv2.Rows[n1].Cells[5].Value = dgv1.CurrentRow.Cells[5].Value.ToString();
            dgv2.Rows[n1].Cells[6].Value = dgv1.CurrentRow.Cells[6].Value.ToString();
            dgv1.Rows.RemoveAt(this.dgv1.CurrentRow.Index);

            Get_Total();

        }


        private void Get_Total()
        {
            txtTotalInvoices.Text =
                         (from DataGridViewRow row in dgv1.Rows
                          where row.Cells[0].FormattedValue.ToString() != string.Empty
                          select (row.Cells[6].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            txtTotalClosed.Text =
             (from DataGridViewRow row in dgv2.Rows
              where row.Cells[0].FormattedValue.ToString() != string.Empty
              select (row.Cells[6].FormattedValue).ToString().ToDecimal()).Sum().ToString();


        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
