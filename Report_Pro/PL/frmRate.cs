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
    public partial class frmRate : Form
    {
        SqlConnection con = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Properties.Settings.Default.Database_1 + " ;integrated security=false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + "");

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        public frmRate()
        {
            InitializeComponent();
            txtCurrency.DataSource = dal.getDataTabl_1("SELECT * FROM " + dal.db1 + ".dbo.Wh_Currency");
            txtCurrency.ValueMember = "Currency_Code";
            if (Properties.Settings.Default.lungh == "ar")
            {
                txtCurrency.DisplayMember = "Currency_Name";
            }
            else
            {
                txtCurrency.DisplayMember = "Currency_Name";

            }
            txtCurrency.SelectedIndex = -1;

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frmRate_Load(object sender, EventArgs e)
        {
            txtBank.txtMainAcc.Text = "122";
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlTransaction trans;
            trans = con.BeginTransaction();
            cmd.Connection = con;
            cmd.Transaction = trans;
            try
            {
                //try
                //{
                cmd.CommandText = @"INSERT INTO RateTbl(BID,Curncy_Id,Rate)VALUES (@Bank,@currency,@Rate)";
                cmd.Parameters.AddWithValue("@txtitemid", txtBank.ID.Text);
                cmd.Parameters.AddWithValue("@txtitemid", Convert.ToString(txtCurrency.SelectedValue));
                cmd.Parameters.AddWithValue("@txtitemid", txtRate.Text.ToDecimal());

                MessageBox.Show("تم الحفظ بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BSave.Enabled = false;
                trans.Commit();

            }
            catch (Exception ex) {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
