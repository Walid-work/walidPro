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
    public partial class frm_LoansReport : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_LoansReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            Loans.rpt_LoansBalance rptLoans = new Loans.rpt_LoansBalance();
            DataTable dataTabl1 = this.dal.getDataTabl_1(@"SELECT L.*,p.PAYER_NAME as bankName 
        ,p1.PAYER_NAME as LoanName ,p.payer_l_name as bankNameE ,p1.payer_l_name as LoanNameE,LP.Loan_Purpose,LP.Loan_Purpose_E
        FROM LoansTbl as L 
        inner join payer2 as p on L.BankId=p.ACC_NO and L.BRANCH_code=P.BRANCH_code 
        inner join payer2 as p1 on L.LoanAcc=p1.ACC_NO and L.BRANCH_code=P1.BRANCH_code 
        inner join LoanPurpose as LP on LP.Id = L.LoanPurpose       

            where ( case when '" + comb1.SelectedIndex + "'=0 then StartDate when '" + comb1.SelectedIndex + "'=1  then MaturityDate when'" + comb1.SelectedIndex + "'=2  then MaturityDate end ) between '" + this.fromDate.Value.ToString("yyyy/MM/dd")
              + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "' and L.BankId like '"+Bank_.ID.Text+"%'");
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTabl1);
            //dataSet.WriteXmlSchema("schema_rpt.xml");
            rptLoans.SetDataSource(dataSet);
            crystalReportViewer1.ReportSource = rptLoans;
            rptLoans.DataDefinition.FormulaFields["Status_"].Text = "'" + comb1.Text + "'";
            rptLoans.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("dd/MM/yyyy") + "'";
            rptLoans.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("dd/MM/yyyy") + "'";


            groupPanel2.Visible = false;
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupPanel2.Visible = true;
        }

        private void frm_LoansReport_Load(object sender, EventArgs e)
        {

        }
    }
}
