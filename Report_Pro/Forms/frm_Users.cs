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
using static Report_Pro.Classes.Master;

namespace Report_Pro.Forms
{
    public partial class frm_Users : frm_Master
    {
      //  DAL.UserAccessProfile _userAccessProfile ;
        DAL.wh_USER _user;

        public frm_Users()
        {
            InitializeComponent();
            New();
            RefreshData();
        }

        public frm_Users(string id)
        {
            InitializeComponent();
            RefreshData();
            LoadUser(id);
            IsNew = false; 
        }

        private void frm_Users_Load(object sender, EventArgs e)
        { // New();
                  }

        public override void New()
        {
        
            _user=new DAL.wh_USER();

            base.New();
        }
        public override void RefreshData()
        {

            using (var db = new DAL.dbDataContext())
            {
                cmb_type.DataSource = db.UserAccessProfiles.ToList();
                cmb_type.ValueMember = "id";
                cmb_type.DisplayMember = "Name";

               // _branch.IntializeData(db.wh_BRANCHes.Select(p => new { p.Branch_code, p.branch_name }), "branch_name", "Branch_code");


                cmb_Languh.DataSource = LanguhList.ToList();
                if (_Languh == "0")
                {
                    _branch.IntializeData(db.wh_BRANCHes.Select(p => new { p.Branch_code, p.branch_name }), "branch_name", "Branch_code");
                     cmb_Languh.DisplayMember = "Name";
                }
                else
                {
                    _branch.IntializeData(db.wh_BRANCHes.Select(p => new { p.Branch_code, branch_name = p.WH_E_NAME ==null ? p.branch_name :p.WH_E_NAME }), "branch_name", "Branch_code");
                    cmb_Languh.DisplayMember = "EName";
                }
                cmb_Languh.ValueMember = "ID";



            }


            base.RefreshData();
        }
       
        public override void Save()
        {

            var db = new DAL.dbDataContext();

            if (txt_id_.Text.Trim() == string.Empty)
            {
                txt_id_.ErrorText = "برجاء ادخال اسم المستخدم";
                return;
            }
            if (txt_name.Text.Trim() == string.Empty)
            {
                txt_name.ErrorText = "برجاء ادخال الاسم ";
                return;
            }
            if (txt_pass.Text.Trim() == string.Empty)
            {
                txt_pass.ErrorText = "برجاء ادخال كلمة المرور";
                return;
            }
            if (txt_pass2.Text.Trim() != txt_pass.Text.Trim())
            {
                txt_pass2.ErrorText = "برجاء التاكد من مطابقة كلمة المرور";
                return;
            }

            //if (ValidateData() == false)
            //    return;
            //var db = new DAL.dbDataContext();
            if (_user.USER_ID==null)
            {
                db.wh_USERs.InsertOnSubmit(_user);
            }
            else
            {
                db.wh_USERs.Attach(_user);
            }
            SetData();
            db.SubmitChanges();
           

            base.Save();
        }
        public override void Delete()
        {
            base.Delete();
        }

        public override void SetData()
        {
            _user.USER_ID = txt_id_.Text;
            _user.USER_NAME = txt_name.Text;
        //         _user.User_Level = "1";
       //     _user.Branches_category = "G";
            _user.LANG = Convert.ToString(cmb_Languh.SelectedValue);
            _user.USER_DEP = "";
            _user.PASSWORD = txt_pass.Text;
            _user.user_off = "0";
            _user.AREA_CODE = Convert.ToString(_branch.EditValue);
            _user.Title = "";
            _user.Perm_code =Convert.ToInt32(cmb_type.SelectedValue);

            base.SetData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new DAL.dbDataContext();
            _user = db.wh_USERs.Where(s => s.USER_ID == txt_id_.Text).First();
            GetData();
        }

        public override void GetData()
        {
            txt_id_.Text = _user.USER_ID;
            txt_name.Text = _user.USER_NAME;
            txt_pass.Text = _user.PASSWORD;
            txt_pass2.Text = _user.PASSWORD;
            cmb_type.SelectedValue = _user.Perm_code.ToString();
            _branch.EditValue = _user.AREA_CODE;
            cmb_Languh.SelectedValue = _user.LANG;


            base.GetData();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {

        }



        void LoadUser(string id)
        {
            using (var db = new DAL.dbDataContext())
            {
                _user = db.wh_USERs.Single(x => x.USER_ID == id);
                GetData();
            }
        }

        private void _branch_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
