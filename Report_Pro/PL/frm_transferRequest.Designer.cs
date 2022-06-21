namespace Report_Pro.PL
{
    partial class frm_transferRequest
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
            this.uC_Acc1 = new Report_Pro.MyControls.UC_Acc();
            this.SuspendLayout();
            // 
            // uC_Acc1
            // 
            this.uC_Acc1.BackColor = System.Drawing.Color.Transparent;
            this.uC_Acc1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Acc1.Location = new System.Drawing.Point(252, 103);
            this.uC_Acc1.Margin = new System.Windows.Forms.Padding(0);
            this.uC_Acc1.Name = "uC_Acc1";
            this.uC_Acc1.Padding = new System.Windows.Forms.Padding(1);
            this.uC_Acc1.Size = new System.Drawing.Size(325, 26);
            this.uC_Acc1.TabIndex = 0;
            // 
            // frm_transferRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uC_Acc1);
            this.Name = "frm_transferRequest";
            this.Text = "frm_transferRequest";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.UC_Acc uC_Acc1;
    }
}