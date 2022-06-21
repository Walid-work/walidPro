namespace Report_Pro.MyControls
{
    partial class Jor_Row
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jor_Row));
            this.branchID = new System.Windows.Forms.TextBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.ser_ = new DevComponents.DotNetBar.LabelX();
            this.txtBalance = new Report_Pro.MyControls.myText();
            this.txtCr = new Report_Pro.MyControls.mDouble();
            this.txtDb = new Report_Pro.MyControls.mDouble();
            this.txtDocument = new Report_Pro.MyControls.myText();
            this.txtVatNo = new Report_Pro.MyControls.myText();
            this.Acc_ = new Report_Pro.MyControls.Jor_Acc();
            this.txtCat = new Report_Pro.MyControls.Jor_Cat();
            this.txtAcc_2 = new Report_Pro.MyControls.myText();
            this.txtCost = new Report_Pro.MyControls.Jor_Cost();
            this.txtDescription = new Report_Pro.MyControls.myText();
            this.txtDocDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocDate)).BeginInit();
            this.SuspendLayout();
            // 
            // branchID
            // 
            this.branchID.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.branchID, "branchID");
            this.branchID.Name = "branchID";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.labelX6, "labelX6");
            this.labelX6.Name = "labelX6";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ser_
            // 
            this.ser_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.ser_, "ser_");
            this.ser_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ser_.Name = "ser_";
            this.ser_.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ser_.Click += new System.EventHandler(this.ser__Click);
            // 
            // txtBalance
            // 
            resources.ApplyResources(this.txtBalance, "txtBalance");
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBalance.labelBackColor = System.Drawing.SystemColors.Window;
            this.txtBalance.lblControl = "";
            this.txtBalance.Name = "txtBalance";
            // 
            // txtCr
            // 
            resources.ApplyResources(this.txtCr, "txtCr");
            this.txtCr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCr.Name = "txtCr";
            this.txtCr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCr_KeyDown);
            this.txtCr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCr_KeyUp);
            // 
            // txtDb
            // 
            resources.ApplyResources(this.txtDb, "txtDb");
            this.txtDb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDb.Name = "txtDb";
            this.txtDb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDb_KeyDown);
            this.txtDb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDb_KeyUp);
            // 
            // txtDocument
            // 
            resources.ApplyResources(this.txtDocument, "txtDocument");
            this.txtDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDocument.labelBackColor = System.Drawing.SystemColors.Control;
            this.txtDocument.lblControl = "المستند";
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Load += new System.EventHandler(this.txtDocument_Load);
            this.txtDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocument_KeyDown);
            // 
            // txtVatNo
            // 
            resources.ApplyResources(this.txtVatNo, "txtVatNo");
            this.txtVatNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtVatNo.labelBackColor = System.Drawing.SystemColors.Control;
            this.txtVatNo.lblControl = "VatID";
            this.txtVatNo.Name = "txtVatNo";
            this.txtVatNo.Load += new System.EventHandler(this.txtVatNo_Load);
            this.txtVatNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVatNo_KeyDown);
            // 
            // Acc_
            // 
            resources.ApplyResources(this.Acc_, "Acc_");
            this.Acc_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Acc_.Name = "Acc_";
            this.Acc_.Load += new System.EventHandler(this.Acc__Load);
            this.Acc_.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Acc__KeyDown);
            // 
            // txtCat
            // 
            resources.ApplyResources(this.txtCat, "txtCat");
            this.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCat.Name = "txtCat";
            this.txtCat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCat_KeyDown);
            // 
            // txtAcc_2
            // 
            resources.ApplyResources(this.txtAcc_2, "txtAcc_2");
            this.txtAcc_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAcc_2.labelBackColor = System.Drawing.SystemColors.Control;
            this.txtAcc_2.lblControl = "Account";
            this.txtAcc_2.Name = "txtAcc_2";
            this.txtAcc_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcc_2_KeyDown);
            // 
            // txtCost
            // 
            resources.ApplyResources(this.txtCost, "txtCost");
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCost.Name = "txtCost";
            this.txtCost.Load += new System.EventHandler(this.txtCost_Load);
            this.txtCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCost_KeyDown);
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDescription.labelBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescription.lblControl = "";
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Load += new System.EventHandler(this.txtDescription_Load);
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // txtDocDate
            // 
            // 
            // 
            // 
            this.txtDocDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDocDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtDocDate.ButtonDropDown.Visible = true;
            resources.ApplyResources(this.txtDocDate, "txtDocDate");
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
            this.txtDocDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
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
            this.txtDocDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocDate_KeyDown);
            // 
            // Jor_Row
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDocDate);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.ser_);
            this.Controls.Add(this.txtAcc_2);
            this.Controls.Add(this.txtVatNo);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.branchID);
            this.Controls.Add(this.txtCr);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.Acc_);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCost);
            this.Name = "Jor_Row";
            this.Load += new System.EventHandler(this.Jor_Row_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDocDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox branchID;
        public myText txtDescription;
        public mDouble txtCr;
        public mDouble txtDb;
        public DevComponents.DotNetBar.LabelX ser_;
        private DevComponents.DotNetBar.LabelX labelX6;
        public myText txtDocument;
        public myText txtVatNo;
        public Jor_Acc Acc_;
        public Jor_Cat txtCat;
        public myText txtAcc_2;
        public Jor_Cost txtCost;
        public myText txtBalance;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput txtDocDate;
    }
}
