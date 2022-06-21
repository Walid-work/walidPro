namespace Report_Pro.MyControls
{
    partial class US_Date
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GD = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.HD = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "م";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "هـ";
            // 
            // GD
            // 
            this.GD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.GD.BackgroundStyle.Class = "DateTimeInputBackground";
            this.GD.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.GD.ButtonDropDown.Visible = true;
            this.GD.CustomFormat = " ";
            this.GD.Location = new System.Drawing.Point(146, 0);
            this.GD.Margin = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.GD.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.GD.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.GD.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.GD.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.GD.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.GD.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.GD.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GD.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.GD.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.GD.MonthCalendar.DisplayMonth = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.GD.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.GD.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.GD.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GD.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.GD.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GD.MonthCalendar.TodayButtonVisible = true;
            this.GD.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.GD.Name = "GD";
            this.GD.Size = new System.Drawing.Size(94, 20);
            this.GD.TabIndex = 111;
            this.GD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GD_KeyDown);
            this.GD.Leave += new System.EventHandler(this.GD_Leave);
            // 
            // HD
            // 
            this.HD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HD.Location = new System.Drawing.Point(23, 0);
            this.HD.Margin = new System.Windows.Forms.Padding(0);
            this.HD.Mask = "00/00/0000";
            this.HD.Name = "HD";
            this.HD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HD.Size = new System.Drawing.Size(87, 20);
            this.HD.TabIndex = 223;
            this.HD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HD_KeyDown_1);
            this.HD.Leave += new System.EventHandler(this.HD_Leave_1);
            // 
            // US_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.HD);
            this.Controls.Add(this.GD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "US_Date";
            this.Size = new System.Drawing.Size(240, 21);
            ((System.ComponentModel.ISupportInitialize)(this.GD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput GD;
        public System.Windows.Forms.MaskedTextBox HD;

    }
}
