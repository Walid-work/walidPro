namespace Report_Pro.MyControls
{
    partial class UC_cost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_cost));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtBranch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMain = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Tfinl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAcc = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
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
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged_1);
            this.ID.Enter += new System.EventHandler(this.ID_Enter);
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
            // 
            // btn1
            // 
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn1.Image = global::Report_Pro.Properties.Resources.search_16;
            this.btn1.Name = "btn1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Desc
            // 
            resources.ApplyResources(this.Desc, "Desc");
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
            this.Desc.TextChanged += new System.EventHandler(this.Desc_TextChanged);
            this.Desc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Desc_KeyUp);
            // 
            // dgv1
            // 
            resources.ApplyResources(this.dgv1, "dgv1");
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
            // 
            // txtBranch
            // 
            resources.ApplyResources(this.txtBranch, "txtBranch");
            // 
            // 
            // 
            this.txtBranch.Border.Class = "TextBoxBorder";
            this.txtBranch.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtBranch.ButtonCustom.DisplayPosition")));
            this.txtBranch.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtBranch.ButtonCustom.Image")));
            this.txtBranch.ButtonCustom.Text = resources.GetString("txtBranch.ButtonCustom.Text");
            this.txtBranch.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtBranch.ButtonCustom2.DisplayPosition")));
            this.txtBranch.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtBranch.ButtonCustom2.Image")));
            this.txtBranch.ButtonCustom2.Text = resources.GetString("txtBranch.ButtonCustom2.Text");
            this.txtBranch.Name = "txtBranch";
            // 
            // txtMain
            // 
            resources.ApplyResources(this.txtMain, "txtMain");
            // 
            // 
            // 
            this.txtMain.Border.Class = "TextBoxBorder";
            this.txtMain.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtMain.ButtonCustom.DisplayPosition")));
            this.txtMain.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtMain.ButtonCustom.Image")));
            this.txtMain.ButtonCustom.Text = resources.GetString("txtMain.ButtonCustom.Text");
            this.txtMain.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtMain.ButtonCustom2.DisplayPosition")));
            this.txtMain.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtMain.ButtonCustom2.Image")));
            this.txtMain.ButtonCustom2.Text = resources.GetString("txtMain.ButtonCustom2.Text");
            this.txtMain.Name = "txtMain";
            // 
            // txt_Tfinl
            // 
            resources.ApplyResources(this.txt_Tfinl, "txt_Tfinl");
            // 
            // 
            // 
            this.txt_Tfinl.Border.Class = "TextBoxBorder";
            this.txt_Tfinl.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txt_Tfinl.ButtonCustom.DisplayPosition")));
            this.txt_Tfinl.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txt_Tfinl.ButtonCustom.Image")));
            this.txt_Tfinl.ButtonCustom.Text = resources.GetString("txt_Tfinl.ButtonCustom.Text");
            this.txt_Tfinl.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txt_Tfinl.ButtonCustom2.DisplayPosition")));
            this.txt_Tfinl.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txt_Tfinl.ButtonCustom2.Image")));
            this.txt_Tfinl.ButtonCustom2.Text = resources.GetString("txt_Tfinl.ButtonCustom2.Text");
            this.txt_Tfinl.Name = "txt_Tfinl";
            // 
            // txtAcc
            // 
            resources.ApplyResources(this.txtAcc, "txtAcc");
            // 
            // 
            // 
            this.txtAcc.Border.Class = "TextBoxBorder";
            this.txtAcc.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtAcc.ButtonCustom.DisplayPosition")));
            this.txtAcc.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtAcc.ButtonCustom.Image")));
            this.txtAcc.ButtonCustom.Text = resources.GetString("txtAcc.ButtonCustom.Text");
            this.txtAcc.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtAcc.ButtonCustom2.DisplayPosition")));
            this.txtAcc.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtAcc.ButtonCustom2.Image")));
            this.txtAcc.ButtonCustom2.Text = resources.GetString("txtAcc.ButtonCustom2.Text");
            this.txtAcc.Name = "txtAcc";
            // 
            // UC_cost
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.txt_Tfinl);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.ID);
            this.Name = "UC_cost";
            this.Leave += new System.EventHandler(this.UC_cost_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btn1;
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        public DevComponents.DotNetBar.Controls.TextBoxX txtBranch;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMain;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_Tfinl;
        public DevComponents.DotNetBar.Controls.TextBoxX txtAcc;
    }
}
