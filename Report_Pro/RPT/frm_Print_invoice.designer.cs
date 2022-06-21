namespace Report_Pro.RPT
{
    partial class frm_Print_invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Print_invoice));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtSer_1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtSer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtYear = new DevComponents.Editors.IntegerInput();
            this.Transaction = new Report_Pro.MyControls.UC_Transaction();
            this.Branch = new Report_Pro.MyControls.UC_Branch();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.buttonX4);
            this.groupPanel1.Controls.Add(this.buttonX3);
            this.groupPanel1.Controls.Add(this.buttonX2);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.txtSer_1);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.btnPrint);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtSer);
            this.groupPanel1.Controls.Add(this.txtYear);
            this.groupPanel1.Controls.Add(this.Transaction);
            this.groupPanel1.Controls.Add(this.Branch);
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
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // buttonX4
            // 
            resources.ApplyResources(this.buttonX4, "buttonX4");
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Image = global::Report_Pro.Properties.Resources.printer_icon;
            this.buttonX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX3
            // 
            resources.ApplyResources(this.buttonX3, "buttonX3");
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Image = global::Report_Pro.Properties.Resources.printer_icon;
            this.buttonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX2
            // 
            resources.ApplyResources(this.buttonX2, "buttonX2");
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::Report_Pro.Properties.Resources.printer_icon;
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            resources.ApplyResources(this.buttonX1, "buttonX1");
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX6
            // 
            resources.ApplyResources(this.labelX6, "labelX6");
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Name = "labelX6";
            this.labelX6.Click += new System.EventHandler(this.labelX6_Click);
            // 
            // txtSer_1
            // 
            resources.ApplyResources(this.txtSer_1, "txtSer_1");
            // 
            // 
            // 
            this.txtSer_1.Border.Class = "TextBoxBorder";
            this.txtSer_1.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtSer_1.ButtonCustom.DisplayPosition")));
            this.txtSer_1.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtSer_1.ButtonCustom.Image")));
            this.txtSer_1.ButtonCustom.Text = resources.GetString("txtSer_1.ButtonCustom.Text");
            this.txtSer_1.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtSer_1.ButtonCustom2.DisplayPosition")));
            this.txtSer_1.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtSer_1.ButtonCustom2.Image")));
            this.txtSer_1.ButtonCustom2.Text = resources.GetString("txtSer_1.ButtonCustom2.Text");
            this.txtSer_1.Name = "txtSer_1";
            // 
            // labelX4
            // 
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Name = "labelX4";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Image = global::Report_Pro.Properties.Resources.printer_icon;
            this.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // txtSer
            // 
            resources.ApplyResources(this.txtSer, "txtSer");
            // 
            // 
            // 
            this.txtSer.Border.Class = "TextBoxBorder";
            this.txtSer.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtSer.ButtonCustom.DisplayPosition")));
            this.txtSer.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtSer.ButtonCustom.Image")));
            this.txtSer.ButtonCustom.Text = resources.GetString("txtSer.ButtonCustom.Text");
            this.txtSer.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtSer.ButtonCustom2.DisplayPosition")));
            this.txtSer.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtSer.ButtonCustom2.Image")));
            this.txtSer.ButtonCustom2.Text = resources.GetString("txtSer.ButtonCustom2.Text");
            this.txtSer.Name = "txtSer";
            // 
            // txtYear
            // 
            resources.ApplyResources(this.txtYear, "txtYear");
            // 
            // 
            // 
            this.txtYear.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtYear.ButtonClear.DisplayPosition = ((int)(resources.GetObject("txtYear.ButtonClear.DisplayPosition")));
            this.txtYear.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("txtYear.ButtonClear.Image")));
            this.txtYear.ButtonClear.Text = resources.GetString("txtYear.ButtonClear.Text");
            this.txtYear.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtYear.ButtonCustom.DisplayPosition")));
            this.txtYear.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtYear.ButtonCustom.Image")));
            this.txtYear.ButtonCustom.Text = resources.GetString("txtYear.ButtonCustom.Text");
            this.txtYear.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtYear.ButtonCustom2.DisplayPosition")));
            this.txtYear.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtYear.ButtonCustom2.Image")));
            this.txtYear.ButtonCustom2.Text = resources.GetString("txtYear.ButtonCustom2.Text");
            this.txtYear.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("txtYear.ButtonDropDown.DisplayPosition")));
            this.txtYear.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("txtYear.ButtonDropDown.Image")));
            this.txtYear.ButtonDropDown.Text = resources.GetString("txtYear.ButtonDropDown.Text");
            this.txtYear.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("txtYear.ButtonFreeText.DisplayPosition")));
            this.txtYear.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("txtYear.ButtonFreeText.Image")));
            this.txtYear.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtYear.ButtonFreeText.Text = resources.GetString("txtYear.ButtonFreeText.Text");
            this.txtYear.MaxValue = 2100;
            this.txtYear.MinValue = 2010;
            this.txtYear.Name = "txtYear";
            this.txtYear.ShowUpDown = true;
            this.txtYear.Value = 2017;
            // 
            // Transaction
            // 
            resources.ApplyResources(this.Transaction, "Transaction");
            this.Transaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Transaction.Name = "Transaction";
            // 
            // Branch
            // 
            resources.ApplyResources(this.Branch, "Branch");
            this.Branch.BackColor = System.Drawing.Color.Transparent;
            this.Branch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.Branch.Name = "Branch";
            // 
            // frm_Print_invoice
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel1);
            this.Name = "frm_Print_invoice";
            this.Load += new System.EventHandler(this.frm_Print_invoice_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private MyControls.UC_Branch Branch;
        private DevComponents.Editors.IntegerInput txtYear;
        private MyControls.UC_Transaction Transaction;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSer;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSer_1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
    }
}