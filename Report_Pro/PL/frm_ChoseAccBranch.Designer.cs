namespace Report_Pro.PL
{
    partial class frm_ChoseAccBranch
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
            this.GroupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TV1 = new System.Windows.Forms.TreeView();
            this.GroupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPanel2
            // 
            this.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupPanel2.Controls.Add(this.TV1);
            this.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupPanel2.Location = new System.Drawing.Point(0, 0);
            this.GroupPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupPanel2.Name = "GroupPanel2";
            this.GroupPanel2.Size = new System.Drawing.Size(442, 468);
            // 
            // 
            // 
            this.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GroupPanel2.Style.BackColorGradientAngle = 90;
            this.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderBottomWidth = 1;
            this.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderLeftWidth = 1;
            this.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderRightWidth = 1;
            this.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel2.Style.BorderTopWidth = 1;
            this.GroupPanel2.Style.CornerDiameter = 4;
            this.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.GroupPanel2.TabIndex = 38;
            // 
            // TV1
            // 
            this.TV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TV1.Location = new System.Drawing.Point(0, 0);
            this.TV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TV1.Name = "TV1";
            this.TV1.RightToLeftLayout = true;
            this.TV1.Size = new System.Drawing.Size(436, 462);
            this.TV1.TabIndex = 0;
            this.TV1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV1_AfterSelect);
            this.TV1.DoubleClick += new System.EventHandler(this.TV1_DoubleClick);
            // 
            // frm_ChoseAccBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 468);
            this.Controls.Add(this.GroupPanel2);
            this.Name = "frm_ChoseAccBranch";
            this.Text = "frm_ChoseAccBranch";
            this.Load += new System.EventHandler(this.frm_ChoseAccBranch_Load);
            this.GroupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel2;
        internal System.Windows.Forms.TreeView TV1;
    }
}