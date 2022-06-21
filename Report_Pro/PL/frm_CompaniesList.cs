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
    public partial class frm_CompaniesList : XtraForm
    {
        public frm_CompaniesList()
        {
            InitializeComponent();
        }

        private void frm_CompaniesList_Load(object sender, EventArgs e)
        {
            var db = new DAL.dbDataContext();
            gridControl1.DataSource = db.Wh_Oiner_Comps;
            gridView1.OptionsBehavior.Editable = false; // عدم السماح بالتعديلات
            gridView1.Columns["Company_No"].Caption = "Code";
            gridView1.Columns["Company_a_name"].Caption = "Name";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
