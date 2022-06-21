using DevExpress.XtraEditors;
using Report_Pro.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro
{
    public partial class frm_Master : XtraForm
    {
        public bool IsNew;
        public static string ErrorText
        {
            get
            {

                return "هذا الحقل مطلوب";
            }
        }
        public frm_Master()
        {
            InitializeComponent();
           
        }

        private void frm_Master_Load(object sender, EventArgs e)
        {
        
        }
        public virtual void Save()
        {

                XtraMessageBox.Show("تم الحفظ بنجاح");
            RefreshData();
            IsNew = false;
        }
        public virtual void New()
        {
            GetData();
            IsNew = true;
        }
        public virtual void Delete()
        {

        }
        public virtual void Print()
        {

        }

        public virtual void CloseForm(Form frm)
        {
            frm.Close();
        }
        public virtual void MaxForm(Form frm)
        {
            if (frm.WindowState == FormWindowState.Normal)
            {
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
            }
        }
        public virtual void MinForm(Form frm)
        {
            frm.WindowState=FormWindowState.Minimized;
        }

        public virtual void GetData()
        {

        }

        public virtual void SetData()
        {

        }

        public virtual void Search()
        {

        }

        public virtual void RefreshData()
        {

        }
        public virtual bool IsDataVailde()
        {
            return true;
        }


        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckActionAuthorization(this.Name, IsNew ? Master.Actions.Add : Master.Actions.Edit))
                if (IsDataVailde())
                    Save();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckActionAuthorization(this.Name, Master.Actions.Add))

                New();

        }

        private void btn_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckActionAuthorization(this.Name, Master.Actions.Print))
                Print();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckActionAuthorization(this.Name, Master.Actions.Delete))
                Delete();
        }


        public static bool CheckActionAuthorization(string formName, Master.Actions actions, DAL.wh_USER user = null)
        {
            if (user == null)
                user = Session.User;

            if (user.CAN_GIVE_PERM == (byte)Master.UserType.Admin)
                return true;
            else
            {
                var screen = Session.ScreensAccesses.SingleOrDefault(x => x.ScreenName == formName);
                bool flag = true;
                if (screen != null)
                {
                    switch (actions)
                    {
                        case Master.Actions.Add:
                            flag = screen.CanAdd;
                            break;
                        case Master.Actions.Edit:
                            flag = screen.CanEdit;

                            break;
                        case Master.Actions.Delete:
                            flag = screen.CanDelete;

                            break;
                        case Master.Actions.Print:
                            flag = screen.CanPrint;

                            break;
                        default:
                            break;
                    }
                }
                if (flag == false)
                {
                    XtraMessageBox.Show(
         text: "غير مصرح لك ",
         caption: "",
         icon: MessageBoxIcon.Error,
         buttons: MessageBoxButtons.OK
         );
                }
                return flag;
            }


        }





        private void frm_Master_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Save();
            }
            if (e.KeyCode == Keys.F2)
            {
                New();
            }
            if (e.KeyCode == Keys.F3)
            {
                Delete();
            }
            if (e.KeyCode == Keys.F4)
            {
                Print();
            }
        }


       

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Master));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_New = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Print = new DevExpress.XtraBars.BarButtonItem();
            this.btn_search = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Min = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Max = new DevExpress.XtraBars.BarButtonItem();
            this.btn_close = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Save,
            this.btn_New,
            this.btn_Delete,
            this.btn_Print,
            this.btn_close,
            this.btn_search,
            this.btn_Max,
            this.btn_Min});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_New),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Print),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_search),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Min),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Max),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_close)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar2, "bar2");
            // 
            // btn_Save
            // 
            resources.ApplyResources(this.btn_Save, "btn_Save");
            this.btn_Save.Id = 0;
            this.btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Save.ImageOptions.SvgImage")));
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_ItemClick);
            // 
            // btn_New
            // 
            resources.ApplyResources(this.btn_New, "btn_New");
            this.btn_New.Id = 1;
            this.btn_New.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_New.ImageOptions.SvgImage")));
            this.btn_New.Name = "btn_New";
            this.btn_New.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_New_ItemClick);
            // 
            // btn_Delete
            // 
            resources.ApplyResources(this.btn_Delete, "btn_Delete");
            this.btn_Delete.Id = 2;
            this.btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Delete.ImageOptions.SvgImage")));
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Delete_ItemClick);
            // 
            // btn_Print
            // 
            resources.ApplyResources(this.btn_Print, "btn_Print");
            this.btn_Print.Id = 3;
            this.btn_Print.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Print.ImageOptions.SvgImage")));
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Print.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_Print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Print_ItemClick);
            // 
            // btn_search
            // 
            resources.ApplyResources(this.btn_search, "btn_search");
            this.btn_search.Id = 5;
            this.btn_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_search.ImageOptions.SvgImage")));
            this.btn_search.Name = "btn_search";
            this.btn_search.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_search.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_search_ItemClick);
            // 
            // btn_Min
            // 
            this.btn_Min.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Min.Id = 7;
            this.btn_Min.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Min.ImageOptions.Image")));
            this.btn_Min.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Min.ImageOptions.LargeImage")));
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Min_ItemClick);
            // 
            // btn_Max
            // 
            this.btn_Max.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Max.Id = 6;
            this.btn_Max.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Max.ImageOptions.Image")));
            this.btn_Max.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Max.ImageOptions.LargeImage")));
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Max_ItemClick);
            // 
            // btn_close
            // 
            this.btn_close.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_close.Id = 4;
            this.btn_close.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_close.ImageOptions.SvgImage")));
            this.btn_close.Name = "btn_close";
            this.btn_close.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_close_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.barManager1;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.barManager1;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.barManager1;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.barManager1;
            // 
            // frm_Master
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_Master";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm(this);
        }

        private void btn_search_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Search();
        }

        private void btn_Max_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaxForm(this);
        }

        private void btn_Min_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MinForm(this);
        }
    }
}
