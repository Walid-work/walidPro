using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Report_Pro.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Report_Pro.Forms
{
    public partial class frm_Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        public static frm_Main _instance;
        public static frm_Main Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frm_Main();

                return _instance;
            }

        }

        public frm_Main()
        {
            InitializeComponent();

            accordionControl1.ElementClick += AccordionControl1_ElementClick;
            
        }

        private void AccordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
           
            var tag = e.Element.Tag as string;
            if(tag != string.Empty)
            {
                OpenFormByName(tag);
               
            }
           
        }

        public static void OpenFormByName(string name)
        {

            Form frm = null;

                    var ins = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == name);
                    if (ins != null)
                    {
                        frm = Activator.CreateInstance(ins) as Form;
                        if (Application.OpenForms[frm.Name] != null)
                        {
                       frm = Application.OpenForms[frm.Name];
                       frm.WindowState = FormWindowState.Maximized;
                        }
                        else
                        {
                            //    frm.Show();
                        }
                frm.WindowState = FormWindowState.Maximized;
                frm.BringToFront();

                    }
                 

            if (frm != null)
            {
                frm.Name = name;

                OpenForm(frm);
               
            }
        }
        public static void OpenForm(Form frm, bool OpenInDialog = false)
        {
            if (Session.User.CAN_GIVE_PERM == (byte)Master.UserType.Admin)
            {
           
            frm.Show();
            return;
            }
            var screen = Session.ScreensAccesses.SingleOrDefault(x => x.ScreenName == frm.Name);
            if (screen != null)
            {
                if (screen.CanOpen == true)
                {
                    if (OpenInDialog)
                        frm.ShowDialog();
                    else
                        frm.Show();
                    return;
                }
                else
                {
                    XtraMessageBox.Show(
           text: "غير مصرح لك ",
           caption: "",
           icon: MessageBoxIcon.Error,
           buttons: MessageBoxButtons.OK
           );
                    return;
                }

            }



        }

        private void Load_items()
        {
            accordionControl1.Elements.Clear();
            var screens = Session.ScreensAccesses.Where(X => X.CanShow == true || Session.User.CAN_GIVE_PERM == (byte)Master.UserType.Admin);
            screens.Where(s => s.ParentScreenID == 0).ToList().ForEach(s =>
            {
                AccordionControlElement elm = new AccordionControlElement()
                {
                    
                    Text =( Properties.Settings.Default.lungh =="0") ?  s.ScreenCaption : (s.ScreenCaption_E == null || s.ScreenCaption_E == "" ? s.ScreenCaption : s.ScreenCaption_E),
                    //  Text = s.ScreenCaption,
                    Tag = s.ScreenName,
                    Name = s.ScreenName,
                    Style = ElementStyle.Group

                };
                accordionControl1.Elements.Add(elm);
                AddAccordionElement(elm, s.ScreenID);
            });
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            accordionControl1.Elements.Clear();
            var screens = Session.ScreensAccesses.Where(X => X.CanShow == true || Session.User.CAN_GIVE_PERM == (byte)Master.UserType.Admin);
            screens.Where(s => s.ParentScreenID == 0).ToList().ForEach(s =>
               {
                   AccordionControlElement elm = new AccordionControlElement()
                   {
                       Text = (Properties.Settings.Default.lungh == "0") ? s.ScreenCaption : (s.ScreenCaption_E == null || s.ScreenCaption_E == "" ? s.ScreenCaption : s.ScreenCaption_E),

                       // Text = s.ScreenCaption,
                       Tag = s.ScreenName,
                       Name = s.ScreenName,
                       Style = ElementStyle.Group

                   };
                   accordionControl1.Elements.Add(elm);
                   AddAccordionElement(elm, s.ScreenID);
               });
        }

        void AddAccordionElement(AccordionControlElement parent ,int parentID)
        {
            var screens = Session.ScreensAccesses.Where(X => X.CanShow == true || Session.User.CAN_GIVE_PERM == (byte)Master.UserType.Admin);
            screens.Where(s => s.ParentScreenID == parentID).ToList().ForEach(s =>
            {
                AccordionControlElement elm = new AccordionControlElement()
                {
                    Text = (Properties.Settings.Default.lungh == "0") ? s.ScreenCaption : (s.ScreenCaption_E == null || s.ScreenCaption_E == "" ? s.ScreenCaption : s.ScreenCaption_E),

                 //   Text = s.ScreenCaption,
                    Tag = s.ScreenName,
                    Name = s.ScreenName,
                    Style = ElementStyle.Item

                };
                parent.Elements.Add(elm);
            });
            }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

            public static void lang(string lge)
        {
            System.Globalization.CultureInfo TypeOfLanguage = new System.Globalization.CultureInfo(lge);
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(TypeOfLanguage);
        }


       



        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<Form> formList = new List<Form>();
            foreach (Form openForm in (System.Collections.ReadOnlyCollectionBase)Application.OpenForms)
                formList.Add(openForm);
            foreach (Form form in formList)
            {
                if (form.Name != "frm_Main" && form.Name != "login_frm")
                    form.Close();
            }
            
            if (Properties.Settings.Default.lungh != "0")
            {
               
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
                    Properties.Settings.Default.lungh = "0";
                    lang("ar");
                
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                Properties.Settings.Default.lungh = "1";
                lang("en");
            }
            Properties.Settings.Default.Save();
            this.Controls.Clear();
            this.InitializeComponent();
            Load_items();
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;


        }

        private void btnChangeStore_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "frm_Main" && f.Name != "login_frm")
                    f.Close();
            }

           frm_Main.OpenForm(new PL.frm_ChoseStore(),true);

        }
    }
}
