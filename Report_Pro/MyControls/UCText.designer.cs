namespace Report_Pro.MyControls
{
    partial class UCText
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
            this.Desc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Desc
            // 
            this.Desc.BackColor = System.Drawing.Color.MintCream;
            this.Desc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desc.Location = new System.Drawing.Point(0, 0);
            this.Desc.Margin = new System.Windows.Forms.Padding(0);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(314, 20);
            this.Desc.TabIndex = 14;
            // 
            // UCText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Desc);
            this.Name = "UCText";
            this.Size = new System.Drawing.Size(314, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox Desc;

    }
}
