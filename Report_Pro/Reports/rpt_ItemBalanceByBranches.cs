using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Report_Pro.Reports
{
    public partial class rpt_ItemBalanceByBranches : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_ItemBalanceByBranches()
        {
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
