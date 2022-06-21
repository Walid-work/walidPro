namespace Report_Pro.CTR
{
    partial class frm_Funds_Detials_Report
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
            this.date_ = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.branch_ = new Report_Pro.MyControls.UC_AccBranch();
            this.label2 = new System.Windows.Forms.Label();
            this.Type_ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // date_
            // 
            this.date_.Location = new System.Drawing.Point(100, 37);
            this.date_.Name = "date_";
            this.date_.Size = new System.Drawing.Size(107, 20);
            this.date_.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // branch_
            // 
            this.branch_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.branch_.Location = new System.Drawing.Point(100, 9);
            this.branch_.Margin = new System.Windows.Forms.Padding(0);
            this.branch_.Name = "branch_";
            this.branch_.Size = new System.Drawing.Size(321, 24);
            this.branch_.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Branch";
            // 
            // Type_
            // 
            this.Type_.FormattingEnabled = true;
            this.Type_.Items.AddRange(new object[] {
            "نقدي",
            "سلف",
            "شيكات",
            "فواتير",
            "اخري"});
            this.Type_.Location = new System.Drawing.Point(255, 36);
            this.Type_.Name = "Type_";
            this.Type_.Size = new System.Drawing.Size(166, 21);
            this.Type_.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(435, 13);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(118, 40);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(22, 63);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(899, 620);
            this.crystalReportViewer1.TabIndex = 7;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Funds_Detials_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 695);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Type_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.branch_);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_);
            this.Name = "frm_Funds_Detials_Report";
            this.Text = "frm_Funds_Detials_Report";
            this.Load += new System.EventHandler(this.frm_Funds_Detials_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_;
        private System.Windows.Forms.Label label1;
        private MyControls.UC_AccBranch branch_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Type_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}