

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

namespace Report_Pro.PL
{
    public partial class frm_ScanToPDF : Form
    {
        public frm_ScanToPDF()
        {
            InitializeComponent();
        }


        private void ListScanners()
        {
            // Clear the ListBox.
            listBox2.Items.Clear();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                listBox2.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value()) ;
            }
        }



        private void btn_DefaultScan_Click(object sender, EventArgs e)
        {

            //var FileName = TwainLib.TwainOperations.ScanImages(".png",true/* Conversion error: Set to default value for this argument */, Properties.Settings.Default.Scan);

            //foreach (var Itm in FileName)
            //    ListBox1.Items.Add(Itm);
            //  lbl_count.Text = ListBox1.Items.Count;


            CommonDialogClass dialog = new CommonDialogClass();
            Device scanner = dialog.ShowSelectDevice(WiaDeviceType.ScannerDeviceType);
            Item scannnerItem = scanner.Items[1];
            // TODO: Adjust scanner settings.

            //EZTwain.SelectTwainsource(0);

            Properties.Settings.Default.Scan = scanner.Items[1].ToString();

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
             Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
        

        }



        private void TriggerScan()
        {
            Console.WriteLine("Image succesfully scanned");
        }

        public void StartScanning()
        {
            Scanner device = null;

            Invoke(new MethodInvoker(delegate ()
            {
                device = listBox2.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("You need to select first an scanner device from the list",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Provide a filename",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImageFile image = new ImageFile();
            string imageExtension = "";

            Invoke(new MethodInvoker(delegate ()
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        image = device.ScanPNG();
                        imageExtension = ".png";
                        break;
                    case 1:
                        image = device.ScanJPEG();
                        imageExtension = ".jpeg";
                        break;
                    case 2:
                        image = device.ScanTIFF();
                        imageExtension = ".tiff";
                        break;
                }
            }));


            // Save the image
            var path = Path.Combine(textBox3.Text, textBox2.Text + imageExtension);

            if (File.Exists(path))
            {
                File.Delete(path);
            }

           // image.SaveFile(path);
            ListBox1.Items.Add(path);
            object pb = null;
            Pb.Image = new Bitmap(path);
        }


    }
}
