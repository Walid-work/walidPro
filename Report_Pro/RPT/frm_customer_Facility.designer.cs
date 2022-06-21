namespace Report_Pro.RPT
{
    partial class frm_customer_Facility
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
            this.btn_3 = new DevComponents.DotNetBar.ButtonX();
            this.btn_2 = new DevComponents.DotNetBar.ButtonX();
            this.btn_1 = new DevComponents.DotNetBar.ButtonX();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WithoutFacilty = new System.Windows.Forms.RadioButton();
            this.Facilty = new System.Windows.Forms.RadioButton();
            this.FaciltyAll = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RS2 = new System.Windows.Forms.RadioButton();
            this.RS1 = new System.Windows.Forms.RadioButton();
            this.Uc_Branch = new Report_Pro.MyControls.UC_Branch();
            this.Uc_Acc = new Report_Pro.MyControls.UC_Acc();
            this.panel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_3);
            this.panel1.Controls.Add(this.btn_2);
            this.panel1.Controls.Add(this.btn_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 72);
            this.panel1.TabIndex = 52;
            // 
            // btn_3
            // 
            this.btn_3.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.btn_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_3.Location = new System.Drawing.Point(752, 16);
            this.btn_3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(124, 38);
            this.btn_3.TabIndex = 292;
            this.btn_3.Text = "التقرير انجليزي";
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btn_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_2.Location = new System.Drawing.Point(885, 16);
            this.btn_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(124, 38);
            this.btn_2.TabIndex = 291;
            this.btn_2.Text = "التقرير عربي";
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.btn_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_1.Location = new System.Drawing.Point(1054, 16);
            this.btn_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(124, 38);
            this.btn_1.TabIndex = 290;
            this.btn_1.Text = "خيارات";
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 72);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1200, 586);
            this.crystalReportViewer1.TabIndex = 53;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.ToolPanelWidth = 300;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.groupBox3);
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Controls.Add(this.Uc_Branch);
            this.groupPanel1.Controls.Add(this.Uc_Acc);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 72);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1200, 196);
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
            this.groupPanel1.TabIndex = 54;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(1092, 56);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(63, 24);
            this.labelX2.TabIndex = 55;
            this.labelX2.Text = "الحساب";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(1092, 18);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(42, 24);
            this.labelX1.TabIndex = 54;
            this.labelX1.Text = "الفرع";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.WithoutFacilty);
            this.groupBox3.Controls.Add(this.Facilty);
            this.groupBox3.Controls.Add(this.FaciltyAll);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(170, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(198, 155);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "التسهيلات الائتمانية";
            // 
            // WithoutFacilty
            // 
            this.WithoutFacilty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WithoutFacilty.AutoSize = true;
            this.WithoutFacilty.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithoutFacilty.Location = new System.Drawing.Point(46, 114);
            this.WithoutFacilty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WithoutFacilty.Name = "WithoutFacilty";
            this.WithoutFacilty.Size = new System.Drawing.Size(136, 25);
            this.WithoutFacilty.TabIndex = 36;
            this.WithoutFacilty.Text = "بدون تسهيلات";
            this.WithoutFacilty.UseVisualStyleBackColor = true;
            // 
            // Facilty
            // 
            this.Facilty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Facilty.AutoSize = true;
            this.Facilty.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facilty.Location = new System.Drawing.Point(27, 80);
            this.Facilty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Facilty.Name = "Facilty";
            this.Facilty.Size = new System.Drawing.Size(154, 25);
            this.Facilty.TabIndex = 34;
            this.Facilty.Text = "تسهيلات معتمدة";
            this.Facilty.UseVisualStyleBackColor = true;
            // 
            // FaciltyAll
            // 
            this.FaciltyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FaciltyAll.AutoSize = true;
            this.FaciltyAll.Checked = true;
            this.FaciltyAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaciltyAll.Location = new System.Drawing.Point(99, 47);
            this.FaciltyAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FaciltyAll.Name = "FaciltyAll";
            this.FaciltyAll.Size = new System.Drawing.Size(82, 25);
            this.FaciltyAll.TabIndex = 35;
            this.FaciltyAll.TabStop = true;
            this.FaciltyAll.Text = "الجميع";
            this.FaciltyAll.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RS2);
            this.groupBox1.Controls.Add(this.RS1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(376, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(198, 115);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حالة الحساب";
            // 
            // RS2
            // 
            this.RS2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RS2.AutoSize = true;
            this.RS2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS2.Location = new System.Drawing.Point(14, 69);
            this.RS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RS2.Name = "RS2";
            this.RS2.Size = new System.Drawing.Size(167, 25);
            this.RS2.TabIndex = 34;
            this.RS2.Text = "الحسابات المتوقفه";
            this.RS2.UseVisualStyleBackColor = true;
            // 
            // RS1
            // 
            this.RS1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RS1.AutoSize = true;
            this.RS1.Checked = true;
            this.RS1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS1.Location = new System.Drawing.Point(99, 35);
            this.RS1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RS1.Name = "RS1";
            this.RS1.Size = new System.Drawing.Size(82, 25);
            this.RS1.TabIndex = 35;
            this.RS1.TabStop = true;
            this.RS1.Text = "الجميع";
            this.RS1.UseVisualStyleBackColor = true;
            // 
            // Uc_Branch
            // 
            this.Uc_Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Uc_Branch.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Branch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Uc_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.Uc_Branch.Location = new System.Drawing.Point(621, 13);
            this.Uc_Branch.Margin = new System.Windows.Forms.Padding(0);
            this.Uc_Branch.Name = "Uc_Branch";
            this.Uc_Branch.Size = new System.Drawing.Size(463, 32);
            this.Uc_Branch.TabIndex = 1;
            // 
            // Uc_Acc
            // 
            this.Uc_Acc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Uc_Acc.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Acc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Uc_Acc.Location = new System.Drawing.Point(621, 51);
            this.Uc_Acc.Margin = new System.Windows.Forms.Padding(0);
            this.Uc_Acc.Name = "Uc_Acc";
            this.Uc_Acc.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Uc_Acc.Size = new System.Drawing.Size(463, 32);
            this.Uc_Acc.TabIndex = 0;
            // 
            // frm_customer_Facility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_customer_Facility";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تقرير تسهيلات العملاء";
            this.Load += new System.EventHandler(this.frm_customer_Facility_Load);
            this.panel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btn_3;
        private DevComponents.DotNetBar.ButtonX btn_2;
        private DevComponents.DotNetBar.ButtonX btn_1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private MyControls.UC_Branch Uc_Branch;
        private MyControls.UC_Acc Uc_Acc;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.RadioButton WithoutFacilty;
        internal System.Windows.Forms.RadioButton Facilty;
        internal System.Windows.Forms.RadioButton FaciltyAll;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton RS2;
        internal System.Windows.Forms.RadioButton RS1;
    }
}