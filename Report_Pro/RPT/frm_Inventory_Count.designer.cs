namespace Report_Pro.RPT
{
    partial class frm_Inventory_Count
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
            this.btn_stock_count = new DevComponents.DotNetBar.ButtonX();
            this.btn_1 = new DevComponents.DotNetBar.ButtonX();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.XIO = new System.Windows.Forms.CheckBox();
            this.XTT = new System.Windows.Forms.CheckBox();
            this.XIM = new System.Windows.Forms.CheckBox();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.Uc_Group1 = new Report_Pro.MyControls.Uc_Group();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonX3);
            this.panel1.Controls.Add(this.buttonX2);
            this.panel1.Controls.Add(this.btn_stock_count);
            this.panel1.Controls.Add(this.btn_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 63);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.buttonX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(422, 9);
            this.buttonX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(168, 45);
            this.buttonX3.TabIndex = 295;
            this.buttonX3.Text = "تقرير الجرد الاجمالي";
            this.buttonX3.Tooltip = "<font color=\"#ED1C24\">التقرير</font><b></b>";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(598, 9);
            this.buttonX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(168, 45);
            this.buttonX2.TabIndex = 294;
            this.buttonX2.Text = "تقرير الجرد مجموعات";
            this.buttonX2.Tooltip = "<font color=\"#ED1C24\">التقرير</font><b></b>";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btn_stock_count
            // 
            this.btn_stock_count.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.btn_stock_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stock_count.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_stock_count.Location = new System.Drawing.Point(776, 9);
            this.btn_stock_count.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_stock_count.Name = "btn_stock_count";
            this.btn_stock_count.Size = new System.Drawing.Size(134, 45);
            this.btn_stock_count.TabIndex = 293;
            this.btn_stock_count.Text = "تقرير الجرد";
            this.btn_stock_count.Tooltip = "<font color=\"#ED1C24\">التقرير</font><b></b>";
            this.btn_stock_count.Click += new System.EventHandler(this.btn_stock_count_Click);
            // 
            // btn_1
            // 
            this.btn_1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.btn_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_1.Location = new System.Drawing.Point(1012, 9);
            this.btn_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(134, 45);
            this.btn_1.TabIndex = 291;
            this.btn_1.Text = "خيارات";
            this.btn_1.Tooltip = "<font color=\"#ED1C24\">التقرير</font><b></b>";
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
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
            this.ToDate.Size = new System.Drawing.Size(104, 27);
            this.ToDate.TabIndex = 1;
            // 
            // FromDate
            // 
            this.FromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDate.Location = new System.Drawing.Point(612, 8);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(104, 27);
            this.FromDate.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 63);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1167, 595);
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
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.Uc_Group1);
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
            this.groupPanel1.Location = new System.Drawing.Point(0, 63);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1167, 358);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.XIO);
            this.groupBox1.Controls.Add(this.XTT);
            this.groupBox1.Controls.Add(this.XIM);
            this.groupBox1.Location = new System.Drawing.Point(261, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(300, 146);
            this.groupBox1.TabIndex = 317;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الحركة";
            // 
            // XIO
            // 
            this.XIO.AutoSize = true;
            this.XIO.Location = new System.Drawing.Point(80, 28);
            this.XIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XIO.Name = "XIO";
            this.XIO.Size = new System.Drawing.Size(139, 23);
            this.XIO.TabIndex = 314;
            this.XIO.Text = "الجرد الافتتاحي";
            this.XIO.UseVisualStyleBackColor = true;
            // 
            // XTT
            // 
            this.XTT.AutoSize = true;
            this.XTT.Location = new System.Drawing.Point(54, 95);
            this.XTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XTT.Name = "XTT";
            this.XTT.Size = new System.Drawing.Size(164, 23);
            this.XTT.TabIndex = 316;
            this.XTT.Text = "التجميع داخل الفرع";
            this.XTT.UseVisualStyleBackColor = true;
            // 
            // XIM
            // 
            this.XIM.AutoSize = true;
            this.XIM.Location = new System.Drawing.Point(88, 61);
            this.XIM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XIM.Name = "XIM";
            this.XIM.Size = new System.Drawing.Size(128, 23);
            this.XIM.TabIndex = 315;
            this.XIM.Text = "تسويات جردية";
            this.XIM.UseVisualStyleBackColor = true;
            // 
            // labelX9
            // 
            this.labelX9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Location = new System.Drawing.Point(1056, 129);
            this.labelX9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(74, 24);
            this.labelX9.TabIndex = 313;
            this.labelX9.Text = "المجموعة";
            // 
            // Uc_Group1
            // 
            this.Uc_Group1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Uc_Group1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Uc_Group1.Location = new System.Drawing.Point(586, 126);
            this.Uc_Group1.Margin = new System.Windows.Forms.Padding(0);
            this.Uc_Group1.Name = "Uc_Group1";
            this.Uc_Group1.Size = new System.Drawing.Size(463, 32);
            this.Uc_Group1.TabIndex = 311;
            // 
            // UC_Items
            // 
            this.UC_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Items.Location = new System.Drawing.Point(586, 91);
            this.UC_Items.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Items.Name = "UC_Items";
            this.UC_Items.Size = new System.Drawing.Size(463, 32);
            this.UC_Items.TabIndex = 308;
            this.UC_Items.DoubleClick += new System.EventHandler(this.UC_Items_DoubleClick);
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(1056, 95);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(50, 24);
            this.labelX3.TabIndex = 303;
            this.labelX3.Text = "الصنف";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(1056, 57);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(47, 24);
            this.labelX2.TabIndex = 298;
            this.labelX2.Text = "المورد";
            // 
            // UC_Acc
            // 
            this.UC_Acc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Acc.BackColor = System.Drawing.Color.Transparent;
            this.UC_Acc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Acc.Location = new System.Drawing.Point(586, 51);
            this.UC_Acc.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Acc.Name = "UC_Acc";
            this.UC_Acc.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.UC_Acc.Size = new System.Drawing.Size(463, 35);
            this.UC_Acc.TabIndex = 306;
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(1056, 16);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(42, 24);
            this.labelX4.TabIndex = 296;
            this.labelX4.Text = "الفرع";
            // 
            // UC_Branch
            // 
            this.UC_Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_Branch.BackColor = System.Drawing.Color.Transparent;
            this.UC_Branch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.UC_Branch.Location = new System.Drawing.Point(586, 10);
            this.UC_Branch.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Branch.Name = "UC_Branch";
            this.UC_Branch.Size = new System.Drawing.Size(463, 33);
            this.UC_Branch.TabIndex = 305;
            // 
            // ToDate_
            // 
            this.ToDate_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDate_.Location = new System.Drawing.Point(586, 167);
            this.ToDate_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ToDate_.Name = "ToDate_";
            this.ToDate_.Size = new System.Drawing.Size(144, 27);
            this.ToDate_.TabIndex = 292;
            // 
            // FromDate_
            // 
            this.FromDate_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDate_.Location = new System.Drawing.Point(906, 164);
            this.FromDate_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FromDate_.Name = "FromDate_";
            this.FromDate_.Size = new System.Drawing.Size(144, 27);
            this.FromDate_.TabIndex = 291;
            // 
            // labelX7
            // 
            this.labelX7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(732, 170);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(70, 24);
            this.labelX7.TabIndex = 268;
            this.labelX7.Text = "الي تاريخ";
            // 
            // labelX8
            // 
            this.labelX8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Location = new System.Drawing.Point(1048, 167);
            this.labelX8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(65, 24);
            this.labelX8.TabIndex = 267;
            this.labelX8.Text = "من تاريخ";
            // 
            // frm_Inventory_Count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 658);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Inventory_Count";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تقرير الجرد";
            this.Load += new System.EventHandler(this.Purchase_reports_Load);
            this.panel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.Controls.TextBoxX Branch_code;
        private System.Windows.Forms.Button button4;
        private DevComponents.DotNetBar.Controls.TextBoxX Branch_name;
        private DevComponents.DotNetBar.ButtonX btn_1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        //private MyControls.UC_Branch UC_Branch;
        private DevComponents.DotNetBar.LabelX labelX2;
        //private MyControls.UC_Acc UC_Acc;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.DateTimePicker ToDate_;
        private System.Windows.Forms.DateTimePicker FromDate_;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX3;
        private MyControls.UC_Items UC_Items;
        private MyControls.UC_Acc UC_Acc;
        private MyControls.UC_Branch UC_Branch;
        private DevComponents.DotNetBar.ButtonX btn_stock_count;
        private DevComponents.DotNetBar.LabelX labelX9;
        private MyControls.Uc_Group Uc_Group1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox XIO;
        private System.Windows.Forms.CheckBox XTT;
        private System.Windows.Forms.CheckBox XIM;
        //private MyControls.UC_Items UC_Items;
    }
}