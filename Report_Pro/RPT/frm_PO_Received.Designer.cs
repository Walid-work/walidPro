namespace Report_Pro.RPT
{
    partial class frm_PO_Received
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_LP = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.PO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LP
            // 
            this.dgv_LP.AllowUserToAddRows = false;
            this.dgv_LP.AllowUserToDeleteRows = false;
            this.dgv_LP.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PO,
            this.Column14,
            this.Column15,
            this.Column16,
            this.itemCode,
            this.ItemDesc,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column24,
            this.Column25,
            this.Column26});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LP.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_LP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_LP.Location = new System.Drawing.Point(0, 0);
            this.dgv_LP.Name = "dgv_LP";
            this.dgv_LP.ReadOnly = true;
            this.dgv_LP.RowHeadersVisible = false;
            this.dgv_LP.RowHeadersWidth = 51;
            this.dgv_LP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LP.Size = new System.Drawing.Size(1275, 561);
            this.dgv_LP.TabIndex = 51;
            this.dgv_LP.DoubleClick += new System.EventHandler(this.dgv_LP_DoubleClick);
            // 
            // PO
            // 
            this.PO.HeaderText = "PO No";
            this.PO.Name = "PO";
            this.PO.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.FillWeight = 111.5319F;
            this.Column14.HeaderText = "Branch";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 130;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Invoice Ser";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 60;
            // 
            // Column16
            // 
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.Column16.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column16.HeaderText = "Date";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // itemCode
            // 
            this.itemCode.HeaderText = "Item Code";
            this.itemCode.Name = "itemCode";
            this.itemCode.ReadOnly = true;
            // 
            // ItemDesc
            // 
            this.ItemDesc.HeaderText = "Item Description";
            this.ItemDesc.Name = "ItemDesc";
            this.ItemDesc.ReadOnly = true;
            this.ItemDesc.Width = 300;
            // 
            // Column17
            // 
            dataGridViewCellStyle3.Format = "N2";
            this.Column17.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column17.HeaderText = "Qty";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 70;
            // 
            // Column18
            // 
            dataGridViewCellStyle4.Format = "N3";
            this.Column18.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column18.HeaderText = "Unit Price";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 70;
            // 
            // Column19
            // 
            dataGridViewCellStyle5.Format = "N0";
            this.Column19.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column19.HeaderText = "Ton Price";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 70;
            // 
            // Column20
            // 
            this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column20.HeaderText = "Vendor";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "Branch Code";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Visible = false;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "Year";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Visible = false;
            // 
            // Column26
            // 
            this.Column26.HeaderText = "Transaction Code";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            this.Column26.Visible = false;
            // 
            // frm_PO_Received
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 561);
            this.Controls.Add(this.dgv_LP);
            this.Name = "frm_PO_Received";
            this.Text = "frm_PO_Received";
            this.Load += new System.EventHandler(this.frm_PO_Received_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_LP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
    }
}