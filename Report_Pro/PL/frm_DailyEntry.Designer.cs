namespace Report_Pro.PL
{
    partial class frm_DailyEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DailyEntry));
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.BEdit = new DevComponents.DotNetBar.ButtonItem();
            this.BSearch = new DevComponents.DotNetBar.ButtonItem();
            this.BtnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.BtnEmail = new DevComponents.DotNetBar.ButtonItem();
            this.BtnAttache = new DevComponents.DotNetBar.ButtonItem();
            this.BtnCalc = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtCyear = new DevComponents.DotNetBar.LabelX();
            this.txtUserID = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btn_ChoseCompamy = new System.Windows.Forms.Button();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtBranchName = new DevComponents.DotNetBar.LabelX();
            this.txtBranchCode = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txt_sp_ser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtDate_H = new System.Windows.Forms.MaskedTextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMainNote = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSerNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Main_serNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.previous_ = new System.Windows.Forms.PictureBox();
            this.first_ = new System.Windows.Forms.PictureBox();
            this.next_ = new System.Windows.Forms.PictureBox();
            this.last_ = new System.Windows.Forms.PictureBox();
            this.jorDebit1 = new Report_Pro.MyControls.jorDebit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previous_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_)).BeginInit();
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
            this.BEdit,
            this.BSearch,
            this.BtnPrint,
            this.BtnEmail,
            this.BtnAttache,
            this.BtnCalc,
            this.BExit});
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TitleVisible = false;
            // 
            // BNew
            // 
            resources.ApplyResources(this.BNew, "BNew");
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BNew.Image = global::Report_Pro.Properties.Resources.Add_Icon;
            this.BNew.ImagePaddingHorizontal = 15;
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            // 
            // BSave
            // 
            resources.ApplyResources(this.BSave, "BSave");
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSave.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.BSave.ImagePaddingHorizontal = 15;
            this.BSave.Name = "BSave";
            this.BSave.SubItemsExpandWidth = 14;
            // 
            // BEdit
            // 
            resources.ApplyResources(this.BEdit, "BEdit");
            this.BEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BEdit.Enabled = false;
            this.BEdit.FontBold = true;
            this.BEdit.Image = global::Report_Pro.Properties.Resources.update;
            this.BEdit.ImagePaddingHorizontal = 15;
            this.BEdit.Name = "BEdit";
            this.BEdit.SubItemsExpandWidth = 14;
            // 
            // BSearch
            // 
            resources.ApplyResources(this.BSearch, "BSearch");
            this.BSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSearch.Image = global::Report_Pro.Properties.Resources.search_16;
            this.BSearch.ImagePaddingHorizontal = 15;
            this.BSearch.Name = "BSearch";
            this.BSearch.SubItemsExpandWidth = 14;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // BtnPrint
            // 
            resources.ApplyResources(this.BtnPrint, "BtnPrint");
            this.BtnPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnPrint.Image = global::Report_Pro.Properties.Resources.printer_icon;
            this.BtnPrint.ImagePaddingHorizontal = 15;
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.SubItemsExpandWidth = 14;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnEmail
            // 
            resources.ApplyResources(this.BtnEmail, "BtnEmail");
            this.BtnEmail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnEmail.Image = global::Report_Pro.Properties.Resources.Mail_icon;
            this.BtnEmail.ImagePaddingHorizontal = 15;
            this.BtnEmail.Name = "BtnEmail";
            this.BtnEmail.SubItemsExpandWidth = 14;
            // 
            // BtnAttache
            // 
            resources.ApplyResources(this.BtnAttache, "BtnAttache");
            this.BtnAttache.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnAttache.Image = global::Report_Pro.Properties.Resources.Attachment_icon1;
            this.BtnAttache.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.BtnAttache.ImagePaddingHorizontal = 15;
            this.BtnAttache.Name = "BtnAttache";
            this.BtnAttache.SubItemsExpandWidth = 14;
            // 
            // BtnCalc
            // 
            resources.ApplyResources(this.BtnCalc, "BtnCalc");
            this.BtnCalc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnCalc.Image = global::Report_Pro.Properties.Resources.CalcImg;
            this.BtnCalc.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.BtnCalc.ImagePaddingHorizontal = 15;
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.SubItemsExpandWidth = 14;
            // 
            // BExit
            // 
            resources.ApplyResources(this.BExit, "BExit");
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BExit.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.BExit.ImagePaddingHorizontal = 15;
            this.BExit.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.BExit.Name = "BExit";
            this.BExit.SubItemsExpandWidth = 14;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // groupPanel1
            // 
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtCyear);
            this.groupPanel1.Controls.Add(this.txtUserID);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.btn_ChoseCompamy);
            this.groupPanel1.Controls.Add(this.buttonX3);
            this.groupPanel1.Controls.Add(this.buttonX2);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.txtBranchName);
            this.groupPanel1.Controls.Add(this.txtBranchCode);
            this.groupPanel1.Controls.Add(this.labelX20);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.txt_sp_ser);
            this.groupPanel1.Controls.Add(this.txtDate);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txtDate_H);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtMainNote);
            this.groupPanel1.Controls.Add(this.txtSerNo);
            this.groupPanel1.Controls.Add(this.Main_serNo);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.previous_);
            this.groupPanel1.Controls.Add(this.first_);
            this.groupPanel1.Controls.Add(this.next_);
            this.groupPanel1.Controls.Add(this.last_);
            this.groupPanel1.Name = "groupPanel1";
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
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // txtCyear
            // 
            resources.ApplyResources(this.txtCyear, "txtCyear");
            this.txtCyear.BackColor = System.Drawing.SystemColors.Info;
            this.txtCyear.Name = "txtCyear";
            // 
            // txtUserID
            // 
            resources.ApplyResources(this.txtUserID, "txtUserID");
            this.txtUserID.BackColor = System.Drawing.SystemColors.Info;
            this.txtUserID.Name = "txtUserID";
            // 
            // labelX3
            // 
            resources.ApplyResources(this.labelX3, "labelX3");
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Name = "labelX3";
            // 
            // btn_ChoseCompamy
            // 
            resources.ApplyResources(this.btn_ChoseCompamy, "btn_ChoseCompamy");
            this.btn_ChoseCompamy.BackColor = System.Drawing.Color.Beige;
            this.btn_ChoseCompamy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_ChoseCompamy.Name = "btn_ChoseCompamy";
            this.btn_ChoseCompamy.UseVisualStyleBackColor = false;
            this.btn_ChoseCompamy.Click += new System.EventHandler(this.btn_ChoseCompamy_Click);
            // 
            // buttonX3
            // 
            resources.ApplyResources(this.buttonX3, "buttonX3");
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
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
            // txtBranchName
            // 
            resources.ApplyResources(this.txtBranchName, "txtBranchName");
            this.txtBranchName.BackColor = System.Drawing.SystemColors.Info;
            this.txtBranchName.Name = "txtBranchName";
            // 
            // txtBranchCode
            // 
            resources.ApplyResources(this.txtBranchCode, "txtBranchCode");
            this.txtBranchCode.BackColor = System.Drawing.SystemColors.Info;
            this.txtBranchCode.Name = "txtBranchCode";
            // 
            // labelX20
            // 
            resources.ApplyResources(this.labelX20, "labelX20");
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            this.labelX20.Name = "labelX20";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Name = "label1";
            // 
            // labelX9
            // 
            resources.ApplyResources(this.labelX9, "labelX9");
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Name = "labelX9";
            // 
            // txt_sp_ser
            // 
            resources.ApplyResources(this.txt_sp_ser, "txt_sp_ser");
            // 
            // 
            // 
            this.txt_sp_ser.Border.Class = "TextBoxBorder";
            this.txt_sp_ser.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txt_sp_ser.ButtonCustom.DisplayPosition")));
            this.txt_sp_ser.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txt_sp_ser.ButtonCustom.Image")));
            this.txt_sp_ser.ButtonCustom.Text = resources.GetString("txt_sp_ser.ButtonCustom.Text");
            this.txt_sp_ser.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txt_sp_ser.ButtonCustom2.DisplayPosition")));
            this.txt_sp_ser.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txt_sp_ser.ButtonCustom2.Image")));
            this.txt_sp_ser.ButtonCustom2.Text = resources.GetString("txt_sp_ser.ButtonCustom2.Text");
            this.txt_sp_ser.Name = "txt_sp_ser";
            // 
            // txtDate
            // 
            resources.ApplyResources(this.txtDate, "txtDate");
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Name = "txtDate";
            // 
            // labelX5
            // 
            resources.ApplyResources(this.labelX5, "labelX5");
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Name = "labelX5";
            // 
            // labelX4
            // 
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Name = "labelX4";
            // 
            // txtDate_H
            // 
            resources.ApplyResources(this.txtDate_H, "txtDate_H");
            this.txtDate_H.Name = "txtDate_H";
            this.txtDate_H.ValidatingType = typeof(System.DateTime);
            // 
            // labelX1
            // 
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Name = "labelX1";
            // 
            // txtMainNote
            // 
            resources.ApplyResources(this.txtMainNote, "txtMainNote");
            // 
            // 
            // 
            this.txtMainNote.Border.Class = "TextBoxBorder";
            this.txtMainNote.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtMainNote.ButtonCustom.DisplayPosition")));
            this.txtMainNote.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtMainNote.ButtonCustom.Image")));
            this.txtMainNote.ButtonCustom.Text = resources.GetString("txtMainNote.ButtonCustom.Text");
            this.txtMainNote.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtMainNote.ButtonCustom2.DisplayPosition")));
            this.txtMainNote.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtMainNote.ButtonCustom2.Image")));
            this.txtMainNote.ButtonCustom2.Text = resources.GetString("txtMainNote.ButtonCustom2.Text");
            this.txtMainNote.Name = "txtMainNote";
            // 
            // txtSerNo
            // 
            resources.ApplyResources(this.txtSerNo, "txtSerNo");
            // 
            // 
            // 
            this.txtSerNo.Border.Class = "TextBoxBorder";
            this.txtSerNo.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtSerNo.ButtonCustom.DisplayPosition")));
            this.txtSerNo.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtSerNo.ButtonCustom.Image")));
            this.txtSerNo.ButtonCustom.Text = resources.GetString("txtSerNo.ButtonCustom.Text");
            this.txtSerNo.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtSerNo.ButtonCustom2.DisplayPosition")));
            this.txtSerNo.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtSerNo.ButtonCustom2.Image")));
            this.txtSerNo.ButtonCustom2.Text = resources.GetString("txtSerNo.ButtonCustom2.Text");
            this.txtSerNo.Name = "txtSerNo";
            // 
            // Main_serNo
            // 
            resources.ApplyResources(this.Main_serNo, "Main_serNo");
            // 
            // 
            // 
            this.Main_serNo.Border.Class = "TextBoxBorder";
            this.Main_serNo.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("Main_serNo.ButtonCustom.DisplayPosition")));
            this.Main_serNo.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("Main_serNo.ButtonCustom.Image")));
            this.Main_serNo.ButtonCustom.Text = resources.GetString("Main_serNo.ButtonCustom.Text");
            this.Main_serNo.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("Main_serNo.ButtonCustom2.DisplayPosition")));
            this.Main_serNo.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("Main_serNo.ButtonCustom2.Image")));
            this.Main_serNo.ButtonCustom2.Text = resources.GetString("Main_serNo.ButtonCustom2.Text");
            this.Main_serNo.Name = "Main_serNo";
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
            // previous_
            // 
            resources.ApplyResources(this.previous_, "previous_");
            this.previous_.BackColor = System.Drawing.Color.Transparent;
            this.previous_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previous_.Name = "previous_";
            this.previous_.TabStop = false;
            // 
            // first_
            // 
            resources.ApplyResources(this.first_, "first_");
            this.first_.BackColor = System.Drawing.Color.Transparent;
            this.first_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.first_.Name = "first_";
            this.first_.TabStop = false;
            // 
            // next_
            // 
            resources.ApplyResources(this.next_, "next_");
            this.next_.BackColor = System.Drawing.Color.Transparent;
            this.next_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.next_.Name = "next_";
            this.next_.TabStop = false;
            // 
            // last_
            // 
            resources.ApplyResources(this.last_, "last_");
            this.last_.BackColor = System.Drawing.Color.Transparent;
            this.last_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.last_.Name = "last_";
            this.last_.TabStop = false;
            // 
            // jorDebit1
            // 
            resources.ApplyResources(this.jorDebit1, "jorDebit1");
            this.jorDebit1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.jorDebit1.Name = "jorDebit1";
            this.jorDebit1.Load += new System.EventHandler(this.jorDebit1_Load);
            // 
            // frm_DailyEntry
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.jorDebit1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.ribbonBar1);
            this.Name = "frm_DailyEntry";
            this.Load += new System.EventHandler(this.frm_DailyEntry_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previous_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem BEdit;
        private DevComponents.DotNetBar.ButtonItem BSearch;
        private DevComponents.DotNetBar.ButtonItem BtnPrint;
        private DevComponents.DotNetBar.ButtonItem BtnEmail;
        private DevComponents.DotNetBar.ButtonItem BtnAttache;
        private DevComponents.DotNetBar.ButtonItem BtnCalc;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private MyControls.jorDebit jorDebit1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX txtBranchName;
        private DevComponents.DotNetBar.LabelX txtBranchCode;
        private DevComponents.DotNetBar.LabelX labelX20;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sp_ser;
        private System.Windows.Forms.DateTimePicker txtDate;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.MaskedTextBox txtDate_H;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMainNote;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerNo;
        private DevComponents.DotNetBar.Controls.TextBoxX Main_serNo;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        internal System.Windows.Forms.PictureBox previous_;
        internal System.Windows.Forms.PictureBox first_;
        internal System.Windows.Forms.PictureBox next_;
        internal System.Windows.Forms.PictureBox last_;
        private System.Windows.Forms.Button btn_ChoseCompamy;
        private DevComponents.DotNetBar.LabelX txtUserID;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX txtCyear;
    }
}