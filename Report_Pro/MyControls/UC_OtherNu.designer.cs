namespace Report_Pro.MyControls
{
    partial class UC_OtherNu
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
            this.ID = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Desc
            // 
            this.Desc.BackColor = System.Drawing.Color.MintCream;
            this.Desc.Location = new System.Drawing.Point(0, 0);
            this.Desc.Margin = new System.Windows.Forms.Padding(0);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(224, 20);
            this.Desc.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.MintCream;
            this.ID.Location = new System.Drawing.Point(253, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(62, 20);
            this.ID.TabIndex = 12;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.LemonChiffon;
            this.BtnSearch.BackgroundImage = global::Report_Pro.Properties.Resources.search;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.Location = new System.Drawing.Point(224, -1);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(29, 22);
            this.BtnSearch.TabIndex = 14;
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // UC_OtherNu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.ID);
            this.Name = "UC_OtherNu";
            this.Size = new System.Drawing.Size(315, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnSearch;
        internal System.Windows.Forms.TextBox Desc;
        internal System.Windows.Forms.TextBox ID;
    }
}
