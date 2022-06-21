namespace Report_Pro.PL
{
    partial class frm_user_mang
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.list_users = new System.Windows.Forms.ListBox();
            this.list_screens = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Active_list = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chCanSeeCost = new System.Windows.Forms.CheckBox();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.list_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(861, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "بحث عن مستخدم";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "القوائم";
            // 
            // dGV1
            // 
            this.dGV1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(443, 53);
            this.dGV1.Name = "dGV1";
            this.dGV1.Size = new System.Drawing.Size(409, 274);
            this.dGV1.TabIndex = 5;
            // 
            // list_users
            // 
            this.list_users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.list_users.FormattingEnabled = true;
            this.list_users.Location = new System.Drawing.Point(861, 74);
            this.list_users.Name = "list_users";
            this.list_users.Size = new System.Drawing.Size(138, 251);
            this.list_users.TabIndex = 6;
            this.list_users.SelectedValueChanged += new System.EventHandler(this.list_users_SelectedValueChanged);
            // 
            // list_screens
            // 
            this.list_screens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.list_screens.FormattingEnabled = true;
            this.list_screens.Location = new System.Drawing.Point(12, 51);
            this.list_screens.Name = "list_screens";
            this.list_screens.Size = new System.Drawing.Size(134, 277);
            this.list_screens.TabIndex = 7;
            this.list_screens.ValueMemberChanged += new System.EventHandler(this.list_screens_ValueMemberChanged);
            this.list_screens.SelectedValueChanged += new System.EventHandler(this.list_screens_SelectedValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(195, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Active_list
            // 
            this.Active_list.AutoSize = true;
            this.Active_list.Location = new System.Drawing.Point(271, 12);
            this.Active_list.Name = "Active_list";
            this.Active_list.Size = new System.Drawing.Size(87, 17);
            this.Active_list.TabIndex = 9;
            this.Active_list.Text = "تفعيل القائمة";
            this.Active_list.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(457, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chCanSeeCost
            // 
            this.chCanSeeCost.AutoSize = true;
            this.chCanSeeCost.Location = new System.Drawing.Point(443, 333);
            this.chCanSeeCost.Name = "chCanSeeCost";
            this.chCanSeeCost.Size = new System.Drawing.Size(116, 17);
            this.chCanSeeCost.TabIndex = 12;
            this.chCanSeeCost.Text = "Can See Item Cost";
            this.chCanSeeCost.UseVisualStyleBackColor = true;
            // 
            // dgv_list
            // 
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.list_id,
            this.list_name,
            this.list_active});
            this.dgv_list.Location = new System.Drawing.Point(152, 54);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowHeadersVisible = false;
            this.dgv_list.Size = new System.Drawing.Size(285, 274);
            this.dgv_list.TabIndex = 13;
            // 
            // list_id
            // 
            this.list_id.HeaderText = "الكود";
            this.list_id.Name = "list_id";
            this.list_id.Width = 70;
            // 
            // list_name
            // 
            this.list_name.HeaderText = "اسم القائمة";
            this.list_name.Name = "list_name";
            this.list_name.Width = 150;
            // 
            // list_active
            // 
            this.list_active.HeaderText = "تفعيل";
            this.list_active.Name = "list_active";
            this.list_active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.list_active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.list_active.Width = 60;
            // 
            // frm_user_mang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 475);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.chCanSeeCost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Active_list);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_screens);
            this.Controls.Add(this.list_users);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_user_mang";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة الصلاحيات";
            this.Load += new System.EventHandler(this.user_mang_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.ListBox list_users;
        private System.Windows.Forms.ListBox list_screens;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox Active_list;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chCanSeeCost;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn list_active;
    }
}