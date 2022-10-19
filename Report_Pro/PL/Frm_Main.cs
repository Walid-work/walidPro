using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing; using System.Linq;

using System.Text;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;
//using UserRoles;

namespace Report_Pro.PL
{
    public partial class Frm_Main : Form
    {

        TreeNode _selectedNode = null;
        TreeNode _selectedStore = null;
        TreeNode _selectedBranch = null;
        Color c;
        DataTable _acountsTb = null;
        DataTable dt_C_ch;
        DataTable dt_C_Ma;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Frm_Main()
        {

            InitializeComponent();
            dt_C_ch = dal.getDataTabl_1(@"SELECT *  FROM ReportDB.dbo.setting_bg_font  where ID='Chiled'");
            dt_C_Ma = dal.getDataTabl_1(@"SELECT *  FROM ReportDB.dbo.setting_bg_font  where ID='main'");
            //Color c = Color.FromArgb(dt_C_Ma.Rows[0][1].ToString().ParseInt(), dt_C_Ma.Rows[0][2].ToString().ParseInt(), dt_C_Ma.Rows[0][3].ToString().ParseInt());

            this.Text = Properties.Settings.Default.head_txt;
            this.panel2.Dock = DockStyle.Fill;
        }




        //private void openForm(Form form, FormWindowState frmstate, int allowMultiOpen)
        //{
        //    foreach (Form frm in Application.OpenForms)
        //    {
        //        if (frm.Name == "login_frm" || frm.Name == "Frm_Main") continue;
        //        if (allowMultiOpen == 0)
        //        {
        //            if (form.Name == frm.Name)
        //            {
        //                frm.Activate();
        //                return;
        //            }
        //        }
        //    }



        //   // Color c = Color.FromArgb(dt_C_ch.Rows[0][1].ToString().ParseInt(), dt_C_ch.Rows[0][2].ToString().ParseInt(), dt_C_ch.Rows[0][3].ToString().ParseInt());
        //    form.BackColor = c;
        //    if (form.Controls.OfType<TabControl>().Count() > 0)
        //    {
        //        foreach (TabControl tc in form.Controls)
        //        {

        //            foreach (TabPage tb in tc.TabPages)
        //            {
        //                tb.BackColor = c;
        //            }

        //        }

        //    }

        //    Size S = form.Size;
        //    form.Font = new Font(form.Font.Name, Program.FS, form.Font.Style);

        //    foreach (Control ctrl in form.Controls)
        //    {
        //        //if (ctrl.Controls != null)

        //        //   SetAllControlsFont(ctrl);

        //        ctrl.Font = new Font(form.Font.Name, Program.FS, form.Font.Style);

        //    }
        //    form.Size = S;
        //    form.TopLevel = false;

        //    this.panel2.Controls.Add(form);
        //    //this.panel2.Dock = DockStyle.Fill;
        //    //form.Dock = DockStyle.Fill;

        //    ////form.MdiParent = this;
        //    form.WindowState = frmstate;
        //    form.Show();
        //    form.BringToFront();
        //    form.Location = new Point(
        //    (panel2.Location.X + panel2.Width / 2) - (form.Width / 2),
        //    (panel2.Location.Y + panel2.Height / 2) - (form.Height / 2));
        //    form.StartPosition = FormStartPosition.Manual;

        //}


        private void openForm(Form form, FormWindowState frmstate, int allowMultiOpen)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "login_frm" || frm.Name == "Frm_Main") continue;
                if (allowMultiOpen == 0)
                {
                    if (form.Name == frm.Name)
                    {
                        frm.Activate();
                        frm.BringToFront();
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        return;
                    }
                }
            }



            //// Color c = Color.FromArgb(dt_C_ch.Rows[0][1].ToString().ParseInt(), dt_C_ch.Rows[0][2].ToString().ParseInt(), dt_C_ch.Rows[0][3].ToString().ParseInt());
            //form.BackColor = c;
            //if (form.Controls.OfType<TabControl>().Count() > 0)
            //{
            //    foreach (TabControl tc in form.Controls)
            //    {

            //        foreach (TabPage tb in tc.TabPages)
            //        {
            //            tb.BackColor = c;
            //        }

            //    }

            //}

            Size S = form.Size;
          //  form.Font = new Font(form.Font.Name, Properties.Settings.Default.font_, form.Font.Style);

            //foreach (Control ctrl in form.Controls)
            //{
            //    //if (ctrl.Controls != null)

            //    //   SetAllControlsFont(ctrl);

            //    ctrl.Font = new Font(form.Font.Name, Properties.Settings.Default.font_, form.Font.Style);

            //}
            form.Size = S;
            form.TopLevel = false;

            this.panel2.Controls.Add(form);
            this.panel2.Dock = DockStyle.Fill;
            form.Dock = DockStyle.Fill;
           // form.StartPosition = FormStartPosition.CenterScreen;

            //form.MdiParent = this;
            form.WindowState = frmstate;
            form.Show();
            form.BringToFront();
            //form.Location = new Point(
            //(panel2.Location.X + panel2.Width / 2) - (form.Width / 2),
            //(panel2.Location.Y + panel2.Height / 2) - (form.Height / 2));
            //form.StartPosition = FormStartPosition.Manual;

        }


        private void Frm_Main_Load(object sender, EventArgs e)
        {
          //  this.Location = new Point(0, 0);

          //this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            this.Controls.OfType<MdiClient>().FirstOrDefault().BackColor = c;
            this.panel1.BackColor = c;
            this.listView1.BackColor = c;

            _acountsTb = dal.getDataTabl("get_SM");
            TreeNode tr = new TreeNode();
            if (Properties.Settings.Default.lungh == "0")
            {
                tr.Text = "الصفحة الرئيسية";
            }
            else
            {
                tr.Text = "Home";
            }
            tr.Name = "0";
            TV1.Nodes.Add(tr);
            PopulateTreeView_Menue("0", null);
            //loadMenu();

            // listView1.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void loadMenu()
        {
            _acountsTb = dal.getDataTabl("get_SM");
            TreeNode tr = new TreeNode();
            if (Properties.Settings.Default.lungh == "0")
            {
                tr.Text = "الصفحة الرئيسية";
            }
            else
            {
                tr.Text = "Home";
            }
            tr.Name = "0";
            TV1.Nodes.Add(tr);
            PopulateTreeView_Menue("0", null);
        }

        private void PopulateTreeView_Menue(string parentId, TreeNode parentNode)
        {
            TreeNode childNode;

            foreach (DataRow dr in _acountsTb.Select("prev_no = '" + parentId + "'"))
            {
                TreeNode t = new TreeNode();
                if (Properties.Settings.Default.lungh == "0")
                {
                    t.Text =/* dr["Menu_code"].ToString() + " - " +*/ dr["Menu_name"].ToString();
                }
                else
                {
                    t.Text =/* dr["Menu_code"].ToString() + " - " +*/ dr["Menu_E_Name"].ToString();
                }
                t.Name = dr["Menu_code"].ToString();
                t.Tag = _acountsTb.Rows.IndexOf(dr);
                if (dr["T_final"].ToString() == "0")
                {
                    t.ImageIndex = 0;
                    t.SelectedImageIndex = 1;
                }
                else
                {
                    t.ImageIndex = 2;
                    t.SelectedImageIndex = 6;
                }
                if (parentNode == null)
                {
                    TV1.Nodes[0].Nodes.Add(t);
                    //TV1.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }

                PopulateTreeView_Menue((dr["Menu_code"].ToString()), childNode);
            }
        }



        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openForm(new PL.Frm_Config(), FormWindowState.Maximized, 0);
        }

        private void M312_Click(object sender, EventArgs e)
        {
          //openForm((Form)new frmListPrice(), FormWindowState.Maximized, 0);
        }

        private void M716_Click(object sender, EventArgs e)
        {
            openForm((Form)new RPT.frm_rep_Fees(), FormWindowState.Maximized, 0);
        }

        private void M26_Click(object sender, EventArgs e)
        {
            openForm((Form)new RPT.frm_transRepot(), FormWindowState.Maximized, 0);
        }

        private void M313_Click(object sender, EventArgs e)
        {
            openForm((Form)new frmDelivryNote(), FormWindowState.Maximized, 0);
        }



        private void tsbtnTransRep_Click(object sender, EventArgs e)
        {
            openForm(new RPT.Rpt_Trans_Detials(), FormWindowState.Maximized, 0);
        }
        private void tsbtnMantinancRep_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnPurchaseRep_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_trns_purch(), FormWindowState.Maximized, 0);
        }

        private void tsbtn_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_tot_customers(), FormWindowState.Maximized, 0);
        }

        private void tsbtnTotalRep_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_Sales_by_Br(), FormWindowState.Maximized, 0);
        }

        private void tsbtnVatSales_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Export_sales(), FormWindowState.Maximized, 0);
        }

        private void tsbtnUpdateData_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_Update_custom_no(), FormWindowState.Normal, 0);
        }

        private void tsbtnProjects_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_project_materails(), FormWindowState.Maximized, 0);
        }

        private void tsbtnInventory_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_inventory(), FormWindowState.Maximized, 0);
        }

        private void tsbtnTB_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_TB(), FormWindowState.Maximized, 0);
        }

        private void tsbtnStatment_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_statment_Rpt(), FormWindowState.Maximized, 0);
        }

        private void tsbtnAgeing_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frmAgeReport(), FormWindowState.Maximized, 0);
        }


        private void stbtnLastPurchase_Click(object sender, EventArgs e)
        {
            openForm(new RPT.Purchase_reports(), FormWindowState.Maximized, 0);
        }

        private void tsbtnPurchasesRep_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frmPurchase_rpt(), FormWindowState.Maximized, 0);
        }

        private void tsbtnCostTB_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_CostCenter_TB(), FormWindowState.Maximized, 0);
        }

        private void tsbtnItemsTrans_Click(object sender, EventArgs e)
        {

        }

        private void tstbtnTablesUpdate_Click(object sender, EventArgs e)
        {

            DataTable dt_ = new DataTable();
            //dt_ = dal.getDataTabl_1(@"select TABLE_CATALOG,TABLE_NAME,COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE from main_acc_wh.INFORMATION_SCHEMA.COLUMNS ");
            dt_ = dal.getDataTabl_1(@"select * from "+Properties.Settings.Default.Database+"dbo.SysMenu ");

            OleDbConnection conn = new OleDbConnection();
            string cnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + System.IO.Directory.GetCurrentDirectory() + "\\adj.mdb";
            conn = new OleDbConnection(cnString);

            OleDbCommand cmd = new OleDbCommand("delete from SysMenu", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();

            //for (int ii = 0; ii < dt_.Rows.Count; ii++)
            //{
            foreach (DataRow DR in dt_.Rows)
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO SysMenu  VALUES(" +DR.ItemArray +")", conn);
                command.ExecuteNonQuery();
            }
            conn.Close();

        }

        private void tsUpdateCustData_Click(object sender, EventArgs e)
        {
            openForm(new PL.UpdateAccData(), FormWindowState.Maximized, 0);
        }

        private void tsbtnBackColor_Click(object sender, EventArgs e)
        {
            openForm(new PL.background(), FormWindowState.Maximized, 0);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openForm(new PL.OpenedForms(), FormWindowState.Maximized, 0);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_check_item_Price(), FormWindowState.Maximized, 0);
        }

        private void btnCustomerTB_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Customers_TB(), FormWindowState.Maximized, 0);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_update_trans_invoice(), FormWindowState.Maximized, 0);
        }

        private void تقاريرالجردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Inventory_Count(), FormWindowState.Maximized, 0);
        }

        private void كارتالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Item_Transaction(), FormWindowState.Maximized, 0);
        }

        private void btnBalanceSheet_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_BalanceSheet(), FormWindowState.Maximized, 0);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_BS_elements(), FormWindowState.Maximized, 0);
        }

        private void btn_R_Qutation_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_R_Qutaion(), FormWindowState.Maximized, 0);
        }

      

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem3_Click_1(object sender, EventArgs e)
        {

        }

        private void M11_Click(object sender, EventArgs e)
        {
            openForm(new PL.Frm_Config(), FormWindowState.Maximized, 0);
        }

        private void M2_Click(object sender, EventArgs e)
        {

        }

        private void M21_Click(object sender, EventArgs e)
        {
            openForm(new RPT.Rpt_Trans_Detials(), FormWindowState.Maximized, 0);
        }

        private void M22_Click(object sender, EventArgs e)
        {
            openForm(new RPT.rpt_Mantinance(), FormWindowState.Maximized, 0);
        }

        private void M23_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_trns_purch(), FormWindowState.Maximized, 0);
        }

        private void M24_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_tot_customers(), FormWindowState.Maximized, 0);

        }

        private void M25_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_update_trans_invoice(), FormWindowState.Maximized, 0);

        }

        private void M31_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_Sales_by_Br(), FormWindowState.Maximized, 0);
        }

        private void M32_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Export_sales(), FormWindowState.Maximized, 0);
        }

        private void M34_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Customers_TB(), FormWindowState.Maximized, 0);
        }

        private void M33_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_check_item_Price(), FormWindowState.Maximized, 0);
        }



        private void M41_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_Purchases(), FormWindowState.Maximized, 0);
        }

        private void M42_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frmPurchase_rpt(), FormWindowState.Maximized, 0);
        }

        private void M43_Click(object sender, EventArgs e)
        {
            openForm(new RPT.Purchase_reports(), FormWindowState.Maximized, 0);
        }

        private void M4_Click(object sender, EventArgs e)
        {

        }

        private void M51_Click(object sender, EventArgs e)
        {
            //openForm(new RPT.frm_rpt_inventory(), FormWindowState.Normal, 0);
            openForm(new RPT.frm_Inventory_Report(), FormWindowState.Normal, 0);

        }

        private void M53_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Item_Transaction(), FormWindowState.Maximized, 0);
        }

        private void حركةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void M54_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Inventory_Count(), FormWindowState.Maximized, 0);
        }

        private void M44_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_R_Qutaion(), FormWindowState.Maximized, 0);
        }

        private void M35_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_Update_custom_no(), FormWindowState.Maximized, 0);
        }

        private void M36_Click(object sender, EventArgs e)
        {
            openForm(new PL.UpdateAccData(), FormWindowState.Maximized, 0);
        }

        private void M61_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_Productin(), FormWindowState.Maximized, 0);
        }

        private void M63_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_project_materails(), FormWindowState.Maximized, 0);
        }

        private void M71_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_statment_Rpt(), FormWindowState.Maximized, 0);
        }

        private void M72_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frmAgeReport(), FormWindowState.Maximized, 0);
        }

        private void M73_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_TB(), FormWindowState.Maximized, 0);
        }

        private void M74_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_CostCenter_TB(), FormWindowState.Maximized, 0);
        }

        private void M75_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_BS_elements(), FormWindowState.Maximized, 0);
        }

        private void M76_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_BalanceSheet(), FormWindowState.Maximized, 0);
        }

        private void M12_Click(object sender, EventArgs e)
        {
            openForm(new PL.background(), FormWindowState.Maximized, 0);
        }

        private void M13_Click(object sender, EventArgs e)
        {
            openForm(new PL.OpenedForms(), FormWindowState.Maximized, 0);
        }

        private void MLangue_Click(object sender, EventArgs e)
        {

            List<Form> formList = new List<Form>();
            foreach (Form openForm in (System.Collections.ReadOnlyCollectionBase)Application.OpenForms)
                formList.Add(openForm);
            foreach (Form form in formList)
            {
                if (form.Name != "Frm_Main" && form.Name != "login_frm")
                    form.Close();
            }
            string ietfLanguageTag = Thread.CurrentThread.CurrentUICulture.IetfLanguageTag;
            if (!(ietfLanguageTag == "ar"))
            {
                if (ietfLanguageTag == "en")
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
                    Properties.Settings.Default.lungh = "0";
                }
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                Properties.Settings.Default.lungh = "1";
            }
            Properties.Settings.Default.Save();
            this.Controls.Clear();
            this.InitializeComponent();
            this.loadMenu();
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;




            //List<Form> openForms = new List<Form>();

            //foreach (Form f in Application.OpenForms)
            //    openForms.Add(f);

            //foreach (Form f in openForms)
            //{
            //    if (f.Name != "Frm_Main" && f.Name != "login_frm")
            //        f.Close();
            //}


            //switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
            //{
            //    case ("ar"): Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en"); Properties.Settings.Default.lungh = "1"; break;
            //    case ("en"): Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar"); Properties.Settings.Default.lungh = "0"; break;
            //}
            //Properties.Settings.Default.Save();
            //this.Controls.Clear();


            //InitializeComponent();
            //loadMenu();
            ////this.WindowState = FormWindowState.Maximized;

        }

        private void M37_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_CashCustomer_statment(), FormWindowState.Maximized, 0);
        }

        private void M45_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_Purch_Qutation(), FormWindowState.Maximized, 0);
        }

        private void buttonItem1_Click_1(object sender, EventArgs e)
        {
            openForm(new PL.frmQuotation(), FormWindowState.Maximized, 0);
        }

        private void M77_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_BS_TB(), FormWindowState.Maximized, 0);
        }

        private void M46_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Compare_PQ(), FormWindowState.Maximized, 0);

        }

        private void M14_Click(object sender, EventArgs e)
        {
            openForm(new PL.Frm_Banks(), FormWindowState.Normal, 0);
        }

        private void M39_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_customer_Facility(), FormWindowState.Maximized, 0);
        }

        private void M15_Click(object sender, EventArgs e)
        {
            openForm(new PL.frmStores(), FormWindowState.Maximized, 0);
        }

        private void M78_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Compare_TB(), FormWindowState.Maximized, 0);
        }

        private void M79_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Confirmation(), FormWindowState.Maximized, 0);
        }

        private void M47_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_R_Matrails(), FormWindowState.Maximized, 0);
        }

        private void M81_Click(object sender, EventArgs e)
        {
            openForm(new PL.frmLcs(), FormWindowState.Maximized, 0);
        }

        private void M82_Click(object sender, EventArgs e)
        {
            openForm(new PL.FrmLcInv(), FormWindowState.Maximized, 0);
        }

        private void M48_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_preform(), FormWindowState.Maximized, 0);
        }

        private void M911_Click(object sender, EventArgs e)
        {
            openForm(new PL.frmAssetesGroup(), FormWindowState.Normal, 0);
        }

        private void M912_Click(object sender, EventArgs e)
        {
            openForm(new PL.frmAssetes(), FormWindowState.Normal, 0);
        }

        private void M913_Click(object sender, EventArgs e)
        {
            openForm(new PL.frmLocations(), FormWindowState.Normal, 0);
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Print_invoice(), FormWindowState.Normal, 0);
        }

        private void buttonItem3_Click_2(object sender, EventArgs e)
        {
            openForm(new Form_1(), FormWindowState.Normal, 0);
        }

        private void M8_Click(object sender, EventArgs e)
        {

        }

        private void M91_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            //  openForm(new PL.frm_deposit(), FormWindowState.Maximized, 0);
              openForm(new Forms.frm_savePicture(), FormWindowState.Maximized, 0);

        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            openForm(new CTR.frm_cash_transaction(), FormWindowState.Maximized, 0);
        }

        private void M64_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_matrail_id(), FormWindowState.Maximized, 0);
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            openForm(new PL.Update_take_to_production(), FormWindowState.Normal, 0);
        }

        private void buttonItem6_Click_1(object sender, EventArgs e)
        {
            // openForm(new PL.frmTest(), FormWindowState.Maximized, 0);
            Form3 frm = new Form3();
            frm.Show();
        }

        private void TV1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataTable dt_icons = dal.getDataTabl("get_SM_1" , TV1.SelectedNode.Name );
            listView1.Items.Clear();
           
            for (int i = 0; i < dt_icons.Rows.Count; i++)
            {
                DataRow dr = dt_icons.Rows[i];
                ListViewItem listitem;
                if (Properties.Settings.Default.lungh == "0")
                {
                     listitem = new ListViewItem(dr["Menu_name"].ToString());
                }
                else
                {
                    listitem = new ListViewItem(dr["Menu_E_Name"].ToString());
                }
                //ListViewItem listitem = new ListViewItem(dr["Menu_name"].ToString());
                listitem.SubItems.Add(dr["Menu_code"].ToString());
                listitem.SubItems.Add(dr["Form_Name"].ToString());
                listitem.SubItems.Add(dr["T_final"].ToString());
                listitem.ImageIndex = Convert.ToInt32(dr["Image_Large_icon"]);
                listView1.Items.Add(listitem);

            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
                if (listView1.SelectedItems[0].SubItems[3].Text == "1")
                {
                    open_form(listView1.SelectedItems[0].SubItems[2].Text, FormWindowState.Maximized, 0);
                }
                else
                {


                    DataTable dt_icons = dal.getDataTabl("get_SM_1", listView1.SelectedItems[0].SubItems[1].Text);
                    listView1.Items.Clear();

                    for (int i = 0; i < dt_icons.Rows.Count; i++)
                    {
                        DataRow dr = dt_icons.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["Menu_name"].ToString());
                        listitem.SubItems.Add(dr["Form_Name"].ToString());
                        listitem.SubItems.Add(dr["T_final"].ToString());
                        listitem.ImageIndex = Convert.ToInt32(dr["Image_Large_icon"]);
                        listView1.Items.Add(listitem);

                    }

                }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void open_form(string F, FormWindowState frmstate, int allowMultiOpen)
        {
            //try
            //{
                Type FormInstanceType = Type.GetType("Report_Pro." + F, true, true);
                Form frm_ = (Form)Activator.CreateInstance(FormInstanceType);

                foreach (Form frm in Application.OpenForms)
                {

                    if (frm.Name == "login_frm" || frm.Name == "Frm_Main") continue;
                if (allowMultiOpen == 0)
                {
                    if (frm_.Name == frm.Name)
                    {
                        frm.Activate();
                        frm.BringToFront();
                    }
                    
                }
              
            }
            //Color c = Color.FromArgb(dt_C_ch.Rows[0][1].ToString().ParseInt(), dt_C_ch.Rows[0][2].ToString().ParseInt(), dt_C_ch.Rows[0][3].ToString().ParseInt());
                frm_.BackColor = c;
                if (frm_.Controls.OfType<TabControl>().Count() > 0)
                {
                    foreach (TabControl tc in frm_.Controls)
                    {

                        foreach (TabPage tb in tc.TabPages)
                        {
                            tb.BackColor = c;
                        }

                    }

                }
           
               
               // frm_.AutoScroll = true;

            //    this.panel2.Controls.Add(frm_);
            //this.panel2.Dock = DockStyle.Fill;

            Size S = frm_.Size;
                frm_.Font = new Font(frm_.Font.Name, Program.FS, frm_.Font.Style);
            foreach (Control ctrl in frm_.Controls)
            {
                ctrl.Font = new Font(frm_.Font.Name, Program.FS, frm_.Font.Style);

            }

            frm_.Size = S;
            frm_.TopLevel = false;

            panel2.Controls.Add(frm_);
            panel2.Dock=DockStyle.Fill;
            frm_.Dock = DockStyle.Fill;

            frm_.WindowState = frmstate;


                frm_.Show();
                //frm_.Activate();
                frm_.BringToFront();
          


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void M710_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_salary(), FormWindowState.Maximized, 0);
        }

        private void btnUpdatetables_Click(object sender, EventArgs e)
        {
            DataTable dt_ = new DataTable();
            //dt_ = dal.getDataTabl_1(@"select TABLE_CATALOG,TABLE_NAME,COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE from main_acc_wh.INFORMATION_SCHEMA.COLUMNS ");
            dt_ = dal.getDataTabl_1(@"select Menu_code,Menu_name,Menu_E_Name,Form_Name,isnull(Software_code,0),Securty_Code,securty_code2,Securty_Mode,MAIN_NO,isnull(Prev_no,0),isnull(T_final,0),isnull(T_Level,0),isnull(Image_Large_icon,0),isnull(Image_Small_Icon,0),Notes,User_id,G_Date,isnull(administrator_level,0),Screen_name from " + Properties.Settings.Default.Database + ".dbo.SysMenu ");
                
            OleDbConnection conn = new OleDbConnection();
            string cnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + System.IO.Directory.GetCurrentDirectory() + "\\adj.mdb";
            conn = new OleDbConnection(cnString);

            OleDbCommand cmd = new OleDbCommand("delete from SysMenu", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();

         
                foreach (DataRow DR in dt_.Rows)
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO SysMenu (Menu_code,Menu_name,Menu_E_Name,Form_Name," +
                        "Software_code,Securty_Code,securty_code2,Securty_Mode,MAIN_NO,Prev_no,T_final,T_Level,Image_Large_icon," +
                        "Image_Small_Icon,Notes,User_id,G_Date,administrator_level,Screen_name)" +
                        "  VALUES('" + DR[0] + "','" + DR[1] + "','" + DR[2] + "','" + DR[3] + "','" + DR[4] + "','" + DR[5] + 
                        "','" + DR[6] + "','" + DR[7] + "','" + DR[8] + "','" + DR[9] + "','" + DR[10] + "','" + DR[11] + 
                        "','" + DR[12] + "','" + DR[13] + "','" + DR[14] + "','" + DR[15] + 
                        "','"+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"','" + DR[17] + "','" + DR[18] + "')", conn);
                    command.ExecuteNonQuery();
                }
            
            conn.Close();

        }

        private void btnAdjData_Click(object sender, EventArgs e)
        {

            DataTable dt_ = new DataTable();

            OleDbConnection conn = new OleDbConnection();
            string cnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + System.IO.Directory.GetCurrentDirectory() + "\\adj.mdb";
            conn = new OleDbConnection(cnString);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = new OleDbDataAdapter("select * from SysMenu", conn);
            da.Fill(dt_);
                      
            dal.Execute_1("delete from " + Properties.Settings.Default.Database + ".dbo.SysMenu");

            foreach (DataRow DR in dt_.Rows)
            {
              dal.Execute_1(@"INSERT INTO " + Properties.Settings.Default.Database + ".dbo.SysMenu (Menu_code,Menu_name,Menu_E_Name,Form_Name," +
                    "Software_code,Securty_Code,securty_code2,Securty_Mode,MAIN_NO,Prev_no,T_final,T_Level,Image_Large_icon," +
                    "Image_Small_Icon,Notes,User_id,G_Date,administrator_level,Screen_name)" +
                    "  VALUES('" + DR[0] + "','" + DR[1] + "','" + DR[2] + "','" + DR[3] + "','" + DR[4] + "','" + DR[5] +
                    "','" + DR[6] + "','" + DR[7] + "','" + DR[8] + "','" + DR[9] + "','" + DR[10] + "','" + DR[11] +
                    "','" + DR[12] + "','" + DR[13] + "','" + DR[14] + "','" + DR[15] +
                    "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "','" + DR[17] + "','" + DR[18] + "')");
               
            }

         

        }

        private void M310_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_MonthelySales(), FormWindowState.Maximized, 0);
        }

        private void M711_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Daliy_rpt(), FormWindowState.Maximized, 0);
        }

        private void M712_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Total_Jor(), FormWindowState.Maximized, 0);
        }

        private void M713_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_Galvanaize(), FormWindowState.Maximized, 0);
        }

        private void M101_Click(object sender, EventArgs e)
        {
            openForm(new PL.Prepaid_expenses(), FormWindowState.Maximized, 0);
        }

        private void M102_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_PE_rpt(), FormWindowState.Maximized, 0);

        }

        private void M714_Click(object sender, EventArgs e)
        {
            //openForm(new PL.frm_DailyEntry(), FormWindowState.Maximized, 0);
           openForm(new PL.frmJornal(), FormWindowState.Maximized, 0);
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_PE_Jor(), FormWindowState.Maximized, 0);

        }

        private void b1_Click(object sender, EventArgs e)
        {

            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void b1_Click_1(object sender, EventArgs e)
        {
            DataTable dt_ = new DataTable();
            dt_ = dal.getDataTabl_1(@"select TABLE_CATALOG,TABLE_NAME,COLUMN_NAME,DATA_TYPE,isnull(CHARACTER_MAXIMUM_LENGTH,0),IS_NULLABLE from main_acc_wh.INFORMATION_SCHEMA.COLUMNS ");
            //dt_ = dal.getdatatabl_1(@"select menu_code,menu_name,menu_e_name,form_name,isnull(software_code,0),securty_code,securty_code2,securty_mode,main_no,isnull(prev_no,0),isnull(t_final,0),isnull(t_level,0),isnull(image_large_icon,0),isnull(image_small_icon,0),notes,user_id,g_date,isnull(administrator_level,0),screen_name from " + properties.settings.default.database + ".dbo.sysmenu ");

            OleDbConnection conn = new OleDbConnection();
            string cnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + System.IO.Directory.GetCurrentDirectory() + "\\adj.mdb";
            conn = new OleDbConnection(cnString);

            OleDbCommand cmd = new OleDbCommand("delete from tatable", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();


            foreach (DataRow DR in dt_.Rows)
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO tatable (database_name,table_name,field_name,field_type,field_size,AllowNull) VALUES('" + DR[0] + "','" + DR[1] + "','" + DR[2] + "','" + DR[3] + "','" + DR[4] + "','" + DR[5] +"')", conn);
                command.ExecuteNonQuery();
            }

            conn.Close();
        }

        private void M104_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_Create_PE_Jor(), FormWindowState.Maximized, 0);
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void M16_Click(object sender, EventArgs e)
        {
            openForm(new PL.frmRate(), FormWindowState.Normal, 0);

        }

        private void M49_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_PurchaseOrder(), FormWindowState.Maximized, 0);
        }

        private void M55_Click(object sender, EventArgs e)
        {
            openForm(new PL.frmProducts(), FormWindowState.Normal, 0);
        }

        private void M410_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Print_invoice(), FormWindowState.Normal, 0);
        }

        private void M311_Click(object sender, EventArgs e)
        {
           // openForm(new PL.frm_Sales_Invoice(), FormWindowState.Maximized, 0);
            openForm(new PL.invoice_frm(), FormWindowState.Maximized, 0);
            //PL.invoice_frm frm = new invoice_frm();
           // frm.Show();
        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
        private void PopulateTreeView_store(   string parentId, TreeNode parentNode)
        {
            TreeNode childNode;
            foreach (DataRow dr in _acountsTb.Select("[PREV_NO]= '" + parentId + "'"))
            {
                TreeNode t = new TreeNode();
                string branch_ = dr["Branch_code"].ToString();
                if (string.IsNullOrEmpty(dr["Branch_code"].ToString()))
                { branch_ = "0"; }
                else
                {
                    branch_ = dr["Branch_code"].ToString();
                }
                if (Properties.Settings.Default.lungh == "0")
                {
                    t.Text = branch_ + " - " + dr["branch_name"].ToString();
                }
                else
                {
                    t.Text = branch_ + " - " + dr["WH_E_NAME"].ToString();
                }
                t.Name = branch_;
                t.Tag = _acountsTb.Rows.IndexOf(dr);
                if (dr["t_final"].ToString() == "1")
                {
                    t.ImageIndex = 0;
                    t.SelectedImageIndex = 1;
                }
                else
                {
                    t.ImageIndex = 2;
                    t.SelectedImageIndex = 6;
                }
                if (parentNode == null)
                {

                    tvStore.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }

                PopulateTreeView_store(branch_, childNode);
            }
        }

        private void btnChangBranch_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "Frm_Main" && f.Name != "login_frm")
                    f.Close();
            }

            openForm(new PL.frm_ChoseStore(), FormWindowState.Normal, 0);
        }

        private void tvStore_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedStore = tvStore.SelectedNode;
            GetStoreData(_selectedStore);
        }

        private void GetStoreData(TreeNode nod)
        {
            DataRow r = _acountsTb.Rows[int.Parse(nod.Tag.ToString())];
            Properties.Settings.Default.BranchId = r[0].ToString();
            Properties.Settings.Default.BranchAccID = r[5].ToString();
            Properties.Settings.Default.TRANS_TO_ACC = r[13].ToString();
            Properties.Settings.Default.Save();
        }

        private void M715_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Monthly_TB(), FormWindowState.Maximized, 0);
        }

        private void listView1_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }

        private void M83_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_lcsRep(), FormWindowState.Maximized, 0);
        }

        private void M92_Click(object sender, EventArgs e)
        {    openForm(new PL.frmAssetAdditions(), FormWindowState.Maximized, 0);

        }

        private void M93_Click(object sender, EventArgs e)
        {
            openForm(new PL.frmDepreciation(), FormWindowState.Maximized, 0);
        }

        private void M84_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_LcInvRep(), FormWindowState.Maximized, 0);
        }

        private void M85_Click(object sender, EventArgs e)
        {
            //  openForm(new Loans.frm_Loan(), FormWindowState.Normal, 0);

            Loans.frm_Loan frm = new Loans.frm_Loan();
            frm.Show();
        }

        private void M86_Click(object sender, EventArgs e)
        {
            openForm(new PL.test(), FormWindowState.Maximized, 0);
        }

        private void buttonItem7_Click_1(object sender, EventArgs e)
        {

            openForm(new PL.test(), FormWindowState.Maximized, 0);

        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            // openForm(new frm_QR_Code(), FormWindowState.Maximized, 0);
            openForm(new PL.Form2(), FormWindowState.Maximized, 0);

        }

        private void M56_Click(object sender, EventArgs e)
        {
           
        }

        private void M27_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_maintenance_SP_ByCustomer(), FormWindowState.Maximized, 0);

        }

        private void M57_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_CutOff(), FormWindowState.Maximized, 0);

        }

        private void M717_Click(object sender, EventArgs e)
        {
            openForm(new Group.frm_rep_Fees_Consolidated(), FormWindowState.Maximized, 0);

        }

        private void M87_Click(object sender, EventArgs e)
        {
         

        }

        private void M88_Click(object sender, EventArgs e)
        {
            openForm(new Loans.frm_LoansReport(), FormWindowState.Maximized, 0);

        }

        private void M89_Click(object sender, EventArgs e)
        {
            //openForm(new Loans.frm_LoanPayment(), FormWindowState.Normal, 0);

            Loans.frm_LoanPayment frm = new Loans.frm_LoanPayment();
            frm.Show();
        }

        private void M87_2_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_PreformaInvoice(), FormWindowState.Maximized, 0);
           
        }

        private void M87_1_Click(object sender, EventArgs e)
        {

            openForm(new PL.frm_PreformaInvoice_Local(), FormWindowState.Maximized, 0);
        }

        private void btn_CashTransaction_Click(object sender, EventArgs e)
        {
        }

        private void btnChangeAccBranch_Click(object sender, EventArgs e)
        {

        }

        private void M810_Click(object sender, EventArgs e)
        {
            openForm(new Loans.frm_LoansReports(), FormWindowState.Maximized, 0);
        }

        private void M_Loans_Click(object sender, EventArgs e)
        {

        }

        private void M_Loans_1_Click(object sender, EventArgs e)
        {
            Loans.frm_Loan frm = new Loans.frm_Loan();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void M_Loans_2_Click(object sender, EventArgs e)
        {
            Loans.frm_LoanPayment frm = new Loans.frm_LoanPayment();
            frm.Show();
        }

        private void M_Loans_3_Click(object sender, EventArgs e)
        {
            openForm(new Loans.frm_LoansReports(), FormWindowState.Maximized, 0);

        }

        private void M58_Click(object sender, EventArgs e)
        {
            RPT.frm_rpt_InventoryBranches frm = new RPT.frm_rpt_InventoryBranches();
              frm.Show();
        }

        private void M59_Click(object sender, EventArgs e)
        {
            RPT.frm_rpt_InventoryGroups frm = new RPT.frm_rpt_InventoryGroups();
            frm.Show();
        }

        private void M60_Click(object sender, EventArgs e)
        {
            RPT.frm_rpt_InventoryItems frm = new RPT.frm_rpt_InventoryItems();
            frm.Show();
        }

        private void M_Loans_4_Click(object sender, EventArgs e)
        {
            Loans.frm_Loans_Interest frm = new Loans.frm_Loans_Interest();
            frm.Show();
        }

        private void btnCash_1_Click(object sender, EventArgs e)
        {
            openForm(new CTR.frm_cash_transaction(), FormWindowState.Maximized, 0);

        }

        private void btnCash_2_Click(object sender, EventArgs e)
        {
            openForm(new CTR.frm_Funds_Detials_Report(), FormWindowState.Maximized, 0);

        }

        private void M718_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_Update_Classification(), FormWindowState.Maximized, 0);

        }

        private void M314_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_Price_Group(), FormWindowState.Normal, 0);

        }

        private void buttonItem1_Click_2(object sender, EventArgs e)
        {
            openForm(new PL.frmQuotation(), FormWindowState.Maximized, 0);
        }

        private void M511_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_Internal_RM(), FormWindowState.Normal, 0);
        }

        private void M512_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_pritBracode(), FormWindowState.Normal, 0);

        }

        private void M513_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_Exchange_Materials(), FormWindowState.Normal, 0);

        }

        private void btn_Group_Report_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_Conslidated_Reports(), FormWindowState.Maximized, 0);

        }

        private void btn_bankTrans_Click(object sender, EventArgs e)
        {

        }

        private void btn_BankTransfer_Click(object sender, EventArgs e)
        {

            PL.frm_BankTransfair frm = new frm_BankTransfair();
            frm.Show();

            //openForm(new PL.frm_BankTransfair(), FormWindowState.Normal, 0);

        }

        private void M51_1_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_inventory(), FormWindowState.Maximized, 0);

        }

        private void btn_cash_payment_voucher_Click(object sender, EventArgs e)
        {
          //  openForm(new CTR.frm_paySanad(), FormWindowState.Maximized, 0);
            openForm(new CTR.frm_Cash_Receipt(), FormWindowState.Maximized, 0);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataTable dt_user = dal.getDataTabl_1(@"select USER_ID from wh_USERS");
            foreach (DataRow ur in dt_user.Rows)
            {
                //dal.Execute_1(@"INSERT INTO Priv_Tbl (priv_screen_id,priv_user_id)    SELECT screen_id ,'" + ur[0].ToString() + "' from Screen_Tbl");
                dal.Execute_1(@"INSERT INTO Active_list (list_id,user_id )    SELECT list_id ,'" + ur[0].ToString() + "' from List_Tbl");

            }
        }



        void validation()
        {
            DataTable dt_active_list = dal.getDataTabl_1(@"SELECT active  FROM Active_list where  user_id='" + Program.userID + "'  ORDER BY CAST(list_id AS int)");
            if (dt_active_list.Rows.Count > 0)
            {
                if (dt_active_list.Rows[0][0].ToString() == "True" || dt_active_list.Rows[0][0].ToString() == string.Empty)
                { M1.Enabled = true; }

                if (dt_active_list.Rows[1][0].ToString() == "True" || dt_active_list.Rows[1][0].ToString() == string.Empty)
                { M2.Enabled = true; }

                if (dt_active_list.Rows[2][0].ToString() == "True" || dt_active_list.Rows[2][0].ToString() == string.Empty)
                { M3.Enabled = true; }

                if (dt_active_list.Rows[3][0].ToString() == "True" || dt_active_list.Rows[3][0].ToString() == string.Empty)
                { M4.Enabled = true; }

                if (dt_active_list.Rows[4][0].ToString() == "True" || dt_active_list.Rows[4][0].ToString() == string.Empty)
                { M5.Enabled = true; }

                if (dt_active_list.Rows[5][0].ToString() == "True" || dt_active_list.Rows[5][0].ToString() == string.Empty)
                { M6.Enabled = true; }

                if (dt_active_list.Rows[6][0].ToString() == "True" || dt_active_list.Rows[6][0].ToString() == string.Empty)
                { M7.Enabled = true; }

                if (dt_active_list.Rows[7][0].ToString() == "True" || dt_active_list.Rows[7][0].ToString() == string.Empty)
                { M8.Enabled = true; }

                if (dt_active_list.Rows[8][0].ToString() == "True" || dt_active_list.Rows[8][0].ToString() == string.Empty)
                { M_Loans.Enabled = true; }

            }
            else
            {

            }



            DataTable dt_validation = dal.getDataTabl_1("select priv_display from Priv_Tbl where priv_user_id='" + Program.userID + "' order by id");
            if (dt_validation.Rows.Count > 0)
            {
                if (dt_validation.Rows[0][0].ToString() == "True" || dt_validation.Rows[0][0].ToString() == string.Empty)
                { M11.Enabled = true; }
                else { M11.Enabled = false; }


                if (dt_validation.Rows[1][0].ToString() == "True" || dt_validation.Rows[1][0].ToString() == string.Empty)
                { M15.Enabled = true; }
                else { M15.Enabled = false; }
                if (dt_validation.Rows[2][0].ToString() == "True" || dt_validation.Rows[2][0].ToString() == string.Empty)
                { M16.Enabled = true; }
                else { M16.Enabled = false; }
                if (dt_validation.Rows[3][0].ToString() == "True" || dt_validation.Rows[3][0].ToString() == string.Empty)
                { M21.Enabled = true; }
                else { M21.Enabled = false; }
                if (dt_validation.Rows[4][0].ToString() == "True" || dt_validation.Rows[4][0].ToString() == string.Empty)
                { M22.Enabled = true; }
                else { M22.Enabled = false; }
                if (dt_validation.Rows[5][0].ToString() == "True" || dt_validation.Rows[5][0].ToString() == string.Empty)
                { M23.Enabled = true; }
                else { M23.Enabled = false; }
                //if (dt_validation.Rows[6][0].ToString() == "False" || dt_validation.Rows[6][0].ToString() == string.Empty)
                //{ rBtnCars.Enabled = false; }

                // if (dt_validation.Rows[7][0].ToString() == "False" || dt_validation.Rows[7][0].ToString() == string.Empty)
                // { rBtnDrivers.Enabled = false; }

                // if (dt_validation.Rows[8][0].ToString() == "False" || dt_validation.Rows[8][0].ToString() == string.Empty)
                // { rBtnLines.Enabled = false; }


                //if ((dg.Rows[2].Cells[0].Value).ToString() == "False" || (dg.Rows[2].Cells[0].Value).ToString() == string.Empty)
                //{ tsm1_3.Enabled = false; }

                //if ((dg.Rows[3].Cells[0].Value).ToString() == "False" || (dg.Rows[3].Cells[0].Value).ToString() == string.Empty)
                //{ tsm1_4.Enabled = false; }

                //if ((dg.Rows[4].Cells[0].Value).ToString() == "False" || (dg.Rows[4].Cells[0].Value).ToString() == string.Empty)
                //{ tsm1_5.Enabled = false; }

                //if ((dg.Rows[5].Cells[0].Value).ToString() == "False" || (dg.Rows[5].Cells[0].Value).ToString() == string.Empty)
                //{ tsm1_6.Enabled = false; }

                //if ((dg.Rows[6].Cells[0].Value).ToString() == "False" || (dg.Rows[5].Cells[0].Value).ToString() == string.Empty)
                //{ tsm1_7.Enabled = false; }

                //if ((dg.Rows[7].Cells[0].Value).ToString() == "False" || (dg.Rows[6].Cells[0].Value).ToString() == string.Empty)
                //{ tsm2_1.Enabled = false; }

                //if ((dg.Rows[8].Cells[0].Value).ToString() == "False" || (dg.Rows[7].Cells[0].Value).ToString() == string.Empty)
                //{ tsm2_2.Enabled = false; }

                //if ((dg.Rows[9].Cells[0].Value).ToString() == "False" || (dg.Rows[8].Cells[0].Value).ToString() == string.Empty)
                //{ tsm2_3.Enabled = false; }

                //if ((dg.Rows[10].Cells[0].Value).ToString() == "False" || (dg.Rows[9].Cells[0].Value).ToString() == string.Empty)
                //{ tsm2_4.Enabled = false; }
            }


        }

        private void Frm_Main_Shown(object sender, EventArgs e)
        {
            //validation();
        }

        private void M17_Click(object sender, EventArgs e)
        {
            // openForm(new Forms.frm_Users(), FormWindowState.Maximized, 0);
            openForm(new Forms.frm_UserPermissions(), FormWindowState.Maximized, 0);

        }

        private void btn_IncomeStatment_Click(object sender, EventArgs e)
        {
            openForm(new RPT.statmentOfIncom(), FormWindowState.Maximized, 0);

        }

        private void M18_Click(object sender, EventArgs e)
        {
            openForm(new Forms.frm_CompanyData(), FormWindowState.Normal, 0);

        }

        private void M85_Click_1(object sender, EventArgs e)
        {
            openForm(new Forms.frm_close_purch_to_lc(), FormWindowState.Normal, 0);
        }

        private void M28_Click(object sender, EventArgs e)
        {
            openForm(new Reports.frm_rpt_transport_detials_byCustomer(), FormWindowState.Maximized, 0);
        }

        private void btn_Element_Entry_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_BS_elements_Group(), FormWindowState.Maximized, 0);

        }

        private void btn_BS_TB_Click(object sender, EventArgs e)
        {
            openForm(new Group.frm_BS_TB_Group(), FormWindowState.Maximized, 0);
        }

        private void btn_customers_TB_Click(object sender, EventArgs e)
        {
            openForm(new Group.frm_Customers_TB_Group(), FormWindowState.Maximized, 0);

        }

        private void btn_Cut_off_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_CutOff(), FormWindowState.Maximized, 0);

        }

        private void btn_samples_Click(object sender, EventArgs e)
        {
            openForm(new Group.frm_samples(), FormWindowState.Maximized, 0);

        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_ScanToPDF(), FormWindowState.Normal, 0);

        }

        private void btn_Group_Daliy_rpt_Click(object sender, EventArgs e)
        {
            openForm(new Group.frm_Group_Daliy_rpt(), FormWindowState.Maximized, 0);
            
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            openForm(new Forms.frmWord(), FormWindowState.Maximized, 0);

        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            openForm(new Forms.frm_AccessProfile(), FormWindowState.Maximized, 0);
        }

        private void btnPOReport_Click(object sender, EventArgs e)
        {
            openForm(new RPT.frm_rpt_Po(), FormWindowState.Maximized, 0);

        }

        private void btnSendWhatsApp_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_sendWhatsApp(), FormWindowState.Maximized, 0);

        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_Contract(), FormWindowState.Maximized, 0);
           
        }

        private void StorePlan_Click(object sender, EventArgs e)
        {
            openForm(new PL.frm_storePlan(), FormWindowState.Maximized, 0);

        }

        private void btnShowAccessProfil_Click(object sender, EventArgs e)
        {
            openForm(new Forms.frm_AccessProfileList(), FormWindowState.Maximized, 0);

        }
    }
}
