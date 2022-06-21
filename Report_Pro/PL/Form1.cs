using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class Form1 : Form
    {
        TreeNode _selectedNode = null;
        DataTable _acountsTb = null;
        // bool _newNode, _thisLevel;
        // string _parent ;


        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _acountsTb = dal.getDataTabl_1(@"SELECT Menu_code,Menu_name,Menu_E_Name,Form_Name,isnull(Prev_no,0) as Prev_no,T_final,T_Level  FROM SysMenu  where T_final=0");

            PopulateTreeView("0", null);
        }
        private void PopulateTreeView(string parentId, TreeNode parentNode)
        {
            TreeNode childNode;
            foreach (DataRow dr in _acountsTb.Select("[prev_no]= '" + parentId + "'"))
            {
                TreeNode t = new TreeNode();
                t.Text = dr["Menu_code"].ToString() + " - " + dr["Menu_name"].ToString();
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

                    TV1.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }

                PopulateTreeView((dr["Menu_code"].ToString()), childNode);
            }
        }

        private void TV1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataTable dt_icons=dal.getDataTabl_1(@"select Menu_code, Menu_name, Menu_E_Name, Form_Name, Software_code, Securty_Code, securty_code2, Securty_Mode, MAIN_NO, Prev_no, T_final, T_Level,  isnull(Image_Large_icon,0) as Image_Large_icon , Image_Small_Icon, Notes, User_id, 
                         G_Date, administrator_level, Screen_name
 from SysMenu  where prev_no ='" + TV1.SelectedNode.Name + "'");
            listView1.Items.Clear();
            //foreach (DataRow r in dt_icons.Rows)
            //{
            //    listView1.Items.Add(r["Menu_name"].ToString());

            //    listView1.LargeImageList=imageList1;
            //} 
            for (int i = 0; i < dt_icons.Rows.Count; i++)
            {
                DataRow dr = dt_icons.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Menu_name"].ToString());
                listitem.SubItems.Add(dr["Form_Name"].ToString());
                 listitem.ImageIndex= Convert.ToInt32(dr["Image_Large_icon"]);



                listView1.Items.Add(listitem);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
       
        
        string s = listView1.SelectedItems[0].SubItems[1].Text;
            Type FormInstanceType = Type.GetType(GetType().Namespace +"."+ s, true, true);
            Form objForm = (Form)Activator.CreateInstance(FormInstanceType);
            objForm.Show();
            

        }
    }
}
