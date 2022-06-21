namespace Report_Pro.PL
{
    partial class frmEntryJornal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntryJornal));
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
            this.txt_docId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Cyear = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSanad_type = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtSer_code = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBranchName = new DevComponents.DotNetBar.LabelX();
            this.txtBranchCode = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.btn_Srearch = new System.Windows.Forms.Button();
            this.btn_Cancl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txt_sp_ser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.mTxt_H = new System.Windows.Forms.MaskedTextBox();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.jor_Row1 = new Report_Pro.MyControls.Jor_Row();
            this.jor_Row2 = new Report_Pro.MyControls.Jor_Row();
            this.jor_Row3 = new Report_Pro.MyControls.Jor_Row();
            this.jor_Row4 = new Report_Pro.MyControls.Jor_Row();
            this.jorHead1 = new Report_Pro.MyControls.JorHead();
            this.groupPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previous_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.BtnPrint,
            this.BtnEmail,
            this.BtnAttache,
            this.BtnCalc,
            this.BExit});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(1215, 29);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 102;
            this.ribbonBar1.Text = "ribbonBar1";
            this.ribbonBar1.TitleVisible = false;
            // 
            // BNew
            // 
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BNew.Image = global::Report_Pro.Properties.Resources.Add_Icon;
            this.BNew.ImagePaddingHorizontal = 15;
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            this.BNew.Text = "جديد";
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // BSave
            // 
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSave.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.BSave.ImagePaddingHorizontal = 15;
            this.BSave.Name = "BSave";
            this.BSave.SubItemsExpandWidth = 14;
            this.BSave.Text = "حفظ";
            // 
            // BEdit
            // 
            this.BEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BEdit.Enabled = false;
            this.BEdit.FontBold = true;
            this.BEdit.Image = global::Report_Pro.Properties.Resources.update;
            this.BEdit.ImagePaddingHorizontal = 15;
            this.BEdit.Name = "BEdit";
            this.BEdit.SubItemsExpandWidth = 14;
            this.BEdit.Text = "تعديل";
            // 
            // BSearch
            // 
            this.BSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSearch.Image = global::Report_Pro.Properties.Resources.search_16;
            this.BSearch.ImagePaddingHorizontal = 15;
            this.BSearch.Name = "BSearch";
            this.BSearch.SubItemsExpandWidth = 14;
            this.BSearch.Text = "بحث";
            // 
            // BtnPrint
            // 
            this.BtnPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnPrint.Image = global::Report_Pro.Properties.Resources.printer_icon;
            this.BtnPrint.ImagePaddingHorizontal = 15;
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.SubItemsExpandWidth = 14;
            this.BtnPrint.Text = "طباعة";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnEmail
            // 
            this.BtnEmail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnEmail.Image = global::Report_Pro.Properties.Resources.Mail_icon;
            this.BtnEmail.ImagePaddingHorizontal = 15;
            this.BtnEmail.Name = "BtnEmail";
            this.BtnEmail.SubItemsExpandWidth = 14;
            this.BtnEmail.Text = "ارسال بالبريد";
            // 
            // BtnAttache
            // 
            this.BtnAttache.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnAttache.Image = global::Report_Pro.Properties.Resources.Attachment_icon1;
            this.BtnAttache.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.BtnAttache.ImagePaddingHorizontal = 15;
            this.BtnAttache.Name = "BtnAttache";
            this.BtnAttache.SubItemsExpandWidth = 14;
            this.BtnAttache.Text = "المرفقات";
            // 
            // BtnCalc
            // 
            this.BtnCalc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnCalc.Image = global::Report_Pro.Properties.Resources.CalcImg;
            this.BtnCalc.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.BtnCalc.ImagePaddingHorizontal = 15;
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.SubItemsExpandWidth = 14;
            this.BtnCalc.Text = "الحاسبة";
            // 
            // BExit
            // 
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BExit.Image = global::Report_Pro.Properties.Resources.deleteAttach_icon;
            this.BExit.ImagePaddingHorizontal = 15;
            this.BExit.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.BExit.Name = "BExit";
            this.BExit.RibbonWordWrap = false;
            this.BExit.SubItemsExpandWidth = 14;
            this.BExit.Text = "خروج";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txt_docId);
            this.groupPanel1.Controls.Add(this.txt_Cyear);
            this.groupPanel1.Controls.Add(this.txtSanad_type);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtSer_code);
            this.groupPanel1.Controls.Add(this.txtBranchName);
            this.groupPanel1.Controls.Add(this.txtBranchCode);
            this.groupPanel1.Controls.Add(this.labelX20);
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.txt_sp_ser);
            this.groupPanel1.Controls.Add(this.dateTimePicker1);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.mTxt_H);
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
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 29);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupPanel1.Size = new System.Drawing.Size(1215, 106);
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
            this.groupPanel1.TabIndex = 103;
            // 
            // txt_docId
            // 
            this.txt_docId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_docId.Border.Class = "TextBoxBorder";
            this.txt_docId.Location = new System.Drawing.Point(484, 2);
            this.txt_docId.Margin = new System.Windows.Forms.Padding(2);
            this.txt_docId.Name = "txt_docId";
            this.txt_docId.ReadOnly = true;
            this.txt_docId.Size = new System.Drawing.Size(33, 20);
            this.txt_docId.TabIndex = 140;
            this.txt_docId.Text = "JOR";
            this.txt_docId.Visible = false;
            // 
            // txt_Cyear
            // 
            this.txt_Cyear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_Cyear.Border.Class = "TextBoxBorder";
            this.txt_Cyear.Location = new System.Drawing.Point(447, 2);
            this.txt_Cyear.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cyear.Name = "txt_Cyear";
            this.txt_Cyear.ReadOnly = true;
            this.txt_Cyear.Size = new System.Drawing.Size(33, 20);
            this.txt_Cyear.TabIndex = 139;
            this.txt_Cyear.Text = "cy";
            this.txt_Cyear.Visible = false;
            // 
            // txtSanad_type
            // 
            this.txtSanad_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSanad_type.Border.Class = "TextBoxBorder";
            this.txtSanad_type.Location = new System.Drawing.Point(536, 2);
            this.txtSanad_type.Margin = new System.Windows.Forms.Padding(2);
            this.txtSanad_type.Name = "txtSanad_type";
            this.txtSanad_type.ReadOnly = true;
            this.txtSanad_type.Size = new System.Drawing.Size(33, 20);
            this.txtSanad_type.TabIndex = 137;
            this.txtSanad_type.Visible = false;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(573, 3);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(53, 17);
            this.labelX3.TabIndex = 136;
            this.labelX3.Text = "نوع الحركة";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX3.Visible = false;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(667, 3);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(38, 17);
            this.labelX2.TabIndex = 135;
            this.labelX2.Text = "المعرف";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX2.Visible = false;
            // 
            // txtSer_code
            // 
            this.txtSer_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSer_code.Border.Class = "TextBoxBorder";
            this.txtSer_code.Location = new System.Drawing.Point(631, 2);
            this.txtSer_code.Margin = new System.Windows.Forms.Padding(2);
            this.txtSer_code.Name = "txtSer_code";
            this.txtSer_code.ReadOnly = true;
            this.txtSer_code.Size = new System.Drawing.Size(33, 20);
            this.txtSer_code.TabIndex = 138;
            this.txtSer_code.Visible = false;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBranchName.BackColor = System.Drawing.Color.Transparent;
            this.txtBranchName.Location = new System.Drawing.Point(819, 49);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBranchName.Size = new System.Drawing.Size(277, 21);
            this.txtBranchName.TabIndex = 134;
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBranchCode.BackColor = System.Drawing.Color.Transparent;
            this.txtBranchCode.Location = new System.Drawing.Point(1096, 52);
            this.txtBranchCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBranchCode.Size = new System.Drawing.Size(51, 15);
            this.txtBranchCode.TabIndex = 133;
            // 
            // labelX20
            // 
            this.labelX20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX20.AutoSize = true;
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            this.labelX20.Location = new System.Drawing.Point(1147, 52);
            this.labelX20.Margin = new System.Windows.Forms.Padding(2);
            this.labelX20.Name = "labelX20";
            this.labelX20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX20.Size = new System.Drawing.Size(36, 17);
            this.labelX20.TabIndex = 132;
            this.labelX20.Text = "الفرع :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.labelX15);
            this.groupBox1.Controls.Add(this.btn_Srearch);
            this.groupBox1.Controls.Add(this.btn_Cancl);
            this.groupBox1.Location = new System.Drawing.Point(146, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(166, 62);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtsearch.Border.Class = "TextBoxBorder";
            this.txtsearch.Location = new System.Drawing.Point(12, 14);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(94, 20);
            this.txtsearch.TabIndex = 128;
            // 
            // labelX15
            // 
            this.labelX15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX15.Location = new System.Drawing.Point(108, 15);
            this.labelX15.Margin = new System.Windows.Forms.Padding(2);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(51, 17);
            this.labelX15.TabIndex = 129;
            this.labelX15.Text = "رقم القيد";
            this.labelX15.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_Srearch
            // 
            this.btn_Srearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Srearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Srearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Srearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Srearch.Location = new System.Drawing.Point(71, 36);
            this.btn_Srearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Srearch.Name = "btn_Srearch";
            this.btn_Srearch.Size = new System.Drawing.Size(53, 17);
            this.btn_Srearch.TabIndex = 130;
            this.btn_Srearch.Text = "بحث";
            this.btn_Srearch.UseVisualStyleBackColor = false;
            // 
            // btn_Cancl
            // 
            this.btn_Cancl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cancl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Cancl.Location = new System.Drawing.Point(15, 36);
            this.btn_Cancl.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancl.Name = "btn_Cancl";
            this.btn_Cancl.Size = new System.Drawing.Size(53, 17);
            this.btn_Cancl.TabIndex = 131;
            this.btn_Cancl.Text = "الغاء";
            this.btn_Cancl.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(979, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 129;
            this.label1.Text = "قيد يومية";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX9
            // 
            this.labelX9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Location = new System.Drawing.Point(475, 75);
            this.labelX9.Margin = new System.Windows.Forms.Padding(2);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(61, 17);
            this.labelX9.TabIndex = 128;
            this.labelX9.Text = "الرقم الخاص";
            // 
            // txt_sp_ser
            // 
            this.txt_sp_ser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_sp_ser.Border.Class = "TextBoxBorder";
            this.txt_sp_ser.Location = new System.Drawing.Point(389, 74);
            this.txt_sp_ser.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sp_ser.Name = "txt_sp_ser";
            this.txt_sp_ser.Size = new System.Drawing.Size(81, 20);
            this.txt_sp_ser.TabIndex = 127;
            this.txt_sp_ser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(609, 29);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker1.TabIndex = 125;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(692, 30);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(76, 17);
            this.labelX5.TabIndex = 61;
            this.labelX5.Text = "التاريخ الميلادي";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(694, 52);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(70, 17);
            this.labelX4.TabIndex = 60;
            this.labelX4.Text = "التاريخ الهجري";
            // 
            // mTxt_H
            // 
            this.mTxt_H.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTxt_H.Location = new System.Drawing.Point(609, 51);
            this.mTxt_H.Margin = new System.Windows.Forms.Padding(2);
            this.mTxt_H.Mask = "00/00/0000";
            this.mTxt_H.Name = "mTxt_H";
            this.mTxt_H.Size = new System.Drawing.Size(82, 20);
            this.mTxt_H.TabIndex = 98;
            this.mTxt_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTxt_H.ValidatingType = typeof(System.DateTime);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(1143, 78);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(47, 17);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ملاحظات";
            // 
            // txtMainNote
            // 
            this.txtMainNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMainNote.Border.Class = "TextBoxBorder";
            this.txtMainNote.Location = new System.Drawing.Point(819, 74);
            this.txtMainNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtMainNote.Name = "txtMainNote";
            this.txtMainNote.Size = new System.Drawing.Size(321, 20);
            this.txtMainNote.TabIndex = 62;
            // 
            // txtSerNo
            // 
            this.txtSerNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSerNo.Border.Class = "TextBoxBorder";
            this.txtSerNo.Location = new System.Drawing.Point(389, 29);
            this.txtSerNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerNo.Name = "txtSerNo";
            this.txtSerNo.Size = new System.Drawing.Size(81, 20);
            this.txtSerNo.TabIndex = 107;
            this.txtSerNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Main_serNo
            // 
            this.Main_serNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Main_serNo.Border.Class = "TextBoxBorder";
            this.Main_serNo.Location = new System.Drawing.Point(389, 51);
            this.Main_serNo.Margin = new System.Windows.Forms.Padding(2);
            this.Main_serNo.Name = "Main_serNo";
            this.Main_serNo.Size = new System.Drawing.Size(81, 20);
            this.Main_serNo.TabIndex = 108;
            this.Main_serNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX6
            // 
            this.labelX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(475, 30);
            this.labelX6.Margin = new System.Windows.Forms.Padding(2);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(47, 17);
            this.labelX6.TabIndex = 106;
            this.labelX6.Text = "رقم القيد";
            // 
            // labelX7
            // 
            this.labelX7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(475, 52);
            this.labelX7.Margin = new System.Windows.Forms.Padding(2);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(53, 17);
            this.labelX7.TabIndex = 105;
            this.labelX7.Text = "رقم السند";
            // 
            // previous_
            // 
            this.previous_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previous_.BackColor = System.Drawing.Color.Transparent;
            this.previous_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previous_.Image = ((System.Drawing.Image)(resources.GetObject("previous_.Image")));
            this.previous_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.previous_.Location = new System.Drawing.Point(1076, 10);
            this.previous_.Margin = new System.Windows.Forms.Padding(2);
            this.previous_.Name = "previous_";
            this.previous_.Size = new System.Drawing.Size(16, 22);
            this.previous_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previous_.TabIndex = 110;
            this.previous_.TabStop = false;
            // 
            // first_
            // 
            this.first_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.first_.BackColor = System.Drawing.Color.Transparent;
            this.first_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.first_.Image = ((System.Drawing.Image)(resources.GetObject("first_.Image")));
            this.first_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.first_.Location = new System.Drawing.Point(1090, 10);
            this.first_.Margin = new System.Windows.Forms.Padding(2);
            this.first_.Name = "first_";
            this.first_.Size = new System.Drawing.Size(17, 22);
            this.first_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.first_.TabIndex = 109;
            this.first_.TabStop = false;
            // 
            // next_
            // 
            this.next_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.next_.BackColor = System.Drawing.Color.Transparent;
            this.next_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.next_.Image = ((System.Drawing.Image)(resources.GetObject("next_.Image")));
            this.next_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.next_.Location = new System.Drawing.Point(964, 10);
            this.next_.Margin = new System.Windows.Forms.Padding(2);
            this.next_.Name = "next_";
            this.next_.Size = new System.Drawing.Size(16, 22);
            this.next_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.next_.TabIndex = 111;
            this.next_.TabStop = false;
            // 
            // last_
            // 
            this.last_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.last_.BackColor = System.Drawing.Color.Transparent;
            this.last_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.last_.Image = ((System.Drawing.Image)(resources.GetObject("last_.Image")));
            this.last_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.last_.Location = new System.Drawing.Point(949, 10);
            this.last_.Margin = new System.Windows.Forms.Padding(2);
            this.last_.Name = "last_";
            this.last_.Size = new System.Drawing.Size(17, 22);
            this.last_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.last_.TabIndex = 112;
            this.last_.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.jor_Row1);
            this.flowLayoutPanel1.Controls.Add(this.jor_Row2);
            this.flowLayoutPanel1.Controls.Add(this.jor_Row3);
            this.flowLayoutPanel1.Controls.Add(this.jor_Row4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 159);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1215, 340);
            this.flowLayoutPanel1.TabIndex = 105;
            // 
            // jor_Row1
            // 
            this.jor_Row1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jor_Row1.BackColor = System.Drawing.SystemColors.Control;
            this.jor_Row1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jor_Row1.Location = new System.Drawing.Point(0, 0);
            this.jor_Row1.Margin = new System.Windows.Forms.Padding(0);
            this.jor_Row1.Name = "jor_Row1";
            this.jor_Row1.Padding = new System.Windows.Forms.Padding(2);
            this.jor_Row1.Size = new System.Drawing.Size(1191, 69);
            this.jor_Row1.TabIndex = 0;
            this.jor_Row1.Load += new System.EventHandler(this.jor_Row1_Load);
            // 
            // jor_Row2
            // 
            this.jor_Row2.BackColor = System.Drawing.SystemColors.Control;
            this.jor_Row2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jor_Row2.Location = new System.Drawing.Point(0, 69);
            this.jor_Row2.Margin = new System.Windows.Forms.Padding(0);
            this.jor_Row2.Name = "jor_Row2";
            this.jor_Row2.Padding = new System.Windows.Forms.Padding(2);
            this.jor_Row2.Size = new System.Drawing.Size(1191, 71);
            this.jor_Row2.TabIndex = 1;
            // 
            // jor_Row3
            // 
            this.jor_Row3.BackColor = System.Drawing.SystemColors.Control;
            this.jor_Row3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jor_Row3.Location = new System.Drawing.Point(0, 140);
            this.jor_Row3.Margin = new System.Windows.Forms.Padding(0);
            this.jor_Row3.Name = "jor_Row3";
            this.jor_Row3.Padding = new System.Windows.Forms.Padding(2);
            this.jor_Row3.Size = new System.Drawing.Size(1191, 70);
            this.jor_Row3.TabIndex = 2;
            // 
            // jor_Row4
            // 
            this.jor_Row4.BackColor = System.Drawing.SystemColors.Control;
            this.jor_Row4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jor_Row4.Location = new System.Drawing.Point(0, 210);
            this.jor_Row4.Margin = new System.Windows.Forms.Padding(0);
            this.jor_Row4.Name = "jor_Row4";
            this.jor_Row4.Padding = new System.Windows.Forms.Padding(2);
            this.jor_Row4.Size = new System.Drawing.Size(1191, 55);
            this.jor_Row4.TabIndex = 3;
            // 
            // jorHead1
            // 
            this.jorHead1.AutoSize = true;
            this.jorHead1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.jorHead1.Dock = System.Windows.Forms.DockStyle.Top;
            this.jorHead1.Location = new System.Drawing.Point(0, 135);
            this.jorHead1.Margin = new System.Windows.Forms.Padding(1);
            this.jorHead1.Name = "jorHead1";
            this.jorHead1.Size = new System.Drawing.Size(1215, 24);
            this.jorHead1.TabIndex = 104;
            // 
            // frmEntryJornal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 510);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.jorHead1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.ribbonBar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEntryJornal";
            this.Text = "frmEntryJornal";
            this.Load += new System.EventHandler(this.frmEntryJornal_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previous_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevComponents.DotNetBar.LabelX txtBranchName;
        private DevComponents.DotNetBar.LabelX txtBranchCode;
        private DevComponents.DotNetBar.LabelX labelX20;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsearch;
        private DevComponents.DotNetBar.LabelX labelX15;
        private System.Windows.Forms.Button btn_Srearch;
        private System.Windows.Forms.Button btn_Cancl;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sp_ser;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.MaskedTextBox mTxt_H;
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
        private DevComponents.DotNetBar.Controls.TextBoxX txt_docId;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Cyear;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSanad_type;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSer_code;
        private MyControls.JorHead jorHead1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MyControls.Jor_Row jor_Row1;
        private MyControls.Jor_Row jor_Row2;
        private MyControls.Jor_Row jor_Row3;
        private MyControls.Jor_Row jor_Row4;
    }
}