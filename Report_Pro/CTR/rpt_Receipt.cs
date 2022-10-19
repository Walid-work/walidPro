using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Report_Pro.CTR
{
    public partial class rpt_Receipt : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_Receipt()
        {
            InitializeComponent();
        }
        bool firstPage = true;
        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
          
        }

        private void rpt_Receipt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            bool noDataFound = GetCurrentRow() == null;
            if (noDataFound == true)
            {
                xrLabel47.Visible = false;
                this.Detail.Visible = false;
                this.PageHeader.Visible = false;
                this.ReportFooter.Visible = false;
            }
            else
            {
                xrLabel47.Visible        = true;
                this.Detail.Visible      = true;
                this.PageHeader.Visible  = true;
                this.ReportFooter.Visible  = true;
            }
        }
    }
}
