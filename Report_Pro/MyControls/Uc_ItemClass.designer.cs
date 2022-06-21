namespace Report_Pro.MyControls
{
    partial class Uc_ItemClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_Group));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AccessibleDescription = null;
            this.dgv1.AccessibleName = null;
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgv1, "dgv1");
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv1.BackgroundImage = null;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv1.Font = null;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
            // 
            // Desc
            // 
            this.Desc.AccessibleDescription = null;
            this.Desc.AccessibleName = null;
            resources.ApplyResources(this.Desc, "Desc");
            this.Desc.BackgroundImage = null;
            // 
            // 
            // 
            this.Desc.Border.Class = "TextBoxBorder";
            this.Desc.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("Desc.ButtonCustom.DisplayPosition")));
            this.Desc.ButtonCustom.Image = null;
            this.Desc.ButtonCustom.Text = resources.GetString("Desc.ButtonCustom.Text");
            this.Desc.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("Desc.ButtonCustom2.DisplayPosition")));
            this.Desc.ButtonCustom2.Image = null;
            this.Desc.ButtonCustom2.Text = resources.GetString("Desc.ButtonCustom2.Text");
            this.Desc.Font = null;
            this.Desc.Name = "Desc";
            this.Desc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Desc_KeyUp);
            this.Desc.TextChanged += new System.EventHandler(this.Desc_TextChanged_1);
            // 
            // btn1
            // 
            this.btn1.AccessibleDescription = null;
            this.btn1.AccessibleName = null;
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn1.CommandParameter = null;
            this.btn1.Font = null;
            this.btn1.Image = global::Report_Pro.Properties.Resources.search_16;
            this.btn1.Name = "btn1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // ID
            // 
            this.ID.AccessibleDescription = null;
            this.ID.AccessibleName = null;
            resources.ApplyResources(this.ID, "ID");
            this.ID.BackgroundImage = null;
            // 
            // 
            // 
            this.ID.Border.Class = "TextBoxBorder";
            this.ID.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("ID.ButtonCustom.DisplayPosition")));
            this.ID.ButtonCustom.Image = null;
            this.ID.ButtonCustom.Text = resources.GetString("ID.ButtonCustom.Text");
            this.ID.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("ID.ButtonCustom2.DisplayPosition")));
            this.ID.ButtonCustom2.Image = null;
            this.ID.ButtonCustom2.Text = resources.GetString("ID.ButtonCustom2.Text");
            this.ID.Font = null;
            this.ID.Name = "ID";
            this.ID.Enter += new System.EventHandler(this.ID_Enter);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // Uc_Group
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.ID);
            this.Font = null;
            this.Name = "Uc_Group";
            this.Leave += new System.EventHandler(this.UC_Catogry_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        private DevComponents.DotNetBar.ButtonX btn1;
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
    }
}
