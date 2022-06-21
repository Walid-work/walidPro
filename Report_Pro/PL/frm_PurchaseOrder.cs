using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Report_Pro.PL
{
    public partial class frm_PurchaseOrder : frm_Master
    {
        string btntype = "0";
        string frmType = "ADD";
        Int32 m;
        DataTable dt_Q;
        //string Jor_no;
        string btn_name;
        decimal old_balance, old_cost, new_balance, new_cost;
        Dates date_ = new Dates();

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();




        public frm_PurchaseOrder()
        {

            InitializeComponent();

            comboBox1.DataSource = Enumerable.Range(1983, DateTime.Now.Year - 1983 + 1).ToList();
            comboBox1.SelectedItem = DateTime.Now.Year;

            foreach (DataGridViewRow row in this.dGV_Item.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                dGV_Item.EnableHeadersVisualStyles = false;
            }

            FillComboCurrency();


            creatDattable();
            resizeDG();



            txt_InvSM.Text = Program.salesman;
            txtStore_ID.Text = Properties.Settings.Default.BranchId;
            txtBranch_Id.Text = Properties.Settings.Default.BranchAccID;
            userID.Text = Program.userID;
          
            Payment_Type.DataSource = dal.getDataTabl_1("SELECT * FROM wh_Payment_type");

            if (Properties.Settings.Default.lungh == "0")
            {
                Payment_Type.DisplayMember = "Payment_name";
            }
            else
            {
                Payment_Type.DisplayMember = "Payment_name";
            }
            Payment_Type.ValueMember = "Payment_type";
            Payment_Type.SelectedIndex = -1;

            

          

        }





  


        private void dGV_Item_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            total_inv();
        }




        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dGV_Item.Rows.RemoveAt(dGV_Item.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dGV_Item.Refresh();
            }
            catch
            {
                return;
            }
        }





        private void txt_InvNot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                //Btn_srch_cust.Focus();
            }
        }




        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            total_inv();
        }

        private void get_invSer()
        {
            //try
            //{
                txtMainSer.Text = dal.getDataTabl_1(@"select isnull(PS+1,1) from wh_Serial_MAIN where  Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();
               txt_InvNu.Text = dal.getDataTabl_1(@"select isnull(PS+1,1) from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();
               
            //}
            //catch { }


        }

        private void Payment_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_invSer();
            total_inv();
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
            groupPanel7.Enabled = true;

            dt.Clear();
            dGV_Item.DataSource = null;
            dGV_Item.Refresh();
            dGV_Item.Rows.Clear();


            BSave.Enabled = true;
            txt_InvNot.Focus();
            
        }

        private void BSave_Click(object sender, EventArgs e)
        {

            try
            {
            
                if (txtSupplier.ID.Text == string.Empty)
                {
                    MessageBox.Show("فضلا.. تاكد من اختيار العميل ", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dGV_Item.Rows.Count < 1)
                {
                    MessageBox.Show("فضلا.. تاكد من اختيار الاصناف", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (Payment_Type.SelectedIndex < 0)
                {
                    MessageBox.Show("فضلا.. تاكد من نوع الفاتورة", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtNetTotal.Text.ToDecimal() <= 0)
                {
                    MessageBox.Show("لايمكن حفظ فاتورة بقيمة اقل من او ياو", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               

              
              

                get_invSer();

            
                AddInv();
                AddInvDetails();
              
                dal.Execute_1(@"UPDATE  wh_Serial SET "+ txt_transaction_code.Text+" = '" + txt_InvNu.Text + "' WHERE Branch_code = '" + txtStore_ID.Text+ "' and Cyear='" + txt_InvDate.Value.ToString("yy")+"' ");

               
                MessageBox.Show("تم الحفظ بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControlPanel1.Enabled = false;
                tabControlPanel2.Enabled = false;
                tabControlPanel3.Enabled = false;
                groupPanel7.Enabled = false;

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

           dal.Execute_1(@"insert into wh_Po_Cot_inv_data
            (Ser_no,Branch_code,Transaction_code,Cyear,Sanad_no
            ,G_date,ACC_TYPE,Acc_no,Acc_Branch_code,Payment_Type
            ,Sales_man_Id,User_id,Po_Status,Cash_costomer_name,Costomer_Notes
            ,Costomer_adress,Costomer_Phone,Costmer_fax,Ref,E_mail
            ,TermsOfPayment,Validity,DelevryE,requist_no,FORIN_TYPE
            ,PRINTING_SECURTY,TERMofCONDATION,PREPAREDby,RECEVEDby,TO_BRANCH
            ,CANCELED,aprovedBY,K_M_ACC_NO,K_M_Credit_TAX,K_M_Debit_TAX
            ,COSTMER_K_M_NO,K_M_SER,KM_CODE_ACC,MAIN_KM_CODE,OPEN_VAT)
values
     ('" + txt_InvNu.Text +
     "', '" + txtStore_ID.Text +
     "', '" + txt_transaction_code.Text +
    "', '" + txt_InvDate.Value.ToString("yy") +
    "' ,'" + txtMainSer.Text +
    "', '" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") +
    "','A', '" + txtSupplier.ID.Text +
    "', '" + txtBranch_Id.Text +
    "', '" + Convert.ToString(Payment_Type.SelectedValue) +
    "', '" + Uc_Cost.ID.Text +
    "' , '" + userID.Text +
    "', '','" +txtSuppContact.Text +
    "','" + txt_InvNot.Text +
    "', '" + txt_address.Text +
    "', '" + txt_custTel.Text +
    "','"+txt_custFax.Text +
    "','"+ txtRefrance.Text +
    "','"+ txt_CustEmail.Text+
    "','"+ Payment_Type.Text+
    "','" + ValidtyDays.Text +
    "','"+ Convert.ToString(DelevryTearms.SelectedValue)+
    "','0','"+Convert.ToString(txtcurrency.SelectedValue)+
    "','1','" + Convert.ToString(PaymentTearms.SelectedValue) +
    "','" + Uc_Cost.ID.Text +
    "','" + txtAauditBY.ID.Text +
    "','" +txtBranch.ID.Text +
    "','" + (chStop.Checked ? "C" : "") +
    "','"+ txtApproveBY.ID.Text +
    "', '" + Vat_acc.Text + 
    "','0','" +Net_Vat.Text.ToDecimal() +
    "', '" + Cust_Vat_No.Text +
    "', '1','" + txtKmCode.Text +
    "','" + Vat_Class.Text +
    "','" + (chVAT.Checked ? "1" : "0") + "')");

               }



     

        private void AddInvDetails()
        {
            for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            {
                if (dGV_Item.Rows[i].Cells[0].Value != null && dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() > 0)
                    //&& dGV_Item.Rows[i].Cells[6].Value.ToString().ToDecimal() > 0)
                {
                    dal.Execute_1(@" insert into wh_Po_Cot_MATERIAL_TRANSACTION 
                    (SER_NO,Branch_code,TRANSACTION_CODE,Cyear,SANAD_NO
                    ,ITEM_NO,QTY_ADD,QTY_TAKE,COST_PRICE,total_disc
                    ,DISC_R,DISC_R2,DISC_R3,G_DATE,Unit,Local_Price,FORIN_TYPE
                    ,USER_ID,main_counter,balance,K_M_TYPE_ITEMS,TAX_IN,TAX_OUT) 
           values( '" + txt_InvNu.Text 
                    + "', '" + txtStore_ID.Text
                    + "', '" + txt_transaction_code.Text 
                    + "', '" + txt_InvDate.Value.ToString("yy") 
                    +"' ,'" + txtMainSer.Text 
                    + "','" + dGV_Item.Rows[i].Cells[0].Value.ToString() 
                    + "' ,'0','" + dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() 
                    + "','" + dGV_Item.Rows[i].Cells[15].Value.ToString().ToDecimal() 
                    + "','" + ((dGV_Item.Rows[i].Cells[9].Value.ToString().ToDecimal()/  dGV_Item.Rows[i].Cells[8].Value.ToString().ToDecimal()) + disc_Rate.Text.ToDecimal())*100 
                    + "' ,'" + (dGV_Item.Rows[i].Cells[9].Value.ToString().ToDecimal() / dGV_Item.Rows[i].Cells[8].Value.ToString().ToDecimal())*100 
                    + "' ,'0','" + (disc_Rate.Text.ToDecimal())*100 
                    + "', '" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") 
                    + "','" + dGV_Item.Rows[i].Cells[3].Value.ToString()
                    + "' ,'" + dGV_Item.Rows[i].Cells[6].Value.ToString().ToDecimal()
                    + "' , '" + Convert.ToString(txtcurrency.SelectedValue) 
                    + "' , '" + userID.Text 
                    + "','" + dGV_Item.Rows[i].Index 
                    + "', '" + dGV_Item.Rows[i].Cells[4].Value.ToString().ToDecimal() 
                    + "','" + dGV_Item.Rows[i].Cells[16].Value.ToString() 
                    + "' ,'0','" + dGV_Item.Rows[i].Cells[12].Value.ToString().ToDecimal() + "')");


                }
            }
        }


        private void get_ItemData(string item_No)
        {
            DataTable dt = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,Weight,unit,
                BALANCE,local_cost,K.KM_RATIO,K.KM_Code
                FROM wh_main_master as A 
                inner join wh_Groups As B on A.group_code = B.group_code 
                left join KM_MATERIAL_CODE As K on  ISNULL(NULLIF(a.KM_CODE, ''), 1) = K.KM_CODE
                 where item_no = '" + item_No + "' or factory_no = '" + item_No + "'");
            if (dt.Rows.Count > 0)
            {
                TxtId.Text = dt.Rows[0][0].ToString();
                if (Properties.Settings.Default.lungh == "0")
                {
                    TxtDesc.Text = dt.Rows[0][2].ToString();
                }
                else
                {
                    TxtDesc.Text = dt.Rows[0][3].ToString();
                }
                Weight_.Text = dt.Rows[0][4].ToString().ToDecimal().ToString("N3");
                txtUnit.Text = dt.Rows[0][5].ToString();
                txtBalance.Text = dt.Rows[0][6].ToString().ToDecimal().ToString("N1");
                txtCost.Text = dt.Rows[0][7].ToString().ToDecimal().ToString("N3");
                VatRate.Text = dt.Rows[0][8].ToString().ToDecimal().ToString("N2");
                KM_TYPE_ITEMS.Text = dt.Rows[0][9].ToString();

                txtNote.Focus();


            }
            else
            {
                btn_braws.PerformClick();
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
            groupBox1.Visible = true;
            //PL.order_list_frm ord = new PL.order_list_frm();
            //ord.trans_code = "xsc";
            //ord.trans_code_1 = "xsd";
            //ord.ShowDialog();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            string printModel = Properties.Settings.Default.inv_print;
          
                RPT.rpt_Purchase_Order reportInv = new RPT.rpt_Purchase_Order();
                RPT.Form1 frminv = new RPT.Form1();
                DataSet ds = new DataSet();
                getQuotation(txt_InvNu.Text, txtStore_ID.Text, txt_transaction_code.Text, txt_InvDate.Value.ToString("yy"));
                ds.Tables.Add(dt_Q);
                //ds.WriteXmlSchema("schema_rpt.xml");
                reportInv.SetDataSource(ds);
                //reportInv.SetDataSource(dal.getDataTabl("get_invDetails", txt_InvNu.Text, txt_transaction_code.Text, txt_InvDate.Value.Year.ToString()));
                frminv.crystalReportViewer1.ReportSource = reportInv;
                frminv.ShowDialog();
           
               
        }


        private void BtnCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

   
     
     
        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void TxtDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clculat_amount();

                if (btntype == "0")
                {
                    
                        if (TxtPrice.Value <= 0)
                        {
                            MessageBox.Show("تأكد من السعر", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
                        {
                            if (dGV_Item.Rows[i].Cells[0].Value.ToString() == TxtId.Text)
                            {
                                MessageBox.Show("هذا الصنف مضاف من قبل", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                    
                    addrow_new();
                    btntype = "0";


                }
                else if (btntype == "1")
                {
                    editrow();
                    btntype = "0";

                }
               
            }
        }


       
      

        void clculat_amount()
        {
            try
            {
                txt_subTOt.Text = (TxtQty.Text.ToDecimal() * TxtPrice.Text.ToDecimal()).ToString("N" + dal.digits_);
                Txtvalue.Text = (TxtQty.Text.ToDecimal() * TxtPrice.Text.ToDecimal() - TxtDisc.Text.ToDecimal()).ToString("N" + dal.digits_);
                VatValue.Text = (Txtvalue.Text.ToDecimal() * VatRate.Text.ToDecimal()).ToString("N" + dal.digits_);
                totWeight.Text = (TxtQty.Text.ToDecimal() * Weight_.Text.ToDecimal()).ToString("N3");
            }
            catch
            {
                return;
            }
        }
        void addrow_new()
        {
            DataRow r = dt.NewRow();
            r[0] = TxtId.Text;
            r[1] = TxtDesc.Text;
            r[2] = txtNote.Text;
            r[3] = txtUnit.Text;
            r[4] = Weight_.Text.ToDecimal().ToString("N3");
            r[5] = TxtQty.Text.ToDecimal().ToString("N0");
            r[6] = TxtPrice.Text.ToDecimal().ToString("N" + dal.digits_);
            r[7] = Price_ton.Text.ToDecimal().ToString("N0");
            r[8] = txt_subTOt.Text.ToDecimal().ToString("N" + dal.digits_); ;
            r[9] = TxtDisc.Text.ToDecimal().ToString("N" + dal.digits_); ;
            r[10] = Txtvalue.Text.ToDecimal().ToString("N" + dal.digits_); ;
            r[11] = VatRate.Text.ToDecimal().ToString("N2"); ;
            r[12] = VatValue.Text.ToDecimal().ToString("N" + dal.digits_); ;
            r[13] = totWeight.Text.ToDecimal().ToString("N3"); ;
            r[14] = txtBalance.Text.ToDecimal().ToString("N0"); ;
            r[15] = txtCost.Text.ToDecimal().ToString("N" + dal.digits_); ;
            r[16] = KM_TYPE_ITEMS.Text;
         

            dt.Rows.Add(r);
            dGV_Item.DataSource = dt;
            clear_texts();
            btn_braws.Focus();
            total_inv();
            resizeDG();
        }

        void editrow()
        {
            dGV_Item.Rows[m].Cells[0].Value = TxtId.Text;
            dGV_Item.Rows[m].Cells[1].Value = TxtDesc.Text;
            dGV_Item.Rows[m].Cells[2].Value = txtNote.Text;
            dGV_Item.Rows[m].Cells[3].Value = txtUnit.Text;
            dGV_Item.Rows[m].Cells[4].Value = Weight_.Text.ToDecimal().ToString("N3");
            dGV_Item.Rows[m].Cells[5].Value = TxtQty.Text.ToDecimal().ToString("N0");
            dGV_Item.Rows[m].Cells[6].Value = TxtPrice.Text.ToDecimal().ToString("N" + dal.digits_);
            dGV_Item.Rows[m].Cells[7].Value = Price_ton.Text.ToDecimal().ToString("N0");
            dGV_Item.Rows[m].Cells[8].Value = txt_subTOt.Text.ToDecimal().ToString("N" + dal.digits_);
            dGV_Item.Rows[m].Cells[9].Value = TxtDisc.Text.ToDecimal().ToString("N" + dal.digits_);
            dGV_Item.Rows[m].Cells[10].Value = Txtvalue.Text.ToDecimal().ToString("N" + dal.digits_);
            dGV_Item.Rows[m].Cells[11].Value = VatRate.Text.ToDecimal().ToString("N2");
            dGV_Item.Rows[m].Cells[12].Value = VatValue.Text.ToDecimal().ToString("N" + dal.digits_); 
            dGV_Item.Rows[m].Cells[13].Value = totWeight.Text.ToDecimal().ToString("N3");
            dGV_Item.Rows[m].Cells[14].Value = txtBalance.Text.ToDecimal().ToString("N0");
            dGV_Item.Rows[m].Cells[15].Value = txtCost.Text.ToDecimal().ToString("N" + dal.digits_);
            dGV_Item.Rows[m].Cells[16].Value = KM_TYPE_ITEMS.Text;


            total_inv();
            clear_texts();
            btn_braws.Focus();
            resizeDG();

        }



        private void total_inv()
        {

            TxtTotal.Text =
               (from DataGridViewRow row in dGV_Item.Rows
                where row.Cells[8].FormattedValue.ToString() != string.Empty
                select Convert.ToDouble(row.Cells[8].FormattedValue)).Sum().ToString();
            txtDiscount_1.Text =
                (from DataGridViewRow row in dGV_Item.Rows
                 where row.Cells[9].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[9].FormattedValue)).Sum().ToString();




            if (TxtTotal.Text.ToDecimal() > 0)
            {
                ////disc_Rate.Text = (txtDiscount.Text.ToDecimal() /NetValue.Text.ToDecimal()).ToString();
                disc_Rate.Text = ((txtDiscount.Text.ToDecimal() / 1.05.ToString().ToDecimal()) / (TxtTotal.Text.ToDecimal() - txtDiscount_1.Text.ToDecimal())).ToString();
                
            }
            txtNetTotal.Text = (TxtTotal.Text.ToDecimal() - txtDiscount_1.Text.ToDecimal() - (txtDiscount.Text.ToDecimal() / 1.05.ToString().ToDecimal())).ToString("N"+dal.digits_);


            for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            {
                if (dGV_Item.Rows[i].Cells[0].Value != null && dGV_Item.Rows[i].Cells[4].Value.ToString().ToDecimal() > 0
                   && dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() > 0)
                {
                    if (dGV_Item.Rows[i].Cells[11].Value.ToString().ToDecimal() > Cust_Vat_Rate.Text.ToDecimal())
                    {
                        dGV_Item.Rows[i].Cells[12].Value = Math.Round((dGV_Item.Rows[i].Cells[10].Value.ToString().ToDecimal() * Cust_Vat_Rate.Text.ToDecimal() * (1 - disc_Rate.Text.ToDecimal())), 3);
                    }
                    else
                    {
                        dGV_Item.Rows[i].Cells[12].Value = Math.Round((dGV_Item.Rows[i].Cells[10].Value.ToString().ToDecimal() * dGV_Item.Rows[i].Cells[11].Value.ToString().ToDecimal() * (1 - disc_Rate.Text.ToDecimal())), 3);
                    }
                }
            }
            Net_Vat.Text =
                (from DataGridViewRow row in dGV_Item.Rows
                 where row.Cells[12].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString("N" + dal.digits_);

            NetValue.Text = (txtNetTotal.Text.ToDecimal() + Net_Vat.Text.ToDecimal()).ToString("N" + dal.digits_);

            if (Convert.ToString(Payment_Type.SelectedValue) == "2")
            {
                paied_amount.Text = "0";
            }
            else if (Convert.ToString(Payment_Type.SelectedValue) == "11" || Convert.ToString(Payment_Type.SelectedValue) == "12")
            {
                paied_amount.Text = NetValue.Text;
            }

            balance_amount.Text = (NetValue.Text.ToDecimal() - paied_amount.Text.ToDecimal()).ToString();


        }
        void clear_texts()
        {
            TxtId.Clear();
            TxtDesc.Clear();
            txtNote.Clear();
            txtUnit.Clear();
            TxtQty.Value=0;
            TxtPrice.Value = 0;
            txt_subTOt.Clear();
            TxtDisc.Value = 0;
            Txtvalue.Clear();
            VatRate.Clear();
            VatValue.Clear();
            txtBalance.Clear();
            txtCost.Clear();

        }

        void resizeDG()
        {

            this.dGV_Item.Columns[0].Width = this.TxtId.Width;
            this.dGV_Item.Columns[1].Width = this.TxtDesc.Width;
            this.dGV_Item.Columns[2].Width = this.txtNote.Width;
            this.dGV_Item.Columns[3].Width = this.txtUnit.Width;
            this.dGV_Item.Columns[4].Width = this.Weight_.Width;
            this.dGV_Item.Columns[5].Width = this.TxtQty.Width;
            this.dGV_Item.Columns[6].Width = this.TxtPrice.Width;
            this.dGV_Item.Columns[7].Width = this.Price_ton.Width;
            this.dGV_Item.Columns[8].Width = this.txt_subTOt.Width;
            this.dGV_Item.Columns[9].Width = this.TxtDisc.Width;
            this.dGV_Item.Columns[10].Width = this.Txtvalue.Width;
            this.dGV_Item.Columns[11].Width = this.VatRate.Width;
            this.dGV_Item.Columns[12].Width = this.VatValue.Width;
            this.dGV_Item.Columns[13].Width = this.totWeight.Width;
            this.dGV_Item.Columns[14].Width = this.txtBalance.Width;
            this.dGV_Item.Columns[15].Width = this.txtCost.Width;
            this.dGV_Item.Columns[16].Visible = false;


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
            dGV_Item.DataSource = dt;
        }

        private void TxtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TxtQty.Value > 0)
            {

                TxtPrice.Focus();
            }
        }

        private void TxtQty_KeyUp(object sender, KeyEventArgs e)
        {
            clculat_amount();
        
        }

        private void TxtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            clculat_amount();
            //get_B_C();
        }

        private void TxtDisc_KeyUp(object sender, KeyEventArgs e)
        {
           
            clculat_amount();
            //get_B_C();
        }

        private void TxtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TxtPrice.Text != string.Empty)
            {
                TxtDisc.Focus();
            }

            if (e.KeyCode == Keys.F1)
            {
                PL.list_H_price item_h_price = new PL.list_H_price();
                item_h_price.dataGridView1.DataSource = dal.getDataTabl("item_H_prices_sales", TxtId.Text, txtSupplier.ID.Text);
                item_h_price.ShowDialog();


            }

            if (e.KeyCode == Keys.F2)
            {
               

                PL.list_H_price item_h_price = new PL.list_H_price();
                item_h_price.dataGridView1.DataSource = dal.getDataTabl("item_H_prices_sales", TxtId.Text,"%");
                item_h_price.ShowDialog();



            }

        }

        private void TxtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TxtId.Text != "")
            {

                get_ItemData(TxtId.Text);

            }
            //if (e.KeyCode == Keys.Enter && TxtId.Text != string.Empty)
            //{
            //    DataTable dt = dal.getDataTabl("get_product_name", TxtId.Text, Properties.Settings.Default.StoreID);
            //    if (dt.Rows.Count > 0)
            //    {
            //        if (Properties.Settings.Default.lungh == "0")
            //        {
            //            TxtId.Text = dt.Rows[0][0].ToString();
            //            TxtDesc.Text = dt.Rows[0][2].ToString();
            //            VatRate.Text = dt.Rows[0][13].ToString();
            //            cmb_unit.SelectedValue = dt.Rows[0][8].ToString();

            //        }
            //        else
            //        {

            //            TxtId.Text = dt.Rows[0][0].ToString();
            //            TxtDesc.Text = dt.Rows[0][3].ToString();
            //            VatRate.Text = dt.Rows[0][13].ToString();
            //            cmb_unit.SelectedValue = dt.Rows[0][8].ToString();

            //        }
            //        get_B_C();
            //        txtNote.Focus();


            //    }
            //    else
            //    {
            //        btn_braws.PerformClick();
            //    }


            //}
        }

        private void get_B_C()
        {
            string StockItem = dal.getDataTabl_1("select stock_Kind from Product_Tbl where Id_Pro='" + TxtId.Text + "'").Rows[0][0].ToString();
            if (StockItem == "01")
            {
                DataTable dt_B_c = new DataTable();
                dt_B_c = dal.getDataTabl("getBalnceAndCost", TxtId.Text, txtStore_ID.Text);
                if (dt_B_c.Rows.Count > 0)
                {
                    txtBalance.Text = dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
                    txtCost.Text = dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
                    old_balance = Convert.ToDecimal(dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
                    old_cost = Convert.ToDecimal(dt_B_c.Rows[0][1].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
                }
                else
                {
                    txtBalance.Text = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
                    txtCost.Text = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
                    old_balance = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
                    old_cost = Convert.ToDecimal("0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_));
                }
                new_balance = old_balance - TxtQty.Text.ToDecimal();
                new_cost = old_cost;
                txtBalance.Text = new_balance.ToString("N" + Properties.Settings.Default.digitNo_);
                txtCost.Text = new_cost.ToString("N" + Properties.Settings.Default.digitNo_);
            }
            else 
            {
                txtBalance.Text = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
                txtCost.Text = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);

            }  
        }


        private void btn_braws_Click(object sender, EventArgs e)
        {

            try
            {
                clear_texts();

                PL.frm_search_items frm = new PL.frm_search_items();
                frm.ShowDialog();
                get_ItemData(frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
                return;
            }

            ////try
            ////{
            //clear_texts();
            //product_list_frm frm = new product_list_frm();
            //frm.ShowDialog();
            //this.TxtId.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
            //this.TxtDesc.Text = frm.dGV_pro_list.CurrentRow.Cells[2].Value.ToString();
            //this.txtUnit.Text = frm.dGV_pro_list.CurrentRow.Cells[8].Value.ToString();
            //this.VatRate.Text = frm.dGV_pro_list.CurrentRow.Cells[11].Value.ToString();
            
            //get_B_C();
            //txtNote.Focus();
           
        }

        private void dGV_Item_DoubleClick(object sender, EventArgs e)
        {

            btntype = "1";
            m = dGV_Item.CurrentRow.Index;
            //try
            //{
                //DataTable itemdata_ = dal.getDataTabl("get_product_name", dGV_Item.CurrentRow.Cells[0].Value.ToString(), Properties.Settings.Default.CoId);
                TxtId.Text = dGV_Item.CurrentRow.Cells[0].Value.ToString();
                TxtDesc.Text = dGV_Item.CurrentRow.Cells[1].Value.ToString();
                txtNote.Text = dGV_Item.CurrentRow.Cells[2].Value.ToString();
                txtUnit.Text = dGV_Item.CurrentRow.Cells[3].Value.ToString();
                Weight_.Text = dGV_Item.CurrentRow.Cells[4].Value.ToString();
                TxtQty.Text = dGV_Item.CurrentRow.Cells[5].Value.ToString();
                TxtPrice.Text = dGV_Item.CurrentRow.Cells[6].Value.ToString();
                Price_ton.Text = dGV_Item.CurrentRow.Cells[7].Value.ToString().ToDecimal().ToString("N0");
                txt_subTOt.Text = dGV_Item.CurrentRow.Cells[8].Value.ToString();
                TxtDisc.Text = dGV_Item.CurrentRow.Cells[9].Value.ToString().ToDecimal().ToString("N"+dal.digits_); ;
                Txtvalue.Text = dGV_Item.CurrentRow.Cells[10].Value.ToString();
                VatRate.Text = dGV_Item.CurrentRow.Cells[11].Value.ToString();
                VatValue.Text = dGV_Item.CurrentRow.Cells[12].Value.ToString();
                totWeight.Text = dGV_Item.CurrentRow.Cells[13].Value.ToString();
                txtBalance.Text = dGV_Item.CurrentRow.Cells[14].Value.ToString();
                txtCost.Text = dGV_Item.CurrentRow.Cells[15].Value.ToString();
                KM_TYPE_ITEMS.Text = dGV_Item.CurrentRow.Cells[16].Value.ToString();
                TxtId.Focus();
            //}
            //catch
            //{
            //    return;
            //}
        }


        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                TxtQty.Focus();
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

        private void BtnAttache_Click(object sender, EventArgs e)
        {
            ////string date = Program.ConvertDateCalendar(txt_InvDate.Value, "Hijri", "en-US");
            //MessageBox.Show(date);
        }

        private void KM_TYPE_ITEMS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Qutation_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControlPanel1_Click_1(object sender, EventArgs e)
        {

        }


        private void FillComboCurrency()
        {
            DataTable dt_currency = dal.getDataTabl_1("select * from Wh_Currency");
            txtcurrency.DataSource = dt_currency;
            txtcurrency.ValueMember = "Currency_Code";
            txtcurrency.DisplayMember = "Currency_Name";
            txtcurrency.SelectedIndex = -1;
        }

        private void frm_PurchaseOrder_Load(object sender, EventArgs e)
        {
            get_invSer();
            txtSupplier.txtMainAcc.Text = "234";
            txtSupplier.txtFinal.Text = "1";
            txtSupplier.branchID.Text = dal.GetCell_1(@"Select acc_branch from wh_BRANCHES where BRANCH_code='"+txtStore_ID.Text+"'").ToString();
           
            DataTable Dt_1 = dal.getDataTabl_1(@"SELECT B.SALES_ACC_NO , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.SALES_ACC_NO=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code where B.BRANCH_code= '" + Properties.Settings.Default.BranchId + "'");
            if (Dt_1.Rows.Count > 0)
            {
                txtAcc2_ID.Text = Dt_1.Rows[0][0].ToString();
                txtAcc2_Desc.Text = Dt_1.Rows[0][1].ToString();
            }
            DataTable Dt_2 = dal.getDataTabl_1(@"SELECT B.Cash_acc_no , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.Cash_acc_no=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code where B.BRANCH_code= '" + Properties.Settings.Default.BranchId + "'");
            if (Dt_2.Rows.Count > 0)
            {
                txt_CashAcc_ID.Text = Dt_2.Rows[0][0].ToString();
                txt_CashAcc_Desc.Text = Dt_2.Rows[0][1].ToString();
            }

            DataTable Dt_3 = dal.getDataTabl_1(@"SELECT B.K_M_ACC_NO_SALES , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.K_M_ACC_NO_SALES=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code where B.BRANCH_code= '" + Properties.Settings.Default.BranchId + "'");
            if (Dt_3.Rows.Count > 0)
            {
                Vat_acc.Text = Dt_3.Rows[0][0].ToString();
                Vat_acc_Desc.Text = Dt_3.Rows[0][1].ToString();
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
                left join  KM_ACC_CODE as b on b.KM_CODE = a.KM_CODE where P.BRANCH_code like '" + Properties.Settings.Default.BranchId + "%' and P.ACC_NO = '" + txtSupplier.ID.Text + "' and(P.ACC_NO like '" + Acc_main + "%' or P.ACC_NO like '" + Acc_cash + "%') and P.t_final ='1'");
                txtBranch_Id.Text = Properties.Settings.Default.BranchId;
                if (dt_cust.Rows.Count > 0)
                {
                    if (txtSupplier.ID.Text == Acc_cash)
                    {
                       
                        Payment_Type.SelectedValue = "11";
                        Payment_Type.Enabled = false;
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
                        
                        Payment_Type.SelectedValue = "2";
                        Payment_Type.Enabled = true;

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
                total_inv();
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

      

     
       
        private void Btn_DelRow_Click(object sender, EventArgs e)
        {
            if (this.dGV_Item.SelectedRows.Count > 0)
            {
                dGV_Item.Rows.RemoveAt(this.dGV_Item.SelectedRows[0].Index);
                total_inv();
                foreach (DataGridViewRow row in this.dGV_Item.Rows)
                {
                    row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Srearch_Click(object sender, EventArgs e)
        {
            //txt_InvNu.Text = txtsearch.Text;
            //groupBox1.Visible = false;

           

                frmType = "EDIT";

//            dt_Q = dal.getDataTabl_1(@"select A.Ser_no,A.Branch_code,A.Transaction_code,A.Cyear,A.Sanad_no,A.G_date,A.Acc_no,A.Acc_Branch_code
//,A.Payment_Type,A.Sales_man_Id,A.User_id,A.Po_Status,A.Po_Expire_Date,A.Cash_costomer_name,A.Costomer_adress
//,A.Costomer_Phone,A.Costmer_fax,A.Ref,A.E_mail,A.TermsOfPayment,A.Validity,A.DelevryE,A.FORIN_TYPE
//,A.COSTMER_K_M_NO,A.COMP_TAX_NO,B.ITEM_NO,B.QTY_ADD,B.QTY_TAKE,B.total_disc,B.Local_Price,B.TAX_IN,B.TAX_OUT
//,M.descr,M.Descr_eng,m.Weight,m.BALANCE ,K.KM_RATIO,
//SP.Payment_name,SP.Notes,
//            DP.DeLEVRY_Name,DP.DELEVER_NAME_E,U.USER_NAME
//            from wh_Po_Cot_inv_data As A             
//            Inner join wh_Po_Cot_MATERIAL_TRANSACTION As B
//            on A.Ser_no = B.SER_NO and A.Branch_code = B.Branch_code AND A.Transaction_code = B.TRANSACTION_CODE AND A.Cyear = B.Cyear
//            inner join wh_main_master AS M on M.item_no = B.ITEM_NO
//            left join KM_MATERIAL_CODE As K on K.KM_CODE = ISNULL(NULLIF(M.KM_CODE, ''), 1)
//            left join Sal_Pyment_type As SP on SP.Payment_type = A.termsOfPayment
//            left join WH_PO_DELEVRY_CODE As DP on DP.DeLEVRY_CODE = A.DelevryE
//            inner join wh_USERS As U on U.USER_ID = A.USER_ID
//            where A.Ser_no = '" + txtsearch.Text + "'  and A.Branch_code = '" + txtStore_ID.Text + "'  and A.transaction_code = '" + txt_transaction_code.Text + "'  and A.cyear = '" + comboBox1.Text.Substring(comboBox1.Text.Length - 2) + "'");


            getQuotation(txtsearch.Text, txtStore_ID.Text, txt_transaction_code.Text, comboBox1.Text.Substring(comboBox1.Text.Length - 2));

            // DataTable dt_Q = dal.getDataTabl("Get_Po_Cot", txtSearch.Text, txtStore_ID.Text, Doc_Type.Text, txt_InvDate.Value.ToString("yy"),0,"");
            if (dt_Q.Rows.Count > 0)
                {
                   
                    txt_InvDate.Text = dt_Q.Rows[0]["G_date"].ToString();
                    txtSupplier.ID.Text = dt_Q.Rows[0]["Acc_no"].ToString();
                    Payment_Type.SelectedValue = dt_Q.Rows[0]["Payment_Type"].ToString();
                    Uc_Cost.ID.Text = dt_Q.Rows[0]["Sales_man_Id"].ToString();
                    txt_address.Text = dt_Q.Rows[0]["Costomer_adress"].ToString();
                    txt_custTel.Text = dt_Q.Rows[0]["Costomer_Phone"].ToString();
                    txt_custFax.Text = dt_Q.Rows[0]["Costmer_fax"].ToString();
                    txtRefrance.Text = dt_Q.Rows[0]["Ref"].ToString();
                    txt_CustEmail.Text = dt_Q.Rows[0]["E_mail"].ToString();
                    PaymentTearms.SelectedValue = dt_Q.Rows[0]["TermsOfPayment"].ToString();
                    ValidtyDays.Value = dt_Q.Rows[0]["Validity"].ToString().ParseInt(0);
                    DelevryTearms.SelectedValue = dt_Q.Rows[0]["DelevryE"].ToString();
                    Vat_acc.Text = dt_Q.Rows[0]["K_M_ACC_NO"].ToString();     
                    Net_Vat.Text = dt_Q.Rows[0]["K_M_Credit_TAX"].ToString();
                    Cust_Vat_No.Text = dt_Q.Rows[0]["COSTMER_K_M_NO"].ToString();
                    txtKmCode.Text = dt_Q.Rows[0]["KM_CODE_ACC"].ToString();
                    Vat_Class.Text = dt_Q.Rows[0]["MAIN_KM_CODE"].ToString();
                    txtSuppContact.Text = dt_Q.Rows[0]["Costomer_Notes"].ToString();
                    if (dt_Q.Rows[0]["VAT_RATIO"].ToString() == string.Empty)
                    { Cust_Vat_Rate.Text = "0.15"; }
                    else
                    {
                        Cust_Vat_Rate.Text = dt_Q.Rows[0]["VAT_RATIO"].ToString().ToDecimal().ToString("N2");
                    }
                    Validty_Date.Value = txt_InvDate.Value.AddDays(ValidtyDays.Value);
                    txt_InvNu.Text = dt_Q.Rows[0]["Ser_no"].ToString();
                txtMainSer.Text = dt_Q.Rows[0]["Sanad_no"].ToString();


                dt.Clear();
                    int i = 0;
                    DataRow row = null;
                    foreach (DataRow r in dt_Q.Rows)
                    {

                        row = dt.NewRow();
                        row[0] = dt_Q.Rows[i]["ITEM_NO"].ToString();
                        if (Properties.Settings.Default.lungh == "0")
                        {
                            row[1] = dt_Q.Rows[i]["descr"].ToString();
                        }
                        else
                        {
                            row[1] = dt_Q.Rows[i]["Descr_eng"].ToString();
                        }
                        row[2] = dt_Q.Rows[i]["DETAILS"].ToString();
                        row[3] = dt_Q.Rows[i]["Unit"].ToString();
                        row[4] = dt_Q.Rows[i]["Weight"].ToString();
                        row[5] = dt_Q.Rows[i]["QTY_TAKE"].ToString().ToDecimal().ToString("N2");
                        row[6] = dt_Q.Rows[i]["Local_Price"].ToString().ToDecimal().ToString("N" + dal.digits_);
                        row[7] = (dt_Q.Rows[i]["Local_Price"].ToString().ToDecimal() / dt_Q.Rows[i]["Weight"].ToString().ToDecimal() * 1000).ToString("N0");
                        row[8] = (dt_Q.Rows[i]["Local_Price"].ToString().ToDecimal() * dt_Q.Rows[i]["QTY_TAKE"].ToString().ToDecimal()).ToString("N" + dal.digits_); ;
                        row[9] = dt_Q.Rows[i]["KM_RATIO"].ToString().ToDecimal().ToString("N2");
                        row[10] = dt_Q.Rows[i]["TAX_OUT"].ToString().ToDecimal().ToString("N" + dal.digits_); ;
                        row[11] = (dt_Q.Rows[i]["QTY_TAKE"].ToString().ToDecimal() * dt_Q.Rows[i]["Weight"].ToString().ToDecimal()).ToString("n3");
                        row[12] = dt_Q.Rows[i]["BALANCE"].ToString().ToDecimal().ToString("N0");
                        row[13] = dt_Q.Rows[i]["Pice_Total_Cost"].ToString().ToDecimal().ToString("N" + dal.digits_);
                        row[14] = dt_Q.Rows[i]["K_M_TYPE_ITEMS"].ToString();
                        dt.Rows.Add(row);
                        i = i + 1;
                    }
                    dGV_Item.DataSource = dt;
                    resizeDG();
                    total_inv();
                    txtsearch.Text = "";
                    groupBox1.Visible = false;
                    BSave.Enabled = false;
                    BEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("تاكد من الرقم", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        




        }

        private void txtcurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_vactor = dal.getDataTabl_1("select * from Wh_Currency  where Currency_Code='" + txtcurrency.SelectedValue + "'");
                txt_Rate.Text = dt_vactor.Rows[0][2].ToString();

            }
            catch
            { txt_Rate.Text = "0"; }
        }



        private void getQuotation(string ser_, string branch_, string transaction_, string cyear_)
        {
            //try
            //{ //, ReportDB.dbo.Tafkeet('+@4+', '''+@5+''')  from wh_Po_Cot_inv_data As A
            dt_Q = dal.getDataTabl_1(@"select A.Ser_no,A.Branch_code,A.Transaction_code,A.Cyear,A.Sanad_no,A.G_date,A.Acc_no,A.Acc_Branch_code
            ,A.Payment_Type,A.Sales_man_Id,A.User_id,A.Po_Status,A.Po_Expire_Date,A.Cash_costomer_name,A.Costomer_adress
            ,A.Costomer_Phone,A.Costmer_fax,A.Ref,A.E_mail,A.TermsOfPayment,A.Validity,A.DelevryE,A.FORIN_TYPE
            ,A.K_M_ACC_NO,A.K_M_Credit_TAX,A.COSTMER_K_M_NO,A.KM_CODE_ACC,A.MAIN_KM_CODE,A.Costomer_Notes,A.VAT_RATIO,A.COMP_TAX_NO
            ,B.ITEM_NO,B.QTY_ADD,B.QTY_TAKE,B.Unit,B.total_disc,B.Local_Price,B.TAX_IN,B.TAX_OUT,B.DETAILS,B.Pice_Total_Cost,B.K_M_TYPE_ITEMS

            ,M.descr,M.Descr_eng,m.Weight,m.BALANCE ,K.KM_RATIO,
            SP.Payment_name,SP.Notes,
            DP.DeLEVRY_Name,DP.DELEVER_NAME_E,U.USER_NAME
			,P.PAYER_NAME,P.payer_l_name
            ,(select top 1 vat_ratio from VAT_RATIO_MASTER where cast(A.G_date as date ) between date_of_vat and '" + DateTime.Today.ToString("yyyy-MM-dd") + "' order by date_of_vat desc) as VatRatio " +
            "from wh_Po_Cot_inv_data As A " +
            "Inner join wh_Po_Cot_MATERIAL_TRANSACTION As B " +
            "on A.Ser_no = B.SER_NO and A.Branch_code = B.Branch_code AND A.Transaction_code = B.TRANSACTION_CODE AND A.Cyear = B.Cyear " +
            "inner join wh_main_master AS M on M.item_no = B.ITEM_NO " +
            "left join KM_MATERIAL_CODE As K on K.KM_CODE = ISNULL(NULLIF(M.KM_CODE, ''), 1) " +
            "left join Sal_Pyment_type As SP on SP.Payment_type = A.termsOfPayment " +
            "left join WH_PO_DELEVRY_CODE As DP on DP.DeLEVRY_CODE = A.DelevryE " +
            "inner join wh_USERS As U on U.USER_ID = A.USER_ID " +
            "inner join wh_BRANCHES as BR on A.Branch_code = BR.Branch_code " +
            "inner join payer2 as P on P.acc_no = A.acc_no and p.BRANCH_code = BR.ACC_BRANCH " +
            "where A.Ser_no = '" + ser_ + "'  and A.Branch_code = '" + branch_ + "'  and A.transaction_code = '" + transaction_ + "'  and A.cyear = '" + cyear_ + "'");
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }






    }
}


     