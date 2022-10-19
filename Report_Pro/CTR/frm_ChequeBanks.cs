using DevExpress.XtraEditors;
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
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DAL.SHEEK_BANKS_TYPE _bank;

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
            using (var db = new DAL.dbDataContext())
            {
                _bank = db.SHEEK_BANKS_TYPEs.Single(x => x.BANK_NO == id);
                GetData();
                IsNew = false;
            }
        }

        public override void New()
        {
            _bank = new DAL.SHEEK_BANKS_TYPE();
            
            base.New();
            using (var db = new DAL.dbDataContext())
            {
                var maxValue = Convert.ToInt32(db.SHEEK_BANKS_TYPEs.Max(x => x.BANK_NO)) + 1;
                txt_ID.Text = maxValue.ToString("00");

            }
        }
        public override void GetData()
        {
            txt_ID.Text = _bank.BANK_NO;
            txt_Name.Text = _bank.BANK_NAME;
            txt_Name_E.Text = _bank.BANK_NAME_E;

            base.GetData();
        }
        public override void Save()
        {

            if (txt_ID.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show(
        text: "You Must Enter Bank Code -- يجب ادخال رقم البنك ",
        caption: "Error -- خطأ",
        icon: MessageBoxIcon.Error,
        buttons: MessageBoxButtons.OK);
                return;
            }

            if (txt_Name.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show(
        text: "You Must Enter Bank Name -- يجب ادخال اسم البنك ",
        caption: "Error -- خطأ",
        icon: MessageBoxIcon.Error,
        buttons: MessageBoxButtons.OK);
                return;
            }

            var db = new DAL.dbDataContext();
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
            getData();

            base.RefreshData();
        }

        private void frm_ChequeBanks_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {

            DataTable dtBanks = dal.getDataTabl_1(@"select BANK_NO,BANK_NAME,BANK_NAME_E from SHEEK_BANKS_TYPE");

            if (dtBanks.Rows.Count > 0)
            {
                int B_rowscount = dtBanks.Rows.Count;

                dgv1.Rows.Clear();
                dgv1.Rows.Add(B_rowscount);
                for (int i = 0; i <= (B_rowscount - 1); i++)
                {


                    dgv1.Rows[i].Cells[0].Value = dtBanks.Rows[i]["BANK_NO"];
                    dgv1.Rows[i].Cells[1].Value = dtBanks.Rows[i]["BANK_NAME"];
                    dgv1.Rows[i].Cells[2].Value = dtBanks.Rows[i]["BANK_NAME_E"];

                }
            }
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadChequeBanke(dgv1.CurrentRow.Cells[0].Value.ToString());
            
        }

    }
}
