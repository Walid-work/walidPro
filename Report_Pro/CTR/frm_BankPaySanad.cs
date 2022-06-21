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
    public partial class frm_BankPaySanad : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string btn_name;

        public frm_BankPaySanad()
        {
            InitializeComponent();
            cmb_Pay.DataSource = dal.getDataTabl_1("SELECT * FROM pay_method");
            if (Properties.Settings.Default.lungh == "0")
            {
                cmb_Pay.DisplayMember = "Pay_name";
            }
            else
            {
                cmb_Pay.DisplayMember = "Pay_name_E";
            }
            cmb_Pay.ValueMember = "Pay_ID";
            cmb_Pay.SelectedIndex = -1;

            cmb_Bank.DataSource = dal.getDataTabl_1("SELECT * FROM SHEEK_BANKS_TYPE");

            if (Properties.Settings.Default.lungh == "0")
            {
                cmb_Bank.DisplayMember = "BANK_NAME";
            }
            else
            {
                cmb_Bank.DisplayMember = "BANK_NAME_E";
            }
            cmb_Bank.ValueMember = "BANK_NO";
            cmb_Bank.SelectedIndex = -1;




            txt_sandDate.Value = DateTime.Today;
            acc_year.Text = "cy";
            Payment_Type.Text = "2";
            user_id.Text = Program.userID;
            txtStore_ID.Text = Properties.Settings.Default.BranchId;
            txt_source_code.Text = "DR";

            txtCashAcc.ID.Text = dal.GetCell_1("SELECT Cash_acc_no FROM wh_BRANCHES where Branch_code='"+ Properties.Settings.Default.BranchId+"'").ToString();
            txt_sandNo.Text = dal.getDataTabl_1(@"select isnull(BOX_ED_SER+1,1) as BOX_ED_SER  ,isnull(BOX_SARF_SER+1,1) as BOX_SARF_SER ,isnull(bank_sarf_ser+1,1) as bank_sarf_ser  ,isnull(bank_ed_ser+1,1) as bank_ed_ser  from serial_no where BRANCH_CODE ='" + txtStore_ID.Text
                      + "' and ACC_YEAR = '" + acc_year.Text + "'").Rows[0]["BOX_SARF_SER"].ToString();
        }


        private void frm_paySanad_Load(object sender, EventArgs e)
        {

        }

        private void BSave_Click(object sender, EventArgs e)
        {

            if (paied_amount.Value <= 0)
            {
                MessageBox.Show("فضلا.. تاكد من مبلغ السند", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmb_Pay.SelectedIndex < 0)
            {
                MessageBox.Show("فضلا.. تاكد من طريقة السداد", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txtAcc.ID.Text.Trim() == "")
            {
                MessageBox.Show("فضلا.. تاكد من الحساب ", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCust.Text == "")
            {
                MessageBox.Show("فضلا.. تاكد من اسم العميل ", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDescr.Text == "")
            {
                MessageBox.Show("فضلا.. تاكد من البيان ", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Add_sands();
            Add_Jor();
            BSave.Enabled = false;     
        }

        private void Add_sands()
        {

            txt_sandNo.Text = dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + Properties.Settings.Default.BranchId
                       + "' and Cyear= '" + acc_year.Text + "' and doc_Id =  '"+ txt_source_code.Text+"'").Rows[0][0].ToString();

            this.AccSer_No.Text = dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + Properties.Settings.Default.BranchId
                 + "' and Cyear= '" + acc_year.Text + "' and doc_Id =  'ENT'").Rows[0][0].ToString();//.PadLeft(4, '0');

            dal.Execute_1(@"Insert into Sands_tbl values( '" + acc_year.Text + "', '" + txtAcc.ID.Text + "','"
             + txtStore_ID.Text + "', '" + AccSer_No.Text + "','" + txtCost.ID.Text + "',0, '" + paied_amount.Text + "','" + txt_sandDate.Value.Date.ToString("yyyy/MM/dd")
            + "' , '" + txt_sandNo.Text + "','" + Payment_Type.Text + "','" + user_id.Text + "','" + txtDescr.Text + "', '" + txt_Check.Text + "' ,'" +
            Convert.ToString(cmb_Bank.SelectedValue) + "','" + (Check_Date.Value > Check_Date.MinDate ? Check_Date.Value.Date.ToString("yyyy/MM/dd") : Check_Date.MinDate.Date.ToString("yyyy/MM/dd"))
            + "','" + Convert.ToString(cmb_Pay.SelectedValue) + "','','','" + txt_source_code.Text + "','" + txtStore_ID.Text
            + "','','" + txtCashAcc.ID.Text + "','','" + paied_amount.Text + "','" + txtCust.Text + "','','','','','','','','','','','','','')");

            DataTable dt_ = dal.getDataTabl_1("Select * from Serails_tbl where Baranch_ID= '" + txtStore_ID.Text + "' and Cyear='" + acc_year.Text
                  + "' and doc_Id = '" + txt_source_code.Text + "'");
            if (dt_.Rows.Count > 0)
            {

                dal.Execute_1(@"UPDATE Serails_tbl SET last_ser = '" + txt_sandNo.Text + "' WHERE Baranch_ID= '" +
                    txtStore_ID.Text + "' and Cyear='" + acc_year.Text + "' and doc_Id = '" + txt_source_code.Text + "'");
            }

            else
            {
                dal.Execute_1(@"INSERT INTO Serails_tbl  Values ('" + txtStore_ID.Text + "' , '" + acc_year.Text + "' ,  '" + txt_source_code.Text + "','','','" + txt_sandNo.Text + "'");
            }
            MessageBox.Show("تم الحفظ بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        private void Add_Jor()
        {
            //string cyear = txt_InvDate.Value.Year.ToString();
            string H_Date;
            DataTable dtCurrntdate_ = dal.getDataTabl("convertdate_G", txt_sandDate.Value);
            H_Date = dtCurrntdate_.Rows[0][0].ToString();
            //this.AccSer_No.Text = dal.getDataTabl("get_ser", Properties.Settings.Default.BranchId, txt_InvDate.Value.Year.ToString(), "ENT").Rows[0][0].ToString().PadLeft(4, '0');


            //     }

            dal.Execute("Add_daily_transaction",
            acc_year.Text,
            txtAcc.ID.Text,
            //txtCashAcc.ID.Text,
            txtStore_ID.Text,
            AccSer_No.Text,
            "",
            "",
            "",
            paied_amount.Text,
            0,
            paied_amount.Text,
            H_Date,
            txt_sandDate.Value,
            txt_sandNo.Text,
            txt_source_code.Text,
            txt_source_code.Text + txt_sandNo.Text,
            user_id.Text,
            txtDescr.Text,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            String.Empty, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            txt_source_code.Text, txtStore_ID.Text, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, '0', DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            txtCust.Text, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, AccSer_No.Text);

            dal.Execute("Add_daily_transaction",
         acc_year.Text,
         txtCashAcc.ID.Text,
         //txtAcc.ID.Text,
         txtStore_ID.Text,
         AccSer_No.Text,
         "",
         "",
         "",
         0,
         paied_amount.Value,
         -paied_amount.Value,
         H_Date,
         txt_sandDate.Value,
         txt_sandNo.Text,
         txt_source_code.Text,
         txt_source_code.Text + txt_sandNo.Text,
         user_id.Text,
         txtDescr.Text,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         String.Empty, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
        txt_source_code.Text, txtStore_ID.Text, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, '0', DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         txtCust.Text, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, AccSer_No.Text);

            dal.Execute_1(@"UPDATE Serails_tbl SET last_ser = '" + AccSer_No.Text + "' WHERE Baranch_ID= '" + txtStore_ID.Text + "' and Cyear='" + acc_year.Text + "' and doc_Id = 'ENT'");


        }

        private void cmb_Pay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cmb_Pay.SelectedValue) == "04")
            {
                txt_Check.Enabled = true;
                cmb_Bank.Enabled = true;
                Check_Date.Enabled = true;
            }
            else
            {

                txt_Check.Enabled = false;
                cmb_Bank.Enabled = false;
                Check_Date.Enabled = false;
                txt_Check.Clear();
                cmb_Bank.SelectedIndex = -1;
                Check_Date.Text = "";

            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            try
            {
                CTR.frm_search_recect frm_recet = new CTR.frm_search_recect();
                frm_recet.txt_source_code.Text = "DR";
                frm_recet.ShowDialog();
               

                int ii = frm_recet.DGV1.CurrentRow.Index;

                DataTable dt_ = dal.getDataTabl_1("select * from Sands_tbl where SOURCE_CODE='" + txt_source_code.Text + " ' and sanad_no='" + frm_recet.DGV1.Rows[ii].Cells[0].Value.ToString() + "'");

                if (dt_.Rows.Count > 0)
                {

                    acc_year.Text = dt_.Rows[0][0].ToString();
                    txtAcc.ID.Text = dt_.Rows[0][1].ToString();
                    AccSer_No.Text = dt_.Rows[0][3].ToString();
                    txtCost.ID.Text = dt_.Rows[0][5].ToString();
                    paied_amount.Text = dt_.Rows[0][7].ToString();
                    txt_sandDate.Text = dt_.Rows[0][8].ToString();
                    txt_sandNo.Text = dt_.Rows[0][9].ToString();
                    Payment_Type.Text = dt_.Rows[0][10].ToString();
                    user_id.Text = dt_.Rows[0][11].ToString();
                    txtDescr.Text = dt_.Rows[0][12].ToString();
                    txt_Check.Text = dt_.Rows[0][13].ToString();
                    cmb_Bank.SelectedValue = dt_.Rows[0][14].ToString();
                    Check_Date.Text = dt_.Rows[0][15].ToString();
                    cmb_Pay.SelectedValue = dt_.Rows[0][16].ToString();
                    txt_source_code.Text = dt_.Rows[0][19].ToString();
                    txtStore_ID.Text = dt_.Rows[0][20].ToString();
                    txtCashAcc.ID.Text = dt_.Rows[0][22].ToString();
                    paied_amount.Text = dt_.Rows[0][24].ToString();
                    txtCust.Text = dt_.Rows[0][25].ToString();
                }
            }
            catch { }
        }

     
        private void print_sand_Click(object sender, EventArgs e)
        {
            try
            {
                CTR.Form1 frmSand = new CTR.Form1();
                CTR.rpt_paySanad print_sand = new CTR.rpt_paySanad();
                DataTable dt1 = new DataTable();

                dt1 = dal.getDataTabl_1(@"select Sands_tbl.*,payer2.PAYER_NAME,p2.PAYER_NAME,bank_name,pay_name,D.head_pic,D.foot_pic from Sands_tbl
                inner join Depart_tbl AS D on D.Depart_ID=sands_tbl.BRANCH_code
                inner join payer2 on sands_tbl.Acc_no=payer2.Acc_No
                inner join payer2 as p2 on sands_tbl.Cash_acc=p2.Acc_No
                left join SHEEK_BANKS_TYPE on bank_no=sheek_bank
                left join pay_method on pay_id=sheek_or_cash
                where sanad_no='" + txt_sandNo.Text + "' and source_code='" + txt_source_code.Text + " ' and BRANCH_code='" + Properties.Settings.Default.BranchId + "'");

                string tafqeet = dal.getDataTabl_1("select dbo.Tafkeet('" + dt1.Rows[0][24] + "','SAR')").Rows[0][0].ToString();
                print_sand.SetDataSource(dt1);
                print_sand.DataDefinition.FormulaFields["Tafqeet"].Text = "'" + tafqeet + "'";

                frmSand.crystalReportViewer1.ReportSource = print_sand;
                frmSand.ShowDialog();


                DataSet ds = new DataSet("sanads");
                ds.Tables.Add(dt1);

                //ds.WriteXmlSchema("schema3.xml");
            }
            catch { }
        }
        private void Acc_no_TextChanged(object sender, EventArgs e)
        {
            //Acc_name.Text = dal.getDataTabl_1("select payer_name from payer2 where acc_no='" + txtAcc.ID.Text + "'").Rows[0][0].ToString();
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            BSave.Enabled = true;
            Payment_Type.Text = "2";
            txtCashAcc.ID.Text = dal.getDataTabl("Get_Branche_data", Properties.Settings.Default.BranchId).Rows[0][14].ToString();

            txt_sandNo.Text = dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + txtStore_ID.Text
                + "' and Cyear= '" + acc_year.Text + "' and doc_Id =  '" + txt_source_code.Text + " '").Rows[0][0].ToString();

            
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DateTimeAdv.DateTimeInput)
                        (control as DevComponents.Editors.DateTimeAdv.DateTimeInput).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;

                    else
                        func(control.Controls);
            };
            func(Controls);
            // txtCoId.Text = Properties.Settings.Default.CoId;
            //BranchId.Text = Properties.Settings.Default.BranchId;
        }
        private void Cost_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
