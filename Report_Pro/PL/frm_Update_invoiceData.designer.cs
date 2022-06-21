namespace Report_Pro.PL
{
    partial class frm_Update_invoiceData
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
            this.cmb_Branch = new System.Windows.Forms.ComboBox();
            this.cmb_transaction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invDate = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.invNo = new System.Windows.Forms.TextBox();
            this.txt_inv_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_VatNo = new System.Windows.Forms.MaskedTextBox();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Supp = new System.Windows.Forms.TextBox();
            this.G_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.acc_ser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_Branch
            // 
            this.cmb_Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Branch.FormattingEnabled = true;
            this.cmb_Branch.Location = new System.Drawing.Point(151, 39);
            this.cmb_Branch.Name = "cmb_Branch";
            this.cmb_Branch.Size = new System.Drawing.Size(199, 21);
            this.cmb_Branch.TabIndex = 0;
            // 
            // cmb_transaction
            // 
            this.cmb_transaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_transaction.FormattingEnabled = true;
            this.cmb_transaction.Location = new System.Drawing.Point(151, 63);
            this.cmb_transaction.Name = "cmb_transaction";
            this.cmb_transaction.Size = new System.Drawing.Size(199, 21);
            this.cmb_transaction.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "الفرع";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "الحركة";
            // 
            // invDate
            // 
            this.invDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invDate.Location = new System.Drawing.Point(100, 179);
            this.invDate.Name = "invDate";
            this.invDate.Size = new System.Drawing.Size(91, 20);
            this.invDate.TabIndex = 4;
            this.invDate.ValueChanged += new System.EventHandler(this.invDate_ValueChanged);
            this.invDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_custom_date_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // invNo
            // 
            this.invNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invNo.Location = new System.Drawing.Point(100, 157);
            this.invNo.Name = "invNo";
            this.invNo.Size = new System.Drawing.Size(91, 20);
            this.invNo.TabIndex = 5;
            this.invNo.TextChanged += new System.EventHandler(this.invNo_TextChanged);
            this.invNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_custom_no_KeyDown);
            // 
            // txt_inv_no
            // 
            this.txt_inv_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_inv_no.Location = new System.Drawing.Point(102, 96);
            this.txt_inv_no.Name = "txt_inv_no";
            this.txt_inv_no.Size = new System.Drawing.Size(105, 20);
            this.txt_inv_no.TabIndex = 6;
            this.txt_inv_no.TextChanged += new System.EventHandler(this.txt_inv_no_TextChanged);
            this.txt_inv_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_inv_no_KeyDown);
            this.txt_inv_no.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_inv_no_KeyUp);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "رقم الفاتورة";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "رقم فاتورة المورد";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "تاريخ فاتورة المورد";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(102, 217);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 30);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(214, 217);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(106, 30);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "تاريخ الفاتورة";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(475, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "العام";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_VatNo
            // 
            this.txt_VatNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_VatNo.Location = new System.Drawing.Point(297, 179);
            this.txt_VatNo.Mask = "00000-00000-00000";
            this.txt_VatNo.Name = "txt_VatNo";
            this.txt_VatNo.Size = new System.Drawing.Size(111, 20);
            this.txt_VatNo.TabIndex = 149;
            this.txt_VatNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelX12
            // 
            this.labelX12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX12.AutoSize = true;
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            this.labelX12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(221, 181);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(71, 17);
            this.labelX12.TabIndex = 148;
            this.labelX12.Text = "الرقم الضريبي";
            this.labelX12.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX12.Click += new System.EventHandler(this.labelX12_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 151;
            this.label7.Text = "المورد";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_Supp
            // 
            this.txt_Supp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Supp.Location = new System.Drawing.Point(297, 157);
            this.txt_Supp.Name = "txt_Supp";
            this.txt_Supp.Size = new System.Drawing.Size(295, 20);
            this.txt_Supp.TabIndex = 150;
            // 
            // G_date
            // 
            this.G_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_date.Location = new System.Drawing.Point(297, 96);
            this.G_date.Name = "G_date";
            this.G_date.Size = new System.Drawing.Size(91, 20);
            this.G_date.TabIndex = 154;
            this.G_date.ValueChanged += new System.EventHandler(this.new_G_date_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 156;
            this.label4.Text = "رقم القيد";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // acc_ser
            // 
            this.acc_ser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acc_ser.Location = new System.Drawing.Point(481, 96);
            this.acc_ser.Name = "acc_ser";
            this.acc_ser.Size = new System.Drawing.Size(105, 20);
            this.acc_ser.TabIndex = 155;
            // 
            // frm_Update_invoiceData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 299);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.acc_ser);
            this.Controls.Add(this.G_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Supp);
            this.Controls.Add(this.txt_VatNo);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_inv_no);
            this.Controls.Add(this.invNo);
            this.Controls.Add(this.invDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_transaction);
            this.Controls.Add(this.cmb_Branch);
            this.Name = "frm_Update_invoiceData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Update_custom_no";
            this.Load += new System.EventHandler(this.frm_Update_custom_no_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_Update_custom_no_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Branch;
        private System.Windows.Forms.ComboBox cmb_transaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker invDate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox invNo;
        private System.Windows.Forms.TextBox txt_inv_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txt_VatNo;
        private DevComponents.DotNetBar.LabelX labelX12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Supp;
        private System.Windows.Forms.DateTimePicker G_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox acc_ser;
    }
}