using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
//
using System.Windows.Forms;

namespace Report_Pro.RPT
{

    public partial class frm_local_sales : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string db1 = Properties.Settings.Default.Database_1;

        public frm_local_sales()
        {
            InitializeComponent();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {

            RPT.rpt_local_sales rpt = new RPT.rpt_local_sales();

            rpt.SetDataSource(dal.getDataTabl("Get_local_Sales_", dTP1.Value.Date, dTP2.Value.Date, '1',UC_Branch.ID.Text,UC_Acc.ID.Text,UC_PayType.ID.Text,db1));

            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + UC_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + UC_PayType.Desc.Text + "'";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_local_sales_Load(object sender, EventArgs e)
        {

        }
    }
}
