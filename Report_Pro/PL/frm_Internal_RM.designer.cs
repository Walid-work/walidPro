namespace Report_Pro.PL
{
    partial class frm_Internal_RM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Internal_RM));
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.BtnEmail = new DevComponents.DotNetBar.ButtonItem();
            this.BtnAttache = new DevComponents.DotNetBar.ButtonItem();
            this.BtnCalc = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel6 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.userID = new DevComponents.DotNetBar.LabelX();
            this.txt_InvSM = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_transaction_code = new DevComponents.DotNetBar.LabelX();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.txt_MainNote = new System.Windows.Forms.TextBox();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tabItem6 = new DevComponents.DotNetBar.TabItem(this.components);
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
            this.Supply_Branch = new Report_Pro.MyControls.UC_Branch();
            this.txtRequst_p = new Report_Pro.MyControls.UC_cost();
            this.uC_cost1 = new Report_Pro.MyControls.UC_cost();
            this.Uc_Branch = new Report_Pro.MyControls.UC_Branch();
            this.groupPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
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
            this.groupPanel6.Controls.Add(this.buttonX1);
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
            // buttonX1
            // 
            resources.ApplyResources(this.buttonX1, "buttonX1");
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // userID
            // 
            resources.ApplyResources(this.userID, "userID");
            this.userID.BackColor = System.Drawing.Color.MistyRose;
            this.userID.Name = "userID";
            this.userID.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txt_InvSM
            // 
            resources.ApplyResources(this.txt_InvSM, "txt_InvSM");
            this.txt_InvSM.BackColor = System.Drawing.Color.MistyRose;
            this.txt_InvSM.Name = "txt_InvSM";
            this.txt_InvSM.TextAlignment = System.Drawing.StringAlignment.Center;
            this.txt_InvSM.Click += new System.EventHandler(this.txt_InvSM_Click);
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
            this.txt_transaction_code.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem6);
            // 
            // tabControlPanel2
            // 
            resources.ApplyResources(this.tabControlPanel2, "tabControlPanel2");
            this.tabControlPanel2.Controls.Add(this.labelX4);
            this.tabControlPanel2.Controls.Add(this.labelX13);
            this.tabControlPanel2.Controls.Add(this.labelX20);
            this.tabControlPanel2.Controls.Add(this.txt_MainNote);
            this.tabControlPanel2.Controls.Add(this.labelX11);
            this.tabControlPanel2.Controls.Add(this.labelX3);
            this.tabControlPanel2.Controls.Add(this.Supply_Branch);
            this.tabControlPanel2.Controls.Add(this.txtRequst_p);
            this.tabControlPanel2.Controls.Add(this.uC_cost1);
            this.tabControlPanel2.Controls.Add(this.Uc_Branch);
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
            // Supply_Branch
            // 
            resources.ApplyResources(this.Supply_Branch, "Supply_Branch");
            this.Supply_Branch.BackColor = System.Drawing.Color.Transparent;
            this.Supply_Branch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Supply_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.Supply_Branch.Name = "Supply_Branch";
            this.Supply_Branch.Load += new System.EventHandler(this.Supply_Branch_Load);
            // 
            // txtRequst_p
            // 
            resources.ApplyResources(this.txtRequst_p, "txtRequst_p");
            this.txtRequst_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequst_p.Name = "txtRequst_p";
            // 
            // uC_cost1
            // 
            resources.ApplyResources(this.uC_cost1, "uC_cost1");
            this.uC_cost1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_cost1.Name = "uC_cost1";
            // 
            // Uc_Branch
            // 
            resources.ApplyResources(this.Uc_Branch, "Uc_Branch");
            this.Uc_Branch.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Branch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Uc_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.Uc_Branch.Name = "Uc_Branch";
            this.Uc_Branch.Load += new System.EventHandler(this.Uc_Branch_Load);
            this.Uc_Branch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Uc_Branch_KeyUp);
            // 
            // frm_Internal_RM
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
            this.Name = "frm_Internal_RM";
            this.Load += new System.EventHandler(this.frm_R_Qutaion_Load);
            this.groupPanel6.ResumeLayout(false);
            this.groupPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel2.PerformLayout();
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
        private MyControls.UC_Branch Uc_Branch;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX20;
        private System.Windows.Forms.TextBox txt_MainNote;
        private MyControls.UC_cost uC_cost1;
        private MyControls.UC_cost txtRequst_p;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX userID;
        private DevComponents.DotNetBar.LabelX txt_InvSM;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private MyControls.UC_Branch Supply_Branch;
        private MyControls.Delivry_Grid delivry_Grid1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}