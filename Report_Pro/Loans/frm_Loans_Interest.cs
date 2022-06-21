using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frm_Loans_Interest : XtraForm
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string strLoanTearm = "";

        public frm_Loans_Interest()
        {
            InitializeComponent();
        }

        private void btnAccruedIntrrest_Click(object sender, EventArgs e)
        {
           groupControl2.Visible = false;

            DataTable dt_ = dal.getDataTabl_1(@"SELECT A.id,A.LoanNo,A.BankId,A.LoanACC,A.LoanDate,A.NumberOfPayments,A.LoanValue,A.PaymentNo,A.PaymentValue
            ,A.StartDate,A.MaturityDate,A.Rate,A.LoanPurpose,A.LoanRefrance,A.Branch_code,A.Jor_ser_no
            ,B.PAYER_NAME,B.payer_l_name,C.Loan_Purpose,C.Loan_Purpose_E
			,isnull(X.payment,0) as payment ,isnull(X.PayMentInterest,0) as PayMentInterest,A.Loan_Tearm,D.descr,D.descr_E
			
	        FROM LoansTbl As A 
            inner Join payer2 as B  on A.BankId=B.ACC_NO and A.Branch_code=B.BRANCH_code 
            left join LoanPurpose as C on c.Id=A.LoanPurpose 
            left join LoanTearms as D on D.id = A.Loan_Tearm
            left join (select LoanNo,PaymentNo,SUM(CASE WHEN  cast( PaymentDate  as date) <= '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  isnull(PaymentAmount,0) else 0 END) as payment " +
            ", SUM(CASE WHEN  cast( PaymentDate  as date) <= '" + toDate.Value.ToString("yyyy-MM-dd") + "' THEN  isnull(PayMentInterest,0) else 0 END) as PayMentInterest " +
            "from LoanPaymentTbl group by LoanNo,PaymentNo) as X "+		
			 "on A.LoanNo = X.LoanNo  and A.PaymentNo = X.PaymentNo "+
             "where  A.BankId like '"+txtBank.ID.Text+ "%' and A.StartDate <='"+ toDate.Value.ToString("yyyy-MM-dd") + "' and A.Loan_Tearm ='1'");

            DataSet ds = new DataSet();
            Loans.rpt_Accrued_Interest rpt = new Loans.rpt_Accrued_Interest();
         
            ds.Tables.Add(dt_);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);

            crystalReportViewer1.ReportSource = rpt;
            rpt.SetParameterValue("accrued_Date",toDate.Value.ToString("yyyy-MM-dd"));

            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Bank_Name"].Text = "'" + txtBank.Desc.Text + "'";
            //rpt.DataDefinition.FormulaFields["companyName"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            //rpt.DataDefinition.FormulaFields["branchName"].Text = "'" + dt_.Rows[0]["BRANCH_name"].ToString() + "'";




           




        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupControl2.Visible = true;
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

        }




        private void btnMaturityLoans_Click(object sender, EventArgs e)
        {

        }

        private void btnPaidIntrrest_Click(object sender, EventArgs e)
        {
            check_Tearm();
           DataTable dt_=dal.getDataTabl_1(@"SELECT   A.LoanNo, A.PaymentNo, A.PaymentAmount, A.PayMentInterest, A.PaymentDate,B.PaymentValue,B.LoanValue,B.LoanDate,B.StartDate,B.BankId
        ,PAYER_NAME,payer_l_name ,DATEDIFF(D,B.StartDate,A.PaymentDate) as days_
        , (A.PayMentInterest*360)/(B.LoanValue*DATEDIFF(D,B.StartDate,A.PaymentDate)) as rate
        FROM (select LoanNo, PaymentNo,sum(PaymentAmount) as PaymentAmount ,sum(PayMentInterest) as PayMentInterest,max(PaymentDate) as PaymentDate from LoanPaymentTbl Group by LoanNo, PaymentNo) as A
        inner join LoansTbl as B on A.LoanNo = B.LoanNo and A.PaymentNo= B.PaymentNo
        inner join payer2 as C on C.acc_no = B.bankid and c.branch_code = B.branch_code       
        where B.BankId like '" + txtBank.ID.Text+ "%' and Loan_Tearm like '" + strLoanTearm + "%' and A.PaymentDate between '" + fromDate.Value.ToString("yyyy-MM-dd")+ "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' and DATEDIFF(D,B.StartDate,A.PaymentDate)>0");
            Loans.rpt_paid_Intrest rpt = new Loans.rpt_paid_Intrest();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt_);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.DataSource=ds;

            rpt.ShowPreview();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBank_Load(object sender, EventArgs e)
        {

        }
    }
}
