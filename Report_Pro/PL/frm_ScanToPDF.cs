

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using System.Windows.Interop;
using System.Runtime.ExceptionServices;
using ALquhaliLibrary;

using System.Drawing.Imaging;
using System.Drawing.Drawing2D;


namespace Report_Pro.PL
{
    public partial class frm_ScanToPDF : Form
    {
        AlquhaliClass cls = new AlquhaliClass();
        private Image MyPic;

        int cropX, cropY, cropWidth, cropHeight;
        //here rectangle border pen color=red and size=2;
        Pen borderpen = new Pen(Color.Red, 2);
        Image _orgImage;
        Bitmap crop;
        List<string> devices;
        //fill the rectangle color =white
        SolidBrush rectbrush = new SolidBrush(Color.FromArgb(100, Color.White));
        int pages;
        int currentPage = 0;



        public frm_ScanToPDF()
        {
            InitializeComponent();
            IsSaved = false;
        }
        List<Image> images;
        private string f_path;
        private string doc_no;
        private bool savedOrNot = false;
        private List<string> fNames;
        public List<string> fileNames
        {
            get { return fNames; }
            set { fNames = value; }
        }
        public String SavePath
        {
            get { return f_path; }
            set { f_path = value; }
        }
        public String DocNo
        {
            get { return doc_no; }
            set { doc_no = value; }
        }
        public bool IsSaved
        {
            get { return savedOrNot; }
            set { savedOrNot = value; }
        }


        private void ListScanners()
        {
            //var deviceManager = new DeviceManager();
            //for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            //{
            //    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
            //    {
            //        continue;
            //    }
            //  //  cmb_Scanars.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());
            //    lbDevices.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());

            //}

            devices = WAIScanner.GetDevices();

            foreach (string device in devices)
            {
                lbDevices.Items.Add(device);
            }
            //check if device is not available
            if (lbDevices.Items.Count != 0)
            {
                lbDevices.SelectedIndex = 0;

            }


        }



        private void btn_DefaultScan_Click(object sender, EventArgs e)
        {



            Properties.Settings.Default.Scan = lbDevices.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void frm_ScanToPDF_Load(object sender, EventArgs e)
        {
            ListScanners();

            // Set start output folder TMP
            textBox3.Text = Path.GetTempPath();
            // Set JPEG as default
            comboBox2.SelectedIndex = 1;
        }

        private void btn_Scan_Click(object sender, EventArgs e)
        {
            //get list of devices available
            try { 
            if (lbDevices.Items.Count == 0)
            {
                MessageBox.Show("You do not have any WIA devices.");

            }
            else
            {
                //get images from scanner
                pages = 3;
                images = WAIScanner.Scan((string)lbDevices.SelectedItem, pages);
                pages = images.Count;
                if (images != null)
                {
                    foreach (Image image in images)
                    {
                            Pb.Visible = true;
                        Pb.Image = images[0];
                      //      Pb.Show();
                      //      Pb.SizeMode = PictureBoxSizeMode.StretchImage;
                      //  _orgImage = images[0];
                      //  crop = new Bitmap(images[0]);
                      ////  btnOriginal.Enabled = true;
                      //  //btnSave.Enabled = true;
                      //  currentPage = 0;
                      }
                }
            }


        }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }







//Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
        

        }



        private void TriggerScan()
        {
            Console.WriteLine("Image succesfully scanned");
        }

        public void StartScanning()
        {
           // Scanner device = null;

           // Invoke(new MethodInvoker(delegate ()
           // {
           //     device = (Scanner) lbDevices.SelectedItem;
             
           //   //  MessageBox.Show(device.ToString());
           // }));

           // if (device == null)
           // {
           //     MessageBox.Show("You need to select first an scanner device from the list",
           //                     "Warning",
           //                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
           //     return;
           // }
           // else if (String.IsNullOrEmpty(textBox2.Text))
           // {
           //     MessageBox.Show("Provide a filename",
           //                     "Warning",
           //                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
           //     return;
           // }

           // ImageFile image = new ImageFile();
           // string imageExtension = "";

           // Invoke(new MethodInvoker(delegate ()
           // {
           //     switch (comboBox2.SelectedIndex)
           //     {
           //         case 0:
           //             image = device.ScanPNG();
           //             imageExtension = ".png";
           //             break;
           //         case 1:
           //             image = device.ScanJPEG();
           //             imageExtension = ".jpeg";
           //             break;
           //         case 2:
           //             image = device.ScanTIFF();
           //             imageExtension = ".tiff";
           //             break;
           //     }
           // }));


           // // Save the image
           // var path = Path.Combine(textBox3.Text, textBox2.Text + imageExtension);

           // if (File.Exists(path))
           // {
           //     File.Delete(path);
           // }

           //// image.SaveFile(path);
           // ListBox1.Items.Add(path);
           // object pb = null;
           // Pb.Image = new Bitmap(path);
        }

        private void btn_CreatPDF_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (TextBox1.Text != null/* TODO Change to default(_) if this is not a reference type */ )
                    // save 2 PDF
                    cls.Save_Multiple_Images_2PDF(ListBox1, TextBox1.Text.Trim());
                else
                {
                    MessageBox.Show("من فضلك ادخل اسم لملف المراد انشاؤه ", "Notification Message");
                    TextBox1.Focus();
                }
            //}
            //catch (Exception ex)
            //{
            //}

        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
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
                        ListBox1.Items.Add(p.ToString());

                        //row.CreateCells(dgv2, p.ToString(), Path.GetFileNameWithoutExtension(p), Path.GetExtension(p), p_id);
                        //dgv2.Rows.Add(row);
                        //tabControl1.SelectedTab = tabItem3;
                      //  pdf_v.src = p;

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

                    //lbl_count.Text = ListBox1.Items.Count;
                    //    Label5.Text = null;
                }    // Count Items
                
            }
            catch (Exception ex)
            {
               
            }
        }

        private void ListBox1_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (ListBox1.Items.Count != 0)
                {
                     string[] tab = ListBox1.SelectedItem.ToString().Split('.');
                    if (tab[1].ToLower() != "pdf")
                    {
                    pdf_v.Visible = false;
                    Pb.Visible = true;
                        Bitmap bt = new Bitmap(ListBox1.SelectedItem.ToString());
                        Pb.Image = bt;
                        MyPic = Pb.Image;
                    }
                    else
                    {
                    Pb.Visible = false;
                    pdf_v.Visible = true;
                    pdf_v.src = ListBox1.SelectedItem.ToString();
                        label5.Text = ListBox1.SelectedItem.ToString();
                        label5.Text = ListBox1.SelectedItem.ToString();
                    }
                }
            //}
            //catch (Exception ex)
            //{
                
            //}
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ListBox1.Items.Count != 0)
                {
                    string[] tab = ListBox1.SelectedItem.ToString().Split('.');
                    if (tab[1].ToLower() != "pdf")
                    {
                        pdf_v.Visible = false;
                        Pb.Visible = true;
                        Bitmap bt = new Bitmap(ListBox1.SelectedItem.ToString());
                        Pb.Image = bt;
                        MyPic = Pb.Image;
                    }
                    else
                    {
                        Pb.Visible = false;
                        pdf_v.Visible = true;
                        pdf_v.src = ListBox1.SelectedItem.ToString();
                        label5.Text = ListBox1.SelectedItem.ToString();
                        label5.Text = ListBox1.SelectedItem.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete1_Click(object sender, EventArgs e)
        {
            if (ListBox1.Items.Count != 0)
            {
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
                // Count Items
               // lbl_count.Text = ListBox1.Items.Count;
                label5.Text = null;
                Pb.Image = null;
                pdf_v.src = null;
            }
        }
    }
}
