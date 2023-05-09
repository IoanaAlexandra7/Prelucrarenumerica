using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ProiectPNI
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap.CopyToSquareCanvas(picPreview.Width);
                picPreview.Image = previewBitmap;

                ApplyFilter(true);
                ApplyFilter1(true);
                ApplyFilter2(true);
            }
        }

        private void btnSaveNewImage_Click(object sender, EventArgs e)
        {
            ApplyFilter(false);
            ApplyFilter1(false);
            ApplyFilter2(false);

            if (resultBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                    resultBitmap = null;
                }
            }
        }

        private void ApplyFilter(bool preview)
        {
            if (previewBitmap == null)
            {
                return;
            }

            if (preview == true)
            {
                picPreview.Image = previewBitmap.ColorBalance((byte)trcBlue.Value,
                                        (byte)trcGreen.Value, (byte)trcRed.Value);
            }
            else
            {
                resultBitmap = originalBitmap.ColorBalance((byte)trcBlue.Value, 
                                     (byte)trcGreen.Value, (byte)trcRed.Value);
            }
        }

        private void ApplyFilter1(bool preview)
        {
            if (previewBitmap == null)
            {
                return;
            }

            if (preview == true)
            {
                picPreview.Image = previewBitmap.Contrast((byte)trackBar1.Value);
            }
            else
            {
                resultBitmap = originalBitmap.Contrast((byte)trackBar1.Value);
            }
        }

        private void ApplyFilter2(bool preview)
        {
            if (previewBitmap == null)
            {
                return;
            }

            byte blue = (byte)trcBlue.Value;
            byte green = (byte)trcGreen.Value;
            byte red = (byte)trcRed.Value;

            if (preview == true)
            {
                picPreview.Image = previewBitmap.Solarise(blue, green, red);
            }
            else
            {
                resultBitmap = originalBitmap.Solarise(blue, green, red);
            }
        }

        private void ColourComponentValueChangedEventHandler(object sender, EventArgs e)
        {
            lblBlueValue.Text = trcBlue.Value.ToString();
            lblGreenValue.Text = trcGreen.Value.ToString();
            lblRedValue.Text = trcRed.Value.ToString();

            ApplyFilter(true);
        }

        private void pnlFilterControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_blur_Click(object sender, EventArgs e)
        {
            ExtBitmap.ConvertToBlur(previewBitmap);
            this.picPreview.Image = previewBitmap;
        }

        private void btn_sepia_Click(object sender, EventArgs e)
        {
            ExtBitmap.ConvertToSepia(previewBitmap);
            this.picPreview.Image = previewBitmap;
        }

        private void btn_negative_Click(object sender, EventArgs e)
        {
            ExtBitmap.ConvertToNegative(previewBitmap);
            this.picPreview.Image = previewBitmap;
        }

        private void GreyScale_Click(object sender, EventArgs e)
        {
            ExtBitmap.ConvertToGrayScale(previewBitmap);
            this.picPreview.Image = previewBitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblContrastValue.Text = 0.ToString();
            trackBar1.Value = 0;

            lblBlueValue.Text = 0.ToString();
            trcBlue.Value = 255;

            lblGreenValue.Text = 0.ToString();
            trcGreen.Value = 255;

            lblRedValue.Text = 0.ToString();
            trcRed.Value = 255;

            label1.Text = 0.ToString();
            trackBar2.Value = 0;

            label2.Text = 0.ToString();
            trackBar3.Value = 0;

            label3.Text = 0.ToString();
            trackBar4.Value = 0;

            this.picPreview.Image = originalBitmap;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblContrastValue.Text = trackBar1.Value.ToString();
            ApplyFilter1(true);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ColourSolariseComponentValueChangedEventHandler(object sender, EventArgs e)
        {

            label3.Text = trackBar4.Value.ToString();
            label2.Text = trackBar3.Value.ToString();
            label1.Text = trackBar2.Value.ToString();

            ApplyFilter2(true);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LblBlue_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void LblContrast_Click(object sender, EventArgs e)
        {

        }
    }
}
