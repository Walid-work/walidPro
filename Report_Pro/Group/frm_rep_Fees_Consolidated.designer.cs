namespace Report_Pro.Group
{
    partial class frm_rep_Fees_Consolidated
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
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rep_Fees_Consolidated));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnReport_2 = new DevComponents.DotNetBar.ButtonX();
            this.btnOption = new DevComponents.DotNetBar.ButtonX();
            this.btnReport_1 = new DevComponents.DotNetBar.ButtonX();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.Acc_Group = new Report_Pro.MyControls.UC_Acc_Group();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.toDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.fromDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtAcc = new Report_Pro.MyControls.UC_Acc();
            this.txtBranch = new Report_Pro.MyControls.UC_AccBranch();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnReport_2);
            this.groupPanel1.Controls.Add(this.btnOption);
            this.groupPanel1.Controls.Add(this.btnReport_1);
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.Name = "groupPanel1";
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
            // 
            // btnReport_2
            // 
            this.btnReport_2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReport_2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnReport_2, "btnReport_2");
            this.btnReport_2.Name = "btnReport_2";
            this.btnReport_2.Click += new System.EventHandler(this.btnReport_2_Click);
            // 
            // btnOption
            // 
            this.btnOption.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOption.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnOption, "btnOption");
            this.btnOption.Name = "btnOption";
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnReport_1
            // 
            this.btnReport_1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReport_1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnReport_1, "btnReport_1");
            this.btnReport_1.Name = "btnReport_1";
            this.btnReport_1.Click += new System.EventHandler(this.btnReport_1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.crystalReportViewer1, "crystalReportViewer1");
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.Acc_Group);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.toDate);
            this.groupPanel2.Controls.Add(this.fromDate);
            this.groupPanel2.Controls.Add(this.txtAcc);
            this.groupPanel2.Controls.Add(this.txtBranch);
            resources.ApplyResources(this.groupPanel2, "groupPanel2");
            this.groupPanel2.Name = "groupPanel2";
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.Click += new System.EventHandler(this.groupPanel2_Click);
            // 
            // labelX5
            // 
            resources.ApplyResources(this.labelX5, "labelX5");
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Name = "labelX5";
            this.labelX5.Click += new System.EventHandler(this.labelX5_Click);
            // 
            // Acc_Group
            // 
            this.Acc_Group.BackColor = System.Drawing.Color.Transparent;
            this.Acc_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Acc_Group, "Acc_Group");
            this.Acc_Group.Name = "Acc_Group";
            // 
            // labelX4
            // 
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Name = "labelX4";
            // 
            // labelX3
            // 
            resources.ApplyResources(this.labelX3, "labelX3");
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Name = "labelX3";
            // 
            // labelX1
            // 
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Name = "labelX1";
            // 
            // toDate
            // 
            // 
            // 
            // 
            this.toDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.toDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.toDate.ButtonDropDown.Visible = true;
            resources.ApplyResources(this.toDate, "toDate");
            // 
            // 
            // 
            this.toDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("toDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.toDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.toDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.toDate.MonthCalendar.DisplayMonth = new System.DateTime(2020, 8, 1, 0, 0, 0, 0);
            this.toDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("toDate.MonthCalendar.MarkedDates")));
            this.toDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("toDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.toDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.toDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.toDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.toDate.MonthCalendar.TodayButtonVisible = true;
            this.toDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("toDate.MonthCalendar.WeeklyMarkedDays")));
            this.toDate.Name = "toDate";
            // 
            // fromDate
            // 
            // 
            // 
            // 
            this.fromDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.fromDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.fromDate.ButtonDropDown.Visible = true;
            resources.ApplyResources(this.fromDate, "fromDate");
            // 
            // 
            // 
            this.fromDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("fromDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.fromDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.fromDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.fromDate.MonthCalendar.DisplayMonth = new System.DateTime(2020, 8, 1, 0, 0, 0, 0);
            this.fromDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("fromDate.MonthCalendar.MarkedDates")));
            this.fromDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("fromDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.fromDate.MonthCalendar.TodayButtonVisible = true;
            this.fromDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("fromDate.MonthCalendar.WeeklyMarkedDays")));
            this.fromDate.Name = "fromDate";
            // 
            // txtAcc
            // 
            this.txtAcc.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtAcc, "txtAcc");
            this.txtAcc.Name = "txtAcc";
            // 
            // txtBranch
            // 
            this.txtBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtBranch, "txtBranch");
            this.txtBranch.Name = "txtBranch";
            // 
            // frm_rep_Fees_Consolidated
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frm_rep_Fees_Consolidated";
            this.Load += new System.EventHandler(this.frm_rep_Fees_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX4;
       private DevComponents.DotNetBar.LabelX labelX3;
       private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput toDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput fromDate;
        private MyControls.UC_Acc txtAcc;
        private MyControls.UC_AccBranch txtBranch;
        private DevComponents.DotNetBar.ButtonX btnReport_1;
        private DevComponents.DotNetBar.ButtonX btnOption;
        private DevComponents.DotNetBar.ButtonX btnReport_2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private Report_Pro.MyControls.UC_Acc_Group Acc_Group;
    }
}