using DevExpress.XtraEditors;
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
    public partial class frm_storePlan : XtraForm
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string btntype = "0";
        Int32 m;

        public frm_storePlan()
        {
            InitializeComponent();


            txtUnit.DataSource = dal.getDataTabl_1("SELECT Wh_Unit,unit_Description,unit_Description_E FROM Wh_Unit");

            txtUnit.ValueMember = "Wh_Unit";
            if (Properties.Settings.Default.lungh == "0")
            {
                txtUnit.DisplayMember = "unit_Description";
            }
            else
            {
                txtUnit.DisplayMember = "unit_Description_E";
            }

            txtUnit.SelectedIndex = -1;
        }

        private void frm_storePlan_Load(object sender, EventArgs e)
        {
            toDate_Sales.Value = DateTime.Today;
            fromDate_Sales.Value = DateTime.Today.AddDays(-90); ;
        }

        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
                txtWeight.Text = txtItem.itemWeight.Value.ToString();
                txtUnit.SelectedValue = txtItem.itemUnit.Text;
                txtThickness.Text = txtItem.txtDepth.Value.ToString("N2");
                txtStoreStock.Text = get_itemBalance(txtItem.ID.Text).Rows[0]["S_Balance"].ToString().ToDecimal().ToString("N0");
                txtBranchsStock.Text= get_itemBalance(txtItem.ID.Text).Rows[0]["B_Balance"].ToString().ToDecimal().ToString("N0");
                txtStoreStock_W.Text = Math.Round((txtStoreStock.Value * txtWeight.Value/1000),0).ToString("N0");
                txtBranchsStock_W.Text = Math.Round((txtBranchsStock.Value * txtWeight.Value/1000),0).ToString("N0");
                txtSalesAverag.Text = (get_itemSales(txtItem.ID.Text, fromDate_Sales.Value, toDate_Sales.Value).Rows[0]["itemSale"].ToString().ToDecimal()*30/txtSalesDays.Value).ToString("N0");
                txtTotalStock.Text = (txtStoreStock.Value + txtBranchsStock.Value).ToString("N0");
                txtTotalStock_W.Text = (txtStoreStock_W.Value + txtBranchsStock_W.Value).ToString("N0");
            }
        }

        private DataTable get_itemBalance(string _itemCode)
        {
           DataTable dtBalance= dal.getDataTabl_1(@"select * from (select sum (case when branch_code ='A1112' and Cyear =22 and item_no='" + _itemCode + "' then QTY_ADD - QTY_TAKE  else 0 end)  as B_Balance" +
               ", sum (case when branch_code <>'A1112' and Cyear ='"+Properties.Settings.Default.C_year+"' and item_no='"+_itemCode+"' then QTY_ADD - QTY_TAKE  else 0 end) as S_Balance from wh_material_transaction) as x");
            if (dtBalance.Rows.Count > 0)
            {
                return dtBalance;
            }
            else
            {
                return null;
            }
        }

        private DataTable get_itemSales(string _itemCode,DateTime _fDate,DateTime _tDate)
        {
            DataTable dtSales = dal.getDataTabl_1(@"select sum(QTY_TAKE- QTY_ADD) as itemSale from wh_material_transaction where TRANSACTION_CODE like 'xs%' and ITEM_NO = '"+_itemCode+"' and CAST (G_DATE as date) between '"+_fDate.ToString("yyyy-MM-dd")+"' and '"+_tDate.ToString("yyyy-MM-dd")+"'");
            if (dtSales.Rows.Count > 0)
            {
                return dtSales;
            }
            else
            {
                return null;
            }
        }



        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (btntype == "0")
            {
               
                addrow_new();
                btntype = "0";


            }
            else if (btntype == "1")
            {
                editrow();
                btntype = "0";

            }


            foreach (DataGridViewRow row in this.dgv1.Rows)
            {
                row.Cells[0].Value = string.Format("{0}", row.Index + 1);
                // dgv1.EnableHeadersVisualStyles = false;


            }


        }

        void addrow_new()
        {
            DataGridViewRow r = (DataGridViewRow)dgv1.RowTemplate.Clone();
            r.CreateCells(dgv1);

            //r.Cells[0].Value = mapping.Key;
            //r.Cells[1].Value = ((BusinessObject)mapping.Value).Name;
            //r.Cells[1].Tag = mapping.Value;



            // DataGridViewRow  r = dataGridView1.NewRow(1);
            r.Cells[1].Value = txtItem.ID.Text;
            r.Cells[2].Value = txtItem.Desc.Text;
            r.Cells[3].Value = txtDescription.Text;
            r.Cells[4].Value = txtUnit.Text;
            r.Cells[5].Value = txtThickness.Text.ToDecimal().ToString("N2");
            r.Cells[6].Value = txtWeight.Text.ToDecimal().ToString("N3");
            r.Cells[7].Value = txtStoreStock.Text.ToDecimal().ToString("N0");
            r.Cells[8].Value = txtStoreStock_W.Text.ToDecimal().ToString("N0");
            r.Cells[9].Value = txtBranchsStock.Text.ToDecimal().ToString("N0");
            r.Cells[10].Value = txtBranchsStock_W.Text.ToDecimal().ToString("N0");
            r.Cells[11].Value = txtTotalStock.Text.ToDecimal().ToString("N0");
            r.Cells[12].Value = txtTotalStock_W.Text.ToDecimal().ToString("N0");
            r.Cells[13].Value = txtSalesAverag.Text.ToDecimal().ToString("N0");
            r.Cells[14].Value = txtUnit.SelectedValue;
            dgv1.Rows.Add(r);
            cleartextbooks();
            txtItem.ID.Focus();
            //total_inv();

        }


        private void cleartextbooks()
        {
            txtItem.ID.Clear();
            txtItem.Desc.Clear();
            txtDescription.Clear();
            txtUnit.SelectedIndex = -1;
            txtWeight.Clear();
            txtThickness.Clear();
            txtStoreStock.Clear();
            txtStoreStock_W.Clear();
            txtBranchsStock.Clear();
            txtBranchsStock_W.Clear();
            txtTotalStock.Clear();
            txtTotalStock_W.Clear();
            txtSalesAverag.Clear();
            
        }


        void editrow()
        {

            dgv1.Rows[m].Cells[1].Value = txtItem.ID.Text;
            dgv1.Rows[m].Cells[2].Value = txtItem.Desc.Text;
            dgv1.Rows[m].Cells[3].Value = txtDescription.Text;
            dgv1.Rows[m].Cells[4].Value = txtUnit.Text;
            dgv1.Rows[m].Cells[5].Value = txtThickness.Text.ToDecimal().ToString("N2");
            dgv1.Rows[m].Cells[6].Value = txtWeight.Text.ToDecimal().ToString("N3");
            dgv1.Rows[m].Cells[7].Value = txtStoreStock.Text.ToDecimal().ToString("N0");
            dgv1.Rows[m].Cells[8].Value = txtStoreStock.Text.ToDecimal().ToString("N0");
            dgv1.Rows[m].Cells[9].Value = txtBranchsStock.Text.ToDecimal().ToString("N0");
            dgv1.Rows[m].Cells[10].Value = txtBranchsStock_W.Text.ToDecimal().ToString("N0");
            dgv1.Rows[m].Cells[11].Value = txtTotalStock.Text.ToDecimal().ToString("N0");
            dgv1.Rows[m].Cells[12].Value = txtTotalStock_W.Text.ToDecimal().ToString("N0");
            dgv1.Rows[m].Cells[13].Value = txtSalesAverag.Text.ToDecimal().ToString("N0");
            dgv1.Rows[m].Cells[14].Value = txtUnit.SelectedValue;



            cleartextbooks();
            txtItem.ID.Focus();
           // total_inv();

        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btntype = "1";
            m = dgv1.CurrentRow.Index;
            //try
            //{
            //DataTable itemdata_ = dal.getDataTabl("get_product_name", dGV_Item.CurrentRow.Cells[0].Value.ToString(), Properties.Settings.Default.CoId);
            txtItem.ID.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
            txtItem.Desc.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            txtUnit.SelectedValue = dgv1.CurrentRow.Cells[14].Value.ToString();
            txtThickness.Text = dgv1.CurrentRow.Cells[5].Value.ToString().ToDecimal().ToString("N2"); ;
            txtWeight.Text = dgv1.CurrentRow.Cells[6].Value.ToString().ToDecimal().ToString("N3"); 
            txtStoreStock.Text= dgv1.CurrentRow.Cells[7].Value.ToString().ToDecimal().ToString("N0");
            txtStoreStock.Text= dgv1.CurrentRow.Cells[8].Value.ToString().ToDecimal().ToString("N0");
            txtBranchsStock.Text = dgv1.CurrentRow.Cells[9].Value.ToString().ToDecimal().ToString("N0");
            txtBranchsStock_W.Text = dgv1.CurrentRow.Cells[10].Value.ToString().ToDecimal().ToString("N0");
            txtTotalStock.Text = dgv1.CurrentRow.Cells[11].Value.ToString().ToDecimal().ToString("N0");
            txtTotalStock_W.Text = dgv1.CurrentRow.Cells[12].Value.ToString().ToDecimal().ToString("N0");
            txtSalesAverag.Text = dgv1.CurrentRow.Cells[13].Value.ToString().ToDecimal().ToString("N0");




        }

        private void fromDate_Sales_Click(object sender, EventArgs e)
        {

        }

        private void toDate_Sales_Click(object sender, EventArgs e)
        {

        }

        private void toDate_Sales_ValueChanged(object sender, EventArgs e)
        {
            txtSalesDays.Text = (toDate_Sales.Value - fromDate_Sales.Value).TotalDays.ToString("N0");

        }

        private void fromDate_Sales_ValueChanged(object sender, EventArgs e)
        {
            txtSalesDays.Text = (toDate_Sales.Value - fromDate_Sales.Value).TotalDays.ToString("N0");

        }
    }
}
