using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Report_Pro.Reports
{
    public partial class rpt_LoanLetter : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_LoanLetter()
        {
            InitializeComponent();
        }

        private void rpt_Confirmation_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
    }
}
