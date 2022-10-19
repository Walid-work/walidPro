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
    public partial class Uc_SearchItem : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();

        string strBalance = "2";

        public Uc_SearchItem()
        {
           
            
            InitializeComponent();

            if (radiobalance.Checked)
            {
                strBalance = "1";
            }
            else
            {
                strBalance = "2";
            }

            dt = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,BALANCE,Weight,Group_name,unit
            FROM wh_main_master as A
            inner join wh_Groups as B
            on A.group_code = B.group_code
            where BALANCE > (CASE WHEN '" + strBalance + "'= 1 then 0 else '"+int.MinValue+"' end)");
            dGV_pro_list.DataSource = dt;
            
        }


        private void search_product()
        {
            
            if (dGV_pro_list.Columns.Count == 0)
            {

                dGV_pro_list.DataSource = dt;
            }

            //try
            //{
                dt.DefaultView.RowFilter = "descr + Descr_eng Like '%" + txtsrch_1.Text.Trim() + "%' and descr + Descr_eng  Like '%" + txtserch_2.Text +
                          "%' and descr + Descr_eng  Like '%" + txtSrch_3.Text.Trim() + "%' and descr +Descr_eng  Like '%" + txtserch_4.Text +
                          "%' and ( item_no like '" + txtSrch.Text + "%' or factory_no like '" + txtSrch.Text +"%')";
              

            //}
            //catch
            //{

               
            //}

      

            resizeDG();
        }
        void resizeDG()
        {
            if (dal.languh_ == "0")
            {
                dGV_pro_list.Columns[0].HeaderText = "كود الصنف";
                dGV_pro_list.Columns[1].HeaderText = "الكود الاضافي";
                dGV_pro_list.Columns[2].HeaderText = "الوصف";
                dGV_pro_list.Columns[3].HeaderText = "الوصف لاتيني";
                dGV_pro_list.Columns[4].HeaderText = "الرصيد";
                dGV_pro_list.Columns[5].HeaderText = "الوزن";
                dGV_pro_list.Columns[6].HeaderText = "المجموعة";
                dGV_pro_list.Columns[7].HeaderText = "الوحدة";
                
            }
            else
            {
                dGV_pro_list.Columns[0].HeaderText = "Item No";
                dGV_pro_list.Columns[1].HeaderText = "Factory No";
                dGV_pro_list.Columns[2].HeaderText = "Description";
                dGV_pro_list.Columns[3].HeaderText = "Description English";
                dGV_pro_list.Columns[4].HeaderText = "Balance";
                dGV_pro_list.Columns[5].HeaderText = "Weight";
                dGV_pro_list.Columns[6].HeaderText = "Group";
                dGV_pro_list.Columns[7].HeaderText = "Unit";
               
            }
            dGV_pro_list.Columns[0].Width = 100;
            dGV_pro_list.Columns[1].Width = 100;
            dGV_pro_list.Columns[2].Width = 300;
            dGV_pro_list.Columns[3].Width = 300;
            dGV_pro_list.Columns[4].Width = 100;
            dGV_pro_list.Columns[5].Width = 300;
            dGV_pro_list.Columns[6].Width = 100;
            dGV_pro_list.Columns[7].Width = 100;
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
            if (ch_SaveSearch.Checked == false)
            {
                dal.ClearTextBoxes_uc(this);
            }
            Visible = false;
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
            search_product();

        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobalance.Checked)
            {
                strBalance = "1";
            }
            else
            {
                strBalance = "2";
            }

            dt = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,BALANCE,Weight,Group_name,unit
            FROM wh_main_master as A
            inner join wh_Groups as B
            on A.group_code = B.group_code
            where BALANCE > (CASE WHEN '" + strBalance + "'= 1 then 0 else '"+int.MinValue+"' end)");
            dGV_pro_list.DataSource = dt;
            search_product();
            resizeDG();

        }
    }
}
