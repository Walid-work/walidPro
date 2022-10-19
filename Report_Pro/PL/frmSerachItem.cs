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
    public partial class frmSerachItem : XtraForm
    {

        public int clos_;

        private void uc_SearchItem1_Load(object sender, EventArgs e)
        {

        }

        public frmSerachItem()
        {
            InitializeComponent();
            
        }

        private void frmSerachItem_Load(object sender, EventArgs e)
        {

        }

        private void uc_SearchItem1_DoubleClick(object sender, EventArgs e)
        {
            clos_ = 1;
          this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
