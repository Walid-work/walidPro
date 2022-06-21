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
    public partial class frmLoanSearch : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dtSearch = new DataTable();

        public frmLoanSearch()
        {
            InitializeComponent();
            creatDattable();
        }

        private void BName_Load(object sender, EventArgs e)
        {
            searchLoan(txtLoanNo.Text, BName.ID.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        void creatDattable()
        {
            if (Properties.Settings.Default.lungh == "0")
            {
                dtSearch.Columns.Add("م");
                dtSearch.Columns.Add("البنك");
                dtSearch.Columns.Add("رقم القرض");
                dtSearch.Columns.Add("الدفعة");
                dtSearch.Columns.Add("المبلغ");
                dtSearch.Columns.Add("المسدد");
                dtSearch.Columns.Add("الرصيد");
            }
            else
            {
                dtSearch.Columns.Add("Ser");
                dtSearch.Columns.Add("Bank");
                dtSearch.Columns.Add("Loan No");
                dtSearch.Columns.Add("Pay No");
                dtSearch.Columns.Add("Value");
                dtSearch.Columns.Add("Payment");
                dtSearch.Columns.Add("Balance");
            }
            DGV1.DataSource = dtSearch;
           
        }

        private void searchLoan(string no_ ,string Bank_)
        {
            DataTable dt_;
            if (chB1.Checked == true)
            {
                dt_ = dal.getDataTabl_1(@"select * from( SELECT id,B.PAYER_NAME,B.payer_l_name,LoanNo,PaymentNo,PaymentValue
            ,(select sum (PaymentAmount) from LoanPaymentTbl as LP where LP.LoanNo = A.LoanNo and Lp.PaymentNo =A.PaymentNo) as Payment_
			FROM LoansTbl As A 
            inner join payer2 as B on A.BankId=B.ACC_NO and B.BRANCH_code=A.Branch_code
            where A.LoanNo like '" + no_ + "%' and A.BankId like '" + Bank_ + "%') as X ");
            }
            else
            {
                dt_ = dal.getDataTabl_1(@"SELECT id,B.PAYER_NAME,B.payer_l_name,LoanNo,PaymentNo,PaymentValue
            ,(select sum (PaymentAmount) from LoanPaymentTbl as LP where LP.LoanNo = A.LoanNo and Lp.PaymentNo =A.PaymentNo) as Payment_
			FROM LoansTbl As A  inner join payer2 as B on A.BankId=B.ACC_NO and B.BRANCH_code=A.Branch_code
            where A.LoanNo like '" + no_ + "%' and A.BankId like '" + Bank_ + "%'");

            }

            dtSearch.Clear();
            int i = 0;
            DataRow row = null;
            foreach (DataRow r in dt_.Rows)
            {

                row = dtSearch.NewRow();
                row[0] = dt_.Rows[i]["id"].ToString();
                if (Properties.Settings.Default.lungh == "0")
                {
                    row[1] = dt_.Rows[i]["PAYER_NAME"].ToString();
                }
                else
                {
                    row[1] = dt_.Rows[i]["payer_l_name"].ToString();

                }
                row[2] = dt_.Rows[i]["LoanNo"].ToString();
                row[3] = dt_.Rows[i]["PaymentNo"].ToString();
                row[4] = dt_.Rows[i]["PaymentValue"].ToString().ToDecimal().ToString("n2");
                row[5] = dt_.Rows[i]["Payment_"].ToString().ToDecimal().ToString("n2");
                row[6] = (dt_.Rows[i]["PaymentValue"].ToString().ToDecimal()- dt_.Rows[i]["Payment_"].ToString().ToDecimal()).ToString("n2");
                dtSearch.Rows.Add(row);
                i = i + 1;
            }

            DGV1.DataSource = dtSearch;
            //resizeDG();
            //total_inv();

        }




       // DGV1.DataSource = dt_;
            //DGV1.RowCount = dt_.Rows.Count;

            //int count_ = 0;
            //for (int i = 0; i <= dt_.Rows.Count - 1; i++)
            //{
            //    DGV1.Rows[count_].Cells[0].Value = dt_.Rows[i]["id"].ToString();
            //    DGV1.Rows[count_].Cells[1].Value = dt_.Rows[i]["LoanNo"].ToString();
            //    DGV1.Rows[count_].Cells[2].Value = dt_.Rows[i]["PaymentNo"].ToString();
            //    DGV1.Rows[count_].Cells[3].Value = dt_.Rows[i]["PAYER_NAME"].ToString();
            //    //DGV1.Rows[count_].Cells[4].Value = dt_.Rows[i]["Line_name"].ToString();
            //    //DGV1.Rows[count_].Cells[5].Value = Convert.ToDateTime(dt_.Rows[i]["T_date"]).ToShortDateString();
            //    //DGV1.Rows[count_].Cells[6].Value = dt_.Rows[i]["Line_no"].ToString();
            //    count_ = count_ + 1;

            //}
        //}
        private void frmLoanSearch_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            searchLoan(txtLoanNo.Text,BName.ID.Text);
        }

       

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLoanNo_KeyUp(object sender, KeyEventArgs e)
        {
            searchLoan(txtLoanNo.Text, BName.ID.Text);
        }

        private void BName_KeyUp(object sender, KeyEventArgs e)
        {
            searchLoan(txtLoanNo.Text, BName.ID.Text);
        }
    }
}
