using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class FRM_SALESREPORTS : Form
    {
        public FRM_SALESREPORTS()
        {
            InitializeComponent();
        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            RPT.frm_rpt_Sales_by_Br frm_salesreport = new RPT.frm_rpt_Sales_by_Br();
            frm_salesreport.TopLevel = false;
            PN_SALESREPORTS.Controls.Add(frm_salesreport);
            frm_salesreport.Show();
            frm_salesreport.BringToFront();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            RPT.frm_Export_sales frm_salesreport = new RPT.frm_Export_sales();
            frm_salesreport.TopLevel = false;
            PN_SALESREPORTS.Controls.Add(frm_salesreport);
            frm_salesreport.Show();
            frm_salesreport.BringToFront();
        }

        private void Btn_SalesReports_Click(object sender, EventArgs e)
        {
            RPT.frm_rpt_Sales_by_Br frm_salesreport = new RPT.frm_rpt_Sales_by_Br();
            frm_salesreport.TopLevel = false;
            PN_SALESREPORTS.Controls.Add(frm_salesreport);
            frm_salesreport.Show();
            frm_salesreport.BringToFront();
        }

        private void Btn_salesVatReport_Click(object sender, EventArgs e)
        {
            RPT.frm_Export_sales frm_salesreport = new RPT.frm_Export_sales();
            frm_salesreport.TopLevel = false;
            PN_SALESREPORTS.Controls.Add(frm_salesreport);
            frm_salesreport.Show();
            frm_salesreport.BringToFront();
        }
    }
}
