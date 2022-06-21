namespace Report_Pro.Loans
{
    partial class frm_Loans_Interest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Loans_Interest));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.txtBank = new Report_Pro.MyControls.UC_Acc();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPaidIntrrest = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccruedIntrrest = new DevExpress.XtraEditors.SimpleButton();
            this.btnOption = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.rdo_All_Tearm = new System.Windows.Forms.RadioButton();
            this.rdo_Short_Tearm = new System.Windows.Forms.RadioButton();
            this.rdo_Long_Tearm = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(244, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "To Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From Date";
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(294, 42);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(104, 20);
            this.toDate.TabIndex = 2;
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(77, 42);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(104, 20);
            this.fromDate.TabIndex = 1;
            this.fromDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // txtBank
            // 
            this.txtBank.BackColor = System.Drawing.Color.Transparent;
            this.txtBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBank.Location = new System.Drawing.Point(77, 14);
            this.txtBank.Margin = new System.Windows.Forms.Padding(0);
            this.txtBank.Name = "txtBank";
            this.txtBank.Padding = new System.Windows.Forms.Padding(1);
            this.txtBank.Size = new System.Drawing.Size(321, 22);
            this.txtBank.TabIndex = 0;
            this.txtBank.Load += new System.EventHandler(this.txtBank_Load);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 231);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 413);
            this.crystalReportViewer1.TabIndex = 5;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.btnPaidIntrrest);
            this.groupControl1.Controls.Add(this.btnAccruedIntrrest);
            this.groupControl1.Controls.Add(this.btnOption);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 68);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnPaidIntrrest
            // 
            this.btnPaidIntrrest.AutoSize = true;
            this.btnPaidIntrrest.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPaidIntrrest.ImageOptions.SvgImage")));
            this.btnPaidIntrrest.Location = new System.Drawing.Point(250, 26);
            this.btnPaidIntrrest.Name = "btnPaidIntrrest";
            this.btnPaidIntrrest.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPaidIntrrest.Size = new System.Drawing.Size(102, 36);
            this.btnPaidIntrrest.TabIndex = 2;
            this.btnPaidIntrrest.Text = "Paid Intrrest";
            this.btnPaidIntrrest.Click += new System.EventHandler(this.btnPaidIntrrest_Click);
            // 
            // btnAccruedIntrrest
            // 
            this.btnAccruedIntrrest.AutoSize = true;
            this.btnAccruedIntrrest.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAccruedIntrrest.ImageOptions.SvgImage")));
            this.btnAccruedIntrrest.Location = new System.Drawing.Point(114, 26);
            this.btnAccruedIntrrest.Name = "btnAccruedIntrrest";
            this.btnAccruedIntrrest.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAccruedIntrrest.Size = new System.Drawing.Size(121, 36);
            this.btnAccruedIntrrest.TabIndex = 1;
            this.btnAccruedIntrrest.Text = "Accrued Intrrest";
            this.btnAccruedIntrrest.Click += new System.EventHandler(this.btnAccruedIntrrest_Click);
            // 
            // btnOption
            // 
            this.btnOption.AutoSize = true;
            this.btnOption.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOption.ImageOptions.SvgImage")));
            this.btnOption.Location = new System.Drawing.Point(21, 26);
            this.btnOption.Name = "btnOption";
            this.btnOption.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnOption.Size = new System.Drawing.Size(74, 36);
            this.btnOption.TabIndex = 0;
            this.btnOption.Text = "Option";
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txtBank);
            this.groupControl2.Controls.Add(this.toDate);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.fromDate);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 68);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(800, 163);
            this.groupControl2.TabIndex = 7;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.groupControl3.Appearance.Options.UseBorderColor = true;
            this.groupControl3.Controls.Add(this.rdo_All_Tearm);
            this.groupControl3.Controls.Add(this.rdo_Short_Tearm);
            this.groupControl3.Controls.Add(this.rdo_Long_Tearm);
            this.groupControl3.Location = new System.Drawing.Point(77, 68);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(321, 59);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Loans Tearm";
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
            // frm_Loans_Interest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_Loans_Interest";
            this.Text = "frm_Loans_Interest";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDate;
        private MyControls.UC_Acc txtBank;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromDate;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnPaidIntrrest;
        private DevExpress.XtraEditors.SimpleButton btnAccruedIntrrest;
        private DevExpress.XtraEditors.SimpleButton btnOption;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.RadioButton rdo_All_Tearm;
        private System.Windows.Forms.RadioButton rdo_Short_Tearm;
        private System.Windows.Forms.RadioButton rdo_Long_Tearm;
    }
}