namespace Report_Pro.Forms
{
    partial class frm_close_purch_to_lc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_close_purch_to_lc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new ADGV.AdvancedDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btn_GetData = new DevComponents.DotNetBar.ButtonX();
            this.dgv2 = new ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_totalAmount_1 = new DevComponents.Editors.DoubleInput();
            this.txt_totalAmount = new DevComponents.Editors.DoubleInput();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_docId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSanad_type = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtSer_code = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSerNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Main_serNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtAcc_year = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txt_entryDate = new System.Windows.Forms.DateTimePicker();
            this.txt_vend_inv_no = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_vend_inv_date = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.Uc_AccBranch = new Report_Pro.MyControls.UC_AccBranch();
            this.Uc_Lc = new Report_Pro.MyControls.UC_Acc();
            this.Uc_Vendor = new Report_Pro.MyControls.UC_Acc();
            this.txtSearchByDelevry = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Added = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_totalAmount_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_totalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vend_inv_date)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoGenerateContextFilters = true;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dgv1.DateWithTime = false;
            resources.ApplyResources(this.dgv1, "dgv1");
            this.dgv1.Name = "dgv1";
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.TimeFilter = false;
            this.dgv1.SortStringChanged += new System.EventHandler(this.dgv1_SortStringChanged);
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_Click);
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // labelX1
            // 
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.Name = "labelX1";
            // 
            // labelX2
            // 
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.Name = "labelX2";
            // 
            // btn_GetData
            // 
            this.btn_GetData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_GetData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btn_GetData, "btn_GetData");
            this.btn_GetData.Name = "btn_GetData";
            this.btn_GetData.Click += new System.EventHandler(this.btn_GetData_Click);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AutoGenerateContextFilters = true;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv2.DateWithTime = false;
            resources.ApplyResources(this.dgv2, "dgv2");
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.TimeFilter = false;
            this.dgv2.DoubleClick += new System.EventHandler(this.dgv2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // txt_totalAmount_1
            // 
            // 
            // 
            // 
            this.txt_totalAmount_1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txt_totalAmount_1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txt_totalAmount_1.Increment = 1D;
            resources.ApplyResources(this.txt_totalAmount_1, "txt_totalAmount_1");
            this.txt_totalAmount_1.Name = "txt_totalAmount_1";
            // 
            // txt_totalAmount
            // 
            // 
            // 
            // 
            this.txt_totalAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txt_totalAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txt_totalAmount.Increment = 1D;
            resources.ApplyResources(this.txt_totalAmount, "txt_totalAmount");
            this.txt_totalAmount.Name = "txt_totalAmount";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.buttonX1, "buttonX1");
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX4
            // 
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.Name = "labelX4";
            // 
            // txt_docId
            // 
            // 
            // 
            // 
            this.txt_docId.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txt_docId, "txt_docId");
            this.txt_docId.Name = "txt_docId";
            this.txt_docId.ReadOnly = true;
            // 
            // txtSanad_type
            // 
            // 
            // 
            // 
            this.txtSanad_type.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtSanad_type, "txtSanad_type");
            this.txtSanad_type.Name = "txtSanad_type";
            this.txtSanad_type.ReadOnly = true;
            // 
            // labelX5
            // 
            resources.ApplyResources(this.labelX5, "labelX5");
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Name = "labelX5";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX8
            // 
            resources.ApplyResources(this.labelX8, "labelX8");
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Name = "labelX8";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtSer_code
            // 
            // 
            // 
            // 
            this.txtSer_code.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtSer_code, "txtSer_code");
            this.txtSer_code.Name = "txtSer_code";
            this.txtSer_code.ReadOnly = true;
            // 
            // txtSerNo
            // 
            // 
            // 
            // 
            this.txtSerNo.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtSerNo, "txtSerNo");
            this.txtSerNo.Name = "txtSerNo";
            this.txtSerNo.ReadOnly = true;
            // 
            // Main_serNo
            // 
            // 
            // 
            // 
            this.Main_serNo.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.Main_serNo, "Main_serNo");
            this.Main_serNo.Name = "Main_serNo";
            this.Main_serNo.ReadOnly = true;
            // 
            // labelX6
            // 
            resources.ApplyResources(this.labelX6, "labelX6");
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Name = "labelX6";
            // 
            // labelX7
            // 
            resources.ApplyResources(this.labelX7, "labelX7");
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Name = "labelX7";
            // 
            // txtAcc_year
            // 
            resources.ApplyResources(this.txtAcc_year, "txtAcc_year");
            this.txtAcc_year.BackColor = System.Drawing.Color.Transparent;
            this.txtAcc_year.Name = "txtAcc_year";
            // 
            // labelX9
            // 
            resources.ApplyResources(this.labelX9, "labelX9");
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Name = "labelX9";
            // 
            // txt_entryDate
            // 
            resources.ApplyResources(this.txt_entryDate, "txt_entryDate");
            this.txt_entryDate.Name = "txt_entryDate";
            // 
            // txt_vend_inv_no
            // 
            // 
            // 
            // 
            this.txt_vend_inv_no.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txt_vend_inv_no, "txt_vend_inv_no");
            this.txt_vend_inv_no.Name = "txt_vend_inv_no";
            // 
            // labelX3
            // 
            resources.ApplyResources(this.labelX3, "labelX3");
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Name = "labelX3";
            // 
            // txt_vend_inv_date
            // 
            // 
            // 
            // 
            this.txt_vend_inv_date.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txt_vend_inv_date.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txt_vend_inv_date.ButtonDropDown.Visible = true;
            resources.ApplyResources(this.txt_vend_inv_date, "txt_vend_inv_date");
            // 
            // 
            // 
            this.txt_vend_inv_date.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("txt_vend_inv_date.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.txt_vend_inv_date.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txt_vend_inv_date.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txt_vend_inv_date.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txt_vend_inv_date.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txt_vend_inv_date.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txt_vend_inv_date.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_vend_inv_date.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txt_vend_inv_date.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txt_vend_inv_date.MonthCalendar.DisplayMonth = new System.DateTime(2022, 2, 1, 0, 0, 0, 0);
            this.txt_vend_inv_date.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("txt_vend_inv_date.MonthCalendar.MarkedDates")));
            this.txt_vend_inv_date.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("txt_vend_inv_date.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.txt_vend_inv_date.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txt_vend_inv_date.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txt_vend_inv_date.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txt_vend_inv_date.MonthCalendar.TodayButtonVisible = true;
            this.txt_vend_inv_date.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("txt_vend_inv_date.MonthCalendar.WeeklyMarkedDays")));
            this.txt_vend_inv_date.Name = "txt_vend_inv_date";
            // 
            // labelX10
            // 
            resources.ApplyResources(this.labelX10, "labelX10");
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            this.labelX10.Name = "labelX10";
            // 
            // Uc_AccBranch
            // 
            this.Uc_AccBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Uc_AccBranch, "Uc_AccBranch");
            this.Uc_AccBranch.Name = "Uc_AccBranch";
            this.Uc_AccBranch.Load += new System.EventHandler(this.Uc_AccBranch_Load);
            // 
            // Uc_Lc
            // 
            this.Uc_Lc.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Lc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Uc_Lc, "Uc_Lc");
            this.Uc_Lc.Name = "Uc_Lc";
            // 
            // Uc_Vendor
            // 
            this.Uc_Vendor.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Uc_Vendor, "Uc_Vendor");
            this.Uc_Vendor.Name = "Uc_Vendor";
            // 
            // txtSearchByDelevry
            // 
            // 
            // 
            // 
            this.txtSearchByDelevry.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtSearchByDelevry, "txtSearchByDelevry");
            this.txtSearchByDelevry.Name = "txtSearchByDelevry";
            this.txtSearchByDelevry.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // labelX11
            // 
            resources.ApplyResources(this.labelX11, "labelX11");
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            this.labelX11.Name = "labelX11";
            // 
            // btnReturn
            // 
            this.btnReturn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnReturn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReturn.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnReturn, "btnReturn");
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btn_Added
            // 
            this.btn_Added.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Added.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Added.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btn_Added, "btn_Added");
            this.btn_Added.Name = "btn_Added";
            this.btn_Added.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Added.Click += new System.EventHandler(this.btn_Added_Click);
            // 
            // frm_close_purch_to_lc
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Added);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtSearchByDelevry);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.txt_vend_inv_date);
            this.Controls.Add(this.txt_vend_inv_no);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txt_entryDate);
            this.Controls.Add(this.txt_docId);
            this.Controls.Add(this.txtSanad_type);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtSer_code);
            this.Controls.Add(this.txtSerNo);
            this.Controls.Add(this.Main_serNo);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtAcc_year);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.Uc_AccBranch);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txt_totalAmount);
            this.Controls.Add(this.txt_totalAmount_1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.btn_GetData);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.Uc_Lc);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.Uc_Vendor);
            this.Name = "frm_close_purch_to_lc";
            this.Load += new System.EventHandler(this.frm_close_purch_to_lc_Load);
            this.Controls.SetChildIndex(this.Uc_Vendor, 0);
            this.Controls.SetChildIndex(this.dgv1, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.Uc_Lc, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.btn_GetData, 0);
            this.Controls.SetChildIndex(this.dgv2, 0);
            this.Controls.SetChildIndex(this.txt_totalAmount_1, 0);
            this.Controls.SetChildIndex(this.txt_totalAmount, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.Uc_AccBranch, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.txtAcc_year, 0);
            this.Controls.SetChildIndex(this.labelX7, 0);
            this.Controls.SetChildIndex(this.labelX6, 0);
            this.Controls.SetChildIndex(this.Main_serNo, 0);
            this.Controls.SetChildIndex(this.txtSerNo, 0);
            this.Controls.SetChildIndex(this.txtSer_code, 0);
            this.Controls.SetChildIndex(this.labelX8, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.txtSanad_type, 0);
            this.Controls.SetChildIndex(this.txt_docId, 0);
            this.Controls.SetChildIndex(this.txt_entryDate, 0);
            this.Controls.SetChildIndex(this.labelX9, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.txt_vend_inv_no, 0);
            this.Controls.SetChildIndex(this.txt_vend_inv_date, 0);
            this.Controls.SetChildIndex(this.labelX10, 0);
            this.Controls.SetChildIndex(this.labelX11, 0);
            this.Controls.SetChildIndex(this.txtSearchByDelevry, 0);
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.btn_Added, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_totalAmount_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_totalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vend_inv_date)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private MyControls.UC_Acc Uc_Vendor;
        private ADGV.AdvancedDataGridView dgv1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private MyControls.UC_Acc Uc_Lc;
        private DevComponents.DotNetBar.ButtonX btn_GetData;
        private ADGV.AdvancedDataGridView dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevComponents.Editors.DoubleInput txt_totalAmount_1;
        private DevComponents.Editors.DoubleInput txt_totalAmount;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private MyControls.UC_AccBranch Uc_AccBranch;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_docId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSanad_type;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSer_code;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerNo;
        private DevComponents.DotNetBar.Controls.TextBoxX Main_serNo;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX txtAcc_year;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.DateTimePicker txt_entryDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_vend_inv_no;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txt_vend_inv_date;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchByDelevry;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private DevExpress.XtraEditors.SimpleButton btn_Added;
    }
}