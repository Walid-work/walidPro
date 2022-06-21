using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
//using System.Linq;
using System.Text;
////using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_return_rep : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string db1 = Properties.Settings.Default.Database_1;
        public frm_return_rep()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
        RPT.return_previws_period rpt = new RPT.return_previws_period();

            rpt.SetDataSource(dal.getDataTabl("Get_Return_", dTP1.Value.Date, dTP2.Value.Date,db1));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RPT.rpt_Export_Sales rpt = new RPT.rpt_Export_Sales();

            rpt.SetDataSource(dal.getDataTabl("Get_Sales_", dTP1.Value.Date, dTP2.Value.Date,'3'));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
        }

        private void frm_return_rep_Load(object sender, EventArgs e)
        {

        }
    }
}
