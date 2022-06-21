namespace Report_Pro
{
    partial class frm_QR_Code
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
            this.txtQr = new System.Windows.Forms.TextBox();
            this.btnCreatQR = new System.Windows.Forms.Button();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQr
            // 
            this.txtQr.Location = new System.Drawing.Point(181, 300);
            this.txtQr.Name = "txtQr";
            this.txtQr.Size = new System.Drawing.Size(267, 20);
            this.txtQr.TabIndex = 0;
            // 
            // btnCreatQR
            // 
            this.btnCreatQR.Location = new System.Drawing.Point(454, 300);
            this.btnCreatQR.Name = "btnCreatQR";
            this.btnCreatQR.Size = new System.Drawing.Size(75, 23);
            this.btnCreatQR.TabIndex = 1;
            this.btnCreatQR.Text = "Creat QR Code";
            this.btnCreatQR.UseVisualStyleBackColor = true;
            this.btnCreatQR.Click += new System.EventHandler(this.btnCreatQR_Click);
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(172, 65);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(276, 220);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQR.TabIndex = 2;
            this.picQR.TabStop = false;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(181, 326);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(267, 20);
            this.txtNo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Creat QR Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_QR_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.btnCreatQR);
            this.Controls.Add(this.txtQr);
            this.Name = "frm_QR_Code";
            this.Text = "frm_QR_Code";
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQr;
        private System.Windows.Forms.Button btnCreatQR;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button button1;
    }
}