using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class UC_ItemsCopy : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_ItemsCopy()
        {
            InitializeComponent();
        }

        private void UC_Catogry_Load(object sender, EventArgs e)
        {

        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
           // get_desc();
        }

        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT item_no,descr,Descr_eng,isnull(Weight,0) as Weight,Unit,isnull(sale_price,0) as sale_price,local_cost,UnitLenth,Unitwidth,UnitDepth " +
                    ",isnull(KM_CODE,'1') as KM_CODE,(select top 1 vat_ratio from VAT_RATIO_MASTER where  date_of_vat <= '" + DateTime.Today.ToString("yyyy-MM-dd") + "'  order by date_of_vat desc) as VatRatio " +
                    "FROM wh_main_master where item_no = '" + ID.Text + "' or factory_no= '" + ID.Text + "' ");
                if (ID.Text!="" && dt_.Rows.Count > 0)
                {
                   

                    ID.Text= dt_.Rows[0]["item_no"].ToString();
                    itemWeight.Value = Convert.ToDouble(dt_.Rows[0]["Weight"].ToString());
                    itemPrice.Value = Convert.ToDouble(dt_.Rows[0]["sale_price"].ToString());
                    itemUnit.Text = dt_.Rows[0]["Unit"].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["descr"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["Descr_eng"].ToString();
                    }
                    txtCost.Text = dt_.Rows[0]["local_cost"].ToString().ToDecimal().ToString() ;
                    txtLenth.Text = dt_.Rows[0]["UnitLenth"].ToString().ToDecimal().ToString();
                    txtWidth.Text = dt_.Rows[0]["Unitwidth"].ToString().ToDecimal().ToString();
                    txtDepth.Text = dt_.Rows[0]["UnitDepth"].ToString().ToDecimal().ToString();
                    txtItemVat.Text = dt_.Rows[0]["VatRatio"].ToString().ToDecimal().ToString("N0");
                    txtKmItem.Text = dt_.Rows[0]["KM_CODE"].ToString().ToDecimal().ToString("N0");
                }
                else
                {

                    Desc.Clear();
                    itemWeight.Value = 0;
                    itemPrice.Value = 0;
                    itemUnit.Clear();
                    txtCost.Value = 0;
                    txtLenth.Value = 0;
                    txtWidth.Value = 0;
                    txtDepth.Value = 0;
                    itemUnit.Text = "";
                    btn1.PerformClick();

                }
            }

            catch { }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            PL.frmSerachItem frm = new PL.frmSerachItem();

            frm.uc_SearchItem1.txtSrch.Text = txt_s1.Text;
            frm.uc_SearchItem1.txtsrch_1.Text = txt_s2.Text;
            frm.uc_SearchItem1.txtserch_2.Text = txt_s3.Text;
            frm.uc_SearchItem1.txtSrch_3.Text = txt_s4.Text;
            frm.uc_SearchItem1.txtserch_4.Text = txt_s5.Text;





            frm.ShowDialog();

            // if (Properties.Settings.Default.lungh == "0")
            //  {

            //      frm.Location = new Point(x - frm.Width, y);
            //  }
            //  else
            //  {
            //      frm.Location = new Point(x, y);
            //  }
            ////  frm.branch_search = branchID.Text;
            //  frm.ShowDialog();
            if (frm.clos_ == 1)
            {

                ID.Text = frm.uc_SearchItem1.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                if (frm.uc_SearchItem1.ch_SaveSearch.Checked)
                {
                    txt_s1.Text = frm.uc_SearchItem1.txtSrch.Text;
                    txt_s2.Text = frm.uc_SearchItem1.txtsrch_1.Text;
                    txt_s3.Text = frm.uc_SearchItem1.txtserch_2.Text;
                    txt_s4.Text = frm.uc_SearchItem1.txtSrch_3.Text;
                    txt_s5.Text = frm.uc_SearchItem1.txtserch_4.Text;
                }
                else
                {
                    txt_s1.Clear();
                    txt_s2.Clear();
                    txt_s3.Clear();
                    txt_s4.Clear();
                    txt_s5.Clear();
                }
            }
            ID.Focus();



            //uc_SearchItem1.Visible = true;
            //uc_SearchItem1.Dock = DockStyle.Fill;
            //this.Dock = DockStyle.Fill;
            //this.BringToFront();

            //  OnClick(e);

        }









        private void ID_TextChanged(object sender, EventArgs e)
        {
          //  get_desc();
            
            OnLoad(e);

        }

     

       

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                get_desc();
                OnKeyDown(e);
            }
             
        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void uc_SearchItem1_Load(object sender, EventArgs e)
        {
            
        }

        private void uc_SearchItem1_DoubleClick(object sender, EventArgs e)
        {

            if (uc_SearchItem1.dGV_pro_list.SelectedRows.Count > 0)
            {
                if (uc_SearchItem1.ch_SaveSearch.Checked == true)
                {
                    ID.Text = uc_SearchItem1.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();

                }
                else
                {
                    ID.Text = uc_SearchItem1.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                    dal.ClearTextBoxes_uc(uc_SearchItem1);

                }
                uc_SearchItem1.Visible = false;


                if (Properties.Settings.Default.lungh == "0")
                {
                    this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                }
                else
                {
                    this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                }
                this.Dock = DockStyle.None;
            }
        }

        private void uc_SearchItem1_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.lungh == "0")
            {
                this.Parent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            }
            else
            {
                this.Parent.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }
            this.Dock = DockStyle.None;
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            if (ID.Text.Trim() != string.Empty)
            {
            get_desc();
            }
                          
        }
    }
}
