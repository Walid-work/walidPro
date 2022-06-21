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
    public partial class frm_Funds_Detials_Report : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Funds_Detials_Report()
        {
            InitializeComponent();
        }

        private void frm_Funds_Detials_Report_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1(@"SELECT A.*,B.BRANCH_name
            FROM fund_Balance_Detials as A
            inner join BRANCHS as B on A.branch_code = B.BRANCH_code
            where cast(A.G_date as date ) = '" + date_.Value.ToString("yyyy-MM-dd") + "' and A.type like'" + Type_.Text + "%' and A.branch_code like '" + branch_.ID.Text + "%'");

            DataSet ds = new DataSet();
            ds.Tables.Add(dt_);
            //ds.WriteXmlSchema("schema_xml");
            CTR.rpt_Funds_Detials_Report rpt = new rpt_Funds_Detials_Report();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
