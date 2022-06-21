namespace Report_Pro.PL
{
    partial class frm_DataBaseChose
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
            this.uC_Years1 = new Report_Pro.MyControls.UC_Years();
            this.SuspendLayout();
            // 
            // uC_Years1
            // 
            this.uC_Years1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Years1.Location = new System.Drawing.Point(0, 0);
            this.uC_Years1.Name = "uC_Years1";
            this.uC_Years1.Size = new System.Drawing.Size(120, 416);
            this.uC_Years1.TabIndex = 0;
            // 
            // frm_DataBaseChose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 416);
            this.Controls.Add(this.uC_Years1);
            this.Name = "frm_DataBaseChose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frm_DataBaseChose";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.UC_Years uC_Years1;
    }
}