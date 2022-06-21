// Decompiled with JetBrains decompiler
// Type: Report_Pro.PL.frmDepreciation
// Assembly: Report_Pro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 39327453-3C78-42DC-8027-AE7037A66322
// Assembly location: C:\Users\Walid\Desktop\Report_Pro.exe

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using Report_Pro.DAL;
using Report_Pro.MyControls;
using System;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Windows.Forms;

namespace Report_Pro.PL
{
  public partial class frmDepreciation : Form
  {
    DataAccesslayer1 dal = new DataAccesslayer1();
   

    public frmDepreciation()
    {
      InitializeComponent();
      cmbLocation.DataSource = dal.getDataTabl_1("SELECT * FROM FAS_LOCATION where BRANCH_CODE like '" + this.AccBranch.ID.Text + "%'");
      cmbLocation.ValueMember = "LOCATION_CODE";
      cmbLocation.DisplayMember = "LOCATION_NAME";
      cmbLocation.SelectedIndex = -1;
      cmbGroup.DataSource = dal.getDataTabl_1("SELECT * FROM AssetsGroup where isFinal = '1'");
      cmbGroup.ValueMember = "code";
      cmbGroup.DisplayMember = "Name";
      cmbGroup.SelectedIndex = -1;
    }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = dal.getDataTabl_1(@" select X.*,(CASE WHEN dep_Period<=0 THEN 0 
             WHEN Net_Value = 1 THEN 0
             when round(dep_Days / dep_Period * Net_Value, 0) > Net_Value - 1  then Net_Value - 1
             else round(dep_Days / dep_Period * Net_Value, 0) end ) as Dep_
              from(SELECT B.Id, b.Name, b.deprisStartDate, b.lastDepDate, (CASE  WHEN((B.assAge * 365) - (DATEDIFF(DAY, B.deprisStartDate, B.lastDepDate) - 1)) <= 0 THEN 0
              else ((B.assAge * 365) - (DATEDIFF(DAY, B.deprisStartDate, B.lastDepDate) - 1)) end ) as dep_Period,
			  (CASE  WHEN((B.assAge * 365) - (DATEDIFF(DAY, B.deprisStartDate, B.lastDepDate) - 1)) <= 0 THEN 0
              WHEN((B.assAge * 365) - (DATEDIFF(DAY, B.deprisStartDate, '" + this.depreciationDate.Value.ToString("yyyy-MM-dd") + "') - 1)) <= 0 THEN((B.assAge * 365) - (DATEDIFF(DAY, B.deprisStartDate, B.lastDepDate) - 1)) "+
              "else (DATEDIFF(day, B.lastDepDate, '" + this.depreciationDate.Value.ToString("yyyy-MM-dd") + "'))end ) as dep_Days, " +
              "(select sum(Meno - Loh)  FROM Fas_Transaction where Tr_Code = 'PUR' and fa_no = b.id) as Purchase, " +
              "(select sum(Meno - Loh)  FROM Fas_Transaction where Tr_Code = 'PUA' and fa_no = b.id) as Additions, " +
              "(select sum(Meno - Loh)  FROM Fas_Transaction where Tr_Code = 'PUM' and fa_no = b.id) as Decrease, " +
              "(select sum(Meno - Loh)  FROM Fas_Transaction where Tr_Code = 'DEP' and fa_no = b.id) as Depreciation, " +
              "(select sum(Meno - Loh)  FROM Fas_Transaction where Tr_Code = 'SAL' and fa_no = b.id) as Sales, " +
              "(select sum(Meno - Loh)  FROM Fas_Transaction where Tr_Code = 'TRA' and fa_no = b.id) as Transfer, " +
              "(select sum(Meno - Loh)  FROM Fas_Transaction where Tr_Code = 'TRX' and fa_no = b.id) as Excluded, " +
              "(select sum(Meno - Loh)  FROM Fas_Transaction where fa_no = b.id) as Net_Value " +
              "FROM AssetsTbl as B  left outer join Fas_Transaction as A  on A.Fa_No = B.Id " +
              "where b.assLocation like'" + this.cmbLocation.SelectedValue + "%' and b.BranchCode like '" + this.AccBranch.ID.Text + "%' and b.GroupID like '" + cmbGroup.SelectedValue + 
              "%'group by b.id,b.Name ,B.deprisStartDate,B.lastDepDate,B.assAge) X  ");
        }

    private void frmDeterioration_Load(object sender, EventArgs e)
    {
    }

    private void depreciationDate_Click(object sender, EventArgs e)
    {
    }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
