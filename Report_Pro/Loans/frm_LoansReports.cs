using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.Loans
{
    public partial class frm_LoansReports :XtraForm
    {
        string strLoanTearm = "";
        string balance_ = "";
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_LoansReports()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnReportToal_Click(object sender, EventArgs e)
        {
            check_Tearm();
            DataTable dt = dal.getDataTabl_1(@"select * from (select A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.LoanValue,
            SUM(CASE WHEN  cast( B.PaymentDate  as date) <= '" + toDate.Value.ToString("yyyy/MM/dd") + "' THEN  B.PaymentAmount else 0 END) as payment " +
            "from LoansTbl As A " +
            "left join LoanPaymentTbl As B on A.LoanNo = B.LoanNo  and A.PaymentNo = B.PaymentNo " +
            "inner Join(select* from (select*, ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount " +
            "FROM payer2 As P) as t1  where t1.DuplicateCount = 1 ) as C on C.ACC_NO = A.BankId where A.BankId like '" + txtBank.ID.Text+"%' and " +
            "StartDate <= '" + toDate.Value.ToString("yyyy/MM/dd") + "' and Loan_Tearm like '" + strLoanTearm + "%' " +
            "group by A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.LoanValue) as X where ((LoanValue-payment)>=  case when '"+balance_+ "'='A' then 0  when '" + balance_ + "'='uz' then 1  end or(LoanValue-payment)=  case when '" + balance_ + "'='z' then 0 end )  ");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            //ds.WriteXmlSchema("schema_rpt.xml");
            Loans.rpt_LoansReportTotal rpt = new Loans.rpt_LoansReportTotal();
            rpt.SetDataSource (ds);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";


        }

        private void btnMaturityLoans_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.getDataTabl_1(@"select  A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo,A.PaymentValue,
          SUM(CASE WHEN  cast( B.PaymentDate  as date) <= '" + toDate.Value.ToString("yyyy/MM/dd") + "' THEN  B.PaymentAmount else 0 END) as PaymentAmount " +
          "from LoansTbl As A " +
          "left join LoanPaymentTbl As B on A.LoanNo = B.LoanNo  and A.PaymentNo = B.PaymentNo " +
          "inner Join(select* from (select*, ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount " +
          "FROM payer2 As P) as t1  where t1.DuplicateCount = 1) as C " +
          "on C.ACC_NO = A.BankId where A.BankId like '" + txtBank.ID.Text + "%' and " +
          "A.MaturityDate between '" + fromDate.Value.ToString("yyyy/MM/dd") + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "' " +
          " and A.LoanNo like '"+txtLoanNo.Text+"%' group by A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo,A.PaymentValue");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            //ds.WriteXmlSchema("schema_rpt.xml");
            Loans.rpt_LoansMaturity rpt = new Loans.rpt_LoansMaturity();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;

            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";
            string rptTitel = "Due Loans";
            rpt.DataDefinition.FormulaFields["reportTitel"].Text = "'"+rptTitel+"'";

        }

        private void frm_LoansReports_Load(object sender, EventArgs e)
        {

        }

        private void check_Tearm()
        {
            if (rdo_All_Tearm.Checked == true)
            {
                strLoanTearm = "";
            }
           else if (rdo_Short_Tearm.Checked == true)
            {
                strLoanTearm = "1";
            }
            else if (rdo_Long_Tearm.Checked == true)
            {
                strLoanTearm = "2";
            }

            if (rdoAllBalance.Checked == true)
            {
                balance_ = "A";
            }
            else if (rdoUn_Zero.Checked == true)
            {
                balance_ = "uz";
            }
            else if (rdoZero.Checked == true)
            {
                balance_ = "z";
            }
        }
        private void btnNewLoans_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.getDataTabl_1(@"select  A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo,A.PaymentValue,
            SUM(CASE WHEN  cast( B.PaymentDate  as date) <= '" + toDate.Value.ToString("yyyy/MM/dd") + "' THEN  B.PaymentAmount else 0 END) as PaymentAmount " +
            "from LoansTbl As A " +
            "left join LoanPaymentTbl As B on A.LoanNo = B.LoanNo  and A.PaymentNo = B.PaymentNo " +
            "inner Join(select* from (select*, ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount " +
            "FROM payer2 As P) as t1  where t1.DuplicateCount = 1) as C " +
            "on C.ACC_NO = A.BankId where A.BankId like '" + txtBank.ID.Text + "%' and " +
            "A.StartDate between '" + fromDate.Value.ToString("yyyy/MM/dd") + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "' " +
            "group by A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo,A.PaymentValue");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            //ds.WriteXmlSchema("schema_rpt.xml");
            Loans.rpt_LoansMaturity rpt = new Loans.rpt_LoansMaturity();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;

            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";
            string rptTitel = "New Loans";
            rpt.DataDefinition.FormulaFields["reportTitel"].Text = "'"+rptTitel+"'";
        }

        private void btnPaymentsLoans_Click(object sender, EventArgs e)
        {
            check_Tearm();
            DataTable dt = dal.getDataTabl_1(@"select T.* from  (select  A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo
            ,A.PaymentValue - SUM(CASE WHEN  cast( B.PaymentDate  as date) < '" + fromDate.Value.ToString("yyyy/MM/dd") + "' THEN  B.PaymentAmount else 0 END) as PaymentValue " +
         ", SUM(CASE WHEN  cast( B.PaymentDate  as date)  between '" + fromDate.Value.ToString("yyyy/MM/dd") + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "' THEN  B.PaymentAmount else 0 END) as PaymentAmount " +
        "from LoansTbl As A " +
        "left join LoanPaymentTbl As B on A.LoanNo = B.LoanNo  and A.PaymentNo = B.PaymentNo " +
        "inner Join(select* from (select*, ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount " +
        "FROM payer2 As P) as t1  where t1.DuplicateCount = 1) as C " +
        "on C.ACC_NO = A.BankId " +
        " where  A.BankId like '" + txtBank.ID.Text + "%' and A.LoanNo like '" + txtLoanNo.Text + "%' and Loan_Tearm like '" + strLoanTearm + 
        "%'group by A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo,A.PaymentValue) as T  where PaymentAmount>0");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            //ds.WriteXmlSchema("schema_rpt.xml");
            Loans.rpt_LoansMaturity rpt = new Loans.rpt_LoansMaturity();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;

            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";
            string rptTitel = "Paid Loans";
            rpt.DataDefinition.FormulaFields["reportTitel"].Text = "'" + rptTitel + "'";

        }

        private void btn_Loans_Transaction_Click(object sender, EventArgs e)
        {
            check_Tearm();
            DataTable dt = dal.getDataTabl_1(@"SELECT X.bankID,P.PAYER_NAME,P.payer_l_name,X.LoanNo,X.LoanDate,isnull(Open_balance,0)-isnull(Open_balance_P,0) as OB,isnull(Value,0) as Value,isnull(Value_P,0) as Value_P 
        ,isnull(Open_balance,0)-isnull(Open_balance_P,0)+isnull(Value,0)-isnull(Value_P,0) as EB  from 
        (SELECT bankID,LoanNo,LoanDate,Loan_Tearm,Branch_code,
        sum (case when LoanDate< '" + fromDate.Value.ToString("yyyy/MM/dd") + "'  then isnull(PaymentValue,0) else 0 end)  as Open_balance "+
        ", sum (case when LoanDate between '" + fromDate.Value.ToString("yyyy/MM/dd") + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "'  then isnull(PaymentValue,0) else 0 end)  as Value " +
        "FROM LoansTbl group by bankID,LoanNo,LoanDate,Loan_Tearm,Branch_code) as X " +
        "left join(SELECT LoanNo,sum (case when PaymentDate < '"+fromDate.Value.ToString("yyyy/MM/dd")+"'  then isnull(PaymentAmount,0) else 0 end)  as Open_balance_P "+
        ",sum (case when PaymentDate between '" + fromDate.Value.ToString("yyyy/MM/dd") + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "'  then isnull(PaymentAmount,0) else 0 end)  as Value_P "+
        "FROM LoanPaymentTbl "+
        "group by LoanNo) as Y  on X.LoanNo=Y.LoanNo "+
        "inner Join payer2 as P on P.acc_no=X.bankID and P.branch_Code = X.Branch_code " + 
        "where BankID like '" + txtBank.ID.Text + "%' and X.LoanNo like '"+txtLoanNo.Text+"%' and Loan_Tearm like '" + strLoanTearm+"%'");


            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            //ds.WriteXmlSchema("schema_rpt.xml");
            Loans.rpt_LoanTransaction rpt = new Loans.rpt_LoanTransaction();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;

            //rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            //rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";
            //string rptTitel = "Paid Loans";
            //rpt.DataDefinition.FormulaFields["reportTitel"].Text = "'" + rptTitel + "'";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnOption__Click(object sender, EventArgs e)
        {

        }
    }
}
