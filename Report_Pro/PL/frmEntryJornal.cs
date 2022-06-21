using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmEntryJornal : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        Dates date_ = new Dates();
        public frmEntryJornal()
        {
            InitializeComponent();
        }

        private void frmEntryJornal_Load(object sender, EventArgs e)
        {
            txtBranchCode.Text = Properties.Settings.Default.BranchAccID;
            txtBranchName.Text = dal.GetCell_1("select BRANCH_name from BRANCHS where BRANCH_code='" + Properties.Settings.Default.BranchAccID + "' ").ToString();

        }

        private void getJorSer()
        {

            this.txtSerNo.Text = "M" + dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) from serial_no where BRANCH_CODE='" + Properties.Settings.Default.BranchId
                     + "' and ACC_YEAR= '" + txt_Cyear.Text + "'").Rows[0][0].ToString().PadLeft(4, '0');

            this.Main_serNo.Text = dal.getDataTabl_1(@"select isnull(daily_sn_ser+1,1) from serial_no where BRANCH_CODE='" + Properties.Settings.Default.BranchId
                 + "' and ACC_YEAR= '" + txt_Cyear.Text + "' ").Rows[0][0].ToString();//.PadLeft(4, '0');


        }

        //void Add_D_transaction()
        //{
        //    for (int i = 0; i <= jorDebit1.Controls.Count - 1; i++)
        //    {
        //        DataGridViewRow DgRow = dGV_Item.Rows[i];
        //        if (dGV_Item.Rows[i].Cells[2].Value != null)
        //        {
        //            if (dGV_Item.Rows[i].Cells[0].Value == null)
        //            {
        //                dGV_Item.Rows[i].Cells[0].Value = 0;
        //            }

        //            if (dGV_Item.Rows[i].Cells[1].Value == null)
        //            {
        //                dGV_Item.Rows[i].Cells[1].Value = 0;
        //            }


        //            dal.Execute("Add_daily_transaction",
        //               txt_Cyear.Text,
        //               DgRow.Cells[2].Value.ToString(),
        //                Properties.Settings.Default.BranchId,
        //                txtSerNo.Text.ToString(),
        //                Convert.ToString(DgRow.Cells[5].Value),
        //                "",
        //                "",
        //                DgRow.Cells[0].Value.ToString().ToDecimal(),
        //                DgRow.Cells[1].Value.ToString().ToDecimal(),
        //                DgRow.Cells[0].Value.ToString().ToDecimal() - DgRow.Cells[1].Value.ToString().ToDecimal(),
        //                mTxt_H.Text.ToString(),
        //                dateTimePicker1.Value,
        //                Main_serNo.Text,
        //                txtSanad_type.Text,
        //                txt_sp_ser.Text,
        //                Program.userID,
        //                dGV_Item.Rows[i].Cells[4].Value.ToString(),
        //                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
        //                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
        //                txtMainNote.Text,
        //                DBNull.Value, String.Empty, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
        //                DBNull.Value, DBNull.Value, DBNull.Value,
        //                Properties.Settings.Default.BranchId,
        //                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
        //                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
        //                Convert.ToString(DgRow.Cells[7].Value),
        //                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
        //                DBNull.Value, DBNull.Value, DgRow.Cells[9].Value.ToString().ToDecimal(), DgRow.Cells[10].Value.ToString(), DgRow.Cells[11].Value.ToString(),
        //                DgRow.Cells[12].Value.ToString(), DgRow.Cells[13].Value.ToString(), DBNull.Value, DBNull.Value,
        //                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
        //                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
        //                Main_serNo.Text);

        //        }

        //    }
        //}


        private void BNew_Click(object sender, EventArgs e)
        {
            getJorSer();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mTxt_H.Text = date_.GregToHijri(dateTimePicker1.Text);

            }
        }

        private void jor_Row1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
