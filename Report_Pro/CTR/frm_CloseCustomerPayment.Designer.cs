namespace Report_Pro.CTR
{
    partial class frm_CloseCustomerPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CloseCustomerPayment));
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this._InvNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acc_Cr = new Report_Pro.MyControls.UC_Acc();
            this.txtStore_ID = new DevComponents.DotNetBar.LabelX();
            this.Btn_NonPayInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalInvoices = new Report_Pro.MyControls.decimalText();
            this.txtTotalClosed = new Report_Pro.MyControls.decimalText();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAcountBal = new Report_Pro.MyControls.decimalText();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._InvNo,
            this._Date,
            this._Po,
            this._amount,
            this._Paid,
            this._return,
            this._balance});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv1.Location = new System.Drawing.Point(12, 183);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.Size = new System.Drawing.Size(747, 424);
            this.dgv1.TabIndex = 302;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
            // 
            // _InvNo
            // 
            this._InvNo.HeaderText = "Invoice No";
            this._InvNo.Name = "_InvNo";
            this._InvNo.ReadOnly = true;
            // 
            // _Date
            // 
            this._Date.HeaderText = "Date";
            this._Date.Name = "_Date";
            this._Date.ReadOnly = true;
            // 
            // _Po
            // 
            this._Po.HeaderText = "PO N0";
            this._Po.Name = "_Po";
            this._Po.ReadOnly = true;
            // 
            // _amount
            // 
            this._amount.HeaderText = "Amount";
            this._amount.Name = "_amount";
            this._amount.ReadOnly = true;
            // 
            // _Paid
            // 
            this._Paid.HeaderText = "Paid";
            this._Paid.Name = "_Paid";
            this._Paid.ReadOnly = true;
            // 
            // _return
            // 
            this._return.HeaderText = "Return";
            this._return.Name = "_return";
            this._return.ReadOnly = true;
            // 
            // _balance
            // 
            this._balance.HeaderText = "Balance";
            this._balance.Name = "_balance";
            this._balance.ReadOnly = true;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv2.Location = new System.Drawing.Point(786, 183);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv2.Size = new System.Drawing.Size(747, 424);
            this.dgv2.TabIndex = 303;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "PO N0";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Paid";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Return";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Acc_Cr
            // 
            this.Acc_Cr.BackColor = System.Drawing.Color.Transparent;
            this.Acc_Cr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Acc_Cr.Location = new System.Drawing.Point(138, 61);
            this.Acc_Cr.Margin = new System.Windows.Forms.Padding(0);
            this.Acc_Cr.MaximumSize = new System.Drawing.Size(400, 24);
            this.Acc_Cr.MinimumSize = new System.Drawing.Size(400, 24);
            this.Acc_Cr.Name = "Acc_Cr";
            this.Acc_Cr.Padding = new System.Windows.Forms.Padding(1);
            this.Acc_Cr.Size = new System.Drawing.Size(400, 24);
            this.Acc_Cr.TabIndex = 304;
            // 
            // txtStore_ID
            // 
            this.txtStore_ID.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.txtStore_ID.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderBottomWidth = 1;
            this.txtStore_ID.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtStore_ID.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderLeftWidth = 1;
            this.txtStore_ID.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderRightWidth = 1;
            this.txtStore_ID.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderTopWidth = 1;
            this.txtStore_ID.ForeColor = System.Drawing.Color.Black;
            this.txtStore_ID.Location = new System.Drawing.Point(108, 30);
            this.txtStore_ID.Name = "txtStore_ID";
            this.txtStore_ID.Size = new System.Drawing.Size(136, 24);
            this.txtStore_ID.TabIndex = 305;
            // 
            // Btn_NonPayInvoice
            // 
            this.Btn_NonPayInvoice.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_NonPayInvoice.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Btn_NonPayInvoice.Appearance.Options.UseFont = true;
            this.Btn_NonPayInvoice.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.Btn_NonPayInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_NonPayInvoice.ImageOptions.SvgImage")));
            this.Btn_NonPayInvoice.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.Btn_NonPayInvoice.Location = new System.Drawing.Point(556, 41);
            this.Btn_NonPayInvoice.Name = "Btn_NonPayInvoice";
            this.Btn_NonPayInvoice.Size = new System.Drawing.Size(146, 84);
            this.Btn_NonPayInvoice.TabIndex = 306;
            this.Btn_NonPayInvoice.Text = "Non Paid Invoices";
            this.Btn_NonPayInvoice.Click += new System.EventHandler(this.Btn_NonPayInvoice_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 307;
            this.label1.Text = "Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalInvoices
            // 
            this.txtTotalInvoices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalInvoices.DicemalDigits = 0;
            this.txtTotalInvoices.Location = new System.Drawing.Point(629, 619);
            this.txtTotalInvoices.Name = "txtTotalInvoices";
            this.txtTotalInvoices.ProgramDigits = false;
            this.txtTotalInvoices.Size = new System.Drawing.Size(122, 20);
            this.txtTotalInvoices.TabIndex = 308;
            this.txtTotalInvoices.Text = "0";
            this.txtTotalInvoices.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtTotalClosed
            // 
            this.txtTotalClosed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalClosed.DicemalDigits = 0;
            this.txtTotalClosed.Location = new System.Drawing.Point(1408, 619);
            this.txtTotalClosed.Name = "txtTotalClosed";
            this.txtTotalClosed.ProgramDigits = false;
            this.txtTotalClosed.Size = new System.Drawing.Size(122, 20);
            this.txtTotalClosed.TabIndex = 309;
            this.txtTotalClosed.Text = "0";
            this.txtTotalClosed.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(542, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 310;
            this.label2.Text = "Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(1321, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 311;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(45, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 313;
            this.label4.Text = "Account Balance";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAcountBal
            // 
            this.txtAcountBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcountBal.DicemalDigits = 0;
            this.txtAcountBal.Location = new System.Drawing.Point(138, 101);
            this.txtAcountBal.Name = "txtAcountBal";
            this.txtAcountBal.ProgramDigits = false;
            this.txtAcountBal.Size = new System.Drawing.Size(122, 20);
            this.txtAcountBal.TabIndex = 312;
            this.txtAcountBal.Text = "0";
            this.txtAcountBal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // frm_CloseCustomerPayment
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 694);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAcountBal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalClosed);
            this.Controls.Add(this.txtTotalInvoices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_NonPayInvoice);
            this.Controls.Add(this.txtStore_ID);
            this.Controls.Add(this.Acc_Cr);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Name = "frm_CloseCustomerPayment";
            this.Text = "frm_CloseCustomerPayment";
            this.Controls.SetChildIndex(this.dgv1, 0);
            this.Controls.SetChildIndex(this.dgv2, 0);
            this.Controls.SetChildIndex(this.Acc_Cr, 0);
            this.Controls.SetChildIndex(this.txtStore_ID, 0);
            this.Controls.SetChildIndex(this.Btn_NonPayInvoice, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTotalInvoices, 0);
            this.Controls.SetChildIndex(this.txtTotalClosed, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtAcountBal, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _InvNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Po;
        private System.Windows.Forms.DataGridViewTextBoxColumn _amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn _return;
        private System.Windows.Forms.DataGridViewTextBoxColumn _balance;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private MyControls.UC_Acc Acc_Cr;
        public DevComponents.DotNetBar.LabelX txtStore_ID;
        private DevExpress.XtraEditors.SimpleButton Btn_NonPayInvoice;
        private System.Windows.Forms.Label label1;
        private MyControls.decimalText txtTotalInvoices;
        private MyControls.decimalText txtTotalClosed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MyControls.decimalText txtAcountBal;
    }
}