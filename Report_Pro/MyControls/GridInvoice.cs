using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class GridInvoice : UserControl
    {
        string btntype = "0";
        Int32 m;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        public GridInvoice()
        {
            InitializeComponent();

            txtTotal._digit = dal.digits_;
            txtDiscount._digit = dal.digits_;
            txtPrice._digit = dal.digits_;

            inv_itemsDiscount._digit = dal.digits_;
            inv_addDiscount._digit = dal.digits_;
            inv_Total._digit = dal.digits_;
            inv_totalBeforVat._digit = dal.digits_;
            inv_totalVAT._digit = dal.digits_;
            inv_netValue._digit = dal.digits_;

            txtUnit.DataSource = dal.getDataTabl_1("SELECT Wh_Unit,unit_Description,unit_Description_E FROM Wh_Unit");
            
            txtUnit.ValueMember = "Wh_Unit";
            if (Properties.Settings.Default.lungh == "0")
            {
            txtUnit.DisplayMember = "unit_Description";
            }
            else
            {
                txtUnit.DisplayMember = "unit_Description_E";
            }
      
            txtUnit.SelectedIndex = -1;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void addrow_new()
        {
            DataGridViewRow r = (DataGridViewRow)dgv1.RowTemplate.Clone();
            r.CreateCells(dgv1);

            //r.Cells[0].Value = mapping.Key;
            //r.Cells[1].Value = ((BusinessObject)mapping.Value).Name;
            //r.Cells[1].Tag = mapping.Value;

            

           // DataGridViewRow  r = dataGridView1.NewRow(1);
            r.Cells[1].Value  = txtItem.ID.Text;
            r.Cells[2].Value  = txtItem.Desc.Text;
            r.Cells[3].Value  = txtDescription.Text;
            r.Cells[4].Value  = txtUnit.Text;
            r.Cells[5].Value  = txtWeight.Text.ToDecimal().ToString("N3");
            r.Cells[6].Value  = txtQty.Text.ToDecimal().ToString("N0");
            r.Cells[7].Value  = txtTotalWeight.Text.ToDecimal().ToString("N3");
            r.Cells[8].Value  = txtPrice.Text.ToDecimal().ToString("N" + dal.digits_);
            r.Cells[9].Value  = txtTonPrice.Text.ToDecimal().ToString("N0"); 
            r.Cells[10].Value = txtTotal.Text.ToDecimal().ToString("N" + dal.digits_);
            r.Cells[11].Value = txtDiscount.Text.ToDecimal().ToString("N" + dal.digits_);
            r.Cells[12].Value = txtNetValue.Text.ToDecimal().ToString("N" + dal.digits_);
            r.Cells[13].Value = txtVatRatio.Text.ToDecimal().ToString("n0");
            r.Cells[14].Value = txtVat.Text.ToDecimal().ToString("N" + dal.digits_);
            r.Cells[15].Value = txtBalance.Text.ToDecimal().ToString("N0");
            r.Cells[16].Value = txtCost.Text.ToDecimal().ToString("N" + dal.digits_);
            r.Cells[17].Value = txtKmCode.Text.ToDecimal();
            r.Cells[18].Value = txtKmAcc.Text.ToDecimal();
            r.Cells[19].Value = txtUnit.SelectedValue;
            dgv1.Rows.Add(r);
            cleartextbooks();
            txtItem.ID.Focus();
            total_inv();
            
        }

        void editrow()
        {
           
            dgv1.Rows[m].Cells[1].Value  = txtItem.ID.Text;
            dgv1.Rows[m].Cells[2].Value  = txtItem.Desc.Text;
            dgv1.Rows[m].Cells[3].Value  = txtDescription.Text;
            dgv1.Rows[m].Cells[4].Value  = txtUnit.Text;
            dgv1.Rows[m].Cells[5].Value  = txtWeight.Text.ToDecimal().ToString("N3");
            dgv1.Rows[m].Cells[6].Value  = txtQty.Text.ToDecimal().ToString("N0");
            dgv1.Rows[m].Cells[7].Value  = txtTotalWeight.Text.ToDecimal().ToString("N3");
            dgv1.Rows[m].Cells[8].Value  = txtPrice.Text.ToDecimal().ToString("N" + dal.digits_);
            dgv1.Rows[m].Cells[9].Value  = txtTonPrice.Text.ToDecimal().ToString("N0"); 
            dgv1.Rows[m].Cells[10].Value = txtTotal.Text.ToDecimal().ToString("N" + dal.digits_);
            dgv1.Rows[m].Cells[11].Value = txtDiscount.Text.ToDecimal().ToString("N" + dal.digits_);
            dgv1.Rows[m].Cells[12].Value = txtNetValue.Text.ToDecimal().ToString("N" + dal.digits_);
            dgv1.Rows[m].Cells[13].Value = txtVatRatio.Text.ToDecimal().ToString("n0");
            dgv1.Rows[m].Cells[14].Value = txtVat.Text.ToDecimal().ToString("N" + dal.digits_);
            dgv1.Rows[m].Cells[15].Value = txtBalance.Text.ToDecimal().ToString("N0");
            dgv1.Rows[m].Cells[16].Value = txtCost.Text.ToDecimal().ToString("N" + dal.digits_);
            dgv1.Rows[m].Cells[17].Value = txtKmCode.Text.ToDecimal();
            dgv1.Rows[m].Cells[18].Value = txtKmAcc.Text.ToDecimal();
            dgv1.Rows[m].Cells[19].Value = txtUnit.SelectedValue;



            cleartextbooks();
            txtItem.ID.Focus();
            total_inv();

        }

        private void cleartextbooks()
        {
            txtItem.ID.Clear();
            txtItem.Desc.Clear();
            txtDescription.Clear();
            txtUnit.SelectedIndex = -1;
            txtWeight.Clear();
            txtQty.Clear();
            txtTotalWeight.Clear();
            txtPrice.Clear();
            txtTonPrice.Clear();
            txtTotal.Clear();
            txtDiscount.Clear();
            txtNetValue.Clear();
            txtVatRatio.Clear();
            txtVat.Clear();
            txtBalance.Clear();
            txtCost.Clear();
            txtKmCode.Clear();
            txtKmAcc.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

      

        private void txtWeight_KeyUp(object sender, KeyEventArgs e)
        {
            totalRow();
            tonPrice();
           // txtTotalWeight.Text = (txtQty.Value * txtWeight.Value).ToString("N3");
        }

        private void txtItem_Load(object sender, EventArgs e)
        {
            totalRow();
        }

        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
                txtPrice.Text = txtItem.itemPrice.Value.ToString();
                txtCost.Text = txtItem.txtCost.Value.ToString();
                txtWeight.Text = txtItem.itemWeight.Value.ToString();
                txtUnit.SelectedValue = txtItem.itemUnit.Text;
                txtKmCode.Text = txtItem.txtKmItem.Value.ToString("N0");
                if (VatType.Text=="1" && txtAccKMCode.Text == "1" && txtKmCode.Text == "1")
                {
                txtVatRatio.Text = txtItem.txtItemVat.Value.ToString("N0");
                }
                else
                {
                    txtVatRatio.Text = 0.ToString("n0");

                }
                txtKmCode.Text = txtItem.txtKmItem.Value.ToString("N0");
                totalRow();
            }
           
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQty.Value >0)
            {
                txtPrice.Focus();
            }

        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Value > 0)
            {
                txtDiscount.Focus();
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            totalRow();
            


            if (ch1.Checked == false)
            {
                if (txtPrice.Value <= 0)
                {
                    MessageBox.Show("تأكد من السعر", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (btntype == "0")
            {
                if (ch2.Checked == false)
                {
                    for (int i = 0; i <= dgv1.Rows.Count - 1; i++)
                    {
                        if (dgv1.Rows[i].Cells[1].Value.ToString() == txtItem.ID.Text)
                        {
                            MessageBox.Show("هذا الصنف مضاف من قبل", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
                addrow_new();
                btntype = "0";


            }
            else if (btntype == "1")
            {
                editrow();
                btntype = "0";

            }
            ch1.Checked=false;


            foreach (DataGridViewRow row in this.dgv1.Rows)
            {
                row.Cells[0].Value = string.Format("{0}", row.Index + 1);
               // dgv1.EnableHeadersVisualStyles = false;


            }




        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Value > 0)
            {
                btnAddRow.Focus();
            }
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            totalRow();
        }

        private void totalRow()
        {
            txtTotalWeight.Text = (txtQty.Value * txtWeight.Value).ToString("N3");
            txtTotal.Text = (txtQty.Value * txtPrice.Value).ToString("N" + dal.digits_);
            txtNetValue.Text = (txtTotal.Value - txtDiscount.Value).ToString("N" + dal.digits_);
            txtVat.Text = (txtNetValue.Value * txtVatRatio.Value / 100).ToString("N" + dal.digits_);
        }


        private void tonPrice()
        {
            if (txtWeight.Value > 0)
            {
                txtTonPrice.Text = (txtPrice.Value / txtWeight.Value * 1000).ToString("N0");
            }
            else
            {
                txtTonPrice.Text = "0".ToDecimal().ToString("N0");
            }
            
        }

        private void UnitPrice()
        {
            if (txtWeight.Value > 0)
            {
                txtPrice.Text = (txtTonPrice.Value * txtWeight.Value / 1000).ToString("N"+dal.digits_);
            }
            else
            {
                txtTonPrice.Text = "0".ToDecimal().ToString("N0");
            }
           
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            totalRow();
        }

        private void txtTonPrice_KeyUp(object sender, KeyEventArgs e)
        {
            totalRow();
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            tonPrice();
            totalRow();
        }

        private void txtTonPrice_KeyUp_1(object sender, KeyEventArgs e)
        {
            UnitPrice();
            totalRow();
        }

        private void txtVatRatio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void updateVateRatio()
        {
          DataTable dt_VATRatio=  dal.getDataTabl_1("select top 1 vat_ratio from VAT_RATIO_MASTER where date_of_vat <= '" + DateTime.Today.ToString("yyyy-MM-dd") + "'  order by date_of_vat desc") ;
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                
                if (txtAccKMCode.Text == "1" && VatType.Text == "1")
                {
                    row.Cells[13].Value = dt_VATRatio.Rows[0][0].ToString().ToDecimal().ToString("n0");
                    row.Cells[20].Value = inv_discRate.Value/ (1+(row.Cells[13].Value.ToString().ToDecimal())/100) * row.Cells[12].Value.ToString().ToDecimal() ;
                }
                else
                {
                    row.Cells[13].Value = 0.ToString("n0");
                    row.Cells[20].Value = inv_discRate.Value.ToString().ToDecimal()* row.Cells[12].Value.ToString().ToDecimal();
                }
                row.Cells[18].Value = txtAccKMCode.Text;
                row.Cells[14].Value =  (row.Cells[13].Value.ToString().ToDecimal()/100 * row.Cells[12].Value.ToString().ToDecimal()).ToString("N" + dal.digits_);

            }
            total_inv();
        }


        private void txtAccKMCode_TextChanged(object sender, EventArgs e)
        {

            updateVateRatio();
        }

        private void VatType_TextChanged(object sender, EventArgs e)
        {
            updateVateRatio();
        }

        private void txtTonPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiscount.Focus();
            }
        }



        public void total_inv()
        {

            inv_totalQty.Text =
               (from DataGridViewRow row in dgv1.Rows
                where row.Cells[6].FormattedValue.ToString() != string.Empty
                select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

            inv_totalWeight.Text =
                (from DataGridViewRow row in dgv1.Rows
                 where row.Cells[7].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();

            inv_itemsDiscount.Text =
             (from DataGridViewRow row in dgv1.Rows
              where row.Cells[11].FormattedValue.ToString() != string.Empty
              select Convert.ToDouble(row.Cells[11].FormattedValue)).Sum().ToString("N" + dal.digits_);

            inv_netAddDiscount.Text =
               (from DataGridViewRow row in dgv1.Rows
                where row.Cells[20].FormattedValue.ToString() != string.Empty
                select Convert.ToDouble(row.Cells[20].FormattedValue)).Sum().ToString("N" + dal.digits_);

            inv_vatAddDiscount.Text = (inv_addDiscount.Value - inv_netAddDiscount.Value).ToString();

            inv_Total.Text =
           (from DataGridViewRow row in dgv1.Rows
             where row.Cells[12].FormattedValue.ToString() != string.Empty
             select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString().ToDecimal().ToString("N" + dal.digits_);


            if (inv_Total.Value > 0)
            {
                inv_discRate.Text = (inv_addDiscount.Value / inv_Total.Value).ToString();

            }


            inv_totalBeforVat.Text = (inv_Total.Text.ToDecimal() - inv_netAddDiscount.Value).ToString("N" + dal.digits_);


            inv_totalVAT.Text =
                ((from DataGridViewRow row in dgv1.Rows
                 where row.Cells[14].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[14].FormattedValue)).Sum().ToString().ToDecimal()-inv_vatAddDiscount.Value).ToString("N" + dal.digits_);

           inv_netValue.Text = ( inv_totalBeforVat.Value + inv_totalVAT.Value).ToString("N" + dal.digits_);

            inv_countItems.Text =
                (from DataGridViewRow row in dgv1.Rows
                 where row.Cells[1].FormattedValue.ToString() != string.Empty
                 select (row.Cells[1].FormattedValue)).Count().ToString("N0");

        }


        private void inv_addDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            if (inv_Total.Value > 0)
            {
                inv_discRate.Text = (inv_addDiscount.Value / inv_Total.Value).ToString();

            }
            updateVateRatio();

        }

        private void inv_discRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btntype = "1";
            m = dgv1.CurrentRow.Index;
            //try
            //{
            //DataTable itemdata_ = dal.getDataTabl("get_product_name", dGV_Item.CurrentRow.Cells[0].Value.ToString(), Properties.Settings.Default.CoId);
            txtItem.ID.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
            txtItem.Desc.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            txtUnit.SelectedValue = dgv1.CurrentRow.Cells[19].Value.ToString();
            txtWeight.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
            txtQty.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
            txtTotalWeight.Text = dgv1.CurrentRow.Cells[7].Value.ToString();
            txtPrice.Text = dgv1.CurrentRow.Cells[8].Value.ToString();
            txtTonPrice.Text = dgv1.CurrentRow.Cells[9].Value.ToString();
            txtTotal.Text = dgv1.CurrentRow.Cells[10].Value.ToString();
            txtDiscount.Text = dgv1.CurrentRow.Cells[11].Value.ToString();
            txtNetValue.Text = dgv1.CurrentRow.Cells[12].Value.ToString();
            txtVatRatio.Text = dgv1.CurrentRow.Cells[13].Value.ToString();
            txtVat.Text = dgv1.CurrentRow.Cells[14].ToString().ToDecimal().ToString("N"+dal.digits_);
            txtBalance.Text = dgv1.CurrentRow.Cells[15].ToString().ToDecimal().ToString("N0");
            txtCost.Text = dgv1.CurrentRow.Cells[16].ToString().ToDecimal().ToString("N" + dal.digits_);
            txtKmCode.Text = dgv1.CurrentRow.Cells[17].ToString();
            txtKmAcc.Text = dgv1.CurrentRow.Cells[18].ToString();
                                                                              
        }

        private void txtItem_Leave(object sender, EventArgs e)
        {
           
            txtPrice.Text = txtItem.itemPrice.Value.ToString();
            txtCost.Text = txtItem.txtCost.Value.ToString();
            txtWeight.Text = txtItem.itemWeight.Value.ToString();
            txtUnit.SelectedValue = txtItem.itemUnit.Text;
            if (txtAccKMCode.Text == "1" && VatType.Text == "1")
            {
                txtVatRatio.Text = txtItem.txtItemVat.Value.ToString("N0");
            }
            else
            {
                txtVatRatio.Text = 0.ToString("n0");

            }
            txtKmCode.Text = txtItem.txtKmItem.Value.ToString("N0");
            totalRow();

        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }
    }
}
