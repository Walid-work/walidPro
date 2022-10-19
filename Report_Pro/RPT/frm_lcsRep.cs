// Decompiled with JetBrains decompiler
// Type: Report_Pro.RPT.frm_lcsRep
// Assembly: Report_Pro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 39327453-3C78-42DC-8027-AE7037A66322
// Assembly location: C:\Users\Walid\Desktop\Report_Pro.exe

using CrystalDecisions.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using Report_Pro.DAL;
using Report_Pro.MyControls;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_lcsRep : Form
  {
       DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

    public frm_lcsRep() {
        InitializeComponent();
    }
    private void groupPanel2_Click(object sender, EventArgs e)
    {
    }

    private void btnReport_Click(object sender, EventArgs e)
    {
            string titeltext = "";
            if (comb1.SelectedIndex == 0)
            {
                titeltext = "Isue Date";
            }
            else if (comb1.SelectedIndex == 1)
            {
                titeltext = "Expiry Date";
            }
            else if (comb1.SelectedIndex == 2)
            {
                titeltext = "Last Ship Date";
            }

            RPT.rpt_lcsRpt rptLcsRpt = new rpt_lcsRpt();
      DataTable dataTabl1 = this.dal.getDataTabl_1(@"SELECT L.*,p.PAYER_NAME as bankName 
        ,p1.PAYER_NAME as SuplierName ,p.payer_l_name as bankNameE ,p1.payer_l_name as SuplierNameE  
        ,c.Currency_Name as CurrencyName 
        FROM LcsTbl as L 
        inner join wh_BRANCHES as B on L.Branch_Code=B.Branch_code 
        inner join payer2 as p on L.BID=p.ACC_NO and B.ACC_BRANCH=P.BRANCH_code 
        inner join payer2 as p1 on L.Supplier=p1.ACC_NO and B.ACC_BRANCH=P1.BRANCH_code 
        inner join Wh_Currency as C on C.Currency_Code=L.Currency 
        where ( case when '"+comb1.SelectedIndex+ "'=0 then OpenDate when '" + comb1.SelectedIndex + "'=1  then ExpiryDate when'" + comb1.SelectedIndex + "'=2  then LShipDate end ) between '" + this.fromDate.Value.ToString("yyyy/MM/dd") 
        + "' and '" + this.toDate.Value.ToString("yyyy/MM/dd") + "'");
      DataSet dataSet = new DataSet();
      dataSet.Tables.Add(dataTabl1);
      //dataSet.WriteXmlSchema("schema_rpt.xml");
      rptLcsRpt.SetDataSource(dataSet);
      this.crystalReportViewer1.ReportSource = (object) rptLcsRpt;
            rptLcsRpt.DataDefinition.FormulaFields["From_date"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            rptLcsRpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";
            rptLcsRpt.DataDefinition.FormulaFields["titelText"].Text = "'" + titeltext+ "'";


            this.groupPanel2.Visible = false;
    }

        //public override void preview()
        //{
        //    base.preview();
        //    string titeltext = "";
        //    if (comb1.SelectedIndex == 0)
        //    {
        //        titeltext = "Isue Date";
        //    }
        //    else if (comb1.SelectedIndex == 1)
        //    {
        //        titeltext = "Expiry Date";
        //    }
        //    else if (comb1.SelectedIndex == 2)
        //    {
        //        titeltext = "Last Ship Date";
        //    }

        //    RPT.rpt_lcsRpt rptLcsRpt = new rpt_lcsRpt();
        //    DataTable dataTabl1 = this.dal.getDataTabl_1(@"SELECT L.*,p.PAYER_NAME as bankName 
        //,p1.PAYER_NAME as SuplierName ,p.payer_l_name as bankNameE ,p1.payer_l_name as SuplierNameE  
        //,c.Currency_Name as CurrencyName 
        //FROM LcsTbl as L 
        //inner join wh_BRANCHES as B on L.Branch_Code=B.Branch_code 
        //inner join payer2 as p on L.BID=p.ACC_NO and B.ACC_BRANCH=P.BRANCH_code 
        //inner join payer2 as p1 on L.Supplier=p1.ACC_NO and B.ACC_BRANCH=P1.BRANCH_code 
        //inner join Wh_Currency as C on C.Currency_Code=L.Currency 
        //where ( case when '" + comb1.SelectedIndex + "'=0 then OpenDate when '" + comb1.SelectedIndex + "'=1  then ExpiryDate when'" + comb1.SelectedIndex + "'=2  then LShipDate end ) between '" + this.fromDate.Value.ToString("yyyy/MM/dd")
        //      + "' and '" + this.toDate.Value.ToString("yyyy/MM/dd") + "'");
        //    DataSet dataSet = new DataSet();
        //    dataSet.Tables.Add(dataTabl1);
        //    //dataSet.WriteXmlSchema("schema_rpt.xml");
        //    rptLcsRpt.SetDataSource(dataSet);
        //    this.crystalReportViewer1.ReportSource = (object)rptLcsRpt;
        //    rptLcsRpt.DataDefinition.FormulaFields["From_date"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
        //    rptLcsRpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";
        //    rptLcsRpt.DataDefinition.FormulaFields["titelText"].Text = "'" + titeltext + "'";


        //    this.groupPanel2.Visible = false;

        //}

        //public override void Option()
        //{
        //    groupPanel2.Visible = true;
        //    base.Option();
        //}

        private void btnOption_Click(object sender, EventArgs e)
    {
        groupPanel2.Visible = true;

    }

        private void frm_lcsRep_Load(object sender, EventArgs e)
        {
            fromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            toDate.Value = DateTime.Today;

            comb1.SelectedIndex = 0;
        }
    }
}
