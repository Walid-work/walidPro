// Decompiled with JetBrains decompiler
// Type: Report_Pro.MyControls.Uc_TransactionAssets
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
  public partial class Uc_TransactionAssets : UserControl
  {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Uc_TransactionAssets() {
            InitializeComponent();
        } 

    private void ID_KeyUp(object sender, KeyEventArgs e) { this.get_desc();}

    private void get_desc()
    {
      try
      {
        DataTable dataTabl1 = this.dal.getDataTabl_1("SELECT Tr_Name, Tr_Name_E FROM Fas_Transaction_code where Tr_Code = '" + this.ID.Text + "'");
        if (dataTabl1.Rows.Count > 0)
        {
          if (Settings.Default.lungh == "0")
            this.Desc.Text = dataTabl1.Rows[0]["Tr_Name"].ToString();
          else
            this.Desc.Text = dataTabl1.Rows[0]["Tr_Name_E"].ToString();
        }
        else
          this.Desc.Clear();
      }
      catch
      {
      }
    }

    private void btn1_Click(object sender, EventArgs e) { this.search_();}

    private void search_()
    {
      try
      {
        this.dgv1.Visible = true;
        this.Height = 130;
        this.BringToFront();
        this.dgv1.DataSource = (object) this.dal.getDataTabl_1("SELECT Tr_Code,Tr_Name, Tr_Name_E FROM Fas_Transaction_code where  Tr_Name like '%" + this.Desc.Text + "'+'%' or Tr_Name_E like '%" + this.Desc.Text + "'+'%'  ");
        this.dgv1.Columns[0].Width = 100;
      }
      catch
      {
      }
    }

    private void Desc_KeyUp(object sender, KeyEventArgs e) { this.search_(); }

    private void ID_Enter(object sender, EventArgs e)
    {
      this.dgv1.Visible = false;
      this.Height = 23;
      this.SendToBack();
    }

    private void dgv1_DoubleClick(object sender, EventArgs e)
    {
      this.ID.Text = this.dgv1.Rows[this.dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString();
      this.get_desc();
      this.dgv1.Visible = false;
      this.Height = 23;
      this.SendToBack();
    }

    private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void ID_TextChanged(object sender, EventArgs e)
    {
      this.get_desc();
      this.OnLoad(e);
    }

    private void Desc_TextChanged(object sender, EventArgs e)
    {
    }

    private void Uc_TransactionAssets_Leave(object sender, EventArgs e)
    {
      this.dgv1.Visible = false;
      this.Height = 23;
      this.SendToBack();
    }

    ////protected override void Dispose(bool disposing)
    ////{
    ////  if (disposing && this.components != null)
    ////    this.components.Dispose();
    ////  base.Dispose(disposing);
    ////}

    //private void InitializeComponent()
    //{
    //  ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Uc_TransactionAssets));
    //  DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
    //  this.dgv1 = new DataGridViewX();
    //  this.Desc = new TextBoxX();
    //  this.btn1 = new ButtonX();
    //  this.ID = new TextBoxX();
    //  ((ISupportInitialize) this.dgv1).BeginInit();
    //  this.SuspendLayout();
    //  componentResourceManager.ApplyResources((object) this.dgv1, "dgv1");
    //  this.dgv1.AllowUserToAddRows = false;
    //  this.dgv1.AllowUserToDeleteRows = false;
    //  this.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    //  this.dgv1.BackgroundColor = SystemColors.Window;
    //  this.dgv1.BorderStyle = BorderStyle.None;
    //  this.dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    //  this.dgv1.ColumnHeadersVisible = false;
    //  gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    //  gridViewCellStyle.BackColor = SystemColors.Window;
    //  gridViewCellStyle.Font = new Font("Tahoma", 8f);
    //  gridViewCellStyle.ForeColor = SystemColors.ControlText;
    //  gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
    //  gridViewCellStyle.SelectionForeColor = SystemColors.ControlText;
    //  gridViewCellStyle.WrapMode = DataGridViewTriState.False;
    //  this.dgv1.DefaultCellStyle = gridViewCellStyle;
    //  this.dgv1.GridColor = Color.FromArgb(208, 215, 229);
    //  this.dgv1.Name = "dgv1";
    //  this.dgv1.ReadOnly = true;
    //  this.dgv1.RowHeadersVisible = false;
    //  this.dgv1.DoubleClick += new EventHandler(this.dgv1_DoubleClick);
    //  componentResourceManager.ApplyResources((object) this.Desc, "Desc");
    //  this.Desc.Border.Class = "TextBoxBorder";
    //  this.Desc.ButtonCustom.DisplayPosition = (int) componentResourceManager.GetObject("Desc.ButtonCustom.DisplayPosition");
    //  this.Desc.ButtonCustom.Image = (Image) componentResourceManager.GetObject("Desc.ButtonCustom.Image");
    //  this.Desc.ButtonCustom.Text = componentResourceManager.GetString("Desc.ButtonCustom.Text");
    //  this.Desc.ButtonCustom2.DisplayPosition = (int) componentResourceManager.GetObject("Desc.ButtonCustom2.DisplayPosition");
    //  this.Desc.ButtonCustom2.Image = (Image) componentResourceManager.GetObject("Desc.ButtonCustom2.Image");
    //  this.Desc.ButtonCustom2.Text = componentResourceManager.GetString("Desc.ButtonCustom2.Text");
    //  this.Desc.Name = "Desc";
    //  this.Desc.KeyUp += new KeyEventHandler(this.Desc_KeyUp);
    //  componentResourceManager.ApplyResources((object) this.btn1, "btn1");
    //  this.btn1.AccessibleRole = AccessibleRole.PushButton;
    //  this.btn1.ColorTable = eButtonColor.OrangeWithBackground;
    //  this.btn1.Image = (Image) Resources.search_16;
    //  this.btn1.Name = "btn1";
    //  this.btn1.Click += new EventHandler(this.btn1_Click);
    //  componentResourceManager.ApplyResources((object) this.ID, "ID");
    //  this.ID.Border.Class = "TextBoxBorder";
    //  this.ID.ButtonCustom.DisplayPosition = (int) componentResourceManager.GetObject("ID.ButtonCustom.DisplayPosition");
    //  this.ID.ButtonCustom.Image = (Image) componentResourceManager.GetObject("ID.ButtonCustom.Image");
    //  this.ID.ButtonCustom.Text = componentResourceManager.GetString("ID.ButtonCustom.Text");
    //  this.ID.ButtonCustom2.DisplayPosition = (int) componentResourceManager.GetObject("ID.ButtonCustom2.DisplayPosition");
    //  this.ID.ButtonCustom2.Image = (Image) componentResourceManager.GetObject("ID.ButtonCustom2.Image");
    //  this.ID.ButtonCustom2.Text = componentResourceManager.GetString("ID.ButtonCustom2.Text");
    //  this.ID.Name = "ID";
    //  this.ID.TextChanged += new EventHandler(this.ID_TextChanged);
    //  this.ID.Enter += new EventHandler(this.ID_Enter);
    //  this.ID.KeyUp += new KeyEventHandler(this.ID_KeyUp);
    //  componentResourceManager.ApplyResources((object) this, "$this");
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.BorderStyle = BorderStyle.Fixed3D;
    //  this.Controls.Add((Control) this.dgv1);
    //  this.Controls.Add((Control) this.Desc);
    //  this.Controls.Add((Control) this.btn1);
    //  this.Controls.Add((Control) this.ID);
    //  this.Name = nameof (Uc_TransactionAssets);
    //  this.Leave += new EventHandler(this.Uc_TransactionAssets_Leave);
    //  ((ISupportInitialize) this.dgv1).EndInit();
    //  this.ResumeLayout(false);
    //}
  }
}
