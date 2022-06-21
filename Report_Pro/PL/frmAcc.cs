using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmAcc : Form
    {
        string Serch_Btn;
        TreeNode _selectedNode = null;
        DataTable _acountsTb = null;
        string _parent ;
        string btnType="save";

        DAL.DataAccesslayer1 dal =new DAL.DataAccesslayer1();
         public frmAcc()
        {
            InitializeComponent();
            _acountsTb = new DataTable();
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
            BranchId.Text = Properties.Settings.Default.BranchId;
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            btnType = "save";

            ClearTextBoxes();
            _selectedNode = TV1.SelectedNode;
            AddData(_selectedNode);
            MAccId.Visible = true;
            AccId.Enabled = true;
            AccId.Focus();
                    
                    }

        private void frmAcc_Load(object sender, EventArgs e)
        {
            TV1.Nodes.Clear();
            _acountsTb = dal.getDataTabl_1("select * FROM payer2 where BRANCH_code='"+Properties.Settings.Default.BranchId+"'");

            PopulateTreeView("0", null);
        }

        private void PopulateTreeView(string parentId, TreeNode parentNode)
        {
            
            TreeNode childNode;
            foreach (DataRow dr in _acountsTb.Select("prev_no = '" + parentId + "'"))
            {
                TreeNode t = new TreeNode();
                t.Text = dr["Acc_No"].ToString() + " - " + dr["payer_name"].ToString();
                t.Name = dr["Acc_No"].ToString();
                t.Tag = _acountsTb.Rows.IndexOf(dr);
                if (dr["t_final"].ToString() == "0")
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

                PopulateTreeView((dr["Acc_No"].ToString()), childNode);  
            }
        }

        
              
        private void ShowNodeData(TreeNode nod)
        {
            try
            {
                DataRow r = _acountsTb.Rows[int.Parse(nod.Tag.ToString())];
                CoId.Text = r[0].ToString();
                BranchId.Text=r[2].ToString();
                AccId.Text = r[1].ToString();
                AccName.Text = r[7].ToString();
                AccNameL.Text = r[8].ToString();
                MAccId.Text = r[3].ToString();
              
                if (r[21].ToString().Equals("0"))
                {
                  radioParent.Checked = true;
                }
                     else
                radioTransaction.Checked = true;

                if (r[4].ToString().Equals("0"))
                {
                    radioActive.Checked = true;
                }
                else
                    radioStop.Checked = true;

                Address.Text = r[11].ToString();
            
                BOBox.Text = r[12].ToString();
                AreaCode.Text = r[13].ToString();
                PhoneNo.Text = r[14].ToString();
                Email.Text = r[15].ToString();
                FaxNo.Text = r[16].ToString();
                MobileNo.Text = r[17].ToString();
                RespName.Text = r[22].ToString();
                RespMobileNo.Text = r[18].ToString();
                RespPhone.Text = r[20].ToString();
                AccLevel.Text = r[23].ToString();
                Balance.Text = r[25].ToString();
                Notes.Text = r[28].ToString();
                Sdate.Text = r[29].ToString();

                UC_QutType.ID.Text = r[10].ToString();
                uC_cost.ID.Text = r[26].ToString();
                //lvl_1.Text = r[40].ToString();
                //lvl_2.Text = r[41].ToString();
                //lvl_3.Text = r[42].ToString();
                //lvl_4.Text = r[43].ToString();
                uC_CashCard.ID.Text = r[46].ToString();
                KM_Sales.ID.Text = r[61].ToString();
                KM_Purch.ID.Text = r[62].ToString();
                UC_KM_no.Desc.Text = r[64].ToString();
                UC_MultiCurncey.Desc.Text = r[35].ToString();
                uC_currency.ID.Text = r[36].ToString();
                UC_Purch_price.Desc.Text=r[37].ToString();
                UC_Sales_price.Desc.Text = r[38].ToString();
                UC_User.Desc.Text = r[32].ToString();
                UC_Credit.Desc.Text = r[9].ToString();
                UC_days.Desc.Text = r[45].ToString();
                uC_OtherNu.ID.Text = r[56].ToString();
                uC_Catogry.ID.Text = r[47].ToString();
                uC_FinalAcc.ID.Text = r[30].ToString();
                UC_BSheet_NO.Desc.Text = r[43].ToString();

                //MAccId.Visible = false;
                //panel1.Visible = false;
                //panel2.Visible = false;
                AccId.ReadOnly = true;
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void عرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedNode = TV1.SelectedNode;
            ShowNodeData(_selectedNode);
        }

     

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            _selectedNode = TV1.SelectedNode;
            AddData(_selectedNode);
            AccId.Focus();
        }


    
        private void AddData(TreeNode nod)
        {
            try
            {
                if (TV1.SelectedNode!=null)
                {
                    DataRow r = _acountsTb.Rows[int.Parse(nod.Tag.ToString())];
                    if (r[21].ToString() == "0")
                    {
                        ClearTextBoxes();
                        MAccId.Visible = true;
                        panel1.Visible = true;
                        panel2.Visible = true;
                        AccId.ReadOnly = false;
                        MAccId.Text = r[1].ToString();
                        ////MAccName.Text = r[7].ToString();
                        ////MAccNameL.Text = r[8].ToString();
                        //lvl_1.Text = r[40].ToString();
                        //lvl_2.Text = r[41].ToString();
                        //lvl_3.Text = r[42].ToString();
                        //lvl_4.Text = r[43].ToString();
                        AccLevel.Text = (Int32.Parse(r[23].ToString()) + 1).ToString();

                        string AccNo = string.Empty;
                        
                        _parent = (int.Parse(_acountsTb.Rows[int.Parse(_selectedNode.Tag.ToString())]["ACC_NO"].ToString())).ToString();

                        if (_selectedNode.Nodes.Count > 0)
                        {

                            DataRow[] nodes = _acountsTb.Select("[MAIN_NO]= '" + _parent + "'");
                            int max = 0;
                            foreach (DataRow ra in nodes)
                            {
                                int n = int.Parse(ra["ACC_NO"].ToString());
                                if (n > max)
                                    max = n;
                            }
                            max += 1;

                            AccId.Text = max.ToString();
                            AccNo = max.ToString();
                            int _len = AccNo.Length;
                            string __pp = _parent.ToString();
                            int __lenpp = __pp.Length;
                            AccId.Text = AccNo.Substring(__lenpp, _len - __lenpp); ;

                        }
                        else
                        {
                            AccId.Text = "0000";
                        }

                    }
                    else
                    {

                        MessageBox.Show("لايمكن الاضافة الي حساب فرعي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("يرجي تحديد الحساب الرئيسي من شجرة الحسابات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            
            if (btnType != "save")
            {
                MessageBox.Show("البيانات موجودة من قبل يرجي اختيار تعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }
            else
            {
                if (AccLevel.Text == "4" && radioParent.Checked == true)
                {
                    MessageBox.Show("لا يمكن حفظ حساب رئيسي في المستوي الخامس", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (CoId.Text != string.Empty && BranchId.Text != string.Empty && AccId.Text != string.Empty && AccName.Text != string.Empty && MAccId.Text != string.Empty)
                {

                    dal.Execute_1(@"INSERT INTO payer2 (acc_type,ACC_NO,BRANCH_code,MAIN_NO,ACC_STOPED,PAYER_NAME,payer_l_name,Max_Sales_Am
, PriceCatogry, adress, b_o_box, area_code, phone_no, E_MAIL, fax_no, mobile_no, RESP_MOBILE_NO, RESP_PHONE
, t_final, resp_name, t_level, PREV_NO, balance, COST_CENTER, notes, S_DATE, med_MEZAN, user_id, MultyCurrency
, Currency_Code, Last_Currency_Value_Purch, Last_Currency_Value_Sales, CREDIT_AGE, COSTMER_CASH_NO, CAT_CODE
, acc_no2, KM_CODE_Sales, KM_CODE_Purch, EXTER_EXP) VALUES
('"+CoId.Text+"','"+ MAccId.Text+"' + '"+AccId.Text+"','" + BranchId.Text+"','" + MAccId.Text+"','" + (radioActive.Checked ? "0" : "1")
+"','" + AccName.Text+"','" + AccNameL.Text+"','" + UC_Credit.Desc.Text.ToDecimal()+"','" + UC_QutType.ID.Text+"','" + Address.Text
+"','" + BOBox.Text+"','" + uC_Area.ID.Text+"','" + PhoneNo.Text+"','" + Email.Text+"','" + FaxNo.Text+"','" + MobileNo.Text+"','" + RespMobileNo.Text
+"','" + RespPhone.Text+"','" + (radioParent.Checked ? "0" : "1")+"','" + RespName.Text+"','" + AccLevel.Text+"','" + MAccId.Text
+"','" + Balance.Text.ToDecimal()+"','" + uC_cost.ID.Text+"','" + Notes.Text+"','" + Sdate.Text+"','" + uC_FinalAcc.ID.Text+"','" + UC_User.Desc.Text
+"','" + UC_MultiCurncey.Desc.Text+"','" + uC_currency.ID.Text+"','" + UC_Purch_price.Desc.Text.ToDecimal()+"','" + UC_Sales_price.Desc.Text
+"','" + UC_days.Desc.Text.ToDecimal()+"','" + uC_CashCard.ID.Text+"','" + uC_Catogry.ID.Text+"','" + uC_OtherNu.ID.Text+"','" + KM_Sales.ID.Text
+"','" + KM_Purch.ID.Text+"','" + UC_KM_no.Desc.Text+"')");
                    
                    TV1.Nodes.Clear();
                    _acountsTb = dal.getDataTabl_1("select * FROM payer2 where BRANCH_code='" + Properties.Settings.Default.BranchId + "'");
                    PopulateTreeView("0", null);

                    //_selectedNode.Nodes.Add(tn);
                    TV1.SelectedNode = GetNodeByName(TV1.Nodes, MAccId.Text);
                    TV1.SelectedNode.ExpandAll();
                    //_selectedNode.Expand();
                    MAccId.Visible = false;
                    AccId.Enabled = false;
                    btnType = "edit";
                }


                else
                {
                    MessageBox.Show("تاكد من اكمال البيانات الاساسية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       


        private void TV1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            ClearTextBoxes();
            _selectedNode = TV1.SelectedNode;
            ShowNodeData(_selectedNode);
            MAccId.Visible = false;
            AccId.Enabled = false;
            btnType = "edit";
        }



        private int SearchTreeView(string p_sSearchTerm, TreeNodeCollection p_Nodes)
        {
            foreach (TreeNode node in p_Nodes)
            {
                if (node.Text == p_sSearchTerm)
                {
                    return node.Index;
                }

                if (node.Nodes.Count > 0)
                    SearchTreeView(p_sSearchTerm, node.Nodes);
            }

            return -1;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                TV1.SelectedNode = GetNodeByText(TV1.Nodes, txtSearchName.Text);
            }
        }
        

        private TreeNode GetNodeByName(TreeNodeCollection nodes, string searchtext)
        {
            TreeNode n_found_node = null;
            bool b_node_found = false;

            foreach (TreeNode node in nodes)
            {

                if (node.Name == searchtext)
                {
                    b_node_found = true;
                    n_found_node = node;

                    return n_found_node;
                }

                if (!b_node_found)
                {
                    n_found_node = GetNodeByName(node.Nodes, searchtext);

                    if (n_found_node != null)
                    {
                        return n_found_node;
                    }
                }
            }
            return null;
        }

        private TreeNode GetNodeByText(TreeNodeCollection nodes, string searchtext)
        {
            TreeNode n_found_node = null;
            bool b_node_found = false;

            foreach (TreeNode node in nodes)
            {

                if (node.Text.Contains( searchtext))
                {
                    b_node_found = true;
                    n_found_node = node;

                    return n_found_node;
                }

                if (!b_node_found)
                {
                    n_found_node = GetNodeByText(node.Nodes, searchtext);

                    if (n_found_node != null)
                    {
                        return n_found_node;
                    }
                }
            }
            return null;
        }
                  
                   
      private void txtSearchNumber_KeyUp(object sender, KeyEventArgs e)
        {
                            if (e.KeyCode==Keys.Enter)
            {
                TV1.SelectedNode = GetNodeByName(TV1.Nodes,txtSearchNumber.Text);
            }
        }

                    private void BEdit_Click(object sender, EventArgs e)
                    {
                        btnType = "edit";
                        TV1.BeginUpdate();
                        if (CoId.Text != string.Empty && BranchId.Text != string.Empty && AccId.Text != string.Empty && AccName.Text != string.Empty )
                        {


                            dal.Execute_1(@"update payer2 set acc_type = '" + CoId.Text + 
                                "', ACC_NO = '"+AccId.Text+"', BRANCH_code = '" + BranchId.Text+
                                "', MAIN_NO = '" + MAccId.Text+"', ACC_STOPED = '" + (radioActive.Checked ? "0" : "1")+
                                "', PAYER_NAME = '" + AccName.Text+"', payer_l_name = '" + AccNameL.Text+
                                "', Max_Sales_Am = '" + UC_Credit.Desc.Text.ToDecimal()+"', PriceCatogry = '" + UC_QutType.ID.Text+
                                "', adress = '" + Address.Text+"', b_o_box = '" + BOBox.Text+"', area_code = '" + uC_Area.ID.Text+
                                "', phone_no = '" + PhoneNo.Text+"', E_MAIL = '" + Email.Text+"', fax_no = '" + FaxNo.Text+
                                "', mobile_no = '" + MobileNo.Text+"', RESP_MOBILE_NO = '" + RespMobileNo.Text+"', RESP_PHONE = '" + RespPhone.Text+
                                "', t_final = '" + (radioParent.Checked ? "0" : "1")+"', resp_name = '" + RespName.Text+
                                "', t_level = '" + AccLevel.Text+"', PREV_NO = '" + MAccId.Text+"', balance = '" + Balance.Text.ToDecimal()+
                                "', COST_CENTER = '" + uC_cost.ID.Text+"', notes = '" + Notes.Text+"', S_DATE = '" + Sdate.Text+
                                "', med_MEZAN = '" + uC_FinalAcc.ID.Text+"', user_id = '" + UC_User.Desc.Text+"', MultyCurrency = '" + UC_MultiCurncey.Desc.Text+
                                "', Currency_Code = '" + uC_currency.ID.Text+"', Last_Currency_Value_Purch = '" + UC_Purch_price.Desc.Text.ToDecimal()+
                                "', Last_Currency_Value_Sales = '" + UC_Sales_price.Desc.Text+"', CREDIT_AGE = '" + UC_days.Desc.Text.ToDecimal()+
                                "', COSTMER_CASH_NO = '" + uC_CashCard.ID.Text+"', CAT_CODE = '" + uC_Catogry.ID.Text+"', acc_no2 = '" + uC_OtherNu.ID.Text+
                                "', KM_CODE_Sales = '" + KM_Sales.ID.Text+"', KM_CODE_Purch = '" + KM_Purch.ID.Text+"', EXTER_EXP = '" + UC_KM_no.Desc.Text+
                                "'where  acc_type = '"+CoId.Text+"' and ACC_NO = '"+AccId.Text+"' and BRANCH_code = '" + BranchId.Text+"'");
                                 
                TV1.Nodes.Clear();
                _acountsTb = dal.getDataTabl_1("select * FROM payer2 where BRANCH_code='" + Properties.Settings.Default.BranchId + "'");
                PopulateTreeView("0", null);
                TV1.SelectedNode = GetNodeByName(TV1.Nodes, MAccId.Text);
                TV1.SelectedNode.ExpandAll();

            }

                        else
                        {
                            MessageBox.Show("تاكد من اكمال البيانات الاساسية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        
                    }



                    private void BExit_Click(object sender, EventArgs e)
                    {
                        this.Close();
                    }

                   
                    private void ToolStripMenuItem2_Click(object sender, EventArgs e)
                    {
                        if (TV1.SelectedNode != null)
                        {
                            DataTable dt_1 = dal.getDataTabl_1("select * from daily_transaction where acc_no='" + AccId.Text + "'");
                            if (TV1.SelectedNode.Nodes.Count > 0)
                            {
                                MessageBox.Show("لايمكن حذف الحساب لوجود حسابات متفرعة منه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;

                            }


                            if (dt_1.Rows.Count > 0)
                            {
                                MessageBox.Show("لايمكن حذف الحساب لوجود حركة علية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                if (MessageBox.Show("هل تريد حذف الحساب رقم : '"+AccId.Text+"'" , "تحذير !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                                {

                                    dal.Execute_1("delete from payer2 where acc_no='" + AccId.Text + "'");

                                    TV1.SelectedNode.Remove();
                                    MessageBox.Show("تم حذف الحساب", "تأكيد الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
 
                                }

                            }

                        }
                        else
                        {
                            MessageBox.Show("يجب تحديد الحساب المراد حذفة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

        private void BSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
    