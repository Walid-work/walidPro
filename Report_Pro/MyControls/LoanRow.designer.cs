namespace Report_Pro.MyControls
{
    partial class LoanRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanRow));
            this.paySer = new DevComponents.Editors.IntegerInput();
            this.startDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.maturityDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.PayValue = new DevComponents.Editors.DoubleInput();
            this.intrestRate = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.paySer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maturityDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrestRate)).BeginInit();
            this.SuspendLayout();
            // 
            // paySer
            // 
            // 
            // 
            // 
            this.paySer.BackgroundStyle.Class = "DateTimeInputBackground";
            this.paySer.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.paySer.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.paySer.DisabledBackColor = System.Drawing.SystemColors.Highlight;
            this.paySer.DisabledForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.paySer, "paySer");
            this.paySer.Name = "paySer";
            // 
            // startDate
            // 
            // 
            // 
            // 
            this.startDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.startDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.startDate.ButtonDropDown.Visible = true;
            this.startDate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.startDate, "startDate");
            // 
            // 
            // 
            this.startDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("startDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.startDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.startDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.startDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.startDate.MonthCalendar.DisplayMonth = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.startDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("startDate.MonthCalendar.MarkedDates")));
            this.startDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("startDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.startDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.startDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.startDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.startDate.MonthCalendar.TodayButtonVisible = true;
            this.startDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("startDate.MonthCalendar.WeeklyMarkedDays")));
            this.startDate.Name = "startDate";
            this.startDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startDate_KeyDown);
            // 
            // maturityDate
            // 
            // 
            // 
            // 
            this.maturityDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.maturityDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.maturityDate.ButtonDropDown.Visible = true;
            this.maturityDate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.maturityDate, "maturityDate");
            // 
            // 
            // 
            this.maturityDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("maturityDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.maturityDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.maturityDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.maturityDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.maturityDate.MonthCalendar.DisplayMonth = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.maturityDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("maturityDate.MonthCalendar.MarkedDates")));
            this.maturityDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("maturityDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.maturityDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.maturityDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.maturityDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.maturityDate.MonthCalendar.TodayButtonVisible = true;
            this.maturityDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("maturityDate.MonthCalendar.WeeklyMarkedDays")));
            this.maturityDate.Name = "maturityDate";
            this.maturityDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maturityDate_KeyDown);
            // 
            // PayValue
            // 
            // 
            // 
            // 
            this.PayValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.PayValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.PayValue.Increment = 1D;
            resources.ApplyResources(this.PayValue, "PayValue");
            this.PayValue.Name = "PayValue";
            this.PayValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PayValue_KeyDown);
            // 
            // intrestRate
            // 
            // 
            // 
            // 
            this.intrestRate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intrestRate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intrestRate.DisplayFormat = "#,##0.0000";
            this.intrestRate.Increment = 1D;
            resources.ApplyResources(this.intrestRate, "intrestRate");
            this.intrestRate.Name = "intrestRate";
            this.intrestRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.intrestRate_KeyDown);
            // 
            // LoanRow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intrestRate);
            this.Controls.Add(this.PayValue);
            this.Controls.Add(this.maturityDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.paySer);
            this.Name = "LoanRow";
            ((System.ComponentModel.ISupportInitialize)(this.paySer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maturityDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrestRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevComponents.Editors.IntegerInput paySer;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput startDate;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput maturityDate;
        public DevComponents.Editors.DoubleInput PayValue;
        public DevComponents.Editors.DoubleInput intrestRate;
    }
}
