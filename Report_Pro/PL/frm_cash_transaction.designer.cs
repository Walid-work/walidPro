namespace Report_Pro.PL
{
    partial class frm_cash_transaction
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.Branch = new Report_Pro.MyControls.ذ();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.btn_fees = new DevComponents.DotNetBar.ButtonX();
            this.btn_bank_recet = new DevComponents.DotNetBar.ButtonX();
            this.btn_bank_deposit = new DevComponents.DotNetBar.ButtonX();
            this.btn_cash_recet = new DevComponents.DotNetBar.ButtonX();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.buttonX2);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.Branch);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.ToDate);
            this.groupPanel1.Controls.Add(this.FromDate);
            this.groupPanel1.Controls.Add(this.btn_fees);
            this.groupPanel1.Controls.Add(this.btn_bank_recet);
            this.groupPanel1.Controls.Add(this.btn_bank_deposit);
            this.groupPanel1.Controls.Add(this.btn_cash_recet);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(893, 100);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(82, 57);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(126, 28);
            this.buttonX2.TabIndex = 300;
            this.buttonX2.Text = "كشف الحركة";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(637, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 299;
            this.label3.Text = "الفرع";
            // 
            // Branch
            // 
            this.Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Branch.BackColor = System.Drawing.Color.Transparent;
            this.Branch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.Branch.Location = new System.Drawing.Point(312, 3);
            this.Branch.Margin = new System.Windows.Forms.Padding(0);
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(321, 23);
            this.Branch.TabIndex = 298;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(213, 57);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(126, 28);
            this.buttonX1.TabIndex = 297;
            this.buttonX1.Text = "كشف الحركة";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(833, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 296;
            this.label2.Text = "الي تاريخ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(833, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 295;
            this.label1.Text = "من تاريخ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ToDate
            // 
            this.ToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDate.Location = new System.Drawing.Point(729, 27);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(97, 20);
            this.ToDate.TabIndex = 294;
            this.ToDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // FromDate
            // 
            this.FromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDate.Location = new System.Drawing.Point(729, 3);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(97, 20);
            this.FromDate.TabIndex = 293;
            // 
            // btn_fees
            // 
            this.btn_fees.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_fees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fees.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_fees.Location = new System.Drawing.Point(342, 57);
            this.btn_fees.Name = "btn_fees";
            this.btn_fees.Size = new System.Drawing.Size(126, 28);
            this.btn_fees.TabIndex = 3;
            this.btn_fees.Text = "المصاريف";
            this.btn_fees.Click += new System.EventHandler(this.btn_fees_Click);
            // 
            // btn_bank_recet
            // 
            this.btn_bank_recet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_bank_recet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bank_recet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_bank_recet.Location = new System.Drawing.Point(600, 57);
            this.btn_bank_recet.Name = "btn_bank_recet";
            this.btn_bank_recet.Size = new System.Drawing.Size(126, 28);
            this.btn_bank_recet.TabIndex = 2;
            this.btn_bank_recet.Text = "سندات قبض بنوك";
            this.btn_bank_recet.Click += new System.EventHandler(this.btn_bank_recet_Click);
            // 
            // btn_bank_deposit
            // 
            this.btn_bank_deposit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_bank_deposit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bank_deposit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_bank_deposit.Location = new System.Drawing.Point(471, 57);
            this.btn_bank_deposit.Name = "btn_bank_deposit";
            this.btn_bank_deposit.Size = new System.Drawing.Size(126, 28);
            this.btn_bank_deposit.TabIndex = 1;
            this.btn_bank_deposit.Text = "ايداعات بنكية من الصندوق";
            this.btn_bank_deposit.Click += new System.EventHandler(this.btn_bank_deposit_Click);
            // 
            // btn_cash_recet
            // 
            this.btn_cash_recet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cash_recet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cash_recet.BackColor = System.Drawing.Color.Transparent;
            this.btn_cash_recet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cash_recet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cash_recet.Location = new System.Drawing.Point(729, 57);
            this.btn_cash_recet.Name = "btn_cash_recet";
            this.btn_cash_recet.Size = new System.Drawing.Size(126, 28);
            this.btn_cash_recet.TabIndex = 0;
            this.btn_cash_recet.Text = "سندات قبض نقدية";
            this.btn_cash_recet.Click += new System.EventHandler(this.btn_cash_recet_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 100);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(893, 350);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.ToolPanelWidth = 133;
            // 
            // frm_cash_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frm_cash_transaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "حركة الصندوق";
            this.Load += new System.EventHandler(this.frm_cash_transaction_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btn_fees;
        private DevComponents.DotNetBar.ButtonX btn_bank_recet;
        private DevComponents.DotNetBar.ButtonX btn_bank_deposit;
        private DevComponents.DotNetBar.ButtonX btn_cash_recet;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label label3;
        private MyControls.ذ Branch;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}