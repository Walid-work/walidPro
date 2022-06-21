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
namespace Report_Pro.CTR
{
    public partial class frm_ChequeBanks : frm_Master
    {
        DAL.SHEEK_BANKS_TYPE  _bank ;
        public frm_ChequeBanks()
        {
            InitializeComponent();
            New();
            RefreshData();
        }
        public frm_ChequeBanks(string id)
        {
            InitializeComponent();
            RefreshData();
            LoadChequeBanke(id);
            IsNew = false;
        }
        void LoadChequeBanke(string id)
        {
            using (var db =new DAL.dbDataContext ())
            {
                _bank = db.SHEEK_BANKS_TYPEs.Single(x => x.BANK_NO == id);
                GetData();
            }
        }

        public override void New()
        {
            _bank = new DAL.SHEEK_BANKS_TYPE();
            base.New();
        }
        public override void GetData()
        {
            txt_ID.Text = _bank.BANK_NO;
            txt_Name .Text = _bank.BANK_NAME;
            txt_Name_E.Text = _bank.BANK_NAME_E;

            base.GetData();
        }
        public override void Save()
        {
            if (txt_Name.Text.Trim() == string.Empty)
            {
                txt_Name.ErrorText = "برجاء ادخال اسم البنك";
                return;
            }
            var db = new DAL.dbDataContext();

          //  _bank = db.SHEEK_BANKS_TYPEs.Single(x => x.BANK_NO == txt_ID.Text);
            if (_bank.BANK_NO == null)
            {
                
                db.SHEEK_BANKS_TYPEs.InsertOnSubmit(_bank);
                          }
            else
            {
                db.SHEEK_BANKS_TYPEs.Attach(_bank);
               
            }
           
            SetData();
            db.SubmitChanges();


            base.Save();    
        }

        public override void SetData()
        {
            _bank.BANK_NO = txt_ID.Text;
            _bank.BANK_NAME = txt_Name.Text;
            _bank.BANK_NAME_E = txt_Name_E.Text;
            base.SetData();
        }

        public override void RefreshData()
        {
           
            base.RefreshData();
        }
        //public override void Save()
        //{
        //    if (textEdit1.Text.Trim() == string.Empty)
        //    {
        //        textEdit1.ErrorText = "برجاء ادخال اسم الخزنه";
        //        return;
        //    }
        //    var db = new DAL.dbDataContext();
        //    DAL.Account account = new DAL.Account() ;
        //    if (drawer.ID == 0)
        //    {
        //        db.Accounts.InsertOnSubmit(account);
        //        db.Drawers.InsertOnSubmit(drawer);
        //    }
        //    else
        //    {
        //        account = db.Accounts.Single(x => x.ID == drawer.AcoountID);
        //        
        //        db.Drawers.Attach(drawer);

        //    }
        //    SetData();
        //    account.Name = textEdit1.Text;
        //    db.SubmitChanges();

        //    drawer.AcoountID = account.ID;

        //    base.Save();
        //}
        //public override void New()
        //{
        //    drawer = new DAL.Drawer();
        //     base.New();
        //}
    }
}
