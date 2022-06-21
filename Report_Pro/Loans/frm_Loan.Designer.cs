namespace Report_Pro.Loans
{
    partial class frm_Loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Loan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BNew_ = new System.Windows.Forms.ToolStripMenuItem();
            this.BSave_ = new System.Windows.Forms.ToolStripMenuItem();
            this.BSearch_ = new System.Windows.Forms.ToolStripMenuItem();
            this.BStatment_ = new System.Windows.Forms.ToolStripMenuItem();
            this.BPrint_ = new System.Windows.Forms.ToolStripMenuItem();
            this.BExit_ = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.ch_Murabaha = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoanTearm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new DevComponents.Editors.DoubleInput();
            this.NoOfPayments = new DevComponents.Editors.IntegerInput();
            this.txtIntrestRate = new DevComponents.Editors.DoubleInput();
            this.txtLoanValue = new DevComponents.Editors.DoubleInput();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_StartDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtLoanRefrance = new System.Windows.Forms.TextBox();
            this.txtLoanPurpose = new System.Windows.Forms.ComboBox();
            this.txtLoanNo = new System.Windows.Forms.TextBox();
            this.txtLoanId = new System.Windows.Forms.TextBox();
            this.dgAccNo = new System.Windows.Forms.DataGridView();
            this.txtJorSer = new System.Windows.Forms.TextBox();
            this.txtSanadSer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jorDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMainLoanAccNo = new System.Windows.Forms.TextBox();
            this.chLoanSave = new System.Windows.Forms.CheckBox();
            this.txtYear = new System.Windows.Forms.Label();
            this.btnUploadDoc = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnViewDoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintJor = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateJor = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.BName = new Report_Pro.MyControls.UC_Acc();
            this.txtLoanAcc = new Report_Pro.MyControls.UC_Acc();
            this.Uc_Acc_M = new Report_Pro.MyControls.UC_Acc();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntrestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_StartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jorDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BNew_,
            this.BSave_,
            this.BSearch_,
            this.BStatment_,
            this.BPrint_,
            this.BExit_});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // BNew_
            // 
            resources.ApplyResources(this.BNew_, "BNew_");
            this.BNew_.ForeColor = System.Drawing.SystemColors.Window;
            this.BNew_.Image = global::Report_Pro.Properties.Resources.Add_Icon;
            this.BNew_.Name = "BNew_";
            this.BNew_.Click += new System.EventHandler(this.BNew_Click);
            // 
            // BSave_
            // 
            resources.ApplyResources(this.BSave_, "BSave_");
            this.BSave_.ForeColor = System.Drawing.SystemColors.Window;
            this.BSave_.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.BSave_.Name = "BSave_";
            this.BSave_.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BSearch_
            // 
            resources.ApplyResources(this.BSearch_, "BSearch_");
            this.BSearch_.ForeColor = System.Drawing.SystemColors.Window;
            this.BSearch_.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.BSearch_.Name = "BSearch_";
            this.BSearch_.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // BStatment_
            // 
            resources.ApplyResources(this.BStatment_, "BStatment_");
            this.BStatment_.ForeColor = System.Drawing.SystemColors.Window;
            this.BStatment_.Image = global::Report_Pro.Properties.Resources.Reports1;
            this.BStatment_.Name = "BStatment_";
            this.BStatment_.Click += new System.EventHandler(this.BStatment_Click);
            // 
            // BPrint_
            // 
            resources.ApplyResources(this.BPrint_, "BPrint_");
            this.BPrint_.ForeColor = System.Drawing.SystemColors.Window;
            this.BPrint_.Image = global::Report_Pro.Properties.Resources.printer_icon;
            this.BPrint_.Name = "BPrint_";
            this.BPrint_.Click += new System.EventHandler(this.BPrint_Click);
            // 
            // BExit_
            // 
            resources.ApplyResources(this.BExit_, "BExit_");
            this.BExit_.ForeColor = System.Drawing.SystemColors.Window;
            this.BExit_.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.BExit_.Name = "BExit_";
            this.BExit_.Click += new System.EventHandler(this.BExit_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Name = "label10";
            // 
            // ch_Murabaha
            // 
            resources.ApplyResources(this.ch_Murabaha, "ch_Murabaha");
            this.ch_Murabaha.Name = "ch_Murabaha";
            this.ch_Murabaha.UseVisualStyleBackColor = true;
            this.ch_Murabaha.CheckedChanged += new System.EventHandler(this.ch_Murabaha_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Name = "label1";
            // 
            // txtLoanTearm
            // 
            resources.ApplyResources(this.txtLoanTearm, "txtLoanTearm");
            this.txtLoanTearm.FormattingEnabled = true;
            this.txtLoanTearm.Name = "txtLoanTearm";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Name = "label2";
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            // 
            // 
            // 
            this.txtTotal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTotal.ButtonClear.DisplayPosition = ((int)(resources.GetObject("txtTotal.ButtonClear.DisplayPosition")));
            this.txtTotal.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("txtTotal.ButtonClear.Image")));
            this.txtTotal.ButtonClear.Text = resources.GetString("txtTotal.ButtonClear.Text");
            this.txtTotal.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtTotal.ButtonCustom.DisplayPosition")));
            this.txtTotal.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtTotal.ButtonCustom.Image")));
            this.txtTotal.ButtonCustom.Text = resources.GetString("txtTotal.ButtonCustom.Text");
            this.txtTotal.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtTotal.ButtonCustom2.DisplayPosition")));
            this.txtTotal.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtTotal.ButtonCustom2.Image")));
            this.txtTotal.ButtonCustom2.Text = resources.GetString("txtTotal.ButtonCustom2.Text");
            this.txtTotal.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("txtTotal.ButtonDropDown.DisplayPosition")));
            this.txtTotal.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("txtTotal.ButtonDropDown.Image")));
            this.txtTotal.ButtonDropDown.Text = resources.GetString("txtTotal.ButtonDropDown.Text");
            this.txtTotal.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("txtTotal.ButtonFreeText.DisplayPosition")));
            this.txtTotal.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("txtTotal.ButtonFreeText.Image")));
            this.txtTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtTotal.ButtonFreeText.Text = resources.GetString("txtTotal.ButtonFreeText.Text");
            this.txtTotal.Increment = 1D;
            this.txtTotal.Name = "txtTotal";
            // 
            // NoOfPayments
            // 
            resources.ApplyResources(this.NoOfPayments, "NoOfPayments");
            // 
            // 
            // 
            this.NoOfPayments.BackgroundStyle.Class = "DateTimeInputBackground";
            this.NoOfPayments.ButtonClear.DisplayPosition = ((int)(resources.GetObject("NoOfPayments.ButtonClear.DisplayPosition")));
            this.NoOfPayments.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("NoOfPayments.ButtonClear.Image")));
            this.NoOfPayments.ButtonClear.Text = resources.GetString("NoOfPayments.ButtonClear.Text");
            this.NoOfPayments.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("NoOfPayments.ButtonCustom.DisplayPosition")));
            this.NoOfPayments.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("NoOfPayments.ButtonCustom.Image")));
            this.NoOfPayments.ButtonCustom.Text = resources.GetString("NoOfPayments.ButtonCustom.Text");
            this.NoOfPayments.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("NoOfPayments.ButtonCustom2.DisplayPosition")));
            this.NoOfPayments.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("NoOfPayments.ButtonCustom2.Image")));
            this.NoOfPayments.ButtonCustom2.Text = resources.GetString("NoOfPayments.ButtonCustom2.Text");
            this.NoOfPayments.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("NoOfPayments.ButtonDropDown.DisplayPosition")));
            this.NoOfPayments.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("NoOfPayments.ButtonDropDown.Image")));
            this.NoOfPayments.ButtonDropDown.Text = resources.GetString("NoOfPayments.ButtonDropDown.Text");
            this.NoOfPayments.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("NoOfPayments.ButtonFreeText.DisplayPosition")));
            this.NoOfPayments.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("NoOfPayments.ButtonFreeText.Image")));
            this.NoOfPayments.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.NoOfPayments.ButtonFreeText.Text = resources.GetString("NoOfPayments.ButtonFreeText.Text");
            this.NoOfPayments.Name = "NoOfPayments";
            this.NoOfPayments.ShowUpDown = true;
            this.NoOfPayments.Value = 1;
            this.NoOfPayments.ValueChanged += new System.EventHandler(this.NoOfPayments_ValueChanged);
            this.NoOfPayments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NoOfPayments_KeyDown);
            // 
            // txtIntrestRate
            // 
            resources.ApplyResources(this.txtIntrestRate, "txtIntrestRate");
            // 
            // 
            // 
            this.txtIntrestRate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtIntrestRate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("txtIntrestRate.ButtonClear.DisplayPosition")));
            this.txtIntrestRate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("txtIntrestRate.ButtonClear.Image")));
            this.txtIntrestRate.ButtonClear.Text = resources.GetString("txtIntrestRate.ButtonClear.Text");
            this.txtIntrestRate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtIntrestRate.ButtonCustom.DisplayPosition")));
            this.txtIntrestRate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtIntrestRate.ButtonCustom.Image")));
            this.txtIntrestRate.ButtonCustom.Text = resources.GetString("txtIntrestRate.ButtonCustom.Text");
            this.txtIntrestRate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtIntrestRate.ButtonCustom2.DisplayPosition")));
            this.txtIntrestRate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtIntrestRate.ButtonCustom2.Image")));
            this.txtIntrestRate.ButtonCustom2.Text = resources.GetString("txtIntrestRate.ButtonCustom2.Text");
            this.txtIntrestRate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("txtIntrestRate.ButtonDropDown.DisplayPosition")));
            this.txtIntrestRate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("txtIntrestRate.ButtonDropDown.Image")));
            this.txtIntrestRate.ButtonDropDown.Text = resources.GetString("txtIntrestRate.ButtonDropDown.Text");
            this.txtIntrestRate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("txtIntrestRate.ButtonFreeText.DisplayPosition")));
            this.txtIntrestRate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("txtIntrestRate.ButtonFreeText.Image")));
            this.txtIntrestRate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtIntrestRate.ButtonFreeText.Text = resources.GetString("txtIntrestRate.ButtonFreeText.Text");
            this.txtIntrestRate.DisplayFormat = "#,##0.0000";
            this.txtIntrestRate.Increment = 1D;
            this.txtIntrestRate.Name = "txtIntrestRate";
            this.txtIntrestRate.ValueChanged += new System.EventHandler(this.txtIntrestRate_ValueChanged);
            this.txtIntrestRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIntrestRate_KeyDown);
            this.txtIntrestRate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIntrestRate_KeyUp);
            // 
            // txtLoanValue
            // 
            resources.ApplyResources(this.txtLoanValue, "txtLoanValue");
            // 
            // 
            // 
            this.txtLoanValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtLoanValue.ButtonClear.DisplayPosition = ((int)(resources.GetObject("txtLoanValue.ButtonClear.DisplayPosition")));
            this.txtLoanValue.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("txtLoanValue.ButtonClear.Image")));
            this.txtLoanValue.ButtonClear.Text = resources.GetString("txtLoanValue.ButtonClear.Text");
            this.txtLoanValue.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtLoanValue.ButtonCustom.DisplayPosition")));
            this.txtLoanValue.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtLoanValue.ButtonCustom.Image")));
            this.txtLoanValue.ButtonCustom.Text = resources.GetString("txtLoanValue.ButtonCustom.Text");
            this.txtLoanValue.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtLoanValue.ButtonCustom2.DisplayPosition")));
            this.txtLoanValue.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtLoanValue.ButtonCustom2.Image")));
            this.txtLoanValue.ButtonCustom2.Text = resources.GetString("txtLoanValue.ButtonCustom2.Text");
            this.txtLoanValue.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("txtLoanValue.ButtonDropDown.DisplayPosition")));
            this.txtLoanValue.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("txtLoanValue.ButtonDropDown.Image")));
            this.txtLoanValue.ButtonDropDown.Text = resources.GetString("txtLoanValue.ButtonDropDown.Text");
            this.txtLoanValue.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("txtLoanValue.ButtonFreeText.DisplayPosition")));
            this.txtLoanValue.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("txtLoanValue.ButtonFreeText.Image")));
            this.txtLoanValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtLoanValue.ButtonFreeText.Text = resources.GetString("txtLoanValue.ButtonFreeText.Text");
            this.txtLoanValue.Increment = 1D;
            this.txtLoanValue.Name = "txtLoanValue";
            this.txtLoanValue.ValueChanged += new System.EventHandler(this.txtLoanValue_ValueChanged);
            this.txtLoanValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoanValue_KeyDown);
            this.txtLoanValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLoanValue_KeyUp);
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.BackColor = System.Drawing.SystemColors.Highlight;
            this.label35.ForeColor = System.Drawing.SystemColors.Window;
            this.label35.Name = "label35";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.BackColor = System.Drawing.SystemColors.Highlight;
            this.label34.ForeColor = System.Drawing.SystemColors.Window;
            this.label34.Name = "label34";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.BackColor = System.Drawing.SystemColors.Highlight;
            this.label33.ForeColor = System.Drawing.SystemColors.Window;
            this.label33.Name = "label33";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.BackColor = System.Drawing.SystemColors.Highlight;
            this.label27.ForeColor = System.Drawing.SystemColors.Window;
            this.label27.Name = "label27";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.BackColor = System.Drawing.SystemColors.Highlight;
            this.label26.ForeColor = System.Drawing.SystemColors.Window;
            this.label26.Name = "label26";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Name = "label25";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Name = "label24";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Name = "label23";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Name = "label7";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Name = "label3";
            // 
            // L_StartDate
            // 
            resources.ApplyResources(this.L_StartDate, "L_StartDate");
            // 
            // 
            // 
            this.L_StartDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.L_StartDate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("L_StartDate.ButtonClear.DisplayPosition")));
            this.L_StartDate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("L_StartDate.ButtonClear.Image")));
            this.L_StartDate.ButtonClear.Text = resources.GetString("L_StartDate.ButtonClear.Text");
            this.L_StartDate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("L_StartDate.ButtonCustom.DisplayPosition")));
            this.L_StartDate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("L_StartDate.ButtonCustom.Image")));
            this.L_StartDate.ButtonCustom.Text = resources.GetString("L_StartDate.ButtonCustom.Text");
            this.L_StartDate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("L_StartDate.ButtonCustom2.DisplayPosition")));
            this.L_StartDate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("L_StartDate.ButtonCustom2.Image")));
            this.L_StartDate.ButtonCustom2.Text = resources.GetString("L_StartDate.ButtonCustom2.Text");
            this.L_StartDate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("L_StartDate.ButtonDropDown.DisplayPosition")));
            this.L_StartDate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("L_StartDate.ButtonDropDown.Image")));
            this.L_StartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.L_StartDate.ButtonDropDown.Text = resources.GetString("L_StartDate.ButtonDropDown.Text");
            this.L_StartDate.ButtonDropDown.Visible = true;
            this.L_StartDate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("L_StartDate.ButtonFreeText.DisplayPosition")));
            this.L_StartDate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("L_StartDate.ButtonFreeText.Image")));
            this.L_StartDate.ButtonFreeText.Text = resources.GetString("L_StartDate.ButtonFreeText.Text");
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("L_StartDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.L_StartDate.MonthCalendar.Category = resources.GetString("L_StartDate.MonthCalendar.Category");
            this.L_StartDate.MonthCalendar.ClearButtonVisible = true;
            this.L_StartDate.MonthCalendar.CommandParameter = ((object)(resources.GetObject("L_StartDate.MonthCalendar.CommandParameter")));
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.L_StartDate.MonthCalendar.DayNames = ((string[])(resources.GetObject("L_StartDate.MonthCalendar.DayNames")));
            this.L_StartDate.MonthCalendar.Description = resources.GetString("L_StartDate.MonthCalendar.Description");
            this.L_StartDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.L_StartDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("L_StartDate.MonthCalendar.MarkedDates")));
            this.L_StartDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("L_StartDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.L_StartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.L_StartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.L_StartDate.MonthCalendar.Tag = resources.GetString("L_StartDate.MonthCalendar.Tag");
            this.L_StartDate.MonthCalendar.Text = resources.GetString("L_StartDate.MonthCalendar.Text");
            this.L_StartDate.MonthCalendar.TodayButtonVisible = true;
            this.L_StartDate.MonthCalendar.Tooltip = resources.GetString("L_StartDate.MonthCalendar.Tooltip");
            this.L_StartDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("L_StartDate.MonthCalendar.WeeklyMarkedDays")));
            this.L_StartDate.Name = "L_StartDate";
            this.L_StartDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.L_StartDate_KeyDown);
            this.L_StartDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.L_StartDate_KeyUp);
            // 
            // txtLoanRefrance
            // 
            resources.ApplyResources(this.txtLoanRefrance, "txtLoanRefrance");
            this.txtLoanRefrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoanRefrance.Name = "txtLoanRefrance";
            // 
            // txtLoanPurpose
            // 
            resources.ApplyResources(this.txtLoanPurpose, "txtLoanPurpose");
            this.txtLoanPurpose.FormattingEnabled = true;
            this.txtLoanPurpose.Name = "txtLoanPurpose";
            this.txtLoanPurpose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoanPurpose_KeyDown);
            // 
            // txtLoanNo
            // 
            resources.ApplyResources(this.txtLoanNo, "txtLoanNo");
            this.txtLoanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoanNo_KeyDown);
            this.txtLoanNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLoanNo_KeyUp);
            // 
            // txtLoanId
            // 
            resources.ApplyResources(this.txtLoanId, "txtLoanId");
            this.txtLoanId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.TextChanged += new System.EventHandler(this.txtLoanId_TextChanged);
            // 
            // dgAccNo
            // 
            resources.ApplyResources(this.dgAccNo, "dgAccNo");
            this.dgAccNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAccNo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgAccNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccNo.Name = "dgAccNo";
            this.dgAccNo.RowTemplate.Height = 29;
            this.dgAccNo.DoubleClick += new System.EventHandler(this.dgAccNo_DoubleClick);
            // 
            // txtJorSer
            // 
            resources.ApplyResources(this.txtJorSer, "txtJorSer");
            this.txtJorSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJorSer.Name = "txtJorSer";
            this.txtJorSer.TextChanged += new System.EventHandler(this.txtJorSer_TextChanged);
            // 
            // txtSanadSer
            // 
            resources.ApplyResources(this.txtSanadSer, "txtSanadSer");
            this.txtSanadSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSanadSer.Name = "txtSanadSer";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Name = "label5";
            // 
            // jorDate
            // 
            resources.ApplyResources(this.jorDate, "jorDate");
            // 
            // 
            // 
            this.jorDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.jorDate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("jorDate.ButtonClear.DisplayPosition")));
            this.jorDate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("jorDate.ButtonClear.Image")));
            this.jorDate.ButtonClear.Text = resources.GetString("jorDate.ButtonClear.Text");
            this.jorDate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("jorDate.ButtonCustom.DisplayPosition")));
            this.jorDate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("jorDate.ButtonCustom.Image")));
            this.jorDate.ButtonCustom.Text = resources.GetString("jorDate.ButtonCustom.Text");
            this.jorDate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("jorDate.ButtonCustom2.DisplayPosition")));
            this.jorDate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("jorDate.ButtonCustom2.Image")));
            this.jorDate.ButtonCustom2.Text = resources.GetString("jorDate.ButtonCustom2.Text");
            this.jorDate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("jorDate.ButtonDropDown.DisplayPosition")));
            this.jorDate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("jorDate.ButtonDropDown.Image")));
            this.jorDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.jorDate.ButtonDropDown.Text = resources.GetString("jorDate.ButtonDropDown.Text");
            this.jorDate.ButtonDropDown.Visible = true;
            this.jorDate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("jorDate.ButtonFreeText.DisplayPosition")));
            this.jorDate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("jorDate.ButtonFreeText.Image")));
            this.jorDate.ButtonFreeText.Text = resources.GetString("jorDate.ButtonFreeText.Text");
            // 
            // 
            // 
            this.jorDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("jorDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.jorDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.jorDate.MonthCalendar.Category = resources.GetString("jorDate.MonthCalendar.Category");
            this.jorDate.MonthCalendar.ClearButtonVisible = true;
            this.jorDate.MonthCalendar.CommandParameter = ((object)(resources.GetObject("jorDate.MonthCalendar.CommandParameter")));
            // 
            // 
            // 
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.jorDate.MonthCalendar.DayNames = ((string[])(resources.GetObject("jorDate.MonthCalendar.DayNames")));
            this.jorDate.MonthCalendar.Description = resources.GetString("jorDate.MonthCalendar.Description");
            this.jorDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.jorDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("jorDate.MonthCalendar.MarkedDates")));
            this.jorDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("jorDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.jorDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.jorDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.jorDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.jorDate.MonthCalendar.Tag = resources.GetString("jorDate.MonthCalendar.Tag");
            this.jorDate.MonthCalendar.Text = resources.GetString("jorDate.MonthCalendar.Text");
            this.jorDate.MonthCalendar.TodayButtonVisible = true;
            this.jorDate.MonthCalendar.Tooltip = resources.GetString("jorDate.MonthCalendar.Tooltip");
            this.jorDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("jorDate.MonthCalendar.WeeklyMarkedDays")));
            this.jorDate.Name = "jorDate";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Name = "label6";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Name = "label8";
            // 
            // txtMainLoanAccNo
            // 
            resources.ApplyResources(this.txtMainLoanAccNo, "txtMainLoanAccNo");
            this.txtMainLoanAccNo.Name = "txtMainLoanAccNo";
            // 
            // chLoanSave
            // 
            resources.ApplyResources(this.chLoanSave, "chLoanSave");
            this.chLoanSave.BackColor = System.Drawing.Color.Transparent;
            this.chLoanSave.Name = "chLoanSave";
            this.chLoanSave.UseVisualStyleBackColor = false;
            this.chLoanSave.CheckedChanged += new System.EventHandler(this.chLoanSave_CheckedChanged);
            // 
            // txtYear
            // 
            resources.ApplyResources(this.txtYear, "txtYear");
            this.txtYear.BackColor = System.Drawing.Color.Transparent;
            this.txtYear.Name = "txtYear";
            // 
            // btnUploadDoc
            // 
            resources.ApplyResources(this.btnUploadDoc, "btnUploadDoc");
            this.btnUploadDoc.Appearance.Options.UseTextOptions = true;
            this.btnUploadDoc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnUploadDoc.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUploadDoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUploadDoc.ImageOptions.SvgImage")));
            this.btnUploadDoc.Name = "btnUploadDoc";
            this.btnUploadDoc.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnUploadDoc.Click += new System.EventHandler(this.btnUploadDoc_Click);
            // 
            // groupControl1
            // 
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.btnViewDoc);
            this.groupControl1.Controls.Add(this.btnUploadDoc);
            this.groupControl1.Name = "groupControl1";
            // 
            // btnViewDoc
            // 
            resources.ApplyResources(this.btnViewDoc, "btnViewDoc");
            this.btnViewDoc.Appearance.Options.UseTextOptions = true;
            this.btnViewDoc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnViewDoc.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnViewDoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewDoc.ImageOptions.SvgImage")));
            this.btnViewDoc.Name = "btnViewDoc";
            this.btnViewDoc.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnViewDoc.Click += new System.EventHandler(this.btnViewDoc_Click);
            // 
            // btnPrintJor
            // 
            resources.ApplyResources(this.btnPrintJor, "btnPrintJor");
            this.btnPrintJor.Appearance.Options.UseTextOptions = true;
            this.btnPrintJor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnPrintJor.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrintJor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintJor.ImageOptions.SvgImage")));
            this.btnPrintJor.Name = "btnPrintJor";
            this.btnPrintJor.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPrintJor.Click += new System.EventHandler(this.btnPrintJor_Click);
            // 
            // btnCreateJor
            // 
            resources.ApplyResources(this.btnCreateJor, "btnCreateJor");
            this.btnCreateJor.Appearance.Options.UseTextOptions = true;
            this.btnCreateJor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnCreateJor.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreateJor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreateJor.ImageOptions.SvgImage")));
            this.btnCreateJor.Name = "btnCreateJor";
            this.btnCreateJor.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCreateJor.Click += new System.EventHandler(this.btnCreateJor_Click);
            // 
            // groupControl2
            // 
            resources.ApplyResources(this.groupControl2, "groupControl2");
            this.groupControl2.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.txtJorSer);
            this.groupControl2.Controls.Add(this.btnPrintJor);
            this.groupControl2.Controls.Add(this.btnCreateJor);
            this.groupControl2.Controls.Add(this.txtSanadSer);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.jorDate);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Name = "groupControl2";
            // 
            // groupControl3
            // 
            resources.ApplyResources(this.groupControl3, "groupControl3");
            this.groupControl3.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.groupControl3.Appearance.Options.UseBorderColor = true;
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.simpleButton1);
            this.groupControl3.Controls.Add(this.dgAccNo);
            this.groupControl3.Name = "groupControl3";
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Click += new System.EventHandler(this.btnAddAccount);
            // 
            // groupControl4
            // 
            resources.ApplyResources(this.groupControl4, "groupControl4");
            this.groupControl4.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.groupControl4.Appearance.Options.UseBorderColor = true;
            this.groupControl4.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl4.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl4.Controls.Add(this.txtTotal);
            this.groupControl4.Controls.Add(this.label10);
            this.groupControl4.Controls.Add(this.label35);
            this.groupControl4.Controls.Add(this.txtLoanId);
            this.groupControl4.Controls.Add(this.label34);
            this.groupControl4.Controls.Add(this.ch_Murabaha);
            this.groupControl4.Controls.Add(this.label33);
            this.groupControl4.Controls.Add(this.txtLoanNo);
            this.groupControl4.Controls.Add(this.label27);
            this.groupControl4.Controls.Add(this.label1);
            this.groupControl4.Controls.Add(this.label26);
            this.groupControl4.Controls.Add(this.flowLayoutPanel1);
            this.groupControl4.Controls.Add(this.BName);
            this.groupControl4.Controls.Add(this.txtLoanTearm);
            this.groupControl4.Controls.Add(this.txtLoanAcc);
            this.groupControl4.Controls.Add(this.label2);
            this.groupControl4.Controls.Add(this.txtLoanPurpose);
            this.groupControl4.Controls.Add(this.txtLoanRefrance);
            this.groupControl4.Controls.Add(this.Uc_Acc_M);
            this.groupControl4.Controls.Add(this.L_StartDate);
            this.groupControl4.Controls.Add(this.NoOfPayments);
            this.groupControl4.Controls.Add(this.label3);
            this.groupControl4.Controls.Add(this.txtIntrestRate);
            this.groupControl4.Controls.Add(this.label7);
            this.groupControl4.Controls.Add(this.txtLoanValue);
            this.groupControl4.Controls.Add(this.label9);
            this.groupControl4.Controls.Add(this.label11);
            this.groupControl4.Controls.Add(this.label12);
            this.groupControl4.Controls.Add(this.label13);
            this.groupControl4.Controls.Add(this.label14);
            this.groupControl4.Controls.Add(this.label23);
            this.groupControl4.Controls.Add(this.label24);
            this.groupControl4.Controls.Add(this.label25);
            this.groupControl4.Name = "groupControl4";
            // 
            // BName
            // 
            resources.ApplyResources(this.BName, "BName");
            this.BName.BackColor = System.Drawing.Color.Transparent;
            this.BName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BName.Name = "BName";
            this.BName.Load += new System.EventHandler(this.BName_Load);
            this.BName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BName_KeyDown);
            // 
            // txtLoanAcc
            // 
            resources.ApplyResources(this.txtLoanAcc, "txtLoanAcc");
            this.txtLoanAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtLoanAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoanAcc.Name = "txtLoanAcc";
            this.txtLoanAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoanAcc_KeyDown);
            // 
            // Uc_Acc_M
            // 
            resources.ApplyResources(this.Uc_Acc_M, "Uc_Acc_M");
            this.Uc_Acc_M.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Acc_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Uc_Acc_M.Name = "Uc_Acc_M";
            this.Uc_Acc_M.Load += new System.EventHandler(this.Uc_Acc_M_Load);
            // 
            // frm_Loan
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chLoanSave);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMainLoanAccNo);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "frm_Loan";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frm_Loan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Loan_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntrestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_StartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jorDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BNew_;
        private System.Windows.Forms.ToolStripMenuItem BSave_;
        private System.Windows.Forms.ToolStripMenuItem BSearch_;
        private System.Windows.Forms.ToolStripMenuItem BStatment_;
        private System.Windows.Forms.ToolStripMenuItem BPrint_;
        private System.Windows.Forms.ToolStripMenuItem BExit_;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput L_StartDate;
        private System.Windows.Forms.TextBox txtLoanRefrance;
        private System.Windows.Forms.ComboBox txtLoanPurpose;
        private MyControls.UC_Acc txtLoanAcc;
        private MyControls.UC_Acc BName;
        private System.Windows.Forms.TextBox txtLoanNo;
        private System.Windows.Forms.TextBox txtLoanId;
        private System.Windows.Forms.DataGridView dgAccNo;
        private System.Windows.Forms.TextBox txtJorSer;
        private System.Windows.Forms.TextBox txtSanadSer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput jorDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMainLoanAccNo;
        private System.Windows.Forms.CheckBox chLoanSave;
        private System.Windows.Forms.Label txtYear;
        private DevComponents.Editors.IntegerInput NoOfPayments;
        private DevComponents.Editors.DoubleInput txtIntrestRate;
        private DevComponents.Editors.DoubleInput txtLoanValue;
        private DevComponents.Editors.DoubleInput txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtLoanTearm;
        private System.Windows.Forms.Label label2;
        private MyControls.UC_Acc Uc_Acc_M;
        private System.Windows.Forms.CheckBox ch_Murabaha;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btnUploadDoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnViewDoc;
        private DevExpress.XtraEditors.SimpleButton btnPrintJor;
        private DevExpress.XtraEditors.SimpleButton btnCreateJor;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
    }
}