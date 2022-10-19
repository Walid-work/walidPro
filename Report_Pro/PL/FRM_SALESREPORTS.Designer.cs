namespace Report_Pro.PL
{
    partial class FRM_SALESREPORTS
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PN_SALESREPORTS = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_SalesReports = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_salesVatReport = new DevExpress.XtraEditors.SimpleButton();
            this.PN_SALESREPORTS.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_SALESREPORTS
            // 
            this.PN_SALESREPORTS.Controls.Add(this.flowLayoutPanel1);
            this.PN_SALESREPORTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PN_SALESREPORTS.Location = new System.Drawing.Point(0, 0);
            this.PN_SALESREPORTS.Name = "PN_SALESREPORTS";
            this.PN_SALESREPORTS.Size = new System.Drawing.Size(1386, 788);
            this.PN_SALESREPORTS.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Btn_SalesReports);
            this.flowLayoutPanel1.Controls.Add(this.Btn_salesVatReport);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1386, 788);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Btn_SalesReports
            // 
            this.Btn_SalesReports.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Btn_SalesReports.Appearance.Options.UseFont = true;
            this.Btn_SalesReports.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Btn_SalesReports.ImageOptions.SvgImage = global::Report_Pro.Properties.Resources.employeesummary;
            this.Btn_SalesReports.Location = new System.Drawing.Point(13, 13);
            this.Btn_SalesReports.Name = "Btn_SalesReports";
            this.Btn_SalesReports.Size = new System.Drawing.Size(130, 100);
            this.Btn_SalesReports.TabIndex = 9;
            this.Btn_SalesReports.Text = "Sales Reports";
            this.Btn_SalesReports.Click += new System.EventHandler(this.Btn_SalesReports_Click);
            // 
            // Btn_salesVatReport
            // 
            this.Btn_salesVatReport.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Btn_salesVatReport.Appearance.Options.UseFont = true;
            this.Btn_salesVatReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Btn_salesVatReport.ImageOptions.SvgImage = global::Report_Pro.Properties.Resources.employeesummary;
            this.Btn_salesVatReport.Location = new System.Drawing.Point(149, 13);
            this.Btn_salesVatReport.Name = "Btn_salesVatReport";
            this.Btn_salesVatReport.Size = new System.Drawing.Size(130, 100);
            this.Btn_salesVatReport.TabIndex = 10;
            this.Btn_salesVatReport.Text = "Sales VAT Report";
            this.Btn_salesVatReport.Click += new System.EventHandler(this.Btn_salesVatReport_Click);
            // 
            // FRM_SALESREPORTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.PN_SALESREPORTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SALESREPORTS";
            this.Text = "FRM_SALESREPORTS";
            this.PN_SALESREPORTS.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Panel PN_SALESREPORTS;
        private DevExpress.XtraEditors.SimpleButton Btn_SalesReports;
        private DevExpress.XtraEditors.SimpleButton Btn_salesVatReport;
    }
}