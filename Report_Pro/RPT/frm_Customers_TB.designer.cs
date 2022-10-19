namespace Report_Pro.RPT
{
    partial class frm_Customers_TB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customers_TB));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new ADGV.AdvancedDataGridView();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.T_Eb = new System.Windows.Forms.TextBox();
            this.T_Cr = new System.Windows.Forms.TextBox();
            this.T_Bb = new System.Windows.Forms.TextBox();
            this.T_Db = new System.Windows.Forms.TextBox();
            this.ContextM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Statment_ = new System.Windows.Forms.ToolStripMenuItem();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.FromDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.UserName = new System.Windows.Forms.TextBox();
            this.ToDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.RB6 = new System.Windows.Forms.RadioButton();
            this.RB5 = new System.Windows.Forms.RadioButton();
            this.RB4 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.gBox3 = new System.Windows.Forms.GroupBox();
            this.b1 = new DevComponents.Editors.DoubleInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.b2 = new DevComponents.Editors.DoubleInput();
            this.chBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RS2 = new System.Windows.Forms.RadioButton();
            this.RS1 = new System.Windows.Forms.RadioButton();
            this.UC_Catogry = new Report_Pro.MyControls.UC_Catogry();
            this.UC_cost = new Report_Pro.MyControls.UC_cost();
            this.UC_Branch = new Report_Pro.MyControls.ذ();
            this.UC_Acc = new Report_Pro.MyControls.UC_Acc();
            this.barCodeReader1 = new Aspose.BarCode.BarCodeRecognition.BarCodeReader();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.ContextM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.gBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            resources.ApplyResources(this.btn_preview, "btn_preview");
            this.btn_preview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_preview.ImageOptions.Image")));
            // 
            // crystalReportViewer1
            // 
            resources.ApplyResources(this.crystalReportViewer1, "crystalReportViewer1");
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.DataGridView1);
            this.panel3.Controls.Add(this.groupPanel2);
            this.panel3.Name = "panel3";
            // 
            // DataGridView1
            // 
            resources.ApplyResources(this.DataGridView1, "DataGridView1");
            this.DataGridView1.AutoGenerateContextFilters = true;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.DateWithTime = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.TimeFilter = false;
            this.DataGridView1.SortStringChanged += new System.EventHandler(this.DataGridView1_SortStringChanged);
            this.DataGridView1.FilterStringChanged += new System.EventHandler(this.DataGridView1_FilterStringChanged);
            // 
            // groupPanel2
            // 
            resources.ApplyResources(this.groupPanel2, "groupPanel2");
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.T_Eb);
            this.groupPanel2.Controls.Add(this.T_Cr);
            this.groupPanel2.Controls.Add(this.T_Bb);
            this.groupPanel2.Controls.Add(this.T_Db);
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
            // T_Eb
            // 
            resources.ApplyResources(this.T_Eb, "T_Eb");
            this.T_Eb.BackColor = System.Drawing.Color.White;
            this.T_Eb.Name = "T_Eb";
            // 
            // T_Cr
            // 
            resources.ApplyResources(this.T_Cr, "T_Cr");
            this.T_Cr.BackColor = System.Drawing.Color.White;
            this.T_Cr.Name = "T_Cr";
            this.T_Cr.TextChanged += new System.EventHandler(this.T_Cr_TextChanged);
            // 
            // T_Bb
            // 
            resources.ApplyResources(this.T_Bb, "T_Bb");
            this.T_Bb.BackColor = System.Drawing.Color.White;
            this.T_Bb.Name = "T_Bb";
            // 
            // T_Db
            // 
            resources.ApplyResources(this.T_Db, "T_Db");
            this.T_Db.BackColor = System.Drawing.Color.White;
            this.T_Db.Name = "T_Db";
            // 
            // ContextM
            // 
            resources.ApplyResources(this.ContextM, "ContextM");
            this.ContextM.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Statment_});
            this.ContextM.Name = "ContextM";
            // 
            // Statment_
            // 
            resources.ApplyResources(this.Statment_, "Statment_");
            this.Statment_.Name = "Statment_";
            this.Statment_.Click += new System.EventHandler(this.Statment__Click);
            // 
            // labelX6
            // 
            resources.ApplyResources(this.labelX6, "labelX6");
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Name = "labelX6";
            // 
            // labelX1
            // 
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Name = "labelX1";
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
            // UserName
            // 
            resources.ApplyResources(this.UserName, "UserName");
            this.UserName.BackColor = System.Drawing.Color.White;
            this.UserName.Name = "UserName";
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
            // labelX7
            // 
            resources.ApplyResources(this.labelX7, "labelX7");
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Name = "labelX7";
            // 
            // GroupBox2
            // 
            resources.ApplyResources(this.GroupBox2, "GroupBox2");
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.RB6);
            this.GroupBox2.Controls.Add(this.RB5);
            this.GroupBox2.Controls.Add(this.RB4);
            this.GroupBox2.Controls.Add(this.RB3);
            this.GroupBox2.Controls.Add(this.RB2);
            this.GroupBox2.Controls.Add(this.RB1);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.TabStop = false;
            // 
            // RB6
            // 
            resources.ApplyResources(this.RB6, "RB6");
            this.RB6.Name = "RB6";
            this.RB6.UseVisualStyleBackColor = true;
            // 
            // RB5
            // 
            resources.ApplyResources(this.RB5, "RB5");
            this.RB5.Name = "RB5";
            this.RB5.UseVisualStyleBackColor = true;
            // 
            // RB4
            // 
            resources.ApplyResources(this.RB4, "RB4");
            this.RB4.Name = "RB4";
            this.RB4.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            resources.ApplyResources(this.RB3, "RB3");
            this.RB3.Name = "RB3";
            this.RB3.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            resources.ApplyResources(this.RB2, "RB2");
            this.RB2.Checked = true;
            this.RB2.Name = "RB2";
            this.RB2.TabStop = true;
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB1
            // 
            resources.ApplyResources(this.RB1, "RB1");
            this.RB1.Name = "RB1";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // labelX2
            // 
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Name = "labelX2";
            // 
            // groupPanel1
            // 
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.gBox3);
            this.groupPanel1.Controls.Add(this.chBox);
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Controls.Add(this.ToDate);
            this.groupPanel1.Controls.Add(this.UC_Catogry);
            this.groupPanel1.Controls.Add(this.UC_cost);
            this.groupPanel1.Controls.Add(this.UC_Branch);
            this.groupPanel1.Controls.Add(this.UC_Acc);
            this.groupPanel1.Controls.Add(this.GroupBox2);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.UserName);
            this.groupPanel1.Controls.Add(this.FromDate);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.labelX6);
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
            // gBox3
            // 
            resources.ApplyResources(this.gBox3, "gBox3");
            this.gBox3.Controls.Add(this.b1);
            this.gBox3.Controls.Add(this.labelX4);
            this.gBox3.Controls.Add(this.b2);
            this.gBox3.Name = "gBox3";
            this.gBox3.TabStop = false;
            // 
            // b1
            // 
            resources.ApplyResources(this.b1, "b1");
            // 
            // 
            // 
            this.b1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.b1.ButtonClear.DisplayPosition = ((int)(resources.GetObject("b1.ButtonClear.DisplayPosition")));
            this.b1.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("b1.ButtonClear.Image")));
            this.b1.ButtonClear.Text = resources.GetString("b1.ButtonClear.Text");
            this.b1.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("b1.ButtonCustom.DisplayPosition")));
            this.b1.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("b1.ButtonCustom.Image")));
            this.b1.ButtonCustom.Text = resources.GetString("b1.ButtonCustom.Text");
            this.b1.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("b1.ButtonCustom2.DisplayPosition")));
            this.b1.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("b1.ButtonCustom2.Image")));
            this.b1.ButtonCustom2.Text = resources.GetString("b1.ButtonCustom2.Text");
            this.b1.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("b1.ButtonDropDown.DisplayPosition")));
            this.b1.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("b1.ButtonDropDown.Image")));
            this.b1.ButtonDropDown.Text = resources.GetString("b1.ButtonDropDown.Text");
            this.b1.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("b1.ButtonFreeText.DisplayPosition")));
            this.b1.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("b1.ButtonFreeText.Image")));
            this.b1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.b1.ButtonFreeText.Text = resources.GetString("b1.ButtonFreeText.Text");
            this.b1.DisplayFormat = "#,##0.000";
            this.b1.Increment = 1D;
            this.b1.Name = "b1";
            // 
            // labelX4
            // 
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Name = "labelX4";
            // 
            // b2
            // 
            resources.ApplyResources(this.b2, "b2");
            // 
            // 
            // 
            this.b2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.b2.ButtonClear.DisplayPosition = ((int)(resources.GetObject("b2.ButtonClear.DisplayPosition")));
            this.b2.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("b2.ButtonClear.Image")));
            this.b2.ButtonClear.Text = resources.GetString("b2.ButtonClear.Text");
            this.b2.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("b2.ButtonCustom.DisplayPosition")));
            this.b2.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("b2.ButtonCustom.Image")));
            this.b2.ButtonCustom.Text = resources.GetString("b2.ButtonCustom.Text");
            this.b2.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("b2.ButtonCustom2.DisplayPosition")));
            this.b2.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("b2.ButtonCustom2.Image")));
            this.b2.ButtonCustom2.Text = resources.GetString("b2.ButtonCustom2.Text");
            this.b2.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("b2.ButtonDropDown.DisplayPosition")));
            this.b2.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("b2.ButtonDropDown.Image")));
            this.b2.ButtonDropDown.Text = resources.GetString("b2.ButtonDropDown.Text");
            this.b2.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("b2.ButtonFreeText.DisplayPosition")));
            this.b2.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("b2.ButtonFreeText.Image")));
            this.b2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.b2.ButtonFreeText.Text = resources.GetString("b2.ButtonFreeText.Text");
            this.b2.DisplayFormat = "#,##0.000";
            this.b2.Increment = 1D;
            this.b2.Name = "b2";
            // 
            // chBox
            // 
            resources.ApplyResources(this.chBox, "chBox");
            this.chBox.Name = "chBox";
            this.chBox.UseVisualStyleBackColor = true;
            this.chBox.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RS2);
            this.groupBox1.Controls.Add(this.RS1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // RS2
            // 
            resources.ApplyResources(this.RS2, "RS2");
            this.RS2.Name = "RS2";
            this.RS2.UseVisualStyleBackColor = true;
            this.RS2.CheckedChanged += new System.EventHandler(this.RS2_CheckedChanged);
            // 
            // RS1
            // 
            resources.ApplyResources(this.RS1, "RS1");
            this.RS1.Checked = true;
            this.RS1.Name = "RS1";
            this.RS1.TabStop = true;
            this.RS1.UseVisualStyleBackColor = true;
            // 
            // UC_Catogry
            // 
            resources.ApplyResources(this.UC_Catogry, "UC_Catogry");
            this.UC_Catogry.Name = "UC_Catogry";
            // 
            // UC_cost
            // 
            resources.ApplyResources(this.UC_cost, "UC_cost");
            this.UC_cost.Name = "UC_cost";
            this.UC_cost.Load += new System.EventHandler(this.uC_cost1_Load);
            // 
            // UC_Branch
            // 
            resources.ApplyResources(this.UC_Branch, "UC_Branch");
            this.UC_Branch.BackColor = System.Drawing.Color.Transparent;
            this.UC_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.UC_Branch.Name = "UC_Branch";
            this.UC_Branch.Load += new System.EventHandler(this.UC_Branch_Load);
            // 
            // UC_Acc
            // 
            resources.ApplyResources(this.UC_Acc, "UC_Acc");
            this.UC_Acc.BackColor = System.Drawing.Color.Transparent;
            this.UC_Acc.Name = "UC_Acc";
            // 
            // barCodeReader1
            // 
            this.barCodeReader1.ChecksumValidation = Aspose.BarCode.BarCodeRecognition.ChecksumValidation.Default;
            this.barCodeReader1.CustomerInformationInterpretingType = Aspose.BarCode.CustomerInformationInterpretingType.Other;
            this.barCodeReader1.DetectEncoding = true;
            this.barCodeReader1.StripFNC = false;
            this.barCodeReader1.Timeout = 0;
            // 
            // frm_Customers_TB
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frm_Customers_TB";
            this.Load += new System.EventHandler(this.frm_TB_Load);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.groupPanel1, 0);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.ContextM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.gBox3.ResumeLayout(false);
            this.gBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        internal System.Windows.Forms.TextBox T_Eb;
        internal System.Windows.Forms.TextBox T_Cr;
        internal System.Windows.Forms.TextBox T_Bb;
        internal System.Windows.Forms.TextBox T_Db;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput FromDate;
        internal System.Windows.Forms.TextBox UserName;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput ToDate;
        private DevComponents.DotNetBar.LabelX labelX7;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RadioButton RB4;
        internal System.Windows.Forms.RadioButton RB3;
        internal System.Windows.Forms.RadioButton RB2;
        internal System.Windows.Forms.RadioButton RB1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private MyControls.UC_Acc UC_Acc;
        private MyControls.ذ UC_Branch;
        private MyControls.UC_cost UC_cost;
        private MyControls.UC_Catogry UC_Catogry;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton RS2;
        internal System.Windows.Forms.RadioButton RS1;
        private System.Windows.Forms.ContextMenuStrip ContextM;
        private System.Windows.Forms.ToolStripMenuItem Statment_;
        internal System.Windows.Forms.RadioButton RB5;
        internal System.Windows.Forms.RadioButton RB6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DoubleInput b2;
        private DevComponents.Editors.DoubleInput b1;
        private System.Windows.Forms.CheckBox chBox;
        private System.Windows.Forms.GroupBox gBox3;
        private ADGV.AdvancedDataGridView DataGridView1;
        private Aspose.BarCode.BarCodeRecognition.BarCodeReader barCodeReader1;
    }
}