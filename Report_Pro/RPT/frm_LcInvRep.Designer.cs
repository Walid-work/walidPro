namespace Report_Pro.RPT
{
    partial class frm_LcInvRep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LcInvRep));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnReport = new DevComponents.DotNetBar.ButtonX();
            this.btnOption = new DevComponents.DotNetBar.ButtonX();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rdoNotPaid = new System.Windows.Forms.RadioButton();
            this.rdoPaid = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.comb1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.ToDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.FromDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtLcNo = new System.Windows.Forms.TextBox();
            this.txtBank = new Report_Pro.MyControls.UC_Acc();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnReport);
            this.groupPanel1.Controls.Add(this.btnOption);
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
            // btnReport
            // 
            resources.ApplyResources(this.btnReport, "btnReport");
            this.btnReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReport.Image = global::Report_Pro.Properties.Resources.Reports1;
            this.btnReport.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnReport.Name = "btnReport";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnOption
            // 
            resources.ApplyResources(this.btnOption, "btnOption");
            this.btnOption.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOption.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOption.Image = global::Report_Pro.Properties.Resources.choose;
            this.btnOption.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnOption.Name = "btnOption";
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // crystalReportViewer1
            // 
            resources.ApplyResources(this.crystalReportViewer1, "crystalReportViewer1");
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // groupPanel2
            // 
            resources.ApplyResources(this.groupPanel2, "groupPanel2");
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.groupPanel3);
            this.groupPanel2.Controls.Add(this.comb1);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.ToDate);
            this.groupPanel2.Controls.Add(this.FromDate);
            this.groupPanel2.Controls.Add(this.buttonX1);
            this.groupPanel2.Controls.Add(this.txtLcNo);
            this.groupPanel2.Controls.Add(this.txtBank);
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
            // 
            // groupPanel3
            // 
            resources.ApplyResources(this.groupPanel3, "groupPanel3");
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.rdoNotPaid);
            this.groupPanel3.Controls.Add(this.rdoPaid);
            this.groupPanel3.Controls.Add(this.rdoAll);
            this.groupPanel3.Name = "groupPanel3";
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // rdoNotPaid
            // 
            resources.ApplyResources(this.rdoNotPaid, "rdoNotPaid");
            this.rdoNotPaid.BackColor = System.Drawing.Color.Transparent;
            this.rdoNotPaid.Name = "rdoNotPaid";
            this.rdoNotPaid.TabStop = true;
            this.rdoNotPaid.UseVisualStyleBackColor = false;
            // 
            // rdoPaid
            // 
            resources.ApplyResources(this.rdoPaid, "rdoPaid");
            this.rdoPaid.BackColor = System.Drawing.Color.Transparent;
            this.rdoPaid.Name = "rdoPaid";
            this.rdoPaid.TabStop = true;
            this.rdoPaid.UseVisualStyleBackColor = false;
            // 
            // rdoAll
            // 
            resources.ApplyResources(this.rdoAll, "rdoAll");
            this.rdoAll.BackColor = System.Drawing.Color.Transparent;
            this.rdoAll.Checked = true;
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.TabStop = true;
            this.rdoAll.UseVisualStyleBackColor = false;
            // 
            // comb1
            // 
            resources.ApplyResources(this.comb1, "comb1");
            this.comb1.DisplayMember = "Text";
            this.comb1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comb1.FormattingEnabled = true;
            this.comb1.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.comb1.Name = "comb1";
            // 
            // comboItem1
            // 
            resources.ApplyResources(this.comboItem1, "comboItem1");
            // 
            // comboItem2
            // 
            resources.ApplyResources(this.comboItem2, "comboItem2");
            // 
            // comboItem3
            // 
            resources.ApplyResources(this.comboItem3, "comboItem3");
            // 
            // comboItem4
            // 
            resources.ApplyResources(this.comboItem4, "comboItem4");
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
            // labelX2
            // 
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Name = "labelX2";
            // 
            // labelX7
            // 
            resources.ApplyResources(this.labelX7, "labelX7");
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Name = "labelX7";
            // 
            // ToDate
            // 
            resources.ApplyResources(this.ToDate, "ToDate");
            // 
            // 
            // 
            this.ToDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ToDate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("ToDate.ButtonClear.DisplayPosition")));
            this.ToDate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("ToDate.ButtonClear.Image")));
            this.ToDate.ButtonClear.Text = resources.GetString("ToDate.ButtonClear.Text");
            this.ToDate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("ToDate.ButtonCustom.DisplayPosition")));
            this.ToDate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("ToDate.ButtonCustom.Image")));
            this.ToDate.ButtonCustom.Text = resources.GetString("ToDate.ButtonCustom.Text");
            this.ToDate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("ToDate.ButtonCustom2.DisplayPosition")));
            this.ToDate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("ToDate.ButtonCustom2.Image")));
            this.ToDate.ButtonCustom2.Text = resources.GetString("ToDate.ButtonCustom2.Text");
            this.ToDate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("ToDate.ButtonDropDown.DisplayPosition")));
            this.ToDate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("ToDate.ButtonDropDown.Image")));
            this.ToDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.ToDate.ButtonDropDown.Text = resources.GetString("ToDate.ButtonDropDown.Text");
            this.ToDate.ButtonDropDown.Visible = true;
            this.ToDate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("ToDate.ButtonFreeText.DisplayPosition")));
            this.ToDate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("ToDate.ButtonFreeText.Image")));
            this.ToDate.ButtonFreeText.Text = resources.GetString("ToDate.ButtonFreeText.Text");
            // 
            // 
            // 
            this.ToDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("ToDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.ToDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.ToDate.MonthCalendar.Category = resources.GetString("ToDate.MonthCalendar.Category");
            this.ToDate.MonthCalendar.ClearButtonVisible = true;
            this.ToDate.MonthCalendar.CommandParameter = ((object)(resources.GetObject("ToDate.MonthCalendar.CommandParameter")));
            // 
            // 
            // 
            this.ToDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ToDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.ToDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ToDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ToDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.ToDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.ToDate.MonthCalendar.DayNames = ((string[])(resources.GetObject("ToDate.MonthCalendar.DayNames")));
            this.ToDate.MonthCalendar.Description = resources.GetString("ToDate.MonthCalendar.Description");
            this.ToDate.MonthCalendar.DisplayMonth = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.ToDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("ToDate.MonthCalendar.MarkedDates")));
            this.ToDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("ToDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.ToDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.ToDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.ToDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ToDate.MonthCalendar.Tag = resources.GetString("ToDate.MonthCalendar.Tag");
            this.ToDate.MonthCalendar.Text = resources.GetString("ToDate.MonthCalendar.Text");
            this.ToDate.MonthCalendar.TodayButtonVisible = true;
            this.ToDate.MonthCalendar.Tooltip = resources.GetString("ToDate.MonthCalendar.Tooltip");
            this.ToDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("ToDate.MonthCalendar.WeeklyMarkedDays")));
            this.ToDate.Name = "ToDate";
            // 
            // FromDate
            // 
            resources.ApplyResources(this.FromDate, "FromDate");
            // 
            // 
            // 
            this.FromDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.FromDate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("FromDate.ButtonClear.DisplayPosition")));
            this.FromDate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("FromDate.ButtonClear.Image")));
            this.FromDate.ButtonClear.Text = resources.GetString("FromDate.ButtonClear.Text");
            this.FromDate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("FromDate.ButtonCustom.DisplayPosition")));
            this.FromDate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("FromDate.ButtonCustom.Image")));
            this.FromDate.ButtonCustom.Text = resources.GetString("FromDate.ButtonCustom.Text");
            this.FromDate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("FromDate.ButtonCustom2.DisplayPosition")));
            this.FromDate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("FromDate.ButtonCustom2.Image")));
            this.FromDate.ButtonCustom2.Text = resources.GetString("FromDate.ButtonCustom2.Text");
            this.FromDate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("FromDate.ButtonDropDown.DisplayPosition")));
            this.FromDate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("FromDate.ButtonDropDown.Image")));
            this.FromDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.FromDate.ButtonDropDown.Text = resources.GetString("FromDate.ButtonDropDown.Text");
            this.FromDate.ButtonDropDown.Visible = true;
            this.FromDate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("FromDate.ButtonFreeText.DisplayPosition")));
            this.FromDate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("FromDate.ButtonFreeText.Image")));
            this.FromDate.ButtonFreeText.Text = resources.GetString("FromDate.ButtonFreeText.Text");
            // 
            // 
            // 
            this.FromDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("FromDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.FromDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.FromDate.MonthCalendar.Category = resources.GetString("FromDate.MonthCalendar.Category");
            this.FromDate.MonthCalendar.ClearButtonVisible = true;
            this.FromDate.MonthCalendar.CommandParameter = ((object)(resources.GetObject("FromDate.MonthCalendar.CommandParameter")));
            // 
            // 
            // 
            this.FromDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.FromDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.FromDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.FromDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.FromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.FromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.FromDate.MonthCalendar.DayNames = ((string[])(resources.GetObject("FromDate.MonthCalendar.DayNames")));
            this.FromDate.MonthCalendar.Description = resources.GetString("FromDate.MonthCalendar.Description");
            this.FromDate.MonthCalendar.DisplayMonth = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.FromDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("FromDate.MonthCalendar.MarkedDates")));
            this.FromDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("FromDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.FromDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.FromDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.FromDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.FromDate.MonthCalendar.Tag = resources.GetString("FromDate.MonthCalendar.Tag");
            this.FromDate.MonthCalendar.Text = resources.GetString("FromDate.MonthCalendar.Text");
            this.FromDate.MonthCalendar.TodayButtonVisible = true;
            this.FromDate.MonthCalendar.Tooltip = resources.GetString("FromDate.MonthCalendar.Tooltip");
            this.FromDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("FromDate.MonthCalendar.WeeklyMarkedDays")));
            this.FromDate.Name = "FromDate";
            // 
            // buttonX1
            // 
            resources.ApplyResources(this.buttonX1, "buttonX1");
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::Report_Pro.Properties.Resources.search_16;
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtLcNo
            // 
            resources.ApplyResources(this.txtLcNo, "txtLcNo");
            this.txtLcNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtLcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLcNo.Name = "txtLcNo";
            // 
            // txtBank
            // 
            resources.ApplyResources(this.txtBank, "txtBank");
            this.txtBank.BackColor = System.Drawing.Color.Transparent;
            this.txtBank.Name = "txtBank";
            // 
            // frm_LcInvRep
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frm_LcInvRep";
            this.Load += new System.EventHandler(this.frm_LcInvRep_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnReport;
        private DevComponents.DotNetBar.ButtonX btnOption;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private Report_Pro.MyControls.UC_Acc txtBank;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.TextBox txtLcNo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput ToDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput FromDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comb1;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.RadioButton rdoNotPaid;
        private System.Windows.Forms.RadioButton rdoPaid;
        private System.Windows.Forms.RadioButton rdoAll;
    }
}