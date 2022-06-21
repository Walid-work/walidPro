using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.CTR
{
    public partial class frm_Update_Sanadtype_2 : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Update_Sanadtype_2()
        {
            InitializeComponent();
        }

        private void frm_Update_Sanadtype_2_Load(object sender, EventArgs e)
        {
           cmb_Transaction.DisplayMember = "Text";
           cmb_Transaction.ValueMember = "Value";

           //cmb_Transaction.Items.Add(new { Text = "ايداع بنكي من الصندوق", Value = "CB" });
           //cmb_Transaction.Items.Add(new { Text = "سند صرف مصروفات", Value = "CE" });
           //cmb_Transaction.Items.Add(new { Text = "سند قبض نقدي", Value = "CR" });
           ////cmb_Transaction.Items.Add(new { Text = "report D", Value = "reportD" });
           ////cmb_Transaction.Items.Add(new { Text = "report E", Value = "reportE" });
          

           var items = new[] { 
new { Text = "ايداع بنكي من الصندوق", Value = "CB" },
new { Text = "سند صرف مصروفات", Value = "CE" },
new { Text = "سند قبض نقدي", Value = "CR" },
new { Text = " سند قبض بنكي ", Value = "BR" }
           
};

           cmb_Transaction.DataSource = items;

        }

        private void txt_J_Entry_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dt_ = dal.getDataTabl_1(@"select meno+loh as amount_,SANAD_TYPE2 FROM daily_transaction where branch_code='" + txtBranch.ID.Text + "' and ser_no='" + txt_J_Entry.Text + "' ");
                txtAmount.Text = dt_.Rows[0]["amount_"].ToString();
                cmb_Transaction.SelectedValue = dt_.Rows[0]["SANAD_TYPE2"].ToString();
            }
            catch
            {
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dal.Execute_1(@"update daily_transaction  set SANAD_TYPE2 ='"+Convert.ToString(cmb_Transaction.SelectedValue)+"' where branch_code='" + txtBranch.ID.Text + "' and ser_no='" + txt_J_Entry.Text + "' ");
             }
    }
}
