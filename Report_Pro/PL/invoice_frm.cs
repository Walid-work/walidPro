using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using CrystalDecisions.CrystalReports.Engine;

namespace Report_Pro.PL
{
    public partial class invoice_frm : frm_Master
    {
        string btntype = "0";
        Int32 m;
        //string Jor_no;
        string btn_name;
        decimal old_balance, old_cost, new_balance, new_cost;
        Dates date_ = new Dates();

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();




        public invoice_frm()
        {

            InitializeComponent();


            
           // creatDattable();
           



            txt_InvSM.Text = Program.salesman;
            txtStore_ID.Text = Properties.Settings.Default.BranchId;
            txtBranch_Id.Text = Properties.Settings.Default.BranchAccID;
            userID.Text = Program.userID;


            PayType.DataSource = dal.getDataTabl_1("SELECT * FROM wh_Payment_type");

            if (Properties.Settings.Default.lungh == "0")
            {
                PayType.DisplayMember = "Payment_name";
            }
            else
            {
                PayType.DisplayMember = "Payment_name";
            }
            PayType.ValueMember = "Payment_type";
            PayType.SelectedIndex = -1;




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
                cmb_Bank.DisplayMember = "BANK_NAME";
            }
            cmb_Bank.ValueMember = "BANK_NO";
            cmb_Bank.SelectedIndex = -1;




        }



        public override void GoFrist()
        {
            MessageBox.Show("frist");
            base.GoFrist();
        }



















        private void get_invSer()
        {
            try
            {
                txtMainSer.Text = dal.getDataTabl_1(@"select isnull(XS+1,1) from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();
                if (txt_PayType.ID.Text == "2")
                {
                    Doc_Type.Text = "XSD";
                    this.txt_InvNu.Text = dal.getDataTabl_1(@"select isnull(XSD+1,1) from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();
                }
                else if (txt_PayType.ID.Text == "11" || txt_PayType.ID.Text == "12")
                {
                    Doc_Type.Text = "XSC";
                    this.txt_InvNu.Text = dal.getDataTabl_1(@"select isnull(XSC+1,1) from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();

                }
            }
            catch { }


        }

        private void Payment_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_invSer();
            gridInvoice1.total_inv();
        }

        private void paied_amount_KeyUp(object sender, KeyEventArgs e)
        {
            balance_amount.Text = (txtNetTotal.Text.ToDecimal() - paied_amount.Text.ToDecimal()).ToString();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            btntype = "0";
            get_invSer();
            tabControlPanel1.Enabled = true;
            tabControlPanel2.Enabled = true;
            tabControlPanel3.Enabled = true;
            gridInvoice1.Enabled = true;

            dt.Clear();
            gridInvoice1.dgv1.DataSource = null;
            gridInvoice1.dgv1.Refresh();
            gridInvoice1.dgv1.Rows.Clear();


            BSave.Enabled = true;
            txt_InvNot.Focus();
            
        }

        private void BSave_Click(object sender, EventArgs e)
        {

            try
            {
            
                if (txt_Acc.ID.Text == string.Empty)
                {
                    MessageBox.Show("فضلا.. تاكد من اختيار العميل ", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (gridInvoice1.dgv1.Rows.Count < 1)
                {
                    MessageBox.Show("فضلا.. تاكد من اختيار الاصناف", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (txt_PayType.ID.Text.Trim() =="")
                {
                    MessageBox.Show("فضلا.. تاكد من نوع الفاتورة", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtNetTotal.Text.ToDecimal() <= 0)
                {
                    MessageBox.Show("لايمكن حفظ فاتورة بقيمة اقل من او ياو", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               

                if (txt_PayType.ID.Text.Trim() == "11" || txt_PayType.ID.Text.Trim() == "12")
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
                 try
            {
                if (txt_PayType.ID.Text.Trim()== "2")
                {
                    Doc_Type.Text = "XSD";
                    this.txt_InvNu.Text = dal.getDataTabl_1(@"select isnull(XSD+1,1) from wh_Serial where Branch_code= '"+txtStore_ID.Text+"' and Cyear='"+ txt_InvDate.Value.Date.ToString("yy")+"'").Rows[0][0].ToString();
                }
                else if (txt_PayType.ID.Text.Trim() == "11" || txt_PayType.ID.Text.Trim() == "12")
                {
                    Doc_Type.Text = "XSC";
                    this.txt_InvNu.Text = dal.getDataTabl_1(@"select isnull(XSC+1,1) from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();
                    
                }
            }
            catch { }

                get_invSer();

                this.AccSer_No.Text = dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) from serial_no where BRANCH_CODE='" + Properties.Settings.Default.BranchId
                 + "' and ACC_YEAR= '" + acc_year.Text + "' ").Rows[0][0].ToString();//.PadLeft(4, '0');


                AddInv();
                AddInvDetails();
                //if (Convert.ToString(Payment_Type.SelectedValue) == "11")
                //{
                //    Add_sands();
                //}
                dal.Execute_1(@"UPDATE  wh_Serial SET "+ Doc_Type.Text+" = '" + txt_InvNu.Text + "' WHERE Branch_code = '" + txtStore_ID.Text+ "' and Cyear='" + txt_InvDate.Value.ToString("yy")+"' ");

                if (Properties.Settings.Default.TRANS_TO_ACC == "A")
                {
                    Add_Jor();
                    dal.Execute_1(@"UPDATE serial_no SET main_daily_ser = '" + AccSer_No.Text + "' WHERE BRANCH_CODE= '" + Properties.Settings.Default.BranchId + "' and ACC_YEAR='" + acc_year.Text + "' ");
                }
                MessageBox.Show("تم الحفظ بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControlPanel1.Enabled = false;
                tabControlPanel2.Enabled = false;
                tabControlPanel3.Enabled = false;
                gridInvoice1.Enabled = false;

                BSave.Enabled = false;
            }



            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }

        }

        private void AddInv()
        {

           dal.Execute_1(@"insert into wh_inv_data(Ser_no, Branch_code, Transaction_code, Cyear, Sanad_no, G_date, ACC_TYPE, Acc_no,
                        Acc_Branch_code, Payment_Type, Sales_man_Id, acc_serial_no, Po_no, User_id, NetAmount, PanyedAmount,
                        Cash_costomer_name, total_cost, Inv_Notes, Costmer_No, Phone, Adress, K_M_ACC_NO, K_M_Credit_TAX,
                        K_M_Debit_TAX, COSTMER_K_M_NO, K_M_SER, KM_CODE_ACC, MAIN_KM_CODE)
                        values('" + txt_InvNu.Text + "', '" + txtStore_ID.Text + "', '" + Doc_Type.Text +
                        "', '" + txt_InvDate.Value.ToString("yy") + "' ,'" + txtMainSer.Text +
                        "', '" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','A', '" + txt_Acc.ID.Text +
                        "', '" + txtBranch_Id.Text + "', '" + txt_PayType.ID.Text +
                        "', '" + Uc_Cost.ID.Text + "', '" + AccSer_No.Text + "', '" + Po_No.Text + "' , '" + userID.Text +
                        "', '" + txtNetTotal.Text.ToDecimal() + "', '" + paied_amount.Text.ToDecimal() +
                        "', '" +cashCustomer.Desc.Text + "', '0', '" + txt_InvNot.Text + "', '" + cashCustomer.ID.Text +
                        "', '" + txt_custTel.Text + "', '" + txt_address.Text + "', '" + txt_vatAcc.Text + "', '" + Net_Vat.Text.ToDecimal() +
                        "', '0', '" + Cust_Vat_No.Text + "', '0','" + txtKmCode.Text+"','" + Vat_Class.Text + "')");

               }



        private void Add_sands()
        {

            txt_sandNo.Text = dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + Properties.Settings.Default.BranchId
                       + "' and Cyear= '" + acc_year.Text + "' and doc_Id =  'CR'").Rows[0][0].ToString();

            dal.Execute_1(@"Insert into Sands_tbl values( '" + acc_year.Text + "', '" + txt_Acc.ID.Text + "','"
             + txtBranch_Id.Text + "', '" + AccSer_No.Text + "','"+ Uc_Cost.ID.Text +"',0, '" + txtNetTotal.Text + "','"
             + txt_InvDate.Value.Date.ToString("yyyy/MM/dd") + "' , '" + txt_sandNo.Text + "','" 
             + txt_PayType.ID.Text + "','" + userID.Text + "',  'سداد فاتورة مبيعات ' +'" 
             + txt_PayType.Desc.Text + "' + ' رقم ' + '" + txt_InvNu.Text + "', '" + txt_Check.Text + "' ,'" 
             + Convert.ToString(cmb_Bank.SelectedValue) + "','" + (Check_Date.Value > Check_Date.MinDate ? 
             Check_Date.Value.Date.ToString("yyyy/MM/dd") : Check_Date.MinDate.Date.ToString("yyyy/MM/dd")) + "','" 
             + Convert.ToString(cmb_Pay.SelectedValue) + "','','" + txt_InvNot.Text + "','CR','" + txtStore_ID.Text 
             + "','" +Net_Vat.Text.ToDecimal() + "','" + txt_CashAcc.ID.Text + "','" + txt_InvNu.Text + "','" 
             + paied_amount.Text + "','"+ cashCustomer.Desc.Text +"')");


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
            for (int i = 0; i <= gridInvoice1.dgv1.Rows.Count - 1; i++)
            {
                if (gridInvoice1.dgv1.Rows[i].Cells[0].Value != null && gridInvoice1.dgv1.Rows[i].Cells[5].Value.ToString().ToDecimal() > 0)
                    //&& dGV_Item.Rows[i].Cells[6].Value.ToString().ToDecimal() > 0)
                {
            dal.Execute_1(@" insert into wh_material_transaction (SER_NO,Branch_code,TRANSACTION_CODE,Cyear,SANAD_NO,ITEM_NO,QTY_ADD,QTY_TAKE,COST_PRICE,total_disc,DISC_R,DISC_R2,DISC_R3,
            G_DATE,Unit,Local_Price,USER_ID,main_counter,balance,Store_Code,Weight,K_M_TYPE_ITEMS,TAX_IN,TAX_OUT) 
           values( '" + txt_InvNu.Text + "', '" + txtStore_ID.Text + "', '" + Doc_Type.Text + "', '" + txt_InvDate.Value.ToString("yy") +
            "' ,'" + txtMainSer.Text + "','" + gridInvoice1.dgv1.Rows[i].Cells[0].Value.ToString() + "' ,'0','" +
            gridInvoice1.dgv1.Rows[i].Cells[5].Value.ToString().ToDecimal() + "','" + gridInvoice1.dgv1.Rows[i].Cells[15].Value.ToString().ToDecimal() +
            "','" + ((gridInvoice1.dgv1.Rows[i].Cells[9].Value.ToString().ToDecimal()/ gridInvoice1.dgv1.Rows[i].Cells[8].Value.ToString().ToDecimal()) + disc_Rate.Text.ToDecimal())*100 +
            "' ,'" + (gridInvoice1.dgv1.Rows[i].Cells[9].Value.ToString().ToDecimal() / gridInvoice1.dgv1.Rows[i].Cells[8].Value.ToString().ToDecimal())*100 + "' ,'0','" + (disc_Rate.Text.ToDecimal())*100 +
            "', '" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + gridInvoice1.dgv1.Rows[i].Cells[3].Value.ToString()+
            "' ,'" + gridInvoice1.dgv1.Rows[i].Cells[6].Value.ToString().ToDecimal() + "' , '" + userID.Text + "','"+
            gridInvoice1.dgv1.Rows[i].Index+"', '" + gridInvoice1.dgv1.Rows[i].Cells[4].Value.ToString().ToDecimal() + "', '" + txtStore_ID.Text +
            "','" + gridInvoice1.dgv1.Rows[i].Cells[5].Value.ToString().ToDecimal() + "','" + gridInvoice1.dgv1.Rows[i].Cells[16].Value.ToString() +
            "' ,'0','" + gridInvoice1.dgv1.Rows[i].Cells[12].Value.ToString().ToDecimal() + "')");

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

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            string printModel = Properties.Settings.Default.inv_print;
            if (printModel == "1")
            {
                RPT.Rpt_inv reportInv = new RPT.Rpt_inv();
                RPT.Form1 frminv = new RPT.Form1();
                reportInv.SetDataSource(dal.getDataTabl("get_invDetails", txt_InvNu.Text, Doc_Type.Text, txt_InvDate.Value.Year.ToString()));
                //reportInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;
                //reportInv.PrintToPrinter(1, false, 0, 15);
                frminv.crystalReportViewer1.ReportSource = reportInv;
                frminv.ShowDialog();
            }

            else

            {
                RPT.Rpt_inv_1 reportInv = new RPT.Rpt_inv_1();
                RPT.Form1 frminv = new RPT.Form1();
                reportInv.SetDataSource(dal.getDataTabl("get_invDetails", txt_InvNu.Text, Doc_Type.Text, txt_InvDate.Value.Year.ToString()));
                //reportInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;
                //reportInv.PrintToPrinter(1, false, 0, 15);
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
            // Qutation_list_frm ord = new Qutation_list_frm();
            //ord.ShowDialog();

            //string invnu = Convert.ToString(ord.dg_orders_list.CurrentRow.Cells[0].Value);
            //string Trans_id = Convert.ToString(ord.dg_orders_list.CurrentRow.Cells[7].Value);
            // DateTime Cyear = DateTime.Parse(ord.dg_orders_list.CurrentRow.Cells[1].Value.ToString());
            //string cyear_ = Cyear.Year.ToString();
            // DataTable dtMain_ = dal.getDataTabl("get_Qutation", txt_Qutation.Text, Properties.Settings.Default.BranchId, "Qut", txt_InvDate.Value.Year.ToString());

            DataTable dtMain_ = dal.getDataTabl_1(@"SELECT Qutation_Tbl.*,Payment_name,dbo.Tafkeet(InvNetTotal,'SAR')as tfqtAR,saleman,C_Name,branch_name
            FROM Qutation_Tbl inner join wh_Payment_type on wh_Payment_type.Payment_type=Qutation_Tbl.Payment_Type
            inner join Customer_Tbl on Customer_Tbl.C_ID=Qutation_Tbl.custID
            inner join wh_BRANCHES on wh_BRANCHES.Branch_code=Qutation_Tbl.DepID
            where Qutation_Tbl.SerNO='" + txt_Qutation.Text + "' and DepID='" + Properties.Settings.Default.BranchId + "' and Qutation_Tbl.TransID='Qut' and Qutation_Tbl.Cyear='" + txt_InvDate.Value.Year.ToString() + "'");


            txt_InvNu.Text = dtMain_.Rows[0][0].ToString();
            txt_InvDate.Text = dtMain_.Rows[0][1].ToString();
            txt_Acc.ID.Text = dtMain_.Rows[0][2].ToString();
            txt_InvNot.Text = dtMain_.Rows[0][3].ToString();
            TxtTotal.Text = dtMain_.Rows[0][4].ToString();
            txtDiscount.Text = dtMain_.Rows[0][5].ToString();
            txtNetTotal.Text = dtMain_.Rows[0][6].ToString();
            txtStore_ID.Text = dtMain_.Rows[0][7].ToString();
            txt_PayType.ID.Text = dtMain_.Rows[0][11].ToString();
            // txt_Attn.Text = dtMain_.Rows[0][12].ToString();
            txt_custTel.Text = dtMain_.Rows[0][13].ToString();
            txt_custFax.Text = dtMain_.Rows[0][15].ToString();
            txt_CustEmail.Text = dtMain_.Rows[0][16].ToString();
            //txt_`.Text = dtMain_.Rows[0][17].ToString();
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

            gridInvoice1.dgv1.DataSource = dt;
            //resizeDG();

        }

        //private void dGV_Item_CellEndEdit(object sender, DataGridViewCellEventArgs e)

        //{
        //    //try
        //    {
        //        int i = dGV_Item_.CurrentCell.RowIndex;
        //        int j = dGV_Item_.CurrentCell.ColumnIndex;
        //       //-------------------------------------------------------------------//
        //        if (j == 0)
        //        {
        //            //=============================================================//
        //            if (dGV_Item_.Rows[i].Cells[0].Value != null)
        //            {
        //                DataTable dt = new DataTable();
        //                dt = dal.getDataTabl("get_product_name", dGV_Item_.Rows[i].Cells[0].Value.ToString(), Properties.Settings.Default.CoId);


        //                if (dt.Rows.Count > 0)
        //                {
        //                    dGV_Item_.Rows[i].Cells[0].Value = dt.Rows[0][0].ToString();
        //                    dGV_Item_.Rows[i].Cells[1].Value = dt.Rows[0][2].ToString();
        //                    dGV_Item_.Rows[i].Cells[2].Value = dt.Rows[0][8].ToString();
        //                    dGV_Item_.Rows[i].Cells[8].Value = dt.Rows[0][6].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                  //--------------------------- احضار الرصيد والكلفة----------------------//
        //                    DataTable dt_B_c = new DataTable();
        //                    dt_B_c=dal.getDataTabl ("getBalnceAndCost",dGV_Item_.Rows[i].Cells[0].Value.ToString(), Properties.Settings.Default.BranchId);
        //                if (dt_B_c.Rows.Count > 0)
        //                {
        //                    dGV_Item_.Rows[i].Cells[10].Value =dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N"+Properties.Settings.Default.digitNo_);
        //                    dGV_Item_.Rows[i].Cells[11].Value =dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N"+Properties.Settings.Default.digitNo_);
        //                    old_balance = Convert.ToDecimal(dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                    old_cost = Convert.ToDecimal(dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                }
        //                    else
        //                {
        //                     dGV_Item_.Rows[i].Cells[10].Value ="0".ToDecimal().ToString("N"+Properties.Settings.Default.digitNo_);
        //                     dGV_Item_.Rows[i].Cells[11].Value = "0".ToDecimal().ToString("N"+Properties.Settings.Default.digitNo_);
        //                     old_balance = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                     old_cost = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                }
        //                   //--------------------------- نهاية احضار الرصيد والكلفة----------------------//

        //                    dGV_Item_.Rows[i].Cells[3].Value = 0;
        //                    dGV_Item_.Rows[i].Cells[4].Value = 0;
        //                    dGV_Item_.Rows[i].Cells[5].Value = 0;
        //                    dGV_Item_.Rows[i].Cells[6].Value = 0;
        //                    dGV_Item_.Rows[i].Cells[7].Value = 0;
        //                    dGV_Item_.Rows[i].Cells[9].Value = 0;
        //                    SendKeys.Send("{up}");
        //                    dGV_Item_.CurrentCell = dGV_Item_[j + 3, i];
        //                }
        //                else
        //                {

        //                    dGV_Item_.Rows[i].Cells[0].Value = null;
        //                    dGV_Item_.Rows[i].Cells[1].Value = null;
        //                    PL.product_list_frm F = new product_list_frm();
        //                    F.ShowDialog();
        //                    if (F.clos_ == 1)
        //                    {
        //                    int ii = F.dGV_pro_list.CurrentCell.RowIndex;
        //                    dGV_Item_.Rows[i].Cells[0].Value = F.dGV_pro_list.Rows[ii].Cells[0].Value;
        //                    dGV_Item_.Rows[i].Cells[1].Value = F.dGV_pro_list.Rows[ii].Cells[2].Value;
        //                    dGV_Item_.Rows[i].Cells[2].Value = F.dGV_pro_list.Rows[ii].Cells[8].Value;
        //                   dGV_Item_.Rows[i].Cells[8].Value = F.dGV_pro_list.Rows[ii].Cells[6].Value.ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);

        //                   //--------------------------- احضار الرصيد والكلفة----------------------//
        //                   DataTable dt_B_c = new DataTable();
        //                   dt_B_c = dal.getDataTabl("getBalnceAndCost", F.dGV_pro_list.Rows[ii].Cells[0].Value, Properties.Settings.Default.BranchId);
        //                   if (dt_B_c.Rows.Count > 0)
        //                   {
        //                       dGV_Item_.Rows[i].Cells[10].Value = dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                       dGV_Item_.Rows[i].Cells[11].Value = dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                       old_balance = Convert.ToDecimal(dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                       old_cost = Convert.ToDecimal(dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                   }
        //                   else
        //                   {
        //                       dGV_Item_.Rows[i].Cells[10].Value = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                       dGV_Item_.Rows[i].Cells[11].Value = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                       old_balance = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                       old_cost = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                   }
        //                   //--------------------------- نهاية احضار الرصيد والكلفة----------------------//

        //                    //dGV_Item.Rows[i].Cells[10].Value = F.dGV_pro_list.Rows[ii].Cells[4].Value.ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                    //dGV_Item.Rows[i].Cells[11].Value = F.dGV_pro_list.Rows[ii].Cells[5].Value.ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);

        //                    //old_balance = F.dGV_pro_list.Rows[ii].Cells[4].Value.ToString().ToDecimal();
        //                    //old_cost = F.dGV_pro_list.Rows[ii].Cells[5].Value.ToString().ToDecimal();
        //                    dGV_Item_.Rows[i].Cells[3].Value = 0;
        //                    dGV_Item_.Rows[i].Cells[4].Value = 0;
        //                    dGV_Item_.Rows[i].Cells[5].Value = 0;
        //                    dGV_Item_.Rows[i].Cells[6].Value = 0;
        //                    dGV_Item_.Rows[i].Cells[7].Value = 0;
        //                    dGV_Item_.Rows[i].Cells[9].Value = 0;
        //                    SendKeys.Send("{up}");
        //                    dGV_Item_.CurrentCell = dGV_Item_[j + 3, i];
        //                }
        //                }

        //            }
        //            else
        //            {
        //                dGV_Item_.Rows[i].Cells[0].Value = null;
        //                dGV_Item_.Rows[i].Cells[1].Value = null;
        //                PL.product_list_frm F = new product_list_frm();
        //                F.ShowDialog();
        //                if (F.clos_ == 1)
        //                {
        //                int ii = F.dGV_pro_list.CurrentCell.RowIndex;
        //                dGV_Item_.Rows[i].Cells[0].Value = F.dGV_pro_list.Rows[ii].Cells[0].Value;
        //                dGV_Item_.Rows[i].Cells[1].Value = F.dGV_pro_list.Rows[ii].Cells[2].Value;
        //                dGV_Item_.Rows[i].Cells[2].Value = F.dGV_pro_list.Rows[ii].Cells[8].Value;
        //                dGV_Item_.Rows[i].Cells[8].Value = F.dGV_pro_list.Rows[ii].Cells[6].Value.ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);

        //                //--------------------------- احضار الرصيد والكلفة----------------------//
        //                DataTable dt_B_c = new DataTable();
        //                dt_B_c = dal.getDataTabl("getBalnceAndCost", F.dGV_pro_list.Rows[ii].Cells[0].Value, Properties.Settings.Default.BranchId);
        //                if (dt_B_c.Rows.Count > 0)
        //                {
        //                    dGV_Item_.Rows[i].Cells[10].Value = dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                    dGV_Item_.Rows[i].Cells[11].Value = dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                    old_balance = Convert.ToDecimal(dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                    old_cost = Convert.ToDecimal(dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                }
        //                else
        //                {
        //                    dGV_Item_.Rows[i].Cells[10].Value = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                    dGV_Item_.Rows[i].Cells[11].Value = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                    old_balance = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                    old_cost = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                }
        //                //--------------------------- نهاية احضار الرصيد والكلفة----------------------//
        //                dGV_Item_.Rows[i].Cells[3].Value = 0;
        //                dGV_Item_.Rows[i].Cells[4].Value = 0;
        //                dGV_Item_.Rows[i].Cells[5].Value = 0;
        //                dGV_Item_.Rows[i].Cells[6].Value = 0;
        //                dGV_Item_.Rows[i].Cells[7].Value = 0;
        //                dGV_Item_.Rows[i].Cells[9].Value = 0;
        //                SendKeys.Send("{up}");
        //                dGV_Item_.CurrentCell = dGV_Item_[j + 3, i];
        //            }

        //            }

        //        }

        //        else
        //        {

        //            if (j == 3 || j == 4 || j == 6)
        //            {

        //                decimal Qty_ = Convert.ToDecimal(dGV_Item_.Rows[i].Cells[3].Value.ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                    decimal Price_ = Convert.ToDecimal(dGV_Item_.Rows[i].Cells[4].Value.ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                    decimal discount_ = Convert.ToDecimal(dGV_Item_.Rows[i].Cells[6].Value.ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                    decimal wight_ = Convert.ToDecimal(dGV_Item_.Rows[i].Cells[8].Value.ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));

        //                    dGV_Item_.Rows[i].Cells[3].Value = Qty_.ToString("N" + Properties.Settings.Default.digitNo_);
        //                    dGV_Item_.Rows[i].Cells[4].Value = Price_.ToString("N" + Properties.Settings.Default.digitNo_);
        //                    dGV_Item_.Rows[i].Cells[6].Value = discount_.ToString("N" + Properties.Settings.Default.digitNo_);

        //                    dGV_Item_.Rows[i].Cells[5].Value = (Qty_ * Price_).ToString("N" + Properties.Settings.Default.digitNo_);
        //                    dGV_Item_.Rows[i].Cells[7].Value = ((Qty_ * Price_) - discount_).ToString("N" + Properties.Settings.Default.digitNo_);
        //                    dGV_Item_.Rows[i].Cells[9].Value = (Qty_ * wight_).ToString("N" + Properties.Settings.Default.digitNo_);
        //                    dGV_Item_.Rows[i].Cells[12].Value = (Qty_ * old_cost).ToString("N" + Properties.Settings.Default.digitNo_);

        //                if (j == 3 )
        //                    {
        //                        DataTable dt_B_c = new DataTable();
        //                        dt_B_c = dal.getDataTabl("getBalnceAndCost", dGV_Item_.Rows[i].Cells[0].Value, Properties.Settings.Default.BranchId);
        //                        if (dt_B_c.Rows.Count > 0)
        //                        {
        //                            dGV_Item_.Rows[i].Cells[10].Value = dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                            dGV_Item_.Rows[i].Cells[11].Value = dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                            old_balance = Convert.ToDecimal(dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                            old_cost = Convert.ToDecimal(dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                        }
        //                        else
        //                        {
        //                            dGV_Item_.Rows[i].Cells[10].Value = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                            dGV_Item_.Rows[i].Cells[11].Value = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                            old_balance = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                            old_cost = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                        }
        //                        new_balance = old_balance - Qty_;
        //                        new_cost = old_cost;
        //                        dGV_Item_.Rows[i].Cells[10].Value = new_balance.ToString("N" + Properties.Settings.Default.digitNo_);
        //                        dGV_Item_.Rows[i].Cells[11].Value = new_cost.ToString("N" + Properties.Settings.Default.digitNo_);
        //                        SendKeys.Send("{up}");
        //                        dGV_Item_.CurrentCell = dGV_Item_[j + 1, i];
        //                    }

        //                  else if (j == 4)
        //                    {


        //                        SendKeys.Send("{up}");
        //                        dGV_Item_.CurrentCell = dGV_Item_[j +2, i];
        //                    }

        //                    else if (j == 6)
        //                    {
        //                        dGV_Item_.CurrentCell = dGV_Item_[0, i + 1];
        //                    }
        //                }


        //        }
        //        //---------------------------------------------------------------------//


        //        total_inv();
        //    //}
        //    //catch
        //    //{
        //    }


        //}

        //private void dGV_Item_KeyDown(object sender, KeyEventArgs e)


        //{


        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        e.SuppressKeyPress = true;
        //        var iCol = dGV_Item_.CurrentCell.ColumnIndex;
        //        var iRow = dGV_Item_.CurrentCell.RowIndex;
        //        if (iCol == dGV_Item_.Columns.Count - 7)
        //        {
        //            //if (iRow < dGV_Item.Rows.Count - 1)
        //            //{
        //                dGV_Item_.CurrentCell = dGV_Item_[0, iRow + 1];
        //            //}
        //        }
        //        else
        //        {
        //            if (iCol == 0)

        //            {
        //                if (dGV_Item_.Rows[iRow].Cells[0].Value != null)
        //                {
        //                    dGV_Item_.CurrentCell = dGV_Item_[iCol + 3, iRow];
        //                    //--------------------------- احضار الرصيد والكلفة----------------------//
        //                    DataTable dt_B_c = new DataTable();
        //                    dt_B_c = dal.getDataTabl("getBalnceAndCost", dGV_Item_.Rows[iRow].Cells[0].Value, Properties.Settings.Default.BranchId);
        //                    if (dt_B_c.Rows.Count > 0)
        //                    {

        //                        old_balance = Convert.ToDecimal(dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                        old_cost = Convert.ToDecimal(dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                        dGV_Item_.Rows[iRow].Cells[10].Value = old_balance - dGV_Item_.Rows[iRow].Cells[3].Value.ToString().ToDecimal();
        //                        dGV_Item_.Rows[iRow].Cells[11].Value = dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                    }
        //                    else
        //                    {
        //                        dGV_Item_.Rows[iRow].Cells[10].Value = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                        dGV_Item_.Rows[iRow].Cells[11].Value = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                        old_balance = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                        old_cost = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                    }
        //                    //--------------------------- نهاية احضار الرصيد والكلفة----------------------//
        //                }
        //                else
        //                {
        //                    dGV_Item_.Rows[iRow].Cells[0].Value = null;
        //                    dGV_Item_.Rows[iRow].Cells[1].Value = null;
        //                    PL.product_list_frm F = new product_list_frm();
        //                    F.ShowDialog();
        //                    if (F.clos_ == 1)
        //                    {
        //                    int ii = F.dGV_pro_list.CurrentCell.RowIndex;
        //                    dGV_Item_.Rows[iRow].Cells[0].Value = F.dGV_pro_list.Rows[ii].Cells[0].Value;
        //                    dGV_Item_.Rows[iRow].Cells[1].Value = F.dGV_pro_list.Rows[ii].Cells[2].Value;
        //                    dGV_Item_.Rows[iRow].Cells[2].Value = F.dGV_pro_list.Rows[ii].Cells[8].Value;
        //                    dGV_Item_.Rows[iRow].Cells[8].Value = F.dGV_pro_list.Rows[ii].Cells[6].Value.ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                    //--------------------------- احضار الرصيد والكلفة----------------------//
        //                    DataTable dt_B_c = new DataTable();
        //                    dt_B_c = dal.getDataTabl("getBalnceAndCost", F.dGV_pro_list.Rows[ii].Cells[0].Value, Properties.Settings.Default.BranchId);
        //                    if (dt_B_c.Rows.Count > 0)
        //                    {
        //                        dGV_Item_.Rows[iRow].Cells[10].Value = dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                        dGV_Item_.Rows[iRow].Cells[11].Value = dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                        old_balance = Convert.ToDecimal(dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                        old_cost = Convert.ToDecimal(dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                    }
        //                    else
        //                    {
        //                        dGV_Item_.Rows[iRow].Cells[10].Value = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                        dGV_Item_.Rows[iRow].Cells[11].Value = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
        //                        old_balance=Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                        old_cost = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
        //                    }
        //                    //--------------------------- نهاية احضار الرصيد والكلفة----------------------//
        //                    dGV_Item_.Rows[iRow].Cells[3].Value = 0;
        //                    dGV_Item_.Rows[iRow].Cells[4].Value = 0;
        //                    dGV_Item_.Rows[iRow].Cells[5].Value = 0;
        //                    dGV_Item_.Rows[iRow].Cells[6].Value = 0;
        //                    dGV_Item_.Rows[iRow].Cells[7].Value = 0;
        //                    dGV_Item_.Rows[iRow].Cells[9].Value = 0;

        //                    dGV_Item_.CurrentCell = dGV_Item_[iCol + 3, iRow];
        //                }
        //                }

        //            }
        //            else
        //            {
        //                dGV_Item_.CurrentCell = dGV_Item_[iCol + 1, iRow];
        //            }
        //        }
        //    }



        //}

        private void invoice_frm_Load(object sender, EventArgs e)
        {
            btn_search.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            txt_Acc.txtMainAcc.Text = "123";
            txt_Acc.txtFinal.Text = "1";
            txt_Acc.branchID.Text = Properties.Settings.Default.BranchAccID;
            
            DataTable Dt_1 = dal.getDataTabl_1(@"SELECT B.SALES_ACC_NO , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.SALES_ACC_NO=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code where B.BRANCH_code= '" + Properties.Settings.Default.BranchId+"'");
            if (Dt_1.Rows.Count > 0)
            {
                txtAcc2.ID.Text = Dt_1.Rows[0][0].ToString();
            }
            DataTable Dt_2 = dal.getDataTabl_1(@"SELECT B.Cash_acc_no , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.Cash_acc_no=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code where B.BRANCH_code= '" + Properties.Settings.Default.BranchId + "'");
            if (Dt_2.Rows.Count > 0)
            {
                txt_CashAcc.ID.Text = Dt_2.Rows[0][0].ToString();
            }

            DataTable Dt_3 = dal.getDataTabl_1(@"SELECT B.K_M_ACC_NO_SALES , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.K_M_ACC_NO_SALES=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code where B.BRANCH_code= '" + Properties.Settings.Default.BranchId + "'");
            if (Dt_3.Rows.Count>0)
            {
                txt_vatAcc.ID.Text = Dt_3.Rows[0][0].ToString();
            }
            txt_cyear.Text = Properties.Settings.Default.C_year;
            //txt_CashAcc.ID.Text = dal.getDataTabl_1("SELECT* FROM wh_BRANCHES where  Branch_code='" + Properties.Settings.Default.BranchId + "'").Rows[0][14].ToString();
           // Vat_acc.Text = dal.getDataTabl_1("SELECT* FROM wh_BRANCHES where  Branch_code='" + Properties.Settings.Default.BranchId + "'").Rows[0][87].ToString();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Add_Jor()
        {
            string cyear = txt_InvDate.Value.Year.ToString("yy");
            string H_Date = date_.GregToHijri(txt_InvDate.Text);
           

            dal.Execute_1(@"INSERT INTO daily_transaction ( ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh,
            balance, h_date,g_date,sanad_no, SANAD_TYPE, sp_ser_no, user_name, desc2,POASTING,SOURCE_CODE, Wh_Branch_Code, MAIN_SER_NO )
            Values('" + acc_year.Text+"', '"+txt_Acc.ID.Text+"', '"+ txtBranch_Id.Text + "','" + AccSer_No.Text + "','" + 
            Uc_Cost.ID.Text + "','" + NetValue.Text + "','" + 0 + "','" + NetValue.Text + "','" + H_Date + "','" + 
            txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txt_InvNu.Text + "','" + Doc_Type.Text + "','" + Doc_Type.Text + txt_InvNu.Text + "','" + 
            userID.Text + "','" + "فاتورة مبيعات " + txt_PayType.Desc.Text + " رقم " + txt_InvNu.Text + "','0','" + Doc_Type.Text + "','" + 
            txtStore_ID.Text + "','" + AccSer_No.Text + "')");


            dal.Execute_1(@"INSERT INTO daily_transaction ( ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh,
            balance, h_date,g_date,sanad_no, SANAD_TYPE, sp_ser_no, user_name, desc2,POASTING, SOURCE_CODE, Wh_Branch_Code, MAIN_SER_NO )
            Values('" + acc_year.Text + "', '" + txtAcc2.ID.Text + "', '" + txtBranch_Id.Text + "','" + AccSer_No.Text + "','" +
            Uc_Cost.ID.Text + "','" + 0 + "','" + txtNetTotal.Text.ToDecimal() + "','" + -txtNetTotal.Text.ToDecimal() + "','" + H_Date + "','" +
            txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txt_InvNu.Text + "','" + Doc_Type.Text + "','" + Doc_Type.Text + txt_InvNu.Text + "','" +
            userID.Text + "','" + "فاتورة مبيعات " + txt_PayType.Desc.Text + " رقم " + txt_InvNu.Text + "','0','" + Doc_Type.Text + "','" +
            txtStore_ID.Text + "','" + AccSer_No.Text + "')");

            dal.Execute_1(@"INSERT INTO daily_transaction ( ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh,
            balance, h_date,g_date,sanad_no, SANAD_TYPE, sp_ser_no, user_name, desc2,POASTING, SOURCE_CODE, Wh_Branch_Code, MAIN_SER_NO )
            Values('" + acc_year.Text + "', '" + txt_vatAcc.ID.Text + "', '" + txtBranch_Id.Text + "','" + AccSer_No.Text + "','" +
            Uc_Cost.ID.Text + "','" + 0 + "','" + Net_Vat.Text.ToDecimal() + "','" + -Net_Vat.Text.ToDecimal() + "','" + H_Date + "','" +
            txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txt_InvNu.Text + "','" + Doc_Type.Text + "','" + Doc_Type.Text + txt_InvNu.Text + "','" +
            userID.Text + "','" + "ضريبة فاتورة مبيعات " + txt_PayType.Desc.Text + " رقم " + txt_InvNu.Text + "','0','" + Doc_Type.Text + "','" +
            txtStore_ID.Text + "','" + AccSer_No.Text + "')");




        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

         
            DataTable dtMain_ = dal.getDataTabl_1(@"SELECT * FROM wh_Po_Cot_inv_data
                      where Ser_NO='" + txt_Qutation.Text + "' and Branch_code='" + Properties.Settings.Default.BranchId +
                      "' and Transaction_code ='CO' and Cyear='" + txt_InvDate.Value.ToString("yy") + "'");


    
            txt_Acc.ID.Text = dtMain_.Rows[0][8].ToString();
            txt_InvNot.Text = dtMain_.Rows[0]["Costomer_Notes"].ToString();
            txtStore_ID.Text = dtMain_.Rows[0]["Branch_code"].ToString();
            txt_PayType.ID.Text = dtMain_.Rows[0]["Payment_Type"].ToString();
            txt_custTel.Text = dtMain_.Rows[0]["Costomer_Phone"].ToString();
            txt_custFax.Text = dtMain_.Rows[0]["Costmer_fax"].ToString();
            txt_CustEmail.Text = dtMain_.Rows[0]["E_mail"].ToString();

            // DataTable dt_ = dal.getDataTabl("Get_Qutation_Details", txt_Qutation.Text, Properties.Settings.Default.BranchId, "Qut", txt_InvDate.Value.Year.ToString());

            DataTable dt_ = dal.getDataTabl_1(@" SELECT A.*,M.descr,M.Descr_eng,Weight,k.KM_RATIO
            FROM wh_Po_Cot_MATERIAL_TRANSACTION As A inner join wh_main_master As M on A.item_no=M.item_no 
			inner join KM_MATERIAL_CODE as K on K.KM_CODE=A.K_M_TYPE_ITEMS
            where A.SER_NO='" + txt_Qutation.Text + "' and A.Branch_code='" + Properties.Settings.Default.BranchId + "' and A.TRANSACTION_CODE='CO' and A.Cyear='" + txt_InvDate.Value.ToString("yy") + "'");

            dt.Clear();
            int i = 0;
            DataRow row = null;
            foreach (DataRow r in dt_.Rows)
            {

                row = dt.NewRow();
                row[0] = dt_.Rows[i]["ITEM_NO"];
                row[1] = dt_.Rows[i]["descr"];
                row[2] = dt_.Rows[i]["DETAILS"];
                row[3] = dt_.Rows[i]["Unit"];
                row[4] = dt_.Rows[i]["Weight"];
                row[5] = dt_.Rows[i]["QTY_TAKE"];
                row[6] = dt_.Rows[i]["Local_Price"];
                row[7] = '0';
                row[8] = dt_.Rows[i]["QTY_TAKE"].ToString().ToDecimal() * dt_.Rows[i]["Local_Price"].ToString().ToDecimal();
                row[9] = '0';
                row[10] = dt_.Rows[i]["QTY_TAKE"].ToString().ToDecimal() * dt_.Rows[i]["Local_Price"].ToString().ToDecimal();
                row[11] = dt_.Rows[i]["KM_RATIO"];
                row[12] = dt_.Rows[i]["TAX_OUT"];
                row[13] = dt_.Rows[i]["Weight"].ToString().ToDecimal() * dt_.Rows[i]["Local_Price"].ToString().ToDecimal();
                row[14] = '0';
                row[15] = '0';
                row[16] = dt_.Rows[i]["K_M_TYPE_ITEMS"];
                //row[9] = dt_.Rows[i][2];


                dt.Rows.Add(row);
                i = i + 1;
            }

            gridInvoice1.dgv1.DataSource = dt;
            gridInvoice1.total_inv();

        }

        private void txtAcc_2_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void txtStore_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void txtStore_ID_TextChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    DataTable dt = dal.getDataTabl("GetStores", txtStore_ID.Text.ToString());
            //    if (dt.Rows.Count > 0)
            //    {
            //        // txtStore_Desc.Text = dt.Rows[0][2].ToString();
            //        txtAcc2_ID.Text = dt.Rows[0][9].ToString();
            //        txt_CashAcc_ID.Text = dt.Rows[0][12].ToString();
            //        txt_CustAcc_ID.Text = dt.Rows[0][13].ToString();
            //    }
            //    else
            //    {
            //        // txtStore_Desc.Text = "";
            //    }
            //}
            //catch
            //{

            //}
        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void TxtDisc_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    clculat_amount();

            //    if (btntype == "0")
            //    {
            //        if (chb1.Checked == false) {
            //            if (TxtPrice.Value <= 0)
            //            {
            //                MessageBox.Show("تأكد من السعر", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                return;
            //            }
            //            for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            //            {
            //                if (dGV_Item.Rows[i].Cells[0].Value.ToString() == TxtId.Text)
            //                {
            //                    MessageBox.Show("هذا الصنف مضاف من قبل", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                    return;
            //                }
            //            }
            //        }
            //        addrow_new();
            //        btntype = "0";


            //    }
            //    else if (btntype == "1")
            //    {
            //        editrow();
            //        btntype = "0";

            //    }
            //    chb1.Checked = false;
            //}
        }


       
      



   

     
        void creatDattable()
        {
            dt.Columns.Add("رقم الصنف");
            dt.Columns.Add(" اسم الصنف");
            dt.Columns.Add(" الوصف");
            dt.Columns.Add(" الوحدة");
            dt.Columns.Add("الوزن");
            dt.Columns.Add(" الكمية");
            dt.Columns.Add("السعر");
            dt.Columns.Add("سعر الطن");
            dt.Columns.Add(" الاجمالي");
            dt.Columns.Add("الخصم");
            dt.Columns.Add("الصافي");
            dt.Columns.Add("نسبة الضريبة");
            dt.Columns.Add("مبلغ الضريبة");
            dt.Columns.Add("اجمالي الوزن");
            dt.Columns.Add("الرصيد");
            dt.Columns.Add("التكلفة");
            dt.Columns.Add("كود القيمة المضافة");
            gridInvoice1.dgv1.DataSource = dt;
        }

    
        
        private void print_sand_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.Form1 frmSand = new RPT.Form1();
                RPT.CrystalReport5 print_sand = new RPT.CrystalReport5();
                DataTable dt1 = new DataTable();

                dt1 = dal.getDataTabl_1(@"select Sands_tbl.*,payer2.PAYER_NAME,p2.PAYER_NAME,bank_name,pay_name from Sands_tbl
            inner join payer2 on sands_tbl.Acc_no=payer2.Acc_No
            inner join payer2 as p2 on sands_tbl.Cash_acc=p2.Acc_No
            left join SHEEK_BANKS_TYPE on bank_no=sheek_bank
            left join pay_method on pay_id=sheek_or_cash
            where sanad_no='" + txt_sandNo.Text + "' and source_code='CR'");

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

        private void txtNetTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cust_Vat_Rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel5_Click(object sender, EventArgs e)
        {

        }

        private void disc_Rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Srearch_Click(object sender, EventArgs e)
        {
            DataTable dt_search = dal.getDataTabl_1(@"select Ser_no ,Branch_code ,Transaction_code ,Cyear ,G_date ,ACC_TYPE,Acc_no ,Acc_Branch_code,Payment_Type,Sales_man_Id
            ,Inv_no,Inv_date,acc_serial_no,User_id,NetAmount,PanyedAmount,Cash_costomer_name ,total_cost,Inv_Notes,Costmer_No
            ,K_M_ACC_NO,K_M_Credit_TAX,K_M_Debit_TAX,COSTMER_K_M_NO,KM_CODE_ACC,MAIN_KM_CODE  
            from wh_inv_data where Cyear ='"+txt_cyear.Text+"' and Transaction_code = '"+searchTransaction.Text +"' and Branch_code ='"+txtStore_ID.Text+"'  and  Ser_no = '"+txtsearch.Text.Trim()+"'");

            if(dt_search.Rows.Count > 0)
            {
                txt_InvNot.Text = dt_search.Rows[0]["Ser_no"].ToString();
                txt_InvDate.Text = dt_search.Rows[0]["G_date"].ToString();
                Doc_Type.Text = dt_search.Rows[0]["Transaction_code"].ToString();
                txt_PayType.ID.Text = dt_search.Rows[0]["Payment_Type"].ToString();
            }
            groupBox1.Visible = false;
        }

        private void BtnAttache_Click(object sender, EventArgs e)
        {
            ////string date = Program.ConvertDateCalendar(txt_InvDate.Value, "Hijri", "en-US");
            //MessageBox.Show(date);
        }

        private void PayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(PayType.SelectedValue).StartsWith("1") )
            {
                searchTransaction.Text = "xsc";
            }
            else if (Convert.ToString(PayType.SelectedValue) == "2")
            {
                searchTransaction.Text = "xsd";
            }
        }

        private void Uc_Customer_Load(object sender, EventArgs e)
        {

            DataTable dt_M = dal.getDataTabl_1(@"select Costmers_acc_no,Suppliers_acc_no,Cash_acc_no FROM wh_BRANCHES where BRANCH_code like '" + Properties.Settings.Default.BranchId + "%'");
            if (dt_M.Rows.Count > 0)
            {
                string Acc_main = dt_M.Rows[0][0].ToString();
                string Acc_cash = dt_M.Rows[0][2].ToString();
                DataTable dt_cust = dal.getDataTabl_1(@"select P.*,A.MAIN_KM_CODE,a.MAIN_KM_DESC,b.KM_RATIO,b.KM_CODE FROM payer2 As P left join KM_MAIN_ACC_CODE as A on  ISNULL(NULLIF(P.KM_CODE_Sales, ''), 11) = A.MAIN_KM_CODE
                left join  KM_ACC_CODE as b on b.KM_CODE = a.KM_CODE where P.BRANCH_code like '" + Properties.Settings.Default.BranchId + "%' and P.ACC_NO = '" + txt_Acc.ID.Text + "' and(P.ACC_NO like '" + Acc_main + "%' or P.ACC_NO like '" + Acc_cash + "%') and P.t_final ='1'");
                txtBranch_Id.Text = Properties.Settings.Default.BranchId;
                if (dt_cust.Rows.Count > 0)
                {
                    if (txt_Acc.ID.Text == Acc_cash)
                    {
                        cashCustomer.Enabled = true;
                        txt_PayType.ID.Text = "11";
                        txt_PayType.Enabled = false;
                        Vat_Class.Text = dt_cust.Rows[0][68].ToString();
                        Vat_Class_Desc.Text = dt_cust.Rows[0][69].ToString();
                        if (dt_cust.Rows[0][70].ToString() == string.Empty)
                        { Cust_Vat_Rate.Text = "0.05"; }
                        else
                        {
                            Cust_Vat_Rate.Text = dt_cust.Rows[0][70].ToString().ToDecimal().ToString("N2");
                        }
                        txtKmCode.Text = dt_cust.Rows[0][71].ToString();
                    }
                    else
                    {
                        cashCustomer.Enabled = false;
                        txt_PayType.ID.Text = "2";
                        txt_PayType.Enabled = true;

                        txt_custTel.Text = dt_cust.Rows[0][14].ToString();
                        txt_address.Text = dt_cust.Rows[0][11].ToString();
                        txt_custFax.Text = dt_cust.Rows[0][16].ToString();
                        txt_CustEmail.Text = dt_cust.Rows[0][15].ToString();
                        txt_BoBox.Text = dt_cust.Rows[0][12].ToString();
                        txt_area_code.Text = dt_cust.Rows[0][19].ToString();
                        Cust_Vat_No.Text = dt_cust.Rows[0][60].ToString();
                        Vat_Class.Text = dt_cust.Rows[0][68].ToString();
                        Vat_Class_Desc.Text = dt_cust.Rows[0][69].ToString();
                        if (dt_cust.Rows[0][70].ToString() == string.Empty)
                        { Cust_Vat_Rate.Text = "0.05"; }
                        else
                        {
                            Cust_Vat_Rate.Text = dt_cust.Rows[0][70].ToString().ToDecimal().ToString("N2");
                        }
                        txtKmCode.Text = dt_cust.Rows[0][71].ToString();
                    }
                }
                else
                {
                    cashCustomer.Enabled = false;
                    txt_custTel.Clear();
                    txt_address.Clear();
                    txt_custFax.Clear();
                    txt_CustEmail.Clear();
                    txt_BoBox.Clear();
                    txt_area_code.Clear();
                    Cust_Vat_No.Clear();
                    Vat_Class.Clear();
                    Vat_Class_Desc.Clear();
                    Cust_Vat_Rate.Clear();


                }
                gridInvoice1.total_inv();
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

        public override void Search()
        {
            groupBox1.Visible = true;

            base.Search();
        }


    }
}


     