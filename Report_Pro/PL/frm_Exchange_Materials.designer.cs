namespace Report_Pro.PL
{
    partial class frm_Exchange_Materials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Exchange_Materials));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.BtnEmail = new DevComponents.DotNetBar.ButtonItem();
            this.BtnAttache = new DevComponents.DotNetBar.ButtonItem();
            this.BtnCalc = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel6 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_cyear = new DevComponents.DotNetBar.LabelX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.AccSer_No = new System.Windows.Forms.TextBox();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.userID = new DevComponents.DotNetBar.LabelX();
            this.txt_InvSM = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_transaction_code = new DevComponents.DotNetBar.LabelX();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.Request_Year = new System.Windows.Forms.TextBox();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.requset_Ser = new System.Windows.Forms.TextBox();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.txt_MainNote = new System.Windows.Forms.TextBox();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tabItem6 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.dgv_R = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ser_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requested_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requested_Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requested_Balance_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.labelX51 = new DevComponents.DotNetBar.LabelX();
            this.Doc_Name = new System.Windows.Forms.Label();
            this.next_ = new System.Windows.Forms.PictureBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.previous_ = new System.Windows.Forms.PictureBox();
            this.first_ = new System.Windows.Forms.PictureBox();
            this.txt_InvDate = new System.Windows.Forms.DateTimePicker();
            this.last_ = new System.Windows.Forms.PictureBox();
            this.txt_serNo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delivry_Grid1 = new Report_Pro.MyControls.Delivry_Grid();
            this.Branch = new Report_Pro.MyControls.UC_Branch();
            this.txtStoreMan = new Report_Pro.MyControls.UC_cost();
            this.Cost_Center = new Report_Pro.MyControls.UC_cost();
            this.requset_Branch = new Report_Pro.MyControls.UC_Branch();
            this.groupPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            resources.ApplyResources(this.ribbonBar1, "ribbonBar1");
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BNew,
            this.BSave,
            this.buttonItem1,
            this.BtnEmail,
            this.BtnAttache,
            this.BtnCalc,
            this.BExit});
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TitleVisible = false;
            this.ribbonBar1.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // BNew
            // 
            resources.ApplyResources(this.BNew, "BNew");
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BNew.Image = ((System.Drawing.Image)(resources.GetObject("BNew.Image")));
            this.BNew.ImagePaddingHorizontal = 15;
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // BSave
            // 
            resources.ApplyResources(this.BSave, "BSave");
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSave.Image = ((System.Drawing.Image)(resources.GetObject("BSave.Image")));
            this.BSave.ImagePaddingHorizontal = 15;
            this.BSave.Name = "BSave";
            this.BSave.SubItemsExpandWidth = 14;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // buttonItem1
            // 
            resources.ApplyResources(this.buttonItem1, "buttonItem1");
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImagePaddingHorizontal = 15;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // BtnEmail
            // 
            resources.ApplyResources(this.BtnEmail, "BtnEmail");
            this.BtnEmail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnEmail.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmail.Image")));
            this.BtnEmail.ImagePaddingHorizontal = 15;
            this.BtnEmail.Name = "BtnEmail";
            this.BtnEmail.SubItemsExpandWidth = 14;
            this.BtnEmail.Click += new System.EventHandler(this.BtnEmail_Click);
            // 
            // BtnAttache
            // 
            resources.ApplyResources(this.BtnAttache, "BtnAttache");
            this.BtnAttache.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnAttache.Image = ((System.Drawing.Image)(resources.GetObject("BtnAttache.Image")));
            this.BtnAttache.ImagePaddingHorizontal = 15;
            this.BtnAttache.Name = "BtnAttache";
            this.BtnAttache.SubItemsExpandWidth = 14;
            // 
            // BtnCalc
            // 
            resources.ApplyResources(this.BtnCalc, "BtnCalc");
            this.BtnCalc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnCalc.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalc.Image")));
            this.BtnCalc.ImagePaddingHorizontal = 15;
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.SubItemsExpandWidth = 14;
            // 
            // BExit
            // 
            resources.ApplyResources(this.BExit, "BExit");
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BExit.Image = ((System.Drawing.Image)(resources.GetObject("BExit.Image")));
            this.BExit.ImagePaddingHorizontal = 15;
            this.BExit.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.BExit.Name = "BExit";
            this.BExit.SubItemsExpandWidth = 14;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // groupPanel6
            // 
            resources.ApplyResources(this.groupPanel6, "groupPanel6");
            this.groupPanel6.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel6.Controls.Add(this.txt_cyear);
            this.groupPanel6.Controls.Add(this.buttonX2);
            this.groupPanel6.Controls.Add(this.buttonX1);
            this.groupPanel6.Controls.Add(this.AccSer_No);
            this.groupPanel6.Controls.Add(this.labelX8);
            this.groupPanel6.Controls.Add(this.userID);
            this.groupPanel6.Controls.Add(this.txt_InvSM);
            this.groupPanel6.Controls.Add(this.labelX5);
            this.groupPanel6.Controls.Add(this.txt_transaction_code);
            this.groupPanel6.Controls.Add(this.tabControl1);
            this.groupPanel6.Controls.Add(this.labelX51);
            this.groupPanel6.Controls.Add(this.Doc_Name);
            this.groupPanel6.Controls.Add(this.next_);
            this.groupPanel6.Controls.Add(this.labelX1);
            this.groupPanel6.Controls.Add(this.labelX2);
            this.groupPanel6.Controls.Add(this.previous_);
            this.groupPanel6.Controls.Add(this.first_);
            this.groupPanel6.Controls.Add(this.txt_InvDate);
            this.groupPanel6.Controls.Add(this.last_);
            this.groupPanel6.Controls.Add(this.txt_serNo);
            this.groupPanel6.Name = "groupPanel6";
            // 
            // 
            // 
            this.groupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel6.Style.BackColorGradientAngle = 90;
            this.groupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderBottomWidth = 1;
            this.groupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderLeftWidth = 1;
            this.groupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderRightWidth = 1;
            this.groupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderTopWidth = 1;
            this.groupPanel6.Style.CornerDiameter = 4;
            this.groupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel6.Click += new System.EventHandler(this.groupPanel6_Click);
            // 
            // txt_cyear
            // 
            resources.ApplyResources(this.txt_cyear, "txt_cyear");
            this.txt_cyear.BackColor = System.Drawing.Color.MistyRose;
            this.txt_cyear.Name = "txt_cyear";
            // 
            // buttonX2
            // 
            resources.ApplyResources(this.buttonX2, "buttonX2");
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            resources.ApplyResources(this.buttonX1, "buttonX1");
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // AccSer_No
            // 
            resources.ApplyResources(this.AccSer_No, "AccSer_No");
            this.AccSer_No.BackColor = System.Drawing.SystemColors.Window;
            this.AccSer_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccSer_No.Name = "AccSer_No";
            this.AccSer_No.ReadOnly = true;
            this.AccSer_No.TabStop = false;
            // 
            // labelX8
            // 
            resources.ApplyResources(this.labelX8, "labelX8");
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Name = "labelX8";
            // 
            // userID
            // 
            resources.ApplyResources(this.userID, "userID");
            this.userID.BackColor = System.Drawing.Color.MistyRose;
            this.userID.Name = "userID";
            // 
            // txt_InvSM
            // 
            resources.ApplyResources(this.txt_InvSM, "txt_InvSM");
            this.txt_InvSM.BackColor = System.Drawing.Color.MistyRose;
            this.txt_InvSM.Name = "txt_InvSM";
            // 
            // labelX5
            // 
            resources.ApplyResources(this.labelX5, "labelX5");
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Name = "labelX5";
            // 
            // txt_transaction_code
            // 
            resources.ApplyResources(this.txt_transaction_code, "txt_transaction_code");
            this.txt_transaction_code.BackColor = System.Drawing.Color.MistyRose;
            this.txt_transaction_code.Name = "txt_transaction_code";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem6);
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabControlPanel2
            // 
            resources.ApplyResources(this.tabControlPanel2, "tabControlPanel2");
            this.tabControlPanel2.Controls.Add(this.Request_Year);
            this.tabControlPanel2.Controls.Add(this.labelX12);
            this.tabControlPanel2.Controls.Add(this.labelX4);
            this.tabControlPanel2.Controls.Add(this.labelX13);
            this.tabControlPanel2.Controls.Add(this.requset_Ser);
            this.tabControlPanel2.Controls.Add(this.labelX9);
            this.tabControlPanel2.Controls.Add(this.labelX20);
            this.tabControlPanel2.Controls.Add(this.txt_MainNote);
            this.tabControlPanel2.Controls.Add(this.labelX11);
            this.tabControlPanel2.Controls.Add(this.labelX3);
            this.tabControlPanel2.Controls.Add(this.Branch);
            this.tabControlPanel2.Controls.Add(this.txtStoreMan);
            this.tabControlPanel2.Controls.Add(this.Cost_Center);
            this.tabControlPanel2.Controls.Add(this.requset_Branch);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabItem = this.tabItem6;
            this.tabControlPanel2.Click += new System.EventHandler(this.tabControlPanel2_Click);
            // 
            // Request_Year
            // 
            resources.ApplyResources(this.Request_Year, "Request_Year");
            this.Request_Year.BackColor = System.Drawing.SystemColors.Window;
            this.Request_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Request_Year.Name = "Request_Year";
            this.Request_Year.ReadOnly = true;
            this.Request_Year.TabStop = false;
            // 
            // labelX12
            // 
            resources.ApplyResources(this.labelX12, "labelX12");
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            this.labelX12.Name = "labelX12";
            // 
            // labelX4
            // 
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Name = "labelX4";
            // 
            // labelX13
            // 
            resources.ApplyResources(this.labelX13, "labelX13");
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            this.labelX13.Name = "labelX13";
            // 
            // requset_Ser
            // 
            resources.ApplyResources(this.requset_Ser, "requset_Ser");
            this.requset_Ser.BackColor = System.Drawing.SystemColors.Window;
            this.requset_Ser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requset_Ser.Name = "requset_Ser";
            this.requset_Ser.ReadOnly = true;
            this.requset_Ser.TabStop = false;
            // 
            // labelX9
            // 
            resources.ApplyResources(this.labelX9, "labelX9");
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Name = "labelX9";
            // 
            // labelX20
            // 
            resources.ApplyResources(this.labelX20, "labelX20");
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            this.labelX20.Name = "labelX20";
            // 
            // txt_MainNote
            // 
            resources.ApplyResources(this.txt_MainNote, "txt_MainNote");
            this.txt_MainNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MainNote.Name = "txt_MainNote";
            // 
            // labelX11
            // 
            resources.ApplyResources(this.labelX11, "labelX11");
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            this.labelX11.Name = "labelX11";
            // 
            // labelX3
            // 
            resources.ApplyResources(this.labelX3, "labelX3");
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Name = "labelX3";
            // 
            // tabItem6
            // 
            this.tabItem6.AttachedControl = this.tabControlPanel2;
            this.tabItem6.Name = "tabItem6";
            resources.ApplyResources(this.tabItem6, "tabItem6");
            // 
            // tabControlPanel1
            // 
            resources.ApplyResources(this.tabControlPanel1, "tabControlPanel1");
            this.tabControlPanel1.Controls.Add(this.dgv_R);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // dgv_R
            // 
            resources.ApplyResources(this.dgv_R, "dgv_R");
            this.dgv_R.AllowUserToAddRows = false;
            this.dgv_R.AllowUserToDeleteRows = false;
            this.dgv_R.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_R.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ser_no,
            this.Requested_Date,
            this.Branch_Code,
            this.Requested_Branch,
            this.Item_Code,
            this.Item_Description,
            this.Requested_Balance_Qty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_R.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_R.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_R.Name = "dgv_R";
            this.dgv_R.ReadOnly = true;
            this.dgv_R.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_R.DoubleClick += new System.EventHandler(this.dgv_R_DoubleClick);
            // 
            // ser_no
            // 
            resources.ApplyResources(this.ser_no, "ser_no");
            this.ser_no.Name = "ser_no";
            this.ser_no.ReadOnly = true;
            // 
            // Requested_Date
            // 
            resources.ApplyResources(this.Requested_Date, "Requested_Date");
            this.Requested_Date.Name = "Requested_Date";
            this.Requested_Date.ReadOnly = true;
            // 
            // Branch_Code
            // 
            resources.ApplyResources(this.Branch_Code, "Branch_Code");
            this.Branch_Code.Name = "Branch_Code";
            this.Branch_Code.ReadOnly = true;
            // 
            // Requested_Branch
            // 
            this.Requested_Branch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Requested_Branch, "Requested_Branch");
            this.Requested_Branch.Name = "Requested_Branch";
            this.Requested_Branch.ReadOnly = true;
            // 
            // Item_Code
            // 
            resources.ApplyResources(this.Item_Code, "Item_Code");
            this.Item_Code.Name = "Item_Code";
            this.Item_Code.ReadOnly = true;
            // 
            // Item_Description
            // 
            resources.ApplyResources(this.Item_Description, "Item_Description");
            this.Item_Description.Name = "Item_Description";
            this.Item_Description.ReadOnly = true;
            // 
            // Requested_Balance_Qty
            // 
            resources.ApplyResources(this.Requested_Balance_Qty, "Requested_Balance_Qty");
            this.Requested_Balance_Qty.Name = "Requested_Balance_Qty";
            this.Requested_Balance_Qty.ReadOnly = true;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            resources.ApplyResources(this.tabItem1, "tabItem1");
            this.tabItem1.Click += new System.EventHandler(this.tabControlPanel2_Click);
            // 
            // labelX51
            // 
            resources.ApplyResources(this.labelX51, "labelX51");
            this.labelX51.BackColor = System.Drawing.Color.Transparent;
            this.labelX51.Name = "labelX51";
            // 
            // Doc_Name
            // 
            resources.ApplyResources(this.Doc_Name, "Doc_Name");
            this.Doc_Name.BackColor = System.Drawing.SystemColors.Info;
            this.Doc_Name.Name = "Doc_Name";
            // 
            // next_
            // 
            resources.ApplyResources(this.next_, "next_");
            this.next_.BackColor = System.Drawing.Color.MistyRose;
            this.next_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.next_.Name = "next_";
            this.next_.TabStop = false;
            // 
            // labelX1
            // 
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Name = "labelX1";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // labelX2
            // 
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Name = "labelX2";
            // 
            // previous_
            // 
            resources.ApplyResources(this.previous_, "previous_");
            this.previous_.BackColor = System.Drawing.Color.MistyRose;
            this.previous_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previous_.Name = "previous_";
            this.previous_.TabStop = false;
            // 
            // first_
            // 
            resources.ApplyResources(this.first_, "first_");
            this.first_.BackColor = System.Drawing.Color.MistyRose;
            this.first_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.first_.Name = "first_";
            this.first_.TabStop = false;
            // 
            // txt_InvDate
            // 
            resources.ApplyResources(this.txt_InvDate, "txt_InvDate");
            this.txt_InvDate.Name = "txt_InvDate";
            // 
            // last_
            // 
            resources.ApplyResources(this.last_, "last_");
            this.last_.BackColor = System.Drawing.Color.MistyRose;
            this.last_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.last_.Name = "last_";
            this.last_.TabStop = false;
            // 
            // txt_serNo
            // 
            resources.ApplyResources(this.txt_serNo, "txt_serNo");
            this.txt_serNo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_serNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_serNo.Name = "txt_serNo";
            this.txt_serNo.ReadOnly = true;
            this.txt_serNo.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Name = "panel2";
            // 
            // delivry_Grid1
            // 
            resources.ApplyResources(this.delivry_Grid1, "delivry_Grid1");
            this.delivry_Grid1.Name = "delivry_Grid1";
            // 
            // Branch
            // 
            resources.ApplyResources(this.Branch, "Branch");
            this.Branch.BackColor = System.Drawing.Color.Transparent;
            this.Branch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.Branch.Name = "Branch";
            this.Branch.Load += new System.EventHandler(this.Supply_Branch_Load);
            // 
            // txtStoreMan
            // 
            resources.ApplyResources(this.txtStoreMan, "txtStoreMan");
            this.txtStoreMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreMan.Name = "txtStoreMan";
            // 
            // Cost_Center
            // 
            resources.ApplyResources(this.Cost_Center, "Cost_Center");
            this.Cost_Center.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cost_Center.Name = "Cost_Center";
            // 
            // requset_Branch
            // 
            resources.ApplyResources(this.requset_Branch, "requset_Branch");
            this.requset_Branch.BackColor = System.Drawing.Color.Transparent;
            this.requset_Branch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requset_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.requset_Branch.Name = "requset_Branch";
            this.requset_Branch.Load += new System.EventHandler(this.Uc_Branch_Load);
            this.requset_Branch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Uc_Branch_KeyUp);
            // 
            // frm_Exchange_Materials
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.delivry_Grid1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupPanel6);
            this.Controls.Add(this.ribbonBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Exchange_Materials";
            this.Load += new System.EventHandler(this.frm_R_Qutaion_Load);
            this.groupPanel6.ResumeLayout(false);
            this.groupPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel2.PerformLayout();
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem BtnEmail;
        private DevComponents.DotNetBar.ButtonItem BtnAttache;
        private DevComponents.DotNetBar.ButtonItem BtnCalc;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel6;
        private DevComponents.DotNetBar.LabelX labelX51;
        private System.Windows.Forms.Label Doc_Name;
        internal System.Windows.Forms.PictureBox previous_;
        private System.Windows.Forms.TextBox txt_serNo;
        internal System.Windows.Forms.PictureBox first_;
        private DevComponents.DotNetBar.LabelX labelX1;
        internal System.Windows.Forms.PictureBox next_;
        private DevComponents.DotNetBar.LabelX labelX2;
        internal System.Windows.Forms.PictureBox last_;
        private System.Windows.Forms.DateTimePicker txt_InvDate;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem6;
        private DevComponents.DotNetBar.LabelX txt_transaction_code;
        private MyControls.UC_Branch requset_Branch;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX20;
        private System.Windows.Forms.TextBox txt_MainNote;
        private MyControls.UC_cost Cost_Center;
        private MyControls.UC_cost txtStoreMan;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX userID;
        private DevComponents.DotNetBar.LabelX txt_InvSM;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private MyControls.UC_Branch Branch;
        private MyControls.Delivry_Grid delivry_Grid1;
        private System.Windows.Forms.TextBox AccSer_No;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_R;
        private System.Windows.Forms.DataGridViewTextBoxColumn ser_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requested_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requested_Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requested_Balance_Qty;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.TextBox requset_Ser;
        private DevComponents.DotNetBar.LabelX labelX12;
        private System.Windows.Forms.TextBox Request_Year;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX txt_cyear;
    }
}