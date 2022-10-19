namespace Report_Pro
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.txt_sandDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sandNo = new Report_Pro.MyControls.textWithButton();
            this.AccSer_No = new Report_Pro.MyControls.textWithButton();
            this.txtSpecialNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paied_amount = new Report_Pro.MyControls.decimalText();
            this.Account = new Report_Pro.MyControls.UC_Acc();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_Pay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.Check_Date = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Check = new System.Windows.Forms.TextBox();
            this.glkp_bank = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.txtDescr_E = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CashAcc = new Report_Pro.MyControls.UC_Acc();
            this.label6 = new System.Windows.Forms.Label();
            this.Cost = new Report_Pro.MyControls.UC_cost();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sandDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkp_bank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 356;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView2, 5);
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(253, 335);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(989, 203);
            this.dataGridView2.TabIndex = 361;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(542, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 11);
            this.dataGridView1.Size = new System.Drawing.Size(700, 281);
            this.dataGridView1.TabIndex = 360;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(78, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(518, 25);
            this.miniToolStrip.TabIndex = 359;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // txt_sandDate
            // 
            this.txt_sandDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_sandDate.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.BorderBottomWidth = 1;
            this.txt_sandDate.BackgroundStyle.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_sandDate.BackgroundStyle.BorderColor2 = System.Drawing.SystemColors.WindowFrame;
            this.txt_sandDate.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.BorderLeftWidth = 1;
            this.txt_sandDate.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.BorderRightWidth = 1;
            this.txt_sandDate.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.BorderTopWidth = 1;
            this.txt_sandDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txt_sandDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txt_sandDate.ButtonDropDown.Visible = true;
            this.txt_sandDate.Location = new System.Drawing.Point(100, 28);
            this.txt_sandDate.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            // 
            // 
            // 
            this.txt_sandDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txt_sandDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sandDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txt_sandDate.MonthCalendar.DisplayMonth = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.txt_sandDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txt_sandDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txt_sandDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txt_sandDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txt_sandDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txt_sandDate.MonthCalendar.TodayButtonVisible = true;
            this.txt_sandDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txt_sandDate.Name = "txt_sandDate";
            this.txt_sandDate.Size = new System.Drawing.Size(150, 20);
            this.txt_sandDate.TabIndex = 344;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(0, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 329;
            this.label7.Text = "Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_sandNo
            // 
            this.txt_sandNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sandNo.buttonImage = global::Report_Pro.Properties.Resources.find_32x32;
            this.txt_sandNo.buttonVisable = true;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_sandNo, 2);
            this.txt_sandNo.LabelAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_sandNo.LabelBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_sandNo.LabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_sandNo.LabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.txt_sandNo.LabelSize = new System.Drawing.Size(100, 20);
            this.txt_sandNo.LabelText = "Sanad No رقم";
            this.txt_sandNo.labelVisable = true;
            this.txt_sandNo.Location = new System.Drawing.Point(270, 28);
            this.txt_sandNo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txt_sandNo.Name = "txt_sandNo";
            this.txt_sandNo.Size = new System.Drawing.Size(249, 20);
            this.txt_sandNo.TabIndex = 330;
            this.txt_sandNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sandNo.TextBackColor = System.Drawing.SystemColors.Window;
            this.txt_sandNo.TextColor = System.Drawing.SystemColors.WindowText;
            this.txt_sandNo.TextlFont = new System.Drawing.Font("Tahoma", 8F);
            this.txt_sandNo.TextS = "";
            this.txt_sandNo.TextSize = new System.Drawing.Size(119, 20);
            // 
            // AccSer_No
            // 
            this.AccSer_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AccSer_No.buttonImage = global::Report_Pro.Properties.Resources.find_32x32;
            this.AccSer_No.buttonVisable = true;
            this.tableLayoutPanel1.SetColumnSpan(this.AccSer_No, 2);
            this.AccSer_No.LabelAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AccSer_No.LabelBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AccSer_No.LabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AccSer_No.LabelFont = new System.Drawing.Font("Tahoma", 8F);
            this.AccSer_No.LabelSize = new System.Drawing.Size(100, 20);
            this.AccSer_No.LabelText = "Jornal No";
            this.AccSer_No.labelVisable = true;
            this.AccSer_No.Location = new System.Drawing.Point(0, 54);
            this.AccSer_No.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.AccSer_No.Name = "AccSer_No";
            this.AccSer_No.Size = new System.Drawing.Size(250, 20);
            this.AccSer_No.TabIndex = 331;
            this.AccSer_No.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AccSer_No.TextBackColor = System.Drawing.SystemColors.Window;
            this.AccSer_No.TextColor = System.Drawing.SystemColors.WindowText;
            this.AccSer_No.TextlFont = new System.Drawing.Font("Tahoma", 8F);
            this.AccSer_No.TextS = "";
            this.AccSer_No.TextSize = new System.Drawing.Size(120, 20);
            // 
            // txtSpecialNo
            // 
            this.txtSpecialNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecialNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialNo.Location = new System.Drawing.Point(369, 54);
            this.txtSpecialNo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtSpecialNo.Name = "txtSpecialNo";
            this.txtSpecialNo.Size = new System.Drawing.Size(150, 20);
            this.txtSpecialNo.TabIndex = 346;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(270, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 333;
            this.label8.Text = "Special No";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(0, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 334;
            this.label9.Text = "Amount";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paied_amount
            // 
            this.paied_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paied_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paied_amount.DicemalDigits = 0;
            this.paied_amount.Location = new System.Drawing.Point(100, 80);
            this.paied_amount.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.paied_amount.Name = "paied_amount";
            this.paied_amount.ProgramDigits = false;
            this.paied_amount.Size = new System.Drawing.Size(150, 20);
            this.paied_amount.TabIndex = 345;
            this.paied_amount.Text = "0";
            this.paied_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paied_amount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.paied_amount.TextChanged += new System.EventHandler(this.paied_amount_TextChanged);
            // 
            // Account
            // 
            this.Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Account.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.Account, 4);
            this.Account.Location = new System.Drawing.Point(100, 106);
            this.Account.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(419, 20);
            this.Account.TabIndex = 347;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(0, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 332;
            this.label11.Text = "Account";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Pay
            // 
            this.cmb_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Pay.FormattingEnabled = true;
            this.cmb_Pay.Location = new System.Drawing.Point(100, 158);
            this.cmb_Pay.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.cmb_Pay.Name = "cmb_Pay";
            this.cmb_Pay.Size = new System.Drawing.Size(150, 21);
            this.cmb_Pay.TabIndex = 348;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(0, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 335;
            this.label1.Text = "Payment Method";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCust
            // 
            this.txtCust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.txtCust, 4);
            this.txtCust.Location = new System.Drawing.Point(100, 132);
            this.txtCust.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(419, 20);
            this.txtCust.TabIndex = 351;
            // 
            // Check_Date
            // 
            this.Check_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Check_Date.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Check_Date.BackgroundStyle.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.Check_Date.BackgroundStyle.BorderColor2 = System.Drawing.SystemColors.WindowFrame;
            this.Check_Date.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Check_Date.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Check_Date.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Check_Date.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Check_Date.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.Check_Date.ButtonDropDown.Visible = true;
            this.Check_Date.Location = new System.Drawing.Point(100, 185);
            this.Check_Date.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            // 
            // 
            // 
            this.Check_Date.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.Check_Date.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Check_Date.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.Check_Date.MonthCalendar.DisplayMonth = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.Check_Date.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.Check_Date.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.Check_Date.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Check_Date.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.Check_Date.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Check_Date.MonthCalendar.TodayButtonVisible = true;
            this.Check_Date.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.Check_Date.Name = "Check_Date";
            this.Check_Date.Size = new System.Drawing.Size(150, 20);
            this.Check_Date.TabIndex = 350;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(0, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 336;
            this.label12.Text = "Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(0, 185);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 337;
            this.label13.Text = "Chuqe Date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Check
            // 
            this.txt_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Check.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Check.Location = new System.Drawing.Point(369, 158);
            this.txt_Check.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txt_Check.Name = "txt_Check";
            this.txt_Check.Size = new System.Drawing.Size(150, 20);
            this.txt_Check.TabIndex = 349;
            // 
            // glkp_bank
            // 
            this.glkp_bank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.glkp_bank.EditValue = " ";
            this.glkp_bank.Location = new System.Drawing.Point(369, 185);
            this.glkp_bank.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.glkp_bank.Name = "glkp_bank";
            this.glkp_bank.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.glkp_bank.Properties.NullText = "";
            this.glkp_bank.Properties.PopupView = this.gridLookUpEdit1View;
            this.glkp_bank.Size = new System.Drawing.Size(150, 20);
            this.glkp_bank.TabIndex = 352;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(270, 158);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 20);
            this.label14.TabIndex = 338;
            this.label14.Text = "Chuqe No.";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(270, 185);
            this.label15.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 20);
            this.label15.TabIndex = 339;
            this.label15.Text = "Bank";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescr
            // 
            this.txtDescr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescr.Location = new System.Drawing.Point(100, 211);
            this.txtDescr.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtDescr.Multiline = true;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescr.Size = new System.Drawing.Size(150, 20);
            this.txtDescr.TabIndex = 353;
            this.txtDescr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescr_KeyUp);
            // 
            // txtDescr_E
            // 
            this.txtDescr_E.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescr_E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescr_E.Location = new System.Drawing.Point(100, 237);
            this.txtDescr_E.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtDescr_E.Multiline = true;
            this.txtDescr_E.Name = "txtDescr_E";
            this.txtDescr_E.Size = new System.Drawing.Size(150, 20);
            this.txtDescr_E.TabIndex = 354;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(0, 211);
            this.label16.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.TabIndex = 340;
            this.label16.Text = "Arabic Description";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(0, 237);
            this.label17.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 20);
            this.label17.TabIndex = 341;
            this.label17.Text = "Englis Description";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashAcc
            // 
            this.CashAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CashAcc.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.CashAcc, 4);
            this.CashAcc.Enabled = false;
            this.CashAcc.Location = new System.Drawing.Point(100, 263);
            this.CashAcc.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.CashAcc.Name = "CashAcc";
            this.CashAcc.Size = new System.Drawing.Size(419, 20);
            this.CashAcc.TabIndex = 355;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(0, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label6.MaximumSize = new System.Drawing.Size(100, 20);
            this.label6.MinimumSize = new System.Drawing.Size(100, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 342;
            this.label6.Text = "Cash / Bank";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cost
            // 
            this.Cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.Cost, 5);
            this.Cost.Location = new System.Drawing.Point(0, 289);
            this.Cost.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(519, 20);
            this.Cost.TabIndex = 343;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_sandDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_sandNo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.AccSer_No, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSpecialNo, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.paied_amount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Account, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCust, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Pay, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Check_Date, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label14, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_Check, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.glkp_bank, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.label15, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtDescr, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtDescr_E, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.CashAcc, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.Cost, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 2, 13);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1245, 566);
            this.tableLayoutPanel1.TabIndex = 357;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 2);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(250, 25);
            this.toolStrip1.TabIndex = 359;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Resize += new System.EventHandler(this.Form3_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sandDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkp_bank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MyControls.UC_cost Cost;
        public System.Windows.Forms.Label label6;
        private MyControls.UC_Acc CashAcc;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDescr_E;
        private System.Windows.Forms.TextBox txtDescr;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.GridLookUpEdit glkp_bank;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.TextBox txt_Check;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput Check_Date;
        private System.Windows.Forms.TextBox txtCust;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Pay;
        public System.Windows.Forms.Label label11;
        private MyControls.UC_Acc Account;
        private MyControls.decimalText paied_amount;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label7;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txt_sandDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyControls.textWithButton txt_sandNo;
        private MyControls.textWithButton AccSer_No;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSpecialNo;
        private System.Windows.Forms.ToolStrip miniToolStrip;
    }
}