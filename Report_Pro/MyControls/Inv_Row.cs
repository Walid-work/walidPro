using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class Inv_Row : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Inv_Row()
        {
            InitializeComponent();
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
           // get_desc();
        }

        private void get_desc()
        {
            try
            {
                txtUnit.Text = "";
                DataTable dt_ = dal.getDataTabl_1("SELECT item_no,descr,Descr_eng,isnull(Weight,0) as Weight,Unit,isnull(sale_price,0) as sale_price FROM wh_main_master where item_no = '" +txt_Code.Text + "' or factory_no= '" + txt_Code.Text + "' ");
                if (txt_Code.Text!="" && dt_.Rows.Count > 0)
                {
                    

                  txt_Code.Text= dt_.Rows[0]["item_no"].ToString();
                    Weight_.Value = Convert.ToDouble(dt_.Rows[0]["Weight"].ToString());

                    txtUnit.SelectedText = dt_.Rows[0]["Unit"].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        TxtDesc.Text = dt_.Rows[0]["descr"].ToString();
                    }
                    else
                    {
                        TxtDesc.Text = dt_.Rows[0]["Descr_eng"].ToString();
                    }
                    txtNote.Focus();
                }
                else
                {

                    TxtDesc.Clear();
                    Weight_.Value = 0;
                    txtUnit.Clear();
                   
                }
                clculat_amount();
        }

            catch { }
        }

    
      

        private void ID_TextChanged(object sender, EventArgs e)
        {
            //get_desc();
            //OnLoad(e);

        }

     

       

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ID_DoubleClick(object sender, EventArgs e)
        {
           //OnDoubleClick(e);
        }

        private void Inv_Row_Load(object sender, EventArgs e)
        {
            //txtUnit.DataSource = dal.getDataTabl_1("select * from wh_unit");
            //txtUnit.DisplayMember = "Wh_Unit";
            //txtUnit.ValueMember = "Wh_Unit";
            //txtUnit.SelectedIndex = -1;

        }

       

        private void ID_Leave(object sender, EventArgs e)
        {
            get_desc();
        }

        void clculat_amount()
        {
            //    try
            //    {
            txt_subTOt.Text = (qty.Text.ToDecimal() * TxtPrice.Text.ToDecimal()).ToString("N3");
            Txtvalue.Text = (txt_subTOt.Text.ToDecimal() - TxtDisc.Text.ToDecimal()).ToString("N3");

            VatValue.Text = ((VatRate.Value <= VatAccRate.Value ? VatRate.Value : VatAccRate.Value) * Txtvalue.Value).ToString("N3");
               //}
            //catch
            //{
            //    return;
            //}
        }

        void clculat_Peaces()
        {
            try
            {
                qty.Text = (Convert.ToDecimal(totWeight.Text) / Convert.ToDecimal(Weight_.Text)).ToString();
                //Txtvalue.Text = (txt_subTOt.Text.ToDecimal() - TxtDisc.Text.ToDecimal()).ToString("N" + dal.digits_);
                //VatValue.Text = (Convert.ToDecimal(Txtvalue.Text) * Convert.ToDecimal(VatRate.Text)).ToString("N" + dal.digits_);
                //totWeight.Text = (Convert.ToDecimal(qty.Text) * Convert.ToDecimal(Weight_.Text)).ToString("N3");

            }
            catch
            {
                return;
            }
        }

        private void Qty_KeyUp(object sender, KeyEventArgs e)
        {
            clculat_amount();
            totWeight.Text = (qty.Text.ToDecimal() * Weight_.Text.ToDecimal()).ToString("N3");
            OnKeyUp(e);
        }

       

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                qty.Focus();

            }
        }

        private void Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && qty.Value>0)
            {
                TxtPrice.Focus();

            }
        }

        private void txt_Code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Code.Text != "")
            {

                get_ItemData(txt_Code.Text);

            }
            else if (e.KeyCode == Keys.Enter && txt_Code.Text == "")
            {
                
                    PL.frm_search_items frm = new PL.frm_search_items();
                    frm.ShowDialog();

                if (frm.dGV_pro_list.SelectedRows.Count > 0)
                {
                    if (frm.clos_ == 1)
                    {
                        get_ItemData(frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString());
                    }
                }
               
            }

        }

        private void get_ItemData(string item_No)
        {
           
                DataTable dt = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,Weight,unit,
                BALANCE,local_cost

            ,(select top 1 vat_ratio from VAT_RATIO_MASTER where  date_of_vat <= '" + DateTime.Today.ToString("yyyy-MM-dd") + "'  order by date_of_vat desc) as VatRatio " +

                ",K.KM_Code "+
               " FROM wh_main_master as A  "+
                " inner join wh_Groups As B on A.group_code = B.group_code  "+
                " left join KM_MATERIAL_CODE As K on  ISNULL(NULLIF(a.KM_CODE, ''), 1) = K.KM_CODE "+
                 " where item_no = '" + item_No + "' or factory_no = '" + item_No + "'");
                if (dt.Rows.Count > 0)
                {
                    txt_Code.Text = dt.Rows[0][0].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        TxtDesc.Text = dt.Rows[0][2].ToString();
                    }
                    else
                    {
                        TxtDesc.Text = dt.Rows[0][3].ToString();
                    }
                    Weight_.Text = dt.Rows[0][4].ToString().ToDecimal().ToString("N3");
                    txtUnit.Text = dt.Rows[0][5].ToString();
                    txtBalance.Text = dt.Rows[0][6].ToString().ToDecimal().ToString("N0");
                    txtCost.Text = dt.Rows[0][7].ToString().ToDecimal().ToString("N3");
                    VatRate.Text = dt.Rows[0][8].ToString().ToDecimal().ToString();
                    KM_TYPE_ITEMS.Text = dt.Rows[0][9].ToString();

                    txtNote.Focus();


                }
                else
                {
                
                    PL.frm_search_items frm = new PL.frm_search_items();
                    frm.ShowDialog();
                if (frm.dGV_pro_list.SelectedRows.Count > 0)
                {
                    get_ItemData(frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString());
                }
            }
           
        }

    

        private void TxtDisc_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

       

        private void TxtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TxtPrice.Value > 0)
            {
                TxtDisc.Focus();

            }
        }

        private void TxtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (Weight_.Text.ToDecimal() > 0)
            {
                Price_ton.Text = ((TxtPrice.Text.ToDecimal() / Weight_.Text.ToDecimal()) * 1000).ToString("n0");
            }
            clculat_amount();
            OnKeyUp(e);
        }

        private void totWeight_KeyUp(object sender, KeyEventArgs e)
        {
            clculat_Peaces();
            clculat_amount();
            OnKeyUp(e);
        }

        private void Price_ton_KeyUp(object sender, KeyEventArgs e)
        {
            if (Weight_.Text.ToDecimal() > 0)
            {
                TxtPrice.Text = ((Price_ton.Text.ToDecimal() * Weight_.Text.ToDecimal()) / 1000).ToString("n3");
            }
            clculat_amount();
            OnKeyUp(e);
        }

        private void totWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && totWeight.Value > 0)
            {
                Price_ton.Focus();
            }
        }

        private void Price_ton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Price_ton.Value > 0)
            {
                TxtDisc.Focus();

            }
        }

        private void txt_Code_DoubleClick(object sender, EventArgs e)
        {
          
                PL.frm_search_items frm = new PL.frm_search_items();
                frm.ShowDialog();

                if (frm.dGV_pro_list.SelectedRows.Count>0)
                {
                    get_ItemData(frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString());
                }
          

        }

        private void Inv_Row_Enter(object sender, EventArgs e)
        {
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          OnClick(e);
           this.Dispose();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void buttonX1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
