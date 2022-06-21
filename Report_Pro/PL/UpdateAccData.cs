using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class UpdateAccData : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt_;
        public UpdateAccData()
        {
            InitializeComponent();
        }

        private void UpdateAccData_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try

            {
            //    if (txt_VatNo.Text.Replace(" ", "").Length < 15 && txt_VatNo.Text.Trim() != string.Empty)
            //    {
            //        MessageBox.Show("تأكد من الرقم الضريبي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txt_VatNo.Focus();
            //        return;

            //    }
                string facility_;
                if (ch_facility.Checked == true)
                {
                    facility_ = "YES";
                }
                else
                {
                    facility_ = "NO";
                }

                dal.Execute_1("update payer2 set PAYER_NAME='" + Desc.Text + "',payer_l_name='" + Desc_L.Text + "', adress='" + adress.Text + "' , COSTMER_K_M_NO='" + txt_VatNo.Text + "',notes='" + facility_ + "' ,E_MAIL='" + txtEmail.Text + "',phone_no='" + txtTel.Text + "',resp_name='"+txtResponsaple.Text+"' where acc_no= '" + UC_Acc.ID.Text + "'");
                dal.Execute_1("update wh_inv_data set adress='" + adress.Text + "', COSTMER_K_M_NO='" + txt_VatNo.Text + "' where acc_no= '" + UC_Acc.ID.Text + "'");
                MessageBox.Show("تمت عملية التعديل بنجاح", "تأكيد التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch  (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

      
        private void update_Acc1_Load(object sender, EventArgs e)
        {

        }

       
        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select PAYER_NAME,payer_l_name,adress,COSTMER_K_M_NO,notes,E_Mail,phone_no,resp_name from payer2 where ACC_NO= '" + UC_Acc.ID.Text + "'   ");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0][0].ToString();
                    Desc_L.Text = dt_.Rows[0][1].ToString();
                    adress.Text = dt_.Rows[0][2].ToString();
                    txtEmail.Text = dt_.Rows[0]["E_MAIL"].ToString();
                    txt_VatNo.Text = dt_.Rows[0]["COSTMER_K_M_NO"].ToString();
                     txtTel.Text = dt_.Rows[0]["phone_no"].ToString();
                     txtResponsaple.Text = dt_.Rows[0]["resp_name"].ToString();
                     adress.Text = dt_.Rows[0]["adress"].ToString();

                //if (Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ').Length > 1)
                //{
                //    txt_Building.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[1];
                //}
                //else if (Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ').Length > 3)
                //{
                //    txt_Building.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[1];
                //    txt_Road.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[3];
                //}
                //else if (Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ').Length > 5)
                //{
                //    txt_Building.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[1];
                //    txt_Road.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[3];
                //    txt_Block.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[5];
                //}
                //    else if (Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ').Length  > 7)
                //    {
                //    txt_Building.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[1];
                //    txt_Road.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[3];
                //    txt_Block.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[5];
                //    txt_Area.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[6] + " " + Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[7];
                //    }
                //    else if (Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ').Length == 7)
                //{
                //    txt_Building.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[1];
                //    txt_Road.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[3];
                //    txt_Block.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[5];
                //    txt_Area.Text = Regex.Replace(dt_.Rows[0][2].ToString(), " {2,}", " ").Split(' ')[6]; }

                    
                    if (dt_.Rows[0][4].ToString().ToUpper() == "YES")
                    {
                        ch_facility.Checked = true;
                    }
                    else
                    {
                        {
                            ch_facility.Checked = false;
                        }
                    }

                  

                   
                }
                else
                {

                    Desc.Clear();
                    adress.Clear();
                    Desc_L.Clear();
                    txt_VatNo.Clear();
                    txt_Building.Clear();
                    txt_Road.Clear();
                    txt_Block.Clear();
                    txt_Area.Clear();
                    txtEmail.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     



       


        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
        }

        private void UC_Acc_Load(object sender, EventArgs e)
        {
            get_desc();
        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            txt_Building.Text = adress.Text.Split(' ')[1];
            txt_Road.Text = adress.Text.Split(' ')[3];
            txt_Block.Text = adress.Text.Split(' ')[5];
            txt_Area.Text = adress.Text.Split(' ')[6];
        }


        private void setAddress()
        {
            string Building = "";
            string Road = "";
            string Block = "";
            

            if (txt_Building.Text.Trim() != string.Empty)
            {
                Building = lbl_Building.Text + " " + txt_Building.Text + " ";
            }
            else
            {
                Building = "";
            }

            if (txt_Road.Text.Trim() != string.Empty)
            {
                Road = lbl_Road.Text + " " + txt_Road.Text + " ";
            }
            else
            {
                Road = "";
            }

            if (txt_Block.Text != string.Empty || txt_Area.Text != string.Empty)
            {
                Block = lbl_Block.Text + " " + txt_Block.Text + " " + txt_Area.Text;
            }
            else Block = "";

            adress.Text = Building + Road + Block;
                //lbl_Building.Text + " " + txt_Building.Text + " " + lbl_Road.Text + " " + txt_Road.Text + " " + lbl_Block.Text + " " + txt_Block.Text + " " + txt_Area.Text;

        }

        private void txt_Building_KeyUp(object sender, KeyEventArgs e)
        {
            setAddress();
        }

        private void txt_Road_KeyUp(object sender, KeyEventArgs e)
        {
            setAddress();
            //adress.Text = lbl_Building.Text + " " + txt_Building.Text + " " + lbl_Road.Text + " " + txt_Road.Text + " " + lbl_Block.Text + " " + txt_Block.Text + " " + txt_Area.Text;
        }

        private void txt_Block_KeyUp(object sender, KeyEventArgs e)
        {
            setAddress();
            //adress.Text = lbl_Building.Text + " " + txt_Building.Text + " " + lbl_Road.Text + " " + txt_Road.Text + " " + lbl_Block.Text + " " + txt_Block.Text + " " + txt_Area.Text;
        }

        private void txt_Area_KeyUp(object sender, KeyEventArgs e)
        {
            setAddress();
            //adress.Text = lbl_Building.Text + " " + txt_Building.Text + " " + lbl_Road.Text + " " + txt_Road.Text + " " + lbl_Block.Text + " " + txt_Block.Text + " " + txt_Area.Text;
        }

        private void txt_Road_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }


}
