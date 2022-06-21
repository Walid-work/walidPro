namespace Report_Pro.PL
{
    partial class frmAssetesGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioTransaction = new System.Windows.Forms.RadioButton();
            this.radioParent = new System.Windows.Forms.RadioButton();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtRLAcc = new Report_Pro.MyControls.UC_Acc();
            this.txtRGAcc = new Report_Pro.MyControls.UC_Acc();
            this.txtLSAcc = new Report_Pro.MyControls.UC_Acc();
            this.txtGSAcc = new Report_Pro.MyControls.UC_Acc();
            this.txtADepAcc = new Report_Pro.MyControls.UC_Acc();
            this.txtDepAcc = new Report_Pro.MyControls.UC_Acc();
            this.txtAssAcc = new Report_Pro.MyControls.UC_Acc();
            this.txtNotes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbMainGroup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtName_L = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnClose);
            this.groupPanel1.Controls.Add(this.btnEdit);
            this.groupPanel1.Controls.Add(this.btnDelete);
            this.groupPanel1.Controls.Add(this.btnSearch);
            this.groupPanel1.Controls.Add(this.btnNew);
            this.groupPanel1.Controls.Add(this.btnSave);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupPanel1.Location = new System.Drawing.Point(833, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(95, 220);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.btnClose.Location = new System.Drawing.Point(5, 181);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 25);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Image = global::Report_Pro.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(5, 68);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 25);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = global::Report_Pro.Properties.Resources.deleteAttach_icon;
            this.btnDelete.Location = new System.Drawing.Point(5, 124);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "حذف";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.btnSearch.Location = new System.Drawing.Point(5, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "بحث";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Image = global::Report_Pro.Properties.Resources.Add_Icon;
            this.btnNew.Location = new System.Drawing.Point(5, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 25);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.btnSave.Location = new System.Drawing.Point(5, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.panel1);
            this.groupPanel2.Controls.Add(this.labelX17);
            this.groupPanel2.Controls.Add(this.labelX16);
            this.groupPanel2.Controls.Add(this.labelX15);
            this.groupPanel2.Controls.Add(this.labelX14);
            this.groupPanel2.Controls.Add(this.labelX13);
            this.groupPanel2.Controls.Add(this.groupPanel1);
            this.groupPanel2.Controls.Add(this.labelX12);
            this.groupPanel2.Controls.Add(this.labelX11);
            this.groupPanel2.Controls.Add(this.labelX10);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.txtRLAcc);
            this.groupPanel2.Controls.Add(this.txtRGAcc);
            this.groupPanel2.Controls.Add(this.txtLSAcc);
            this.groupPanel2.Controls.Add(this.txtGSAcc);
            this.groupPanel2.Controls.Add(this.txtADepAcc);
            this.groupPanel2.Controls.Add(this.txtDepAcc);
            this.groupPanel2.Controls.Add(this.txtAssAcc);
            this.groupPanel2.Controls.Add(this.txtNotes);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.cmbMainGroup);
            this.groupPanel2.Controls.Add(this.txtId);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.txtName_L);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.txtName);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txtCode);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(934, 226);
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
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Click += new System.EventHandler(this.groupPanel2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioTransaction);
            this.panel1.Controls.Add(this.radioParent);
            this.panel1.Location = new System.Drawing.Point(465, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 48);
            this.panel1.TabIndex = 40;
            // 
            // radioTransaction
            // 
            this.radioTransaction.AutoSize = true;
            this.radioTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioTransaction.Location = new System.Drawing.Point(20, 25);
            this.radioTransaction.Name = "radioTransaction";
            this.radioTransaction.Size = new System.Drawing.Size(53, 17);
            this.radioTransaction.TabIndex = 24;
            this.radioTransaction.Text = "فرعي";
            this.radioTransaction.UseVisualStyleBackColor = true;
            // 
            // radioParent
            // 
            this.radioParent.AutoSize = true;
            this.radioParent.Checked = true;
            this.radioParent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioParent.Location = new System.Drawing.Point(14, 4);
            this.radioParent.Name = "radioParent";
            this.radioParent.Size = new System.Drawing.Size(59, 17);
            this.radioParent.TabIndex = 23;
            this.radioParent.TabStop = true;
            this.radioParent.Text = "رئيسي";
            this.radioParent.UseVisualStyleBackColor = true;
            // 
            // labelX17
            // 
            this.labelX17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX17.AutoSize = true;
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            this.labelX17.ForeColor = System.Drawing.Color.Red;
            this.labelX17.Location = new System.Drawing.Point(452, 126);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(12, 17);
            this.labelX17.TabIndex = 39;
            this.labelX17.Text = "*";
            // 
            // labelX16
            // 
            this.labelX16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX16.AutoSize = true;
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            this.labelX16.ForeColor = System.Drawing.Color.Red;
            this.labelX16.Location = new System.Drawing.Point(452, 76);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(12, 17);
            this.labelX16.TabIndex = 38;
            this.labelX16.Text = "*";
            // 
            // labelX15
            // 
            this.labelX15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX15.AutoSize = true;
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            this.labelX15.ForeColor = System.Drawing.Color.Red;
            this.labelX15.Location = new System.Drawing.Point(619, 52);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(12, 17);
            this.labelX15.TabIndex = 37;
            this.labelX15.Text = "*";
            // 
            // labelX14
            // 
            this.labelX14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX14.AutoSize = true;
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            this.labelX14.ForeColor = System.Drawing.Color.Red;
            this.labelX14.Location = new System.Drawing.Point(662, 27);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(12, 17);
            this.labelX14.TabIndex = 36;
            this.labelX14.Text = "*";
            // 
            // labelX13
            // 
            this.labelX13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX13.AutoSize = true;
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            this.labelX13.Location = new System.Drawing.Point(317, 174);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(130, 17);
            this.labelX13.TabIndex = 35;
            this.labelX13.Text = "حساب خسائر اعادة التقييم";
            // 
            // labelX12
            // 
            this.labelX12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX12.AutoSize = true;
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            this.labelX12.Location = new System.Drawing.Point(318, 151);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(124, 17);
            this.labelX12.TabIndex = 34;
            this.labelX12.Text = "حساب فائض اعادة التقييم";
            // 
            // labelX11
            // 
            this.labelX11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX11.AutoSize = true;
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            this.labelX11.Location = new System.Drawing.Point(317, 126);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(127, 17);
            this.labelX11.TabIndex = 33;
            this.labelX11.Text = "حساب الخسائر الرأسمالية";
            // 
            // labelX10
            // 
            this.labelX10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX10.AutoSize = true;
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            this.labelX10.Location = new System.Drawing.Point(317, 101);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(117, 17);
            this.labelX10.TabIndex = 32;
            this.labelX10.Text = "حساب الارباح الرأسمالية";
            // 
            // labelX9
            // 
            this.labelX9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Location = new System.Drawing.Point(317, 76);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(103, 17);
            this.labelX9.TabIndex = 31;
            this.labelX9.Text = "حساب مجمع الاهلاك";
            // 
            // labelX8
            // 
            this.labelX8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Location = new System.Drawing.Point(317, 52);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(73, 17);
            this.labelX8.TabIndex = 30;
            this.labelX8.Text = "حساب الاهلاك";
            // 
            // labelX7
            // 
            this.labelX7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(317, 27);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(70, 17);
            this.labelX7.TabIndex = 29;
            this.labelX7.Text = "حساب الاصول";
            // 
            // txtRLAcc
            // 
            this.txtRLAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRLAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtRLAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtRLAcc.Location = new System.Drawing.Point(5, 173);
            this.txtRLAcc.Margin = new System.Windows.Forms.Padding(0);
            this.txtRLAcc.Name = "txtRLAcc";
            this.txtRLAcc.Padding = new System.Windows.Forms.Padding(1);
            this.txtRLAcc.Size = new System.Drawing.Size(310, 23);
            this.txtRLAcc.TabIndex = 28;
            // 
            // txtRGAcc
            // 
            this.txtRGAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRGAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtRGAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtRGAcc.Location = new System.Drawing.Point(5, 148);
            this.txtRGAcc.Margin = new System.Windows.Forms.Padding(0);
            this.txtRGAcc.Name = "txtRGAcc";
            this.txtRGAcc.Padding = new System.Windows.Forms.Padding(1);
            this.txtRGAcc.Size = new System.Drawing.Size(310, 23);
            this.txtRGAcc.TabIndex = 27;
            // 
            // txtLSAcc
            // 
            this.txtLSAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLSAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtLSAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtLSAcc.Location = new System.Drawing.Point(5, 123);
            this.txtLSAcc.Margin = new System.Windows.Forms.Padding(0);
            this.txtLSAcc.Name = "txtLSAcc";
            this.txtLSAcc.Padding = new System.Windows.Forms.Padding(1);
            this.txtLSAcc.Size = new System.Drawing.Size(310, 23);
            this.txtLSAcc.TabIndex = 26;
            // 
            // txtGSAcc
            // 
            this.txtGSAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGSAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtGSAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtGSAcc.Location = new System.Drawing.Point(5, 98);
            this.txtGSAcc.Margin = new System.Windows.Forms.Padding(0);
            this.txtGSAcc.Name = "txtGSAcc";
            this.txtGSAcc.Padding = new System.Windows.Forms.Padding(1);
            this.txtGSAcc.Size = new System.Drawing.Size(310, 23);
            this.txtGSAcc.TabIndex = 25;
            // 
            // txtADepAcc
            // 
            this.txtADepAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtADepAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtADepAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtADepAcc.Location = new System.Drawing.Point(5, 73);
            this.txtADepAcc.Margin = new System.Windows.Forms.Padding(0);
            this.txtADepAcc.Name = "txtADepAcc";
            this.txtADepAcc.Padding = new System.Windows.Forms.Padding(1);
            this.txtADepAcc.Size = new System.Drawing.Size(310, 23);
            this.txtADepAcc.TabIndex = 24;
            // 
            // txtDepAcc
            // 
            this.txtDepAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtDepAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDepAcc.Location = new System.Drawing.Point(5, 49);
            this.txtDepAcc.Margin = new System.Windows.Forms.Padding(0);
            this.txtDepAcc.Name = "txtDepAcc";
            this.txtDepAcc.Padding = new System.Windows.Forms.Padding(1);
            this.txtDepAcc.Size = new System.Drawing.Size(310, 23);
            this.txtDepAcc.TabIndex = 23;
            // 
            // txtAssAcc
            // 
            this.txtAssAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtAssAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAssAcc.Location = new System.Drawing.Point(5, 24);
            this.txtAssAcc.Margin = new System.Windows.Forms.Padding(0);
            this.txtAssAcc.Name = "txtAssAcc";
            this.txtAssAcc.Padding = new System.Windows.Forms.Padding(1);
            this.txtAssAcc.Size = new System.Drawing.Size(310, 23);
            this.txtAssAcc.TabIndex = 22;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtNotes.Border.Class = "TextBoxBorder";
            this.txtNotes.Location = new System.Drawing.Point(465, 149);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(262, 47);
            this.txtNotes.TabIndex = 20;
            // 
            // labelX6
            // 
            this.labelX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(729, 151);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(47, 17);
            this.labelX6.TabIndex = 21;
            this.labelX6.Text = "ملاحظات";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(733, 126);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(93, 17);
            this.labelX5.TabIndex = 19;
            this.labelX5.Text = "المجموعة الرئيسية";
            // 
            // cmbMainGroup
            // 
            this.cmbMainGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMainGroup.DisplayMember = "Text";
            this.cmbMainGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMainGroup.FormattingEnabled = true;
            this.cmbMainGroup.ItemHeight = 14;
            this.cmbMainGroup.Location = new System.Drawing.Point(465, 124);
            this.cmbMainGroup.Name = "cmbMainGroup";
            this.cmbMainGroup.Size = new System.Drawing.Size(262, 20);
            this.cmbMainGroup.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtId.Border.Class = "TextBoxBorder";
            this.txtId.Location = new System.Drawing.Point(675, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(52, 20);
            this.txtId.TabIndex = 16;
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(729, 27);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(28, 17);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "الرقم";
            // 
            // txtName_L
            // 
            this.txtName_L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtName_L.Border.Class = "TextBoxBorder";
            this.txtName_L.Location = new System.Drawing.Point(465, 99);
            this.txtName_L.Name = "txtName_L";
            this.txtName_L.Size = new System.Drawing.Size(262, 20);
            this.txtName_L.TabIndex = 14;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(729, 101);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(66, 17);
            this.labelX3.TabIndex = 15;
            this.labelX3.Text = "الاسم لاتيني";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Location = new System.Drawing.Point(465, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 20);
            this.txtName.TabIndex = 11;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(729, 76);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(34, 17);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "الاسم";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCode.Border.Class = "TextBoxBorder";
            this.txtCode.Location = new System.Drawing.Point(633, 50);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(94, 20);
            this.txtCode.TabIndex = 10;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(729, 52);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(27, 17);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "الرمز";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 226);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(934, 335);
            this.dgv.TabIndex = 2;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // frmAssetesGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.ControlBox = false;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupPanel2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "frmAssetesGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بطاقة مجموعة";
            this.Load += new System.EventHandler(this.frmAssetesGroup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAssetesGroup_KeyDown);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private MyControls.UC_Acc txtRLAcc;
        private MyControls.UC_Acc txtRGAcc;
        private MyControls.UC_Acc txtLSAcc;
        private MyControls.UC_Acc txtGSAcc;
        private MyControls.UC_Acc txtADepAcc;
        private MyControls.UC_Acc txtDepAcc;
        private MyControls.UC_Acc txtAssAcc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNotes;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMainGroup;
        private DevComponents.DotNetBar.Controls.TextBoxX txtId;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName_L;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCode;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioTransaction;
        private System.Windows.Forms.RadioButton radioParent;
    }
}