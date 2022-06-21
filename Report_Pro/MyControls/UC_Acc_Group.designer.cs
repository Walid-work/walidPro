namespace Report_Pro.MyControls
{
    partial class UC_Acc_Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Acc_Group));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.branchID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMainAcc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.txtFinal = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.Font = null;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
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
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
            this.ID.Enter += new System.EventHandler(this.ID_Enter);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged_1);
            // 
            // branchID
            // 
            this.branchID.AccessibleDescription = null;
            this.branchID.AccessibleName = null;
            resources.ApplyResources(this.branchID, "branchID");
            this.branchID.BackgroundImage = null;
            // 
            // 
            // 
            this.branchID.Border.Class = "TextBoxBorder";
            this.branchID.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("branchID.ButtonCustom.DisplayPosition")));
            this.branchID.ButtonCustom.Image = null;
            this.branchID.ButtonCustom.Text = resources.GetString("branchID.ButtonCustom.Text");
            this.branchID.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("branchID.ButtonCustom2.DisplayPosition")));
            this.branchID.ButtonCustom2.Image = null;
            this.branchID.ButtonCustom2.Text = resources.GetString("branchID.ButtonCustom2.Text");
            this.branchID.Font = null;
            this.branchID.Name = "branchID";
            // 
            // txtMainAcc
            // 
            this.txtMainAcc.AccessibleDescription = null;
            this.txtMainAcc.AccessibleName = null;
            resources.ApplyResources(this.txtMainAcc, "txtMainAcc");
            this.txtMainAcc.BackgroundImage = null;
            // 
            // 
            // 
            this.txtMainAcc.Border.Class = "TextBoxBorder";
            this.txtMainAcc.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtMainAcc.ButtonCustom.DisplayPosition")));
            this.txtMainAcc.ButtonCustom.Image = null;
            this.txtMainAcc.ButtonCustom.Text = resources.GetString("txtMainAcc.ButtonCustom.Text");
            this.txtMainAcc.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtMainAcc.ButtonCustom2.DisplayPosition")));
            this.txtMainAcc.ButtonCustom2.Image = null;
            this.txtMainAcc.ButtonCustom2.Text = resources.GetString("txtMainAcc.ButtonCustom2.Text");
            this.txtMainAcc.Font = null;
            this.txtMainAcc.Name = "txtMainAcc";
            // 
            // Desc
            // 
            this.Desc.AcceptsReturn = true;
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
            // txtFinal
            // 
            this.txtFinal.AccessibleDescription = null;
            this.txtFinal.AccessibleName = null;
            resources.ApplyResources(this.txtFinal, "txtFinal");
            this.txtFinal.BackgroundImage = null;
            // 
            // 
            // 
            this.txtFinal.Border.Class = "TextBoxBorder";
            this.txtFinal.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtFinal.ButtonCustom.DisplayPosition")));
            this.txtFinal.ButtonCustom.Image = null;
            this.txtFinal.ButtonCustom.Text = resources.GetString("txtFinal.ButtonCustom.Text");
            this.txtFinal.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtFinal.ButtonCustom2.DisplayPosition")));
            this.txtFinal.ButtonCustom2.Image = null;
            this.txtFinal.ButtonCustom2.Text = resources.GetString("txtFinal.ButtonCustom2.Text");
            this.txtFinal.Font = null;
            this.txtFinal.Name = "txtFinal";
            // 
            // UC_Acc_Group
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = null;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtMainAcc);
            this.Controls.Add(this.branchID);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.ID);
            this.Font = null;
            this.Name = "UC_Acc_Group";
            this.Leave += new System.EventHandler(this.UC_Acc_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
        public DevComponents.DotNetBar.Controls.TextBoxX branchID;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMainAcc;
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        private DevComponents.DotNetBar.ButtonX btn1;
        public DevComponents.DotNetBar.Controls.TextBoxX txtFinal;
    }
}
