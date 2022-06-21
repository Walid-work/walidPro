namespace Report_Pro.CTR
{
    partial class frm_BankPaySanad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_paySanad));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.BEdit = new DevComponents.DotNetBar.ButtonItem();
            this.BSearch = new DevComponents.DotNetBar.ButtonItem();
            this.print_sand = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtCost = new Report_Pro.MyControls.UC_cost();
            this.txtCashAcc = new Report_Pro.MyControls.UC_Acc();
            this.txtAcc = new Report_Pro.MyControls.UC_Acc();
            this.txtCust = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_source_code = new DevComponents.DotNetBar.LabelX();
            this.user_id = new DevComponents.DotNetBar.LabelX();
            this.txtStore_ID = new DevComponents.DotNetBar.LabelX();
            this.acc_year = new DevComponents.DotNetBar.LabelX();
            this.Payment_Type = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtDescr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX44 = new DevComponents.DotNetBar.LabelX();
            this.cmb_Bank = new System.Windows.Forms.ComboBox();
            this.Check_Date = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX43 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txt_Check = new System.Windows.Forms.TextBox();
            this.labelX42 = new DevComponents.DotNetBar.LabelX();
            this.txt_sandNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX41 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cmb_Pay = new System.Windows.Forms.ComboBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.paied_amount = new DevComponents.Editors.DoubleInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_sandDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.AccSer_No = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paied_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sandDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ribbonBar1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BNew,
            this.BSave,
            this.BEdit,
            this.BSearch,
            this.print_sand,
            this.BExit});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(881, 34);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 4;
            this.ribbonBar1.Text = "ئ";
            this.ribbonBar1.TitleVisible = false;
            // 
            // BNew
            // 
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BNew.Image = global::Report_Pro.Properties.Resources.new_1;
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            this.BNew.Text = "جديد";
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // BSave
            // 
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSave.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.BSave.Name = "BSave";
            this.BSave.SubItemsExpandWidth = 14;
            this.BSave.Text = "حفظ";
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BEdit
            // 
            this.BEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BEdit.Enabled = false;
            this.BEdit.Image = global::Report_Pro.Properties.Resources.update;
            this.BEdit.Name = "BEdit";
            this.BEdit.SubItemsExpandWidth = 14;
            this.BEdit.Text = "تعديل";
            // 
            // BSearch
            // 
            this.BSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSearch.Image = global::Report_Pro.Properties.Resources.search_16;
            this.BSearch.Name = "BSearch";
            this.BSearch.SubItemsExpandWidth = 14;
            this.BSearch.Text = "بحث";
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // print_sand
            // 
            this.print_sand.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.print_sand.Image = ((System.Drawing.Image)(resources.GetObject("print_sand.Image")));
            this.print_sand.ImagePaddingHorizontal = 15;
            this.print_sand.Name = "print_sand";
            this.print_sand.SubItemsExpandWidth = 14;
            this.print_sand.Text = "طباعة";
            this.print_sand.Click += new System.EventHandler(this.print_sand_Click);
            // 
            // BExit
            // 
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BExit.Image = global::Report_Pro.Properties.Resources.deleteAttach_icon;
            this.BExit.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.BExit.Name = "BExit";
            this.BExit.RibbonWordWrap = false;
            this.BExit.SubItemsExpandWidth = 14;
            this.BExit.Text = "خروج";
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dataGridViewX1);
            this.groupPanel1.Controls.Add(this.txtCost);
            this.groupPanel1.Controls.Add(this.txtCashAcc);
            this.groupPanel1.Controls.Add(this.txtAcc);
            this.groupPanel1.Controls.Add(this.txtCust);
            this.groupPanel1.Controls.Add(this.txt_source_code);
            this.groupPanel1.Controls.Add(this.user_id);
            this.groupPanel1.Controls.Add(this.txtStore_ID);
            this.groupPanel1.Controls.Add(this.acc_year);
            this.groupPanel1.Controls.Add(this.Payment_Type);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.txtDescr);
            this.groupPanel1.Controls.Add(this.labelX44);
            this.groupPanel1.Controls.Add(this.cmb_Bank);
            this.groupPanel1.Controls.Add(this.Check_Date);
            this.groupPanel1.Controls.Add(this.labelX43);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.txt_Check);
            this.groupPanel1.Controls.Add(this.labelX42);
            this.groupPanel1.Controls.Add(this.txt_sandNo);
            this.groupPanel1.Controls.Add(this.labelX41);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.cmb_Pay);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.paied_amount);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txt_sandDate);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.AccSer_No);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 34);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(881, 426);
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
            this.groupPanel1.TabIndex = 5;
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // txtCost
            // 
            this.txtCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCost.Location = new System.Drawing.Point(452, 219);
            this.txtCost.Margin = new System.Windows.Forms.Padding(0);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(320, 22);
            this.txtCost.TabIndex = 295;
            // 
            // txtCashAcc
            // 
            this.txtCashAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCashAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtCashAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCashAcc.Location = new System.Drawing.Point(452, 166);
            this.txtCashAcc.Margin = new System.Windows.Forms.Padding(0);
            this.txtCashAcc.Name = "txtCashAcc";
            this.txtCashAcc.Padding = new System.Windows.Forms.Padding(1);
            this.txtCashAcc.Size = new System.Drawing.Size(320, 22);
            this.txtCashAcc.TabIndex = 294;
            // 
            // txtAcc
            // 
            this.txtAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcc.Location = new System.Drawing.Point(452, 193);
            this.txtAcc.Margin = new System.Windows.Forms.Padding(0);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Padding = new System.Windows.Forms.Padding(1);
            this.txtAcc.Size = new System.Drawing.Size(320, 22);
            this.txtAcc.TabIndex = 293;
            // 
            // txtCust
            // 
            this.txtCust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCust.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCust.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCust.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCust.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCust.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCust.Border.Class = "TextBoxBorder";
            this.txtCust.Location = new System.Drawing.Point(25, 166);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(367, 21);
            this.txtCust.TabIndex = 282;
            // 
            // txt_source_code
            // 
            this.txt_source_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_source_code.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.txt_source_code.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_source_code.BackgroundStyle.BorderBottomWidth = 1;
            this.txt_source_code.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_source_code.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_source_code.BackgroundStyle.BorderLeftWidth = 1;
            this.txt_source_code.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_source_code.BackgroundStyle.BorderRightWidth = 1;
            this.txt_source_code.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_source_code.BackgroundStyle.BorderTopWidth = 1;
            this.txt_source_code.Location = new System.Drawing.Point(263, 32);
            this.txt_source_code.Name = "txt_source_code";
            this.txt_source_code.Size = new System.Drawing.Size(82, 15);
            this.txt_source_code.TabIndex = 281;
            // 
            // user_id
            // 
            this.user_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.user_id.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.user_id.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.user_id.BackgroundStyle.BorderBottomWidth = 1;
            this.user_id.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.user_id.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.user_id.BackgroundStyle.BorderLeftWidth = 1;
            this.user_id.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.user_id.BackgroundStyle.BorderRightWidth = 1;
            this.user_id.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.user_id.BackgroundStyle.BorderTopWidth = 1;
            this.user_id.Location = new System.Drawing.Point(263, 11);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(82, 15);
            this.user_id.TabIndex = 280;
            // 
            // txtStore_ID
            // 
            this.txtStore_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStore_ID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.txtStore_ID.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderBottomWidth = 1;
            this.txtStore_ID.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtStore_ID.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderLeftWidth = 1;
            this.txtStore_ID.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderRightWidth = 1;
            this.txtStore_ID.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderTopWidth = 1;
            this.txtStore_ID.Location = new System.Drawing.Point(263, 76);
            this.txtStore_ID.Name = "txtStore_ID";
            this.txtStore_ID.Size = new System.Drawing.Size(82, 15);
            this.txtStore_ID.TabIndex = 278;
            // 
            // acc_year
            // 
            this.acc_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acc_year.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.acc_year.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.acc_year.BackgroundStyle.BorderBottomWidth = 1;
            this.acc_year.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.acc_year.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.acc_year.BackgroundStyle.BorderLeftWidth = 1;
            this.acc_year.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.acc_year.BackgroundStyle.BorderRightWidth = 1;
            this.acc_year.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.acc_year.BackgroundStyle.BorderTopWidth = 1;
            this.acc_year.Location = new System.Drawing.Point(263, 96);
            this.acc_year.Name = "acc_year";
            this.acc_year.Size = new System.Drawing.Size(82, 15);
            this.acc_year.TabIndex = 277;
            // 
            // Payment_Type
            // 
            this.Payment_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Payment_Type.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.Payment_Type.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Payment_Type.BackgroundStyle.BorderBottomWidth = 1;
            this.Payment_Type.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Payment_Type.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Payment_Type.BackgroundStyle.BorderLeftWidth = 1;
            this.Payment_Type.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Payment_Type.BackgroundStyle.BorderRightWidth = 1;
            this.Payment_Type.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Payment_Type.BackgroundStyle.BorderTopWidth = 1;
            this.Payment_Type.Location = new System.Drawing.Point(263, 53);
            this.Payment_Type.Name = "Payment_Type";
            this.Payment_Type.Size = new System.Drawing.Size(82, 15);
            this.Payment_Type.TabIndex = 276;
            // 
            // labelX9
            // 
            this.labelX9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Location = new System.Drawing.Point(779, 171);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 16);
            this.labelX9.TabIndex = 275;
            this.labelX9.Text = "حساب الصندوق";
            // 
            // txtDescr
            // 
            this.txtDescr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDescr.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDescr.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescr.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDescr.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDescr.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDescr.Border.Class = "TextBoxBorder";
            this.txtDescr.Location = new System.Drawing.Point(25, 190);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(367, 21);
            this.txtDescr.TabIndex = 272;
            // 
            // labelX44
            // 
            this.labelX44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX44.AutoSize = true;
            this.labelX44.BackColor = System.Drawing.Color.Transparent;
            this.labelX44.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelX44.Location = new System.Drawing.Point(779, 141);
            this.labelX44.Name = "labelX44";
            this.labelX44.Size = new System.Drawing.Size(57, 16);
            this.labelX44.TabIndex = 270;
            this.labelX44.Text = "تاريخ الشيك";
            // 
            // cmb_Bank
            // 
            this.cmb_Bank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Bank.Enabled = false;
            this.cmb_Bank.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmb_Bank.FormattingEnabled = true;
            this.cmb_Bank.Location = new System.Drawing.Point(625, 87);
            this.cmb_Bank.Name = "cmb_Bank";
            this.cmb_Bank.Size = new System.Drawing.Size(147, 21);
            this.cmb_Bank.TabIndex = 271;
            // 
            // Check_Date
            // 
            this.Check_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Check_Date.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Check_Date.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Check_Date.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.Check_Date.ButtonDropDown.Visible = true;
            this.Check_Date.Enabled = false;
            this.Check_Date.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Check_Date.Location = new System.Drawing.Point(625, 139);
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
            this.Check_Date.MonthCalendar.DisplayMonth = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
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
            this.Check_Date.Size = new System.Drawing.Size(147, 21);
            this.Check_Date.TabIndex = 269;
            // 
            // labelX43
            // 
            this.labelX43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX43.AutoSize = true;
            this.labelX43.BackColor = System.Drawing.Color.Transparent;
            this.labelX43.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelX43.Location = new System.Drawing.Point(779, 89);
            this.labelX43.Name = "labelX43";
            this.labelX43.Size = new System.Drawing.Size(25, 16);
            this.labelX43.TabIndex = 40;
            this.labelX43.Text = "البنك";
            // 
            // labelX8
            // 
            this.labelX8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Location = new System.Drawing.Point(179, 41);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(49, 16);
            this.labelX8.TabIndex = 15;
            this.labelX8.Text = "رقم السند";
            // 
            // txt_Check
            // 
            this.txt_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Check.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Check.Enabled = false;
            this.txt_Check.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_Check.Location = new System.Drawing.Point(625, 114);
            this.txt_Check.Name = "txt_Check";
            this.txt_Check.Size = new System.Drawing.Size(147, 21);
            this.txt_Check.TabIndex = 37;
            this.txt_Check.TabStop = false;
            // 
            // labelX42
            // 
            this.labelX42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX42.AutoSize = true;
            this.labelX42.BackColor = System.Drawing.Color.Transparent;
            this.labelX42.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelX42.Location = new System.Drawing.Point(779, 116);
            this.labelX42.Name = "labelX42";
            this.labelX42.Size = new System.Drawing.Size(52, 16);
            this.labelX42.TabIndex = 38;
            this.labelX42.Text = "رقم الشيك";
            // 
            // txt_sandNo
            // 
            this.txt_sandNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_sandNo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandNo.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_sandNo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandNo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandNo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandNo.Border.Class = "TextBoxBorder";
            this.txt_sandNo.Location = new System.Drawing.Point(25, 38);
            this.txt_sandNo.Name = "txt_sandNo";
            this.txt_sandNo.Size = new System.Drawing.Size(147, 21);
            this.txt_sandNo.TabIndex = 14;
            // 
            // labelX41
            // 
            this.labelX41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX41.AutoSize = true;
            this.labelX41.BackColor = System.Drawing.Color.Transparent;
            this.labelX41.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelX41.Location = new System.Drawing.Point(779, 64);
            this.labelX41.Name = "labelX41";
            this.labelX41.Size = new System.Drawing.Size(64, 16);
            this.labelX41.TabIndex = 36;
            this.labelX41.Text = "طريقة السداد";
            // 
            // labelX7
            // 
            this.labelX7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(399, 194);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(27, 16);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "البيان";
            // 
            // cmb_Pay
            // 
            this.cmb_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Pay.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmb_Pay.FormattingEnabled = true;
            this.cmb_Pay.Location = new System.Drawing.Point(625, 62);
            this.cmb_Pay.Name = "cmb_Pay";
            this.cmb_Pay.Size = new System.Drawing.Size(147, 21);
            this.cmb_Pay.TabIndex = 35;
            this.cmb_Pay.SelectedIndexChanged += new System.EventHandler(this.cmb_Pay_SelectedIndexChanged);
            // 
            // labelX6
            // 
            this.labelX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(399, 170);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(30, 16);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "الاسم";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(779, 199);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(40, 16);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "الحساب";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(779, 224);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(57, 16);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "مركز التكلفة";
            // 
            // paied_amount
            // 
            this.paied_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.paied_amount.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.paied_amount.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paied_amount.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.paied_amount.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.paied_amount.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.paied_amount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.paied_amount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.paied_amount.Increment = 1D;
            this.paied_amount.Location = new System.Drawing.Point(625, 26);
            this.paied_amount.Name = "paied_amount";
            this.paied_amount.Size = new System.Drawing.Size(147, 21);
            this.paied_amount.TabIndex = 5;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(782, 30);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(29, 16);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "المبلغ";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(179, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(30, 16);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "التاريخ";
            // 
            // txt_sandDate
            // 
            this.txt_sandDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_sandDate.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_sandDate.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txt_sandDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txt_sandDate.ButtonDropDown.Visible = true;
            this.txt_sandDate.Location = new System.Drawing.Point(25, 11);
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
            this.txt_sandDate.MonthCalendar.DisplayMonth = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
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
            this.txt_sandDate.Size = new System.Drawing.Size(147, 21);
            this.txt_sandDate.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(181, 67);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(43, 16);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "رقم القيد";
            // 
            // AccSer_No
            // 
            this.AccSer_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.AccSer_No.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.AccSer_No.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AccSer_No.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.AccSer_No.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.AccSer_No.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.AccSer_No.Border.Class = "TextBoxBorder";
            this.AccSer_No.Enabled = false;
            this.AccSer_No.Location = new System.Drawing.Point(25, 65);
            this.AccSer_No.Name = "AccSer_No";
            this.AccSer_No.Size = new System.Drawing.Size(147, 21);
            this.AccSer_No.TabIndex = 0;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(9, 258);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(857, 150);
            this.dataGridViewX1.TabIndex = 296;
            // 
            // frm_paySanad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 460);
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.ribbonBar1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_paySanad";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سند صرف";
            this.Load += new System.EventHandler(this.frm_paySanad_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paied_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sandDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem BEdit;
        private DevComponents.DotNetBar.ButtonItem BSearch;
        private DevComponents.DotNetBar.ButtonItem print_sand;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCust;
        private DevComponents.DotNetBar.LabelX txt_source_code;
        private DevComponents.DotNetBar.LabelX user_id;
        public DevComponents.DotNetBar.LabelX txtStore_ID;
        public DevComponents.DotNetBar.LabelX acc_year;
        public DevComponents.DotNetBar.LabelX Payment_Type;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescr;
        private DevComponents.DotNetBar.LabelX labelX44;
        private System.Windows.Forms.ComboBox cmb_Bank;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput Check_Date;
        private DevComponents.DotNetBar.LabelX labelX43;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.TextBox txt_Check;
        private DevComponents.DotNetBar.LabelX labelX42;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sandNo;
        private DevComponents.DotNetBar.LabelX labelX41;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.ComboBox cmb_Pay;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DoubleInput paied_amount;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txt_sandDate;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX AccSer_No;
        private MyControls.UC_Acc txtAcc;
        private MyControls.UC_Acc txtCashAcc;
        private MyControls.UC_cost txtCost;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
    }
}