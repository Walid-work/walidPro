namespace Report_Pro
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScanPreview = new System.Windows.Forms.Button();
            this.pic_scan = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnScanHighQuality = new System.Windows.Forms.Button();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.lblPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "SavePath:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Scanner List";
            // 
            // btnScanPreview
            // 
            this.btnScanPreview.Location = new System.Drawing.Point(155, 176);
            this.btnScanPreview.Name = "btnScanPreview";
            this.btnScanPreview.Size = new System.Drawing.Size(136, 23);
            this.btnScanPreview.TabIndex = 15;
            this.btnScanPreview.Text = "Scan Preview";
            this.btnScanPreview.UseVisualStyleBackColor = true;
            this.btnScanPreview.Click += new System.EventHandler(this.btnScanPreview_Click);
            // 
            // pic_scan
            // 
            this.pic_scan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_scan.Location = new System.Drawing.Point(370, 46);
            this.pic_scan.Name = "pic_scan";
            this.pic_scan.Size = new System.Drawing.Size(343, 408);
            this.pic_scan.TabIndex = 14;
            this.pic_scan.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnScanHighQuality
            // 
            this.btnScanHighQuality.Location = new System.Drawing.Point(155, 205);
            this.btnScanHighQuality.Name = "btnScanHighQuality";
            this.btnScanHighQuality.Size = new System.Drawing.Size(136, 23);
            this.btnScanHighQuality.TabIndex = 12;
            this.btnScanHighQuality.Text = "Scan High Quality";
            this.btnScanHighQuality.UseVisualStyleBackColor = true;
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.Location = new System.Drawing.Point(99, 46);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(256, 108);
            this.lbDevices.TabIndex = 11;
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(118, 288);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(216, 20);
            this.lblPath.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnScanPreview);
            this.Controls.Add(this.pic_scan);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnScanHighQuality);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.lblPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnScanPreview;
        private System.Windows.Forms.PictureBox pic_scan;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnScanHighQuality;
        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.TextBox lblPath;
    }
}