using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class Update_take_to_production : Form
    {
        SqlConnection con = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Properties.Settings.Default.Database_1 + " ;integrated security=false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + "");
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Update_take_to_production()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //string const "Server=localhost; PORT=3306; Database=db; User id=root; password='';UseAffectedRows=True";
            //MySqlConnection con = new MySqlConnection(const);
            //con.Open();
            //MySqlCommand cmd = new MySqlCommand(con);
            //cmd.CommandText = "Update db set table = value where Column = value";
            //int numberOfRecords = cmd.ExecuteNonQuery();


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlTransaction trans;
            trans = con.BeginTransaction();
            cmd.Connection = con;
            cmd.Transaction = trans;
            try
            {
                cmd.CommandText = @"update wh_material_transaction
                set Local_Price = '" + Cost_.Value + "', COST_PRICE = '" + Cost_.Value +
            "' where TRANSACTION_CODE = 'xtp'  and IN_OUT_TYPE = 'i' and ITEM_NO = '" + Items.ID.Text +
            "' and Cyear = 19  and Local_Price <= '"+ oldCost_.Value+"'";
                cmd.ExecuteNonQuery();
                //SqlDataReader reader = cmd.ExecuteReader();
                int numberOfRecords = cmd.ExecuteNonQuery();
                MessageBox.Show(numberOfRecords.ToString(), "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trans.Commit();

            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "@1975")
            {
                btnUpdate.Visible = true;
            }
            else
            {
                btnUpdate.Visible = false;
            }
        }

        private void Cost__ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
