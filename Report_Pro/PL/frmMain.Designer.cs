namespace Report_Pro.PL
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbl_titlepage = new System.Windows.Forms.Label();
            this.btn_not = new DevExpress.XtraEditors.SimpleButton();
            this.btn_min = new DevExpress.XtraEditors.SimpleButton();
            this.btn_max = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.gHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.gLogin = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.login = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.logout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.gSetup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.system_setup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.setup_colors = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.gBasic_Data = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.banks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.stores = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.branches = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.gSales = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sales_transactions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.gPurchases = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.gStock = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.gAccounting = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.pn_contaner = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlHeader.Controls.Add(this.lbl_titlepage);
            this.pnlHeader.Controls.Add(this.btn_not);
            this.pnlHeader.Controls.Add(this.btn_min);
            this.pnlHeader.Controls.Add(this.btn_max);
            this.pnlHeader.Controls.Add(this.btn_close);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1920, 40);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // lbl_titlepage
            // 
            this.lbl_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titlepage.AutoSize = true;
            this.lbl_titlepage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlepage.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_titlepage.Location = new System.Drawing.Point(916, 14);
            this.lbl_titlepage.Name = "lbl_titlepage";
            this.lbl_titlepage.Size = new System.Drawing.Size(99, 16);
            this.lbl_titlepage.TabIndex = 4;
            this.lbl_titlepage.Text = "الصفحة الرئيسية";
            // 
            // btn_not
            // 
            this.btn_not.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_not.ImageOptions.Image = global::Report_Pro.Properties.Resources.pielabelstooltips_32x32;
            this.btn_not.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_not.Location = new System.Drawing.Point(1742, 3);
            this.btn_not.Name = "btn_not";
            this.btn_not.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_not.Size = new System.Drawing.Size(36, 36);
            this.btn_not.TabIndex = 3;
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.ImageOptions.Image = global::Report_Pro.Properties.Resources.remove_32x32;
            this.btn_min.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_min.Location = new System.Drawing.Point(1788, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_min.Size = new System.Drawing.Size(36, 36);
            this.btn_min.TabIndex = 3;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.ImageOptions.Image = global::Report_Pro.Properties.Resources.selectall_32x32;
            this.btn_max.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_max.Location = new System.Drawing.Point(1834, 3);
            this.btn_max.Name = "btn_max";
            this.btn_max.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_max.Size = new System.Drawing.Size(36, 36);
            this.btn_max.TabIndex = 3;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.ImageOptions.Image = global::Report_Pro.Properties.Resources.cancel_32x32;
            this.btn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_close.Location = new System.Drawing.Point(1880, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_close.Size = new System.Drawing.Size(36, 36);
            this.btn_close.TabIndex = 3;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(165, 21);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1094, 62);
            this.miniToolStrip.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.AccordionControl.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.AccordionControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.AccordionControl.ForeColor = System.Drawing.Color.White;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBorderColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Group.Disabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Group.Disabled.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Group.Disabled.ForeColor = System.Drawing.Color.DimGray;
            this.accordionControl1.Appearance.Group.Disabled.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Group.Disabled.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Group.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Group.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Group.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionControl1.Appearance.Group.Normal.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Group.Normal.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Hint.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Hint.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Disabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Item.Disabled.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Item.Disabled.ForeColor = System.Drawing.Color.DimGray;
            this.accordionControl1.Appearance.Item.Disabled.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Disabled.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Item.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Item.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Item.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionControl1.Appearance.Item.Normal.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Normal.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Item.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Item.Pressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.accordionControl1.Appearance.Item.Pressed.ForeColor = System.Drawing.Color.Gray;
            this.accordionControl1.Appearance.Item.Pressed.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Pressed.Options.UseForeColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.gHome,
            this.gLogin,
            this.gSetup,
            this.gBasic_Data,
            this.gSales,
            this.gPurchases,
            this.gStock,
            this.gAccounting});
            this.accordionControl1.Location = new System.Drawing.Point(0, 40);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(238, 1160);
            this.accordionControl1.TabIndex = 7;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // gHome
            // 
            this.gHome.ImageOptions.Image = global::Report_Pro.Properties.Resources.home_32x32;
            this.gHome.Name = "gHome";
            this.gHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.gHome.Text = "Home";
            this.gHome.Click += new System.EventHandler(this.gHome_Click);
            // 
            // gLogin
            // 
            this.gLogin.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.login,
            this.logout});
            this.gLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gLogin.ImageOptions.Image")));
            this.gLogin.Name = "gLogin";
            this.gLogin.Text = "Login";
            this.gLogin.Click += new System.EventHandler(this.gLogin_Click);
            // 
            // login
            // 
            this.login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("login.ImageOptions.Image")));
            this.login.Name = "login";
            this.login.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // logout
            // 
            this.logout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("logout.ImageOptions.Image")));
            this.logout.Name = "logout";
            this.logout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.logout.Text = "Logout";
            // 
            // gSetup
            // 
            this.gSetup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.system_setup,
            this.setup_colors});
            this.gSetup.ImageOptions.Image = global::Report_Pro.Properties.Resources.properties_32x32;
            this.gSetup.Name = "gSetup";
            this.gSetup.Text = "Setup";
            // 
            // system_setup
            // 
            this.system_setup.ImageOptions.Image = global::Report_Pro.Properties.Resources.loadpagesetup_32x32;
            this.system_setup.Name = "system_setup";
            this.system_setup.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.system_setup.Text = "System Setup";
            // 
            // setup_colors
            // 
            this.setup_colors.ImageOptions.Image = global::Report_Pro.Properties.Resources.changetheme_32x32;
            this.setup_colors.Name = "setup_colors";
            this.setup_colors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.setup_colors.Text = "Setup Colors";
            // 
            // gBasic_Data
            // 
            this.gBasic_Data.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.banks,
            this.stores,
            this.branches});
            this.gBasic_Data.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gBasic_Data.ImageOptions.Image")));
            this.gBasic_Data.Name = "gBasic_Data";
            this.gBasic_Data.Text = "Basic Data";
            // 
            // banks
            // 
            this.banks.ImageOptions.Image = global::Report_Pro.Properties.Resources.bank;
            this.banks.Name = "banks";
            this.banks.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.banks.Text = "Banks";
            // 
            // stores
            // 
            this.stores.ImageOptions.Image = global::Report_Pro.Properties.Resources.store;
            this.stores.Name = "stores";
            this.stores.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.stores.Text = "Stores";
            // 
            // branches
            // 
            this.branches.ImageOptions.Image = global::Report_Pro.Properties.Resources.department;
            this.branches.Name = "branches";
            this.branches.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.branches.Text = "Branches";
            // 
            // gSales
            // 
            this.gSales.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.sales_transactions,
            this.accordionControlElement1});
            this.gSales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gSales.ImageOptions.Image")));
            this.gSales.Name = "gSales";
            this.gSales.Text = "Sales";
            this.gSales.Click += new System.EventHandler(this.gSales_Click);
            // 
            // sales_transactions
            // 
            this.sales_transactions.ImageOptions.Image = global::Report_Pro.Properties.Resources.salesanalysis_32x32;
            this.sales_transactions.Name = "sales_transactions";
            this.sales_transactions.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sales_transactions.Text = "Sales Transactions";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.Image = global::Report_Pro.Properties.Resources.report;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Sales Reports";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // gPurchases
            // 
            this.gPurchases.ImageOptions.Image = global::Report_Pro.Properties.Resources.buy_32x32;
            this.gPurchases.Name = "gPurchases";
            this.gPurchases.Text = "Purchases";
            // 
            // gStock
            // 
            this.gStock.ImageOptions.Image = global::Report_Pro.Properties.Resources.stock;
            this.gStock.Name = "gStock";
            this.gStock.Text = "Stock";
            // 
            // gAccounting
            // 
            this.gAccounting.ImageOptions.Image = global::Report_Pro.Properties.Resources.accounting;
            this.gAccounting.Name = "gAccounting";
            this.gAccounting.Text = "Accounting";
            // 
            // pn_contaner
            // 
            this.pn_contaner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_contaner.Location = new System.Drawing.Point(238, 40);
            this.pn_contaner.Name = "pn_contaner";
            this.pn_contaner.Size = new System.Drawing.Size(1682, 1160);
            this.pn_contaner.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1200);
            this.ControlBox = false;
            this.Controls.Add(this.pn_contaner);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement login;
        private DevExpress.XtraBars.Navigation.AccordionControlElement logout;
        private DevExpress.XtraBars.Navigation.AccordionControlElement system_setup;
        private DevExpress.XtraBars.Navigation.AccordionControlElement setup_colors;
        private DevExpress.XtraBars.Navigation.AccordionControlElement banks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement stores;
        private DevExpress.XtraBars.Navigation.AccordionControlElement branches;
        public DevExpress.XtraBars.Navigation.AccordionControlElement gLogin;
        public DevExpress.XtraBars.Navigation.AccordionControlElement gSetup;
        public DevExpress.XtraBars.Navigation.AccordionControlElement gSales;
        public DevExpress.XtraBars.Navigation.AccordionControlElement gPurchases;
        public DevExpress.XtraBars.Navigation.AccordionControlElement gStock;
        public DevExpress.XtraBars.Navigation.AccordionControlElement gAccounting;
        public DevExpress.XtraBars.Navigation.AccordionControlElement gBasic_Data;
        private System.Windows.Forms.Panel pn_contaner;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_not;
        private DevExpress.XtraEditors.SimpleButton btn_min;
        private DevExpress.XtraEditors.SimpleButton btn_max;
        private System.Windows.Forms.Label lbl_titlepage;
        private DevExpress.XtraBars.Navigation.AccordionControlElement gHome;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sales_transactions;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
    }
}