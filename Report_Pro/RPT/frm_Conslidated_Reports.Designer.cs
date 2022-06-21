namespace Report_Pro.RPT
{
    partial class frm_Conslidated_Reports
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
            this.x = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Branch = new Report_Pro.MyControls.UC_AccBranch();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.btn_CashMovment = new DevComponents.DotNetBar.ButtonX();
            this.x.SuspendLayout();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.CanvasColor = System.Drawing.SystemColors.Control;
            this.x.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.x.Controls.Add(this.Branch);
            this.x.Controls.Add(this.label3);
            this.x.Controls.Add(this.label2);
            this.x.Controls.Add(this.label1);
            this.x.Controls.Add(this.ToDate);
            this.x.Controls.Add(this.FromDate);
            this.x.Controls.Add(this.btn_CashMovment);
            this.x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x.Location = new System.Drawing.Point(0, 0);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(800, 450);
            // 
            // 
            // 
            this.x.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.x.Style.BackColorGradientAngle = 90;
            this.x.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.x.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.x.Style.BorderBottomWidth = 1;
            this.x.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.x.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.x.Style.BorderLeftWidth = 1;
            this.x.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.x.Style.BorderRightWidth = 1;
            this.x.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.x.Style.BorderTopWidth = 1;
            this.x.Style.CornerDiameter = 4;
            this.x.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.x.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.x.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.x.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.x.TabIndex = 0;
            // 
            // Branch
            // 
            this.Branch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Branch.Location = new System.Drawing.Point(94, 19);
            this.Branch.Margin = new System.Windows.Forms.Padding(0);
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(325, 22);
            this.Branch.TabIndex = 314;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(48, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 313;
            this.label3.Text = "Branch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(294, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 312;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 311;
            this.label1.Text = "From Date";
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(345, 47);
            this.ToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(74, 20);
            this.ToDate.TabIndex = 310;
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(94, 47);
            this.FromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(74, 20);
            this.FromDate.TabIndex = 309;
            // 
            // btn_CashMovment
            // 
            this.btn_CashMovment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_CashMovment.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_CashMovment.Location = new System.Drawing.Point(51, 97);
            this.btn_CashMovment.Name = "btn_CashMovment";
            this.btn_CashMovment.Size = new System.Drawing.Size(140, 57);
            this.btn_CashMovment.TabIndex = 0;
            this.btn_CashMovment.Text = "Cash Movment";
            this.btn_CashMovment.Click += new System.EventHandler(this.btn_CashMovment_Click);
            // 
            // frm_Conslidated_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.x);
            this.Name = "frm_Conslidated_Reports";
            this.Text = "frm_Conslidated_Reports";
            this.x.ResumeLayout(false);
            this.x.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel x;
        private DevComponents.DotNetBar.ButtonX btn_CashMovment;
        private MyControls.UC_AccBranch Branch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DateTimePicker FromDate;
    }
}