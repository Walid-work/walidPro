namespace Report_Pro.PL
{
    partial class frm_Search_Item
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSrch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSrch_3 = new System.Windows.Forms.TextBox();
            this.txtSrch_2 = new System.Windows.Forms.TextBox();
            this.txtSrch_1 = new System.Windows.Forms.TextBox();
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.dGV_pro_list = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_pro_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSrch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSrch_3);
            this.panel1.Controls.Add(this.txtSrch_2);
            this.panel1.Controls.Add(this.txtSrch_1);
            this.panel1.Controls.Add(this.txtSrch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 76);
            this.panel1.TabIndex = 0;
            // 
            // btnSrch
            // 
            this.btnSrch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSrch.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.btnSrch.Location = new System.Drawing.Point(232, 14);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(63, 35);
            this.btnSrch.TabIndex = 6;
            this.btnSrch.Text = "بحث";
            this.btnSrch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSrch.UseCompatibleTextRendering = true;
            this.btnSrch.UseVisualStyleBackColor = true;
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "التفاصيل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "رقم الصنف";
            // 
            // txtSrch_3
            // 
            this.txtSrch_3.Location = new System.Drawing.Point(313, 39);
            this.txtSrch_3.Name = "txtSrch_3";
            this.txtSrch_3.Size = new System.Drawing.Size(118, 20);
            this.txtSrch_3.TabIndex = 3;
            this.txtSrch_3.TextChanged += new System.EventHandler(this.txtSrch_3_TextChanged);
            // 
            // txtSrch_2
            // 
            this.txtSrch_2.Location = new System.Drawing.Point(437, 39);
            this.txtSrch_2.Name = "txtSrch_2";
            this.txtSrch_2.Size = new System.Drawing.Size(118, 20);
            this.txtSrch_2.TabIndex = 2;
            this.txtSrch_2.TextChanged += new System.EventHandler(this.txtSrch_2_TextChanged);
            // 
            // txtSrch_1
            // 
            this.txtSrch_1.Location = new System.Drawing.Point(561, 39);
            this.txtSrch_1.Name = "txtSrch_1";
            this.txtSrch_1.Size = new System.Drawing.Size(118, 20);
            this.txtSrch_1.TabIndex = 1;
            this.txtSrch_1.TextChanged += new System.EventHandler(this.txtSrch_1_TextChanged);
            // 
            // txtSrch
            // 
            this.txtSrch.Location = new System.Drawing.Point(561, 12);
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.Size = new System.Drawing.Size(118, 20);
            this.txtSrch.TabIndex = 0;
            this.txtSrch.TextChanged += new System.EventHandler(this.txtSrch_TextChanged);
            // 
            // dGV_pro_list
            // 
            this.dGV_pro_list.AllowUserToAddRows = false;
            this.dGV_pro_list.AllowUserToDeleteRows = false;
            this.dGV_pro_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_pro_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_pro_list.Location = new System.Drawing.Point(0, 76);
            this.dGV_pro_list.Name = "dGV_pro_list";
            this.dGV_pro_list.ReadOnly = true;
            this.dGV_pro_list.Size = new System.Drawing.Size(787, 185);
            this.dGV_pro_list.TabIndex = 1;
            this.dGV_pro_list.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // frm_Search_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 261);
            this.Controls.Add(this.dGV_pro_list);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Search_Item";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frm_Search_Item";
            this.Load += new System.EventHandler(this.frm_Search_Item_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_pro_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSrch_3;
        private System.Windows.Forms.TextBox txtSrch_2;
        private System.Windows.Forms.TextBox txtSrch_1;
        private System.Windows.Forms.TextBox txtSrch;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dGV_pro_list;
    }
}