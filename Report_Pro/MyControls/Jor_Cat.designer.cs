namespace Report_Pro.MyControls
{
    partial class Jor_Cat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jor_Cat));
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Desc
            // 
            resources.ApplyResources(this.Desc, "Desc");
            this.Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.Desc.Border.Class = "TextBoxBorder";
            this.Desc.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("Desc.ButtonCustom.DisplayPosition")));
            this.Desc.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("Desc.ButtonCustom.Image")));
            this.Desc.ButtonCustom.Text = resources.GetString("Desc.ButtonCustom.Text");
            this.Desc.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("Desc.ButtonCustom2.DisplayPosition")));
            this.Desc.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("Desc.ButtonCustom2.Image")));
            this.Desc.ButtonCustom2.Text = resources.GetString("Desc.ButtonCustom2.Text");
            this.Desc.Name = "Desc";
            this.Desc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Desc_KeyUp);
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            // 
            // 
            // 
            this.ID.Border.Class = "TextBoxBorder";
            this.ID.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("ID.ButtonCustom.DisplayPosition")));
            this.ID.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("ID.ButtonCustom.Image")));
            this.ID.ButtonCustom.Text = resources.GetString("ID.ButtonCustom.Text");
            this.ID.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("ID.ButtonCustom2.DisplayPosition")));
            this.ID.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("ID.ButtonCustom2.Image")));
            this.ID.ButtonCustom2.Text = resources.GetString("ID.ButtonCustom2.Text");
            this.ID.Name = "ID";
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.Enter += new System.EventHandler(this.ID_Enter);
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Desc, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Jor_Cat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Jor_Cat";
            this.Load += new System.EventHandler(this.UC_Catogry_Load);
            this.Leave += new System.EventHandler(this.UC_Catogry_Leave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
