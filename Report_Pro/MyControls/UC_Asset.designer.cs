namespace Report_Pro.MyControls
{
    partial class UC_Asset
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
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBranch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLocation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGroup = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // Desc
            // 
            // 
            // 
            // 
            this.Desc.Border.Class = "TextBoxBorder";
            this.Desc.Location = new System.Drawing.Point(140, 0);
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Size = new System.Drawing.Size(340, 24);
            this.Desc.TabIndex = 3;
            this.Desc.TextChanged += new System.EventHandler(this.Desc_TextChanged);
            // 
            // btn1
            // 
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn1.Image = global::Report_Pro.Properties.Resources.search_16;
            this.btn1.Location = new System.Drawing.Point(100, 1);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 24);
            this.btn1.TabIndex = 4;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // ID
            // 
            // 
            // 
            // 
            this.ID.Border.Class = "TextBoxBorder";
            this.ID.Location = new System.Drawing.Point(0, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 24);
            this.ID.TabIndex = 5;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            // 
            // txtBranch
            // 
            // 
            // 
            // 
            this.txtBranch.Border.Class = "TextBoxBorder";
            this.txtBranch.Location = new System.Drawing.Point(0, 0);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(100, 24);
            this.txtBranch.TabIndex = 2;
            // 
            // txtLocation
            // 
            // 
            // 
            // 
            this.txtLocation.Border.Class = "TextBoxBorder";
            this.txtLocation.Location = new System.Drawing.Point(0, 0);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 24);
            this.txtLocation.TabIndex = 1;
            // 
            // txtGroup
            // 
            // 
            // 
            // 
            this.txtGroup.Border.Class = "TextBoxBorder";
            this.txtGroup.Location = new System.Drawing.Point(0, 0);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(100, 24);
            this.txtGroup.TabIndex = 0;
            // 
            // UC_Asset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.ID);
            this.Name = "UC_Asset";
            this.Size = new System.Drawing.Size(480, 27);
            this.Load += new System.EventHandler(this.UC_Catogry_Load);
            this.ResumeLayout(false);

        }
        #endregion

       
        //private IContainer components = (IContainer)null;
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        private DevComponents.DotNetBar.ButtonX btn1;
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
        public DevComponents.DotNetBar.Controls.TextBoxX txtBranch;
        public DevComponents.DotNetBar.Controls.TextBoxX txtLocation;
        public DevComponents.DotNetBar.Controls.TextBoxX txtGroup;
    }
}
