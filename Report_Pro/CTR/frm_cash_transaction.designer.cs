namespace Report_Pro.CTR
{
    partial class frm_cash_transaction
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ReportFundDetials = new DevComponents.DotNetBar.ButtonX();
            this.btn_Balance_Deatials = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.btn_fees = new DevComponents.DotNetBar.ButtonX();
            this.btn_bank_recet = new DevComponents.DotNetBar.ButtonX();
            this.btn_bank_deposit = new DevComponents.DotNetBar.ButtonX();
            this.btn_cash_recet = new DevComponents.DotNetBar.ButtonX();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCopy = new DevComponents.DotNetBar.ButtonX();
            this.btnSaveDetials = new DevComponents.DotNetBar.ButtonX();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.feesGrid1 = new Report_Pro.CTR.FeesGrid();
            this.txtAcc = new Report_Pro.MyControls.UC_Acc();
            this.Branch = new Report_Pro.MyControls.UC_AccBranch();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.txtAcc);
            this.groupPanel1.Controls.Add(this.btn_ReportFundDetials);
            this.groupPanel1.Controls.Add(this.Branch);
            this.groupPanel1.Controls.Add(this.btn_Balance_Deatials);
            this.groupPanel1.Controls.Add(this.buttonX5);
            this.groupPanel1.Controls.Add(this.textBox1);
            this.groupPanel1.Controls.Add(this.buttonX2);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.ToDate);
            this.groupPanel1.Controls.Add(this.FromDate);
            this.groupPanel1.Controls.Add(this.btn_fees);
            this.groupPanel1.Controls.Add(this.btn_bank_recet);
            this.groupPanel1.Controls.Add(this.btn_bank_deposit);
            this.groupPanel1.Controls.Add(this.btn_cash_recet);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1018, 94);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(772, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 312;
            this.label4.Text = "حساب الصندوق";
            // 
            // btn_ReportFundDetials
            // 
            this.btn_ReportFundDetials.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ReportFundDetials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReportFundDetials.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ReportFundDetials.Location = new System.Drawing.Point(105, 53);
            this.btn_ReportFundDetials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ReportFundDetials.Name = "btn_ReportFundDetials";
            this.btn_ReportFundDetials.Size = new System.Drawing.Size(105, 28);
            this.btn_ReportFundDetials.TabIndex = 309;
            this.btn_ReportFundDetials.Text = "تقرير تفاصيل الرصيد";
            this.btn_ReportFundDetials.Visible = false;
            this.btn_ReportFundDetials.Click += new System.EventHandler(this.btn_ReportFundDetials_Click);
            // 
            // btn_Balance_Deatials
            // 
            this.btn_Balance_Deatials.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Balance_Deatials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Balance_Deatials.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Balance_Deatials.Location = new System.Drawing.Point(381, 53);
            this.btn_Balance_Deatials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Balance_Deatials.Name = "btn_Balance_Deatials";
            this.btn_Balance_Deatials.Size = new System.Drawing.Size(87, 28);
            this.btn_Balance_Deatials.TabIndex = 307;
            this.btn_Balance_Deatials.Text = "تفاصيل الرصيد";
            this.btn_Balance_Deatials.Click += new System.EventHandler(this.btn_Balance_Deatials_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Location = new System.Drawing.Point(7, 54);
            this.buttonX5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(88, 28);
            this.buttonX5.TabIndex = 305;
            this.buttonX5.Text = "تعديل كود الحركة";
            this.buttonX5.Visible = false;
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(275, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 302;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(217, 54);
            this.buttonX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(90, 28);
            this.buttonX2.TabIndex = 301;
            this.buttonX2.Text = "تقرير النقدية";
            this.buttonX2.Visible = false;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(772, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 299;
            this.label3.Text = "الفرع";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(474, 54);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(87, 28);
            this.buttonX1.TabIndex = 297;
            this.buttonX1.Text = "كشف الحركة";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(963, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 296;
            this.label2.Text = "الي تاريخ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(963, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 295;
            this.label1.Text = "من تاريخ";
            // 
            // ToDate
            // 
            this.ToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDate.Location = new System.Drawing.Point(867, 29);
            this.ToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(90, 20);
            this.ToDate.TabIndex = 294;
            this.ToDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // FromDate
            // 
            this.FromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDate.Location = new System.Drawing.Point(867, 6);
            this.FromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(90, 20);
            this.FromDate.TabIndex = 293;
            // 
            // btn_fees
            // 
            this.btn_fees.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_fees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fees.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_fees.Location = new System.Drawing.Point(567, 54);
            this.btn_fees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_fees.Name = "btn_fees";
            this.btn_fees.Size = new System.Drawing.Size(87, 28);
            this.btn_fees.TabIndex = 3;
            this.btn_fees.Text = "المصاريف";
            this.btn_fees.Click += new System.EventHandler(this.btn_fees_Click);
            // 
            // btn_bank_recet
            // 
            this.btn_bank_recet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_bank_recet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bank_recet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_bank_recet.Location = new System.Drawing.Point(797, 54);
            this.btn_bank_recet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_bank_recet.Name = "btn_bank_recet";
            this.btn_bank_recet.Size = new System.Drawing.Size(95, 28);
            this.btn_bank_recet.TabIndex = 2;
            this.btn_bank_recet.Text = "سندات قبض بنوك";
            this.btn_bank_recet.Click += new System.EventHandler(this.btn_bank_recet_Click);
            // 
            // btn_bank_deposit
            // 
            this.btn_bank_deposit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_bank_deposit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bank_deposit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_bank_deposit.Location = new System.Drawing.Point(661, 54);
            this.btn_bank_deposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_bank_deposit.Name = "btn_bank_deposit";
            this.btn_bank_deposit.Size = new System.Drawing.Size(129, 28);
            this.btn_bank_deposit.TabIndex = 1;
            this.btn_bank_deposit.Text = "ايداعات بنكية من الصندوق";
            this.btn_bank_deposit.Click += new System.EventHandler(this.btn_bank_deposit_Click);
            // 
            // btn_cash_recet
            // 
            this.btn_cash_recet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cash_recet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cash_recet.BackColor = System.Drawing.Color.Transparent;
            this.btn_cash_recet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cash_recet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cash_recet.Location = new System.Drawing.Point(899, 54);
            this.btn_cash_recet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cash_recet.Name = "btn_cash_recet";
            this.btn_cash_recet.Size = new System.Drawing.Size(95, 28);
            this.btn_cash_recet.TabIndex = 0;
            this.btn_cash_recet.Text = "سندات قبض نقدية";
            this.btn_cash_recet.Click += new System.EventHandler(this.btn_cash_recet_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 1);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1016, 675);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // tabControl1
            // 
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 94);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(1018, 703);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "تفاصيل الرصيد";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.crystalReportViewer1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1018, 677);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "التقارير";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.feesGrid1);
            this.tabControlPanel2.Controls.Add(this.groupPanel2);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(1018, 677);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            this.tabControlPanel2.Enter += new System.EventHandler(this.tabControlPanel2_Enter);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnCopy);
            this.groupPanel2.Controls.Add(this.btnSaveDetials);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(1, 1);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1016, 51);
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
            this.groupPanel2.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCopy.Location = new System.Drawing.Point(691, 8);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(135, 29);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "نسخ من اخر حركة";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSaveDetials
            // 
            this.btnSaveDetials.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveDetials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDetials.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveDetials.Location = new System.Drawing.Point(490, 8);
            this.btnSaveDetials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveDetials.Name = "btnSaveDetials";
            this.btnSaveDetials.Size = new System.Drawing.Size(82, 29);
            this.btnSaveDetials.TabIndex = 10;
            this.btnSaveDetials.Text = "حفظ التفاصيل";
            this.btnSaveDetials.Click += new System.EventHandler(this.btnSaveDetials_Click);
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "تفاصيل الرصيد";
            // 
            // feesGrid1
            // 
            this.feesGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.feesGrid1.Location = new System.Drawing.Point(4, 52);
            this.feesGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.feesGrid1.Name = "feesGrid1";
            this.feesGrid1.Size = new System.Drawing.Size(1013, 624);
            this.feesGrid1.TabIndex = 1;
            // 
            // txtAcc
            // 
            this.txtAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtAcc.Location = new System.Drawing.Point(381, 29);
            this.txtAcc.Margin = new System.Windows.Forms.Padding(0);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Padding = new System.Windows.Forms.Padding(1);
            this.txtAcc.Size = new System.Drawing.Size(385, 21);
            this.txtAcc.TabIndex = 311;
            // 
            // Branch
            // 
            this.Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Branch.Location = new System.Drawing.Point(381, 5);
            this.Branch.Margin = new System.Windows.Forms.Padding(0);
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(385, 21);
            this.Branch.TabIndex = 308;
            this.Branch.Load += new System.EventHandler(this.Branch_Load);
            this.Branch.DoubleClick += new System.EventHandler(this.Branch_DoubleClick);
            // 
            // frm_cash_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 797);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_cash_transaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frm_cash_transaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_cash_transaction_FormClosing);
            this.Load += new System.EventHandler(this.frm_cash_transaction_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_cash_transaction_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DateTimePicker FromDate;
        private DevComponents.DotNetBar.ButtonX btn_fees;
        private DevComponents.DotNetBar.ButtonX btn_bank_recet;
        private DevComponents.DotNetBar.ButtonX btn_bank_deposit;
        private DevComponents.DotNetBar.ButtonX btn_cash_recet;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.TextBox textBox1;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private MyControls.UC_AccBranch Branch;
        private FeesGrid feesGrid1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnSaveDetials;
        private DevComponents.DotNetBar.ButtonX btnCopy;
        private DevComponents.DotNetBar.ButtonX btn_Balance_Deatials;
        private DevComponents.DotNetBar.ButtonX btn_ReportFundDetials;
        private System.Windows.Forms.Label label4;
        private MyControls.UC_Acc txtAcc;
    }
}