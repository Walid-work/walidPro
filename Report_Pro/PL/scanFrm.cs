using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;
using WIA;
using System.Runtime.InteropServices;
using System.IO;

namespace Report_Pro.PL
{
    public partial class scanFrm : Form
    {
        public scanFrm()
        {
            InitializeComponent();
        }

        private void scanFrm_Load(object sender, EventArgs e)
        {
            DeviceManager dManager = new DeviceManager();
            for (int i = 1; i <= dManager.DeviceInfos.Count; i++)
            {
                //if ((dManager.DeviceInfos[i]).Type = WiaDeviceType.ScannerDeviceType)
                //{
                //    continue;
                //}
                comboListOfScanners.Items.Add(dManager.DeviceInfos[i].Properties["Name"].get_Value());
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            //DeviceManager deviceManager = new DeviceManager();
            //DeviceInfo AvailableScanner = null;

            //for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            //{
            //    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
            //    {
            //        continue;
            //    }
            //    AvailableScanner = deviceManager.DeviceInfos[i];
            //    break;
            //}
            //var device = AvailableScanner.Connect();
            //var ScanerItem = device.Items[1];
            //var imgFile = (ImageFile)ScanerItem.Transfer();
            //var path = @"D:\scan.JPEG";
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}
            //imgFile.SaveFile(path);
            //pictureBox1.ImageLocation = path;
        }
    }
}
