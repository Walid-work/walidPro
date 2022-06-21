// Decompiled with JetBrains decompiler
// Type: Report_Pro.MyControls.delivryRow
// Assembly: Report_Pro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 39327453-3C78-42DC-8027-AE7037A66322
// Assembly location: C:\Users\Walid\Desktop\Report_Pro.exe

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using System;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
  public partial class delivryRow : UserControl
  {
    

        public delivryRow() { InitializeComponent(); }

    private void doubleInput1_ValueChanged(object sender, EventArgs e)
    {
    }

    private void txtRef_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtItemNo.Focus();
    }

    private void txtItemNo_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtQty.Focus();
    }

    private void txtQty_KeyDown(object sender, KeyEventArgs e) { this.OnKeyDown(e); }

   

  
  }
}
