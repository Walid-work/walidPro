namespace Report_Pro.MyControls
{
    partial class UC_Date
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.HD = new System.Windows.Forms.MaskedTextBox();
            this.GD = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 108;
            this.label1.Text = "م";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 110;
            this.label2.Text = "هـ";
            // 
            // HD
            // 
            this.HD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HD.Location = new System.Drawing.Point(34, 0);
            this.HD.Margin = new System.Windows.Forms.Padding(4);
            this.HD.Mask = "00/00/0000";
            this.HD.Name = "HD";
            this.HD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HD.Size = new System.Drawing.Size(114, 27);
            this.HD.TabIndex = 223;
            this.HD.Click += new System.EventHandler(this.HD_Click);
            this.HD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HD_KeyDown_1);
            this.HD.Leave += new System.EventHandler(this.HD_Leave_1);
            // 
            // GD
            // 
            this.GD.Location = new System.Drawing.Point(224, 0);
            this.GD.Margin = new System.Windows.Forms.Padding(4);
            this.GD.Name = "GD";
            this.GD.Size = new System.Drawing.Size(142, 27);
            this.GD.TabIndex = 224;
            this.GD.ValueChanged += new System.EventHandler(this.GD_ValueChanged);
            this.GD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GD_KeyDown);
            this.GD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GD_KeyUp);
            this.GD.Leave += new System.EventHandler(this.GD_Leave);
            // 
            // UC_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.GD);
            this.Controls.Add(this.HD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_Date";
            this.Size = new System.Drawing.Size(369, 29);
            this.Load += new System.EventHandler(this.UC_Date_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.MaskedTextBox HD;
        public System.Windows.Forms.DateTimePicker GD;
    }
}
