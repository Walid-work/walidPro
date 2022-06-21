using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_ChoseAccBranch : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        TreeNode _selectedNode = null;
        DataTable _acountsTb = null;
        public string AccBranchCode = "";
        

        public frm_ChoseAccBranch()
        {
            InitializeComponent();
        }

        private void frm_ChoseAccBranch_Load(object sender, EventArgs e)
        {

           
          
                _acountsTb = dal.getDataTabl_1(@"select A.Branch_code,A.BRANCH_name,A.BRANCH_E_NAME,A.T_final,A.PREV_NO  from BRANCHS As A inner join Acc_users_branch As B on A.Branch_code =B.branch_code  where A.T_final =1 and  b.User_id = '" + Program.userID + "' ");
                PopulateTreeView_1("0", null);
             


          

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


        private void PopulateTreeView_1(string parentId, TreeNode parentNode)
        {
            TV1.Nodes.Clear();
            TreeNode childNode;
            TreeNode node1 = new TreeNode("الفروع");
            TV1.Nodes.Add(node1);
            foreach (DataRow dr in _acountsTb.Select())
            //.Select("[PREV_NO]= '" + parentId + "'"))
            {

                TreeNode t = new TreeNode();
                string branch_ = dr["Branch_code"].ToString();
                //if (string.IsNullOrEmpty(dr["Branch_code"].ToString()))
                //{ branch_ = "0"; }
                //else
                //{
                //    branch_ = dr["Branch_code"].ToString();
                //}
                if (Properties.Settings.Default.lungh == "0")
                {
                    t.Text = branch_ + " - " + dr["branch_name"].ToString();
                }
                else {
                    t.Text = branch_ + " - " + dr["BRANCH_E_NAME"].ToString();
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

                    node1.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }

                PopulateTreeView(branch_, childNode);
            }
        }

        private void TV1_AfterSelect(object sender, TreeViewEventArgs e)
        {try
            {
                _selectedNode = TV1.SelectedNode;
                GetData(_selectedNode);
                
            }
            catch { }
        }


        private void GetData(TreeNode nod)
        {
            try
            {
                DataRow r = _acountsTb.Rows[int.Parse(nod.Tag.ToString())];
                Properties.Settings.Default.BranchId = r[0].ToString();
                AccBranchCode = r[0].ToString();
            }
            catch { }

        }

        private void PopulateTreeView(string parentId, TreeNode parentNode)
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
                t.Text = branch_ + " - " + dr["branch_name"].ToString();
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

                    TV1.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }

                PopulateTreeView(branch_, childNode);
            }
        }

        private void TV1_DoubleClick(object sender, EventArgs e)
        {
            if (TV1.SelectedNode.Tag != null)
            {
                _selectedNode = TV1.SelectedNode;
                GetData(_selectedNode);
                this.Close();
            }
        }
    }
}
