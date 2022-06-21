namespace Report_Pro.RPT
{
    partial class frm_rpt_CutOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rpt_CutOff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Late_Sales = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Early_Sales = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Late_Purchase = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Early_Purchase = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Late_Sales
            // 
            this.btn_Late_Sales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Late_Sales.ImageOptions.Image")));
            this.btn_Late_Sales.Location = new System.Drawing.Point(248, 65);
            this.btn_Late_Sales.Name = "btn_Late_Sales";
            this.btn_Late_Sales.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Late_Sales.Size = new System.Drawing.Size(170, 33);
            this.btn_Late_Sales.TabIndex = 13;
            this.btn_Late_Sales.Text = "Sales Late Cut-off";
            this.btn_Late_Sales.Click += new System.EventHandler(this.btn_Late_Sales_Click_1);
            // 
            // btn_Early_Sales
            // 
            this.btn_Early_Sales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Early_Sales.ImageOptions.Image")));
            this.btn_Early_Sales.Location = new System.Drawing.Point(248, 26);
            this.btn_Early_Sales.Name = "btn_Early_Sales";
            this.btn_Early_Sales.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Early_Sales.Size = new System.Drawing.Size(170, 33);
            this.btn_Early_Sales.TabIndex = 12;
            this.btn_Early_Sales.Text = "Sales Early Cut-off";
            this.btn_Early_Sales.Click += new System.EventHandler(this.btn_Early_Sales_Click_1);
            // 
            // btn_Late_Purchase
            // 
            this.btn_Late_Purchase.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Late_Purchase.ImageOptions.SvgImage")));
            this.btn_Late_Purchase.Location = new System.Drawing.Point(424, 65);
            this.btn_Late_Purchase.Name = "btn_Late_Purchase";
            this.btn_Late_Purchase.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Late_Purchase.Size = new System.Drawing.Size(170, 33);
            this.btn_Late_Purchase.TabIndex = 11;
            this.btn_Late_Purchase.Text = "Purchase Late Cut-off";
            this.btn_Late_Purchase.Click += new System.EventHandler(this.btn_Late_Purchase_Click_1);
            // 
            // btn_Early_Purchase
            // 
            this.btn_Early_Purchase.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Early_Purchase.ImageOptions.SvgImage")));
            this.btn_Early_Purchase.Location = new System.Drawing.Point(424, 26);
            this.btn_Early_Purchase.Name = "btn_Early_Purchase";
            this.btn_Early_Purchase.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Early_Purchase.Size = new System.Drawing.Size(170, 33);
            this.btn_Early_Purchase.TabIndex = 10;
            this.btn_Early_Purchase.Text = "Purchase Early Cut-off";
            this.btn_Early_Purchase.Click += new System.EventHandler(this.btn_Early_Purchase_Click_1);
            // 
            // btn_exportToExcel
            // 
            this.btn_exportToExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_exportToExcel.ImageOptions.SvgImage")));
            this.btn_exportToExcel.Location = new System.Drawing.Point(646, 50);
            this.btn_exportToExcel.Name = "btn_exportToExcel";
            this.btn_exportToExcel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_exportToExcel.Size = new System.Drawing.Size(126, 33);
            this.btn_exportToExcel.TabIndex = 9;
            this.btn_exportToExcel.Text = "Export To Excel";
            this.btn_exportToExcel.Click += new System.EventHandler(this.btn_exportToExcel_Click_1);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(41, 53);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(25, 15);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Date";
            // 
            // txtDate
            // 
            // 
            // 
            // 
            this.txtDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtDate.ButtonDropDown.Visible = true;
            this.txtDate.Location = new System.Drawing.Point(70, 50);
            // 
            // 
            // 
            this.txtDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtDate.MonthCalendar.DisplayMonth = new System.DateTime(2022, 2, 1, 0, 0, 0, 0);
            this.txtDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtDate.MonthCalendar.TodayButtonVisible = true;
            this.txtDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(139, 20);
            this.txtDate.TabIndex = 7;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column7,
            this.Column8,
            this.year,
            this.Column9,
            this.Column10,
            this.Column11,
            this.vendorINV,
            this.JorNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv1.Location = new System.Drawing.Point(0, 115);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1234, 335);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Ser";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Branch";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Invoice #";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Invoice Type";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Qty";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Vat";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Branch Code";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Transaction Code";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Account #";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Account Description";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // vendorINV
            // 
            this.vendorINV.HeaderText = "vendor invoice #";
            this.vendorINV.Name = "vendorINV";
            this.vendorINV.ReadOnly = true;
            // 
            // JorNo
            // 
            this.JorNo.HeaderText = "Entry Jor. #";
            this.JorNo.Name = "JorNo";
            this.JorNo.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.btn_Late_Purchase);
            this.groupControl1.Controls.Add(this.btn_Late_Sales);
            this.groupControl1.Controls.Add(this.btn_Early_Purchase);
            this.groupControl1.Controls.Add(this.btn_exportToExcel);
            this.groupControl1.Controls.Add(this.txtDate);
            this.groupControl1.Controls.Add(this.btn_Early_Sales);
            this.groupControl1.Controls.Add(this.labelX1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1234, 115);
            this.groupControl1.TabIndex = 2;
            // 
            // frm_rpt_CutOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 450);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_rpt_CutOff";
            this.Text = "frm_rpt_CutOff";
            this.Load += new System.EventHandler(this.frm_rpt_CutOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn JorNo;
        private DevExpress.XtraEditors.SimpleButton btn_exportToExcel;
        private DevExpress.XtraEditors.SimpleButton btn_Early_Purchase;
        private DevExpress.XtraEditors.SimpleButton btn_Late_Purchase;
        private DevExpress.XtraEditors.SimpleButton btn_Late_Sales;
        private DevExpress.XtraEditors.SimpleButton btn_Early_Sales;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}