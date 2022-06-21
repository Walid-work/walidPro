using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_Invoice : Form
    {
        public frm_Invoice()
        {
            InitializeComponent();
        }

        private void frm_Invoice_Load(object sender, EventArgs e)
        {
            //gridView1.OptionsView.ShowGroupPanel = false;
            //gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;

            //var db = new DAL.dbDataContext();
            //gridControl1.DataSource = db.wh_main_masters.First();
            //GetData();

        }
    }
}
