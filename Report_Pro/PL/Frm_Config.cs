using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
//
using System.Windows.Forms;

namespace Report_Pro.PL{

    public partial class Frm_Config : DevExpress.XtraEditors.XtraForm
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        /// <summary>
        /// جزء من كود عدم تكرار الفتح للفورم
        /// </summary>
        private static Frm_Config frm = null;
        //---------

        public Frm_Config()
        {

            // كود منع تكرار فتح الفورم---------

            // If the form already exists, and has not been closed
            if (frm != null && !frm.IsDisposed)
            {
                frm.Focus();            // Bring the old one to top
                Shown += (s, e) => this.Close();  // and destroy the new one.
                return;
            }

            // Otherwise store this one as reference
            frm = this;
            //--------------------------------


            InitializeComponent();
            try
            {
                cmb_DB_1.DataSource = dal.getDataTabl("get_DB_");
                cmb_DB_1.DisplayMember = "name";
                cmb_DB_1.ValueMember = "database_id";
        }
            catch { }
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                Report_P.Items.Add(strPrinter);
                Invoice_P.Items.Add(strPrinter);
                Barcode_P.Items.Add(strPrinter);
            }
           
                txtServer.Text = Properties.Settings.Default.Server;
                txtDB.Text = Properties.Settings.Default.Database;
                cmb_DB_1.Text = Properties.Settings.Default.Database_1;
                if (Properties.Settings.Default.Mode == "sql")
                {
                    RbSql.Checked = true;
                    txtId.Text = Properties.Settings.Default.Id;
                    txtPWD.Text = Properties.Settings.Default.Password;
                }
                else
                {
                    RbWindows.Checked = true;
                    txtId.Clear();
                    txtPWD.Clear();
                    txtId.ReadOnly = true;
                    txtPWD.ReadOnly = true;
                }
           
            DataTable dt_currency = dal.getDataTabl_1("select * from " + dal.db1 + ".dbo.Wh_Currency");
            comboBox1.DataSource = dt_currency;
            comboBox1.ValueMember = "Currency_Code";
            comboBox1.DisplayMember = "Currency_Name";

            Report_P.SelectedItem = Properties.Settings.Default.Report_P;
            Invoice_P.SelectedItem = Properties.Settings.Default.Invoice_P;
            Barcode_P.SelectedItem = Properties.Settings.Default.Barcode_P;
            company_name.Text = Properties.Settings.Default.head_txt;
            company_name_EN.Text = Properties.Settings.Default.head_txt_EN;
            Branch_Name.Text = Properties.Settings.Default.Branch_txt;
            Branch_Name_EN.Text = Properties.Settings.Default.Branch_txt_EN;
            txtCloseAcc.Text = Properties.Settings.Default.closeAcc;
            comboBox1.Text = Properties.Settings.Default.Currency;
            cmbdigits.Value = Properties.Settings.Default.digitNo_;
            fontSize.Value = Properties.Settings.Default.font_;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDB.Text;
            Properties.Settings.Default.Database_1 = cmb_DB_1.Text;
            Properties.Settings.Default.Mode = RbSql.Checked == true ? "sql" : "windows";
            Properties.Settings.Default.Id = txtId.Text;
            Properties.Settings.Default.Password = txtPWD.Text;
            Properties.Settings.Default.head_txt = company_name.Text;
            Properties.Settings.Default.head_txt_EN = company_name_EN.Text;
            Properties.Settings.Default.Branch_txt = Branch_Name.Text;
            Properties.Settings.Default.Branch_txt_EN= Branch_Name_EN.Text;
            Properties.Settings.Default.closeAcc = txtCloseAcc.Text;
            
            Properties.Settings.Default.Save();


            Frm_Main.ActiveForm.Dispose();
            Frm_Main sd = new Frm_Main();
            sd.Show();


            MessageBox.Show("تمت الاعدادات بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RbSql_CheckedChanged(object sender, EventArgs e)
        {
            txtId.ReadOnly = false;
            txtPWD.ReadOnly = false;
        }

        private void RbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            txtPWD.ReadOnly = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnsave1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Report_P = Report_P.Text;
            Properties.Settings.Default.Invoice_P = Invoice_P.Text;
            Properties.Settings.Default.Barcode_P = Barcode_P.Text;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.digitNo_ = cmbdigits.Value;
            //Properties.Settings.Default.head_txt = company_name.Text;
            Properties.Settings.Default.EmailCC = txtCC.Text;
            Properties.Settings.Default.Currency =Convert.ToString(comboBox1.SelectedValue);
            Properties.Settings.Default.font_ = fontSize.Value;
            Properties.Settings.Default.Save();
        }

        private void CompanyDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CompanyDB.SelectedIndex == 0)
            {
                cmb_DB_1.Text = "MAIN_ACC_WH";
            }
            else if (CompanyDB.SelectedIndex == 1)
            {
                cmb_DB_1.Text = "FACTORY";
            }
            else if (CompanyDB.SelectedIndex == 2)
            {
                cmb_DB_1.Text = "CUST_ACC_WH";
            }
            else if (CompanyDB.SelectedIndex == 3)
            {
                cmb_DB_1.Text = "Qatar";
            }
            else if (CompanyDB.SelectedIndex == 4)
            {
                cmb_DB_1.Text = "Kuwait";
            }
            else if (CompanyDB.SelectedIndex == 5)
            {
                cmb_DB_1.Text = "Bahrain";
            }
            else if (CompanyDB.SelectedIndex == 6)
            {
                cmb_DB_1.Text = "Oman";
            }
        }


        private void cmb_DB_1_TextChanged(object sender, EventArgs e)
        {
            if (cmb_DB_1.Text.Contains("main_acc_wh"))
            {
                CompanyDB.Text = "شركة عثمان عبد الرحمن العصيمي وشركاة التجارية";
                company_name.Text = "شركة عثمان عبد الرحمن العصيمي وشركاة التجارية";
                company_name_EN.Text = "Otman A. Alusaimi & Partners Trading Company";
                Branch_Name.Text = "التجارية";
                Branch_Name_EN.Text = "Trading";
            }
            else if (cmb_DB_1.Text.Contains("cust_acc_wh"))
            {
                CompanyDB.Text = "شركة عثمان عبد الرحمن العصيمي وشريكه للنقليات";
               company_name.Text = "شركة عثمان عبد الرحمن العصيمي وشريكه للنقليات";
                company_name_EN.Text = "Otman A. Alusaimi & Partner Transportation Company";
                Branch_Name.Text = "";
                Branch_Name_EN.Text = "";
            }
            else if (cmb_DB_1.Text.Contains("Factory"))
            {
                CompanyDB.Text = "مصنع عثمان عبد الرحمن العصيمي وشركاة للحديد والصلب";
                company_name.Text = "مصنع عثمان عبد الرحمن العصيمي وشركاة للحديد والصلب";
                company_name_EN.Text = "Otman A. Alusaimi & Partners Factory";
                Branch_Name.Text = "";
                Branch_Name_EN.Text = "";
            }
            else if(cmb_DB_1.Text.Contains("Bahrain"))
            {
                CompanyDB.Text = "شركة عثمان عبد الرحمن العصيمي وشركاة التجارية";
                company_name.Text = "شركة عثمان عبد الرحمن العصيمي وشركاة التجارية";
                company_name_EN.Text = "Otman A. Alusaimi & Partners Trading Company";
                Branch_Name.Text = "فرع البحرين";
                Branch_Name_EN.Text = "Bahrain Branch";
            }
            else if (cmb_DB_1.Text.Contains("Qatar"))
            {
                CompanyDB.Text = "الشركة القطرية لتوزيع الحديد الصناعي";
                company_name.Text = "الشركة القطرية لتوزيع الحديد الصناعي";
                company_name_EN.Text = "AlQataria For Industrail Steel";
                Branch_Name.Text = "فرع قطر";
                Branch_Name_EN.Text = "Qatar Branch";

            }
            else if (cmb_DB_1.Text.Contains("Kuwait"))
            {
                CompanyDB.Text = "مؤسسة عبد الرحمن عثمان العصيمي للمواد الانشائية";
                company_name.Text = "مؤسسة عبد الرحمن عثمان العصيمي للمواد الانشائية";
                company_name_EN.Text = "Abdelrahman Othman Alusaimi Est";
                Branch_Name.Text = "فرع الكويت";
                Branch_Name_EN.Text = "Kuwait Branch";

            }
            else if (cmb_DB_1.Text.Contains("Oman"))
            {
                CompanyDB.Text = "شركة العصيمي العالمية";
                company_name.Text = "شركة العصيمي العالمية";
                company_name_EN.Text = " Alusaimi Univrsal Company";
                Branch_Name.Text = "فرع عمان";
                Branch_Name_EN.Text = "Oman Branch";

            }
        }

        private void Frm_Config_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           //// integrated security=false; user id =  bilal ; password = hassan"

           // string connection_string = "";
           // connection_string = "Data Source=";
           // connection_string += txtServer.Text.Trim();
           
           // connection_string += ";Initial Catalog=";
           // connection_string += cmb_DB_1.Text;
           // connection_string += ";integrated security=false";

           // connection_string += "; user id = ";
           // connection_string += txtId.Text;
           // connection_string += "; password =";
           // connection_string += txtPWD.Text;
           // connection_string += ";";

           // //conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

           // //config.ConnectionStrings.ConnectionStrings["SQLdb"].ConnectionString = connection_string;

           // //config.Save(ConfigurationSaveMode.Modified);

           // ConfigurationManager.RefreshSection("connectionStrings");



            //string fpath = Application.StartupPath + "\\Skin\\GlassGreen.ssk";

            //this.skinEngine1.SkinFile = fpath;
        }
    }
}
