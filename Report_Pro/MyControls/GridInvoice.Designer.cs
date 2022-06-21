namespace Report_Pro.MyControls
{
    partial class GridInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtUnit = new System.Windows.Forms.ComboBox();
            this.txtKmAcc = new System.Windows.Forms.TextBox();
            this.txtKmCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this._ser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._totalweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tonprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._netvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._vatratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._kmcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._kmacc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRow = new DevExpress.XtraEditors.SimpleButton();
            this.txtAccKMCode = new System.Windows.Forms.TextBox();
            this.VatType = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.inv_countItems = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.ch2 = new System.Windows.Forms.CheckBox();
            this.txtCost = new Report_Pro.MyControls.decimalText();
            this.txtBalance = new Report_Pro.MyControls.decimalText();
            this.txtVat = new Report_Pro.MyControls.decimalText();
            this.inv_vatAddDiscount = new Report_Pro.MyControls.decimalText();
            this.inv_netAddDiscount = new Report_Pro.MyControls.decimalText();
            this.inv_discRate = new Report_Pro.MyControls.decimalText();
            this.inv_totalQty = new Report_Pro.MyControls.decimalText();
            this.inv_totalWeight = new Report_Pro.MyControls.decimalText();
            this.inv_Total = new Report_Pro.MyControls.decimalText();
            this.inv_totalBeforVat = new Report_Pro.MyControls.decimalText();
            this.inv_netValue = new Report_Pro.MyControls.decimalText();
            this.inv_itemsDiscount = new Report_Pro.MyControls.decimalText();
            this.inv_totalVAT = new Report_Pro.MyControls.decimalText();
            this.inv_addDiscount = new Report_Pro.MyControls.decimalText();
            this.txtTonPrice = new Report_Pro.MyControls.decimalText();
            this.txtNetValue = new Report_Pro.MyControls.decimalText();
            this.txtVatRatio = new Report_Pro.MyControls.decimalText();
            this.txtDiscount = new Report_Pro.MyControls.decimalText();
            this.txtTotal = new Report_Pro.MyControls.decimalText();
            this.txtPrice = new Report_Pro.MyControls.decimalText();
            this.txtTotalWeight = new Report_Pro.MyControls.decimalText();
            this.txtQty = new Report_Pro.MyControls.decimalText();
            this.txtWeight = new Report_Pro.MyControls.decimalText();
            this.txtItem = new Report_Pro.MyControls.UC_Items();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnit
            // 
            resources.ApplyResources(this.txtUnit, "txtUnit");
            this.txtUnit.FormattingEnabled = true;
            this.txtUnit.Name = "txtUnit";
            // 
            // txtKmAcc
            // 
            resources.ApplyResources(this.txtKmAcc, "txtKmAcc");
            this.txtKmAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKmAcc.Name = "txtKmAcc";
            // 
            // txtKmCode
            // 
            resources.ApplyResources(this.txtKmCode, "txtKmCode");
            this.txtKmCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKmCode.Name = "txtKmCode";
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.BackColor = System.Drawing.Color.LightCyan;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Name = "label18";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.LightCyan;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Name = "label17";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.LightCyan;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.LightCyan;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Name = "label15";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.LightCyan;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Name = "label12";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.LightCyan;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Name = "label14";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.LightCyan;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Name = "label13";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.LightCyan;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.LightCyan;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.LightCyan;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.LightCyan;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.LightCyan;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.LightCyan;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv1
            // 
            resources.ApplyResources(this.dgv1, "dgv1");
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._ser,
            this._itemcode,
            this._item,
            this._description,
            this._unit,
            this._weight,
            this._quantity,
            this._totalweight,
            this._price,
            this._tonprice,
            this._total,
            this._discount,
            this._netvalue,
            this._vatratio,
            this._vat,
            this._balance,
            this._cost,
            this._kmcode,
            this._kmacc,
            this.unitCode,
            this.addDiscount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            // 
            // _ser
            // 
            resources.ApplyResources(this._ser, "_ser");
            this._ser.Name = "_ser";
            this._ser.ReadOnly = true;
            // 
            // _itemcode
            // 
            resources.ApplyResources(this._itemcode, "_itemcode");
            this._itemcode.Name = "_itemcode";
            this._itemcode.ReadOnly = true;
            // 
            // _item
            // 
            this._item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this._item, "_item");
            this._item.Name = "_item";
            this._item.ReadOnly = true;
            // 
            // _description
            // 
            resources.ApplyResources(this._description, "_description");
            this._description.Name = "_description";
            this._description.ReadOnly = true;
            // 
            // _unit
            // 
            resources.ApplyResources(this._unit, "_unit");
            this._unit.Name = "_unit";
            this._unit.ReadOnly = true;
            // 
            // _weight
            // 
            resources.ApplyResources(this._weight, "_weight");
            this._weight.Name = "_weight";
            this._weight.ReadOnly = true;
            // 
            // _quantity
            // 
            resources.ApplyResources(this._quantity, "_quantity");
            this._quantity.Name = "_quantity";
            this._quantity.ReadOnly = true;
            // 
            // _totalweight
            // 
            resources.ApplyResources(this._totalweight, "_totalweight");
            this._totalweight.Name = "_totalweight";
            this._totalweight.ReadOnly = true;
            // 
            // _price
            // 
            resources.ApplyResources(this._price, "_price");
            this._price.Name = "_price";
            this._price.ReadOnly = true;
            // 
            // _tonprice
            // 
            resources.ApplyResources(this._tonprice, "_tonprice");
            this._tonprice.Name = "_tonprice";
            this._tonprice.ReadOnly = true;
            // 
            // _total
            // 
            resources.ApplyResources(this._total, "_total");
            this._total.Name = "_total";
            this._total.ReadOnly = true;
            // 
            // _discount
            // 
            resources.ApplyResources(this._discount, "_discount");
            this._discount.Name = "_discount";
            this._discount.ReadOnly = true;
            // 
            // _netvalue
            // 
            resources.ApplyResources(this._netvalue, "_netvalue");
            this._netvalue.Name = "_netvalue";
            this._netvalue.ReadOnly = true;
            // 
            // _vatratio
            // 
            resources.ApplyResources(this._vatratio, "_vatratio");
            this._vatratio.Name = "_vatratio";
            this._vatratio.ReadOnly = true;
            // 
            // _vat
            // 
            resources.ApplyResources(this._vat, "_vat");
            this._vat.Name = "_vat";
            this._vat.ReadOnly = true;
            // 
            // _balance
            // 
            resources.ApplyResources(this._balance, "_balance");
            this._balance.Name = "_balance";
            this._balance.ReadOnly = true;
            // 
            // _cost
            // 
            resources.ApplyResources(this._cost, "_cost");
            this._cost.Name = "_cost";
            this._cost.ReadOnly = true;
            // 
            // _kmcode
            // 
            resources.ApplyResources(this._kmcode, "_kmcode");
            this._kmcode.Name = "_kmcode";
            this._kmcode.ReadOnly = true;
            // 
            // _kmacc
            // 
            resources.ApplyResources(this._kmacc, "_kmacc");
            this._kmacc.Name = "_kmacc";
            this._kmacc.ReadOnly = true;
            // 
            // unitCode
            // 
            resources.ApplyResources(this.unitCode, "unitCode");
            this.unitCode.Name = "unitCode";
            this.unitCode.ReadOnly = true;
            // 
            // addDiscount
            // 
            resources.ApplyResources(this.addDiscount, "addDiscount");
            this.addDiscount.Name = "addDiscount";
            this.addDiscount.ReadOnly = true;
            // 
            // btnAddRow
            // 
            resources.ApplyResources(this.btnAddRow, "btnAddRow");
            this.btnAddRow.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddRow.Appearance.Options.UseBackColor = true;
            this.btnAddRow.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddRow.ImageOptions.SvgImage")));
            this.btnAddRow.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // txtAccKMCode
            // 
            resources.ApplyResources(this.txtAccKMCode, "txtAccKMCode");
            this.txtAccKMCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccKMCode.Name = "txtAccKMCode";
            this.txtAccKMCode.TextChanged += new System.EventHandler(this.txtAccKMCode_TextChanged);
            // 
            // VatType
            // 
            resources.ApplyResources(this.VatType, "VatType");
            this.VatType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VatType.Name = "VatType";
            this.VatType.TextChanged += new System.EventHandler(this.VatType_TextChanged);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Name = "label19";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Name = "label20";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Name = "label22";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Name = "label23";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Name = "label24";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Name = "label25";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.Name = "label26";
            // 
            // inv_countItems
            // 
            resources.ApplyResources(this.inv_countItems, "inv_countItems");
            this.inv_countItems.BackColor = System.Drawing.SystemColors.Window;
            this.inv_countItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_countItems.Name = "inv_countItems";
            this.inv_countItems.ReadOnly = true;
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label27.Name = "label27";
            // 
            // ch1
            // 
            resources.ApplyResources(this.ch1, "ch1");
            this.ch1.BackColor = System.Drawing.Color.Yellow;
            this.ch1.Name = "ch1";
            this.ch1.UseVisualStyleBackColor = false;
            // 
            // ch2
            // 
            resources.ApplyResources(this.ch2, "ch2");
            this.ch2.BackColor = System.Drawing.Color.PaleGreen;
            this.ch2.Name = "ch2";
            this.ch2.UseVisualStyleBackColor = false;
            // 
            // txtCost
            // 
            resources.ApplyResources(this.txtCost, "txtCost");
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCost.DicemalDigits = 0;
            this.txtCost.Name = "txtCost";
            this.txtCost.ProgramDigits = false;
            this.txtCost.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtBalance
            // 
            resources.ApplyResources(this.txtBalance, "txtBalance");
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBalance.DicemalDigits = 0;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ProgramDigits = false;
            this.txtBalance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtVat
            // 
            resources.ApplyResources(this.txtVat, "txtVat");
            this.txtVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVat.DicemalDigits = 0;
            this.txtVat.Name = "txtVat";
            this.txtVat.ProgramDigits = false;
            this.txtVat.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // inv_vatAddDiscount
            // 
            resources.ApplyResources(this.inv_vatAddDiscount, "inv_vatAddDiscount");
            this.inv_vatAddDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_vatAddDiscount.DicemalDigits = 3;
            this.inv_vatAddDiscount.Name = "inv_vatAddDiscount";
            this.inv_vatAddDiscount.ProgramDigits = false;
            this.inv_vatAddDiscount.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // inv_netAddDiscount
            // 
            resources.ApplyResources(this.inv_netAddDiscount, "inv_netAddDiscount");
            this.inv_netAddDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_netAddDiscount.DicemalDigits = 3;
            this.inv_netAddDiscount.Name = "inv_netAddDiscount";
            this.inv_netAddDiscount.ProgramDigits = false;
            this.inv_netAddDiscount.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // inv_discRate
            // 
            resources.ApplyResources(this.inv_discRate, "inv_discRate");
            this.inv_discRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_discRate.DicemalDigits = 3;
            this.inv_discRate.Name = "inv_discRate";
            this.inv_discRate.ProgramDigits = false;
            this.inv_discRate.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            this.inv_discRate.TextChanged += new System.EventHandler(this.inv_discRate_TextChanged);
            // 
            // inv_totalQty
            // 
            resources.ApplyResources(this.inv_totalQty, "inv_totalQty");
            this.inv_totalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_totalQty.DicemalDigits = 0;
            this.inv_totalQty.Name = "inv_totalQty";
            this.inv_totalQty.ProgramDigits = false;
            this.inv_totalQty.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // inv_totalWeight
            // 
            resources.ApplyResources(this.inv_totalWeight, "inv_totalWeight");
            this.inv_totalWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_totalWeight.DicemalDigits = 3;
            this.inv_totalWeight.Name = "inv_totalWeight";
            this.inv_totalWeight.ProgramDigits = false;
            this.inv_totalWeight.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // inv_Total
            // 
            resources.ApplyResources(this.inv_Total, "inv_Total");
            this.inv_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_Total.DicemalDigits = 3;
            this.inv_Total.Name = "inv_Total";
            this.inv_Total.ProgramDigits = false;
            this.inv_Total.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // inv_totalBeforVat
            // 
            resources.ApplyResources(this.inv_totalBeforVat, "inv_totalBeforVat");
            this.inv_totalBeforVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_totalBeforVat.DicemalDigits = 3;
            this.inv_totalBeforVat.Name = "inv_totalBeforVat";
            this.inv_totalBeforVat.ProgramDigits = false;
            this.inv_totalBeforVat.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // inv_netValue
            // 
            resources.ApplyResources(this.inv_netValue, "inv_netValue");
            this.inv_netValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_netValue.DicemalDigits = 3;
            this.inv_netValue.Name = "inv_netValue";
            this.inv_netValue.ProgramDigits = false;
            this.inv_netValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // inv_itemsDiscount
            // 
            resources.ApplyResources(this.inv_itemsDiscount, "inv_itemsDiscount");
            this.inv_itemsDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_itemsDiscount.DicemalDigits = 3;
            this.inv_itemsDiscount.Name = "inv_itemsDiscount";
            this.inv_itemsDiscount.ProgramDigits = false;
            this.inv_itemsDiscount.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // inv_totalVAT
            // 
            resources.ApplyResources(this.inv_totalVAT, "inv_totalVAT");
            this.inv_totalVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_totalVAT.DicemalDigits = 3;
            this.inv_totalVAT.Name = "inv_totalVAT";
            this.inv_totalVAT.ProgramDigits = false;
            this.inv_totalVAT.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // inv_addDiscount
            // 
            resources.ApplyResources(this.inv_addDiscount, "inv_addDiscount");
            this.inv_addDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv_addDiscount.DicemalDigits = 3;
            this.inv_addDiscount.Name = "inv_addDiscount";
            this.inv_addDiscount.ProgramDigits = false;
            this.inv_addDiscount.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            this.inv_addDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inv_addDiscount_KeyUp);
            // 
            // txtTonPrice
            // 
            resources.ApplyResources(this.txtTonPrice, "txtTonPrice");
            this.txtTonPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTonPrice.DicemalDigits = 0;
            this.txtTonPrice.Name = "txtTonPrice";
            this.txtTonPrice.ProgramDigits = false;
            this.txtTonPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTonPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTonPrice_KeyDown);
            this.txtTonPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTonPrice_KeyUp_1);
            // 
            // txtNetValue
            // 
            resources.ApplyResources(this.txtNetValue, "txtNetValue");
            this.txtNetValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetValue.DicemalDigits = 0;
            this.txtNetValue.Name = "txtNetValue";
            this.txtNetValue.ProgramDigits = false;
            this.txtNetValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtVatRatio
            // 
            resources.ApplyResources(this.txtVatRatio, "txtVatRatio");
            this.txtVatRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVatRatio.DicemalDigits = 0;
            this.txtVatRatio.Name = "txtVatRatio";
            this.txtVatRatio.ProgramDigits = false;
            this.txtVatRatio.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtVatRatio.TextChanged += new System.EventHandler(this.txtVatRatio_TextChanged);
            // 
            // txtDiscount
            // 
            resources.ApplyResources(this.txtDiscount, "txtDiscount");
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.DicemalDigits = 0;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ProgramDigits = false;
            this.txtDiscount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyUp);
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.DicemalDigits = 2;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ProgramDigits = false;
            this.txtTotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.DicemalDigits = 1;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ProgramDigits = false;
            this.txtPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            this.txtPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyUp);
            // 
            // txtTotalWeight
            // 
            resources.ApplyResources(this.txtTotalWeight, "txtTotalWeight");
            this.txtTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalWeight.DicemalDigits = 1;
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.ProgramDigits = false;
            this.txtTotalWeight.Value = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            // 
            // txtQty
            // 
            resources.ApplyResources(this.txtQty, "txtQty");
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.DicemalDigits = 1;
            this.txtQty.Name = "txtQty";
            this.txtQty.ProgramDigits = false;
            this.txtQty.Value = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            // 
            // txtWeight
            // 
            resources.ApplyResources(this.txtWeight, "txtWeight");
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.DicemalDigits = 3;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ProgramDigits = false;
            this.txtWeight.Value = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            this.txtWeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWeight_KeyUp);
            // 
            // txtItem
            // 
            resources.ApplyResources(this.txtItem, "txtItem");
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem.Name = "txtItem";
            this.txtItem.Load += new System.EventHandler(this.txtItem_Load);
            this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
            this.txtItem.Leave += new System.EventHandler(this.txtItem_Leave);
            // 
            // GridInvoice
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.inv_vatAddDiscount);
            this.Controls.Add(this.inv_netAddDiscount);
            this.Controls.Add(this.inv_discRate);
            this.Controls.Add(this.inv_totalQty);
            this.Controls.Add(this.inv_totalWeight);
            this.Controls.Add(this.inv_Total);
            this.Controls.Add(this.inv_totalBeforVat);
            this.Controls.Add(this.inv_netValue);
            this.Controls.Add(this.inv_itemsDiscount);
            this.Controls.Add(this.inv_totalVAT);
            this.Controls.Add(this.inv_addDiscount);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.inv_countItems);
            this.Controls.Add(this.txtTonPrice);
            this.Controls.Add(this.txtNetValue);
            this.Controls.Add(this.txtVatRatio);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTotalWeight);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKmAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKmCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.VatType);
            this.Controls.Add(this.txtAccKMCode);
            this.Name = "GridInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKmCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox txtUnit;
        private DevExpress.XtraEditors.SimpleButton btnAddRow;
        private UC_Items txtItem;
        private decimalText txtWeight;
        private decimalText txtQty;
        private decimalText txtTotalWeight;
        private decimalText txtPrice;
        private decimalText txtTotal;
        private decimalText txtDiscount;
        private decimalText txtVatRatio;
        private decimalText txtNetValue;
        private decimalText txtTonPrice;
        public System.Windows.Forms.TextBox txtKmAcc;
        public System.Windows.Forms.TextBox txtAccKMCode;
        public System.Windows.Forms.DataGridView dgv1;
        public System.Windows.Forms.TextBox VatType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox inv_countItems;
        private System.Windows.Forms.Label label27;
        private decimalText inv_discRate;
        private decimalText inv_netAddDiscount;
        private decimalText inv_vatAddDiscount;
        private System.Windows.Forms.CheckBox ch1;
        private System.Windows.Forms.CheckBox ch2;
        public decimalText inv_addDiscount;
        public decimalText inv_totalVAT;
        public decimalText inv_itemsDiscount;
        public decimalText inv_netValue;
        public decimalText inv_Total;
        public decimalText inv_totalBeforVat;
        public decimalText inv_totalQty;
        public decimalText inv_totalWeight;
        private decimalText txtVat;
        private decimalText txtCost;
        private decimalText txtBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ser;
        private System.Windows.Forms.DataGridViewTextBoxColumn _itemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn _item;
        private System.Windows.Forms.DataGridViewTextBoxColumn _description;
        private System.Windows.Forms.DataGridViewTextBoxColumn _unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn _weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn _quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _totalweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn _price;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tonprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _total;
        private System.Windows.Forms.DataGridViewTextBoxColumn _discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn _netvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn _vatratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn _vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn _balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn _cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kmcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kmacc;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDiscount;
    }
}
