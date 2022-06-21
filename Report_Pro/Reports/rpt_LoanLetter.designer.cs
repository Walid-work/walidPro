namespace Report_Pro.Reports
{
    partial class rpt_LoanLetter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_LoanLetter));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.txtLetter = new DevExpress.XtraReports.UI.XRLabel();
            this.LcDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.Status_E = new DevExpress.XtraReports.UI.CalculatedField();
            this.DR_CR_E = new DevExpress.XtraReports.UI.CalculatedField();
            this.DR_CR = new DevExpress.XtraReports.UI.CalculatedField();
            this.Status_A = new DevExpress.XtraReports.UI.CalculatedField();
            this.balanc_ = new DevExpress.XtraReports.UI.CalculatedField();
            this.LoanDays = new DevExpress.XtraReports.Parameters.Parameter();
            this.bank_ = new DevExpress.XtraReports.Parameters.Parameter();
            this.PicH = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.txtDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.LoanCurrency = new DevExpress.XtraReports.Parameters.Parameter();
            this.LcCurrency = new DevExpress.XtraReports.Parameters.Parameter();
            this.LcNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.AccountNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.amountWord = new DevExpress.XtraReports.Parameters.Parameter();
            this.LcAmount = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 29.16667F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo2,
            this.pageInfo1,
            this.xrPictureBox4});
            this.BottomMargin.HeightF = 37.54213F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(413F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(142.5149F, 28.125F);
            this.pageInfo2.StylePriority.UseTextAlignment = false;
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(147.8055F, 28.125F);
            this.pageInfo1.StylePriority.UseTextAlignment = false;
            this.pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox4.ImageSource"));
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(701.765F, 0F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(40F, 30F);
            this.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtLetter});
            this.Detail.HeightF = 52.08327F;
            this.Detail.Name = "Detail";
            // 
            // txtLetter
            // 
            this.txtLetter.Font = new System.Drawing.Font("Arial", 16F);
            this.txtLetter.LocationFloat = new DevExpress.Utils.PointFloat(50F, 0F);
            this.txtLetter.Multiline = true;
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtLetter.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.txtLetter.SizeF = new System.Drawing.SizeF(678.3426F, 52.08327F);
            this.txtLetter.StylePriority.UseFont = false;
            this.txtLetter.StylePriority.UseTextAlignment = false;
            this.txtLetter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // LcDate
            // 
            this.LcDate.Description = "Lc Date";
            this.LcDate.Name = "LcDate";
            this.LcDate.Type = typeof(System.DateTime);
            this.LcDate.Visible = false;
            // 
            // Status_E
            // 
            this.Status_E.DataMember = "Table1";
            this.Status_E.Expression = "iif([Ending_balance]<0,\'Credit With\',\'Debit With\')";
            this.Status_E.Name = "Status_E";
            // 
            // DR_CR_E
            // 
            this.DR_CR_E.DataMember = "Table1";
            this.DR_CR_E.Expression = "iif([Ending_balance]>0,\'Payable to\',\'Receivable from\')+\' \' + ?CoName_E";
            this.DR_CR_E.Name = "DR_CR_E";
            // 
            // DR_CR
            // 
            this.DR_CR.DataMember = "Table1";
            this.DR_CR.Expression = "iif([Ending_balance]>0,\'مستحق ل\',\'مستحق علي\')+\' \' + ?CoName";
            this.DR_CR.Name = "DR_CR";
            // 
            // Status_A
            // 
            this.Status_A.DataMember = "Table1";
            this.Status_A.Expression = "iif([Ending_balance]<0,\'دائن بمبلغ\',\'مدين بمبلغ\')";
            this.Status_A.Name = "Status_A";
            // 
            // balanc_
            // 
            this.balanc_.DataMember = "Table1";
            this.balanc_.Name = "balanc_";
            // 
            // LoanDays
            // 
            this.LoanDays.Description = "Loan Days";
            this.LoanDays.Name = "LoanDays";
            this.LoanDays.Type = typeof(int);
            this.LoanDays.ValueInfo = "0";
            this.LoanDays.Visible = false;
            // 
            // bank_
            // 
            this.bank_.Description = "bank Name";
            this.bank_.Name = "bank_";
            this.bank_.Type = typeof(int);
            this.bank_.ValueInfo = "0";
            this.bank_.Visible = false;
            // 
            // PicH
            // 
            this.PicH.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter;
            this.PicH.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.PicH.Name = "PicH";
            this.PicH.SizeF = new System.Drawing.SizeF(770F, 90F);
            this.PicH.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrLabel67
            // 
            this.xrLabel67.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(662.5149F, 146.9165F);
            this.xrLabel67.Multiline = true;
            this.xrLabel67.Name = "xrLabel67";
            this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel67.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel67.SizeF = new System.Drawing.SizeF(65.8277F, 23.00001F);
            this.xrLabel67.StylePriority.UseFont = false;
            this.xrLabel67.StylePriority.UseTextAlignment = false;
            this.xrLabel67.Text = "السادة /";
            this.xrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtDate,
            this.xrLabel5,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel1,
            this.xrLabel67,
            this.PicH});
            this.PageHeader.HeightF = 218.0415F;
            this.PageHeader.Name = "PageHeader";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Arial", 16F);
            this.txtDate.LocationFloat = new DevExpress.Utils.PointFloat(413F, 111.0831F);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtDate.SizeF = new System.Drawing.SizeF(217.5372F, 23F);
            this.txtDate.StylePriority.UseFont = false;
            this.txtDate.StylePriority.UseTextAlignment = false;
            this.txtDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(630.5372F, 111.0831F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel5.SizeF = new System.Drawing.SizeF(97.80542F, 23.00001F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "التاريخ :";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(50F, 146.9165F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel2.SizeF = new System.Drawing.SizeF(97.8055F, 23.00001F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "المحترمين";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?bank_")});
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 16F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(151.375F, 146.9165F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(511.1399F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(549.8865F, 185.0415F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel1.SizeF = new System.Drawing.SizeF(178.4561F, 23.00002F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "تحية طيبة وبعد ،،،،";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?AccountNo")});
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 16F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(50F, 226.5838F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(321.4749F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(371.4749F, 226.5836F);
            this.xrLabel18.Multiline = true;
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel18.SizeF = new System.Drawing.SizeF(89.44183F, 23.00004F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "حساب رقم";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(50F, 91.33339F);
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel17.SizeF = new System.Drawing.SizeF(429.3543F, 23.00003F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "شركة عثمان عبدالرحمن العصيمي وشركاة التجارية";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(464.7034F, 38.00001F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel16.SizeF = new System.Drawing.SizeF(231.0618F, 23.00002F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "وتقبلوا منا اطيب التحيات ،،، ";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(431.4531F, 10F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel15.SizeF = new System.Drawing.SizeF(264.312F, 23.00002F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "شاكرين لكم حسن تعاونكم معنا ،،، ";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // LoanCurrency
            // 
            this.LoanCurrency.Description = "Loan Currency";
            this.LoanCurrency.Name = "LoanCurrency";
            this.LoanCurrency.Visible = false;
            // 
            // LcCurrency
            // 
            this.LcCurrency.Description = "Lc Currency";
            this.LcCurrency.Name = "LcCurrency";
            this.LcCurrency.Visible = false;
            // 
            // LcNo
            // 
            this.LcNo.Description = "Lc No";
            this.LcNo.Name = "LcNo";
            this.LcNo.Visible = false;
            // 
            // AccountNo
            // 
            this.AccountNo.Description = "Account No";
            this.AccountNo.Name = "AccountNo";
            this.AccountNo.Visible = false;
            // 
            // amountWord
            // 
            this.amountWord.Description = "amount Word";
            this.amountWord.Name = "amountWord";
            this.amountWord.Visible = false;
            // 
            // LcAmount
            // 
            this.LcAmount.Description = "Lc Amount";
            this.LcAmount.Name = "LcAmount";
            this.LcAmount.Type = typeof(decimal);
            this.LcAmount.ValueInfo = "0";
            this.LcAmount.Visible = false;
            // 
            // PageFooter
            // 
            this.PageFooter.Name = "PageFooter";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15});
            this.ReportFooter.HeightF = 249.5838F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // rpt_LoanLetter
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.ReportFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.Status_E,
            this.DR_CR_E,
            this.DR_CR,
            this.Status_A,
            this.balanc_});
            this.ExportOptions.Pdf.ConvertImagesToJpeg = false;
            this.ExportOptions.Pdf.PasswordSecurityOptions.PermissionsOptions.PrintingPermissions = DevExpress.XtraPrinting.PrintingPermissions.HighResolution;
            this.ExportOptions.Pdf.PasswordSecurityOptions.PermissionsPassword = "walidpdf";
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(25, 32, 29, 38);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.LcDate,
            this.LoanDays,
            this.bank_,
            this.LoanCurrency,
            this.LcCurrency,
            this.LcNo,
            this.AccountNo,
            this.amountWord,
            this.LcAmount});
            this.Version = "21.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.rpt_Confirmation_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        public DevExpress.XtraReports.Parameters.Parameter LcDate;
        private DevExpress.XtraReports.UI.CalculatedField Status_E;
        private DevExpress.XtraReports.UI.CalculatedField DR_CR_E;
        private DevExpress.XtraReports.UI.CalculatedField DR_CR;
        public DevExpress.XtraReports.UI.CalculatedField Status_A;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox4;
        private DevExpress.XtraReports.UI.CalculatedField balanc_;
        public DevExpress.XtraReports.Parameters.Parameter LoanDays;
        public DevExpress.XtraReports.Parameters.Parameter bank_;
        public DevExpress.XtraReports.UI.XRPictureBox PicH;
        private DevExpress.XtraReports.UI.XRLabel xrLabel67;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        public DevExpress.XtraReports.Parameters.Parameter LoanCurrency;
        public DevExpress.XtraReports.Parameters.Parameter LcCurrency;
        public DevExpress.XtraReports.Parameters.Parameter LcNo;
        public DevExpress.XtraReports.Parameters.Parameter AccountNo;
        public DevExpress.XtraReports.Parameters.Parameter amountWord;
        public DevExpress.XtraReports.Parameters.Parameter LcAmount;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        public DevExpress.XtraReports.UI.XRLabel txtLetter;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.UI.XRLabel txtDate;
    }
}
