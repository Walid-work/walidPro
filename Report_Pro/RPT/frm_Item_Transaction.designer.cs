namespace Report_Pro.RPT
{
    partial class frm_Item_Transaction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btn_1 = new DevComponents.DotNetBar.ButtonX();
            this.Report_btn = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btn_Report = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Branch_code = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button4 = new System.Windows.Forms.Button();
            this.Branch_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.Uc_Group1 = new Report_Pro.MyControls.Uc_Group();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.UC_Transaction = new Report_Pro.MyControls.UC_Transaction();
            this.UC_Items = new Report_Pro.MyControls.UC_Items();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.UC_Acc = new Report_Pro.MyControls.UC_Acc();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.UC_Branch = new Report_Pro.MyControls.UC_Branch();
            this.ToDate_ = new System.Windows.Forms.DateTimePicker();
            this.FromDate_ = new System.Windows.Forms.DateTimePicker();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.panel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonX3);
            this.panel1.Controls.Add(this.buttonX2);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.btn_1);
            this.panel1.Controls.Add(this.Report_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 43);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.buttonX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(348, 8);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(112, 27);
            this.buttonX3.TabIndex = 295;
            this.buttonX3.Text = "تقرير الجرد الاجمالي";
            this.buttonX3.Tooltip = "<font color=\"#ED1C24\">التقرير</font><b></b>";
            this.buttonX3.Visible = false;
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(466, 8);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(112, 27);
            this.buttonX2.TabIndex = 294;
            this.buttonX2.Text = "تقرير الجرد مجموعات";
            this.buttonX2.Tooltip = "<font color=\"#ED1C24\">التقرير</font><b></b>";
            this.buttonX2.Visible = false;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(698, 8);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(89, 27);
            this.buttonX1.TabIndex = 292;
            this.buttonX1.Text = "بطاقة صنف";
            this.buttonX1.Tooltip = "<font color=\"#ED1C24\">التقرير</font><b></b>";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btn_1
            // 
            this.btn_1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.btn_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_1.Location = new System.Drawing.Point(887, 8);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(89, 27);
            this.btn_1.TabIndex = 291;
            this.btn_1.Text = "خيارات";
            this.btn_1.Tooltip = "<font color=\"#ED1C24\">التقرير</font><b></b>";
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // Report_btn
            // 
            this.Report_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.Report_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Report_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Report_btn.Location = new System.Drawing.Point(793, 8);
            this.Report_btn.Name = "Report_btn";
            this.Report_btn.Size = new System.Drawing.Size(89, 27);
            this.Report_btn.TabIndex = 290;
            this.Report_btn.Text = "حركة الاصناف";
            this.Report_btn.Tooltip = "<font color=\"#ED1C24\">التقرير</font><b></b>";
            this.Report_btn.Click += new System.EventHandler(this.Report_btn_Click);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(539, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(0, 0);
            this.labelX1.TabIndex = 302;
            this.labelX1.Text = "الفرع";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(539, 7);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(0, 0);
            this.labelX5.TabIndex = 297;
            this.labelX5.Text = "الصنف";
            // 
            // btn_Report
            // 
            this.btn_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Report.Location = new System.Drawing.Point(10, 10);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(90, 26);
            this.btn_Report.TabIndex = 6;
            this.btn_Report.Text = "التقرير";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "الي تاريخ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "من تاريخ";
            // 
            // ToDate
            // 
            this.ToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDate.Location = new System.Drawing.Point(613, 32);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(104, 20);
            this.ToDate.TabIndex = 1;
            // 
            // FromDate
            // 
            this.FromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDate.Location = new System.Drawing.Point(612, 8);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(104, 20);
            this.FromDate.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 43);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(989, 469);
            this.crystalReportViewer1.TabIndex = 6;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.ToolPanelWidth = 300;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // Branch_code
            // 
            this.Branch_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Branch_code.BackColor = System.Drawing.Color.MintCream;
            // 
            // 
            // 
            this.Branch_code.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Branch_code.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Branch_code.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Branch_code.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Branch_code.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Branch_code.Border.Class = "TextBoxBorder";
            this.Branch_code.Location = new System.Drawing.Point(473, 5);
            this.Branch_code.MaxLength = 0;
            this.Branch_code.Name = "Branch_code";
            this.Branch_code.Size = new System.Drawing.Size(61, 20);
            this.Branch_code.TabIndex = 298;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(445, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 22);
            this.button4.TabIndex = 299;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Branch_name
            // 
            this.Branch_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Branch_name.BackColor = System.Drawing.Color.MintCream;
            // 
            // 
            // 
            this.Branch_name.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Branch_name.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Branch_name.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Branch_name.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Branch_name.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Branch_name.Border.Class = "TextBoxBorder";
            this.Branch_name.Location = new System.Drawing.Point(239, 5);
            this.Branch_name.MaxLength = 0;
            this.Branch_name.Name = "Branch_name";
            this.Branch_name.Size = new System.Drawing.Size(204, 20);
            this.Branch_name.TabIndex = 300;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.Uc_Group1);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.UC_Transaction);
            this.groupPanel1.Controls.Add(this.UC_Items);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.UC_Acc);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.UC_Branch);
            this.groupPanel1.Controls.Add(this.ToDate_);
            this.groupPanel1.Controls.Add(this.FromDate_);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 43);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(989, 245);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
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
            this.groupPanel1.TabIndex = 7;
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // labelX9
            // 
            this.labelX9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Location = new System.Drawing.Point(915, 116);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(50, 17);
            this.labelX9.TabIndex = 313;
            this.labelX9.Text = "المجموعة";
            // 
            // Uc_Group1
            // 
            this.Uc_Group1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Uc_Group1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Uc_Group1.Location = new System.Drawing.Point(598, 113);
            this.Uc_Group1.Margin = new System.Windows.Forms.Padding(0);
            this.Uc_Group1.Name = "Uc_Group1";
            this.Uc_Group1.Size = new System.Drawing.Size(310, 23);
            this.Uc_Group1.TabIndex = 311;
            // 
            // labelX6
            // 
            this.labelX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(915, 92);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(53, 17);
            this.labelX6.TabIndex = 310;
            this.labelX6.Text = "نوع الحركة";
            // 
            // UC_Transaction
            // 
            this.UC_Transaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Transaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Transaction.Location = new System.Drawing.Point(598, 88);
            this.UC_Transaction.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Transaction.Name = "UC_Transaction";
            this.UC_Transaction.Size = new System.Drawing.Size(310, 23);
            this.UC_Transaction.TabIndex = 309;
            // 
            // UC_Items
            // 
            this.UC_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Items.Location = new System.Drawing.Point(598, 62);
            this.UC_Items.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Items.Name = "UC_Items";
            this.UC_Items.Size = new System.Drawing.Size(310, 23);
            this.UC_Items.TabIndex = 308;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(915, 65);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(34, 17);
            this.labelX3.TabIndex = 303;
            this.labelX3.Text = "الصنف";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(915, 39);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(32, 17);
            this.labelX2.TabIndex = 298;
            this.labelX2.Text = "المورد";
            // 
            // UC_Acc
            // 
            this.UC_Acc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Acc.BackColor = System.Drawing.Color.Transparent;
            this.UC_Acc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Acc.Location = new System.Drawing.Point(598, 35);
            this.UC_Acc.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Acc.Name = "UC_Acc";
            this.UC_Acc.Padding = new System.Windows.Forms.Padding(1);
            this.UC_Acc.Size = new System.Drawing.Size(310, 25);
            this.UC_Acc.TabIndex = 306;
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(915, 11);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(29, 17);
            this.labelX4.TabIndex = 296;
            this.labelX4.Text = "الفرع";
            // 
            // UC_Branch
            // 
            this.UC_Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Branch.BackColor = System.Drawing.Color.Transparent;
            this.UC_Branch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.UC_Branch.Location = new System.Drawing.Point(598, 7);
            this.UC_Branch.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Branch.Name = "UC_Branch";
            this.UC_Branch.Size = new System.Drawing.Size(310, 24);
            this.UC_Branch.TabIndex = 305;
            // 
            // ToDate_
            // 
            this.ToDate_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDate_.Location = new System.Drawing.Point(415, 37);
            this.ToDate_.Name = "ToDate_";
            this.ToDate_.Size = new System.Drawing.Size(104, 20);
            this.ToDate_.TabIndex = 292;
            // 
            // FromDate_
            // 
            this.FromDate_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDate_.Location = new System.Drawing.Point(415, 9);
            this.FromDate_.Name = "FromDate_";
            this.FromDate_.Size = new System.Drawing.Size(104, 20);
            this.FromDate_.TabIndex = 291;
            // 
            // labelX7
            // 
            this.labelX7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(527, 39);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(47, 17);
            this.labelX7.TabIndex = 268;
            this.labelX7.Text = "الي تاريخ";
            // 
            // labelX8
            // 
            this.labelX8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Location = new System.Drawing.Point(527, 11);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(44, 17);
            this.labelX8.TabIndex = 267;
            this.labelX8.Text = "من تاريخ";
            // 
            // frm_Item_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 512);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Item_Transaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frm_Item_Transaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Purchase_reports_Load);
            this.panel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DateTimePicker FromDate;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.Controls.TextBoxX Branch_code;
        private System.Windows.Forms.Button button4;
        private DevComponents.DotNetBar.Controls.TextBoxX Branch_name;
        private DevComponents.DotNetBar.ButtonX btn_1;
        private DevComponents.DotNetBar.ButtonX Report_btn;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        //private MyControls.UC_Branch UC_Branch;
        private DevComponents.DotNetBar.LabelX labelX2;
        //private MyControls.UC_Acc UC_Acc;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        public System.Windows.Forms.DateTimePicker ToDate_;
        public System.Windows.Forms.DateTimePicker FromDate_;
        public MyControls.UC_Items UC_Items;
        public MyControls.UC_Acc UC_Acc;
        public MyControls.UC_Branch UC_Branch;
        public MyControls.UC_Transaction UC_Transaction;
        public MyControls.Uc_Group Uc_Group1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        public DevComponents.DotNetBar.ButtonX buttonX1;
        //private MyControls.UC_Items UC_Items;
    }
}