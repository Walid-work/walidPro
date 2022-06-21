namespace Report_Pro.MyControls
{
    partial class JorRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JorRow));
            this.branchID = new System.Windows.Forms.TextBox();
            this.txtAcc_2 = new Report_Pro.MyControls.myText();
            this.txtVatNo = new Report_Pro.MyControls.myText();
            this.txtDocDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.ser_ = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX6 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDocument = new Report_Pro.MyControls.myText();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // branchID
            // 
            this.branchID.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.branchID, "branchID");
            this.branchID.Name = "branchID";
            // 
            // txtAcc_2
            // 
            resources.ApplyResources(this.txtAcc_2, "txtAcc_2");
            this.txtAcc_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtAcc_2, 15);
            this.tablePanel1.SetColumnSpan(this.txtAcc_2, 4);
            this.txtAcc_2.labelBackColor = System.Drawing.SystemColors.Control;
            this.txtAcc_2.lblControl = "Account 2";
            this.txtAcc_2.Name = "txtAcc_2";
            this.tablePanel1.SetRow(this.txtAcc_2, 2);
            this.txtAcc_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcc_2_KeyDown);
            // 
            // txtVatNo
            // 
            resources.ApplyResources(this.txtVatNo, "txtVatNo");
            this.txtVatNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtVatNo, 12);
            this.tablePanel1.SetColumnSpan(this.txtVatNo, 3);
            this.txtVatNo.labelBackColor = System.Drawing.SystemColors.Control;
            this.txtVatNo.lblControl = "VAT ID";
            this.txtVatNo.Name = "txtVatNo";
            this.tablePanel1.SetRow(this.txtVatNo, 2);
            this.txtVatNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVatNo_KeyDown);
            // 
            // txtDocDate
            // 
            // 
            // 
            // 
            this.txtDocDate.BackgroundStyle.Class = "TextBoxBorder";
            this.txtDocDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtDocDate.ButtonDropDown.Visible = true;
            this.tablePanel1.SetColumn(this.txtDocDate, 11);
            resources.ApplyResources(this.txtDocDate, "txtDocDate");
            this.txtDocDate.FocusHighlightEnabled = true;
            this.txtDocDate.ForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("txtDocDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtDocDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtDocDate.MonthCalendar.DisplayMonth = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.txtDocDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("txtDocDate.MonthCalendar.MarkedDates")));
            this.txtDocDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("txtDocDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtDocDate.MonthCalendar.TodayButtonVisible = true;
            this.txtDocDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("txtDocDate.MonthCalendar.WeeklyMarkedDays")));
            this.txtDocDate.Name = "txtDocDate";
            this.tablePanel1.SetRow(this.txtDocDate, 2);
            this.txtDocDate.Click += new System.EventHandler(this.txtDocDate_Click);
            this.txtDocDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocDate_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.SetColumn(this.pictureBox2, 1);
            this.pictureBox2.Image = global::Report_Pro.Properties.Resources.arow_green;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.tablePanel1.SetRow(this.pictureBox2, 1);
            this.tablePanel1.SetRowSpan(this.pictureBox2, 2);
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.SetColumn(this.pictureBox1, 7);
            this.pictureBox1.Image = global::Report_Pro.Properties.Resources.arow_red;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.tablePanel1.SetRow(this.pictureBox1, 1);
            this.tablePanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelX6
            // 
            resources.ApplyResources(this.labelX6, "labelX6");
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.SetColumn(this.labelX6, 10);
            this.labelX6.Name = "labelX6";
            this.tablePanel1.SetRow(this.labelX6, 2);
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ser_
            // 
            this.ser_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablePanel1.SetColumn(this.ser_, 0);
            resources.ApplyResources(this.ser_, "ser_");
            this.ser_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ser_.Name = "ser_";
            this.tablePanel1.SetRow(this.ser_, 0);
            this.tablePanel1.SetRowSpan(this.ser_, 3);
            this.ser_.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ser_.Click += new System.EventHandler(this.ser__Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablePanel1.SetColumn(this.label1, 0);
            this.tablePanel1.SetColumnSpan(this.label1, 19);
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 3);
            // 
            // labelX1
            // 
            this.tablePanel1.SetColumn(this.labelX1, 6);
            this.tablePanel1.SetColumnSpan(this.labelX1, 6);
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.Name = "labelX1";
            this.tablePanel1.SetRow(this.labelX1, 0);
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.tablePanel1.SetColumn(this.textBoxX1, 1);
            this.tablePanel1.SetColumnSpan(this.textBoxX1, 2);
            resources.ApplyResources(this.textBoxX1, "textBoxX1");
            this.textBoxX1.Name = "textBoxX1";
            this.tablePanel1.SetRow(this.textBoxX1, 0);
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.tablePanel1.SetColumn(this.textBoxX2, 3);
            this.tablePanel1.SetColumnSpan(this.textBoxX2, 2);
            resources.ApplyResources(this.textBoxX2, "textBoxX2");
            this.textBoxX2.Name = "textBoxX2";
            this.tablePanel1.SetRow(this.textBoxX2, 0);
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.tablePanel1.SetColumn(this.textBoxX3, 5);
            resources.ApplyResources(this.textBoxX3, "textBoxX3");
            this.textBoxX3.Name = "textBoxX3";
            this.tablePanel1.SetRow(this.textBoxX3, 0);
            // 
            // textBoxX4
            // 
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.tablePanel1.SetColumn(this.textBoxX4, 12);
            resources.ApplyResources(this.textBoxX4, "textBoxX4");
            this.textBoxX4.Name = "textBoxX4";
            this.tablePanel1.SetRow(this.textBoxX4, 0);
            // 
            // tablePanel1
            // 
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15.72F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 73.37F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 42.41F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 46.55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 67.05F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 41.16F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15.34F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.35F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 77.95F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 69.17F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30.55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 85.57F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.02F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.97F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 61.3F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 59.22F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.textBox1);
            this.tablePanel1.Controls.Add(this.label4);
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.textBoxX6);
            this.tablePanel1.Controls.Add(this.textBoxX5);
            this.tablePanel1.Controls.Add(this.textBoxX4);
            this.tablePanel1.Controls.Add(this.textBoxX3);
            this.tablePanel1.Controls.Add(this.textBoxX2);
            this.tablePanel1.Controls.Add(this.textBoxX1);
            this.tablePanel1.Controls.Add(this.labelX1);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Controls.Add(this.ser_);
            this.tablePanel1.Controls.Add(this.labelX6);
            this.tablePanel1.Controls.Add(this.txtDocument);
            this.tablePanel1.Controls.Add(this.pictureBox1);
            this.tablePanel1.Controls.Add(this.pictureBox2);
            this.tablePanel1.Controls.Add(this.txtDocDate);
            this.tablePanel1.Controls.Add(this.txtVatNo);
            this.tablePanel1.Controls.Add(this.txtAcc_2);
            resources.ApplyResources(this.tablePanel1, "tablePanel1");
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 24F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 15F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 24F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 15F)});
            // 
            // textBoxX5
            // 
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.tablePanel1.SetColumn(this.textBoxX5, 15);
            resources.ApplyResources(this.textBoxX5, "textBoxX5");
            this.textBoxX5.Name = "textBoxX5";
            this.tablePanel1.SetRow(this.textBoxX5, 0);
            // 
            // textBoxX6
            // 
            // 
            // 
            // 
            this.textBoxX6.Border.Class = "TextBoxBorder";
            this.tablePanel1.SetColumn(this.textBoxX6, 18);
            resources.ApplyResources(this.textBoxX6, "textBoxX6");
            this.textBoxX6.Name = "textBoxX6";
            this.tablePanel1.SetRow(this.textBoxX6, 0);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.tablePanel1.SetColumn(this.label3, 13);
            this.tablePanel1.SetColumnSpan(this.label3, 2);
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.tablePanel1.SetRow(this.label3, 0);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.tablePanel1.SetColumn(this.label4, 16);
            this.tablePanel1.SetColumnSpan(this.label4, 2);
            this.label4.Name = "label4";
            this.tablePanel1.SetRow(this.label4, 0);
            // 
            // textBox1
            // 
            this.tablePanel1.SetColumn(this.textBox1, 2);
            this.tablePanel1.SetColumnSpan(this.textBox1, 5);
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.tablePanel1.SetRow(this.textBox1, 2);
            // 
            // txtDocument
            // 
            resources.ApplyResources(this.txtDocument, "txtDocument");
            this.txtDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtDocument, 8);
            this.tablePanel1.SetColumnSpan(this.txtDocument, 2);
            this.txtDocument.labelBackColor = System.Drawing.SystemColors.Control;
            this.txtDocument.lblControl = "Document";
            this.txtDocument.Name = "txtDocument";
            this.tablePanel1.SetRow(this.txtDocument, 2);
            this.txtDocument.Load += new System.EventHandler(this.txtDocument_Load);
            this.txtDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocument_KeyDown);
            // 
            // JorRow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.branchID);
            this.Name = "JorRow";
            this.Load += new System.EventHandler(this.Jor_Row_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDocDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox branchID;
        public myText txtAcc_2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX6;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        public DevComponents.DotNetBar.LabelX ser_;
        private DevComponents.DotNetBar.LabelX labelX6;
        public myText txtDocument;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput txtDocDate;
        public myText txtVatNo;
    }
}
