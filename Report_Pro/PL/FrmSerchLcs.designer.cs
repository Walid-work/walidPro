namespace Report_Pro.PL
{ 
    partial class FrmSerchLcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerchLcs));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtlcNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPreformNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSupplier = new Report_Pro.MyControls.UC_Acc();
            this.txtBank = new Report_Pro.MyControls.UC_Acc();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnSearch);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtlcNo);
            this.groupPanel1.Controls.Add(this.txtPreformNo);
            this.groupPanel1.Controls.Add(this.txtSupplier);
            this.groupPanel1.Controls.Add(this.txtBank);
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
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // txtlcNo
            // 
            resources.ApplyResources(this.txtlcNo, "txtlcNo");
            // 
            // 
            // 
            this.txtlcNo.Border.Class = "TextBoxBorder";
            this.txtlcNo.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtlcNo.ButtonCustom.DisplayPosition")));
            this.txtlcNo.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtlcNo.ButtonCustom.Image")));
            this.txtlcNo.ButtonCustom.Text = resources.GetString("txtlcNo.ButtonCustom.Text");
            this.txtlcNo.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtlcNo.ButtonCustom2.DisplayPosition")));
            this.txtlcNo.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtlcNo.ButtonCustom2.Image")));
            this.txtlcNo.ButtonCustom2.Text = resources.GetString("txtlcNo.ButtonCustom2.Text");
            this.txtlcNo.Name = "txtlcNo";
            this.txtlcNo.TextChanged += new System.EventHandler(this.txtlcNo_TextChanged);
            this.txtlcNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtlcNo_KeyUp);
            // 
            // txtPreformNo
            // 
            resources.ApplyResources(this.txtPreformNo, "txtPreformNo");
            // 
            // 
            // 
            this.txtPreformNo.Border.Class = "TextBoxBorder";
            this.txtPreformNo.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtPreformNo.ButtonCustom.DisplayPosition")));
            this.txtPreformNo.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtPreformNo.ButtonCustom.Image")));
            this.txtPreformNo.ButtonCustom.Text = resources.GetString("txtPreformNo.ButtonCustom.Text");
            this.txtPreformNo.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtPreformNo.ButtonCustom2.DisplayPosition")));
            this.txtPreformNo.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtPreformNo.ButtonCustom2.Image")));
            this.txtPreformNo.ButtonCustom2.Text = resources.GetString("txtPreformNo.ButtonCustom2.Text");
            this.txtPreformNo.Name = "txtPreformNo";
            this.txtPreformNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPreformNo_KeyUp);
            // 
            // txtSupplier
            // 
            resources.ApplyResources(this.txtSupplier, "txtSupplier");
            this.txtSupplier.BackColor = System.Drawing.Color.Transparent;
            this.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSupplier_KeyUp);
            // 
            // txtBank
            // 
            resources.ApplyResources(this.txtBank, "txtBank");
            this.txtBank.BackColor = System.Drawing.Color.Transparent;
            this.txtBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBank.Name = "txtBank";
            this.txtBank.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBank_KeyUp);
            // 
            // groupPanel2
            // 
            resources.ApplyResources(this.groupPanel2, "groupPanel2");
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.DGV1);
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
            // DGV1
            // 
            resources.ApplyResources(this.DGV1, "DGV1");
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.DoubleClick += new System.EventHandler(this.DGV1_DoubleClick);
            // 
            // FrmSerchLcs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FrmSerchLcs";
            this.Load += new System.EventHandler(this.FrmSerchLcs_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtlcNo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPreformNo;
        private MyControls.UC_Acc txtSupplier;
        private MyControls.UC_Acc txtBank;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        public System.Windows.Forms.DataGridView DGV1;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}