using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_Preview_Jor : Form
    {
        

        public DataTable dt_P_Jor = new DataTable();
        public frm_Preview_Jor()
        {
            InitializeComponent();

            creatDattable();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        void creatDattable()
        {
            dt_P_Jor.Columns.Add("مدين");
            dt_P_Jor.Columns.Add(" دائن");
            dt_P_Jor.Columns.Add(" كود الحساب");
            dt_P_Jor.Columns.Add(" اسم الحساب");
            dt_P_Jor.Columns.Add("البيان");
            dt_P_Jor.Columns.Add(" كود الكلفة");
            dt_P_Jor.Columns.Add("مركز الكلفة");
            dt_P_Jor.Columns.Add("رقم التصنيف");
            dt_P_Jor.Columns.Add("التصنيف");
            dGV_Item.DataSource = dt_P_Jor;
            //dGV_Item.Columns[7].Visible = false;
            //dGV_Item.Columns[8].Visible = false;
        }

        private void frm_Preview_Jor_Load(object sender, EventArgs e)
        {
    
        }
    }
}
