namespace Report_Pro.PL
{
    partial class frm_deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_deposit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.BEdit = new DevComponents.DotNetBar.ButtonItem();
            this.BSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.BtnEmail = new DevComponents.DotNetBar.ButtonItem();
            this.BtnAttache = new DevComponents.DotNetBar.ButtonItem();
            this.BtnCalc = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.print_sand = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtAcc_11 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_12 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_13 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_14 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_15 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_9 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_10 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_8 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_7 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_6 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc_1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmb_Bank = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtAccName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_tot_F = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_tot_D = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_NoToText = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX3 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.buttonItem1,
            this.BtnEmail,
            this.BtnAttache,
            this.BtnCalc,
            this.BExit,
            this.print_sand});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(884, 29);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 103;
            this.ribbonBar1.Text = "ribbonBar1";
            this.ribbonBar1.TitleVisible = false;
            // 
            // BNew
            // 
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BNew.Image = ((System.Drawing.Image)(resources.GetObject("BNew.Image")));
            this.BNew.ImagePaddingHorizontal = 15;
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            this.BNew.Text = "جديد";
            // 
            // BSave
            // 
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSave.Image = ((System.Drawing.Image)(resources.GetObject("BSave.Image")));
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
            this.BEdit.Image = ((System.Drawing.Image)(resources.GetObject("BEdit.Image")));
            this.BEdit.ImagePaddingHorizontal = 15;
            this.BEdit.Name = "BEdit";
            this.BEdit.SubItemsExpandWidth = 14;
            this.BEdit.Text = "تعديل";
            // 
            // BSearch
            // 
            this.BSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSearch.Image = ((System.Drawing.Image)(resources.GetObject("BSearch.Image")));
            this.BSearch.ImagePaddingHorizontal = 15;
            this.BSearch.Name = "BSearch";
            this.BSearch.SubItemsExpandWidth = 14;
            this.BSearch.Text = "بحث";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImagePaddingHorizontal = 15;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "طباعة";
            // 
            // BtnEmail
            // 
            this.BtnEmail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnEmail.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmail.Image")));
            this.BtnEmail.ImagePaddingHorizontal = 15;
            this.BtnEmail.Name = "BtnEmail";
            this.BtnEmail.SubItemsExpandWidth = 14;
            this.BtnEmail.Text = "ارسال بالبريد";
            // 
            // BtnAttache
            // 
            this.BtnAttache.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnAttache.Image = ((System.Drawing.Image)(resources.GetObject("BtnAttache.Image")));
            this.BtnAttache.ImagePaddingHorizontal = 15;
            this.BtnAttache.Name = "BtnAttache";
            this.BtnAttache.SubItemsExpandWidth = 14;
            this.BtnAttache.Text = "المرفقات";
            // 
            // BtnCalc
            // 
            this.BtnCalc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnCalc.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalc.Image")));
            this.BtnCalc.ImagePaddingHorizontal = 15;
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.SubItemsExpandWidth = 14;
            this.BtnCalc.Text = "الحاسبة";
            // 
            // BExit
            // 
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BExit.Image = ((System.Drawing.Image)(resources.GetObject("BExit.Image")));
            this.BExit.ImagePaddingHorizontal = 15;
            this.BExit.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.BExit.Name = "BExit";
            this.BExit.RibbonWordWrap = false;
            this.BExit.SubItemsExpandWidth = 14;
            this.BExit.Text = "خروج";
            // 
            // print_sand
            // 
            this.print_sand.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.print_sand.Image = ((System.Drawing.Image)(resources.GetObject("print_sand.Image")));
            this.print_sand.ImagePaddingHorizontal = 15;
            this.print_sand.Name = "print_sand";
            this.print_sand.SubItemsExpandWidth = 14;
            this.print_sand.Text = "طباعة السند";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.checkBoxX3);
            this.groupPanel1.Controls.Add(this.checkBoxX2);
            this.groupPanel1.Controls.Add(this.checkBoxX1);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtAccName);
            this.groupPanel1.Controls.Add(this.txtAcc_11);
            this.groupPanel1.Controls.Add(this.txtAcc_12);
            this.groupPanel1.Controls.Add(this.txtAcc_13);
            this.groupPanel1.Controls.Add(this.txtAcc_14);
            this.groupPanel1.Controls.Add(this.txtAcc_15);
            this.groupPanel1.Controls.Add(this.txtAcc_9);
            this.groupPanel1.Controls.Add(this.txtAcc_10);
            this.groupPanel1.Controls.Add(this.txtAcc_8);
            this.groupPanel1.Controls.Add(this.txtAcc_7);
            this.groupPanel1.Controls.Add(this.txtAcc_6);
            this.groupPanel1.Controls.Add(this.txtAcc_5);
            this.groupPanel1.Controls.Add(this.txtAcc_4);
            this.groupPanel1.Controls.Add(this.txtAcc_3);
            this.groupPanel1.Controls.Add(this.txtAcc_2);
            this.groupPanel1.Controls.Add(this.txtAcc_1);
            this.groupPanel1.Controls.Add(this.cmb_Bank);
            this.groupPanel1.Controls.Add(this.txtDate);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 29);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(884, 107);
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
            this.groupPanel1.TabIndex = 104;
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // txtAcc_11
            // 
            this.txtAcc_11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_11.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_11.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_11.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_11.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_11.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_11.Border.Class = "TextBoxBorder";
            this.txtAcc_11.Location = new System.Drawing.Point(331, 36);
            this.txtAcc_11.Name = "txtAcc_11";
            this.txtAcc_11.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_11.TabIndex = 17;
            this.txtAcc_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_12
            // 
            this.txtAcc_12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_12.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_12.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_12.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_12.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_12.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_12.Border.Class = "TextBoxBorder";
            this.txtAcc_12.Location = new System.Drawing.Point(353, 36);
            this.txtAcc_12.Name = "txtAcc_12";
            this.txtAcc_12.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_12.TabIndex = 16;
            this.txtAcc_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_13
            // 
            this.txtAcc_13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_13.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_13.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_13.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_13.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_13.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_13.Border.Class = "TextBoxBorder";
            this.txtAcc_13.Location = new System.Drawing.Point(375, 36);
            this.txtAcc_13.Name = "txtAcc_13";
            this.txtAcc_13.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_13.TabIndex = 15;
            this.txtAcc_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_14
            // 
            this.txtAcc_14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_14.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_14.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_14.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_14.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_14.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_14.Border.Class = "TextBoxBorder";
            this.txtAcc_14.Location = new System.Drawing.Point(397, 36);
            this.txtAcc_14.Name = "txtAcc_14";
            this.txtAcc_14.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_14.TabIndex = 14;
            this.txtAcc_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_15
            // 
            this.txtAcc_15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_15.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_15.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_15.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_15.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_15.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_15.Border.Class = "TextBoxBorder";
            this.txtAcc_15.Location = new System.Drawing.Point(419, 36);
            this.txtAcc_15.Name = "txtAcc_15";
            this.txtAcc_15.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_15.TabIndex = 13;
            this.txtAcc_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_9
            // 
            this.txtAcc_9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_9.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_9.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_9.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_9.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_9.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_9.Border.Class = "TextBoxBorder";
            this.txtAcc_9.Location = new System.Drawing.Point(287, 36);
            this.txtAcc_9.Name = "txtAcc_9";
            this.txtAcc_9.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_9.TabIndex = 11;
            this.txtAcc_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_10
            // 
            this.txtAcc_10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_10.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_10.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_10.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_10.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_10.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_10.Border.Class = "TextBoxBorder";
            this.txtAcc_10.Location = new System.Drawing.Point(309, 36);
            this.txtAcc_10.Name = "txtAcc_10";
            this.txtAcc_10.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_10.TabIndex = 10;
            this.txtAcc_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_8
            // 
            this.txtAcc_8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_8.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_8.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_8.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_8.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_8.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_8.Border.Class = "TextBoxBorder";
            this.txtAcc_8.Location = new System.Drawing.Point(265, 36);
            this.txtAcc_8.Name = "txtAcc_8";
            this.txtAcc_8.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_8.TabIndex = 9;
            this.txtAcc_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_7
            // 
            this.txtAcc_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_7.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_7.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_7.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_7.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_7.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_7.Border.Class = "TextBoxBorder";
            this.txtAcc_7.Location = new System.Drawing.Point(243, 36);
            this.txtAcc_7.Name = "txtAcc_7";
            this.txtAcc_7.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_7.TabIndex = 8;
            this.txtAcc_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_6
            // 
            this.txtAcc_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_6.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_6.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_6.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_6.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_6.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_6.Border.Class = "TextBoxBorder";
            this.txtAcc_6.Location = new System.Drawing.Point(221, 36);
            this.txtAcc_6.Name = "txtAcc_6";
            this.txtAcc_6.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_6.TabIndex = 7;
            this.txtAcc_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_5
            // 
            this.txtAcc_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_5.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_5.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_5.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_5.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_5.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_5.Border.Class = "TextBoxBorder";
            this.txtAcc_5.Location = new System.Drawing.Point(199, 36);
            this.txtAcc_5.Name = "txtAcc_5";
            this.txtAcc_5.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_5.TabIndex = 6;
            this.txtAcc_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_4
            // 
            this.txtAcc_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_4.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_4.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_4.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_4.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_4.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_4.Border.Class = "TextBoxBorder";
            this.txtAcc_4.Location = new System.Drawing.Point(177, 36);
            this.txtAcc_4.Name = "txtAcc_4";
            this.txtAcc_4.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_4.TabIndex = 5;
            this.txtAcc_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_3
            // 
            this.txtAcc_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_3.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_3.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_3.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_3.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_3.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_3.Border.Class = "TextBoxBorder";
            this.txtAcc_3.Location = new System.Drawing.Point(155, 36);
            this.txtAcc_3.Name = "txtAcc_3";
            this.txtAcc_3.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_3.TabIndex = 4;
            this.txtAcc_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_2
            // 
            this.txtAcc_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_2.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_2.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_2.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_2.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_2.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_2.Border.Class = "TextBoxBorder";
            this.txtAcc_2.Location = new System.Drawing.Point(133, 36);
            this.txtAcc_2.Name = "txtAcc_2";
            this.txtAcc_2.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_2.TabIndex = 3;
            this.txtAcc_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcc_1
            // 
            this.txtAcc_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAcc_1.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_1.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAcc_1.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_1.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_1.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAcc_1.Border.Class = "TextBoxBorder";
            this.txtAcc_1.Location = new System.Drawing.Point(111, 36);
            this.txtAcc_1.Name = "txtAcc_1";
            this.txtAcc_1.Size = new System.Drawing.Size(21, 20);
            this.txtAcc_1.TabIndex = 2;
            this.txtAcc_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_Bank
            // 
            this.cmb_Bank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Bank.DisplayMember = "Text";
            this.cmb_Bank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Bank.FormattingEnabled = true;
            this.cmb_Bank.ItemHeight = 14;
            this.cmb_Bank.Location = new System.Drawing.Point(580, 36);
            this.cmb_Bank.Name = "cmb_Bank";
            this.cmb_Bank.Size = new System.Drawing.Size(230, 20);
            this.cmb_Bank.TabIndex = 1;
            this.cmb_Bank.SelectedIndexChanged += new System.EventHandler(this.cmb_Bank_SelectedIndexChanged);
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtDate.ButtonDropDown.Visible = true;
            this.txtDate.Location = new System.Drawing.Point(698, 9);
            // 
            // 
            // 
            this.txtDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtDate.MonthCalendar.DisplayMonth = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtDate.MonthCalendar.TodayButtonVisible = true;
            this.txtDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtDate.Name = "txtDate";
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDate.Size = new System.Drawing.Size(112, 20);
            this.txtDate.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 136);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(884, 177);
            this.dgv.TabIndex = 105;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
            this.dgv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyUp);
            // 
            // txtAccName
            // 
            this.txtAccName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAccName.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccName.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txtAccName.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccName.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccName.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccName.Border.Class = "TextBoxBorder";
            this.txtAccName.Location = new System.Drawing.Point(109, 64);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(630, 20);
            this.txtAccName.TabIndex = 18;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(447, 38);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(62, 17);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "رقم الحساب";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(814, 38);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(28, 17);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "البنك";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(744, 65);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(100, 17);
            this.labelX3.TabIndex = 21;
            this.labelX3.Text = "اسم صاحب الحساب";
            // 
            // txt_tot_F
            // 
            this.txt_tot_F.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_tot_F.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_tot_F.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txt_tot_F.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_tot_F.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_tot_F.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_tot_F.Border.Class = "TextBoxBorder";
            this.txt_tot_F.Location = new System.Drawing.Point(52, 319);
            this.txt_tot_F.Name = "txt_tot_F";
            this.txt_tot_F.Size = new System.Drawing.Size(50, 20);
            this.txt_tot_F.TabIndex = 107;
            // 
            // txt_tot_D
            // 
            this.txt_tot_D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_tot_D.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_tot_D.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txt_tot_D.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_tot_D.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_tot_D.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_tot_D.Border.Class = "TextBoxBorder";
            this.txt_tot_D.Location = new System.Drawing.Point(103, 319);
            this.txt_tot_D.Name = "txt_tot_D";
            this.txt_tot_D.Size = new System.Drawing.Size(101, 20);
            this.txt_tot_D.TabIndex = 106;
            // 
            // txt_NoToText
            // 
            this.txt_NoToText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_NoToText.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_NoToText.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.txt_NoToText.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_NoToText.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_NoToText.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_NoToText.Border.Class = "TextBoxBorder";
            this.txt_NoToText.Location = new System.Drawing.Point(260, 319);
            this.txt_NoToText.Name = "txt_NoToText";
            this.txt_NoToText.Size = new System.Drawing.Size(610, 20);
            this.txt_NoToText.TabIndex = 22;
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(210, 320);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(44, 17);
            this.labelX4.TabIndex = 22;
            this.labelX4.Text = "المجموع";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(814, 11);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(34, 17);
            this.labelX5.TabIndex = 22;
            this.labelX5.Text = "التاريخ";
            // 
            // checkBoxX1
            // 
            this.checkBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxX1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxX1.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Right;
            this.checkBoxX1.Location = new System.Drawing.Point(438, 8);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(121, 23);
            this.checkBoxX1.TabIndex = 23;
            this.checkBoxX1.Text = "سداد قسط البطاقة";
            this.checkBoxX1.CheckedChanged += new System.EventHandler(this.checkBoxX1_CheckedChanged);
            // 
            // checkBoxX2
            // 
            this.checkBoxX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxX2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxX2.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Right;
            this.checkBoxX2.Location = new System.Drawing.Point(269, 8);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(163, 23);
            this.checkBoxX2.TabIndex = 24;
            this.checkBoxX2.Text = "ايداع شيكات - البنوك الاخري";
            // 
            // checkBoxX3
            // 
            this.checkBoxX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxX3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxX3.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Right;
            this.checkBoxX3.Location = new System.Drawing.Point(111, 8);
            this.checkBoxX3.Name = "checkBoxX3";
            this.checkBoxX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxX3.Size = new System.Drawing.Size(152, 23);
            this.checkBoxX3.TabIndex = 25;
            this.checkBoxX3.Text = "ايداع شيكات - بنك الاثمار";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "فلس";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "المبلغ";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "العملة";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "العدد";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 70;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "الفئات";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "رقم الحساب";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "رقم الشيك";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "البنك المسحوب علية";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 150;
            // 
            // frm_deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txt_NoToText);
            this.Controls.Add(this.txt_tot_F);
            this.Controls.Add(this.txt_tot_D);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.ribbonBar1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "frm_deposit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_deposit";
            this.Load += new System.EventHandler(this.frm_deposit_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem BEdit;
        private DevComponents.DotNetBar.ButtonItem BSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem BtnEmail;
        private DevComponents.DotNetBar.ButtonItem BtnAttache;
        private DevComponents.DotNetBar.ButtonItem BtnCalc;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private DevComponents.DotNetBar.ButtonItem print_sand;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_13;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_14;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_15;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_Bank;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtDate;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccName;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tot_F;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tot_D;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_NoToText;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX3;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}