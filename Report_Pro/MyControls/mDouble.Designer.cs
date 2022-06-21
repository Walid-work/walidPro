namespace Report_Pro.MyControls
{
    partial class mDouble
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
            this.d = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.d)).BeginInit();
            this.SuspendLayout();
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.d.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.d.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.d.BackgroundStyle.Class = "DateTimeInputBackground";
            this.d.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d.FocusHighlightEnabled = true;
            this.d.Increment = 0D;
            this.d.Location = new System.Drawing.Point(0, 0);
            this.d.Margin = new System.Windows.Forms.Padding(0);
            this.d.MaximumSize = new System.Drawing.Size(0, 24);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(142, 20);
            this.d.TabIndex = 0;
            this.d.KeyDown += new System.Windows.Forms.KeyEventHandler(this.d_KeyDown);
            this.d.KeyUp += new System.Windows.Forms.KeyEventHandler(this.d_KeyUp);
            this.d.Leave += new System.EventHandler(this.d_Leave);
            // 
            // mDouble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.d);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "mDouble";
            this.Size = new System.Drawing.Size(142, 19);
            ((System.ComponentModel.ISupportInitialize)(this.d)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.Editors.DoubleInput d;
    }
}
