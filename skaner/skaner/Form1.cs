using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using WIA;

namespace skaner {
    public partial class Form1 : Form {
        List<DeviceInfo> scanners = new List<DeviceInfo>();
        int resolution = 150;
        int sizeDivisor = 1;
        ImageFile image;
        int height = 1750;
        int width = 1250;
        int colorInt = 1; //1-kolor,czarnobialy
        String format = FormatID.wiaFormatJPEG;
        String roz = ".jpeg";



        public Form1() {
            InitializeComponent();
            var deviceManager = new DeviceManager();
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++) {
                if (deviceManager.DeviceInfos[i].Type == WiaDeviceType.ScannerDeviceType) {
                    scanners.Add(deviceManager.DeviceInfos[i]);
                    break;
                }
            }


            deviceName.Text = scanners[0].DeviceID;
            formatBox.Items.Add("JPEG");
            formatBox.Items.Add("PNG");
            formatBox.Items.Add("BMP");
            formatBox.Items.Add("TIFF");
            colorBox.Items.Add("Colors");
            colorBox.Items.Add("Greyscale");
            colorBox.Items.Add("Black/White");
            rotationBox.Items.Add("0");
            rotationBox.Items.Add("90");
            rotationBox.Items.Add("180");
            rotationBox.Items.Add("270");
            sizeBox.Items.Add("full");
            sizeBox.Items.Add("half");
            sizeBox.Items.Add("quarter");
            dpiBox.Items.Add("150");
            dpiBox.Items.Add("300");
            dpiBox.Items.Add("450");
            dpiBox.Items.Add("600");

            formatBox.SelectedIndex = 0;
            colorBox.SelectedIndex = 0;
            rotationBox.SelectedIndex = 0;
            sizeBox.SelectedIndex = 0;
            dpiBox.SelectedIndex = 0;
            
         
        }
        private static void SetWIAProperty(IProperties properties, object propName, object propValue) {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        void Rotate(string imagePath) {
            int deg = int.Parse(rotationBox.Text);
            Image img = Image.FromFile(imagePath);

            switch (deg) {
                case 90:
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 180:
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 270:
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                default:
                    return;
            }

            img.Save(imagePath);
            img.Dispose();
        }



        private static void scannerSettings(Item scannerItem,int resolution,int width,int height,int colorInt) {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";

            MessageBox.Show($"{width}, {height}");
            MessageBox.Show($"{resolution}");

            SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, resolution);
            SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, resolution);
            SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, 0);
            SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, 0);
            SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, width);
            SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, height);
            SetWIAProperty(scannerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, 0);
            SetWIAProperty(scannerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, 0);
            SetWIAProperty(scannerItem.Properties, WIA_SCAN_COLOR_MODE, colorInt);
        }

        private void button1_Click(object sender, EventArgs e) {
            int prevHeight = height;
            int prevWidth = width;
            var scannerItem = scanners[0].Connect().Items[1];
            if (sizeDivisor == 2)
            {
                height = height / 2;
            }
            if (sizeDivisor == 4)
            {
                height = height / 2;
                width = width / 2;
            }
            MessageBox.Show($"{width}, {height}");
            scannerSettings(scannerItem,resolution,width,height,colorInt);
            image = (ImageFile)scannerItem.Transfer(format);
            string path = @"C:\Users\lab\Desktop\scan"+roz;

            if (File.Exists(path)) {
                File.Delete(path);
            }

            image.SaveFile(path);
            Rotate(path);
            pictureBox1.ImageLocation = path;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            width = prevWidth;
            height = prevHeight;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void colorBox_SelectedIndexChanged(object sender, EventArgs e) {
            string mode = colorBox.Text;
            if (mode.Equals("Colors")) colorInt = 1;
            if (mode.Equals("Black/White")) colorInt = 4;
            if (mode.Equals("Greyscale")) colorInt = 2;
        }

        private void sizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sizeSelected = sizeBox.Text;
            if (sizeSelected.Equals("full")) sizeDivisor = 1;
            if (sizeSelected.Equals("half")) sizeDivisor = 2;
            if (sizeSelected.Equals("quarter")) sizeDivisor = 4;
        }

        private void formatBox_SelectedIndexChanged(object sender, EventArgs e) {
            string formatSelected = formatBox.Text;
            if (formatSelected.Equals("JPEG")) {
                format = FormatID.wiaFormatJPEG;
                roz = ".jpeg";
            }
            if (formatSelected.Equals("PNG")) {
                format = FormatID.wiaFormatPNG;
                roz = ".png";
            }
           
            if (formatSelected.Equals("BMP")) {
                format = FormatID.wiaFormatBMP;
                roz = ".bmp";
            }
           
            if (formatSelected.Equals("TIFF")) {
                format = FormatID.wiaFormatTIFF;
                roz = ".tiff";
            }
         
        }

        private void dpiBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dpiSelected = dpiBox.Text;
            int selectedToInt = int.Parse(dpiSelected);
            if (selectedToInt < 150 || selectedToInt > 600)
            {
                resolution = 150;
            } else
            {
                resolution = selectedToInt;
            }
            switch (selectedToInt)
            {
                case 150:
                    height = 1750;
                    width = 1250;
                    break;
                case 300:
                    height = 3501;
                    width = 2550;
                    break;
                case 450:
                    height = 5251;
                    width = 3825;
                    break;
                case 600:
                    height = 7002;
                    width = 5100;
                    break;
                default:
                    resolution = 150;
                    height = 1750;
                    width = 1250;
                    break;
            }
        }
    }
}
