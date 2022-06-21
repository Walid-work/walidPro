namespace Report_Pro.CTR
{
    partial class FeesRow
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
            this.txtDiscription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNote = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Ser = new DevComponents.Editors.IntegerInput();
            this.txtamount = new DevComponents.Editors.DoubleInput();
            this.txt_R_Date = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.Ser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_R_Date)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiscription
            // 
            // 
            // 
            // 
            this.txtDiscription.Border.Class = "TextBoxBorder";
            this.txtDiscription.FocusHighlightEnabled = true;
            this.txtDiscription.Location = new System.Drawing.Point(407, 0);
            this.txtDiscription.Margin = new System.Windows.Forms.Padding(0);
            this.txtDiscription.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(276, 24);
            this.txtDiscription.TabIndex = 1;
            this.txtDiscription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDiscription_MouseClick);
            this.txtDiscription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscription_KeyDown);
            // 
            // txtNote
            // 
            // 
            // 
            // 
            this.txtNote.Border.Class = "TextBoxBorder";
            this.txtNote.FocusHighlightEnabled = true;
            this.txtNote.Location = new System.Drawing.Point(0, 0);
            this.txtNote.Margin = new System.Windows.Forms.Padding(0);
            this.txtNote.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(257, 24);
            this.txtNote.TabIndex = 2;
            this.txtNote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNote_MouseClick);
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNote_KeyDown);
            // 
            // Ser
            // 
            this.Ser.BackColor = System.Drawing.Color.RoyalBlue;
            // 
            // 
            // 
            this.Ser.BackgroundStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.Ser.BackgroundStyle.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.Ser.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Ser.ButtonFreeText.Checked = true;
            this.Ser.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Ser.FocusHighlightEnabled = true;
            this.Ser.ForeColor = System.Drawing.SystemColors.Window;
            this.Ser.FreeTextEntryMode = true;
            this.Ser.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.Ser.Location = new System.Drawing.Point(900, 0);
            this.Ser.Margin = new System.Windows.Forms.Padding(0);
            this.Ser.MinimumSize = new System.Drawing.Size(0, 24);
            this.Ser.Name = "Ser";
            this.Ser.Size = new System.Drawing.Size(34, 24);
            this.Ser.TabIndex = 3;
            this.Ser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ser_MouseClick);
            // 
            // txtamount
            // 
            this.txtamount.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.txtamount.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtamount.BackgroundStyle.BackColor2 = System.Drawing.Color.Transparent;
            this.txtamount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtamount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtamount.FocusHighlightEnabled = true;
            this.txtamount.Increment = 0D;
            this.txtamount.Location = new System.Drawing.Point(797, 0);
            this.txtamount.Margin = new System.Windows.Forms.Padding(0);
            this.txtamount.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(103, 24);
            this.txtamount.TabIndex = 4;
            this.txtamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtamount_KeyDown_1);
            this.txtamount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtamount_KeyUp_1);
            this.txtamount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtamount_MouseClick);
            // 
            // txt_R_Date
            // 
            // 
            // 
            // 
            this.txt_R_Date.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txt_R_Date.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txt_R_Date.ButtonDropDown.Visible = true;
            this.txt_R_Date.Location = new System.Drawing.Point(257, 0);
            this.txt_R_Date.Margin = new System.Windows.Forms.Padding(0);
            this.txt_R_Date.MinimumSize = new System.Drawing.Size(0, 24);
            // 
            // 
            // 
            this.txt_R_Date.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txt_R_Date.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txt_R_Date.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txt_R_Date.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txt_R_Date.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txt_R_Date.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txt_R_Date.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_R_Date.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txt_R_Date.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txt_R_Date.MonthCalendar.DisplayMonth = new System.DateTime(2021, 3, 1, 0, 0, 0, 0);
            this.txt_R_Date.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txt_R_Date.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txt_R_Date.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txt_R_Date.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txt_R_Date.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txt_R_Date.MonthCalendar.TodayButtonVisible = true;
            this.txt_R_Date.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txt_R_Date.Name = "txt_R_Date";
            this.txt_R_Date.Size = new System.Drawing.Size(150, 24);
            this.txt_R_Date.TabIndex = 5;
            this.txt_R_Date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_R_Date_KeyDown);
            this.txt_R_Date.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_R_Date_MouseClick);
            // 
            // txtType
            // 
            this.txtType.DisplayMember = "Text";
            this.txtType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.FocusHighlightEnabled = true;
            this.txtType.FormattingEnabled = true;
            this.txtType.ItemHeight = 18;
            this.txtType.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5});
            this.txtType.Location = new System.Drawing.Point(683, 0);
            this.txtType.Margin = new System.Windows.Forms.Padding(0);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(115, 24);
            this.txtType.TabIndex = 6;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            this.txtType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtType_KeyDown);
            this.txtType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtType_MouseClick);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "نقدي";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "سلف";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "شيكات";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "فواتير";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "اخري";
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = global::Report_Pro.Properties.Resources.Cross_icon1;
            this.btnDelete.Location = new System.Drawing.Point(934, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(29, 24);
            this.btnDelete.TabIndex = 296;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FeesRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txt_R_Date);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.Ser);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtDiscription);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FeesRow";
            this.Size = new System.Drawing.Size(965, 25);
            this.EnabledChanged += new System.EventHandler(this.FeesRow_EnabledChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FeesRow_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.Ser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_R_Date)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevComponents.DotNetBar.Controls.TextBoxX txtDiscription;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNote;
        public DevComponents.Editors.IntegerInput Ser;
        public DevComponents.Editors.DoubleInput txtamount;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput txt_R_Date;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        public DevComponents.DotNetBar.Controls.ComboBoxEx txtType;
        private DevComponents.DotNetBar.ButtonX btnDelete;
    }
}
