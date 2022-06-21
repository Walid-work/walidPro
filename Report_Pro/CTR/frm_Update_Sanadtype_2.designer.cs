namespace Report_Pro.CTR
{
    partial class frm_Update_Sanadtype_2
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_J_Entry = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmb_Transaction = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.txtAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtBranch = new MyControls.UC_AccBranch();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(69, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(37, 15);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Branch";
            // 
            // txt_J_Entry
            // 
            // 
            // 
            // 
            this.txt_J_Entry.Border.Class = "TextBoxBorder";
            this.txt_J_Entry.Location = new System.Drawing.Point(110, 50);
            this.txt_J_Entry.Name = "txt_J_Entry";
            this.txt_J_Entry.Size = new System.Drawing.Size(110, 20);
            this.txt_J_Entry.TabIndex = 2;
            this.txt_J_Entry.TextChanged += new System.EventHandler(this.txt_J_Entry_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(19, 53);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 15);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Journal Entry No.";
            // 
            // cmb_Transaction
            // 
            this.cmb_Transaction.DisplayMember = "Text";
            this.cmb_Transaction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Transaction.FormattingEnabled = true;
            this.cmb_Transaction.ItemHeight = 14;
            this.cmb_Transaction.Location = new System.Drawing.Point(110, 76);
            this.cmb_Transaction.Name = "cmb_Transaction";
            this.cmb_Transaction.Size = new System.Drawing.Size(321, 20);
            this.cmb_Transaction.TabIndex = 4;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(46, 79);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(60, 15);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Transaction";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Location = new System.Drawing.Point(202, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.Border.Class = "TextBoxBorder";
            this.txtAmount.Location = new System.Drawing.Point(321, 50);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(110, 20);
            this.txtAmount.TabIndex = 7;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(277, 53);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(40, 15);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Amount";
            // 
            // txtBranch
            // 
            this.txtBranch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBranch.Location = new System.Drawing.Point(110, 20);
            this.txtBranch.Margin = new System.Windows.Forms.Padding(0);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(321, 23);
            this.txtBranch.TabIndex = 0;
            // 
            // frm_Update_Sanadtype_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 261);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cmb_Transaction);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txt_J_Entry);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtBranch);
            this.Name = "frm_Update_Sanadtype_2";
            this.Text = "frm_Update_Sanadtype_2";
            this.Load += new System.EventHandler(this.frm_Update_Sanadtype_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.UC_AccBranch txtBranch;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_J_Entry;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_Transaction;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAmount;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}