using System;
using System.Collections.Generic;
//
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
//
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_trns_purch : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_trns_purch()
        {
            InitializeComponent();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            RPT.rpt_tran_purch rpt = new RPT.rpt_tran_purch();

            rpt.SetDataSource(dal.getDataTabl("Get_Purch_trans_", dTP1.Value.Date, dTP2.Value.Date));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
        }

        private void frm_trns_purch_Load(object sender, EventArgs e)
        {

        }
    }
}
