using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Globalization;
using System.Data;

using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


using Microsoft.VisualBasic;
using TwainLib;
using WIA;
using System.Runtime.InteropServices;
using EZTwainLibrary;

namespace Report_Pro.PL
{
    public partial class Frm_uploadImage : Form
    {


        OpenFileDialog OFD = new OpenFileDialog();
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        SqlConnection connection = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Properties.Settings.Default.Database + " ;integrated security=false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + "");
        public string p_id;
        public Frm_uploadImage()
        {
            InitializeComponent();
        }



        void resaizeDG()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
          

        }



        void allfiles()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT id,FilePath,FileName,FileType,DeviceID FROM " + dal.db1 + ".dbo.FileTbl where  DeviceID='" + p_id + "'");
                dataGridView1.DataSource = dt_;
            }
            catch { }
        }

       


        byte[] ReadFile(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            br.Close();
            fStream.Close();
            return data;
        }




        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabItem1;
            allfiles();
            resaizeDG();
        }

        private void Frm_uploadImage_Load(object sender, EventArgs e)
        {
            allfiles();
            resaizeDG();
        }







        private void buttonX1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_chosescaner_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_deletAtt_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_showAtt_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT FileData,FileType FROM FileTbl where  ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'");


                byte[] buffer = (byte[])dt_.Rows[0][0];
                string fpath = Application.StartupPath + "\\test" + dt_.Rows[0][1];

                FileStream fs = new FileStream(fpath, FileMode.Create);
                fs.Write(buffer, 0, buffer.Length);
                fs.Close();
                System.Diagnostics.Process.Start(fpath);

               
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

      

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv2.Rows.Count; i++)
            {
                if (dgv2.Rows[i].Cells[0].Value != null)
                {

                    SqlCommand cmd = new SqlCommand("insert into " + dal.db1 + ".dbo.filetbl(FilePath,filename,filetype,DeviceID,FileData)values(@fd,@fn,@ft,@po,@cp)", connection);
                    cmd.Parameters.AddWithValue("@fd", dgv2.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@fn", dgv2.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@ft", dgv2.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@po", dgv2.Rows[i].Cells[3].Value);
                    byte[] fileData = ReadFile(dgv2.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@cp", fileData);

                    //cmd.Parameters.AddWithValue("@fd", txtFilePath.Text);
                    //cmd.Parameters.AddWithValue("@fn", txtFileName.Text);
                    //cmd.Parameters.AddWithValue("@ft", txtFileType.Text);
                    //cmd.Parameters.AddWithValue("@po", txtDeviceID.Text);
                    //byte[] fileData = ReadFile(txtFilePath.Text);
                    //cmd.Parameters.AddWithValue("@cp", fileData);

                    connection.Open();

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
          //  MessageBox.Show("تم حفظ اابيات بنجاح");
            MessageBox.Show(dal.rm.GetString("msgSave", dal.cul), dal.rm.GetString("msgSave_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgv2.Rows.Clear();
            button3_Click(sender, e);

        }

        private void BNew_Click(object sender, EventArgs e)
        {

            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.Filter = "All Files|*.*|pdf|*.pdf|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            opnFile.FilterIndex = 2;
            opnFile.Multiselect = true;
            if (opnFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string p in opnFile.FileNames)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgv2, p.ToString(), Path.GetFileNameWithoutExtension(p), Path.GetExtension(p), p_id);
                    dgv2.Rows.Add(row);
                    tabControl1.SelectedTab = tabItem3;
                }
                    // ListViewItem itm = new ListViewItem(p);
                    // itm.SubItems.Add(Path.GetFileNameWithoutExtension(p));
                    // itm.SubItems.Add(Path.GetExtension(p));
                    // itm.SubItems.Add(p_id);
                    //// itm.SubItems.Add(Properties.Settings.Default.CoId);
                    // listView1.Items.Add(itm);


                    //txtFilePath.Text = opnFile.FileName;
                    //txtFileName.Text= Path.GetFileNameWithoutExtension(p);
                    //txtFileType.Text=Path.GetExtension(p);
                    //txtDeviceID.Text =p_id;
                
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFromScan_Click(object sender, EventArgs e)
        {
            PL.scanFrm frm = new PL.scanFrm();
            frm.ShowDialog();

            if (System.IO.File.Exists(Application.StartupPath + "\\MyImage.Bmp") == true)
            {
                System.IO.File.Delete(Application.StartupPath + "\\MyImage.Bmp");// في حال وجودها سيتم حذفها حتى يتمكن من حفظ الصورة الجديده
            }

           EZTwain.AcquireToFileName(0, Application.StartupPath + "\\MyImage.Bmp"); // يقوم باستخراج الصورة من الماسح الضوئي وحفظها في الهاردسك
            OFD.FileName = Application.StartupPath + "\\MyImage.Bmp"; // لجلب موقع الصوره ووضعها في متغير
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv2, OFD.FileName.ToString(), Path.GetFileNameWithoutExtension(OFD.FileName), Path.GetExtension(OFD.FileName), p_id);
            dgv2.Rows.Add(row);
            tabControl1.SelectedTab = tabItem3;
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

             EZTwain.SelectTwainsource(0);
        }

        private void btnEdle_Click(object sender, EventArgs e)
        {

           // if (MessageBox.Show("هل تريد فعلا حذف المرفق المحدد", "تحذير !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                if (MessageBox.Show(dal.rm.GetString("msgConfirmDelete", dal.cul), dal.rm.GetString("msgConfirmDelete_H!", dal.cul), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)

                {
                    SqlCommand cmd = new SqlCommand("delete from " + dal.db1 + ".dbo.filetbl where ID='" + dataGridView1.CurrentRow.Cells[0].Value + "' ", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
               // MessageBox.Show("تم حذف المرفق ", "رسالة تاكيد !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(dal.rm.GetString("msgDelete", dal.cul), dal.rm.GetString("msgDelete_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);


                button3_Click(sender, e);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                DataTable dt_ = dal.getDataTabl_1("SELECT FileData,FileType FROM FileTbl where  ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'");


                byte[] buffer = (byte[])dt_.Rows[0][0];
                string fpath = Application.StartupPath + "\\test" + dt_.Rows[0][1];

                FileStream fs = new FileStream(fpath, FileMode.Create);
                fs.Write(buffer, 0, buffer.Length);
                fs.Close();

                //axAcroPDF1.src = fpath;
                System.Diagnostics.Process.Start(fpath);



            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
    }
}
