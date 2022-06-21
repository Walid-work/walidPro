using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_Search_Item : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public int clos_;
        public frm_Search_Item()
        {
            InitializeComponent();
            search_product();
            resizeDG();
        }

        private void frm_Search_Item_Load(object sender, EventArgs e)
        {

        }
        private void search_product()
        {
            dGV_pro_list.DataSource = dal.getDataTabl("srch_product_", txtSrch.Text, txtSrch_1.Text, txtSrch_2.Text, txtSrch_3.Text);
            //            dGV_pro_list.DataSource = dal.getDataTabl_1(@"SELECT Id_Pro,factory_no,Desc_pro,Desc_pro_En,Qty_Stock,Cost_Pro,wight,desc_Cat ,
            //            unit,Product_Tbl.Branch_code,VatRate from  Product_Tbl inner join Cat_Tbl on Cat_Tbl.id_cat=Product_Tbl.id_cat 
            //            where Desc_pro like '%" + txtSrch.Text + "%' and Desc_pro_En like '%" + txtsrch_1.Text + "%' and desc_Cat like '%" + txtserch_2.Text + "%'  and id_pro like '" + txtSrch_3.Text + "%'");

        }



        void resizeDG()
        {
            this.dGV_pro_list.Columns[0].Width = 100;
            this.dGV_pro_list.Columns[1].Width = 300;
            this.dGV_pro_list.Columns[2].Width = 300;
            this.dGV_pro_list.Columns[3].Width = 90;
            this.dGV_pro_list.Columns[4].Width = 90;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            //RPT.frm_project_materails f_project = new RPT.frm_project_materails();
            //f_project.item_no.Text = dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
            //f_project.item_name.Text = dGV_pro_list.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void txtSrch_TextChanged(object sender, EventArgs e)
        {
            search_product();
        
        }

        private void txtSrch_1_TextChanged(object sender, EventArgs e)
        {
            search_product();
           
        }

        private void txtSrch_2_TextChanged(object sender, EventArgs e)
        {
            search_product();
        }

        private void txtSrch_3_TextChanged(object sender, EventArgs e)
        {
            search_product();
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            search_product();
        }
    }
}
