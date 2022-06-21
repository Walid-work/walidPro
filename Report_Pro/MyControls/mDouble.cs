using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class mDouble : UserControl
    {
        public mDouble()
        {
            InitializeComponent();
        }

        private void d_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void d_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void d_Leave(object sender, EventArgs e)
        {
            OnLeave(e);
        }
    }
}
