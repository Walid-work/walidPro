namespace Report_Pro.PL
{
    partial class frm_ChoseStore
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
            this.tvStore = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvStore
            // 
            this.tvStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStore.Location = new System.Drawing.Point(0, 0);
            this.tvStore.Margin = new System.Windows.Forms.Padding(2);
            this.tvStore.Name = "tvStore";
            this.tvStore.Size = new System.Drawing.Size(505, 450);
            this.tvStore.TabIndex = 23;
            this.tvStore.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStore_AfterSelect);
            this.tvStore.DoubleClick += new System.EventHandler(this.tvStore_DoubleClick);
            // 
            // frm_ChoseStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.tvStore);
            this.Name = "frm_ChoseStore";
            this.Text = "frm_ChoseStore";
            this.Load += new System.EventHandler(this.frm_ChoseStore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvStore;
    }
}