using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.Forms
{
    public partial class frm_UserList : frm_Master
    {
        public frm_UserList()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
            gridView1.DoubleClick += GridView1_DoubleClick;
            RefreshData();
        }

        private void frm_DrawerList_Load(object sender, EventArgs e)
        {
           
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if(info.InRow || info.InRowCell)
            {
                var frm = new Forms.frm_Users(view.GetFocusedRowCellValue("USER_ID").ToString());
                frm_Main.OpenForm(frm, true); 
                RefreshData();
            }
        }

        public override void New()
        {
            var frm = new frm_Users();
            frm_Main.OpenForm(frm, true);
            base.New();
        }
      
        public override void RefreshData()
        {
            using(var db = new DAL.dbDataContext())
            {
                gridControl1.DataSource = db.wh_USERs.Select(p => new { p.USER_ID , p.USER_NAME }).ToList() ;
                
            }
            base.RefreshData();
        }
    }
}
