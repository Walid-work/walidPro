using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using CrystalDecisions.CrystalReports.Engine;
using QRCoder;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace Report_Pro.PL
{
    public partial class frm_Sales_Invoice : Form
    {
        string btntype = "0";
        Int32 m;
        //string Jor_no;
        string btn_name;

        decimal old_balance, old_cost, new_balance, new_cost;
        Dates date_ = new Dates();
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();

        DataTable dt_inv_total = new DataTable();
        DataTable dt_inv = new DataTable();

        public frm_Sales_Invoice()
        {

            InitializeComponent();


           


            txt_InvSM.Text = Program.salesman;
            txtStore_ID.Text = Properties.Settings.Default.BranchId;
            txtBranch_Id.Text = Properties.Settings.Default.BranchId;
            userID.Text = Program.userID;
            

            Payment_Type.DataSource = dal.getDataTabl_1("SELECT * FROM wh_Payment_type");

            if (Properties.Settings.Default.lungh == "0")
            {
                Payment_Type.DisplayMember = "Payment_name";
            }
            else
            {
                Payment_Type.DisplayMember = "Payment_name_E";
            }
            Payment_Type.ValueMember = "Payment_type";
            Payment_Type.SelectedIndex = -1;
            
          
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

            M_Doc_Type.Text = "XS";

          


        }




    


       


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            get_BasicData();
            btntype = "0";
            string get_ser = @"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + Properties.Settings.Default.BranchId
                      + "' and Cyear= '" + txt_InvDate.Value.Year.ToString() + "' and doc_Id =  '" + Doc_Type.Text.ToString() + "'";
            this.txt_InvNu.Text = dal.getDataTabl_1(get_ser).Rows[0][0].ToString();//.PadLeft(4, '0');

            tabControlPanel1.Enabled = true;
            tabControlPanel2.Enabled = true;
            tabControlPanel3.Enabled = true;
            dt.Clear();


            BSave.Enabled = true;
            txt_InvNot.Focus();
            
        }

        private void BSave_Click(object sender, EventArgs e)
        {

            if (txt_Acc.ID.Text == string.Empty)
            {
                MessageBox.Show("فضلا.. تاكد من اختيار العميل ", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (Payment_Type.SelectedIndex < 0)
            {
                MessageBox.Show("فضلا.. تاكد من نوع الفاتورة", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inv_Grid.txtNetTotal.Text.ToDecimal() <= 0)
            {
                MessageBox.Show("لايمكن حفظ فاتورة بقيمة اقل من او يساوي صفر", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }





            if (Convert.ToString(Payment_Type.SelectedValue) == "11")
            {
                if (cmb_Pay.SelectedIndex < 0)
                {
                    MessageBox.Show("فضلا.. تاكد من طريقة السداد", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cashCustomer.Desc.Text.Replace(" ", string.Empty) == "")
                {
                    MessageBox.Show("تأكد من اسم العميل النقدي", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



            }


            if (IsGridValid() == false)
            {
                return;
            }

            dal.Execute_1(@"iF NOT EXISTS " +
             "(select Branch_code,Cyear  from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "') BEGIN INSERT INTO wh_Serial (Branch_code,Cyear) VALUES('" + txtStore_ID.Text + "','" + txt_InvDate.Value.Date.ToString("yy") + "') end");



            if (Convert.ToString(Payment_Type.SelectedValue) == "2")
            {
                Doc_Type.Text = "XSD";
                txt_InvNu.Text = dal.getDataTabl_1(@"select isnull(XSD+1,1) from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();
            }
            else if (Convert.ToString(Payment_Type.SelectedValue) == "11" || Convert.ToString(Payment_Type.SelectedValue) == "12")
            {
                Doc_Type.Text = "XSC";
                txt_InvNu.Text = dal.getDataTabl_1(@"select isnull(XSC+1,1) from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();

            }

            get_invSer();
            getAccSer();


            string cyear = txt_InvDate.Value.Year.ToString("yy");
            string H_Date = date_.GregToHijri(txt_InvDate.Text);


            SqlCommand cmd = dal.sqlconn_1.CreateCommand();
            SqlTransaction trans;
            trans = dal.sqlconn_1.BeginTransaction();
            cmd.Connection = dal.sqlconn_1;
            cmd.Transaction = trans;

            try
            {
                cmd.CommandText = @"insert into wh_inv_data (Ser_no, Branch_code, Transaction_code, Cyear, Sanad_no, G_date, ACC_TYPE, Acc_no,
                 Acc_Branch_code, Payment_Type, Sales_man_Id, acc_serial_no, Po_no, User_id, NetAmount, PanyedAmount,
                 Cash_costomer_name, total_cost, Inv_Notes, Costmer_No, Phone, Adress, K_M_ACC_NO, K_M_Credit_TAX,
                 K_M_Debit_TAX, COSTMER_K_M_NO, K_M_SER, KM_CODE_ACC, MAIN_KM_CODE,PROJECT_NO,Refrance_No,REQUIST_NO,Qutation_No)
                 values('" + txt_InvNu.Text + "', '" + txtStore_ID.Text + "', '" + Doc_Type.Text +
                    "', '" + txt_InvDate.Value.ToString("yy") + "' ,'" + txtMainSer.Text +
                    "', '" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','A', '" + txt_Acc.ID.Text +
                    "', '" + txtBranch_Id.Text + "', '" + Convert.ToString(Payment_Type.SelectedValue) +
                    "', '" + txt_Cost.ID.Text + "', '" + AccSer_No.Text + "', '" + Po_No.Text + "' , '" + userID.Text +
                    "', '" + inv_Grid.txtNetTotal.Text.ToDecimal() + "', '" + inv_Grid.paied_amount.Text.ToDecimal() +
                    "', '" + cashCustomer.Desc.Text + "', '0', '" + txt_InvNot.Text + "', '" + cashCustomer.ID.Text +
                    "', '" + txt_custTel.Text + "', '" + txt_address.Text + "', '" + Vat_acc.Text + "', '" + inv_Grid.txtTotalVAT.Text.ToDecimal() +
                    "', '0', '" + Cust_Vat_No.Text + "', '0','" + Vat_Class.Text + "','" + Vat_Class.Text + "','" + Uc_Project.ID.Text +
                    "','" + txt_Refrance.Text + "','" + Po_No.Text + "','" + txt_Qutation.Text + "')";

                cmd.ExecuteNonQuery();


                foreach (MyControls.Inv_Row r in inv_Grid.flowLayoutPanel1.Controls)
                {

                    if (r.txt_Code.Text != string.Empty && r.qty.Value > 0 && r.TxtPrice.Value > 0)
                    {
                        cmd.CommandText = @" insert into wh_MATERIAL_TRANSACTION (SER_NO,Branch_code,TRANSACTION_CODE,Cyear,SANAD_NO,ITEM_NO,QTY_ADD,QTY_TAKE,total_disc,DISC_R,DISC_R2,DISC_R3,
                        G_DATE,Unit,Local_Price,USER_ID,main_counter,balance,Store_Code,K_M_TYPE_ITEMS,TAX_IN,TAX_OUT,modular,VAT_RATIO) 
                       values( '" + txt_InvNu.Text + "', '" + txtStore_ID.Text + "', '" + Doc_Type.Text + "', '" + txt_InvDate.Value.ToString("yy") +
                        "' ,'" + txtMainSer.Text + "','" + r.txt_Code.Text + "' ,'0','" +
                       r.qty.Text + "','" + ((r.TxtDisc.Text.ToDecimal() / r.txt_subTOt.Text.ToDecimal()) + inv_Grid.disc_Rate.Text.ToDecimal()) * 100 +
                        "' ,'" + (r.TxtDisc.Text.ToDecimal() / r.txt_subTOt.Text.ToDecimal()) * 100 + "' ,'0','" + (inv_Grid.disc_Rate.Text.ToDecimal()) * 100 +
                        "', '" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Convert.ToString(r.txtUnit.Text) +
                        "' ,'" + r.TxtPrice.Text.ToDecimal() + "' , '" + userID.Text + "','" +
                        inv_Grid.flowLayoutPanel1.Controls.GetChildIndex(r) + "', '" + r.qty.Text.ToDecimal() + "', '" + txtStore_ID.Text +
                       "','" + r.KM_TYPE_ITEMS.Text + "' ,'0','" + r.VatValue.Text.ToDecimal() + "','" + r.txtNote.Text + "','" + r.VatRate.Value + "')";

                        cmd.ExecuteNonQuery();

                    }

                }



                cmd.CommandText = @"UPDATE  wh_Serial SET " + Doc_Type.Text.ToString() + "= '" + txt_InvNu.Text + "'," + M_Doc_Type.Text.ToString() + "= '" + txtMainSer.Text + "'  WHERE Branch_code = '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.ToString("yy") + "' ";
                cmd.ExecuteNonQuery();



                cmd.CommandText = @"INSERT INTO daily_transaction ( ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh,
                balance, h_date,g_date,sanad_no, SANAD_TYPE, sp_ser_no, user_name, desc2,POASTING,SOURCE_CODE, Wh_Branch_Code, MAIN_SER_NO,PROJECT_NO )
                Values('" + acc_year.Text + "', '" + txt_Acc.ID.Text + "', '" + txtBranch_Id.Text + "','" + AccSer_No.Text + "','" +
                txt_Cost.ID.Text + "','" + inv_Grid.txtNetValue.Text + "','" + 0 + "','" + inv_Grid.txtNetValue.Text + "','" + H_Date + "','" +
                txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txt_InvNu.Text + "','" + Doc_Type.Text + "','" + Doc_Type.Text + txt_InvNu.Text + "','" +
                userID.Text + "','" + "فاتورة مبيعات " + Payment_Type.Text + " رقم " + txt_InvNu.Text + "','0','" + Doc_Type.Text + "','" +
                txtStore_ID.Text + "','" + AccSer_No.Text + "','" + Uc_Project.ID.Text + "')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"INSERT INTO daily_transaction ( ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh,
                 balance, h_date,g_date,sanad_no, SANAD_TYPE, sp_ser_no, user_name, desc2,POASTING, SOURCE_CODE, Wh_Branch_Code, MAIN_SER_NO,PROJECT_NO )
                Values('" + acc_year.Text + "', '" + txtAcc2_ID.Text + "', '" + txtBranch_Id.Text + "','" + AccSer_No.Text + "','" +
                txt_Cost.ID.Text + "','" + 0 + "','" + inv_Grid.txt_SubTot.Text.ToDecimal() + "','" + -inv_Grid.txtNetTotal.Text.ToDecimal() + "','" + H_Date + "','" +
                txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txt_InvNu.Text + "','" + Doc_Type.Text + "','" + Doc_Type.Text + txt_InvNu.Text + "','" +
                userID.Text + "','" + "فاتورة مبيعات " + Payment_Type.Text + " رقم " + txt_InvNu.Text + "','0','" + Doc_Type.Text + "','" +
                txtStore_ID.Text + "','" + AccSer_No.Text + "','" + Uc_Project.ID.Text + "')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"INSERT INTO daily_transaction ( ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh,
                balance, h_date,g_date,sanad_no, SANAD_TYPE, sp_ser_no, user_name, desc2,POASTING, SOURCE_CODE, Wh_Branch_Code, MAIN_SER_NO,PROJECT_NO )
                Values('" + acc_year.Text + "', '" + Vat_acc.Text + "', '" + txtBranch_Id.Text + "','" + AccSer_No.Text + "','" +
                txt_Cost.ID.Text + "','" + 0 + "','" + inv_Grid.txtTotalVAT.Text.ToDecimal() + "','" + -inv_Grid.txtTotalVAT.Text.ToDecimal() + "','" + H_Date + "','" +
                txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txt_InvNu.Text + "','" + Doc_Type.Text + "','" + Doc_Type.Text + txt_InvNu.Text + "','" +
                userID.Text + "','" + "ضريبة فاتورة مبيعات " + Payment_Type.Text + " رقم " + txt_InvNu.Text + "','0','" + Doc_Type.Text + "','" +
                txtStore_ID.Text + "','" + AccSer_No.Text + "','" + Uc_Project.ID.Text + "')";
                cmd.ExecuteNonQuery();





                cmd.CommandText = @"UPDATE serial_no SET daily_sn_ser='" + Main_AccSer_No.Text + "' , main_daily_ser = '" + AccSer_No.Text + "' WHERE BRANCH_CODE=  '" + txtBranch_Id.Text + "' and ACC_YEAR='" + acc_year.Text + "' ";
                cmd.ExecuteNonQuery();





                trans.Commit();
                MessageBox.Show("Data was saved ---- تم حفظ البيانات ", "Save --- حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dal.sqlconn_1.Close();
            }


            //try
            //{

            ////if (MessageBox.Show("هل التاريخ صحيح", "تحذير !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            ////{

            ////    return;

            ////}

            //    if (txt_Acc.ID.Text == string.Empty)
            //    {
            //        MessageBox.Show("فضلا.. تاكد من اختيار العميل ", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    if (inv_Grid.flowLayoutPanel1.Controls.Count < 1)
            //    {
            //        MessageBox.Show("فضلا.. تاكد من اختيار الاصناف", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }


            //    if (Payment_Type.SelectedIndex < 0)
            //    {
            //        MessageBox.Show("فضلا.. تاكد من نوع الفاتورة", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    if (inv_Grid.txtNetValue.Text.ToDecimal() <= 0)
            //    {
            //        MessageBox.Show("لايمكن حفظ فاتورة بقيمة اقل من او ياو", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }



            //    if (Convert.ToString(Payment_Type.SelectedValue) == "11")
            //    {
            //        if (cmb_Pay.SelectedIndex < 0)
            //        {
            //            MessageBox.Show("فضلا.. تاكد من طريقة السداد", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }

            //        if (CashCust_name.Text.Trim() == "" && txt_Acc.ID.Text == dal.GetCell_1(@"SELECT Cash_Costmer_Code FROM wh_BRANCHES where Branch_code = '" + txtStore_ID.Text + "'").ToString())
            //        {
            //            MessageBox.Show("تأكد من اسم العميل النقدي", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }


            //    }
            //    this.AccSer_No.Text = dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + Properties.Settings.Default.BranchId
            //         + "' and Cyear= '" + acc_year.Text + "' and doc_Id =  'ENT'").Rows[0][0].ToString();//.PadLeft(4, '0');
            //    AddInv();
            //    AddInvDetails();
            //    if (Convert.ToString(Payment_Type.SelectedValue) == "11")
            //    {
            //        Add_sands();
            //    }
            //    dal.Execute_1(@"UPDATE Serails_tbl SET last_ser = '" + txt_InvNu.Text + "' WHERE Baranch_ID= '" + Properties.Settings.Default.BranchId + "' and Cyear='" + txt_InvDate.Value.Year.ToString() + "' and doc_Id = '" + Doc_Type.Text + "'");

            //    if (Properties.Settings.Default.TRANS_TO_ACC == "A")
            //    {
            //        Add_Jor();
            //        dal.Execute_1(@"UPDATE Serails_tbl SET last_ser = '" + AccSer_No.Text + "' WHERE Baranch_ID= '" + Properties.Settings.Default.BranchId + "' and Cyear='" + acc_year.Text + "' and doc_Id = 'ENT'");
            //    }
            //    MessageBox.Show("تم الحفظ بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    tabControlPanel1.Enabled = false;
            //    tabControlPanel2.Enabled = false;
            //    tabControlPanel3.Enabled = false;

            //    BSave.Enabled = false;
            //}



            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;

            //}

        }


        bool IsGridValid()
        {

            int countR = 0;

            foreach (MyControls.Inv_Row c in inv_Grid.flowLayoutPanel1.Controls)
            {
                if (c.txt_Code.Text != String.Empty && c.qty.Value > 0 && c.TxtPrice.Value > 0)
                {
                    countR++;
                }

            }
            if (countR > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(dal.rm.GetString("msgError") + " No Items", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }


        private void get_invSer()
        {
            //try
            //{
            DataTable dt_ser =
            dt_ser = dal.getDataTabl_1(@"select isnull(XS+1,1)As xs_ser,isnull(XSD+1,1)As xsd_ser
                ,isnull(XSC+1,1) As xsc_ser,isnull(XSR+1,1)As xsr_ser,isnull(XST+1,1) As xst_ser 
                from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'");
            if (dt_ser.Rows.Count > 0)
            {
                txtMainSer.Text = dt_ser.Rows[0]["xs_ser"].ToString();
                if (Convert.ToString(Payment_Type.SelectedValue) == "2")
                {
                    Doc_Type.Text = "XSD";
                    txt_InvNu.Text = dt_ser.Rows[0]["xsd_ser"].ToString();
                }
                else if (Convert.ToString(Payment_Type.SelectedValue) == "11" || Convert.ToString(Payment_Type.SelectedValue) == "12")
                {
                    Doc_Type.Text = "XSC";
                    txt_InvNu.Text = dt_ser.Rows[0]["xsc_ser"].ToString();

                }
            }
            else
            {
                txtMainSer.Text = "1";
                if (Convert.ToString(Payment_Type.SelectedValue) == "2")
                {
                    Doc_Type.Text = "XSD";
                    txt_InvNu.Text = "1";
                }
                else if (Convert.ToString(Payment_Type.SelectedValue) == "11" || Convert.ToString(Payment_Type.SelectedValue) == "12")
                {
                    Doc_Type.Text = "XSC";
                    txt_InvNu.Text = "1";

                }

            }


        }


        private void getAccSer()
        {
            DataTable dt_AccSer = dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) as main_daily_ser ,isnull(daily_sn_ser+1,1) as daily_sn_ser  from serial_no where BRANCH_CODE='" + Properties.Settings.Default.BranchId
 + "' and ACC_YEAR= '" + acc_year.Text + "' ");//.PadLeft(4, '0');

            AccSer_No.Text = dt_AccSer.Rows[0]["main_daily_ser"].ToString();
            Main_AccSer_No.Text = dt_AccSer.Rows[0]["daily_sn_ser"].ToString();
        }

        private void Payment_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_invSer();
            // total_inv();
        }




        private void AddInv()
        {

            dal.Execute_1(@"Insert into InvTbl (Ser_no,Stor_Code,Transaction_code,Cyear,CoID,G_date,Acc_no,Branch_code,Payment_Type
                        ,Sales_man_Id,Inv_no,Inv_date,acc_serial_no,Po_no,Recvied_by_another_Store,Recving_date,Recving_no,total_cost
                        ,Total_Amount,Disc_1,Total_Value,Disc_2,NetAmount,PanyedAmount,Return_reson,User_id,Send_To_Another_Branch
                        ,Cash_costomer_name,Inv_Notes,Trans_Where,Inv_Balance,Vat_Value,phone_no,fax_no,E_MAIL,Vat_No,adress,b_o_box
                        ,area_code,Guid_Code,F14) 
           
            values('" + txt_InvNu.Text + "', '" + txtStore_ID.Text + "', '" + Doc_Type.Text + "', '" + txt_InvDate.Value.Year.ToString()
            + "' , 'A', '" + txt_InvDate.Value.ToString("yyyy/MM/dd hh:mm:ss") + "', '" + txt_Acc.ID.Text + "', '" + txtBranch_Id.Text + 
            "', '" + Convert.ToString(Payment_Type.SelectedValue) + "', '" + userID.Text + "', '', '' , '" + AccSer_No.Text + 
            "', '" + Po_No.Text + "' , '' , '','', '0','" + inv_Grid.txt_SubTot.Text.ToDecimal() + "', '" +inv_Grid.txt_discount_1.Text.ToDecimal() + 
            "','0', '" + inv_Grid.txt_TotDisc.Text.ToDecimal() + "','" +inv_Grid.txt_SubTot.Text.ToDecimal() + "','" + inv_Grid.paied_amount.Text.ToDecimal() + 
            "', '','','','"+ cashCustomer.Desc.Text +"', '" + txt_InvNot.Text + "','','" + inv_Grid.balance_amount.Text.ToDecimal() + 
            "','" + inv_Grid.txtTotalVAT.Text.ToDecimal() + "','"+ txt_custTel.Text+"','"+ txt_custFax.Text +"','"+ txt_CustEmail.Text + 
            "','"+ Cust_Vat_No.Text +"','"+ txt_address.Text +"','"+ txt_BoBox.Text +"','"+ txt_area_code.Text +"','"+ Guid.NewGuid()+"','"+txt_Refrance+"')");

        }



        private void Add_sands()
        {

            txt_sandNo.Text = dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + Properties.Settings.Default.BranchId
                       + "' and Cyear= '" + acc_year.Text + "' and doc_Id =  'CR'").Rows[0][0].ToString();

            dal.Execute_1(@"Insert into Sands_tbl values( '" + acc_year.Text + "', '" + txt_Acc.ID.Text + "','"
             + txtBranch_Id.Text + "', '" + AccSer_No.Text + "','"+ txt_Cost.ID.Text +"',0, '" + inv_Grid.txt_SubTot.Text + "','"
             + txt_InvDate.Value.ToString("yyyy/MM/dd hh:mm:ss") + "' , '" + txt_sandNo.Text + "','" 
             + Convert.ToString(Payment_Type.SelectedValue) + "','" + userID.Text + "',  'سداد فاتورة مبيعات ' +'" 
             + Payment_Type.Text + "' + ' رقم ' + '" + txt_InvNu.Text + "', '" + txt_Check.Text + "' ,'" 
             + Convert.ToString(cmb_Bank.SelectedValue) + "','" + (Check_Date.Value > Check_Date.MinDate ? 
             Check_Date.Value.Date.ToString("yyyy/MM/dd") : Check_Date.MinDate.Date.ToString("yyyy/MM/dd")) + "','" 
             + Convert.ToString(cmb_Pay.SelectedValue) + "','','" + txt_InvNot.Text + "','CR','" + txtStore_ID.Text 
             + "','" +inv_Grid.txtTotalVAT.Text.ToDecimal() + "','" + txt_CashAcc_ID.Text + "','" + txt_InvNu.Text + "','" 
             + inv_Grid.paied_amount.Text + "','"+ cashCustomer.Desc.Text +"','','','','','','','','','','','','','')");


            DataTable dt_ = dal.getDataTabl_1("Select * from Serails_tbl where Baranch_ID= '" + txtStore_ID.Text + "' and Cyear='" + acc_year.Text
                          + "' and doc_Id = 'CR'");
            if (dt_.Rows.Count > 0)
            {


                dal.Execute_1(@"UPDATE Serails_tbl SET last_ser = '" + txt_sandNo.Text + "' WHERE Baranch_ID= '" +
                    Properties.Settings.Default.BranchId + "' and Cyear='" + acc_year.Text + "' and doc_Id = 'CR'");


            }

            else
            {
                dal.Execute_1(@"INSERT INTO Serails_tbl  Values ('" + txtStore_ID.Text + "' , '" + acc_year.Text + "' ,  'CR','','','" + txt_sandNo.Text + "'");
            }


        }



        private void AddInvDetails()
        {
            foreach (MyControls.Inv_Row r in inv_Grid.flowLayoutPanel1.Controls)
            {

                if (r.txt_Code.Text != string.Empty && r.qty.Value > 0 && r.TxtPrice.Value > 0)
                {

                    dal.Execute_1(@"Insert into InvDetailsTbl values('" + txt_InvNu.Text + "' , '" + txtBranch_Id.Text + "' , '" + txtStore_ID.Text + "' , '" + Doc_Type.Text
                 + "' , '" + txt_InvDate.Value.Year.ToString() + "' , '" + r.txt_Code.Text + "' , '0','" +
                 r.qty.Value + "','" + r.txtUnit.Text + "','" +
                 r.txtCost.Text + "', '" + r.TxtPrice.Value
                 + "' , '" + r.txt_subTOt.Text + "' , '" + r.TxtDisc.Value
                 + "' , '" + r.Txtvalue.Value + "' ,'" + txt_InvDate.Value.ToString("yyyy/MM/dd hh:mm:ss") 
                 + "' ,'"+ r.txtBalance.Text +"', '0', 0,'','" + Convert.ToString(Payment_Type.SelectedValue)
                 + "', 0,0,'" + r.txtNote.Text + "' , '" + inv_Grid.disc_Rate.Text.ToDecimal() * r.Txtvalue.Text.ToString().ToDecimal()
                 + "' , '" + r.VatRate.Value + "' , '" + r.VatValue.Text.ToDecimal() + "','')");

                    //dal.Execute("update_blance"
                    //  , dGV_Item_.Rows[i].Cells[0].Value.ToString() // ITEM_NO
                    //  , Properties.Settings.Default.CoId // CoId
                    //  , Properties.Settings.Default.BranchId // Branh_code
                    //  , dGV_Item_.Rows[i].Cells[11].Value.ToString() // COST_PRICE
                    //  , dGV_Item_.Rows[i].Cells[10].Value.ToString()  // balance
                    //   , txt_InvSM.Text  // Sales_man_Id
                    //   , txt_InvDate.Value       // G_DATE
                    //);

                }
            }
        }

        private void Add_Main_transaction()
        {

        }

        private void Add_daily_transaction()
        {

        }

        private void BSearch_Click(object sender, EventArgs e)
        {

            PL.order_list_frm ord = new PL.order_list_frm();
            ord.trans_code = "xsc";
            ord.trans_code_1 = "xsd";
            ord.ShowDialog();
        }

        private void getSalesInv(string ser_, string branch_, string transaction_, string cyear_)

        {
            dt_inv = this.dal.getDataTabl_1(@"select A.ser_no,A.Branch_code,A.Cyear,A.Transaction_code,A.G_date,A.Acc_no,A.Payment_Type,A.Sales_man_Id,A.Inv_no,A.Inv_date,a.Inv_Notes,A.Phone,A.Adress,A.PROJECT_NO,A.Costmer_No,A.Cash_costomer_name,A.REQUIST_NO,A.Refrance_No,A.acc_serial_no,A.Qutation_No,B.modular,B.DP_Ratio,B.DP_Amount,B.VAT_RATIO,
            B.ITEM_NO,B.QTY_ADD,B.QTY_TAKE,B.Unit,B.Local_Price,isnull(B.TAX_IN,0)as TAX_IN ,isnull(B.TAX_OUT,0)as TAX_OUT , round(b.total_disc*B.local_price*QTY_TAKE/100,2) as disc_ ,p.PAYER_NAME,p.payer_l_name,p2.PAYER_NAME as lc_name ,p2.payer_l_name as lc_L_Name,P.adress,P.adress_E ,P.phone_no,P.fax_no,P.E_MAIL,P.COSTMER_K_M_NO, P.SEGEL_NO,P.ZAKAH_NO,
            M.descr,M.Descr_eng, br.branch_name,BR.WH_E_NAME,Br.Branch_Logo_A4,PT.Payment_name,U.unit_Description, U.unit_Description_E,J.Project_Name,J.Project_Name_E
            ,(select top 1 vat_ratio from VAT_RATIO_MASTER where cast(A.G_date as date ) between date_of_vat and '" + DateTime.Today.ToString("yyyy-MM-dd") + "' order by date_of_vat desc) as VatRatio " +
            "from wh_inv_data As A " +
            "inner join wh_material_transaction As B on a.Ser_no = b.SER_NO and a.Cyear = b.Cyear and a.Transaction_code = b.TRANSACTION_CODE and a.Branch_code = b.Branch_code  " +
            "inner join payer2 As P on a.Acc_no = p.ACC_NO and a.Acc_Branch_code = p.BRANCH_code  " +
            "left join(select* from payer2)as p2 on p2.ACC_NO = a.LC_ACC_NO and a.Acc_Branch_code = p2.BRANCH_code  " +
            "inner join wh_main_master as M on M.item_no=B.ITEM_NO  " +
            "inner join wh_BRANCHES As BR on BR.Branch_code = a.Branch_code  " +
            "inner join wh_Payment_type as PT on A.Payment_Type=PT.Payment_type  " +
            "inner join  Wh_Unit as U on U.Wh_Unit = B.unit " +
            "left join Projects as J on J.ID = A.PROJECT_NO " +
            "where a.SER_NO = '" + ser_ + "' and a.Transaction_code = '" + transaction_ + "' and a.Branch_code = '" + branch_ + "' and a.Cyear = '" + cyear_ + "'");
        }
        //(select case when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) between '2018-01-01' and '2020-06-30'   then 5  when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) > '2020-06-30' then 15  else 0 end)as VatRatio

        private void getInvoiceTotal(string ser_, string branch_, string transaction_, string cyear_)
        {
            dt_inv_total = dal.getDataTabl_1(@"select round(sum(b.QTY_TAKE*Local_Price),2) as TotalValue
            , round(sum(b.total_disc * B.local_price * QTY_TAKE / 100), 2) as discount
            , round(sum(isnull(b.TAX_OUT, 0)), 2) as tax
            , round(sum(b.QTY_TAKE * Local_Price), 2) - round(sum(b.total_disc * B.local_price * QTY_TAKE / 100), 2) + round(sum(isnull(b.TAX_OUT, 0)), 2) as NetValue
            , round(sum(b.QTY_ADD * Local_Price), 2) - round(sum(b.total_disc * B.local_price * QTY_ADD / 100), 2) + round(sum(isnull(b.TAX_IN, 0)), 2) as NetValuePurch 
            from wh_material_transaction as b
            where b.SER_NO = '" + ser_ + "'  and b.Transaction_code = '" + transaction_ + "' and b.Branch_code = '" + branch_ + "' and b.Cyear = '" + cyear_ + "'  " +
            "group by TRANSACTION_CODE,Branch_code,Cyear,SER_NO");
        }

        private void search_Inv(string _transaction)
        {
            PL.frmSerch frm = new PL.frmSerch();
            frm.ShowDialog();
            getSalesInv(frm.txtSearch.t.Text, txtStore_ID.Text, _transaction, txt_InvDate.Value.ToString("yy"));
            if (dt_inv.Rows.Count > 0)
            {
                Doc_Type.Text = dt_inv.Rows[0]["Transaction_code"].ToString();

                txt_InvDate.Text = dt_inv.Rows[0]["G_date"].ToString();
                txt_Acc.ID.Text = dt_inv.Rows[0]["Acc_no"].ToString();
                Payment_Type.SelectedValue = dt_inv.Rows[0]["Payment_Type"].ToString();
                Uc_Project.ID.Text = dt_inv.Rows[0]["PROJECT_NO"].ToString();
                txt_InvNot.Text = dt_inv.Rows[0]["Inv_Notes"].ToString();
                txt_address.Text = dt_inv.Rows[0]["Adress"].ToString();
                txt_Cost.ID.Text = dt_inv.Rows[0]["Sales_man_Id"].ToString();
                cashCustomer.ID.Text = dt_inv.Rows[0]["Costmer_No"].ToString();
                txt_InvNu.Text = dt_inv.Rows[0]["ser_no"].ToString();
                AccSer_No.Text = dt_inv.Rows[0]["acc_serial_no"].ToString();
                txt_Refrance.Text = dt_inv.Rows[0]["Refrance_No"].ToString();
                Po_No.Text = dt_inv.Rows[0]["REQUIST_NO"].ToString();
                txt_Qutation.Text = dt_inv.Rows[0]["Qutation_No"].ToString();

                int i = 0;
                inv_Grid.flowLayoutPanel1.Controls.Clear();

                foreach (DataRow r in dt_inv.Rows)
                {


                    MyControls.Inv_Row row = new MyControls.Inv_Row();
                    row.txt_Code.Text = r["ITEM_NO"].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        row.TxtDesc.Text = r["descr"].ToString();
                    }
                    else
                    {
                        row.TxtDesc.Text = r["Descr_eng"].ToString();
                    }
                    row.txtNote.Text = r["modular"].ToString();
                   // row.txtUnit.SelectedValue = r["Unit"].ToString();
                    row.qty.Text = r["QTY_TAKE"].ToString();
                    row.TxtPrice.Text = r["Local_Price"].ToString();
                    row.txt_subTOt.Text = (row.qty.Value * row.TxtPrice.Value).ToString();
                  // // row.txt_DP_Ratio.Text = r["DP_Ratio"].ToString().ToDecimal().ToString("N0");
                 // // row.TxtDisc.Text = r["DP_Amount"].ToString().ToDecimal().ToString();
                    row.Txtvalue.Text = (row.qty.Value * row.TxtPrice.Value - row.TxtDisc.Value).ToString();
                    row.VatRate.Text = r["VAT_RATIO"].ToString().ToDecimal().ToString();
                    row.VatValue.Text = r["TAX_OUT"].ToString().ToDecimal().ToString();
                    inv_Grid.flowLayoutPanel1.Controls.Add(row);
                    i = i + 1;
                }
                inv_Grid.total_inv();




            }
        }



        private void buttonItem1_Click(object sender, EventArgs e)
        {


            DataSet dataSet = new DataSet();

            RPT.Rpt_Pro_Frm frminv = new RPT.Rpt_Pro_Frm();
            //DataTable dt_1 = dal.getDataTabl("get_invDetails", txt_InvNu.Text, Doc_Type.Text, txt_InvDate.Value.ToString("yy"), Properties.Settings.Default.BranchId);
            getSalesInv(txt_InvNu.Text, txtStore_ID.Text, Doc_Type.Text, txt_InvDate.Value.ToString("yy"));

            string printModel = Properties.Settings.Default.inv_print;

            getInvoiceTotal(txt_InvNu.Text, Properties.Settings.Default.BranchId, Doc_Type.Text, txt_InvDate.Value.ToString("yy"));
            DataTable dt_Co = dal.getDataTabl_1(@"select * from Wh_Oiner_Comp ");


            string vat_no = dt_Co.Rows[0]["Comp_Vat_no"].ToString();
            string Co_Name = dt_Co.Rows[0]["Company_e_name"].ToString();
            string invDate = txt_InvDate.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string TotalInv = dt_inv_total.Rows[0]["NetValue"].ToString().ToDecimal().ToString("N2");
            string TotalTax = dt_inv_total.Rows[0]["tax"].ToString();

            PictureBox pic_ = new PictureBox();
            dal.pic1 = pic_;
            dal.GetImsge(Co_Name, vat_no, invDate, TotalInv, TotalTax);

            DataTable dQR = new DataTable();
            using (MemoryStream ms = new MemoryStream())
            {
                pic_.Image.Save(ms, ImageFormat.Bmp);

                byte[] byteImage = ms.ToArray();
                dQR.Columns.Add(new DataColumn("Barcode", typeof(byte[])));
                dQR.Rows.Add(byteImage);
            }

            //string CompanyName = "شركة فن المدار";
            //string InvNo = dt_1.Rows[0]["Ser_no"].ToString() ;
            //string CustomerName = dt_1.Rows[0]["Cash_costomer_name"].ToString();
            //string TotalInv = dt_inv_total.Rows[0]["TotalValue"].ToString();
            //string TotalTax = dt_inv_total.Rows[0]["tax"].ToString();
            //string code =
            //  //  " + inv_no+"&p2=" +brnch_code+"&p3="+trans_code+"&p4="+cyear;
            //CompanyName + System.Environment.NewLine + "Invoice No. :" + InvNo + System.Environment.NewLine + "Cstomer Name :" + CustomerName + System.Environment.NewLine + "Total Value :" + TotalInv + System.Environment.NewLine + "VAT Value :" + TotalTax;


            //QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            //QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
            //QRCode qRCode = new QRCode(qRCodeData);
            //Bitmap bmp = qRCode.GetGraphic(7);
            //DataTable dQR = new DataTable();
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    bmp.Save(ms, ImageFormat.Bmp);

            //    byte[] byteImage = ms.ToArray();

            //    //picQR.Image = bmp;

            //    // RPT.QR_rpt rpt = new RPT.QR_rpt();
            //    dQR.Columns.Add(new DataColumn("Barcode", typeof(byte[])));
            //    dQR.Rows.Add(byteImage);
            //}


            dataSet.Tables.Add(dt_inv);
            dataSet.Tables.Add(dQR);
            dataSet.Tables.Add(dt_Co);
            //dataSet.WriteXmlSchema("schema_rpt.xml");

            if (printModel == "1")
            {
                RPT.Rpt_Print_Sales_Invoice reportInv = new RPT.Rpt_Print_Sales_Invoice();
                reportInv.SetDataSource(dataSet);
                //reportInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;
                //reportInv.PrintToPrinter(1, false, 0, 15);
                frminv.crystalReportViewer1.ReportSource = reportInv;
                frminv.ShowDialog();
            }

            else

            {
                RPT.Rpt_inv_1 reportInv = new RPT.Rpt_inv_1();
                //                reportInv.SetDataSource(dal.getDataTabl("get_invDetails", txt_InvNu.Text, Doc_Type.Text, txt_InvDate.Value.Year.ToString(), Properties.Settings.Default.BranchId));
                //reportInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;
                //reportInv.PrintToPrinter(1, false, 0, 15);
                reportInv.SetDataSource(dataSet);
                frminv.crystalReportViewer1.ReportSource = reportInv;
                frminv.ShowDialog();
            }
               
        }


        private void BtnCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
                        DataTable dtMain_ = dal.getDataTabl_1(@"SELECT Qutation_Tbl.*,Payment_name,dbo.Tafkeet(InvNetTotal,'SAR')as tfqtAR,saleman,C_Name,branch_name
            FROM Qutation_Tbl inner join wh_Payment_type on wh_Payment_type.Payment_type=Qutation_Tbl.Payment_Type
            inner join Customer_Tbl on Customer_Tbl.C_ID=Qutation_Tbl.custID
            inner join wh_BRANCHES on wh_BRANCHES.Branch_code=Qutation_Tbl.DepID
            where Qutation_Tbl.SerNO='" + txt_Qutation.Text + "' and DepID='" + Properties.Settings.Default.BranchId + "' and Qutation_Tbl.TransID='Qut' and Qutation_Tbl.Cyear='" + txt_InvDate.Value.Year.ToString() + "'");


            txt_InvNu.Text = dtMain_.Rows[0][0].ToString();
            txt_InvDate.Text = dtMain_.Rows[0][1].ToString();
            txt_Acc.ID.Text = dtMain_.Rows[0][2].ToString();
            txt_InvNot.Text = dtMain_.Rows[0][3].ToString();
           inv_Grid.txt_SubTot.Text = dtMain_.Rows[0][4].ToString();
           inv_Grid.txt_TotDisc.Text = dtMain_.Rows[0][5].ToString();
            inv_Grid.txt_SubTot.Text = dtMain_.Rows[0][6].ToString();
            txtStore_ID.Text = dtMain_.Rows[0][7].ToString();
            Payment_Type.SelectedValue = dtMain_.Rows[0][11].ToString();
            // txt_Attn.Text = dtMain_.Rows[0][12].ToString();
            txt_custTel.Text = dtMain_.Rows[0][13].ToString();
            txt_custFax.Text = dtMain_.Rows[0][15].ToString();
            txt_CustEmail.Text = dtMain_.Rows[0][16].ToString();
            //txt_Validity.Text = dtMain_.Rows[0][17].ToString();
            //txt_InvSM.Text = dtMain_.Rows[0][22].ToString();
            // txt_Delevary.Text = dtMain_.Rows[0][19].ToString();
            //txt_CustNm.Text = dtMain_.Rows[0][23].ToString();

            //DataTable dt_ = dal.getDataTabl("Get_Qutation_Details", txt_Qutation.Text, Properties.Settings.Default.BranchId, "Qut", txt_InvDate.Value.Year.ToString());
            DataTable dt_ = dal.getDataTabl_1(@"SELECT Qutation_Details_Tbl.*,Product_Tbl.Desc_pro,Product_Tbl.wight
            FROM Qutation_Details_Tbl inner join Product_Tbl on Qutation_Details_Tbl.Id_pro=Product_Tbl.Id_Pro
            where Qutation_Details_Tbl.Id_order='" + txt_Qutation.Text + "' and Qutation_Details_Tbl.BranchID='" + Properties.Settings.Default.BranchId
             + "' and Qutation_Details_Tbl.TransID='Qut' and Qutation_Details_Tbl.cyear='" + txt_InvDate.Value.Year.ToString() + "'");


            dt.Clear();
            int i = 0;
            DataRow row = null;
            foreach (DataRow r in dt_.Rows)
            {

                row = dt.NewRow();
                row[0] = dt_.Rows[i][0];
                row[1] = dt_.Rows[i][12];
                row[2] = dt_.Rows[i][14];
                row[3] = dt_.Rows[i][3];
                row[4] = dt_.Rows[i][4];
                row[5] = dt_.Rows[i][13];
                row[6] = dt_.Rows[i][5];
                row[7] = dt_.Rows[i][6];
                row[8] = dt_.Rows[i][7];
                row[9] = dt_.Rows[i][2];


                dt.Rows.Add(row);
                i = i + 1;
            }

           // dGV_Item.DataSource = dt;
            //resizeDG();

        }

      
        private void invoice_frm_Load(object sender, EventArgs e)
        {
            get_BasicData();
           
       }

        private void get_BasicData()
        {
            txt_Acc.branchID.Text = Properties.Settings.Default.BranchId;
            txt_Acc.txtFinal.Text = "1";
            txt_Acc.txtMainAcc.Text = dal.getDataTabl_1(@"select Costmers_acc_no FROM wh_BRANCHES where BRANCH_code='" + Properties.Settings.Default.BranchId + "'").Rows[0][0].ToString(); ;


            DataTable Dt_1 = dal.getDataTabl_1(@"SELECT B.SALES_ACC_NO , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.SALES_ACC_NO=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code");
            txtAcc2_ID.Text = Dt_1.Rows[0][0].ToString();
            txtAcc2_Desc.Text = Dt_1.Rows[0][1].ToString();

            DataTable Dt_2 = dal.getDataTabl_1(@"SELECT B.Cash_acc_no , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.Cash_acc_no=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code");
            txt_CashAcc_ID.Text = Dt_2.Rows[0][0].ToString();
            txt_CashAcc_Desc.Text = Dt_2.Rows[0][1].ToString();

            DataTable Dt_3 = dal.getDataTabl_1(@"SELECT B.K_M_ACC_NO_SALES , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.K_M_ACC_NO_SALES=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code");
            Vat_acc.Text = Dt_3.Rows[0][0].ToString();
            Vat_acc_Desc.Text = Dt_3.Rows[0][1].ToString();

        }


        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Add_Jor()
        {
            string cyear = txt_InvDate.Value.Year.ToString();
            string H_Date;
            DataTable dtCurrntdate_ = dal.getDataTabl("convertdate_G", txt_InvDate.Value);
            H_Date = dtCurrntdate_.Rows[0][0].ToString();
            //this.AccSer_No.Text = dal.getDataTabl("get_ser", Properties.Settings.Default.BranchId, txt_InvDate.Value.Year.ToString(), "ENT").Rows[0][0].ToString().PadLeft(4, '0');


            //     }

            dal.Execute("Add_daily_transaction",
            acc_year.Text,
            (Convert.ToString(Payment_Type.SelectedValue) == "2") ? txt_CustAcc_ID.Text : txt_CashAcc_ID.Text,
            txtBranch_Id.Text,
            AccSer_No.Text,
            txt_Cost.ID.Text,
            "",
            "",
            inv_Grid.txt_SubTot.Text,
            0,
           inv_Grid.txt_SubTot.Text,
            H_Date,
            txt_InvDate.Value,
            txt_InvNu.Text,
            Doc_Type.Text,
            Doc_Type.Text + txt_InvNu.Text,
            userID.Text,
            "فاتورة مبيعات " + Payment_Type.Text + " رقم " + txt_InvNu.Text,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            String.Empty, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            Doc_Type.Text, txtStore_ID.Text, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, txt_Acc.ID.Text, 0, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, AccSer_No.Text);

            dal.Execute("Add_daily_transaction",
             acc_year.Text,
             txtAcc2_ID.Text,
             txtStore_ID.Text,
             AccSer_No.Text,
             "",
             "",
             "",
             0,
            inv_Grid.txt_SubTot.Text.ToDecimal(),
             -inv_Grid.txt_SubTot.Text.ToDecimal(),
             H_Date,
             txt_InvDate.Value,
             txt_InvNu.Text,
             Doc_Type.Text,
             Doc_Type.Text + txt_InvNu.Text,
             userID.Text,
             "فاتورة مبيعات " + Payment_Type.Text + " رقم " + txt_InvNu.Text,
             DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             String.Empty, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             Doc_Type.Text, txtStore_ID.Text, DBNull.Value, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, 0, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
             DBNull.Value, DBNull.Value, DBNull.Value, AccSer_No.Text);

            dal.Execute("Add_daily_transaction",
                acc_year.Text,
                Vat_acc.Text,
                txtStore_ID.Text,
                AccSer_No.Text,
                "",
                "",
                "",
                0,
                inv_Grid.txtTotalVAT.Text.ToDecimal(),
               -inv_Grid.txtTotalVAT.Text.ToDecimal(),
                H_Date,
                txt_InvDate.Value,
                txt_InvNu.Text,
                Doc_Type.Text,
                Doc_Type.Text + txt_InvNu.Text,
                userID.Text,
                "ضريبة فاتورة مبيعات " + Payment_Type.Text + " رقم " + txt_InvNu.Text,
                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                String.Empty, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                Doc_Type.Text, txtStore_ID.Text, DBNull.Value, DBNull.Value, DBNull.Value,
                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                DBNull.Value, DBNull.Value, -inv_Grid.txt_SubTot.Text.ToDecimal(), cashCustomer.Desc.Text, txt_InvNu.Text,
                txt_InvDate.Value.ToShortDateString(), Cust_Vat_No.Text, DBNull.Value, DBNull.Value, DBNull.Value,
                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                DBNull.Value, DBNull.Value, DBNull.Value, AccSer_No.Text);


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //DataTable dtMain_ = dal.getDataTabl("get_Qutation", txt_Qutation.Text, Properties.Settings.Default.BranchId, "Qut", txt_InvDate.Value.Year.ToString());

            DataTable dtMain_ = dal.getDataTabl_1(@"SELECT Qutation_Tbl.*,Payment_name,dbo.Tafkeet(InvNetTotal,'SAR')as tfqtAR,saleman,C_Name,branch_name
            FROM Qutation_Tbl inner join wh_Payment_type on wh_Payment_type.Payment_type=Qutation_Tbl.Payment_Type
            inner join Customer_Tbl on Customer_Tbl.C_ID=Qutation_Tbl.custID
            inner join wh_BRANCHES on wh_BRANCHES.Branch_code=Qutation_Tbl.DepID
            where Qutation_Tbl.SerNO='" + txt_Qutation.Text + "' and DepID='" + Properties.Settings.Default.BranchId + "' and Qutation_Tbl.TransID='Qut' and Qutation_Tbl.Cyear='" + txt_InvDate.Value.Year.ToString() + "'");


            txt_InvNu.Text = dtMain_.Rows[0][0].ToString();
            txt_InvDate.Text = dtMain_.Rows[0][1].ToString();
            txt_Acc.ID.Text = dtMain_.Rows[0][2].ToString();
            txt_InvNot.Text = dtMain_.Rows[0][3].ToString();
            inv_Grid.txt_SubTot.Text = dtMain_.Rows[0][4].ToString();
            inv_Grid.txt_TotDisc.Text = dtMain_.Rows[0][5].ToString();
            inv_Grid.txt_SubTot.Text = dtMain_.Rows[0][6].ToString();
            txtStore_ID.Text = dtMain_.Rows[0][7].ToString();
            Payment_Type.SelectedValue = dtMain_.Rows[0][11].ToString();
            txt_custTel.Text = dtMain_.Rows[0][13].ToString();
            txt_custFax.Text = dtMain_.Rows[0][15].ToString();
            txt_CustEmail.Text = dtMain_.Rows[0][16].ToString();

            // DataTable dt_ = dal.getDataTabl("Get_Qutation_Details", txt_Qutation.Text, Properties.Settings.Default.BranchId, "Qut", txt_InvDate.Value.Year.ToString());

            DataTable dt_ = dal.getDataTabl_1(@"SELECT Qutation_Details_Tbl.*,Product_Tbl.Desc_pro,Product_Tbl.wight,Wh_Unit.Unit_Desc
            FROM Qutation_Details_Tbl inner join Product_Tbl on Qutation_Details_Tbl.Id_pro=Product_Tbl.Id_Pro   inner join Wh_Unit on Qutation_Details_Tbl.unit=Wh_Unit.Unit_id
            where Qutation_Details_Tbl.Id_order='" + txt_Qutation.Text + "' and Qutation_Details_Tbl.BranchID='" + Properties.Settings.Default.BranchId
          + "' and Qutation_Details_Tbl.TransID='Qut' and Qutation_Details_Tbl.cyear='" + txt_InvDate.Value.Year.ToString() + "'");

            dt.Clear();
            int i = 0;
            DataRow row = null;
            foreach (DataRow r in dt_.Rows)
            {

                row = dt.NewRow();
                row[0] = dt_.Rows[i][0];
                row[1] = dt_.Rows[i][13];
                row[2] = dt_.Rows[i][14];
                row[3] = dt_.Rows[i][3];
                row[4] = dt_.Rows[i][4];
                row[5] = dt_.Rows[i][5];
                row[6] = dt_.Rows[i][6];
                row[7] = dt_.Rows[i][7];
                //row[8] = dt_.Rows[i][7];
                //row[9] = dt_.Rows[i][2];


                dt.Rows.Add(row);
                i = i + 1;
            }

            //dGV_Item.DataSource = dt;
            //total_inv();

        }

        private void txtAcc_2_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void txtStore_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void txtStore_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = dal.getDataTabl("GetStores", txtStore_ID.Text.ToString());
                if (dt.Rows.Count > 0)
                {
                    // txtStore_Desc.Text = dt.Rows[0][2].ToString();
                    txtAcc2_ID.Text = dt.Rows[0][9].ToString();
                    txt_CashAcc_ID.Text = dt.Rows[0][12].ToString();
                    txt_CustAcc_ID.Text = dt.Rows[0][13].ToString();
                }
                else
                {
                    // txtStore_Desc.Text = "";
                }
            }
            catch
            {

            }
        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

 
        private void groupPanel6_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel7_Click(object sender, EventArgs e)
        {

        }

        private void print_sand_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.Form1 frmSand = new RPT.Form1();
                RPT.CrystalReport5 print_sand = new RPT.CrystalReport5();
                DataTable dt1 = new DataTable();

                dt1 = dal.getDataTabl_1(@"select S.*,P.PAYER_NAME,p2.PAYER_NAME,B.bank_name,pay_name 
            from Sands_tbl as S
            inner join payer2 as P on S.Acc_no=P.Acc_No and S.BRANCH_code=p.BRANCH_code
            inner join payer2 as p2 on S.Cash_acc=p2.Acc_No and S.BRANCH_code=p2.BRANCH_code
            left join SHEEK_BANKS_TYPE as B on B.bank_no=S.sheek_bank
            left join pay_method  as PM on PM.pay_id=S.sheek_or_cash
            where S.sanad_no='" + txt_sandNo.Text + "' and S.source_code='CR' and S.BRANCH_code='"+Properties.Settings.Default.BranchId+"'");

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
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;

                    else
                        func(control.Controls);
            };

            func(Controls);
            // txtCoId.Text = Properties.Settings.Default.CoId;
            //BranchId.Text = Properties.Settings.Default.BranchId;
        }

        private void labelX37_Click(object sender, EventArgs e)
        {

        }

        private void labelX47_Click(object sender, EventArgs e)
        {

        }

        private void tabControlPanel2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Bank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelX44_Click(object sender, EventArgs e)
        {

        }

        private void Check_Date_Click(object sender, EventArgs e)
        {

        }

        private void labelX43_Click(object sender, EventArgs e)
        {

        }

        private void txt_Check_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX42_Click(object sender, EventArgs e)
        {

        }

        private void labelX41_Click(object sender, EventArgs e)
        {

        }

        private void labelX46_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void labelX51_Click(object sender, EventArgs e)
        {

        }

        private void dGV_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      private void tabControl1_Click(object sender, EventArgs e)
        {

        }

         private void txt_CustNm_KeyUp(object sender, KeyEventArgs e)
        {
            //tabControl1.BringToFront();
            //DGV3.Visible = true;
            //btn_name = "Btn_srch_cust";

            //string Acc_cust = (dal.getDataTabl_1(@"select costmers_acc_no FROM wh_BRANCHES where BRANCH_code='" + Properties.Settings.Default.BranchId + "'")).Rows[0][0].ToString();
            //DGV3.DataSource = dal.getDataTabl_1(@"select ACC_NO,PAYER_NAME  FROM payer2 where BRANCH_code='" + Properties.Settings.Default.BranchId
            //    + "' and PAYER_NAME like '%" + txt_CustNm.Text + "%' and t_final='1'");
            //int clientX = (int)(txt_CustNm.Location.X);
            //int clientY = (int)(txt_CustNm.Location.Y);
            //DGV3.Location = new Point(clientX, clientY + 20);
            //DGV3.BringToFront();
            //DGV3.Columns[0].Width = 60;           
        }

        private void TxtDisc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void inv_Grid_Load(object sender, EventArgs e)
        {
           
        }

        private void Doc_Type_Click(object sender, EventArgs e)
        {

        }

        private void AccSer_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sandNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_AccSer_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_InvDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            get_invSer();
        }

        private void btn_Search_Credit_Click(object sender, EventArgs e)
        {
            search_Inv("XSD");
            BSave.Enabled = false;
        }

        private void btn_Search_Cash_Click(object sender, EventArgs e)
        {
            search_Inv("XSC");
            BSave.Enabled = false;
        }

        private void BEdit_Click(object sender, EventArgs e)
        {

        }

        private void txt_Acc_Load(object sender, EventArgs e)
        {
           // string Acc_main = (dal.getDataTabl_1(@"select Costmers_acc_no FROM wh_BRANCHES where BRANCH_code='" + Properties.Settings.Default.BranchId + "'")).Rows[0][0].ToString();

            string Get_cust = @"SELECT p.ACC_NO,p.phone_no,p.fax_no,p.E_MAIL,V.VAT_ID,p.COSTMER_K_M_NO
                ,p.adress,p.adress_E,p.resp_name,p.resp_name_E,p.area_code,p.b_o_box,V.VAT_DESC,V.VAT_RATIO 
                    FROM PAYER2 as P 
                    inner join VAT_ACC as V on V.VAT_ID = isnull(P.KM_CODE_Sales,'11') 
                    where  BRANCH_code='" + txt_Acc.branchID.Text + "' and acc_no like '" + txt_Acc.txtMainAcc.Text + "%' and  ACC_NO ='" + txt_Acc.ID.Text + "'";


            DataTable dt_itme = dal.getDataTabl_1(Get_cust);
            if (dt_itme.Rows.Count > 0)
            {
                // this.txt_CustID.Text = dt_itme.Rows[0][1].ToString();
                // this.txt_CustNm.Text = dt_itme.Rows[0][7].ToString();
                txt_custTel.Text = dt_itme.Rows[0]["phone_no"].ToString();
                txt_custFax.Text = dt_itme.Rows[0]["fax_no"].ToString();
                txt_CustEmail.Text = dt_itme.Rows[0]["E_MAIL"].ToString();
                txt_CustAcc_ID.Text = dt_itme.Rows[0]["ACC_NO"].ToString();
                //txt_CustAcc_Desc.Text = dt_itme.Rows[0][7].ToString();
                Vat_Class.Text = dt_itme.Rows[0]["VAT_ID"].ToString();
                Cust_Vat_No.Text = dt_itme.Rows[0]["COSTMER_K_M_NO"].ToString();
                Vat_Class_Desc.Text = dt_itme.Rows[0]["VAT_DESC"].ToString();
                Cust_Vat_Rate.Text = dt_itme.Rows[0]["VAT_RATIO"].ToString();
                inv_Grid.txtAccVat_Rate.Text= dt_itme.Rows[0]["VAT_RATIO"].ToString();
                txt_address.Text = dt_itme.Rows[0]["adress"].ToString();
                txt_resp.Text = dt_itme.Rows[0]["resp_name"].ToString();
                txt_area_code.Text = dt_itme.Rows[0]["area_code"].ToString();
                txt_BoBox.Text = dt_itme.Rows[0]["b_o_box"].ToString();

                if (txt_Acc.ID.Text == dal.getDataTabl_1(@"select Cash_Costmer_Code FROM wh_BRANCHES where BRANCH_code='" + txt_Acc.branchID.Text + "'").Rows[0][0].ToString())
                {
                    Payment_Type.SelectedValue = "11";
                    Payment_Type.Enabled = false;
                    cashCustomer.Desc.Clear();

                }
                else
                {
                    Payment_Type.SelectedIndex = -1;
                    Payment_Type.Enabled = true;
                    cashCustomer.Desc.Text = dt_itme.Rows[0][7].ToString();
                }
           

                inv_Grid.total_inv();
            }
        }

        private void txt_BoBox_TextChanged(object sender, EventArgs e)
        {

        }

      

       
        
    }
}


     