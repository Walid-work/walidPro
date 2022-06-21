namespace Report_Pro.PL
{
    partial class frmSerachItem
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
            this.uc_SearchItem1 = new Report_Pro.MyControls.Uc_SearchItem();
            this.SuspendLayout();
            // 
            // uc_SearchItem1
            // 
            this.uc_SearchItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_SearchItem1.Location = new System.Drawing.Point(0, 0);
            this.uc_SearchItem1.Name = "uc_SearchItem1";
            this.uc_SearchItem1.Size = new System.Drawing.Size(1131, 510);
            this.uc_SearchItem1.TabIndex = 0;
            this.uc_SearchItem1.DoubleClick += new System.EventHandler(this.uc_SearchItem1_DoubleClick);
            // 
            // frmSerachItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 510);
            this.Controls.Add(this.uc_SearchItem1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSerachItem";
            this.Text = "frmSerachItem";
            this.Load += new System.EventHandler(this.frmSerachItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public MyControls.Uc_SearchItem uc_SearchItem1;
    }
}