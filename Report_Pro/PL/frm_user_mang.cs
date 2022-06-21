using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Report_Pro.PL
{
    public partial class frm_user_mang : Form
    {
        SqlConnection conn = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Properties.Settings.Default.Database + " ;integrated security=false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + "");
        //SqlDataAdapter Da;
        DataTable Dts = new DataTable();

      //  BL.Cls_login log = new BL.Cls_login();
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_user_mang()
        {
            InitializeComponent();
            list_users.DataSource = dal.getDataTabl_1("SELECT * FROM wh_USERS");
            list_users.DisplayMember = "user_name";
            list_users.ValueMember = "user_id";



            //==========
            //DataTable dt_list = dal.getDataTabl_1(@"SELECT A.list_id,B.list_name,B.list_name_E,user_id,active
            //    FROM Active_list as A  inner join List_Tbl as B on A.list_id = B.list_id where user_id  ='" + Convert.ToString(list_users.SelectedValue) + "'  ");
            //if (dt_list.Rows.Count > 0)
            //{
            //    dgv_list.RowCount = dt_list.Rows.Count;

            //    for (int i = 0; i < dgv_list.RowCount; i++)
            //    {
            //        dgv_list.Rows[i].Cells[0].Value = dt_list.Rows[i]["list_id"];
            //        if (Properties.Settings.Default.lungh == "0")
            //        {
            //        dgv_list.Rows[i].Cells[1].Value = dt_list.Rows[i]["list_name"];
            //        }
            //        else
            //        {
            //            dgv_list.Rows[i].Cells[1].Value = dt_list.Rows[i]["list_name_E"];
            //        }
            //            dgv_list.Rows[i].Cells[2].Value = dt_list.Rows[i]["active"];


            //    }
            //    // resizeDG();
            //}

            getList();
            //============



            list_screens.DataSource = dal.getDataTabl_1("SELECT * FROM List_Tbl");
            list_screens.DisplayMember = "list_name";
            list_screens.ValueMember="list_id";

           dGV1.DataSource = dal.getDataTabl_1(@"SELECT priv_user_id,priv_screen_id,screen_name ,priv_display,priv_add,priv_edit,priv_delete
                  FROM Priv_Tbl As A
                  inner join Screen_Tbl As B on A.priv_screen_id = B.screen_id
                  where  priv_user_id ='"+Convert.ToString(list_users.SelectedValue)+ "' and B.list_id = '"+Convert.ToString(list_screens.SelectedValue)+"'");
           dGV1.Columns[0].Visible = false;
           dGV1.Columns[1].Visible = false;
        }


        private void getList()
        {
            //==========
            DataTable dt_list = dal.getDataTabl_1(@"SELECT A.list_id,B.list_name,B.list_name_E,user_id,active
                FROM Active_list as A  inner join List_Tbl as B on A.list_id = B.list_id where user_id  ='" + Convert.ToString(list_users.SelectedValue) + "'  ");
            if (dt_list.Rows.Count > 0)
            {
                dgv_list.RowCount = dt_list.Rows.Count;

                for (int i = 0; i < dgv_list.RowCount; i++)
                {
                    dgv_list.Rows[i].Cells[0].Value = dt_list.Rows[i]["list_id"];
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        dgv_list.Rows[i].Cells[1].Value = dt_list.Rows[i]["list_name"];
                    }
                    else
                    {
                        dgv_list.Rows[i].Cells[1].Value = dt_list.Rows[i]["list_name_E"];
                    }
                    dgv_list.Rows[i].Cells[2].Value = dt_list.Rows[i]["active"];


                }
                // resizeDG();
            }

            //============

        }

        private void list_users_SelectedValueChanged(object sender, EventArgs e)
        {
            //try
            //{
                dGV1.DataSource = dal.getDataTabl_1(@"SELECT priv_user_id,priv_screen_id,screen_name ,priv_display,priv_add,priv_edit,priv_delete
                  FROM Priv_Tbl As A
                  inner join Screen_Tbl As B on A.priv_screen_id = B.screen_id
                  where  priv_user_id = '"+Convert.ToString(list_users.SelectedValue)+ "' and B.list_id = '"+Convert.ToString(list_screens.SelectedValue)+"'");

            getList();
            //}
            //catch

            //{ }
        }

        private void list_screens_SelectedValueChanged(object sender, EventArgs e)
        {
          //try{
            dGV1.DataSource = dal.getDataTabl_1(@"SELECT priv_user_id,priv_screen_id,screen_name ,priv_display,priv_add,priv_edit,priv_delete
                  FROM Priv_Tbl As A
                  inner join Screen_Tbl As B on A.priv_screen_id = B.screen_id
                  where  priv_user_id ='" + Convert.ToString(list_users.SelectedValue) + "' and B.list_id = '" + Convert.ToString(list_screens.SelectedValue) + "'");

              DataTable dt_ = dal.getDataTabl_1("select active from Active_list where list_id='" + Convert.ToString(list_screens.SelectedValue) + "' and user_id='" + Convert.ToString(list_users.SelectedValue) + "'");
            if (dt_.Rows.Count > 0) {
            if (dt_.Rows[0]["active"].ToString() == "False" || dt_.Rows[0]["active"].ToString() == string.Empty)
                {
                    Active_list.Checked =false;
                }
                else
                {
                    Active_list.Checked = true;
                }
            }
            //}
            //catch

            //{ }
        }

        private void list_screens_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string usre_id = Convert.ToString(list_users.SelectedValue);
                for (int i = 0; i < dGV1.Rows.Count; i++)
                {
                    string screen_no = Convert.ToString(dGV1.Rows[i].Cells[1].Value);

                   dal.Execute_1(@"UPDATE Priv_Tbl  SET priv_user_id = '" + usre_id + "', priv_screen_id = '" + screen_no + "', priv_display = '" + dGV1.Rows[i].Cells[3].Value + "' , priv_add = '" + dGV1.Rows[i].Cells[4].Value + "' , priv_edit = '" + dGV1.Rows[i].Cells[5].Value + "'   , priv_delete = '" + dGV1.Rows[i].Cells[6].Value + "'   WHERE priv_user_id = '" + usre_id+"' and priv_screen_id = '"+screen_no+"'");
                  // dal.Execute_1("Update Active_list set active='" + Active_list.Checked + "' where list_id='" + list_screens.SelectedValue + "' and user_id='" + list_users.SelectedValue + "'");

                  //  dal.Execute_1(@"update wh_USERS set Can_See_Cost = '" + chCanSeeCost.Checked.ToString() + "' where user_id='" + list_users.SelectedValue + "' ");
                }
                for (int i = 0; i < dgv_list.Rows.Count; i++)
                {
                    string list_Id = Convert.ToString(dgv_list.Rows[i].Cells[0].Value);

                    //  dal.Execute_1(@"UPDATE Priv_Tbl  SET priv_user_id = '" + usre_id + "', priv_screen_id = '" + screen_no + "', priv_display = '" + dGV1.Rows[i].Cells[3].Value + "'  as bool? ?? false , priv_add = '" + dGV1.Rows[i].Cells[4].Value + "' as bool? ?? false , priv_edit = '" + dGV1.Rows[i].Cells[5].Value + "' as bool? ?? false  , priv_delete = '" + dGV1.Rows[i].Cells[6].Value + "' as bool? ?? false   WHERE priv_user_id = '" + usre_id+"' and priv_screen_id = '"+screen_no+"'");
                    dal.Execute_1("Update Active_list set active = '" + dgv_list.Rows[i].Cells[2].Value + "'  where list_id='" + list_Id + "' and user_id='" + list_users.SelectedValue + "'");

                    //  dal.Execute_1(@"update wh_USERS set Can_See_Cost = '" + chCanSeeCost.Checked.ToString() + "' where user_id='" + list_users.SelectedValue + "' ");
                }


                MessageBox.Show("تم الحفظ بنجاح", "حفظ الصلاحيات", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void user_mang_frm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1("SELECT id,user_id,setup,transportation,sales,purchase,inventory,production,account,lc,loan,fixedassets,Prepaid FROM Active_list where  user_id='" + Convert.ToString(list_users.SelectedValue) + "'");
           if (dt_.Rows[0]["setup"].ToString() == "1")
          

            {
                textBox2.Text = dt_.Rows[0][0].ToString();
                Active_list.Checked = true;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            list_users.DataSource = dal.getDataTabl_1("SELECT * FROM wh_USERS");
            list_users.DisplayMember = "user_name";
            list_users.ValueMember = "user_id";

        }
    }
}
