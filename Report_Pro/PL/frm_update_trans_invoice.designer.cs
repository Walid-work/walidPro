namespace Report_Pro.PL
{
    partial class frm_update_trans_invoice
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtInv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.Uc_Acc = new Report_Pro.MyControls.UC_Acc();
            this.txtSuppDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtSuppInv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAmount = new DevComponents.Editors.DoubleInput();
            this.txtVat = new DevComponents.Editors.DoubleInput();
            this.txtTotalAmount = new DevComponents.Editors.DoubleInput();
            this.txtSuppVatNo = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtCashSupp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.UC_Transaction = new Report_Pro.MyControls.UC_Transaction();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuppDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(173, 39);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 21);
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "بحث";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtInv
            // 
            // 
            // 
            // 
            this.txtInv.Border.Class = "TextBoxBorder";
            this.txtInv.Location = new System.Drawing.Point(107, 39);
            this.txtInv.Name = "txtInv";
            this.txtInv.Size = new System.Drawing.Size(58, 20);
            this.txtInv.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(46, 41);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 17);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "رقم الفاتورة";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(71, 92);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(33, 17);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "المبلغ";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(66, 116);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(38, 17);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "الضريبة";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(56, 140);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(47, 17);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "الاجمالي";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.Location = new System.Drawing.Point(71, 64);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(32, 17);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "المورد";
            this.labelX5.Click += new System.EventHandler(this.labelX5_Click);
            // 
            // Uc_Acc
            // 
            this.Uc_Acc.BackColor = System.Drawing.Color.Transparent;
            this.Uc_Acc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Uc_Acc.Location = new System.Drawing.Point(107, 63);
            this.Uc_Acc.Margin = new System.Windows.Forms.Padding(0);
            this.Uc_Acc.Name = "Uc_Acc";
            this.Uc_Acc.Size = new System.Drawing.Size(328, 23);
            this.Uc_Acc.TabIndex = 11;
            // 
            // txtSuppDate
            // 
            // 
            // 
            // 
            this.txtSuppDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSuppDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtSuppDate.ButtonDropDown.Visible = true;
            this.txtSuppDate.Location = new System.Drawing.Point(107, 187);
            // 
            // 
            // 
            this.txtSuppDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtSuppDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtSuppDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtSuppDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtSuppDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtSuppDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtSuppDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSuppDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtSuppDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtSuppDate.MonthCalendar.DisplayMonth = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            this.txtSuppDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtSuppDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtSuppDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtSuppDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtSuppDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtSuppDate.MonthCalendar.TodayButtonVisible = true;
            this.txtSuppDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtSuppDate.Name = "txtSuppDate";
            this.txtSuppDate.Size = new System.Drawing.Size(126, 20);
            this.txtSuppDate.TabIndex = 12;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.Location = new System.Drawing.Point(18, 189);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(85, 17);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "تاريخ فاتورة المورد";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.Location = new System.Drawing.Point(23, 164);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(80, 17);
            this.labelX7.TabIndex = 15;
            this.labelX7.Text = "رقم فاتورة المورد";
            // 
            // txtSuppInv
            // 
            // 
            // 
            // 
            this.txtSuppInv.Border.Class = "TextBoxBorder";
            this.txtSuppInv.Location = new System.Drawing.Point(107, 162);
            this.txtSuppInv.Name = "txtSuppInv";
            this.txtSuppInv.Size = new System.Drawing.Size(80, 20);
            this.txtSuppInv.TabIndex = 14;
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtAmount.Increment = 1D;
            this.txtAmount.Location = new System.Drawing.Point(107, 92);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(80, 20);
            this.txtAmount.TabIndex = 16;
            // 
            // txtVat
            // 
            // 
            // 
            // 
            this.txtVat.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtVat.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtVat.Increment = 1D;
            this.txtVat.Location = new System.Drawing.Point(107, 116);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(80, 20);
            this.txtVat.TabIndex = 17;
            // 
            // txtTotalAmount
            // 
            // 
            // 
            // 
            this.txtTotalAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTotalAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtTotalAmount.Increment = 1D;
            this.txtTotalAmount.Location = new System.Drawing.Point(107, 140);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(80, 20);
            this.txtTotalAmount.TabIndex = 18;
            // 
            // txtSuppVatNo
            // 
            // 
            // 
            // 
            this.txtSuppVatNo.BackgroundStyle.Class = "TextBoxBorder";
            this.txtSuppVatNo.ButtonClear.Visible = true;
            this.txtSuppVatNo.Location = new System.Drawing.Point(427, 104);
            this.txtSuppVatNo.Mask = "00000-00000-00000";
            this.txtSuppVatNo.Name = "txtSuppVatNo";
            this.txtSuppVatNo.Size = new System.Drawing.Size(124, 20);
            this.txtSuppVatNo.TabIndex = 19;
            this.txtSuppVatNo.Text = "";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.Location = new System.Drawing.Point(321, 107);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(100, 17);
            this.labelX8.TabIndex = 20;
            this.labelX8.Text = "الرقم الضريبي للمورد";
            this.labelX8.Click += new System.EventHandler(this.labelX8_Click);
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.Location = new System.Drawing.Point(321, 133);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(91, 17);
            this.labelX9.TabIndex = 22;
            this.labelX9.Text = "اسم المورد النقدي";
            // 
            // txtCashSupp
            // 
            // 
            // 
            // 
            this.txtCashSupp.Border.Class = "TextBoxBorder";
            this.txtCashSupp.Location = new System.Drawing.Point(427, 130);
            this.txtCashSupp.Name = "txtCashSupp";
            this.txtCashSupp.Size = new System.Drawing.Size(238, 20);
            this.txtCashSupp.TabIndex = 23;
            // 
            // UC_Transaction
            // 
            this.UC_Transaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UC_Transaction.Location = new System.Drawing.Point(107, 9);
            this.UC_Transaction.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Transaction.Name = "UC_Transaction";
            this.UC_Transaction.Size = new System.Drawing.Size(310, 24);
            this.UC_Transaction.TabIndex = 24;
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.Location = new System.Drawing.Point(47, 9);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(56, 17);
            this.labelX10.TabIndex = 25;
            this.labelX10.Text = "نوع الفاتورة";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(363, 201);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(109, 35);
            this.buttonX2.TabIndex = 26;
            this.buttonX2.Text = "تحديث";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // frm_update_trans_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.UC_Transaction);
            this.Controls.Add(this.txtCashSupp);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtSuppVatNo);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtSuppInv);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtSuppDate);
            this.Controls.Add(this.Uc_Acc);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtInv);
            this.Controls.Add(this.buttonX1);
            this.Name = "frm_update_trans_invoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frm_update_trans_invoice";
            ((System.ComponentModel.ISupportInitialize)(this.txtSuppDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInv;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private MyControls.UC_Acc Uc_Acc;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtSuppDate;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSuppInv;
        private DevComponents.Editors.DoubleInput txtAmount;
        private DevComponents.Editors.DoubleInput txtVat;
        private DevComponents.Editors.DoubleInput txtTotalAmount;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtSuppVatNo;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCashSupp;
        private MyControls.UC_Transaction UC_Transaction;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}