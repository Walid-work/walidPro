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
    public partial class frm_ReportMaster : XtraForm
    {
       bool IsNew;

        public static string ErrorText
        {
            get
            {
                return "هذا الحقل مطلوب";
            }
        }

        public frm_ReportMaster()
        {
            InitializeComponent();
        }


        private void frm_Master_Load(object sender, EventArgs e)
        {
        
        }


       
        public virtual void Report()
        {

        }

        public virtual void preview()
        {

        }

        public int canEdit=1 ;

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



        public virtual void Option()
        {

        }

        public virtual void RefreshData()
        {

        }
        public virtual bool IsDataVailde()
        {
            return true;
        }



 

        private void btn_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (CheckActionAuthorization(this.Name, Master.Actions.Print))
            //    Print();
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
            if (e.KeyCode == Keys.F9)
            {
                Report();
            }
            if (e.KeyCode == Keys.F1)
            {
                Option();
            }
         
        }


       

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReportMaster));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Min = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Max = new DevExpress.XtraBars.BarButtonItem();
            this.btn_close = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Option = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Report = new DevExpress.XtraBars.BarButtonItem();
            this.btn_preview = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
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
            this.btn_close,
            this.btn_Max,
            this.btn_Min,
            this.skinDropDownButtonItem1,
            this.btn_Option,
            this.btn_Report,
            this.btn_preview});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 16;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(922, 141);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Min),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Max),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_close),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Option),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Report),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_preview)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.MinHeight = 35;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar2, "bar2");
            // 
            // btn_Min
            // 
            resources.ApplyResources(this.btn_Min, "btn_Min");
            this.btn_Min.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Min.Id = 7;
            this.btn_Min.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Min.ImageOptions.Image")));
            this.btn_Min.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Min.ImageOptions.ImageIndex")));
            this.btn_Min.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Min.ImageOptions.LargeImage")));
            this.btn_Min.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Min.ImageOptions.LargeImageIndex")));
            this.btn_Min.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Min.ImageOptions.SvgImage")));
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Min.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Min_ItemClick);
            // 
            // btn_Max
            // 
            resources.ApplyResources(this.btn_Max, "btn_Max");
            this.btn_Max.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Max.Id = 6;
            this.btn_Max.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Max.ImageOptions.Image")));
            this.btn_Max.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Max.ImageOptions.ImageIndex")));
            this.btn_Max.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Max.ImageOptions.LargeImage")));
            this.btn_Max.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Max.ImageOptions.LargeImageIndex")));
            this.btn_Max.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Max.ImageOptions.SvgImage")));
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Max_ItemClick);
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_close.Id = 4;
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_close.ImageOptions.ImageIndex")));
            this.btn_close.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.LargeImage")));
            this.btn_close.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_close.ImageOptions.LargeImageIndex")));
            this.btn_close.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_close.ImageOptions.SvgImage")));
            this.btn_close.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Red;
            this.btn_close.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btn_close.ItemAppearance.Hovered.Font")));
            this.btn_close.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_close.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btn_close.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_close.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_close.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btn_close.ItemAppearance.Normal.Font")));
            this.btn_close.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_close.Name = "btn_close";
            this.btn_close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_close_ItemClick);
            // 
            // btn_Option
            // 
            resources.ApplyResources(this.btn_Option, "btn_Option");
            this.btn_Option.Id = 9;
            this.btn_Option.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Option.ImageOptions.Image")));
            this.btn_Option.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Option.ImageOptions.ImageIndex")));
            this.btn_Option.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Option.ImageOptions.LargeImage")));
            this.btn_Option.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Option.ImageOptions.LargeImageIndex")));
            this.btn_Option.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Option.ImageOptions.SvgImage")));
            this.btn_Option.Name = "btn_Option";
            this.btn_Option.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Option.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Option_ItemClick);
            // 
            // btn_Report
            // 
            resources.ApplyResources(this.btn_Report, "btn_Report");
            this.btn_Report.Id = 14;
            this.btn_Report.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Report.ImageOptions.Image")));
            this.btn_Report.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Report.ImageOptions.ImageIndex")));
            this.btn_Report.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Report.ImageOptions.LargeImage")));
            this.btn_Report.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Report.ImageOptions.LargeImageIndex")));
            this.btn_Report.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Report.ImageOptions.SvgImage")));
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Report.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Report_ItemClick);
            // 
            // btn_preview
            // 
            resources.ApplyResources(this.btn_preview, "btn_preview");
            this.btn_preview.Id = 15;
            this.btn_preview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_preview.ImageOptions.Image")));
            this.btn_preview.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_preview.ImageOptions.ImageIndex")));
            this.btn_preview.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_preview.ImageOptions.LargeImage")));
            this.btn_preview.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_preview.ImageOptions.LargeImageIndex")));
            this.btn_preview.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_preview.ImageOptions.SvgImage")));
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_preview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_preview_ItemClick);
            // 
            // barDockControlTop
            // 
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Manager = this.barManager1;
            // 
            // barDockControlBottom
            // 
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Manager = this.barManager1;
            // 
            // barDockControlLeft
            // 
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Manager = this.barManager1;
            // 
            // barDockControlRight
            // 
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Manager = this.barManager1;
            // 
            // skinDropDownButtonItem1
            // 
            resources.ApplyResources(this.skinDropDownButtonItem1, "skinDropDownButtonItem1");
            this.skinDropDownButtonItem1.Id = 8;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
          
            // frm_ReportMaster
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.ControlBox = false;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_ReportMaster";
            this.Load += new System.EventHandler(this.frm_ReportMaster_Load);
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

       

        private void btn_Max_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaxForm(this);
        }

        private void btn_Min_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MinForm(this);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                    }

       

     

        private void frm_ReportMaster_Load(object sender, EventArgs e)
        {
            //if (CheckActionAuthorization(this.Name, Master.Actions.Edit))
            //{
            //    canEdit = 1;
            //}
            //else
            //{
            //    canEdit = 0;
            //}
        }

        private void btn_Option_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Option();
        }

        private void btn_preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckActionAuthorization(this.Name, Master.Actions.Print))
                preview();
        }

        private void btn_Report_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (CheckActionAuthorization(this.Name, Master.Actions.Print))
                Report();

        }
    }
    }

