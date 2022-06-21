using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.Loans
{
    public partial class frmLoanPaymentSearch : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frmLoanPaymentSearch()
        {
            InitializeComponent();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void searchLoan(string no_ )
        {
            DataTable dt_ = dal.getDataTabl_1(@"SELECT id,LoanNo,PaymentNo,PaymentAmount,PayMentInterest,PaymentDate
            FROM LoanPaymentTbl as A where A.LoanNo like '" + no_+ "%'");

            DGV1.RowCount = dt_.Rows.Count;

            int count_ = 0;
            for (int i = 0; i <= dt_.Rows.Count - 1; i++)
            {
                DGV1.Rows[count_].Cells[0].Value = dt_.Rows[i]["id"].ToString();
                DGV1.Rows[count_].Cells[1].Value = dt_.Rows[i]["LoanNo"].ToString();
                DGV1.Rows[count_].Cells[2].Value = dt_.Rows[i]["PaymentNo"].ToString();
                DGV1.Rows[count_].Cells[3].Value = dt_.Rows[i]["PaymentAmount"].ToString();
                //DGV1.Rows[count_].Cells[4].Value = dt_.Rows[i]["Line_name"].ToString();
                //DGV1.Rows[count_].Cells[5].Value = Convert.ToDateTime(dt_.Rows[i]["T_date"]).ToShortDateString();
                //DGV1.Rows[count_].Cells[6].Value = dt_.Rows[i]["Line_no"].ToString();
                count_ = count_ + 1;

            }
        }
        private void frmLoanSearch_Load(object sender, EventArgs e)
        {
            searchLoan(txtLoanNo.Text);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            searchLoan(txtLoanNo.Text);
        }

        private void txtLoanNo_TextChanged(object sender, EventArgs e)
        {
            searchLoan(txtLoanNo.Text);
        }

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
