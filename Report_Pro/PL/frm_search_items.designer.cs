namespace Report_Pro.PL
{
    partial class frm_search_items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_search_items));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ts1 = new System.Windows.Forms.Label();
            this.ts2 = new System.Windows.Forms.Label();
            this.chSaveSearchData = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnSrch = new DevComponents.DotNetBar.ButtonX();
            this.txtserch_4 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radiobalance = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsrch_1 = new System.Windows.Forms.TextBox();
            this.txtSrch_3 = new System.Windows.Forms.TextBox();
            this.txtserch_2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dGV_pro_list = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_pro_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupPanel1);
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.ts1);
            this.groupPanel1.Controls.Add(this.ts2);
            this.groupPanel1.Controls.Add(this.chSaveSearchData);
            this.groupPanel1.Controls.Add(this.btnSrch);
            this.groupPanel1.Controls.Add(this.txtserch_4);
            this.groupPanel1.Controls.Add(this.panel3);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.txtSrch);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.txtsrch_1);
            this.groupPanel1.Controls.Add(this.txtSrch_3);
            this.groupPanel1.Controls.Add(this.txtserch_2);
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.Name = "groupPanel1";
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // ts1
            // 
            resources.ApplyResources(this.ts1, "ts1");
            this.ts1.BackColor = System.Drawing.Color.Transparent;
            this.ts1.Name = "ts1";
            // 
            // ts2
            // 
            resources.ApplyResources(this.ts2, "ts2");
            this.ts2.BackColor = System.Drawing.Color.Transparent;
            this.ts2.Name = "ts2";
            // 
            // chSaveSearchData
            // 
            this.chSaveSearchData.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.chSaveSearchData, "chSaveSearchData");
            this.chSaveSearchData.Name = "chSaveSearchData";
            // 
            // btnSrch
            // 
            this.btnSrch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSrch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSrch.Image = global::Report_Pro.Properties.Resources.search;
            this.btnSrch.ImageFixedSize = new System.Drawing.Size(32, 32);
            resources.ApplyResources(this.btnSrch, "btnSrch");
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click_1);
            // 
            // txtserch_4
            // 
            resources.ApplyResources(this.txtserch_4, "txtserch_4");
            this.txtserch_4.Name = "txtserch_4";
            this.txtserch_4.TextChanged += new System.EventHandler(this.txtserch_4_TextChanged);
            this.txtserch_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtserch_4_KeyDown);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.radioAll);
            this.panel3.Controls.Add(this.radiobalance);
            this.panel3.Name = "panel3";
            // 
            // radioAll
            // 
            resources.ApplyResources(this.radioAll, "radioAll");
            this.radioAll.Checked = true;
            this.radioAll.Name = "radioAll";
            this.radioAll.TabStop = true;
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radiobalance
            // 
            resources.ApplyResources(this.radiobalance, "radiobalance");
            this.radiobalance.Name = "radiobalance";
            this.radiobalance.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // txtSrch
            // 
            resources.ApplyResources(this.txtSrch, "txtSrch");
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.TextChanged += new System.EventHandler(this.txtSrch_TextChanged);
            this.txtSrch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSrch_KeyDown);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // txtsrch_1
            // 
            resources.ApplyResources(this.txtsrch_1, "txtsrch_1");
            this.txtsrch_1.Name = "txtsrch_1";
            this.txtsrch_1.TextChanged += new System.EventHandler(this.txtsrch_1_TextChanged);
            this.txtsrch_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsrch_1_KeyDown);
            // 
            // txtSrch_3
            // 
            resources.ApplyResources(this.txtSrch_3, "txtSrch_3");
            this.txtSrch_3.Name = "txtSrch_3";
            this.txtSrch_3.TextChanged += new System.EventHandler(this.txtSrch_3_TextChanged);
            this.txtSrch_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSrch_3_KeyDown);
            this.txtSrch_3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrch_3_KeyUp);
            // 
            // txtserch_2
            // 
            resources.ApplyResources(this.txtserch_2, "txtserch_2");
            this.txtserch_2.Name = "txtserch_2";
            this.txtserch_2.TextChanged += new System.EventHandler(this.txtserch_2_TextChanged);
            this.txtserch_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtserch_2_KeyDown);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dGV_pro_list
            // 
            this.dGV_pro_list.AllowUserToAddRows = false;
            this.dGV_pro_list.AllowUserToDeleteRows = false;
            this.dGV_pro_list.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGV_pro_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dGV_pro_list, "dGV_pro_list");
            this.dGV_pro_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGV_pro_list.MultiSelect = false;
            this.dGV_pro_list.Name = "dGV_pro_list";
            this.dGV_pro_list.ReadOnly = true;
            this.dGV_pro_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_pro_list.DoubleClick += new System.EventHandler(this.dGV_pro_list_DoubleClick);
            this.dGV_pro_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dGV_pro_list_KeyDown);
            this.dGV_pro_list.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dGV_pro_list_KeyUp);
            // 
            // frm_search_items
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGV_pro_list);
            this.Controls.Add(this.panel1);
            this.Name = "frm_search_items";
            this.Load += new System.EventHandler(this.frm_search_items_Load);
            this.panel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_pro_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radiobalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSrch_3;
        private System.Windows.Forms.TextBox txtserch_2;
        private System.Windows.Forms.TextBox txtsrch_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSrch;
        public System.Windows.Forms.DataGridView dGV_pro_list;
        private System.Windows.Forms.TextBox txtserch_4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnSrch;
        private DevComponents.DotNetBar.Controls.CheckBoxX chSaveSearchData;
        private System.Windows.Forms.Label ts1;
        private System.Windows.Forms.Label ts2;
    }
}