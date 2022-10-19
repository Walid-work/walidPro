using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Report_Pro.Classes;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Report_Pro.MyControls
{
    public partial class Uc_listItems : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();
        public Uc_listItems()
        {
            InitializeComponent();


            //dt = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,Weight,Group_name,unit,BALANCE
            //FROM wh_main_master as A
            //inner join wh_Groups as B
            //on A.group_code = B.group_code");


           // dGV_pro_list.DataSource = dt;
            resizeDG();
        }


        private void search_product()
        {
            gridControl1.DataSource = Session.ProductsView.Select(x => x.Code.StartsWith(txtSrch.Text + "%"));

            //// bs.Filter = string.Format("descr LIKE '%{0}%'", txtsrch_1.Text);

            //string strBalance = radiobalance.Checked ? "1" : "2";
            ////  dGV_pro_list.DataSource
            ////dt = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,Weight,Group_name,unit,BALANCE
            ////FROM wh_main_master as A
            ////inner join wh_Groups as B
            ////on A.group_code = B.group_code");
            ////where BALANCE <> case when '" + strBalance + "'= 1  then  0 else 1000000000  end and " +
            ////" descr + Descr_eng + Group_name like '%" + txtsrch_1.Text
            ////+ "%' and descr + Descr_eng + Group_name like  '%" + txtserch_2.Text
            ////+ "%' and descr + Descr_eng + Group_name like '%" + txtSrch_3.Text
            ////+ "%' and descr + Descr_eng + Group_name like '%" + txtserch_4.Text
            ////+ "%' and ( item_no like '" + txtSrch.Text + "%' or factory_no like '" + txtSrch.Text + "%')");
            //////, txtSrch.Text, txtsrch_1.Text, txtserch_2.Text, txtSrch_3.Text,txtserch_4.Text, (radiobalance.Checked ? "1" : "2"),dal.db1);

            ////   dt.DefaultView.RowFilter = string.Format("descr + Descr_eng + Group_name  LIKE '%{0}%'", txtsrch_1.Text + txtserch_2.Text);
            //try
            //{
            //    dt.DefaultView.RowFilter = "descr + Descr_eng Like '%" + txtsrch_1.Text.Trim() + "%' and descr + Descr_eng  Like '%" + txtserch_2.Text +
            //              "%' and descr + Descr_eng  Like '%" + txtSrch_3.Text.Trim() + "%' and descr +Descr_eng  Like '%" + txtserch_4.Text +
            //              "%' and ( item_no like '" + txtSrch.Text + "%' or factory_no like '" + txtSrch.Text + "%')";

            //}
            //catch
            //{

               
            //}

      

            resizeDG();
        }
        void resizeDG()
        {
            //if (dal.languh_ == "0")
            //{
            //    dGV_pro_list.Columns[0].HeaderText = "كود الصنف";
            //    dGV_pro_list.Columns[1].HeaderText = "الكود الاضافي";
            //    dGV_pro_list.Columns[2].HeaderText = "الوصف";
            //    dGV_pro_list.Columns[3].HeaderText = "الوصف لاتيني";
            //    dGV_pro_list.Columns[4].HeaderText = "الوزن";
            //    dGV_pro_list.Columns[5].HeaderText = "المجموعة";
            //    dGV_pro_list.Columns[6].HeaderText = "الوحدة";
            //    dGV_pro_list.Columns[7].HeaderText = "الرصيد";
            //}
            //else
            //{
            //    dGV_pro_list.Columns[0].HeaderText = "Item No";
            //    dGV_pro_list.Columns[1].HeaderText = "Factory No";
            //    dGV_pro_list.Columns[2].HeaderText = "Description";
            //    dGV_pro_list.Columns[3].HeaderText = "Description English";
            //    dGV_pro_list.Columns[4].HeaderText = "Weight";
            //    dGV_pro_list.Columns[5].HeaderText = "Group";
            //    dGV_pro_list.Columns[6].HeaderText = "Unit";
            //    dGV_pro_list.Columns[7].HeaderText = "Balance";
            //}
            //dGV_pro_list.Columns[0].Width = 100;
            //dGV_pro_list.Columns[1].Width = 100;
            //dGV_pro_list.Columns[2].Width = 300;
            //dGV_pro_list.Columns[3].Width = 300;
            //dGV_pro_list.Columns[4].Width = 100;
            //dGV_pro_list.Columns[5].Width = 300;
            //dGV_pro_list.Columns[6].Width = 100;
            //dGV_pro_list.Columns[7].Width = 100;
        }

        private void txtsrch_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtsrch_1.Text.Trim() != "")
            {
                txtserch_2.Focus();
                search_product();
            }
        }


        private void btnSrch_Click(object sender, EventArgs e)
        {
            search_product();
        }

        private void dGV_pro_list_DoubleClick(object sender, EventArgs e)
        {
                      OnDoubleClick(e);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (ch_SaveSearch.Checked == true)
            {
                this.Visible = false;
            }
            else
            {
               dal.ClearTextBoxes_uc(this);
                this.Visible = false;
            }
            OnClick(e);
        }

        private void txtserch_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtserch_2.Text.Trim() != "")
            {
                txtSrch_3.Focus();
              //  search_product();
            }

        }

        private void txtSrch_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtSrch_3.Text.Trim() != "")
            {
                txtserch_4.Focus();
                //search_product();
            }
        }

        private void txtserch_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtserch_4.Text.Trim() != "")
            {
                btnSrch.Focus();
                //search_product();
            }
        }

        private void txtSrch_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }

        private void txtserch_2_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }

        private void txtSrch_3_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }

        private void txtserch_4_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }

        private void txtsrch_1_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }

        private void txtSrch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter && txtSrch.Text.Trim() != "")
            {
                txtsrch_1.Focus();
                search_product();
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Uc_SearchItem_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            
            gridView1.DoubleClick += GridView1_DoubleClick;
            gridControl1.DataSource = Session.ProductsView.Select(x=> x.Code.StartsWith(txtSrch.Text+"%"));
            gridView1.CustomColumnDisplayText += GridView1_CustomColumnDisplayText;
            gridControl1.ViewRegistered += GridControl1_ViewRegistered;
            gridView1.OptionsDetail.ShowDetailTabs = false;
            //dt = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,Weight,Group_name,unit,BALANCE
            //FROM wh_main_master as A
            //inner join wh_Groups as B
            //on A.group_code = B.group_code");


            //dGV_pro_list.DataSource = dt;
        }

        private void GridControl1_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            if (e.View.LevelName == "UOM")
            {
                GridView view = e.View as GridView;
                view.OptionsView.ShowViewCaption = true;
                view.ViewCaption = "وحدات القياس ";
                view.Columns["UnitName"].Caption = "اسم الوحده";
                view.Columns["Factor"].Caption = "المعامل";
                view.Columns["SellPrice"].Caption = "سعر البيع";
                view.Columns["BuyPrice"].Caption = "سعر الشراء";
                view.Columns["Barcode"].Caption = "الباركود";
            }
        }

        private void GridView1_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }
    }
}
