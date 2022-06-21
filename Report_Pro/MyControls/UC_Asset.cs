// Decompiled with JetBrains decompiler
// Type: Report_Pro.MyControls.UC_Asset
// Assembly: Report_Pro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 39327453-3C78-42DC-8027-AE7037A66322
// Assembly location: C:\Users\Walid\Desktop\Report_Pro.exe

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Report_Pro.DAL;
using Report_Pro.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
  public partial class UC_Asset : UserControl
  {
        DataAccesslayer1 dal = new DataAccesslayer1();

        public UC_Asset() { InitializeComponent(); }

    private void UC_Catogry_Load(object sender, EventArgs e)
    {
    }

    private void ID_KeyUp(object sender, KeyEventArgs e) { this.get_desc();}

    private void get_desc()
    {
      try
      {
        DataTable dataTabl1 = this.dal.getDataTabl_1("SELECT id,Name,Name_L FROM AssetsTbl where id = '" + this.ID.Text + "' and BranchCode Like '" + this.txtBranch.Text + "%' and GroupID like '" + this.txtGroup.Text + "%' and assLocation like '" + this.txtLocation.Text + "%'");
        if (this.ID.Text != "" && dataTabl1.Rows.Count > 0)
        {
          this.ID.Text = dataTabl1.Rows[0]["id"].ToString();
          if (Settings.Default.lungh == "0")
            this.Desc.Text = dataTabl1.Rows[0]["Name"].ToString();
          else
            this.Desc.Text = dataTabl1.Rows[0]["Name_L"].ToString();
        }
        else
          this.Desc.Clear();
      }
      catch
      {
      }
    }

    private void btn1_Click(object sender, EventArgs e) { this.OnClick(e);}

    private void ID_TextChanged(object sender, EventArgs e)
    {
      this.get_desc();
      this.OnLoad(e);
    }

    private void ID_KeyDown(object sender, KeyEventArgs e) { this.OnKeyDown(e); }

    private void Desc_TextChanged(object sender, EventArgs e)
    {
    }

  

      }
}
