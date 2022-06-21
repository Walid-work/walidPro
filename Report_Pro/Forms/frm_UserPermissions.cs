using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.Forms
{
    public partial class frm_UserPermissions : XtraForm
    {
        DAL.DataAccesslayer1 dal =new DAL.DataAccesslayer1();
        public frm_UserPermissions()
        {
            InitializeComponent();

            cmbProfile.DataSource = dal.getDataTabl_1(@"SELECT id,Name FROM UserAccessProfile");
            cmbProfile.DisplayMember = "Name";
            cmbProfile.ValueMember = "id";

        }

        RepositoryItemCheckEdit repoCheck;
        private void frm_AccessProfile_Load(object sender, EventArgs e)
        {
            GetPermissions();
            
        }


        private void GetPermissions()
        {
            var data = (from s in Classes.Screens.GetScreens.AsEnumerable()
                        join d in dal.getDataTabl_1(@"select * from UserAccessProfileDetails where ProfileID = '" + cmbProfile.SelectedValue + "'").AsEnumerable()
                        on s.ScreenID equals d["ScreeanID"]
                        into joinedDt
                        from d in joinedDt.DefaultIfEmpty()

                        select new Classes.ScreensAccessProfile(s.ScreenName)
                        {
                            Actions = s.Actions,
                            CanAdd = s.CanAdd,
                            CanDelete = s.CanDelete,
                            CanEdit = s.CanEdit,
                            CanOpen = s.CanOpen,
                            CanPrint = s.CanPrint,
                            CanShow = s.CanShow,
                            ScreenName = s.ScreenName,
                            ScreenCaption = s.ScreenCaption,
                            ScreenID = s.ScreenID,
                            ParentScreenID = s.ParentScreenID,
                        }).ToList();





            treeList1.DataSource = data;
            treeList1.KeyFieldName = nameof(ins.ScreenID);
            treeList1.ParentFieldName = nameof(ins.ParentScreenID);
            treeList1.Columns[nameof(ins.ScreenName)].Visible = false;
            treeList1.Columns[nameof(ins.ScreenName)].OptionsColumn.AllowEdit = false;
            //treeList1.Columns[nameof(ins.ScreenID)].OptionsColumn.AllowEdit = false;
            treeList1.Columns[nameof(ins.ScreenCaption)].OptionsColumn.AllowEdit = false;
            treeList1.BestFitColumns();

            treeList1.Columns[nameof(ins.CanAdd)].Caption = "اضافة";
            treeList1.Columns[nameof(ins.CanDelete)].Caption = "حذف";
            treeList1.Columns[nameof(ins.CanEdit)].Caption = "تعديل";
            treeList1.Columns[nameof(ins.CanOpen)].Caption = "فتح";
            treeList1.Columns[nameof(ins.CanPrint)].Caption = "طباعة";
            treeList1.Columns[nameof(ins.CanShow)].Caption = "اظهار";
            repoCheck = new RepositoryItemCheckEdit();
            repoCheck.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgRadio2;
            treeList1.Columns[nameof(ins.CanAdd)].ColumnEdit =
         treeList1.Columns[nameof(ins.CanDelete)].ColumnEdit =
           treeList1.Columns[nameof(ins.CanEdit)].ColumnEdit =
           treeList1.Columns[nameof(ins.CanOpen)].ColumnEdit =
          treeList1.Columns[nameof(ins.CanPrint)].ColumnEdit =
           treeList1.Columns[nameof(ins.CanShow)].ColumnEdit = repoCheck;

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        Classes.ScreensAccessProfile ins;

        private void treeList1_CustomNodeCellEdit(object sender, DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs e)
        {
            if (e.Node.Id >= 0)
            {
                var row = treeList1.GetRow(e.Node.Id) as Classes.ScreensAccessProfile;
                if (row != null)
                {
            if (e.Column.FieldName ==nameof (ins.CanAdd)&&
            row.Actions.Contains(Classes.Master.Actions.Add) == false)
            {
            e.RepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItem();
            }
            else if (e.Column.FieldName == nameof(ins.CanDelete) &&
            row.Actions.Contains(Classes.Master.Actions.Delete) == false)
            {
            e.RepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItem();
            }
            else if (e.Column.FieldName == nameof(ins.CanEdit) &&
            row.Actions.Contains(Classes.Master.Actions.Edit) == false)
            {
            e.RepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItem();
            }
            else if (e.Column.FieldName == nameof(ins.CanOpen) &&
            row.Actions.Contains(Classes.Master.Actions.Open) == false)
            {
            e.RepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItem();
            }
            else if (e.Column.FieldName == nameof(ins.CanPrint) &&
            row.Actions.Contains(Classes.Master.Actions.Print) == false)
            {
            e.RepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItem();
            }

            else if (e.Column.FieldName == nameof(ins.CanShow) &&
            row.Actions.Contains(Classes.Master.Actions.Show) == false)
            {
            e.RepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItem();
            }

                   
                }
            }
        }

        private void cmbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPermissions();
        }
    }
}
