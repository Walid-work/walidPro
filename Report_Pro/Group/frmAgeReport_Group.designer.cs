namespace Report_Pro.Group
{
    partial class frmAgeReport_Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgeReport_Group));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.rM_120 = new System.Windows.Forms.RadioButton();
            this.rM_150 = new System.Windows.Forms.RadioButton();
            this.rM_180 = new System.Windows.Forms.RadioButton();
            this.rAll = new System.Windows.Forms.RadioButton();
            this.rM_30 = new System.Windows.Forms.RadioButton();
            this.rM_60 = new System.Windows.Forms.RadioButton();
            this.rM_90 = new System.Windows.Forms.RadioButton();
            this.Uc_Acc = new Report_Pro.MyControls.UC_Acc();
            this.Uc_Cost = new Report_Pro.MyControls.UC_cost();
            this.Uc_Catogry = new Report_Pro.MyControls.UC_Catogry();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Uc_Branch = new Report_Pro.MyControls.UC_AccBranch();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            resources.ApplyResources(this.crystalReportViewer1, "crystalReportViewer1");
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // FromDate
            // 
            resources.ApplyResources(this.FromDate, "FromDate");
            this.FromDate.Name = "FromDate";
            // 
            // ToDate
            // 
            resources.ApplyResources(this.ToDate, "ToDate");
            this.ToDate.Name = "ToDate";
            // 
            // rM_120
            // 
            resources.ApplyResources(this.rM_120, "rM_120");
            this.rM_120.Name = "rM_120";
            this.rM_120.UseVisualStyleBackColor = true;
            // 
            // rM_150
            // 
            resources.ApplyResources(this.rM_150, "rM_150");
            this.rM_150.Name = "rM_150";
            this.rM_150.UseVisualStyleBackColor = true;
            // 
            // rM_180
            // 
            resources.ApplyResources(this.rM_180, "rM_180");
            this.rM_180.Name = "rM_180";
            this.rM_180.UseVisualStyleBackColor = true;
            // 
            // rAll
            // 
            resources.ApplyResources(this.rAll, "rAll");
            this.rAll.Checked = true;
            this.rAll.Name = "rAll";
            this.rAll.TabStop = true;
            this.rAll.UseCompatibleTextRendering = true;
            this.rAll.UseVisualStyleBackColor = true;
            // 
            // rM_30
            // 
            resources.ApplyResources(this.rM_30, "rM_30");
            this.rM_30.Name = "rM_30";
            this.rM_30.UseVisualStyleBackColor = true;
            // 
            // rM_60
            // 
            resources.ApplyResources(this.rM_60, "rM_60");
            this.rM_60.Name = "rM_60";
            this.rM_60.UseVisualStyleBackColor = true;
            // 
            // rM_90
            // 
            resources.ApplyResources(this.rM_90, "rM_90");
            this.rM_90.Name = "rM_90";
            this.rM_90.UseVisualStyleBackColor = true;
            // 
            // Uc_Acc
            // 
            resources.ApplyResources(this.Uc_Acc, "Uc_Acc");
            this.Uc_Acc.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Acc.Name = "Uc_Acc";
            this.Uc_Acc.Click += new System.EventHandler(this.Uc_Acc_Click);
            // 
            // Uc_Cost
            // 
            resources.ApplyResources(this.Uc_Cost, "Uc_Cost");
            this.Uc_Cost.Name = "Uc_Cost";
            // 
            // Uc_Catogry
            // 
            resources.ApplyResources(this.Uc_Catogry, "Uc_Catogry");
            this.Uc_Catogry.Name = "Uc_Catogry";
            this.Uc_Catogry.Load += new System.EventHandler(this.Uc_Catogry_Load);
            // 
            // groupPanel1
            // 
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.Uc_Branch);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.Uc_Catogry);
            this.groupPanel1.Controls.Add(this.Uc_Cost);
            this.groupPanel1.Controls.Add(this.Uc_Acc);
            this.groupPanel1.Controls.Add(this.rM_90);
            this.groupPanel1.Controls.Add(this.rM_60);
            this.groupPanel1.Controls.Add(this.rM_30);
            this.groupPanel1.Controls.Add(this.rAll);
            this.groupPanel1.Controls.Add(this.rM_180);
            this.groupPanel1.Controls.Add(this.rM_150);
            this.groupPanel1.Controls.Add(this.rM_120);
            this.groupPanel1.Controls.Add(this.ToDate);
            this.groupPanel1.Controls.Add(this.FromDate);
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
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Name = "label1";
            // 
            // Uc_Branch
            // 
            resources.ApplyResources(this.Uc_Branch, "Uc_Branch");
            this.Uc_Branch.Name = "Uc_Branch";
            this.Uc_Branch.Load += new System.EventHandler(this.Uc_Branch_Load);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Name = "label3";
            // 
            // frmAgeReport_Group
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmAgeReport_Group";
            this.Load += new System.EventHandler(this.frmAgeReport_Load);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.groupPanel1, 0);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.RadioButton rM_120;
        private System.Windows.Forms.RadioButton rM_150;
        private System.Windows.Forms.RadioButton rM_180;
        private System.Windows.Forms.RadioButton rAll;
        private System.Windows.Forms.RadioButton rM_30;
        private System.Windows.Forms.RadioButton rM_60;
        private System.Windows.Forms.RadioButton rM_90;
        private MyControls.UC_Acc Uc_Acc;
        private MyControls.UC_cost Uc_Cost;
        private MyControls.UC_Catogry Uc_Catogry;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MyControls.UC_AccBranch Uc_Branch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}