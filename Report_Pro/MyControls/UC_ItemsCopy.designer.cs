namespace Report_Pro.MyControls
{
    partial class UC_ItemsCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Items));
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.itemPrice = new DevComponents.Editors.DoubleInput();
            this.itemWeight = new DevComponents.Editors.DoubleInput();
            this.itemUnit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLenth = new DevComponents.Editors.DoubleInput();
            this.txtWidth = new DevComponents.Editors.DoubleInput();
            this.txtCost = new DevComponents.Editors.DoubleInput();
            this.txtDepth = new DevComponents.Editors.DoubleInput();
            this.txtItemVat = new Report_Pro.MyControls.decimalText();
            this.txtKmItem = new Report_Pro.MyControls.decimalText();
            this.uc_SearchItem1 = new Report_Pro.MyControls.Uc_SearchItem();
            this.txt_s1 = new System.Windows.Forms.TextBox();
            this.txt_s2 = new System.Windows.Forms.TextBox();
            this.txt_s3 = new System.Windows.Forms.TextBox();
            this.txt_s4 = new System.Windows.Forms.TextBox();
            this.txt_s5 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Desc = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLenth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepth)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.Image = global::Report_Pro.Properties.Resources.search_16;
            this.btn1.Name = "btn1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // itemPrice
            // 
            // 
            // 
            // 
            this.itemPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itemPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.itemPrice.Increment = 1D;
            resources.ApplyResources(this.itemPrice, "itemPrice");
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ShowUpDown = true;
            // 
            // itemWeight
            // 
            // 
            // 
            // 
            this.itemWeight.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itemWeight.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.itemWeight.Increment = 1D;
            resources.ApplyResources(this.itemWeight, "itemWeight");
            this.itemWeight.Name = "itemWeight";
            this.itemWeight.ShowUpDown = true;
            // 
            // itemUnit
            // 
            // 
            // 
            // 
            this.itemUnit.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.itemUnit, "itemUnit");
            this.itemUnit.Name = "itemUnit";
            // 
            // txtLenth
            // 
            // 
            // 
            // 
            this.txtLenth.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtLenth.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtLenth.Increment = 1D;
            resources.ApplyResources(this.txtLenth, "txtLenth");
            this.txtLenth.Name = "txtLenth";
            this.txtLenth.ShowUpDown = true;
            // 
            // txtWidth
            // 
            // 
            // 
            // 
            this.txtWidth.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtWidth.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtWidth.Increment = 1D;
            resources.ApplyResources(this.txtWidth, "txtWidth");
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.ShowUpDown = true;
            // 
            // txtCost
            // 
            // 
            // 
            // 
            this.txtCost.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtCost.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCost.Increment = 1D;
            resources.ApplyResources(this.txtCost, "txtCost");
            this.txtCost.Name = "txtCost";
            this.txtCost.ShowUpDown = true;
            // 
            // txtDepth
            // 
            // 
            // 
            // 
            this.txtDepth.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDepth.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtDepth.Increment = 1D;
            resources.ApplyResources(this.txtDepth, "txtDepth");
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.ShowUpDown = true;
            // 
            // txtItemVat
            // 
            this.txtItemVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemVat.DicemalDigits = 0;
            resources.ApplyResources(this.txtItemVat, "txtItemVat");
            this.txtItemVat.Name = "txtItemVat";
            this.txtItemVat.ProgramDigits = false;
            this.txtItemVat.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtKmItem
            // 
            this.txtKmItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKmItem.DicemalDigits = 0;
            resources.ApplyResources(this.txtKmItem, "txtKmItem");
            this.txtKmItem.Name = "txtKmItem";
            this.txtKmItem.ProgramDigits = false;
            this.txtKmItem.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // uc_SearchItem1
            // 
            resources.ApplyResources(this.uc_SearchItem1, "uc_SearchItem1");
            this.uc_SearchItem1.Name = "uc_SearchItem1";
            this.uc_SearchItem1.Load += new System.EventHandler(this.uc_SearchItem1_Load);
            this.uc_SearchItem1.Click += new System.EventHandler(this.uc_SearchItem1_Click);
            this.uc_SearchItem1.DoubleClick += new System.EventHandler(this.uc_SearchItem1_DoubleClick);
            // 
            // txt_s1
            // 
            resources.ApplyResources(this.txt_s1, "txt_s1");
            this.txt_s1.Name = "txt_s1";
            // 
            // txt_s2
            // 
            resources.ApplyResources(this.txt_s2, "txt_s2");
            this.txt_s2.Name = "txt_s2";
            // 
            // txt_s3
            // 
            resources.ApplyResources(this.txt_s3, "txt_s3");
            this.txt_s3.Name = "txt_s3";
            // 
            // txt_s4
            // 
            resources.ApplyResources(this.txt_s4, "txt_s4");
            this.txt_s4.Name = "txt_s4";
            // 
            // txt_s5
            // 
            resources.ApplyResources(this.txt_s5, "txt_s5");
            this.txt_s5.Name = "txt_s5";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.Desc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ID, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Desc
            // 
            resources.ApplyResources(this.Desc, "Desc");
            this.Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Desc.Name = "Desc";
            this.Desc.TextChanged += new System.EventHandler(this.Desc_TextChanged);
            // 
            // ID
            // 
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
            // 
            // UC_Items
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txt_s5);
            this.Controls.Add(this.txt_s4);
            this.Controls.Add(this.txt_s3);
            this.Controls.Add(this.txt_s2);
            this.Controls.Add(this.txt_s1);
            this.Controls.Add(this.uc_SearchItem1);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.txtLenth);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.itemUnit);
            this.Controls.Add(this.itemWeight);
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.txtItemVat);
            this.Controls.Add(this.txtKmItem);
            this.Name = "UC_Items";
            this.Load += new System.EventHandler(this.UC_Catogry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLenth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepth)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btn1;
        public DevComponents.Editors.DoubleInput itemPrice;
        public DevComponents.Editors.DoubleInput itemWeight;
        public DevComponents.DotNetBar.Controls.TextBoxX itemUnit;
        public DevComponents.Editors.DoubleInput txtLenth;
        public DevComponents.Editors.DoubleInput txtWidth;
        public DevComponents.Editors.DoubleInput txtCost;
        public DevComponents.Editors.DoubleInput txtDepth;
        public decimalText txtItemVat;
        public decimalText txtKmItem;
        private Uc_SearchItem uc_SearchItem1;
        private System.Windows.Forms.TextBox txt_s1;
        private System.Windows.Forms.TextBox txt_s2;
        private System.Windows.Forms.TextBox txt_s3;
        private System.Windows.Forms.TextBox txt_s4;
        private System.Windows.Forms.TextBox txt_s5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox Desc;
        public System.Windows.Forms.TextBox ID;
    }
}
