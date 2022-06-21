namespace Report_Pro.RPT
{
    partial class frm_statment_Many_Rpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_statment_Many_Rpt));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonX9 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.UC_Acc1 = new Report_Pro.MyControls.UC_Acc();
            this.uC_Acc2 = new Report_Pro.MyControls.UC_Acc();
            this.uC_Acc5 = new Report_Pro.MyControls.UC_Acc();
            this.uC_Acc3 = new Report_Pro.MyControls.UC_Acc();
            this.uC_Acc4 = new Report_Pro.MyControls.UC_Acc();
            this.UC_Catogry1 = new Report_Pro.MyControls.UC_Catogry();
            this.UC_cost1 = new Report_Pro.MyControls.UC_cost();
            this.UC_Branch = new Report_Pro.MyControls.UC_Branch();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.chB_1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.buttonX9);
            this.panel2.Controls.Add(this.buttonX5);
            this.panel2.Controls.Add(this.buttonX6);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // buttonX9
            // 
            this.buttonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            resources.ApplyResources(this.buttonX9, "buttonX9");
            this.buttonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX9.Name = "buttonX9";
            this.buttonX9.Click += new System.EventHandler(this.buttonX9_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            resources.ApplyResources(this.buttonX5, "buttonX5");
            this.buttonX5.Name = "buttonX5";
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            resources.ApplyResources(this.buttonX6, "buttonX6");
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.crystalReportViewer1, "crystalReportViewer1");
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Controls.Add(this.UC_Catogry1);
            this.groupPanel1.Controls.Add(this.UC_cost1);
            this.groupPanel1.Controls.Add(this.UC_Branch);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.ToDate);
            this.groupPanel1.Controls.Add(this.FromDate);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.chB_1);
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.Name = "groupPanel1";
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
            // 
            // groupPanel2
            // 
            resources.ApplyResources(this.groupPanel2, "groupPanel2");
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.UC_Acc1);
            this.groupPanel2.Controls.Add(this.uC_Acc2);
            this.groupPanel2.Controls.Add(this.uC_Acc5);
            this.groupPanel2.Controls.Add(this.uC_Acc3);
            this.groupPanel2.Controls.Add(this.uC_Acc4);
            this.groupPanel2.Name = "groupPanel2";
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
            // 
            // UC_Acc1
            // 
            resources.ApplyResources(this.UC_Acc1, "UC_Acc1");
            this.UC_Acc1.BackColor = System.Drawing.Color.Transparent;
            this.UC_Acc1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Acc1.Name = "UC_Acc1";
            // 
            // uC_Acc2
            // 
            resources.ApplyResources(this.uC_Acc2, "uC_Acc2");
            this.uC_Acc2.BackColor = System.Drawing.Color.Transparent;
            this.uC_Acc2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Acc2.Name = "uC_Acc2";
            // 
            // uC_Acc5
            // 
            resources.ApplyResources(this.uC_Acc5, "uC_Acc5");
            this.uC_Acc5.BackColor = System.Drawing.Color.Transparent;
            this.uC_Acc5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Acc5.Name = "uC_Acc5";
            // 
            // uC_Acc3
            // 
            resources.ApplyResources(this.uC_Acc3, "uC_Acc3");
            this.uC_Acc3.BackColor = System.Drawing.Color.Transparent;
            this.uC_Acc3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Acc3.Name = "uC_Acc3";
            // 
            // uC_Acc4
            // 
            resources.ApplyResources(this.uC_Acc4, "uC_Acc4");
            this.uC_Acc4.BackColor = System.Drawing.Color.Transparent;
            this.uC_Acc4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Acc4.Name = "uC_Acc4";
            // 
            // UC_Catogry1
            // 
            resources.ApplyResources(this.UC_Catogry1, "UC_Catogry1");
            this.UC_Catogry1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Catogry1.Name = "UC_Catogry1";
            // 
            // UC_cost1
            // 
            resources.ApplyResources(this.UC_cost1, "UC_cost1");
            this.UC_cost1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_cost1.Name = "UC_cost1";
            // 
            // UC_Branch
            // 
            resources.ApplyResources(this.UC_Branch, "UC_Branch");
            this.UC_Branch.BackColor = System.Drawing.Color.Transparent;
            this.UC_Branch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.UC_Branch.Name = "UC_Branch";
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
            // labelX3
            // 
            resources.ApplyResources(this.labelX3, "labelX3");
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Name = "labelX3";
            // 
            // ToDate
            // 
            resources.ApplyResources(this.ToDate, "ToDate");
            this.ToDate.Name = "ToDate";
            // 
            // FromDate
            // 
            resources.ApplyResources(this.FromDate, "FromDate");
            this.FromDate.Name = "FromDate";
            // 
            // labelX2
            // 
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Name = "labelX2";
            // 
            // labelX1
            // 
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Name = "labelX1";
            // 
            // chB_1
            // 
            resources.ApplyResources(this.chB_1, "chB_1");
            this.chB_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chB_1.Name = "chB_1";
            // 
            // frm_statment_Many_Rpt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel2);
            this.Name = "frm_statment_Many_Rpt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_statment_Rpt_Load);
            this.panel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chB_1;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private MyControls.UC_cost uC_cost;
        public MyControls.UC_Acc UC_Acc;
        private MyControls.UC_Branch uC_Branch1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private MyControls.UC_Catogry uC_Catogry;
        private MyControls.UC_Catogry UC_Catogry1;
        private MyControls.UC_cost UC_cost1;
        private MyControls.UC_Branch UC_Branch;
        public MyControls.UC_Acc UC_Acc1;
        public DevComponents.DotNetBar.ButtonX buttonX9;
        public MyControls.UC_Acc uC_Acc5;
        public MyControls.UC_Acc uC_Acc4;
        public MyControls.UC_Acc uC_Acc3;
        public MyControls.UC_Acc uC_Acc2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
    }
}