using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;
using Report_Pro.Classes;

namespace Report_Pro.PL
{
    public partial class frm_search_items : Form

    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public int clos_;
        DataTable dt = new DataTable();
        public frm_search_items()
        {
            InitializeComponent();

          
            //search_product();

        }

        private void frm_search_items_Load(object sender, EventArgs e)
        {
            txtSrch.Text   = Session.itemSearch1   ;
            txtsrch_1.Text =    Session.itemSearch2;
            txtserch_2.Text=    Session.itemSearch3;
            txtSrch_3.Text =    Session.itemSearch4;
            txtserch_4.Text = Session.itemSearch5;

            dt = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,Weight,Group_name,unit,BALANCE
            FROM wh_main_master as A
            inner join wh_Groups as B
            on A.group_code = B.group_code");


            dGV_pro_list.DataSource = dt;
            resizeDG();


            search_product();


        }

        private void search_product()
        {
            string strBalance = radiobalance.Checked ? "1" : "2";
            //dGV_pro_list.DataSource = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,Weight,Group_name,unit,BALANCE
            //FROM wh_main_master as A
            //inner join wh_Groups as B
            //on A.group_code = B.group_code
            //where BALANCE <> case when '" + strBalance + "'= 1  then  0 else 1000000000  end and " +
            //" descr + Descr_eng + Group_name like '%" + txtsrch_1.Text
            //+ "%' and descr + Descr_eng + Group_name like  '%" + txtserch_2.Text
            //+ "%' and descr + Descr_eng + Group_name like '%" + txtSrch_3.Text
            //+ "%' and descr + Descr_eng + Group_name like '%" + txtserch_4.Text
            //+ "%' and ( item_no like '" + txtSrch.Text + "%' or factory_no like '" + txtSrch.Text + "%')");
            ////, txtSrch.Text, txtsrch_1.Text, txtserch_2.Text, txtSrch_3.Text,txtserch_4.Text, (radiobalance.Checked ? "1" : "2"),dal.db1);
            //resizeDG();


            try
            {
                dt.DefaultView.RowFilter = "descr + Descr_eng Like '%" + txtsrch_1.Text.Trim() + "%' and descr + Descr_eng  Like '%" + txtserch_2.Text +
                          "%' and descr + Descr_eng  Like '%" + txtSrch_3.Text.Trim() + "%' and descr +Descr_eng  Like '%" + txtserch_4.Text +
                          "%' and ( item_no like '" + txtSrch.Text + "%' or factory_no like '" + txtSrch.Text + "%')";

            }
            catch
            {


            }



            resizeDG();


        }
        void resizeDG()
        {
            this.dGV_pro_list.Columns[0].Width = 100;
            this.dGV_pro_list.Columns[1].Width = 300;
            this.dGV_pro_list.Columns[2].Width = 300;
            this.dGV_pro_list.Columns[3].Width = 90;
            this.dGV_pro_list.Columns[4].Width = 90;
        }

        private void dGV_pro_list_DoubleClick(object sender, EventArgs e)
        {
            clos_ = 1;
            if (chSaveSearchData.Checked == true)
            {
                Session.itemSearch1 = txtSrch.Text;
                Session.itemSearch2 = txtsrch_1.Text;
                Session.itemSearch3 = txtserch_2.Text;
                Session.itemSearch4 = txtSrch_3.Text;
                Session.itemSearch5 = txtserch_4.Text;
            }
            else
            {
                Session.itemSearch1 = "";
                Session.itemSearch2 = "";
                Session.itemSearch3 = "";
                Session.itemSearch4 = "";
                Session.itemSearch5 = "";
            }
            Close();
        }

        private void dGV_pro_list_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    this.Close();
            //}
        }

        private void dGV_pro_list_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    e.Handled = true;
            //}
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            search_product();
        }

        private void txtSrch_3_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }

       

        private void txtSrch_3_TextChanged(object sender, EventArgs e)
        {
            search_product();

        }

        private void txtsrch_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtsrch_1.Text.Trim()!="")
            {
                txtserch_2.Focus();
            }
        }

        private void txtserch_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtserch_2.Text.Trim() != "")
            {
                txtSrch_3.Focus();
            }
        }

        private void txtSrch_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtSrch_3.Text.Trim() != "")
            {
                txtserch_4.Focus();
            }
        }

        private void txtserch_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtserch_4.Text.Trim() != "")
            {
                txtsrch_1.Focus();
            }

        }

        private void txtserch_4_TextChanged(object sender, EventArgs e)
        {
           search_product();
        }

        private void btnSrch_Click_1(object sender, EventArgs e)
        {
            search_product();
        }

        
      

        private void txtsrch_1_TextChanged(object sender, EventArgs e)
        {
            search_product();
        }

        private void txtSrch_TextChanged(object sender, EventArgs e)
        {
            search_product();
        }

        private void txtserch_2_TextChanged(object sender, EventArgs e)
        {
            search_product();
        }

        private void txtSrch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtSrch.Text.Trim() != "")
            {
                txtsrch_1.Focus();
            }
        }
    }
}
