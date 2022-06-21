namespace Report_Pro.Forms
{
    partial class frmWord
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtLcNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLcAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.txtLcCurrency = new System.Windows.Forms.ComboBox();
            this.txtLoanCurrency = new System.Windows.Forms.ComboBox();
            this.txtBank = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBankAccount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lcInvDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoanDays = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLoanDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSerail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtisueDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lcInvDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisueDate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(621, 119);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(180, 28);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print Letter";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 437);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1505, 480);
            this.panel1.TabIndex = 2;
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoanAmount.Location = new System.Drawing.Point(1134, 182);
            this.txtLoanAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(215, 24);
            this.txtLoanAmount.TabIndex = 3;
            this.txtLoanAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtLoanAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoanAmount_KeyDown);
            this.txtLoanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanAmount_KeyPress);
            this.txtLoanAmount.Leave += new System.EventHandler(this.txtLoanAmount_Leave);
            // 
            // txtLcNo
            // 
            this.txtLcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLcNo.Location = new System.Drawing.Point(1134, 253);
            this.txtLcNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLcNo.Name = "txtLcNo";
            this.txtLcNo.Size = new System.Drawing.Size(215, 24);
            this.txtLcNo.TabIndex = 4;
            this.txtLcNo.TextChanged += new System.EventHandler(this.txtLcNo_TextChanged);
            this.txtLcNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLcNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1356, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "مبلغ القرض";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1356, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "رقم الاعتماد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1356, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "مبلغ الفاتورة";
            // 
            // txtLcAmount
            // 
            this.txtLcAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLcAmount.Location = new System.Drawing.Point(1134, 311);
            this.txtLcAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLcAmount.Name = "txtLcAmount";
            this.txtLcAmount.Size = new System.Drawing.Size(215, 24);
            this.txtLcAmount.TabIndex = 7;
            this.txtLcAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLcAmount_KeyDown);
            this.txtLcAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLcAmount_KeyPress);
            this.txtLcAmount.Leave += new System.EventHandler(this.txtLcAmount_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1356, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "مسلسل الفاتورة";
            // 
            // txtInvNo
            // 
            this.txtInvNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvNo.Location = new System.Drawing.Point(1277, 282);
            this.txtInvNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.Size = new System.Drawing.Size(72, 24);
            this.txtInvNo.TabIndex = 9;
            this.txtInvNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvNo_KeyDown);
            // 
            // txtLcCurrency
            // 
            this.txtLcCurrency.FormattingEnabled = true;
            this.txtLcCurrency.Location = new System.Drawing.Point(953, 311);
            this.txtLcCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLcCurrency.Name = "txtLcCurrency";
            this.txtLcCurrency.Size = new System.Drawing.Size(173, 24);
            this.txtLcCurrency.TabIndex = 11;
            // 
            // txtLoanCurrency
            // 
            this.txtLoanCurrency.FormattingEnabled = true;
            this.txtLoanCurrency.Location = new System.Drawing.Point(953, 182);
            this.txtLoanCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoanCurrency.Name = "txtLoanCurrency";
            this.txtLoanCurrency.Size = new System.Drawing.Size(173, 24);
            this.txtLoanCurrency.TabIndex = 12;
            // 
            // txtBank
            // 
            this.txtBank.FormattingEnabled = true;
            this.txtBank.Location = new System.Drawing.Point(953, 123);
            this.txtBank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(396, 24);
            this.txtBank.TabIndex = 13;
            this.txtBank.SelectedIndexChanged += new System.EventHandler(this.txtBank_SelectedIndexChanged);
            this.txtBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBank_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1356, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "البنك";
            // 
            // txtBankAccount
            // 
            this.txtBankAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccount.Location = new System.Drawing.Point(953, 152);
            this.txtBankAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBankAccount.Name = "txtBankAccount";
            this.txtBankAccount.Size = new System.Drawing.Size(396, 24);
            this.txtBankAccount.TabIndex = 3;
            this.txtBankAccount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1356, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "رقم الحساب";
            // 
            // lcInvDate
            // 
            // 
            // 
            // 
            this.lcInvDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.lcInvDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.lcInvDate.ButtonDropDown.Visible = true;
            this.lcInvDate.Location = new System.Drawing.Point(1177, 343);
            this.lcInvDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.lcInvDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.lcInvDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.lcInvDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.lcInvDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.lcInvDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.lcInvDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.lcInvDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lcInvDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.lcInvDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.lcInvDate.MonthCalendar.DisplayMonth = new System.DateTime(2022, 4, 1, 0, 0, 0, 0);
            this.lcInvDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.lcInvDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.lcInvDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.lcInvDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.lcInvDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lcInvDate.MonthCalendar.TodayButtonVisible = true;
            this.lcInvDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.lcInvDate.Name = "lcInvDate";
            this.lcInvDate.Size = new System.Drawing.Size(172, 24);
            this.lcInvDate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1356, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "استحقاق الفاتورة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1356, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "مدة القرض";
            // 
            // txtLoanDays
            // 
            this.txtLoanDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoanDays.Location = new System.Drawing.Point(1274, 214);
            this.txtLoanDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoanDays.Name = "txtLoanDays";
            this.txtLoanDays.Size = new System.Drawing.Size(75, 24);
            this.txtLoanDays.TabIndex = 17;
            this.txtLoanDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoanDays_KeyDown);
            this.txtLoanDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanDays_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1242, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "يوم";
            // 
            // txtLoanDate
            // 
            // 
            // 
            // 
            this.txtLoanDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtLoanDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtLoanDate.ButtonDropDown.Visible = true;
            this.txtLoanDate.Location = new System.Drawing.Point(1177, 91);
            this.txtLoanDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.txtLoanDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtLoanDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoanDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtLoanDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtLoanDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtLoanDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtLoanDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtLoanDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtLoanDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtLoanDate.MonthCalendar.DisplayMonth = new System.DateTime(2022, 4, 1, 0, 0, 0, 0);
            this.txtLoanDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtLoanDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtLoanDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtLoanDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtLoanDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtLoanDate.MonthCalendar.TodayButtonVisible = true;
            this.txtLoanDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtLoanDate.Name = "txtLoanDate";
            this.txtLoanDate.Size = new System.Drawing.Size(172, 24);
            this.txtLoanDate.TabIndex = 15;
            this.txtLoanDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoanDate_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1356, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "تاريخ الطلب";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1356, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "مسلسل";
            // 
            // txtSerail
            // 
            this.txtSerail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerail.Enabled = false;
            this.txtSerail.Location = new System.Drawing.Point(1277, 26);
            this.txtSerail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSerail.Name = "txtSerail";
            this.txtSerail.Size = new System.Drawing.Size(72, 24);
            this.txtSerail.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1132, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "تاريخ الطلب";
            // 
            // txtisueDate
            // 
            // 
            // 
            // 
            this.txtisueDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtisueDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtisueDate.ButtonDropDown.Visible = true;
            this.txtisueDate.Enabled = false;
            this.txtisueDate.Location = new System.Drawing.Point(953, 26);
            this.txtisueDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.txtisueDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtisueDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtisueDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtisueDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtisueDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtisueDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtisueDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtisueDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtisueDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtisueDate.MonthCalendar.DisplayMonth = new System.DateTime(2022, 4, 1, 0, 0, 0, 0);
            this.txtisueDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtisueDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtisueDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtisueDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtisueDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtisueDate.MonthCalendar.TodayButtonVisible = true;
            this.txtisueDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtisueDate.Name = "txtisueDate";
            this.txtisueDate.Size = new System.Drawing.Size(172, 24);
            this.txtisueDate.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(621, 178);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 917);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtisueDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSerail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLoanDays);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLoanDate);
            this.Controls.Add(this.lcInvDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtLoanCurrency);
            this.Controls.Add(this.txtLcCurrency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInvNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLcAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLcNo);
            this.Controls.Add(this.txtBankAccount);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmWord";
            this.Text = "frmWord";
            this.Load += new System.EventHandler(this.frmWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcInvDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisueDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtLcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLcAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInvNo;
        private System.Windows.Forms.ComboBox txtLcCurrency;
        private System.Windows.Forms.ComboBox txtLoanCurrency;
        private System.Windows.Forms.ComboBox txtBank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBankAccount;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput lcInvDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoanDays;
        private System.Windows.Forms.Label label9;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtLoanDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSerail;
        private System.Windows.Forms.Label label12;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtisueDate;
        private System.Windows.Forms.Button btnSave;
    }
}