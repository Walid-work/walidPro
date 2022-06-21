namespace Report_Pro.MyControls
{
    partial class Delivry_Row
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivry_Row));
            this.Ser = new DevComponents.Editors.IntegerInput();
            this.Weight_ = new DevComponents.Editors.DoubleInput();
            this.qty = new DevComponents.Editors.DoubleInput();
            this.totWeight = new DevComponents.Editors.DoubleInput();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.txtBalance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUnit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNote = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Code = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtModel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtCost = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.Ser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totWeight)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost)).BeginInit();
            this.SuspendLayout();
            // 
            // Ser
            // 
            this.Ser.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.Ser.BackgroundStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.Ser.BackgroundStyle.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.Ser.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Ser.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Ser.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Ser.BackgroundStyle.TextColor = System.Drawing.SystemColors.Window;
            this.Ser.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this.Ser, "Ser");
            this.Ser.ForeColor = System.Drawing.Color.White;
            this.Ser.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.Ser.Name = "Ser";
            this.Ser.TabStop = false;
            // 
            // Weight_
            // 
            this.Weight_.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.Weight_.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Weight_.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Weight_.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.Weight_.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Weight_.BackgroundStyle.Class = "TextBoxBorder";
            this.Weight_.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Weight_.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Weight_.DisabledBackColor = System.Drawing.Color.Ivory;
            this.Weight_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.Weight_, "Weight_");
            this.Weight_.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.Weight_.FocusHighlightEnabled = true;
            this.Weight_.Increment = 1D;
            this.Weight_.Name = "Weight_";
            // 
            // qty
            // 
            this.qty.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.qty.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.qty.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.qty.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.qty.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.qty.BackgroundStyle.Class = "TextBoxBorder";
            this.qty.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.qty.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this.qty, "qty");
            this.qty.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.qty.FocusHighlightEnabled = true;
            this.qty.Increment = 1D;
            this.qty.Name = "qty";
            this.qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Qty_KeyDown);
            this.qty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Qty_KeyUp);
            // 
            // totWeight
            // 
            this.totWeight.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.totWeight.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.totWeight.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.totWeight.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.totWeight.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.totWeight.BackgroundStyle.Class = "TextBoxBorder";
            this.totWeight.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.totWeight.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this.totWeight, "totWeight");
            this.totWeight.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.totWeight.FocusHighlightEnabled = true;
            this.totWeight.Increment = 1D;
            this.totWeight.Name = "totWeight";
            this.totWeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.totWeight_KeyUp);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Image = global::Report_Pro.Properties.Resources.Cross_icon1;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtBalance.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBalance.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtBalance, "txtBalance");
            this.txtBalance.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtBalance.FocusHighlightEnabled = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.txtUnit.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUnit.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtUnit, "txtUnit");
            this.txtUnit.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtUnit.FocusHighlightEnabled = true;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            // 
            // txtNote
            // 
            // 
            // 
            // 
            this.txtNote.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtNote.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtNote, "txtNote");
            this.txtNote.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtNote.FocusHighlightEnabled = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNote_KeyDown);
            // 
            // TxtDesc
            // 
            this.TxtDesc.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.TxtDesc.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtDesc.Border.BorderRightColor = System.Drawing.SystemColors.Window;
            this.TxtDesc.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.TxtDesc, "TxtDesc");
            this.TxtDesc.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.TxtDesc.FocusHighlightEnabled = true;
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.ReadOnly = true;
            // 
            // txt_Code
            // 
            // 
            // 
            // 
            this.txt_Code.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Code.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txt_Code, "txt_Code");
            this.txt_Code.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txt_Code.FocusHighlightEnabled = true;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.DoubleClick += new System.EventHandler(this.txt_Code_DoubleClick);
            this.txt_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Code_KeyDown);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.TxtDesc, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNote, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Ser, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_Code, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBalance, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.totWeight, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.qty, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.Weight_, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtUnit, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtModel, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCost, 11, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // txtModel
            // 
            this.txtModel.DisplayMember = "Text";
            resources.ApplyResources(this.txtModel, "txtModel");
            this.txtModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtModel.FormattingEnabled = true;
            this.txtModel.Name = "txtModel";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtCost.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCost.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtCost.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.txtCost.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCost.BackgroundStyle.Class = "TextBoxBorder";
            this.txtCost.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.txtCost.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCost.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtCost.FocusHighlightEnabled = true;
            this.txtCost.Increment = 1D;
            resources.ApplyResources(this.txtCost, "txtCost");
            this.txtCost.Name = "txtCost";
            this.txtCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.totWeight_KeyUp);
            // 
            // Delivry_Row
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Delivry_Row";
            this.Load += new System.EventHandler(this.Inv_Row_Load);
            this.Enter += new System.EventHandler(this.Inv_Row_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.Ser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totWeight)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevComponents.Editors.IntegerInput Ser;
        public DevComponents.Editors.DoubleInput Weight_;
        public DevComponents.Editors.DoubleInput qty;
        public DevComponents.Editors.DoubleInput totWeight;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        public DevComponents.DotNetBar.Controls.TextBoxX txtBalance;
        public DevComponents.DotNetBar.Controls.TextBoxX txtUnit;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNote;
        public DevComponents.DotNetBar.Controls.TextBoxX TxtDesc;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_Code;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public DevComponents.Editors.DoubleInput txtCost;
        public DevComponents.DotNetBar.Controls.ComboBoxEx txtModel;
    }
}
