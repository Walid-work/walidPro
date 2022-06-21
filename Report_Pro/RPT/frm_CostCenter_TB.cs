using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_CostCenter_TB : Form
    {
        string db1 = Properties.Settings.Default.Database_1;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_CostCenter_TB()
        {
            InitializeComponent();
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            RPT.rpt_CostCenter_TB rpt = new RPT.rpt_CostCenter_TB();
            rpt.SetDataSource(dal.getDataTabl("CostCenter_TB_", FromDate.Value.Date, ToDate.Value.Date, UC_Branch.ID.Text, UC_Acc.ID.Text, UC_cost.ID.Text,db1));
            crystalReportViewer1.ReportSource = rpt;
            Cursor.Current = Cursors.Default;
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible =true;
        }

        private void frm_Monthly_TB_Load(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
