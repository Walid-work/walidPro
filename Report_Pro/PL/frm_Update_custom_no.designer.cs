namespace Report_Pro.PL
{
    partial class frm_Update_custom_no
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_custom_date = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_custom_no = new System.Windows.Forms.TextBox();
            this.txt_inv_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.inv_amount = new System.Windows.Forms.TextBox();
            this.inv_date = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTransaction = new Report_Pro.MyControls.UC_Transaction();
            this.txtBranch = new Report_Pro.MyControls.UC_Branch();
            ((System.ComponentModel.ISupportInitialize)(this.inv_date)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "الفرع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "الحركة";
            // 
            // txt_custom_date
            // 
            this.txt_custom_date.Location = new System.Drawing.Point(186, 156);
            this.txt_custom_date.Name = "txt_custom_date";
            this.txt_custom_date.Size = new System.Drawing.Size(105, 20);
            this.txt_custom_date.TabIndex = 4;
            this.txt_custom_date.ValueChanged += new System.EventHandler(this.txt_custom_date_ValueChanged);
            this.txt_custom_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_custom_date_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txt_custom_no
            // 
            this.txt_custom_no.Location = new System.Drawing.Point(186, 133);
            this.txt_custom_no.Name = "txt_custom_no";
            this.txt_custom_no.Size = new System.Drawing.Size(105, 20);
            this.txt_custom_no.TabIndex = 5;
            this.txt_custom_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_custom_no_KeyDown);
            // 
            // txt_inv_no
            // 
            this.txt_inv_no.Location = new System.Drawing.Point(186, 111);
            this.txt_inv_no.Name = "txt_inv_no";
            this.txt_inv_no.Size = new System.Drawing.Size(105, 20);
            this.txt_inv_no.TabIndex = 6;
            this.txt_inv_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_inv_no_KeyDown);
            this.txt_inv_no.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_inv_no_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "رقم الفاتورة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "رقم البيان";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "رقم البيان";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "التاريخ";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(96, 212);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 30);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(208, 212);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(106, 30);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "مبلغ الفاتورة";
            // 
            // inv_amount
            // 
            this.inv_amount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_amount.Location = new System.Drawing.Point(438, 112);
            this.inv_amount.Name = "inv_amount";
            this.inv_amount.ReadOnly = true;
            this.inv_amount.Size = new System.Drawing.Size(101, 23);
            this.inv_amount.TabIndex = 12;
            // 
            // inv_date
            // 
            // 
            // 
            // 
            this.inv_date.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inv_date.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.inv_date.ButtonDropDown.Visible = true;
            this.inv_date.Location = new System.Drawing.Point(438, 139);
            // 
            // 
            // 
            this.inv_date.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.inv_date.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.inv_date.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.inv_date.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.inv_date.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.inv_date.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.inv_date.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.inv_date.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.inv_date.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.inv_date.MonthCalendar.DisplayMonth = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            this.inv_date.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.inv_date.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.inv_date.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.inv_date.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.inv_date.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.inv_date.MonthCalendar.TodayButtonVisible = true;
            this.inv_date.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.inv_date.Name = "inv_date";
            this.inv_date.Size = new System.Drawing.Size(101, 20);
            this.inv_date.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "تاريخ الفاتورة";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(527, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "العام";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTransaction
            // 
            this.txtTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransaction.Location = new System.Drawing.Point(149, 69);
            this.txtTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.txtTransaction.Name = "txtTransaction";
            this.txtTransaction.Size = new System.Drawing.Size(321, 22);
            this.txtTransaction.TabIndex = 18;
            // 
            // txtBranch
            // 
            this.txtBranch.BackColor = System.Drawing.Color.Transparent;
            this.txtBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranch.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBranch.Location = new System.Drawing.Point(148, 42);
            this.txtBranch.Margin = new System.Windows.Forms.Padding(0);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(321, 20);
            this.txtBranch.TabIndex = 19;
            // 
            // frm_Update_custom_no
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 301);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.txtTransaction);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inv_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inv_amount);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_inv_no);
            this.Controls.Add(this.txt_custom_no);
            this.Controls.Add(this.txt_custom_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Update_custom_no";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحديث بيانات الجمارك للصادرات";
            this.Load += new System.EventHandler(this.frm_Update_custom_no_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_Update_custom_no_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.inv_date)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt_custom_date;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt_custom_no;
        private System.Windows.Forms.TextBox txt_inv_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inv_amount;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput inv_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private MyControls.UC_Transaction txtTransaction;
        private MyControls.UC_Branch txtBranch;
    }
}