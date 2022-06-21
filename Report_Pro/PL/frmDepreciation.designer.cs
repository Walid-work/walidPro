namespace Report_Pro.PL
{
    partial class frmDepreciation
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
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.depreciationDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnCalculate = new DevComponents.DotNetBar.ButtonX();
            this.btnPreview = new DevComponents.DotNetBar.ButtonX();
            this.Asset_2 = new Report_Pro.MyControls.UC_Asset();
            this.Asset_1 = new Report_Pro.MyControls.UC_Asset();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX50 = new DevComponents.DotNetBar.LabelX();
            this.AccBranch = new Report_Pro.MyControls.UC_AccBranch();
            this.cmbLocation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbGroup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.depreciationDate);
            this.groupPanel1.Controls.Add(this.btnCalculate);
            this.groupPanel1.Controls.Add(this.btnPreview);
            this.groupPanel1.Controls.Add(this.Asset_2);
            this.groupPanel1.Controls.Add(this.Asset_1);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.labelX50);
            this.groupPanel1.Controls.Add(this.AccBranch);
            this.groupPanel1.Controls.Add(this.cmbLocation);
            this.groupPanel1.Controls.Add(this.labelX22);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.cmbGroup);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1036, 163);
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
            this.groupPanel1.TabIndex = 0;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(476, 84);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(115, 20);
            this.labelX3.TabIndex = 58;
            this.labelX3.Text = "Depreciation Date";
            // 
            // depreciationDate
            // 
            // 
            // 
            // 
            this.depreciationDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.depreciationDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.depreciationDate.ButtonDropDown.Visible = true;
            this.depreciationDate.Location = new System.Drawing.Point(599, 81);
            this.depreciationDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            // 
            // 
            // 
            this.depreciationDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.depreciationDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.depreciationDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.depreciationDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.depreciationDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.depreciationDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.depreciationDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.depreciationDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.depreciationDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.depreciationDate.MonthCalendar.DisplayMonth = new System.DateTime(2020, 8, 1, 0, 0, 0, 0);
            this.depreciationDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.depreciationDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.depreciationDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.depreciationDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.depreciationDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.depreciationDate.MonthCalendar.TodayButtonVisible = true;
            this.depreciationDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.depreciationDate.Name = "depreciationDate";
            this.depreciationDate.Size = new System.Drawing.Size(156, 24);
            this.depreciationDate.TabIndex = 57;
            this.depreciationDate.Click += new System.EventHandler(this.depreciationDate_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCalculate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCalculate.Location = new System.Drawing.Point(669, 115);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 32);
            this.btnCalculate.TabIndex = 56;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPreview.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPreview.Location = new System.Drawing.Point(552, 115);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(112, 32);
            this.btnPreview.TabIndex = 55;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Asset_2
            // 
            this.Asset_2.Location = new System.Drawing.Point(599, 46);
            this.Asset_2.Margin = new System.Windows.Forms.Padding(0);
            this.Asset_2.Name = "Asset_2";
            this.Asset_2.Size = new System.Drawing.Size(373, 23);
            this.Asset_2.TabIndex = 54;
            // 
            // Asset_1
            // 
            this.Asset_1.Location = new System.Drawing.Point(599, 15);
            this.Asset_1.Margin = new System.Windows.Forms.Padding(0);
            this.Asset_1.Name = "Asset_1";
            this.Asset_1.Size = new System.Drawing.Size(373, 23);
            this.Asset_1.TabIndex = 53;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(532, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(59, 20);
            this.labelX2.TabIndex = 52;
            this.labelX2.Text = "To Asset";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(516, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 20);
            this.labelX1.TabIndex = 51;
            this.labelX1.Text = "From Asset";
            // 
            // labelX50
            // 
            this.labelX50.AutoSize = true;
            this.labelX50.BackColor = System.Drawing.Color.Transparent;
            this.labelX50.Location = new System.Drawing.Point(16, 19);
            this.labelX50.Name = "labelX50";
            this.labelX50.Size = new System.Drawing.Size(49, 20);
            this.labelX50.TabIndex = 50;
            this.labelX50.Text = "Branch";
            // 
            // AccBranch
            // 
            this.AccBranch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AccBranch.Location = new System.Drawing.Point(73, 17);
            this.AccBranch.Margin = new System.Windows.Forms.Padding(0);
            this.AccBranch.Name = "AccBranch";
            this.AccBranch.Size = new System.Drawing.Size(374, 27);
            this.AccBranch.TabIndex = 49;
            // 
            // cmbLocation
            // 
            this.cmbLocation.DisplayMember = "Text";
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.ItemHeight = 16;
            this.cmbLocation.Location = new System.Drawing.Point(73, 49);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(374, 24);
            this.cmbLocation.TabIndex = 48;
            // 
            // labelX22
            // 
            this.labelX22.AutoSize = true;
            this.labelX22.BackColor = System.Drawing.Color.Transparent;
            this.labelX22.Location = new System.Drawing.Point(7, 53);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(58, 20);
            this.labelX22.TabIndex = 47;
            this.labelX22.Text = "Location";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(21, 83);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(44, 20);
            this.labelX5.TabIndex = 46;
            this.labelX5.Text = "Group";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DisplayMember = "Text";
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.ItemHeight = 16;
            this.cmbGroup.Location = new System.Drawing.Point(73, 79);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(374, 24);
            this.cmbGroup.TabIndex = 45;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel2.Location = new System.Drawing.Point(0, 436);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1036, 83);
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
            this.groupPanel2.TabIndex = 1;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv1.Location = new System.Drawing.Point(0, 163);
            this.dgv1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 29;
            this.dgv1.Size = new System.Drawing.Size(1036, 273);
            this.dgv1.TabIndex = 2;
            // 
            // frmDepreciation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 519);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmDepreciation";
            this.Text = "frmDeterioration";
            this.Load += new System.EventHandler(this.frmDeterioration_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX50;
        private MyControls.UC_AccBranch AccBranch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLocation;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbGroup;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnCalculate;
        private DevComponents.DotNetBar.ButtonX btnPreview;
        private MyControls.UC_Asset Asset_2;
        private MyControls.UC_Asset Asset_1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput depreciationDate;
    }
}