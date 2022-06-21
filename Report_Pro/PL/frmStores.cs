using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Resources;
using System.Reflection;
using System.IO;

namespace Report_Pro.PL
{
   
    public partial class frmStores : Form
    {
      ResourceManager rm;
 TreeNode _selectedNode = null;
        DataTable _acountsTb = null;
        // bool _newNode, _thisLevel;
        // string _parent ;
       

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
                public frmStores()
        {
            InitializeComponent();

            cmb_Combany.DataSource = dal.getDataTabl_1(@"SELECT Company_No,Company_a_name,Company_e_name FROM Wh_Oiner_Comp");
            if (Properties.Settings.Default.lungh == "0")
            {
            cmb_Combany.DisplayMember = "Company_a_name";
            }
            else
            {
                cmb_Combany.DisplayMember = "Company_a_name";
            }
            cmb_Combany.ValueMember = "Company_No";



        }



        private void BSave_Click(object sender, EventArgs e)
        {
            updatestore();
            txt_MBranch.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            //StoreId.Enabled = false;
            //MessageBox.Show(rm.GetString("SaveMessage"));
        }



        private void updatestore()
        {
            byte[] big_Logo = null;
            byte[] small_Logo = null;


            if (pictureBox1.Image == null)
            {

                big_Logo = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                big_Logo = ms.GetBuffer();
                ms.Close();
            }

            if (pictureBox2.Image == null)
            {
                small_Logo = null;
            }
            else
            {
                
                    
                MemoryStream ms1 = new MemoryStream();
                pictureBox2.Image.Save(ms1, pictureBox2.Image.RawFormat);
                small_Logo = ms1.GetBuffer();
                ms1.Close();
            }

            DataTable dt = dal.getDataTabl("GetStores", txt_BranchCode.Text.ToString());
            if (dt.Rows.Count > 0)
            {


                dal.Execute("Updat_Store",
                 txt_BranchCode.Text,
                 txt_BranchName.Text,
                 txt_BrancName_L.Text,
                 txt_ShortName.Text,
                 (wh_active.Checked ? "1" : "0"),
                 txt_AccBranch.ID.Text.ToString(),
                 "",
                 Convert.ToString(cmb_Combany.SelectedValue),
                   "",
                   txt_area.ID.Text,
                   "",
                   txt_SalesAcc.ID.Text,
                   txt_PurAcc.ID.Text,
                   txt_Tranc_ToAcc.ID.Text,
                   txt_CashAcc.ID.Text.ToString(),
                   txt_CostmersAcc.ID.Text.ToString(),
                   txt_SuppliersAacc.ID.Text.ToString(),
                   txt_OpeningAcc.ID.Text.ToString(),
                   "",
                   "",
                   "", TxtTel.Text, TxtFax.Text, TxtEmail.Text, (radioParent.Checked ? "0" : "1"), txt_BranchLevel.Text.ToString(), txt_MBranch.Text.ToString(),
                   txt_MBranch.Text.ToString(), "", Sdate.Value, Program.userID.ToString(), txt_PurFessAcc.ID.Text.ToString(),
                   txt_CargoAcc.ID.Text.ToString(), "", txt_InventoryAcc.ID.Text.ToString(), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
                   "", "", "", "", txt_BoanasAcc.ID.Text.ToString(), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
                   txt_KM_Sales.ID.Text.ToString(), txt_KM_purchase.ID.Text.ToString(), txt_KM_No.Text.ToString(), "", "", "", "", "", "", "", "", "", "0", "", "", "", ""
               , TxtAddress.Text, TxtAddress_E.Text, "", "", small_Logo, small_Logo, big_Logo
             , "", "", "", "", "", "" , txtCr.Text, txtWebSite.Text);
            }
            else
            {
                dal.Execute("Add_Store",
                      txt_BranchCode.Text,
                      txt_BranchName.Text,
                      txt_BrancName_L.Text,
                      txt_ShortName.Text,
                      (wh_active.Checked ? "1" : "0"),
                      txt_AccBranch.ID.Text.ToString(),
                      "",
                      Convert.ToString(cmb_Combany.SelectedValue),
                      "",
                      txt_area.ID.Text,
                      "",
                      txt_SalesAcc.ID.Text,
                      txt_PurAcc.ID.Text,
                      txt_Tranc_ToAcc.ID.Text,
                      txt_CashAcc.ID.Text.ToString(),
                      txt_CostmersAcc.ID.Text.ToString(),
                      txt_SuppliersAacc.ID.Text.ToString(),
                      txt_OpeningAcc.ID.Text.ToString(),
                      "",
                      "",
                      "", "", "", "", (radioParent.Checked ? "0" : "1"), txt_BranchLevel.Text.ToString(), txt_MBranch.Text.ToString(),
                      txt_MBranch.Text.ToString(), "", Sdate.Value, Program.userID.ToString(), txt_PurFessAcc.ID.Text.ToString(),
                      txt_CargoAcc.ID.Text.ToString(), "", txt_InventoryAcc.ID.Text.ToString(), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
                      "", "", "", "", txt_BoanasAcc.ID.Text.ToString(), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
                      txt_KM_Sales.ID.Text.ToString(), txt_KM_purchase.ID.Text.ToString(), txt_KM_No.Text.ToString(), "", "", "", "", "", "", "", "", "", "0", "", "", "", ""
                ,TxtAddress.Text, TxtAddress_E, "", "", small_Logo, small_Logo
, big_Logo, "", "", "", "", "", "",txtCr.Text, txtWebSite.Text);

            }
        }
        private void savestore()
        {
            //DataTable dt = dal.getDataTabl("GetStores", StoreId.Text.ToString());
            //if (dt.Rows.Count > 0)
            //{
            //}
            //else
            //{
            //    dal.Execute("Add_Store", StoreId.Text.ToString(), StoreName.Text.ToString(), StoreNameL.Text.ToString(),
            //               (radioActive.Checked ? "1" : "2"), TxtBranch_ID.Text.ToString(), Address.Text.ToString(), txtCoId.Text.ToString(),
            //                txtArea_Id.Text.ToString(), SalesAcc.ID.Text.ToString(), PurAcc.ID.Text.ToString(), txtToAcc_ID.Text.ToString(),
            //                CashAcc.ID.Text.ToString(), CustAcc.ID.Text.ToString(), SuppAcc.ID.Text.ToString(), OpeningAcc.ID.Text.ToString(),
            //                txtMatrType_ID.Text.ToString(), txtCity_ID.Text.ToString(), txtMang_ID.Text.ToString(), PhoneNo.Text.ToString(),
            //                FaxNo.Text.ToString(), Email.Text.ToString(), (radioParent.Checked ? "1" : "2"), StoreLevel.Text.ToString(),
            //                MStoreId.Text.ToString(), txtNotes.Text.ToString(), Sdate.Value, txtUser.Text.ToString(), PurFessAcc.ID.Text.ToString(),
            //                CargoAcc.ID.Text.ToString(), InventoryAcc.ID.Text.ToString(), SalesCost.ID.Text.ToString(),
            //                F1.Text.ToString(),
            //                F2.Text.ToString(), F3.Text.ToString(), F4.Text.ToString(), F5.Text.ToString(), F6.Text.ToString(), F7.Text.ToString(),
            //                F8.Text.ToString(), F9.Text.ToString(), F10.Text.ToString(), F11.Text.ToString(), F12.Text.ToString(), F13.Text.ToString(),
            //                F14.Text.ToString(), F15.Text.ToString());
            //}

        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            updatestore();

            txt_MBranch.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            // StoreId.Enabled = false;
            
           // MessageBox.Show(rm.GetString("msgSave"));
        }


        private void PopulateTreeView(string parentId, TreeNode parentNode)
        {
            TreeNode childNode;
            foreach (DataRow dr in _acountsTb.Select("[prev_no]= '" + parentId + "'"))
            {
                TreeNode t = new TreeNode();
                t.Text = dr["Branch_code"].ToString() + " - " + dr["branch_name"].ToString();
                t.Name = dr["Branch_code"].ToString();
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

                    TV1.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }

                PopulateTreeView((dr["Branch_code"].ToString()), childNode);
            }
        }

        private void frmStores_Load(object sender, EventArgs e)
        {

            //rm = new ResourceManager("Products.Resources.message.ar_EG", System.Reflection.Assembly.GetExecutingAssembly());

            _acountsTb = dal.getDataTabl_1("SELECT * FROM wh_BRANCHES");
            
            PopulateTreeView("0", null);
        }

        private void TV1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ClearTextBoxes();
            _selectedNode = TV1.SelectedNode;
            ShowNodeData(_selectedNode);
            BEdit.Enabled = true;
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



        private void ShowNodeData(TreeNode nod)
        {
            //try
            //{
                DataRow r = _acountsTb.Rows[int.Parse(nod.Tag.ToString())];


               txt_BranchCode.Text = r["Branch_code"].ToString();
              txt_BranchName.Text = r["branch_name"].ToString();
               txt_BrancName_L.Text = r["WH_E_NAME"].ToString();
               txt_ShortName.Text = r["wh_short_name"].ToString();

                if (r["wh_stoped"].ToString()!="1")
                {
                   wh_active.Checked = true;
                }
                else
                {
                   wh_stoped.Checked = true;
                }

               txt_AccBranch.ID.Text = r["ACC_BRANCH"].ToString();
               txt_area.ID.Text= r["Area_code"].ToString();


               txt_SalesAcc.ID.Text = r["SALES_ACC_NO"].ToString();
               txt_PurAcc.ID.Text = r["PUR_ACC_NO"].ToString();
               txt_Tranc_ToAcc.ID.Text = r["TRANS_TO_ACC"].ToString();
               txt_CashAcc.ID.Text = r["Cash_acc_no"].ToString();
               txt_CostmersAcc.ID.Text = r["Costmers_acc_no"].ToString();
               txt_SuppliersAacc.ID.Text = r["Suppliers_acc_no"].ToString();
               txt_OpeningAcc.ID.Text = r["Opininig_balance_acc_no"].ToString();
               txt_CityCode.Text = r["CITY_CODE"].ToString();
             if (r["t_final"].ToString().Equals("0"))
                {
                    radioParent.Checked = true;
                }
                else
                {
                    radioTransaction.Checked = true;
                }

               txt_BranchLevel.Text = r["t_level"].ToString();
               txt_MBranch.Text = r["PREV_NO"].ToString();
               //txt_MBranch.Text = r[27].ToString();
               Sdate.Text=r["G_DATE"].ToString();
               txt_PurFessAcc.ID.Text = r["Pur_Expensive_Acc_No"].ToString();
               txt_CargoAcc.ID.Text = r["Cargo_Expen_No"].ToString();
               txt_conection.ID.Text = r["Com_Code"].ToString();
               txt_InventoryAcc.ID.Text = r["Invintory_Acc_no"].ToString();
               txt_3.ID.Text = r["Invintory_Running_acc_no"].ToString();
               //txt_BoanasAcc.ID.Text = r[71].ToString();
               //c.ID.Text = r[72].ToString();
               //txt_SP_Inventory.ID.Text = r[75].ToString();
               //txt_TR_Inventory.ID.Text = r[76].ToString();
               //txt_OI_Inventory.ID.Text = r[77].ToString();
               //txt_WS_Inventory.ID.Text = r[78].ToString();
               //txt_TO_Inventory.ID.Text = r[79].ToString();
               //txt_OSP_Inventory.ID.Text = r[80].ToString();
               //txt_Petrol_Supp.ID.Text = r[81].ToString();
               //txt_2.ID.Text = r[82].ToString();
               //txt_1.ID.Text = r[83].ToString();
               //txt_4.ID.Text = r[36].ToString();
               //txt_5.ID.Text = r[84].ToString();
               //txt_6.ID.Text = r[85].ToString();
               //txt_7.ID.Text = r[86].ToString();
               txt_KM_Sales.ID.Text = r["K_M_ACC_NO_SALES"].ToString();
               txt_KM_purchase.ID.Text = r["K_M_ACC_NO_PURCH"].ToString();
               txt_KM_No.Text = r["K_M_ACC_NO"].ToString();

                if (r["Branch_Logo_A4"] != DBNull.Value)
                {
                    byte[] h_pic = (byte[])(r[110]);
                    MemoryStream ms = new MemoryStream(h_pic);
                    pictureBox1.Image = Image.FromStream(ms);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                    // ms.Close();
                }
                else
                {
                    pictureBox1.Image = null;
                }
                if (r["Branch_Logo_Small"] != DBNull.Value)
                {
                    byte[] f_pic = (byte[])(r[109]);
                    MemoryStream ms1 = new MemoryStream(f_pic);
                    pictureBox2.Image = Image.FromStream(ms1);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                    //ms1.Close();
                }
                else
                {
                    pictureBox2.Image = null;
                }
            TxtEmail.Text = r["E_MAIL"].ToString();
            TxtTel.Text = r["PHONE_NO"].ToString();
            TxtFax.Text = r["FAX_NO"].ToString();
            TxtAddress.Text= r["LONG_ADESS_A"].ToString();
            TxtAddress_E.Text = r["LONG_ADESS_E"].ToString();
            txtCr.Text = r["CR"].ToString();
            txtWebSite.Text = r["Website"].ToString();
            txt_KM_No.Text = r["COMP_TAX_NO"].ToString();
            //}

            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            _selectedNode = TV1.SelectedNode;
            AddData(_selectedNode);
            //StoreId.Focus();
        }


        private void AddData(TreeNode nod)
        {
            try
            {
                if (TV1.SelectedNode != null)
                {
                    DataRow r = _acountsTb.Rows[int.Parse(nod.Tag.ToString())];
                    if (r["t_final"].ToString()=="0")
                    {
                        ClearTextBoxes();
                        txt_MBranch.Visible = true;
                        panel1.Visible = true;
                        panel2.Visible = true;
                       // StoreId.Enabled = true;
                        txt_MBranch.Text = r["Branch_code"].ToString();
                        txt_BranchLevel.Text = (Int32.Parse(r["t_level"].ToString()) + 1).ToString();

                        string AccNo = string.Empty;

                    }
                    else
                    {

                        MessageBox.Show("لايمكن الاضافة الي مستودع فرعي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    if (MessageBox.Show("لم تختار حساب رئيسي : هل تريد اضافة مستودع مستوي اول", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        txt_MBranch.Visible = true;
                        panel1.Visible = true;
                        panel2.Visible = true;
                        //StoreId.Enabled = true;
                        txt_MBranch.Text = "";
                        txt_BranchLevel.Text = "1";

                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "c:/pic/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(f.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;

                }
            }
            catch
            {
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "c:/pic/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(f.FileName);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox2.BorderStyle = BorderStyle.Fixed3D;

                }
            }
            catch
            {
            }
        }

        private void GroupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void BSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
