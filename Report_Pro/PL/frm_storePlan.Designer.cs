namespace Report_Pro.PL
{
    partial class frm_storePlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_storePlan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddRow = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fromDate_Sales = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.toDate_Sales = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.fromDate_P = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.toDate_P = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label13 = new System.Windows.Forms.Label();
            this._ser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._thickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._storeStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._storeStock_W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._branchesStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._branchesStock_W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._totalStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._totalStock_W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._salesAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSalesDays = new Report_Pro.MyControls.decimalText();
            this.txtSalesAverag = new Report_Pro.MyControls.decimalText();
            this.txtTotalStock_W = new Report_Pro.MyControls.decimalText();
            this.txtTotalStock = new Report_Pro.MyControls.decimalText();
            this.txtThickness = new Report_Pro.MyControls.decimalText();
            this.txtBranchsStock_W = new Report_Pro.MyControls.decimalText();
            this.txtStoreStock_W = new Report_Pro.MyControls.decimalText();
            this.txtBranchsStock = new Report_Pro.MyControls.decimalText();
            this.txtStoreStock = new Report_Pro.MyControls.decimalText();
            this.txtWeight = new Report_Pro.MyControls.decimalText();
            this.txtItem = new Report_Pro.MyControls.UC_Items();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRow
            // 
            this.btnAddRow.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddRow.Appearance.Options.UseBackColor = true;
            this.btnAddRow.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddRow.ImageOptions.SvgImage")));
            this.btnAddRow.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnAddRow.Location = new System.Drawing.Point(11, 119);
            this.btnAddRow.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(35, 50);
            this.btnAddRow.TabIndex = 67;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 60;
            this.label1.Text = "Item Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtUnit.FormattingEnabled = true;
            this.txtUnit.Location = new System.Drawing.Point(618, 148);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(0);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(70, 22);
            this.txtUnit.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 28);
            this.label2.TabIndex = 61;
            this.label2.Text = "Item";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 28);
            this.label3.TabIndex = 62;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(618, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 63;
            this.label4.Text = "Unit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(828, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 64;
            this.label5.Text = "Store Stock";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtDescription.Location = new System.Drawing.Point(368, 148);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 22);
            this.txtDescription.TabIndex = 65;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightCyan;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(998, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 28);
            this.label6.TabIndex = 70;
            this.label6.Text = "Branches Stock";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightCyan;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(758, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 28);
            this.label7.TabIndex = 72;
            this.label7.Text = "Weight";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightCyan;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(913, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 28);
            this.label8.TabIndex = 74;
            this.label8.Text = "Store Stock MT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightCyan;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1083, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 28);
            this.label9.TabIndex = 76;
            this.label9.Text = "Branches Stock MT";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightCyan;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(688, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 28);
            this.label10.TabIndex = 78;
            this.label10.Text = "Thickness";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Beige;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._ser,
            this._itemcode,
            this._item,
            this._description,
            this._unit,
            this._thickness,
            this._weight,
            this._storeStock,
            this._storeStock_W,
            this._branchesStock,
            this._branchesStock_W,
            this._totalStock,
            this._totalStock_W,
            this._salesAverage,
            this.unitCode});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.Location = new System.Drawing.Point(11, 187);
            this.dgv1.Margin = new System.Windows.Forms.Padding(0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1412, 349);
            this.dgv1.TabIndex = 80;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightCyan;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1253, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 28);
            this.label11.TabIndex = 83;
            this.label11.Text = "Total Stock MT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightCyan;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1168, 120);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 28);
            this.label12.TabIndex = 81;
            this.label12.Text = "Total Stock";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fromDate_Sales
            // 
            this.fromDate_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.fromDate_Sales.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate_Sales.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.fromDate_Sales.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate_Sales.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate_Sales.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate_Sales.BackgroundStyle.Class = "DateTimeInputBackground";
            this.fromDate_Sales.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.fromDate_Sales.ButtonDropDown.Visible = true;
            this.fromDate_Sales.Location = new System.Drawing.Point(22, 38);
            // 
            // 
            // 
            this.fromDate_Sales.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fromDate_Sales.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.fromDate_Sales.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.fromDate_Sales.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.fromDate_Sales.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate_Sales.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.fromDate_Sales.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate_Sales.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.fromDate_Sales.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.fromDate_Sales.MonthCalendar.DisplayMonth = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            this.fromDate_Sales.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.fromDate_Sales.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fromDate_Sales.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.fromDate_Sales.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate_Sales.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.fromDate_Sales.MonthCalendar.TodayButtonVisible = true;
            this.fromDate_Sales.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.fromDate_Sales.Name = "fromDate_Sales";
            this.fromDate_Sales.Size = new System.Drawing.Size(112, 20);
            this.fromDate_Sales.TabIndex = 87;
            this.fromDate_Sales.ValueChanged += new System.EventHandler(this.fromDate_Sales_ValueChanged);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(144, 41);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(40, 15);
            this.labelX1.TabIndex = 88;
            this.labelX1.Text = "من تاريخ";
            // 
            // labelX10
            // 
            this.labelX10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            this.labelX10.Location = new System.Drawing.Point(136, 65);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(40, 15);
            this.labelX10.TabIndex = 86;
            this.labelX10.Text = "الي تاريخ";
            // 
            // toDate_Sales
            // 
            this.toDate_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.toDate_Sales.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate_Sales.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.toDate_Sales.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate_Sales.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate_Sales.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate_Sales.BackgroundStyle.Class = "DateTimeInputBackground";
            this.toDate_Sales.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.toDate_Sales.ButtonDropDown.Visible = true;
            this.toDate_Sales.Location = new System.Drawing.Point(22, 62);
            // 
            // 
            // 
            this.toDate_Sales.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.toDate_Sales.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.toDate_Sales.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.toDate_Sales.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.toDate_Sales.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.toDate_Sales.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.toDate_Sales.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate_Sales.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.toDate_Sales.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.toDate_Sales.MonthCalendar.DisplayMonth = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            this.toDate_Sales.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.toDate_Sales.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.toDate_Sales.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.toDate_Sales.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.toDate_Sales.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.toDate_Sales.MonthCalendar.TodayButtonVisible = true;
            this.toDate_Sales.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.toDate_Sales.Name = "toDate_Sales";
            this.toDate_Sales.Size = new System.Drawing.Size(112, 20);
            this.toDate_Sales.TabIndex = 85;
            this.toDate_Sales.ValueChanged += new System.EventHandler(this.toDate_Sales_ValueChanged);
            this.toDate_Sales.Click += new System.EventHandler(this.toDate_Sales_Click);
            // 
            // fromDate_P
            // 
            this.fromDate_P.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.fromDate_P.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate_P.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.fromDate_P.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate_P.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate_P.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate_P.BackgroundStyle.Class = "DateTimeInputBackground";
            this.fromDate_P.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.fromDate_P.ButtonDropDown.Visible = true;
            this.fromDate_P.Location = new System.Drawing.Point(15, 33);
            // 
            // 
            // 
            this.fromDate_P.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fromDate_P.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.fromDate_P.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.fromDate_P.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.fromDate_P.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate_P.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.fromDate_P.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate_P.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.fromDate_P.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.fromDate_P.MonthCalendar.DisplayMonth = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            this.fromDate_P.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.fromDate_P.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fromDate_P.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.fromDate_P.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate_P.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.fromDate_P.MonthCalendar.TodayButtonVisible = true;
            this.fromDate_P.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.fromDate_P.Name = "fromDate_P";
            this.fromDate_P.Size = new System.Drawing.Size(112, 20);
            this.fromDate_P.TabIndex = 91;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(137, 36);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(40, 15);
            this.labelX2.TabIndex = 92;
            this.labelX2.Text = "من تاريخ";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(129, 60);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(40, 15);
            this.labelX3.TabIndex = 90;
            this.labelX3.Text = "الي تاريخ";
            // 
            // toDate_P
            // 
            this.toDate_P.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.toDate_P.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate_P.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.toDate_P.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate_P.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate_P.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate_P.BackgroundStyle.Class = "DateTimeInputBackground";
            this.toDate_P.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.toDate_P.ButtonDropDown.Visible = true;
            this.toDate_P.Location = new System.Drawing.Point(15, 57);
            // 
            // 
            // 
            this.toDate_P.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.toDate_P.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.toDate_P.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.toDate_P.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.toDate_P.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.toDate_P.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.toDate_P.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate_P.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.toDate_P.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.toDate_P.MonthCalendar.DisplayMonth = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            this.toDate_P.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.toDate_P.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.toDate_P.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.toDate_P.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.toDate_P.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.toDate_P.MonthCalendar.TodayButtonVisible = true;
            this.toDate_P.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.toDate_P.Name = "toDate_P";
            this.toDate_P.Size = new System.Drawing.Size(112, 20);
            this.toDate_P.TabIndex = 89;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.fromDate_Sales);
            this.groupControl1.Controls.Add(this.toDate_Sales);
            this.groupControl1.Controls.Add(this.labelX10);
            this.groupControl1.Controls.Add(this.labelX1);
            this.groupControl1.Location = new System.Drawing.Point(582, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 100);
            this.groupControl1.TabIndex = 93;
            this.groupControl1.Text = "Sales";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.Controls.Add(this.fromDate_P);
            this.groupControl2.Controls.Add(this.toDate_P);
            this.groupControl2.Controls.Add(this.labelX3);
            this.groupControl2.Controls.Add(this.labelX2);
            this.groupControl2.Location = new System.Drawing.Point(238, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 100);
            this.groupControl2.TabIndex = 94;
            this.groupControl2.Text = "Plan Period";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightCyan;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1338, 120);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 28);
            this.label13.TabIndex = 95;
            this.label13.Text = "Sales Avearge";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _ser
            // 
            this._ser.HeaderText = "Ser";
            this._ser.Name = "_ser";
            this._ser.ReadOnly = true;
            this._ser.Width = 35;
            // 
            // _itemcode
            // 
            this._itemcode.HeaderText = "Item Code";
            this._itemcode.Name = "_itemcode";
            this._itemcode.ReadOnly = true;
            this._itemcode.Width = 70;
            // 
            // _item
            // 
            this._item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._item.HeaderText = "Item";
            this._item.Name = "_item";
            this._item.ReadOnly = true;
            // 
            // _description
            // 
            this._description.HeaderText = "Description";
            this._description.Name = "_description";
            this._description.ReadOnly = true;
            this._description.Width = 250;
            // 
            // _unit
            // 
            this._unit.HeaderText = "Unit";
            this._unit.Name = "_unit";
            this._unit.ReadOnly = true;
            this._unit.Width = 70;
            // 
            // _thickness
            // 
            this._thickness.HeaderText = "Thickness";
            this._thickness.Name = "_thickness";
            this._thickness.ReadOnly = true;
            // 
            // _weight
            // 
            this._weight.HeaderText = "Weight";
            this._weight.Name = "_weight";
            this._weight.ReadOnly = true;
            this._weight.Width = 70;
            // 
            // _storeStock
            // 
            this._storeStock.HeaderText = "Store Stock";
            this._storeStock.Name = "_storeStock";
            this._storeStock.ReadOnly = true;
            this._storeStock.Width = 85;
            // 
            // _storeStock_W
            // 
            this._storeStock_W.HeaderText = "Store Stock MT";
            this._storeStock_W.Name = "_storeStock_W";
            this._storeStock_W.ReadOnly = true;
            this._storeStock_W.Width = 95;
            // 
            // _branchesStock
            // 
            this._branchesStock.HeaderText = "Branches Stock";
            this._branchesStock.Name = "_branchesStock";
            this._branchesStock.ReadOnly = true;
            this._branchesStock.Width = 85;
            // 
            // _branchesStock_W
            // 
            this._branchesStock_W.HeaderText = "Branches Stock MT";
            this._branchesStock_W.Name = "_branchesStock_W";
            this._branchesStock_W.ReadOnly = true;
            this._branchesStock_W.Width = 60;
            // 
            // _totalStock
            // 
            this._totalStock.HeaderText = "Total Stock";
            this._totalStock.Name = "_totalStock";
            this._totalStock.ReadOnly = true;
            this._totalStock.Width = 65;
            // 
            // _totalStock_W
            // 
            this._totalStock_W.HeaderText = "Total Stock MT";
            this._totalStock_W.Name = "_totalStock_W";
            this._totalStock_W.ReadOnly = true;
            this._totalStock_W.Visible = false;
            this._totalStock_W.Width = 35;
            // 
            // _salesAverage
            // 
            this._salesAverage.HeaderText = "Sales Average";
            this._salesAverage.Name = "_salesAverage";
            this._salesAverage.ReadOnly = true;
            // 
            // unitCode
            // 
            this.unitCode.HeaderText = "Unit Code";
            this.unitCode.Name = "unitCode";
            this.unitCode.ReadOnly = true;
            this.unitCode.Visible = false;
            // 
            // txtSalesDays
            // 
            this.txtSalesDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesDays.DicemalDigits = 0;
            this.txtSalesDays.Enabled = false;
            this.txtSalesDays.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSalesDays.Location = new System.Drawing.Point(788, 39);
            this.txtSalesDays.Name = "txtSalesDays";
            this.txtSalesDays.ProgramDigits = false;
            this.txtSalesDays.Size = new System.Drawing.Size(85, 22);
            this.txtSalesDays.TabIndex = 97;
            this.txtSalesDays.Text = "0";
            this.txtSalesDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalesDays.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtSalesAverag
            // 
            this.txtSalesAverag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesAverag.DicemalDigits = 3;
            this.txtSalesAverag.Enabled = false;
            this.txtSalesAverag.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSalesAverag.Location = new System.Drawing.Point(1338, 148);
            this.txtSalesAverag.Name = "txtSalesAverag";
            this.txtSalesAverag.ProgramDigits = false;
            this.txtSalesAverag.Size = new System.Drawing.Size(85, 22);
            this.txtSalesAverag.TabIndex = 96;
            this.txtSalesAverag.Text = "0.000";
            this.txtSalesAverag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalesAverag.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // txtTotalStock_W
            // 
            this.txtTotalStock_W.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalStock_W.DicemalDigits = 3;
            this.txtTotalStock_W.Enabled = false;
            this.txtTotalStock_W.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTotalStock_W.Location = new System.Drawing.Point(1253, 148);
            this.txtTotalStock_W.Name = "txtTotalStock_W";
            this.txtTotalStock_W.ProgramDigits = false;
            this.txtTotalStock_W.Size = new System.Drawing.Size(85, 22);
            this.txtTotalStock_W.TabIndex = 84;
            this.txtTotalStock_W.Text = "0.000";
            this.txtTotalStock_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalStock_W.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // txtTotalStock
            // 
            this.txtTotalStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalStock.DicemalDigits = 3;
            this.txtTotalStock.Enabled = false;
            this.txtTotalStock.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTotalStock.Location = new System.Drawing.Point(1168, 148);
            this.txtTotalStock.Name = "txtTotalStock";
            this.txtTotalStock.ProgramDigits = false;
            this.txtTotalStock.Size = new System.Drawing.Size(85, 22);
            this.txtTotalStock.TabIndex = 82;
            this.txtTotalStock.Text = "0.000";
            this.txtTotalStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalStock.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // txtThickness
            // 
            this.txtThickness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThickness.DicemalDigits = 3;
            this.txtThickness.Enabled = false;
            this.txtThickness.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtThickness.Location = new System.Drawing.Point(688, 148);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.ProgramDigits = false;
            this.txtThickness.Size = new System.Drawing.Size(70, 22);
            this.txtThickness.TabIndex = 79;
            this.txtThickness.Text = "0.000";
            this.txtThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThickness.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // txtBranchsStock_W
            // 
            this.txtBranchsStock_W.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchsStock_W.DicemalDigits = 3;
            this.txtBranchsStock_W.Enabled = false;
            this.txtBranchsStock_W.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBranchsStock_W.Location = new System.Drawing.Point(1083, 148);
            this.txtBranchsStock_W.Name = "txtBranchsStock_W";
            this.txtBranchsStock_W.ProgramDigits = false;
            this.txtBranchsStock_W.Size = new System.Drawing.Size(85, 22);
            this.txtBranchsStock_W.TabIndex = 77;
            this.txtBranchsStock_W.Text = "0.000";
            this.txtBranchsStock_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBranchsStock_W.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // txtStoreStock_W
            // 
            this.txtStoreStock_W.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreStock_W.DicemalDigits = 3;
            this.txtStoreStock_W.Enabled = false;
            this.txtStoreStock_W.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtStoreStock_W.Location = new System.Drawing.Point(913, 148);
            this.txtStoreStock_W.Name = "txtStoreStock_W";
            this.txtStoreStock_W.ProgramDigits = false;
            this.txtStoreStock_W.Size = new System.Drawing.Size(85, 22);
            this.txtStoreStock_W.TabIndex = 75;
            this.txtStoreStock_W.Text = "0.000";
            this.txtStoreStock_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStoreStock_W.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // txtBranchsStock
            // 
            this.txtBranchsStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchsStock.DicemalDigits = 3;
            this.txtBranchsStock.Enabled = false;
            this.txtBranchsStock.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBranchsStock.Location = new System.Drawing.Point(998, 148);
            this.txtBranchsStock.Name = "txtBranchsStock";
            this.txtBranchsStock.ProgramDigits = false;
            this.txtBranchsStock.Size = new System.Drawing.Size(85, 22);
            this.txtBranchsStock.TabIndex = 73;
            this.txtBranchsStock.Text = "0.000";
            this.txtBranchsStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBranchsStock.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // txtStoreStock
            // 
            this.txtStoreStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreStock.DicemalDigits = 3;
            this.txtStoreStock.Enabled = false;
            this.txtStoreStock.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtStoreStock.Location = new System.Drawing.Point(828, 148);
            this.txtStoreStock.Name = "txtStoreStock";
            this.txtStoreStock.ProgramDigits = false;
            this.txtStoreStock.Size = new System.Drawing.Size(85, 22);
            this.txtStoreStock.TabIndex = 71;
            this.txtStoreStock.Text = "0.000";
            this.txtStoreStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStoreStock.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.DicemalDigits = 3;
            this.txtWeight.Enabled = false;
            this.txtWeight.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtWeight.Location = new System.Drawing.Point(758, 148);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ProgramDigits = false;
            this.txtWeight.Size = new System.Drawing.Size(70, 22);
            this.txtWeight.TabIndex = 69;
            this.txtWeight.Text = "0.000";
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWeight.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // txtItem
            // 
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem.Location = new System.Drawing.Point(47, 148);
            this.txtItem.Margin = new System.Windows.Forms.Padding(0);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(321, 22);
            this.txtItem.TabIndex = 68;
            this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
            // 
            // frm_storePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 645);
            this.Controls.Add(this.txtSalesDays);
            this.Controls.Add(this.txtSalesAverag);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtTotalStock_W);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalStock);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.txtThickness);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBranchsStock_W);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStoreStock_W);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBranchsStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStoreStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescription);
            this.Name = "frm_storePlan";
            this.Text = "frm_storePlan";
            this.Load += new System.EventHandler(this.frm_storePlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.decimalText txtWeight;
        private DevExpress.XtraEditors.SimpleButton btnAddRow;
        private MyControls.UC_Items txtItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private MyControls.decimalText txtStoreStock;
        private System.Windows.Forms.Label label6;
        private MyControls.decimalText txtBranchsStock;
        private System.Windows.Forms.Label label7;
        private MyControls.decimalText txtStoreStock_W;
        private System.Windows.Forms.Label label8;
        private MyControls.decimalText txtBranchsStock_W;
        private System.Windows.Forms.Label label9;
        private MyControls.decimalText txtThickness;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView dgv1;
        private MyControls.decimalText txtTotalStock_W;
        private System.Windows.Forms.Label label11;
        private MyControls.decimalText txtTotalStock;
        private System.Windows.Forms.Label label12;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput fromDate_Sales;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput toDate_Sales;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput fromDate_P;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput toDate_P;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private MyControls.decimalText txtSalesAverag;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ser;
        private System.Windows.Forms.DataGridViewTextBoxColumn _itemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn _item;
        private System.Windows.Forms.DataGridViewTextBoxColumn _description;
        private System.Windows.Forms.DataGridViewTextBoxColumn _unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn _thickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn _weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn _storeStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn _storeStock_W;
        private System.Windows.Forms.DataGridViewTextBoxColumn _branchesStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn _branchesStock_W;
        private System.Windows.Forms.DataGridViewTextBoxColumn _totalStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn _totalStock_W;
        private System.Windows.Forms.DataGridViewTextBoxColumn _salesAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCode;
        private MyControls.decimalText txtSalesDays;
    }
}