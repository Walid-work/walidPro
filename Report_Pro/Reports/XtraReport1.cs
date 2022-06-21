using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Report_Pro.Report
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }
        public static void print(object ds)
        {
            //RPT.XtraReport1 rpt = new RPT.XtraReport1();

        }

        private void XtraReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)

        {
          

        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //int B_ = Math.Abs(Convert.ToInt32(xrLabel9.Text));
            //int C_ = Math.Abs(Convert.ToInt32(xrLabel10.Text));
            //int W_ = Math.Abs(Convert.ToInt32(xrLabel11.Text));
            //e.Cancel = B_ + C_ + W_ == 0;
        }

        void BindData()
        {
            //lbl_Code.DataBindings.Add("Text", this.DataSource, "Code");
            //xrBarCode1.DataBindings.Add("Text", this.DataSource, "ID");
            //xrTableCell14.DataBindings.Add("Text", this.DataSource, "Store");
            //lbl_Date.DataBindings.Add("Text", this.DataSource, "Date");
            //lbl_Discount.DataBindings.Add("Text", this.DataSource, "DiscountValue");
            //lbl_Expences.DataBindings.Add("Text", this.DataSource, "Expences");
            //lbl_InvoiceType.DataBindings.Add("Text", this.DataSource, "InvoiceType");
            //lbl_Net.DataBindings.Add("Text", this.DataSource, "Net");
            //lbl_Paid.DataBindings.Add("Text", this.DataSource, "Paid");
            //lbl_PartName.DataBindings.Add("Text", this.DataSource, "PartName");
            //lbl_PartType.DataBindings.Add("Text", this.DataSource, "PartType");
            //xrTableCell11.DataBindings.Add("Text", this.DataSource, "Phone");
            //lbl_Qty.DataBindings.Add("Text", this.DataSource, "ProductCount");
            //lbl_Remining.DataBindings.Add("Text", this.DataSource, "Remaing");
            //lbl_Tax.DataBindings.Add("Text", this.DataSource, "TaxValue");
            //lbl_Total.DataBindings.Add("Text", this.DataSource, "Total");
            // lbl_NetText.DataBindings.Add("Text", this.DataSource, "InvoiceType");

            f_ItemNo.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "item_no"));
            f_Description.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "descr"));
            f_B_Balance.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "B_balance"));
            f_B_Cost.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "B_cost"));
            f_B_Weight.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "B_Weight_"));
            f_M_Balance.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "M_balance"));
            f_M_Cost.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "M_cost"));
            f_M_Weight.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "M_Weight_"));
            f_Balance.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "balance"));
            f_Cost.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "cost"));
            f_Weight.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Weight_"));

        }


        public static void Print(object ds)
        {
            Report.XtraReport1 rpt = new Report.XtraReport1();
            rpt.DataSource = ds;
            rpt.BindData();
            rpt.ShowPreview();

            //switch (Session.CurrentSettings.InvoicePrintMode)
            //{
            //    case Master.PrintMode.Direct:
            //        rpt.Print();
            //        break;
            //    case Master.PrintMode.ShowPreview:
            //        rpt.ShowPreview();
            //        break;
            //    case Master.PrintMode.ShowDialog:
            //        rpt.PrintDialog();
            //        break;
            //    default:
            //        break;
            //}
        }

        private void PageFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        //int index = 1;
        //private void cell_Index_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    //_Index.Text = (index++).ToString();
        //}

    }
}

