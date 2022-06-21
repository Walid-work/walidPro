namespace Report_Pro.Reports
{
    partial class frm_rpt_transport_detials_byCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rpt_transport_detials_byCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupOPtion = new DevExpress.XtraEditors.GroupControl();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.fromDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Uc_Acc = new Report_Pro.MyControls.UC_Acc();
            this.dataGridView1 = new ADGV.AdvancedDataGridView();
            this.travelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfTrips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupOPtion)).BeginInit();
            this.groupOPtion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupOPtion
            // 
            this.groupOPtion.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupOPtion.CaptionImageOptions.SvgImage")));
            this.groupOPtion.Controls.Add(this.btn_Print);
            this.groupOPtion.Controls.Add(this.simpleButton2);
            this.groupOPtion.Controls.Add(this.simpleButton1);
            this.groupOPtion.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupOPtion.Location = new System.Drawing.Point(0, 0);
            this.groupOPtion.Name = "groupOPtion";
            this.groupOPtion.ShowCaption = false;
            this.groupOPtion.Size = new System.Drawing.Size(835, 49);
            this.groupOPtion.TabIndex = 3;
            this.groupOPtion.Text = "Options";
            // 
            // btn_Print
            // 
            this.btn_Print.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Print.ImageOptions.SvgImage")));
            this.btn_Print.Location = new System.Drawing.Point(103, 8);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(84, 34);
            this.btn_Print.TabIndex = 2;
            this.btn_Print.Text = "Report";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(250, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(81, 34);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Report";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 34);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Options";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.toDate);
            this.groupControl1.Controls.Add(this.fromDate);
            this.groupControl1.Controls.Add(this.Uc_Acc);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 49);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(835, 88);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Options";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "To Date";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "From Date";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Customer";
            // 
            // toDate
            // 
            // 
            // 
            // 
            this.toDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.toDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.toDate.ButtonDropDown.Visible = true;
            this.toDate.Location = new System.Drawing.Point(100, 62);
            // 
            // 
            // 
            this.toDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.toDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.toDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.toDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.toDate.MonthCalendar.DisplayMonth = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.toDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.toDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.toDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.toDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.toDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.toDate.MonthCalendar.TodayButtonVisible = true;
            this.toDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(130, 20);
            this.toDate.TabIndex = 2;
            // 
            // fromDate
            // 
            // 
            // 
            // 
            this.fromDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.fromDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.fromDate.ButtonDropDown.Visible = true;
            this.fromDate.Location = new System.Drawing.Point(100, 36);
            // 
            // 
            // 
            this.fromDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fromDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.fromDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.fromDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.fromDate.MonthCalendar.DisplayMonth = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.fromDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.fromDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.fromDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.fromDate.MonthCalendar.TodayButtonVisible = true;
            this.fromDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(130, 20);
            this.fromDate.TabIndex = 1;
            // 
            // Uc_Acc
            // 
            this.Uc_Acc.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Acc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Uc_Acc.Location = new System.Drawing.Point(100, 10);
            this.Uc_Acc.Margin = new System.Windows.Forms.Padding(0);
            this.Uc_Acc.Name = "Uc_Acc";
            this.Uc_Acc.Padding = new System.Windows.Forms.Padding(1);
            this.Uc_Acc.Size = new System.Drawing.Size(319, 22);
            this.Uc_Acc.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateContextFilters = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.travelNo,
            this.travelDate,
            this.lineName,
            this.driverName,
            this.carPlate,
            this.NoOfTrips,
            this.amount,
            this.tax,
            this.totalAmount,
            this.Notes});
            this.dataGridView1.DateWithTime = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(835, 289);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.TimeFilter = false;
            this.dataGridView1.SortStringChanged += new System.EventHandler(this.dataGridView1_SortStringChanged);
            this.dataGridView1.FilterStringChanged += new System.EventHandler(this.dataGridView1_FilterStringChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.advancedDataGridView1_CellPainting);
            // 
            // travelNo
            // 
            this.travelNo.HeaderText = "Travel No";
            this.travelNo.MinimumWidth = 22;
            this.travelNo.Name = "travelNo";
            this.travelNo.ReadOnly = true;
            this.travelNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.travelNo.Width = 80;
            // 
            // travelDate
            // 
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.travelDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.travelDate.HeaderText = "Date";
            this.travelDate.MinimumWidth = 22;
            this.travelDate.Name = "travelDate";
            this.travelDate.ReadOnly = true;
            this.travelDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.travelDate.Width = 80;
            // 
            // lineName
            // 
            this.lineName.HeaderText = "Travel Line";
            this.lineName.MinimumWidth = 22;
            this.lineName.Name = "lineName";
            this.lineName.ReadOnly = true;
            this.lineName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.lineName.Width = 160;
            // 
            // driverName
            // 
            this.driverName.HeaderText = "Driver Name";
            this.driverName.MinimumWidth = 22;
            this.driverName.Name = "driverName";
            this.driverName.ReadOnly = true;
            this.driverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // carPlate
            // 
            this.carPlate.HeaderText = "Truck";
            this.carPlate.MinimumWidth = 22;
            this.carPlate.Name = "carPlate";
            this.carPlate.ReadOnly = true;
            this.carPlate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.carPlate.Width = 80;
            // 
            // NoOfTrips
            // 
            dataGridViewCellStyle3.Format = "N0";
            this.NoOfTrips.DefaultCellStyle = dataGridViewCellStyle3;
            this.NoOfTrips.HeaderText = "Trips";
            this.NoOfTrips.MinimumWidth = 22;
            this.NoOfTrips.Name = "NoOfTrips";
            this.NoOfTrips.ReadOnly = true;
            this.NoOfTrips.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NoOfTrips.Width = 80;
            // 
            // amount
            // 
            dataGridViewCellStyle4.Format = "N2";
            this.amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 22;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tax
            // 
            dataGridViewCellStyle5.Format = "N2";
            this.tax.DefaultCellStyle = dataGridViewCellStyle5;
            this.tax.HeaderText = "Tax";
            this.tax.MinimumWidth = 22;
            this.tax.Name = "tax";
            this.tax.ReadOnly = true;
            this.tax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // totalAmount
            // 
            dataGridViewCellStyle6.Format = "N2";
            this.totalAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalAmount.HeaderText = "Total Amount";
            this.totalAmount.MinimumWidth = 22;
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            this.totalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 22;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 426);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(835, 44);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "groupControl2";
            this.groupControl2.Visible = false;
            // 
            // frm_rpt_transport_detials_byCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupOPtion);
            this.Name = "frm_rpt_transport_detials_byCustomer";
            this.Text = "frm_rpt_transport_detials_byCustomer";
            this.Load += new System.EventHandler(this.frm_rpt_transport_detials_byCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupOPtion)).EndInit();
            this.groupOPtion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.UC_Acc Uc_Acc;
        private DevExpress.XtraEditors.GroupControl groupOPtion;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private ADGV.AdvancedDataGridView dataGridView1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput toDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput fromDate;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn carPlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfTrips;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
    }
}