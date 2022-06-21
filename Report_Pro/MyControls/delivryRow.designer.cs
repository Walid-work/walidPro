namespace Report_Pro.MyControls
{
    partial class delivryRow
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
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRef = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtQty = new DevComponents.Editors.DoubleInput();
            this.txtDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtItemNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtQty.BeginInit();
            this.SuspendLayout();
            this.txtRef.Border.Class = "TextBoxBorder";
            this.txtRef.Location = new System.Drawing.Point(0, 0);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(110, 27);
            this.txtRef.TabIndex = 7;
            this.txtRef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRef_KeyDown);
            this.txtQty.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtQty.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtQty.Increment = 1.0;
            this.txtQty.Location = new System.Drawing.Point(610, 0);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 27);
            this.txtQty.TabIndex = 6;
            this.txtQty.ValueChanged += new System.EventHandler(this.doubleInput1_ValueChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtDesc.Border.Class = "TextBoxBorder";
            this.txtDesc.Location = new System.Drawing.Point(210, 0);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(400, 27);
            this.txtDesc.TabIndex = 5;
            this.txtItemNo.Border.Class = "TextBoxBorder";
            this.txtItemNo.Location = new System.Drawing.Point(110, 0);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(100, 27);
            this.txtItemNo.TabIndex = 4;
            this.txtItemNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemNo_KeyDown);
            this.AutoScaleDimensions = new System.Drawing.SizeF(9f, 19f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtItemNo);
            this.Name = "delivryRow";
            this.Size = new System.Drawing.Size(710, 27);
            this.txtQty.EndInit();
            this.ResumeLayout(false);
        }
        #endregion
      //  private IContainer components = (IContainer)null;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRef;
        private DevComponents.Editors.DoubleInput txtQty;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDesc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtItemNo;
    }
}
