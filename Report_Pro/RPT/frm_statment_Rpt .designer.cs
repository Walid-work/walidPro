namespace Report_Pro.RPT
{
    partial class frm_statment_Rpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_statment_Rpt));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rdo_Main = new System.Windows.Forms.RadioButton();
            this.rdo_Sub = new System.Windows.Forms.RadioButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdo_All = new System.Windows.Forms.RadioButton();
            this.rdo_Due = new System.Windows.Forms.RadioButton();
            this.rdo_NonPaid = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UC_Acc1 = new Report_Pro.MyControls.UC_Acc();
            this.UC_Branch = new Report_Pro.MyControls.UC_AccBranch();
            this.UC_Catogry1 = new Report_Pro.MyControls.UC_Catogry();
            this.UC_cost1 = new Report_Pro.MyControls.UC_cost();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.chB_1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.crystalReportViewer1, "crystalReportViewer1");
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.groupControl2);
            this.groupPanel1.Controls.Add(this.groupControl1);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.UC_Acc1);
            this.groupPanel1.Controls.Add(this.UC_Branch);
            this.groupPanel1.Controls.Add(this.UC_Catogry1);
            this.groupPanel1.Controls.Add(this.UC_cost1);
            this.groupPanel1.Controls.Add(this.ToDate);
            this.groupPanel1.Controls.Add(this.FromDate);
            this.groupPanel1.Controls.Add(this.chB_1);
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.Name = "groupPanel1";
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
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
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.Controls.Add(this.rdo_Main);
            this.groupControl2.Controls.Add(this.rdo_Sub);
            resources.ApplyResources(this.groupControl2, "groupControl2");
            this.groupControl2.Name = "groupControl2";
            // 
            // rdo_Main
            // 
            resources.ApplyResources(this.rdo_Main, "rdo_Main");
            this.rdo_Main.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Main.Name = "rdo_Main";
            this.rdo_Main.UseVisualStyleBackColor = false;
            // 
            // rdo_Sub
            // 
            resources.ApplyResources(this.rdo_Sub, "rdo_Sub");
            this.rdo_Sub.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Sub.Checked = true;
            this.rdo_Sub.Name = "rdo_Sub";
            this.rdo_Sub.TabStop = true;
            this.rdo_Sub.UseVisualStyleBackColor = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.rdo_All);
            this.groupControl1.Controls.Add(this.rdo_Due);
            this.groupControl1.Controls.Add(this.rdo_NonPaid);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            // 
            // rdo_All
            // 
            resources.ApplyResources(this.rdo_All, "rdo_All");
            this.rdo_All.BackColor = System.Drawing.Color.Transparent;
            this.rdo_All.Checked = true;
            this.rdo_All.Name = "rdo_All";
            this.rdo_All.TabStop = true;
            this.rdo_All.UseVisualStyleBackColor = false;
            // 
            // rdo_Due
            // 
            resources.ApplyResources(this.rdo_Due, "rdo_Due");
            this.rdo_Due.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Due.Name = "rdo_Due";
            this.rdo_Due.UseVisualStyleBackColor = false;
            // 
            // rdo_NonPaid
            // 
            resources.ApplyResources(this.rdo_NonPaid, "rdo_NonPaid");
            this.rdo_NonPaid.BackColor = System.Drawing.Color.Transparent;
            this.rdo_NonPaid.Name = "rdo_NonPaid";
            this.rdo_NonPaid.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // UC_Acc1
            // 
            this.UC_Acc1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.UC_Acc1, "UC_Acc1");
            this.UC_Acc1.Name = "UC_Acc1";
            // 
            // UC_Branch
            // 
            resources.ApplyResources(this.UC_Branch, "UC_Branch");
            this.UC_Branch.Name = "UC_Branch";
            this.UC_Branch.Load += new System.EventHandler(this.UC_Branch_Load);
            // 
            // UC_Catogry1
            // 
            resources.ApplyResources(this.UC_Catogry1, "UC_Catogry1");
            this.UC_Catogry1.Name = "UC_Catogry1";
            // 
            // UC_cost1
            // 
            resources.ApplyResources(this.UC_cost1, "UC_cost1");
            this.UC_cost1.Name = "UC_cost1";
            // 
            // ToDate
            // 
            resources.ApplyResources(this.ToDate, "ToDate");
            this.ToDate.Name = "ToDate";
            this.ToDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // FromDate
            // 
            resources.ApplyResources(this.FromDate, "FromDate");
            this.FromDate.Name = "FromDate";
            // 
            // chB_1
            // 
            this.chB_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.chB_1, "chB_1");
            this.chB_1.Name = "chB_1";
            this.chB_1.CheckedChanged += new System.EventHandler(this.chB_1_CheckedChanged);
            // 
            // frm_statment_Rpt
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frm_statment_Rpt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_statment_Rpt_Load);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.groupPanel1, 0);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private MyControls.UC_cost uC_cost;
        public MyControls.UC_Acc UC_Acc;
        private MyControls.ذ uC_Branch1;
        private MyControls.UC_Catogry uC_Catogry;
        private MyControls.UC_AccBranch UC_Branch;
        public System.Windows.Forms.DateTimePicker FromDate;
        public System.Windows.Forms.DateTimePicker ToDate;
        public MyControls.UC_Acc UC_Acc1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public DevComponents.DotNetBar.Controls.CheckBoxX chB_1;
        public MyControls.UC_Catogry UC_Catogry1;
        public MyControls.UC_cost UC_cost1;
        private System.Windows.Forms.RadioButton rdo_Due;
        private System.Windows.Forms.RadioButton rdo_NonPaid;
        private System.Windows.Forms.RadioButton rdo_All;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton rdo_Main;
        private System.Windows.Forms.RadioButton rdo_Sub;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}