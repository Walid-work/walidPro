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
    public partial class frm_ChoseStore : Form
    {
        DataTable _acountsTb = null;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public int clos_;
        TreeNode _selectedStore = null;

        public frm_ChoseStore()
        {
            InitializeComponent();
        }

        private void frm_ChoseStore_Load(object sender, EventArgs e)
        {
            tvStore.Nodes.Clear();
            _acountsTb = dal.getDataTabl_1("select A.* from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code  where b.User_id = '" + Program.userID + "' ");

            //_acountsTb = dal.getDataTabl_1("SELECT * FROM wh_BRANCHES");
            PopulateTreeView_store("0", null);
        }

        private void PopulateTreeView_store(string parentId, TreeNode parentNode)
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

        private void tvStore_DoubleClick(object sender, EventArgs e)
        {
            clos_ = 1;
            this.Close();
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
    }
}
