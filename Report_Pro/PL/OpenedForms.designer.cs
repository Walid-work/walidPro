namespace Report_Pro.PL
{
    partial class OpenedForms
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
            this.lbxFormText = new System.Windows.Forms.ListBox();
            this.lbxFormName = new System.Windows.Forms.ListBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUpdate = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnUpdatForms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxFormText
            // 
            this.lbxFormText.FormattingEnabled = true;
            this.lbxFormText.Location = new System.Drawing.Point(19, 88);
            this.lbxFormText.Name = "lbxFormText";
            this.lbxFormText.Size = new System.Drawing.Size(270, 238);
            this.lbxFormText.TabIndex = 0;
            this.lbxFormText.DoubleClick += new System.EventHandler(this.lbxFormText_DoubleClick);
            // 
            // lbxFormName
            // 
            this.lbxFormName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxFormName.FormattingEnabled = true;
            this.lbxFormName.Location = new System.Drawing.Point(255, 37);
            this.lbxFormName.Name = "lbxFormName";
            this.lbxFormName.Size = new System.Drawing.Size(10, 43);
            this.lbxFormName.TabIndex = 1;
            this.lbxFormName.Visible = false;
            this.lbxFormName.DoubleClick += new System.EventHandler(this.lbxFormName_DoubleClick);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Location = new System.Drawing.Point(145, 16);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(157, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "عدد الشاشات المفتوحة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "اضغط DublClick علي اسم الشاشة لفتحها";
            // 
            // cbxUpdate
            // 
            this.cbxUpdate.Location = new System.Drawing.Point(26, 37);
            this.cbxUpdate.Name = "cbxUpdate";
            this.cbxUpdate.Size = new System.Drawing.Size(149, 23);
            this.cbxUpdate.TabIndex = 6;
            this.cbxUpdate.Text = "تحديث تلقائي للشاشات";
            this.cbxUpdate.CheckedChanged += new System.EventHandler(this.cbxUpdate_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnUpdatForms
            // 
            this.btnUpdatForms.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdatForms.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnUpdatForms.FlatAppearance.BorderSize = 0;
            this.btnUpdatForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatForms.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdatForms.Location = new System.Drawing.Point(46, 329);
            this.btnUpdatForms.Name = "btnUpdatForms";
            this.btnUpdatForms.Size = new System.Drawing.Size(105, 30);
            this.btnUpdatForms.TabIndex = 7;
            this.btnUpdatForms.Text = "تحديث الشاشات";
            this.btnUpdatForms.UseVisualStyleBackColor = false;
            this.btnUpdatForms.Click += new System.EventHandler(this.btnUpdatForms_Click);
            // 
            // OpenedForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 370);
            this.Controls.Add(this.btnUpdatForms);
            this.Controls.Add(this.cbxUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lbxFormName);
            this.Controls.Add(this.lbxFormText);
            this.Name = "OpenedForms";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عرض الشاشات المفتوحة";
            this.Load += new System.EventHandler(this.OpenedForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFormText;
        private System.Windows.Forms.ListBox lbxFormName;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxUpdate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUpdatForms;
    }
}