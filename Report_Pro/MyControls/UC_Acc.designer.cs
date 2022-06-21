namespace Report_Pro.MyControls
{
    partial class UC_Acc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Acc));
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.branchID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMainAcc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFinal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Code_Sales = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Desc_Sales = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Ratio_Sales = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Ratio_Purch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Desc_Purch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Code_Purch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAccCash = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtKMCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btn1 = new DevExpress.XtraEditors.SimpleButton();
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
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
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            resources.ApplyResources(this.dgv1, "dgv1");
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
            // 
            // ID
            // 
            // 
            // 
            // 
            this.ID.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged_1);
            this.ID.Enter += new System.EventHandler(this.ID_Enter);
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
            // 
            // branchID
            // 
            // 
            // 
            // 
            this.branchID.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.branchID, "branchID");
            this.branchID.Name = "branchID";
            // 
            // txtMainAcc
            // 
            // 
            // 
            // 
            this.txtMainAcc.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtMainAcc, "txtMainAcc");
            this.txtMainAcc.Name = "txtMainAcc";
            // 
            // txtFinal
            // 
            // 
            // 
            // 
            this.txtFinal.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtFinal, "txtFinal");
            this.txtFinal.Name = "txtFinal";
            // 
            // KM_Code_Sales
            // 
            // 
            // 
            // 
            this.KM_Code_Sales.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.KM_Code_Sales, "KM_Code_Sales");
            this.KM_Code_Sales.Name = "KM_Code_Sales";
            // 
            // KM_Desc_Sales
            // 
            // 
            // 
            // 
            this.KM_Desc_Sales.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.KM_Desc_Sales, "KM_Desc_Sales");
            this.KM_Desc_Sales.Name = "KM_Desc_Sales";
            // 
            // KM_Ratio_Sales
            // 
            // 
            // 
            // 
            this.KM_Ratio_Sales.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.KM_Ratio_Sales, "KM_Ratio_Sales");
            this.KM_Ratio_Sales.Name = "KM_Ratio_Sales";
            // 
            // KM_Ratio_Purch
            // 
            // 
            // 
            // 
            this.KM_Ratio_Purch.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.KM_Ratio_Purch, "KM_Ratio_Purch");
            this.KM_Ratio_Purch.Name = "KM_Ratio_Purch";
            // 
            // KM_Desc_Purch
            // 
            // 
            // 
            // 
            this.KM_Desc_Purch.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.KM_Desc_Purch, "KM_Desc_Purch");
            this.KM_Desc_Purch.Name = "KM_Desc_Purch";
            // 
            // KM_Code_Purch
            // 
            // 
            // 
            // 
            this.KM_Code_Purch.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.KM_Code_Purch, "KM_Code_Purch");
            this.KM_Code_Purch.Name = "KM_Code_Purch";
            // 
            // txtAccCash
            // 
            // 
            // 
            // 
            this.txtAccCash.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtAccCash, "txtAccCash");
            this.txtAccCash.Name = "txtAccCash";
            // 
            // txtKMCode
            // 
            // 
            // 
            // 
            this.txtKMCode.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtKMCode, "txtKMCode");
            this.txtKMCode.Name = "txtKMCode";
            // 
            // layoutControl1
            // 
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Controls.Add(this.btn1);
            this.layoutControl1.Controls.Add(this.ID);
            this.layoutControl1.Controls.Add(this.Desc);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            // 
            // btn1
            // 
            this.btn1.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.btn1.Appearance.BackColor2 = ((System.Drawing.Color)(resources.GetObject("btn1.Appearance.BackColor2")));
            this.btn1.Appearance.Options.UseBackColor = true;
            this.btn1.AppearanceHovered.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn1.AppearanceHovered.BackColor2 = ((System.Drawing.Color)(resources.GetObject("btn1.AppearanceHovered.BackColor2")));
            this.btn1.AppearanceHovered.Options.UseBackColor = true;
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.ImageOptions.Image = global::Report_Pro.Properties.Resources.zoom_16x16;
            this.btn1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btn1.Name = "btn1";
            this.btn1.StyleController = this.layoutControl1;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Desc
            // 
            this.Desc.AcceptsReturn = true;
            // 
            // 
            // 
            this.Desc.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.Desc, "Desc");
            this.Desc.Name = "Desc";
            this.Desc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Desc_KeyUp);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(475, 30);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 20);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(70, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Desc;
            this.layoutControlItem3.Location = new System.Drawing.Point(100, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem3.Size = new System.Drawing.Size(375, 30);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ID;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(70, 20);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(70, 20);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(70, 20);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn1;
            this.layoutControlItem2.Location = new System.Drawing.Point(70, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(30, 30);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // UC_Acc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.txtKMCode);
            this.Controls.Add(this.txtAccCash);
            this.Controls.Add(this.KM_Ratio_Purch);
            this.Controls.Add(this.KM_Desc_Purch);
            this.Controls.Add(this.KM_Code_Purch);
            this.Controls.Add(this.KM_Ratio_Sales);
            this.Controls.Add(this.KM_Desc_Sales);
            this.Controls.Add(this.KM_Code_Sales);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtMainAcc);
            this.Controls.Add(this.branchID);
            this.Controls.Add(this.dgv1);
            this.Name = "UC_Acc";
            this.Leave += new System.EventHandler(this.UC_Acc_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
        public DevComponents.DotNetBar.Controls.TextBoxX branchID;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMainAcc;
        public DevComponents.DotNetBar.Controls.TextBoxX txtFinal;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Code_Sales;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Desc_Sales;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Ratio_Sales;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Ratio_Purch;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Desc_Purch;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Code_Purch;
        public DevComponents.DotNetBar.Controls.TextBoxX txtAccCash;
        public DevComponents.DotNetBar.Controls.TextBoxX txtKMCode;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btn1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
