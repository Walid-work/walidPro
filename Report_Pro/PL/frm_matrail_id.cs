using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{

   
    public partial class frm_matrail_id : Form
    {
        TreeNode _selectedNode = null;
        DataTable _acountsTb = null;
        // bool _newNode, _thisLevel;
        // string _parent ;


        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_matrail_id()
        {
            InitializeComponent();
        }

        private void frm_matrail_id_Load(object sender, EventArgs e)
        {
          
            }



        private void PopulateTreeView(string parentId, TreeNode parentNode)
        {

            TreeNode childNode;
            foreach (DataRow dr in _acountsTb.Select("Master_Material_id = '" + parentId + "'"))
            {
                TreeNode t = new TreeNode();
                t.Text = dr["Material_id"].ToString() + " : " + dr["descr"].ToString() + " : " + dr["qty"].ToString().ToDecimal().ToString("N0");
                t.Name = dr["Material_id"].ToString();
                t.Tag = _acountsTb.Rows.IndexOf(dr);
                //if (dr["t_final"].ToString() == "0")
                //{
                //    t.ImageIndex = 0;
                //    t.SelectedImageIndex = 1;
                //}
                //else
                //{
                //    t.ImageIndex = 2;
                //    t.SelectedImageIndex = 6;
                //}
                if (parentNode == null)
                {

                    //TV1.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }

                PopulateTreeView((dr["Material_id"].ToString()), childNode);
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            RPT.rpt_CoilProduction rpt = new RPT.rpt_CoilProduction();
            DataTable dtCoil = dal.getDataTabl_1(@"SELECT  Branch_code,t.ITEM_NO,round(QTY_TAKE-QTY_ADD,0)  as qty,t.G_DATE ,Material_id ,isnull(Master_Material_id,0) as Master_Material_id  ,IN_OUT_TYPE,descr
            FROM wh_material_transaction as t inner join wh_main_master as M on M.item_no=t.ITEM_NO  where TRANSACTION_CODE='xtp' and  Branch_code='A1012' and( Material_id='H0256124' or  Master_Material_id='H0256124' or  Master_Material_id IN (select Material_id from  wh_material_transaction where Master_Material_id='H0256124' ) OR  Master_Material_id  IN(SELECT Material_id from wh_material_transaction where Master_Material_id IN (select Material_id from  wh_material_transaction where Master_Material_id='H0256124' ) ))");
            DataSet ds = new DataSet();
            ds.Tables.Add(dtCoil);
           

            //ds.WriteXmlSchema("schema1.xml");

            rpt.SetDataSource(ds);

            crystalReportViewer1.ReportSource = rpt;

        }


        //private void PopulateTreeView(DataTable dtParent, int parentId, TreeNode treeNode)
        //{
        //    foreach (DataRow row in dtParent.Rows)
        //    {
        //        TreeNode child = new TreeNode
        //        {
        //            Text = row["Material_id"].ToString(),
        //            Tag = row["Material_id"]
        //        };
        //        if (parentId == 0)
        //        {
        //            TV1.Nodes.Add(child);
        //            DataTable dtChild = dal.getDataTabl_1("SELECT Branch_code,ITEM_NO,QTY_ADD,QTY_TAKE,G_DATE,Material_id,Master_Material_id FROM wh_material_transaction WHERE  isnull( Master_Material_id,'') = " + child.Tag);
        //            PopulateTreeView(dtChild, Convert.ToInt32(child.Tag), child);
        //        }
        //        else
        //        {
        //            treeNode.Nodes.Add(child);
        //        }
        //    }
        //}
    }
}
