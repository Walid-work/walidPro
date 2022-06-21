namespace Report_Pro.RPT
{
    partial class frmAgeReport
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.Report_btn = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Uc_Catogry = new Report_Pro.MyControls.UC_Catogry();
            this.Uc_Cost = new Report_Pro.MyControls.UC_cost();
            this.Uc_Branch = new Report_Pro.MyControls.UC_Branch();
            this.Uc_Acc = new Report_Pro.MyControls.UC_Acc();
            this.rM_90 = new System.Windows.Forms.RadioButton();
            this.rM_60 = new System.Windows.Forms.RadioButton();
            this.rM_30 = new System.Windows.Forms.RadioButton();
            this.rAll = new System.Windows.Forms.RadioButton();
            this.rM_180 = new System.Windows.Forms.RadioButton();
            this.rM_150 = new System.Windows.Forms.RadioButton();
            this.rM_120 = new System.Windows.Forms.RadioButton();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.buttonX1);
            this.panel2.Controls.Add(this.buttonX5);
            this.panel2.Controls.Add(this.Report_btn);
            this.panel2.Controls.Add(this.buttonX6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 58);
            this.panel2.TabIndex = 4;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(666, 7);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(124, 45);
            this.buttonX1.TabIndex = 294;
            this.buttonX1.Text = "اعمار الموردين";
            this.buttonX1.Tooltip = "<font color=\"#ED1C24\">التقرير</font><b></b>";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Location = new System.Drawing.Point(20, 15);
            this.buttonX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(45, 29);
            this.buttonX5.TabIndex = 293;
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click_1);
            // 
            // Report_btn
            // 
            this.Report_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.Report_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Report_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Report_btn.Location = new System.Drawing.Point(825, 7);
            this.Report_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Report_btn.Name = "Report_btn";
            this.Report_btn.Size = new System.Drawing.Size(124, 45);
            this.Report_btn.TabIndex = 288;
            this.Report_btn.Text = "تقرير ";
            this.Report_btn.Tooltip = "<font color=\"#ED1C24\">التقرير</font><b></b>";
            this.Report_btn.Click += new System.EventHandler(this.Report_btn_Click);
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.buttonX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Location = new System.Drawing.Point(958, 7);
            this.buttonX6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(124, 45);
            this.buttonX6.TabIndex = 289;
            this.buttonX6.Text = "خيارات";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.Uc_Catogry);
            this.groupPanel1.Controls.Add(this.Uc_Cost);
            this.groupPanel1.Controls.Add(this.Uc_Branch);
            this.groupPanel1.Controls.Add(this.Uc_Acc);
            this.groupPanel1.Controls.Add(this.rM_90);
            this.groupPanel1.Controls.Add(this.rM_60);
            this.groupPanel1.Controls.Add(this.rM_30);
            this.groupPanel1.Controls.Add(this.rAll);
            this.groupPanel1.Controls.Add(this.rM_180);
            this.groupPanel1.Controls.Add(this.rM_150);
            this.groupPanel1.Controls.Add(this.rM_120);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.ToDate);
            this.groupPanel1.Controls.Add(this.FromDate);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 58);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1101, 247);
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
            this.groupPanel1.TabIndex = 6;
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // Uc_Catogry
            // 
            this.Uc_Catogry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Uc_Catogry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Uc_Catogry.Location = new System.Drawing.Point(520, 118);
            this.Uc_Catogry.Margin = new System.Windows.Forms.Padding(0);
            this.Uc_Catogry.Name = "Uc_Catogry";
            this.Uc_Catogry.Size = new System.Drawing.Size(463, 32);
            this.Uc_Catogry.TabIndex = 307;
            // 
            // Uc_Cost
            // 
            this.Uc_Cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Uc_Cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Uc_Cost.Location = new System.Drawing.Point(520, 82);
            this.Uc_Cost.Margin = new System.Windows.Forms.Padding(0);
            this.Uc_Cost.Name = "Uc_Cost";
            this.Uc_Cost.Size = new System.Drawing.Size(463, 32);
            this.Uc_Cost.TabIndex = 306;
            // 
            // Uc_Branch
            // 
            this.Uc_Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Uc_Branch.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Branch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Uc_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.Uc_Branch.Location = new System.Drawing.Point(520, 9);
            this.Uc_Branch.Margin = new System.Windows.Forms.Padding(0);
            this.Uc_Branch.Name = "Uc_Branch";
            this.Uc_Branch.Size = new System.Drawing.Size(463, 32);
            this.Uc_Branch.TabIndex = 305;
            // 
            // Uc_Acc
            // 
            this.Uc_Acc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Uc_Acc.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Acc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Uc_Acc.Location = new System.Drawing.Point(520, 45);
            this.Uc_Acc.Margin = new System.Windows.Forms.Padding(0);
            this.Uc_Acc.Name = "Uc_Acc";
            this.Uc_Acc.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Uc_Acc.Size = new System.Drawing.Size(463, 32);
            this.Uc_Acc.TabIndex = 304;
            // 
            // rM_90
            // 
            this.rM_90.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rM_90.AutoSize = true;
            this.rM_90.Location = new System.Drawing.Point(351, 104);
            this.rM_90.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rM_90.Name = "rM_90";
            this.rM_90.Size = new System.Drawing.Size(137, 23);
            this.rM_90.TabIndex = 303;
            this.rM_90.Text = "اكثر من  90 يوم";
            this.rM_90.UseVisualStyleBackColor = true;
            // 
            // rM_60
            // 
            this.rM_60.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rM_60.AutoSize = true;
            this.rM_60.Location = new System.Drawing.Point(351, 72);
            this.rM_60.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rM_60.Name = "rM_60";
            this.rM_60.Size = new System.Drawing.Size(137, 23);
            this.rM_60.TabIndex = 302;
            this.rM_60.Text = "اكثر من  60 يوم";
            this.rM_60.UseVisualStyleBackColor = true;
            // 
            // rM_30
            // 
            this.rM_30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rM_30.AutoSize = true;
            this.rM_30.Location = new System.Drawing.Point(351, 39);
            this.rM_30.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rM_30.Name = "rM_30";
            this.rM_30.Size = new System.Drawing.Size(137, 23);
            this.rM_30.TabIndex = 301;
            this.rM_30.Text = "اكثر من  30 يوم";
            this.rM_30.UseVisualStyleBackColor = true;
            // 
            // rAll
            // 
            this.rAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rAll.AutoSize = true;
            this.rAll.Checked = true;
            this.rAll.Location = new System.Drawing.Point(412, 4);
            this.rAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rAll.Name = "rAll";
            this.rAll.Size = new System.Drawing.Size(76, 26);
            this.rAll.TabIndex = 300;
            this.rAll.TabStop = true;
            this.rAll.Text = "الجميع";
            this.rAll.UseCompatibleTextRendering = true;
            this.rAll.UseVisualStyleBackColor = true;
            // 
            // rM_180
            // 
            this.rM_180.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rM_180.AutoSize = true;
            this.rM_180.Location = new System.Drawing.Point(341, 200);
            this.rM_180.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rM_180.Name = "rM_180";
            this.rM_180.Size = new System.Drawing.Size(146, 23);
            this.rM_180.TabIndex = 299;
            this.rM_180.Text = "اكثر من  180 يوم";
            this.rM_180.UseVisualStyleBackColor = true;
            // 
            // rM_150
            // 
            this.rM_150.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rM_150.AutoSize = true;
            this.rM_150.Location = new System.Drawing.Point(341, 168);
            this.rM_150.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rM_150.Name = "rM_150";
            this.rM_150.Size = new System.Drawing.Size(146, 23);
            this.rM_150.TabIndex = 298;
            this.rM_150.Text = "اكثر من  150 يوم";
            this.rM_150.UseVisualStyleBackColor = true;
            // 
            // rM_120
            // 
            this.rM_120.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rM_120.AutoSize = true;
            this.rM_120.Location = new System.Drawing.Point(341, 136);
            this.rM_120.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rM_120.Name = "rM_120";
            this.rM_120.Size = new System.Drawing.Size(146, 23);
            this.rM_120.TabIndex = 297;
            this.rM_120.Text = "اكثر من  120 يوم";
            this.rM_120.UseVisualStyleBackColor = true;
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(993, 13);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(42, 24);
            this.labelX5.TabIndex = 293;
            this.labelX5.Text = "الفرع";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(993, 123);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(61, 24);
            this.labelX4.TabIndex = 283;
            this.labelX4.Text = "التصنيف";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(993, 86);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(90, 24);
            this.labelX3.TabIndex = 282;
            this.labelX3.Text = "مركز التكلفة";
            // 
            // labelX6
            // 
            this.labelX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(993, 51);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(63, 24);
            this.labelX6.TabIndex = 281;
            this.labelX6.Text = "الحساب";
            // 
            // ToDate
            // 
            this.ToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDate.Location = new System.Drawing.Point(570, 161);
            this.ToDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(144, 27);
            this.ToDate.TabIndex = 292;
            // 
            // FromDate
            // 
            this.FromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDate.Location = new System.Drawing.Point(843, 161);
            this.FromDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(144, 27);
            this.FromDate.TabIndex = 291;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(716, 164);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 24);
            this.labelX2.TabIndex = 268;
            this.labelX2.Text = "الي تاريخ";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(986, 164);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 24);
            this.labelX1.TabIndex = 267;
            this.labelX1.Text = "من تاريخ";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 305);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1101, 316);
            this.crystalReportViewer1.TabIndex = 7;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.ToolPanelWidth = 300;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // frmAgeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 621);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAgeReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmAgeReport";
            this.Load += new System.EventHandler(this.frmAgeReport_Load);
            this.panel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX Report_btn;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DateTimePicker FromDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RadioButton rAll;
        private System.Windows.Forms.RadioButton rM_180;
        private System.Windows.Forms.RadioButton rM_150;
        private System.Windows.Forms.RadioButton rM_120;
        private System.Windows.Forms.RadioButton rM_90;
        private System.Windows.Forms.RadioButton rM_60;
        private System.Windows.Forms.RadioButton rM_30;
        private MyControls.UC_Acc Uc_Acc;
        private DevComponents.DotNetBar.LabelX labelX6;
        private MyControls.UC_Branch Uc_Branch;
        private MyControls.UC_Catogry Uc_Catogry;
        private MyControls.UC_cost Uc_Cost;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}