using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing; using System.Linq;
using System.Globalization;

using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;
//using Syncfusion.Pdf.Graphics;
//using Syncfusion.Pdf.Parsing;
//using Syncfusion.Pdf.Security;


namespace Report_Pro.PL
{
    public partial class frmLcs : XtraForm
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        //BL.Cls_Lcs cls = new BL.Cls_Lcs();
        //BL.Cls_PO po = new BL.Cls_PO();
        Assembly a = Assembly.Load("Report_Pro");
        CultureInfo cul;

        /// <summary>
        /// جزء من كود عدم تكرار الفتح للفورم
        /// </summary>
        private static frmLcs frm_lcs = null;
        //---------

        public frmLcs()
        {
            // كود منع تكرار فتح الفورم---------

            // If the form already exists, and has not been closed
            if (frm_lcs != null && !frm_lcs.IsDisposed)
            {
                frm_lcs.Focus();            // Bring the old one to top
                Shown += (s, e) => this.Close();  // and destroy the new one.
                return;
            }

            // Otherwise store this one as reference
            frm_lcs = this;
            //--------------------------------

            InitializeComponent();

            if (Properties.Settings.Default.lungh == "0")
            {
                cul = new CultureInfo("ar");
            }
            else
            {
                cul = new CultureInfo("en");
            }


            Currency.DataSource = dal.getDataTabl_1("SELECT * FROM " + dal.db1 + ".dbo.Wh_Currency");

            Currency.ValueMember = "Currency_Code";
            if (Properties.Settings.Default.lungh == "ar")
            {
                Currency.DisplayMember = "Currency_Name";
            }
            else
            {
                Currency.DisplayMember = "Currency_Name";

            }
            Currency.SelectedIndex = -1;

            txtRegion.DataSource = dal.getDataTabl_1("SELECT * FROM REGIONS");

            txtRegion.ValueMember = "REGION_code";
            if (Properties.Settings.Default.lungh == "0")
            {
                txtRegion.DisplayMember = "REGION_name";
            }
            else
            {
                txtRegion.DisplayMember = "REGION_E_NAME";

            }
            txtRegion.SelectedIndex = -1;


            txtArivePort.DataSource = dal.getDataTabl_1("SELECT * FROM Cus_Ports");

            txtArivePort.ValueMember = "Port_code";
            if (Properties.Settings.Default.lungh == "0")
            {
                txtArivePort.DisplayMember = "Port_name";
            }
            else
            {
                txtArivePort.DisplayMember = "Port_E_name";

            }
            txtArivePort.SelectedIndex = -1;
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
                    else if (control is DevComponents.Editors.DateTimeAdv.DateTimeInput)
                        (control as DevComponents.Editors.DateTimeAdv.DateTimeInput).Text = "";
                    else if (control is DataGridView)
                        (control as DataGridView).DataSource = null;



                    else
                        func(control.Controls);
            };

            func(Controls);
        }








        private void LcNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && LcNo.Text != string.Empty)
            {
                txtBank.ID.Focus();
            }
        }



        private void Currency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Currency.Text != string.Empty)
            {
                Amount.Focus();
            }

        }



        private void AcceptDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && AcceptDays.Text != string.Empty)
            {
                OpenDate.Focus();

            }
        }

        private void Amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Amount.Text != string.Empty)
            {
                AcceptDays.Focus();

            }
        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void AcceptDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void OpenDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                ExpiryDate.Focus();
            }
        }

        private void ExpiryDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                LShipDate.Focus();
            }
        }




        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            BSave.Enabled = true;
            BEdit.Enabled = false;
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if (LcNo.Text != string.Empty && txtBank.ID.Text != string.Empty && Currency.Text != string.Empty &&
               Amount.Text != string.Empty && AcceptDays.Text != string.Empty)
            {
                //try
                //{
                dal.Execute_1(@"insert into LcsTbl(LcNo,BID,Currency,Amount,Qty,Materials,Supplier,AcceptDays,OpenDate,ExpiryDate,LShipDate,plusValue,CurrencyRate,
                        ArrivePort, Region, OpenFees, OpenComnication, OtherFees, AcceptRatio, AcceptFees, VAT, MarginRatio, Margin,Branch_Code,LcAccNo,Factory,Proforma,
                        ProformaDate,MushaarkaFees,OpenFees_SAMA,AddOpenFees) values('" + LcNo.Text + "', '" +
                    txtBank.ID.Text + "', '" + Convert.ToString(Currency.SelectedValue) + "', '" + Amount.Text.ToDecimal().ToString("N2") + "','" +
                    txtQty.Text.ToDecimal().ToString("N3") + "','" + txtMatrails.Text + "','" + txtSupplier.ID.Text + "','" + AcceptDays.Text.ToDecimal().ToString("N0") +
                    "','" + OpenDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + ExpiryDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                    LShipDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txtAddValue.Value + "','" + txtRate.Value + "','" + Convert.ToString(txtArivePort.SelectedValue) +
                    "','" + Convert.ToString(txtRegion.SelectedValue) + "','" + txtopenFess.Value + "','" + txtComnication.Value + "','" + txtotharFess.Value + "','" +
                    ratioAccept.Text.ToDecimal().ToString("N2") + "','" + txtAcceptance.Value + "','" + txtVat.Value + "','" + marginRatio.Text.ToDecimal().ToString("N0") + "','" + txtMargin.Value + 
                    "','"+txtBranch.ID.Text+"','"+txtLcAcc.ID.Text+"','"+txtFactory.Text+"','"+txtProforma.Text+"','"+txtProformaDate.Text+ "','" + txtMuskDownP.Value +"','"+txtIssuSAMA.Value+"','"+txtAddFees.Value+"')");

                createFolder(@"\\192.168.101.4\LC_Folder", LcNo.Text.Trim());
                MessageBox.Show("تم الحفظ بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BSave.Enabled = false;
                BEdit.Enabled = true;
                //ClearTextBoxes();
                //LcNo.Focus();
                //}
                //catch (System.Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

                

            }
            else
            {
                MessageBox.Show("تأكد من اكمال البيانات", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager("Report_Pro.Lang.Langres", a);
            if (txtBank.ID.Text != string.Empty && Currency.Text != string.Empty &&
               Amount.Text != string.Empty && AcceptDays.Text != string.Empty)
            {
                if (LcNo.Text != string.Empty && dal.getDataTabl_1(@"select LcNo from LcsTbl where id!='"+txtId.Text+"' and  LcNo ='" + LcNo.Text + "'").Rows.Count>0)
                {
                    MessageBox.Show(rm.GetString("msgDuplicate", cul), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //try
                    //{

                    dal.Execute_1(@"update LcsTbl set LcNo='" + LcNo.Text +
                "', BID = '" + txtBank.ID.Text +
                "', Currency = '" + Convert.ToString(Currency.SelectedValue) +
                "', Amount = '" + Amount.Text.ToDecimal().ToString("N2") +
                "', Qty = '" + txtQty.Text.ToDecimal().ToString("N3") +
                "', Materials = '" + txtMatrails.Text +
                "', Supplier = '" + txtSupplier.ID.Text +
                "', AcceptDays = '" + Convert.ToInt32(AcceptDays.Text) +
                "', OpenDate = '" + OpenDate.Value.ToString("yyyy-MM-dd HH:mm:ss") +
                "', ExpiryDate = '" + ExpiryDate.Value.ToString("yyyy-MM-dd HH:mm:ss") +
                "', LShipDate = '" + LShipDate.Value.ToString("yyyy-MM-dd HH:mm:ss") +
                "', plusValue = '" + txtAddValue.Value +
                "', CurrencyRate = '" + txtRate.Value +
                "', ArrivePort = '" + Convert.ToString(txtArivePort.SelectedValue) +
                "', Region = '" + Convert.ToString(txtRegion.SelectedValue) +
                "', OpenFees = '" + txtopenFess.Value +
                "', OpenComnication = '" + txtComnication.Value +
                "', OtherFees = '" + txtotharFess.Value +
                "', AcceptRatio = '" + Convert.ToDecimal(ratioAccept.Text) +
                "', AcceptFees = '" + txtAcceptance.Value +
                "', VAT = '" + txtVat.Value +
                "', MarginRatio = '" + Convert.ToDecimal(marginRatio.Text) +
                "', Margin = '" + txtMargin.Value +
                "',Branch_Code ='" + txtBranch.ID.Text +
                "',LcAccNo ='" + txtLcAcc.ID.Text +
                "',Factory ='" + txtFactory.Text +
                "',Proforma='" + txtProforma.Text +
                "', ProformaDate='" + txtProformaDate.Value.ToString("yyyy-MM-dd HH:mm:ss") +
                "',MushaarkaFees='" + txtMuskDownP.Value +
                "', OpenFees_SAMA='" + txtIssuSAMA.Value +
                "', AddOpenFees='" + txtAddFees.Value +
                "' where id ='" + txtId.Text + "'");

                    createFolder(@"\\192.168.101.4\LC_Folder", LcNo.Text.Trim());
                    MessageBox.Show(rm.GetString("msgSave", cul), "تعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //ClearTextBoxes();
                    //BSave.Enabled = true;
                    //LcNo.Focus();
                }
                //}

                //catch (System.Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
               
            }
            else
            {
                MessageBox.Show("تأكد من اكمال البيانات", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            FrmSerchLcs frmSrchLcs = new FrmSerchLcs();
            frmSrchLcs.ShowDialog();
            //try
            //{
                showData(frmSrchLcs.DGV1.CurrentRow.Cells[0].Value.ToString());
                //clc_openFees();
                BSave.Enabled = false;

                BEdit.Enabled = true;

            //}
            //catch
            //{
            //}
        }

        private void showData(string Id_)
        {
            DataTable dtLc = dal.getDataTabl_1(@"select * from LcsTbl where id='" + Id_ + "'");
            if (dtLc.Rows.Count > 0)
            {
                txtId.Text= dtLc.Rows[0]["id"].ToString();
                LcNo.Text = dtLc.Rows[0]["LcNo"].ToString();
                txtBank.ID.Text = dtLc.Rows[0]["BID"].ToString();
                Currency.SelectedValue = dtLc.Rows[0]["Currency"].ToString();
                Amount.Text = dtLc.Rows[0]["Amount"].ToString().ToDecimal().ToString();
                txtQty.Text = dtLc.Rows[0]["Qty"].ToString().ToDecimal().ToString();
                txtMatrails.Text = dtLc.Rows[0]["Materials"].ToString();
                txtSupplier.ID.Text = dtLc.Rows[0]["Supplier"].ToString();
                AcceptDays.Text =(Convert.ToInt32(dtLc.Rows[0]["AcceptDays"].ToString())).ToString();
                DateTime Op_Date;
                DateTime.TryParse(dtLc.Rows[0]["OpenDate"].ToString(), out Op_Date);
                OpenDate.Text = Op_Date.ToString("d");
                DateTime Ex_Date;
                DateTime.TryParse(dtLc.Rows[0]["ExpiryDate"].ToString(), out Ex_Date);
                ExpiryDate.Text = Ex_Date.ToString("d");
                DateTime Sh_Date;
                DateTime.TryParse(dtLc.Rows[0]["LShipDate"].ToString(), out Sh_Date);
                LShipDate.Text = Sh_Date.ToString("d");
                txtAddValue.Text = dtLc.Rows[0]["plusValue"].ToString().ToDecimal().ToString("N0");
                txtRate.Text= dtLc.Rows[0]["CurrencyRate"].ToString().ToDecimal().ToString("N4");
                txtArivePort.SelectedValue = dtLc.Rows[0]["ArrivePort"].ToString();
                txtRegion.SelectedValue = dtLc.Rows[0]["Region"].ToString();
                txtIssuSAMA.Text = dtLc.Rows[0]["OpenFees_SAMA"].ToString().ToDecimal().ToString("N2");
                txtAddFees.Text = dtLc.Rows[0]["AddOpenFees"].ToString().ToDecimal().ToString("N2");
                txtopenFess.Text = dtLc.Rows[0]["OpenFees"].ToString().ToDecimal().ToString("N2");
                txtComnication.Text = dtLc.Rows[0]["OpenComnication"].ToString().ToDecimal().ToString("N2");
                txtotharFess.Text = dtLc.Rows[0]["OtherFees"].ToString().ToDecimal().ToString("N2");
                ratioAccept.Text = dtLc.Rows[0]["AcceptRatio"].ToString().ToDecimal().ToString("N2");
                txtAcceptance.Text = dtLc.Rows[0]["AcceptFees"].ToString().ToDecimal().ToString("N2");
                txtVat.Text = dtLc.Rows[0]["VAT"].ToString().ToDecimal().ToString("N2");
                marginRatio.Text = dtLc.Rows[0]["MarginRatio"].ToString().ToDecimal().ToString("N0");
                txtMargin.Text = dtLc.Rows[0]["Margin"].ToString().ToDecimal().ToString("N2");
                txtBranch.ID.Text = dtLc.Rows[0]["Branch_Code"].ToString();
                txtLcAcc.ID.Text = dtLc.Rows[0]["LcAccNo"].ToString();
                txtFactory.Text = dtLc.Rows[0]["Factory"].ToString();
                txtProforma.Text = dtLc.Rows[0]["Proforma"].ToString();
                txtProformaDate.Text = dtLc.Rows[0]["ProformaDate"].ToString();
                txtMuskDownP.Text= dtLc.Rows[0]["MushaarkaFees"].ToString().ToDecimal().ToString("N2");
                TotalFess.Value = txtopenFess.Value + txtComnication.Value + txtotharFess.Value + txtAcceptance.Value+txtMuskDownP.Value;
                txtTotal.Value = TotalFess.Value + txtVat.Value;
                

            }
        }


        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void buttonX1_Click(object sender, EventArgs e)
        {

            Frm_uploadImage frmUpload = new Frm_uploadImage();
            frmUpload.p_id = this.LcNo.Text;
            frmUpload.ShowDialog();
        }

        private void frmLcs_Load(object sender, EventArgs e)
        {
            txtSupplier.txtMainAcc.Text = "234";
            txtSupplier.txtFinal.Text = "1";
            txtBank.txtMainAcc.Text = "122";
            txtBank.txtFinal.Text = "1";
            txtLcAcc.txtMainAcc.Text = "125";
            txtLcAcc.txtFinal.Text = "1";

            txtBranch.txtTfinal.Text = "1";
           // txtBranch.txtUser.Text = Program.userID.ToString();

        }

        private void clc_openFees()
        {
            try
            {
                double months_ = Math.Ceiling(((ExpiryDate.Value - OpenDate.Value).TotalDays) / 30);

                if (Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100 > 400000)
                {
                    if (months_ > 3)
                    {
                        double d1;
                        double d2;
                        d1 = ((Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100) - 400000) / 800;
                        d2 = (months_ - 3) * Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100 / 1600;
                        txtIssuSAMA.Value= 1000 + d1 + d2;
                        //txtopenFess.Value = 1000 + d1 + d2;
                    }
                    else
                    {
                        double d1;
                        d1 = ((Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100) - 400000) / 800;
                        txtIssuSAMA.Value = 1000 + d1 ;
                        //txtopenFess.Value = 1000 + d1;
                    }
                   
                }
                else
                {
                     //months_ = Math.Ceiling(((ExpiryDate.Value - OpenDate.Value).TotalDays) / 30);
                    if (months_ > 3)
                    {
                        double d1;
                        double d2;
                        d1 = ((Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100)) / 400;
                        d2 = (months_ - 3) * Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100 / 1600;
                        txtIssuSAMA.Value = d1 + d2;
                        //txtopenFess.Value = d1+d2;
                        txtMargin.Text = (Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100 * Convert.ToDouble(marginRatio.Text) / 100).ToString();
                    }
                    else
                    {
                        double d1;
                      
                        d1 = ((Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100)) / 400;
                        txtIssuSAMA.Value = d1;
                        //txtopenFess.Value = d1;
                        txtMargin.Text = (Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100 * Convert.ToDouble(marginRatio.Text) / 100).ToString();

                    }

                }
                // -----------add fees--------------------------
                if (txtBank.ID.Text == "122101" || txtBank.ID.Text == "122121")
                {
                    txtAcceptance.Value = (Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100 * Convert.ToDouble(ratioAccept.Text) / 100 * Convert.ToDouble(AcceptDays.Text) / 360);
                    int lcDates = ((TimeSpan)(ExpiryDate.Value - OpenDate.Value)).Days + 1;
                    double ANBadd =Math.Round(.0025 * lcDates * txtRate.Value*Convert.ToDouble(Amount.Text)* (txtAddValue.Value + 100) / 100 / 360,2);
                    txtAddFees.Text = ANBadd.ToString();
                    txtopenFess.Value += ANBadd;
                }
                else if(txtBank.ID.Text == "122106")
                {
                    int lcDates = ((TimeSpan)(ExpiryDate.Value - OpenDate.Value)).Days;
                    double ANBadd = Math.Round(.0025 * lcDates * txtRate.Value * Convert.ToDouble(Amount.Text) * (txtAddValue.Value + 100) / 100 / 360, 2);
                   txtopenFess.Value += ANBadd;
                    txtAddFees.Text = ANBadd.ToString();
                }
                else if (txtBank.ID.Text == "122108")
                {
                    double Fadd = 0;
                    double Fadd1 = 0;
                    int lcDates = ((TimeSpan)(ExpiryDate.Value - OpenDate.Value)).Days + 1;
                    Fadd = Math.Round(.0005  * ((txtRate.Value * Convert.ToDouble(Amount.Text) * (txtAddValue.Value + 100) / 100) -400000) , 2);
                    if (months_ > 3)
                    {
                        Fadd1 = Math.Round(.0005  * txtRate.Value * Convert.ToDouble(Amount.Text) * (txtAddValue.Value + 100) / 100 * (months_ - 3) , 2);
                    }
                    else
                    {
                        Fadd1 = 0;
                    }
                    txtAddFees.Text = (Fadd+Fadd1).ToString();
                    txtopenFess.Value += Fadd;
                    txtopenFess.Value += Fadd1;
                }
                else if (txtBank.ID.Text == "122113")
                {
                    txtMuskDownP.Value = Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100 * .0125;
                }
                else
                {
                    txtMuskDownP.Value = 0;
                }

                if (txtBank.ID.Text == "122102")
                {
                   int lcDates = ((TimeSpan)(ExpiryDate.Value - OpenDate.Value)).Days;
                    double ryadadd = Math.Round(.005 * lcDates * txtRate.Value * Convert.ToDouble(Amount.Text) * (txtAddValue.Value + 100) / 100 / 360, 2);
                    txtAddFees.Text = ryadadd.ToString();
                    txtopenFess.Value += ryadadd;
                }

                //----------------Totals & VAT --------------------------------
                txtMargin.Text = (Convert.ToDouble(Amount.Text) * txtRate.Value * (txtAddValue.Value + 100) / 100 * Convert.ToDouble(marginRatio.Text) / 100).ToString();
                txtopenFess.Value = txtIssuSAMA.Value + txtAddFees.Value;
                TotalFess.Value = txtopenFess.Value + txtComnication.Value + txtotharFess.Value + txtAcceptance.Value+txtMuskDownP.Value;
               
                if (OpenDate.Value < new DateTime(2020, 7, 1))
                {
                    txtVat.Value = TotalFess.Value * .05;
                }
                else
                {
                    txtVat.Value = TotalFess.Value * .15;
                }
                txtTotal.Value = TotalFess.Value + txtVat.Value;

            }
            catch
            {



            }
        }


        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            currencyRate(txtRate, txtBank.ID.Text, Convert.ToString(Currency.SelectedValue));
            //clc_openFees();
        }

        private void currencyRate(DevComponents.Editors.DoubleInput txt1, string bankId, string currencyId)
        {
            try
            {
                txt1.Value = Convert.ToDouble(dal.getDataTabl_1("select Rate from RateTbl where BID='" + bankId + "' and  Curncy_Id='" + currencyId + "'").Rows[0][0].ToString());

            }
            catch
            {

            }

        }

        private void OpenDate_ValueChanged(object sender, EventArgs e)
        {
            //clc_openFees();
        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            //clc_openFees();
        }

        private void txtRate_ValueChanged(object sender, EventArgs e)
        {
            //clc_openFees();
        }

        private void txtBank_Load(object sender, EventArgs e)
        {
            DataTable dtBank = dal.getDataTabl_1(@"select * from BanksTbl where Acc_no='" + txtBank.ID.Text + "'");
            if (dtBank.Rows.Count > 0) {
                txtComnication.Text = dtBank.Rows[0]["BComnication"].ToString().ToDecimal().ToString();
                marginRatio.Text = dtBank.Rows[0]["Bmargin"].ToString().ToDecimal().ToString();
                ratioAccept.Text = dtBank.Rows[0]["BAccept"].ToString().ToDecimal().ToString();
                txtMainLcAccNo.Text= dtBank.Rows[0]["mainLcAccNo"].ToString();
                //clc_openFees();
            }

        }

        private void ExpiryDate_ValueChanged(object sender, EventArgs e)
        {
            //clc_openFees();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtotharFess_ValueChanged(object sender, EventArgs e)
        {
            //clc_openFees();
        }

        private void lblOpenDate_Click(object sender, EventArgs e)
        {

        }

        private void txtAddValue_ValueChanged(object sender, EventArgs e)
        {
            //clc_openFees();
        }

        private void btnPrintIssueFees_Click(object sender, EventArgs e)
        {
            DataSet ds =new DataSet();
            RPT.lcOpenDocument rpt = new RPT.lcOpenDocument();
            RPT.Form1 frm = new RPT.Form1();
            ds.Tables.Add(LcData(LcNo.Text));
            rpt.SetDataSource(ds);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            //ds.WriteXmlSchema("schema1.xml");
        }

        private DataTable LcData(string LcNum)
        {
            DataTable dt_1 = dal.getDataTabl_1(@"select L.*,X.PAYER_NAME,X.payer_l_name,Y.PAYER_NAME,Y.payer_l_name,C.Currency_Name,p.Port_name,P.Port_E_name  from LcsTbl as L
            inner join  (SELECT acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS Dupl_1 from payer2 ) as X
            on X.ACC_NO=L.BID
            inner join  (SELECT acc_no,PAYER_NAME,payer_l_name ,ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS Dupl_2 from payer2 ) as Y
            on Y.ACC_NO=L.Supplier
            inner join Cus_Ports as P on P.Port_code=L.ArrivePort
            inner join Wh_Currency as C on C.Currency_Code= L.Currency
            where X.Dupl_1=1  and Y.Dupl_2=1 and LcNo='" + LcNum + "'");
            return dt_1;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            string accDesc = "";
            string accDesc_E = "";
            string lcAccNo = "";
            string addDate = "";
            DataTable dtCheckAcc = dal.getDataTabl_1(@"SELECT ACC_NO,PAYER_NAME,payer_l_name FROM payer2 where PAYER_NAME like '%" + LcNo.Text + "%' and MAIN_NO='" + txtMainLcAccNo.Text + "'");
            if (dtCheckAcc.Rows.Count > 0)
            {
                if (MessageBox.Show("توجد حسابات تحتوي نفس رقم الاعتماد... هل تريد الاضافة؟  ", "تحذير !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    accDesc = "ع/ " + LcNo.Text + " - " + txtMatrails.Text;
                    accDesc_E = "LC: " + LcNo.Text;

                    lcAccNo = dal.GetCell_1(@"select max(acc_no) + 1 from payer2 where MAIN_NO = '" + txtMainLcAccNo.Text + "' and BRANCH_code = 'a1110'").ToString();
                    addDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                    dal.Execute_1(@"insert into payer2 (acc_type,ACC_NO,BRANCH_code,MAIN_NO,PAYER_NAME,payer_l_name,t_final,t_level
                        ,PREV_NO,balance,MAIN_MEZAN,S_DATE,user_id,med_MEZAN,MASTER_ACC_NO,MASTER_PREV_NO) values('A',
                         '" + lcAccNo + "','A1110','" + txtMainLcAccNo.Text + "','" + accDesc + "','" + accDesc_E +
                                "','1','4','" + txtMainLcAccNo.Text + "','0','125','" + addDate + "','" + Program.userID + "','1108','12','" + txtMainLcAccNo.Text + "')");

                    dal.Execute_1(@"insert into payer2 (acc_type,ACC_NO,BRANCH_code,MAIN_NO,PAYER_NAME,payer_l_name,t_final,t_level
                        ,PREV_NO,balance,MAIN_MEZAN,S_DATE,user_id,med_MEZAN,MASTER_ACC_NO,MASTER_PREV_NO) values('A',
                         '" + lcAccNo + "','" + txtBranch.txtAccBranch.Text + "','" + txtMainLcAccNo.Text + "','" + accDesc + "','" + accDesc_E +
                               "','1','4','" + txtMainLcAccNo.Text + "','0','125','" + addDate + "','" + Program.userID + "','1108','12','" + txtMainLcAccNo.Text + "')");

                    dal.Execute_1(@"update LcsTbl set  LcAccNo ='" + lcAccNo + "' where LcNo='" + LcNo.Text + "' ");

                }
                else
                {
                    dgAccNo.DataSource = dtCheckAcc;
                }
            }

            else
            {
                dgAccNo.DataSource = null;
                dgAccNo.Rows.Clear();



                accDesc = "ع/ " + LcNo.Text + " - " + txtMatrails.Text;
                accDesc_E = "LC: " + LcNo.Text;

                lcAccNo = dal.GetCell_1(@"select max(acc_no) + 1 from payer2 where MAIN_NO = '" + txtMainLcAccNo.Text + "' and BRANCH_code = 'a1110'").ToString();
                addDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

               

                dal.Execute_1(@"insert into payer2 (acc_type,ACC_NO,BRANCH_code,MAIN_NO,PAYER_NAME,payer_l_name,t_final,t_level
                        ,PREV_NO,balance,MAIN_MEZAN,S_DATE,user_id,med_MEZAN,MASTER_ACC_NO,MASTER_PREV_NO) values('A',
                         '" + lcAccNo + "','A1110','" + txtMainLcAccNo.Text + "','" + accDesc + "','" + accDesc_E +
                            "','1','4','" + txtMainLcAccNo.Text + "','0','125','" + addDate + "','" + Program.userID + "','1108','12','" + txtMainLcAccNo.Text + "')");

                dal.Execute_1(@"insert into payer2 (acc_type,ACC_NO,BRANCH_code,MAIN_NO,PAYER_NAME,payer_l_name,t_final,t_level
                        ,PREV_NO,balance,MAIN_MEZAN,S_DATE,user_id,med_MEZAN,MASTER_ACC_NO,MASTER_PREV_NO) values('A',
                         '" + lcAccNo + "','" + txtBranch.txtAccBranch.Text + "','" + txtMainLcAccNo.Text + "','" + accDesc + "','" + accDesc_E +
                           "','1','4','" + txtMainLcAccNo.Text + "','0','125','" + addDate + "','" + Program.userID + "','1108','12','" + txtMainLcAccNo.Text + "')");

                dal.Execute_1(@"update LcsTbl set  LcAccNo ='" + lcAccNo + "' where LcNo='" + LcNo.Text + "' ");
                txtLcAcc.ID.Text = lcAccNo;
            }
        }

        private void txtArivePort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRate_KeyUp(object sender, KeyEventArgs e)
        {
            clc_openFees();
        }

        private void txtLcAcc_Load(object sender, EventArgs e)
        {
            if (txtLcAcc.ID.Text.Trim()!=String.Empty)
            {
                btnAddLcAcc.Enabled = false;
              
            }
            else
            {
                btnAddLcAcc.Enabled = true;
            }
        }

        private void btnChechAcc_Click(object sender, EventArgs e)
        {
          DataTable dtCheckAcc = dal.getDataTabl_1(@"SELECT ACC_NO,PAYER_NAME,payer_l_name FROM payer2 where PAYER_NAME like '%"+LcNo.Text+"%' and MAIN_NO='"+txtMainLcAccNo.Text+"'");
            if (dtCheckAcc.Rows.Count > 0)
            {
                //dgAccNo.Rows.Clear();
                dgAccNo.DataSource = dtCheckAcc;
            }
            else
            {
                dgAccNo.DataSource = null;
                dgAccNo.Rows.Clear();
            }
        }

        private void txtopenFess_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgAccNo_DoubleClick(object sender, EventArgs e)
        {
            txtLcAcc.ID.Text= dgAccNo.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnStatment_Click(object sender, EventArgs e)
        {
            RPT.frm_statment_Rpt frm = new RPT.frm_statment_Rpt();
            frm.UC_Acc1.ID.Text = txtLcAcc.ID.Text;
            frm.ShowDialog();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            //Load the PDF document
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument("C:\\test\\investment_form.pdf");
            //Gets the first page of the document
            PdfLoadedPage page = loadedDocument.Pages[0] as PdfLoadedPage;
            //Get the loaded form
            PdfLoadedForm form = loadedDocument.Form;
            //Fill the fields from the first page
           // (form.Fields["1"] as PdfLoadedTextBoxField).Text = DateTime.Now.ToString("dd/MM/yyyy");
            (form.Fields["LCExpiryDate"] as PdfLoadedTextBoxField).Text = ExpiryDate.Value.ToString("dd/MM/yyyy");
            (form.Fields["Beneficiary"] as PdfLoadedTextBoxField).Text = txtSupplier.Desc.Text;
            (form.Fields["Beneficiary_2"] as PdfLoadedTextBoxField).Text = txtAddress.Text;
          //  (form.Fields["114"] as PdfLoadedCheckBoxField).Checked = true;
            (form.Fields["Amount"] as PdfLoadedTextBoxField).Text = Amount.Text;
            ////Sign a PDF file
            //PdfLoadedSignatureField signatureField = loadedDocument.Form.Fields[9] as PdfLoadedSignatureField;
            //PdfCertificate certificate = new PdfCertificate(@"PDF.pfx", "syncfusion");
            //signatureField.Signature = new PdfSignature(loadedDocument, page, certificate, "Signature", signatureField);
            //PdfBitmap signatureImage = new PdfBitmap(@"signature.jpg");
            //signatureField.Signature.Appearance.Normal.Graphics.DrawImage(signatureImage, new PointF(5, 5), new SizeF(100, 20));
            ////Save the document

            loadedDocument.Save("Form.pdf");
            //Close the document
            loadedDocument.Close(true);
            //This will open the PDF file so, the result will be seen in default PDF viewer
            Process.Start("Form.pdf");

        }

        private void txtSupplier_Load(object sender, EventArgs e)
        {
            DataTable dtSupp = dal.getDataTabl_1("select adress from payer2 where acc_no='"+txtSupplier.ID.Text+"'");
            if (dtSupp.Rows.Count > 0)
            {
                txtAddress.Text = dtSupp.Rows[0]["adress"].ToString();
            }
        }

        private void txtMainLcAccNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void doubleInput2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel5_Click(object sender, EventArgs e)
        {

        }

        private void uC_Items1_Click(object sender, EventArgs e)
        {
            try
            {
                PL.frm_search_items frm = new PL.frm_search_items();
                frm.ShowDialog();
           //     uC_Items1.ID.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                //get_balance();
            }
            catch { }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            RPT.frm_statment_Rpt frm = new RPT.frm_statment_Rpt();
            frm.UC_Acc1.ID.Text = txtLcAcc.ID.Text;
            frm.ShowDialog();
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            Frm_uploadImage frmUpload = new Frm_uploadImage();
            frmUpload.p_id = this.LcNo.Text;
            frmUpload.ShowDialog();
        }

        private void btnPrintForm_Click(object sender, EventArgs e)
        {
            //Load the PDF document
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument("C:\\test\\investment_form.pdf");
            //Gets the first page of the document
            PdfLoadedPage page = loadedDocument.Pages[0] as PdfLoadedPage;
            //Get the loaded form
            PdfLoadedForm form = loadedDocument.Form;
            //Fill the fields from the first page
            (form.Fields["LCExpiryDate"] as PdfLoadedTextBoxField).Text = ExpiryDate.Value.ToString("dd/MM/yyyy");
            (form.Fields["Beneficiary"] as PdfLoadedTextBoxField).Text = txtSupplier.Desc.Text;
            (form.Fields["Beneficiary_2"] as PdfLoadedTextBoxField).Text = txtAddress.Text;
            (form.Fields["Partial shipment allowed"] as PdfLoadedCheckBoxField).Checked = true;
            (form.Fields["Amount"] as PdfLoadedTextBoxField).Text = Amount.Text;
            (form.Fields["Group20"] as PdfLoadedRadioButtonListField).Items[0].Checked = true;
            (form.Fields["c"] as PdfLoadedTextBoxField).Text = LShipDate.Value.ToString("dd/MM/yyyy");
            (form.Fields["Group1"] as PdfLoadedRadioButtonListField).Items[3].Checked = true;

            ////Sign a PDF fil
            //PdfLoadedSignatureField signatforureField = loadedDocument.Form.Fields[9] as PdfLoadedSignatureField;
            //PdfCertificate certificate = new PdfCertificate(@"PDF.pfx", "syncfusion");
            //signatureField.Signature = new PdfSignature(loadedDocument, page, certificate, "Signature", signatureField);
            //PdfBitmap signatureImage = new PdfBitmap(@"signature.jpg");
            //signatureField.Signature.Appearance.Normal.Graphics.DrawImage(signatureImage, new PointF(5, 5), new SizeF(100, 20));
            ////Save the document

            loadedDocument.Save("Form.pdf");
            //Close the document
            loadedDocument.Close(true);
            //This will open the PDF file so, the result will be seen in default PDF viewer
            Process.Start("Form.pdf");

        }

        private void labelX53_Click(object sender, EventArgs e)
        {

        }

        private void uC_Items1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode==Keys.Enter && uC_Items1.ID.Text != string.Empty)
            //{
            //    txtNote.Focus();
            //}
        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void AcceptDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtComnication_KeyUp(object sender, KeyEventArgs e)
        {
            TotalFess.Value = txtopenFess.Value + txtComnication.Value + txtotharFess.Value + txtAcceptance.Value + txtMuskDownP.Value;

            if (OpenDate.Value < new DateTime(2020, 7, 1))
            {
                txtVat.Value = TotalFess.Value * .05;
            }
            else
            {
                txtVat.Value = TotalFess.Value * .15;
            }
            txtTotal.Value = TotalFess.Value + txtVat.Value;

        }

        private void btn_Add_Preforma_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {


            string path = @"\\192.168.101.4\LC_Folder\"+LcNo.Text.Trim();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Directory.CreateDirectory(path.ToString() + @"\LcDocuments");
                Directory.CreateDirectory(path.ToString() + @"\LcInvoces");
                Directory.CreateDirectory(path.ToString() + @"\LcSaber");
                Directory.CreateDirectory(path.ToString() + @"\LcCustoms");
                Directory.CreateDirectory(path.ToString() + @"\LcMTC");
                MessageBox.Show("Directory created");
            }

        }

        private void createFolder(string folderPath,string folderName)
        {
            string path = folderPath  +"\\"+folderName;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Directory.CreateDirectory(path.ToString() + @"\LcDocuments");
                Directory.CreateDirectory(path.ToString() + @"\LcInvoces");
                Directory.CreateDirectory(path.ToString() + @"\LcSaber");
                Directory.CreateDirectory(path.ToString() + @"\LcCustoms");
                Directory.CreateDirectory(path.ToString() + @"\LcMTC");
                MessageBox.Show("Directory created");
            }

        }

        private void btnUploadDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.Filter = "All Files|*.*|pdf|*.pdf|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            opnFile.FilterIndex = 2;
            opnFile.Multiselect = true;
            if (opnFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string p in opnFile.FileNames)
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dt.Columns.Add("path");
                    dt.Columns.Add("Extension");
                    DataRow _ravi = dt.NewRow();
                    _ravi["path"] = Path.GetFileName(p);
                    dt.Rows.Add(_ravi);
                  //  string newPath = @"\\192.168.101.4\LC_Folder\" + LcNo.Text.Trim() + @"\LcDocuments\" + _ravi["path"].ToString().Trim();

                    string newLcDir = @"\\192.168.101.4\LC_Folder\" + LcNo.Text.Trim();
                    string newDirPath = newLcDir + @"\LcDocuments";
                    string newPath = newDirPath + @"\" + _ravi["path"].ToString().Trim();
                    if (!Directory.Exists(newLcDir))
                    {
                        Directory.CreateDirectory(newLcDir);
                    }
                    if (!Directory.Exists(newDirPath))
                    {
                        Directory.CreateDirectory(newDirPath);
                    }

                    File.Copy(p,newPath);
                  
                }
            }
        }

        private void btnViewDoc_Click(object sender, EventArgs e)
        {
            if (LcNo.Text.Trim() != string.Empty)
            {
                string newPath = @"\\192.168.101.4\LC_Folder\" + LcNo.Text.Trim() + @"\LcDocuments";
                if (!Directory.Exists(newPath))
                {
                    MessageBox.Show("Folder Not Exists");
                }
                else
                {
                    Process.Start("explorer.exe", newPath);
                }
                    

            }
            
          

        }

        private void btnUploadSaber_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.Filter = "All Files|*.*|pdf|*.pdf|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            opnFile.FilterIndex = 2;
            opnFile.Multiselect = true;
            if (opnFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string p in opnFile.FileNames)
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dt.Columns.Add("path");
                    dt.Columns.Add("Extension");
                    DataRow _ravi = dt.NewRow();
                    _ravi["path"] = Path.GetFileName(p);
                    dt.Rows.Add(_ravi);
                    string newLcDir = @"\\192.168.101.4\LC_Folder\" + LcNo.Text.Trim();
                    string newDirPath = newLcDir + @"\LcSaber";
                    string newPath = newDirPath + @"\" + _ravi["path"].ToString().Trim();
                    if (!Directory.Exists(newLcDir))
                    {
                        Directory.CreateDirectory(newLcDir);
                    }
                    if (!Directory.Exists(newDirPath))
                    {
                        Directory.CreateDirectory(newDirPath);
                    }

                    File.Copy(p, newPath);

                }
            }
        }

        private void btnViewSaber_Click(object sender, EventArgs e)
        {

            if (LcNo.Text.Trim() != string.Empty)
            {
                string newPath = @"\\192.168.101.4\LC_Folder\" + LcNo.Text.Trim() + @"\LcSaber";

                if (!Directory.Exists(newPath))
                {
                    MessageBox.Show("Folder Not Exists");
                }
                else
                {
                    Process.Start("explorer.exe", newPath);
                }
            }
        }

        private void btnUploadCustom_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.Filter = "All Files|*.*|pdf|*.pdf|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            opnFile.FilterIndex = 2;
            opnFile.Multiselect = true;
            if (opnFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string p in opnFile.FileNames)
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dt.Columns.Add("path");
                    dt.Columns.Add("Extension");
                    DataRow _ravi = dt.NewRow();
                    _ravi["path"] = Path.GetFileName(p);
                    dt.Rows.Add(_ravi);
                    string newLcDir = @"\\192.168.101.4\LC_Folder\" + LcNo.Text.Trim();
                    string newDirPath = newLcDir + @"\LcCustoms";
                    string newPath = newDirPath + @"\" + _ravi["path"].ToString().Trim();
                    if (!Directory.Exists(newLcDir))
                    {
                        Directory.CreateDirectory(newLcDir);
                    }
                    if (!Directory.Exists(newDirPath))
                    {
                        Directory.CreateDirectory(newDirPath);
                    }

                    File.Copy(p, newPath);

                }
            }
        }

        private void btnViewCustom_Click(object sender, EventArgs e)
        {
            if (LcNo.Text.Trim() != string.Empty)
            {
                string newPath = @"\\192.168.101.4\LC_Folder\" + LcNo.Text.Trim() + @"\LcCustoms";
                if (!Directory.Exists(newPath))
                {
                    MessageBox.Show("Folder Not Exists");
                }
                else
                {
                    Process.Start("explorer.exe", newPath);
                }
            }
        }

        private void btnUploadInv_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.Filter = "All Files|*.*|pdf|*.pdf|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            opnFile.FilterIndex = 2;
            opnFile.Multiselect = true;
            if (opnFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string p in opnFile.FileNames)
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dt.Columns.Add("path");
                    dt.Columns.Add("Extension");
                    DataRow _ravi = dt.NewRow();
                    _ravi["path"] = Path.GetFileName(p);
                    dt.Rows.Add(_ravi);
                    string newLcDir = @"\\192.168.101.4\LC_Folder\" + LcNo.Text.Trim();
                    string newDirPath = newLcDir + @"\LcInvoces";
                    string newPath = newDirPath + @"\" + _ravi["path"].ToString().Trim();
                    if (!Directory.Exists(newLcDir))
                    {
                        Directory.CreateDirectory(newLcDir);
                    }
                    if (!Directory.Exists(newDirPath))
                    {
                        Directory.CreateDirectory(newDirPath);
                    }

                    File.Copy(p, newPath);

                }
            }

        }

        private void btnViewInv_Click(object sender, EventArgs e)
        {
            if (LcNo.Text.Trim() != string.Empty)
            {
                string newPath = @"\\192.168.101.4\LC_Folder\" + LcNo.Text.Trim() + @"\LcInvoces";
                if (!Directory.Exists(newPath))
                {
                    MessageBox.Show("Folder Not Exists");
                }
                else
                {
                    Process.Start("explorer.exe", newPath);
                }
            }

        }
    }
}
