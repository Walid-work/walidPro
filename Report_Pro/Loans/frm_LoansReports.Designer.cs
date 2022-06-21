namespace Report_Pro.Loans
{
    partial class frm_LoansReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LoansReports));
            this.rdoAllBalance = new System.Windows.Forms.RadioButton();
            this.rdoUn_Zero = new System.Windows.Forms.RadioButton();
            this.rdoZero = new System.Windows.Forms.RadioButton();
            this.txtLoanNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_All_Tearm = new System.Windows.Forms.RadioButton();
            this.rdo_Long_Tearm = new System.Windows.Forms.RadioButton();
            this.rdo_Short_Tearm = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtBank = new Report_Pro.MyControls.UC_Acc();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Loans_Transaction = new DevExpress.XtraEditors.SimpleButton();
            this.btnPaymentsLoans = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewLoans = new DevExpress.XtraEditors.SimpleButton();
            this.btnMaturityLoans = new DevExpress.XtraEditors.SimpleButton();
            this.btnReportToal = new DevExpress.XtraEditors.SimpleButton();
            this.btnOption = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoAllBalance
            // 
            this.rdoAllBalance.AutoSize = true;
            this.rdoAllBalance.BackColor = System.Drawing.Color.Transparent;
            this.rdoAllBalance.Checked = true;
            this.rdoAllBalance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdoAllBalance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoAllBalance.Location = new System.Drawing.Point(30, 32);
            this.rdoAllBalance.Margin = new System.Windows.Forms.Padding(5);
            this.rdoAllBalance.Name = "rdoAllBalance";
            this.rdoAllBalance.Size = new System.Drawing.Size(36, 17);
            this.rdoAllBalance.TabIndex = 46;
            this.rdoAllBalance.TabStop = true;
            this.rdoAllBalance.Text = "All";
            this.rdoAllBalance.UseVisualStyleBackColor = false;
            // 
            // rdoUn_Zero
            // 
            this.rdoUn_Zero.AutoSize = true;
            this.rdoUn_Zero.BackColor = System.Drawing.Color.Transparent;
            this.rdoUn_Zero.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdoUn_Zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoUn_Zero.Location = new System.Drawing.Point(199, 32);
            this.rdoUn_Zero.Margin = new System.Windows.Forms.Padding(5);
            this.rdoUn_Zero.Name = "rdoUn_Zero";
            this.rdoUn_Zero.Size = new System.Drawing.Size(94, 17);
            this.rdoUn_Zero.TabIndex = 48;
            this.rdoUn_Zero.Text = "UnZero Balanc";
            this.rdoUn_Zero.UseVisualStyleBackColor = false;
            // 
            // rdoZero
            // 
            this.rdoZero.AutoSize = true;
            this.rdoZero.BackColor = System.Drawing.Color.Transparent;
            this.rdoZero.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdoZero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoZero.Location = new System.Drawing.Point(95, 32);
            this.rdoZero.Margin = new System.Windows.Forms.Padding(5);
            this.rdoZero.Name = "rdoZero";
            this.rdoZero.Size = new System.Drawing.Size(87, 17);
            this.rdoZero.TabIndex = 47;
            this.rdoZero.Text = "Zero Balance";
            this.rdoZero.UseVisualStyleBackColor = false;
            // 
            // txtLoanNo
            // 
            this.txtLoanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoanNo.Location = new System.Drawing.Point(83, 42);
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.Size = new System.Drawing.Size(178, 20);
            this.txtLoanNo.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Loan No.";
            // 
            // rdo_All_Tearm
            // 
            this.rdo_All_Tearm.AutoSize = true;
            this.rdo_All_Tearm.BackColor = System.Drawing.Color.Transparent;
            this.rdo_All_Tearm.Checked = true;
            this.rdo_All_Tearm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdo_All_Tearm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdo_All_Tearm.Location = new System.Drawing.Point(25, 31);
            this.rdo_All_Tearm.Margin = new System.Windows.Forms.Padding(5);
            this.rdo_All_Tearm.Name = "rdo_All_Tearm";
            this.rdo_All_Tearm.Size = new System.Drawing.Size(36, 17);
            this.rdo_All_Tearm.TabIndex = 46;
            this.rdo_All_Tearm.TabStop = true;
            this.rdo_All_Tearm.Text = "All";
            this.rdo_All_Tearm.UseVisualStyleBackColor = false;
            // 
            // rdo_Long_Tearm
            // 
            this.rdo_Long_Tearm.AutoSize = true;
            this.rdo_Long_Tearm.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Long_Tearm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdo_Long_Tearm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdo_Long_Tearm.Location = new System.Drawing.Point(211, 31);
            this.rdo_Long_Tearm.Margin = new System.Windows.Forms.Padding(5);
            this.rdo_Long_Tearm.Name = "rdo_Long_Tearm";
            this.rdo_Long_Tearm.Size = new System.Drawing.Size(81, 17);
            this.rdo_Long_Tearm.TabIndex = 48;
            this.rdo_Long_Tearm.Text = "Long Tearm";
            this.rdo_Long_Tearm.UseVisualStyleBackColor = false;
            // 
            // rdo_Short_Tearm
            // 
            this.rdo_Short_Tearm.AutoSize = true;
            this.rdo_Short_Tearm.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Short_Tearm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdo_Short_Tearm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdo_Short_Tearm.Location = new System.Drawing.Point(92, 31);
            this.rdo_Short_Tearm.Margin = new System.Windows.Forms.Padding(5);
            this.rdo_Short_Tearm.Name = "rdo_Short_Tearm";
            this.rdo_Short_Tearm.Size = new System.Drawing.Size(84, 17);
            this.rdo_Short_Tearm.TabIndex = 47;
            this.rdo_Short_Tearm.Text = "Short Tearm";
            this.rdo_Short_Tearm.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "To Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From Date";
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(303, 69);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(104, 20);
            this.toDate.TabIndex = 2;
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(83, 69);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(104, 20);
            this.fromDate.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 221);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1041, 444);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtLoanNo);
            this.groupControl1.Controls.Add(this.toDate);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.fromDate);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.txtBank);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 66);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1041, 155);
            this.groupControl1.TabIndex = 3;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.groupControl3.Appearance.Options.UseBorderColor = true;
            this.groupControl3.Controls.Add(this.rdo_All_Tearm);
            this.groupControl3.Controls.Add(this.rdo_Short_Tearm);
            this.groupControl3.Controls.Add(this.rdo_Long_Tearm);
            this.groupControl3.Location = new System.Drawing.Point(659, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(301, 59);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Loans Tearm";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.Controls.Add(this.rdoAllBalance);
            this.groupControl2.Controls.Add(this.rdoZero);
            this.groupControl2.Controls.Add(this.rdoUn_Zero);
            this.groupControl2.Location = new System.Drawing.Point(659, 79);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(301, 59);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Balance";
            // 
            // txtBank
            // 
            this.txtBank.BackColor = System.Drawing.Color.Transparent;
            this.txtBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBank.Location = new System.Drawing.Point(83, 14);
            this.txtBank.Margin = new System.Windows.Forms.Padding(0);
            this.txtBank.Name = "txtBank";
            this.txtBank.Padding = new System.Windows.Forms.Padding(1);
            this.txtBank.Size = new System.Drawing.Size(321, 22);
            this.txtBank.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.groupControl4.Appearance.Options.UseBorderColor = true;
            this.groupControl4.Controls.Add(this.btn_Loans_Transaction);
            this.groupControl4.Controls.Add(this.btnPaymentsLoans);
            this.groupControl4.Controls.Add(this.btnNewLoans);
            this.groupControl4.Controls.Add(this.btnMaturityLoans);
            this.groupControl4.Controls.Add(this.btnReportToal);
            this.groupControl4.Controls.Add(this.btnOption);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1041, 66);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "groupControl4";
            // 
            // btn_Loans_Transaction
            // 
            this.btn_Loans_Transaction.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Loans_Transaction.ImageOptions.SvgImage")));
            this.btn_Loans_Transaction.Location = new System.Drawing.Point(707, 26);
            this.btn_Loans_Transaction.Name = "btn_Loans_Transaction";
            this.btn_Loans_Transaction.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Loans_Transaction.Size = new System.Drawing.Size(135, 29);
            this.btn_Loans_Transaction.TabIndex = 5;
            this.btn_Loans_Transaction.Text = "Loans Transaction";
            this.btn_Loans_Transaction.Click += new System.EventHandler(this.btn_Loans_Transaction_Click);
            // 
            // btnPaymentsLoans
            // 
            this.btnPaymentsLoans.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPaymentsLoans.ImageOptions.SvgImage")));
            this.btnPaymentsLoans.Location = new System.Drawing.Point(564, 26);
            this.btnPaymentsLoans.Name = "btnPaymentsLoans";
            this.btnPaymentsLoans.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPaymentsLoans.Size = new System.Drawing.Size(135, 29);
            this.btnPaymentsLoans.TabIndex = 4;
            this.btnPaymentsLoans.Text = "Payments Loans";
            this.btnPaymentsLoans.Click += new System.EventHandler(this.btnPaymentsLoans_Click);
            // 
            // btnNewLoans
            // 
            this.btnNewLoans.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNewLoans.ImageOptions.SvgImage")));
            this.btnNewLoans.Location = new System.Drawing.Point(421, 26);
            this.btnNewLoans.Name = "btnNewLoans";
            this.btnNewLoans.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnNewLoans.Size = new System.Drawing.Size(135, 29);
            this.btnNewLoans.TabIndex = 3;
            this.btnNewLoans.Text = "New Loans";
            this.btnNewLoans.Click += new System.EventHandler(this.btnNewLoans_Click);
            // 
            // btnMaturityLoans
            // 
            this.btnMaturityLoans.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMaturityLoans.ImageOptions.SvgImage")));
            this.btnMaturityLoans.Location = new System.Drawing.Point(278, 26);
            this.btnMaturityLoans.Name = "btnMaturityLoans";
            this.btnMaturityLoans.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMaturityLoans.Size = new System.Drawing.Size(135, 29);
            this.btnMaturityLoans.TabIndex = 2;
            this.btnMaturityLoans.Text = "Maturity Loans";
            this.btnMaturityLoans.Click += new System.EventHandler(this.btnMaturityLoans_Click);
            // 
            // btnReportToal
            // 
            this.btnReportToal.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReportToal.ImageOptions.SvgImage")));
            this.btnReportToal.Location = new System.Drawing.Point(135, 26);
            this.btnReportToal.Name = "btnReportToal";
            this.btnReportToal.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnReportToal.Size = new System.Drawing.Size(135, 29);
            this.btnReportToal.TabIndex = 1;
            this.btnReportToal.Text = "Report Total";
            this.btnReportToal.Click += new System.EventHandler(this.btnReportToal_Click);
            // 
            // btnOption
            // 
            this.btnOption.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOption.ImageOptions.SvgImage")));
            this.btnOption.Location = new System.Drawing.Point(12, 26);
            this.btnOption.Name = "btnOption";
            this.btnOption.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnOption.Size = new System.Drawing.Size(93, 29);
            this.btnOption.TabIndex = 0;
            this.btnOption.Text = "Option";
            // 
            // frm_LoansReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 665);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_LoansReports.IconOptions.SvgImage")));
            this.Name = "frm_LoansReports";
            this.Text = "Loans Reports";
            this.Load += new System.EventHandler(this.frm_LoansReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MyControls.UC_Acc txtBank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RadioButton rdo_All_Tearm;
        private System.Windows.Forms.RadioButton rdo_Long_Tearm;
        private System.Windows.Forms.RadioButton rdo_Short_Tearm;
        private System.Windows.Forms.TextBox txtLoanNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoAllBalance;
        private System.Windows.Forms.RadioButton rdoUn_Zero;
        private System.Windows.Forms.RadioButton rdoZero;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnPaymentsLoans;
        private DevExpress.XtraEditors.SimpleButton btnNewLoans;
        private DevExpress.XtraEditors.SimpleButton btnMaturityLoans;
        private DevExpress.XtraEditors.SimpleButton btnReportToal;
        private DevExpress.XtraEditors.SimpleButton btnOption;
        private DevExpress.XtraEditors.SimpleButton btn_Loans_Transaction;
    }
}