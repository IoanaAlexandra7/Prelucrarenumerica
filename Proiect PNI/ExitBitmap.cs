using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace ProiectPNI
{
    public static class ExtBitmap
    {
        public static Bitmap CopyToSquareCanvas(this Bitmap sourceBitmap, int canvasWidthLenght)
        {
            float ratio = 1.0f;
            int maxSide = sourceBitmap.Width > sourceBitmap.Height ?
                          sourceBitmap.Width : sourceBitmap.Height;

            ratio = (float)maxSide / (float)canvasWidthLenght;

            Bitmap bitmapResult = (sourceBitmap.Width > sourceBitmap.Height ?
                                    new Bitmap(canvasWidthLenght, (int)(sourceBitmap.Height / ratio))
                                    : new Bitmap((int)(sourceBitmap.Width / ratio), canvasWidthLenght));

            using (Graphics graphicsResult = Graphics.FromImage(bitmapResult))
            {
                graphicsResult.CompositingQuality = CompositingQuality.HighQuality;
                graphicsResult.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsResult.PixelOffsetMode = PixelOffsetMode.HighQuality;

                graphicsResult.DrawImage(sourceBitmap,
                                        new Rectangle(0, 0,
                                            bitmapResult.Width, bitmapResult.Height),
                                        new Rectangle(0, 0,
                                            sourceBitmap.Width, sourceBitmap.Height),
                                            GraphicsUnit.Pixel);
                graphicsResult.Flush();
            }

            return bitmapResult;
        }
        
        public static Bitmap ColorBalance(this Bitmap sourceBitmap, byte blueLevel, 
                                          byte greenLevel, byte redLevel)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, 
                                     sourceBitmap.Width, sourceBitmap.Height), 
                                     ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            float blue = 0;
            float green = 0;
            float red = 0;

            float blueLevelFloat = blueLevel;
            float greenLevelFloat = greenLevel;
            float redLevelFloat = redLevel;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                blue = 255.0f / blueLevelFloat * (float)pixelBuffer[k];
                green = 255.0f / greenLevelFloat * (float)pixelBuffer[k + 1];
                red = 255.0f / redLevelFloat * (float)pixelBuffer[k + 2];

                if (blue > 255) { blue = 255; }
                else if (blue < 0) { blue = 0; }

                if (green > 255) { green = 255; }
                else if (green < 0) { green = 0; }

                if (red > 255) {red = 255; }
                else if (red < 0) { red = 0; }
                
                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                     resultBitmap.Width, resultBitmap.Height), 
                                     ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static Bitmap Solarise(this Bitmap sourceBitmap, byte blueValue,
                                      byte greenValue, byte redValue)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                    sourceBitmap.Width, sourceBitmap.Height),
                                    ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            byte byte255 = 255;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                if (pixelBuffer[k] < blueValue)
                {
                    pixelBuffer[k] = (byte)(byte255 - pixelBuffer[k]);
                }

                if (pixelBuffer[k + 1] < greenValue)
                {
                    pixelBuffer[k + 1] = (byte)(byte255 - pixelBuffer[k + 1]);
                }

                if (pixelBuffer[k + 2] < redValue)
                {
                    pixelBuffer[k + 2] = (byte)(byte255 - pixelBuffer[k + 2]);
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                    resultBitmap.Width, resultBitmap.Height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static Bitmap Contrast(this Bitmap sourceBitmap, int threshold)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                        sourceBitmap.Width, sourceBitmap.Height),
                                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            double contrastLevel = Math.Pow((100.0 + threshold) / 100.0, 2);

            double blue = 0;
            double green = 0;
            double red = 0;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                blue = ((((pixelBuffer[k] / 255.0) - 0.5) *
                           contrastLevel) + 0.5) * 255.0;

                green = ((((pixelBuffer[k + 1] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0;

                red = ((((pixelBuffer[k + 2] / 255.0) - 0.5) *
                           contrastLevel) + 0.5) * 255.0;

                if (blue > 255)
                { blue = 255; }
                else if (blue < 0)
                { blue = 0; }

                if (green > 255)
                { green = 255; }
                else if (green < 0)
                { green = 0; }

                if (red > 255)
                { red = 255; }
                else if (red < 0)
                { red = 0; }

                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static bool ConvertToGray(Bitmap bit)
        {
            for (int i = 0; i < bit.Width; i++)
                for (int j = 0; j < bit.Height; j++)
                {
                    Color color1 = bit.GetPixel(i, j);
                    int red1 = color1.R;
                    int green1 = color1.G;
                    int blue1 = color1.B;
                    int gray = (byte)(.299 * red1 + .587 * green1 + .114 * blue1);
                    red1 = gray;
                    green1 = gray;
                    blue1 = gray;
                    bit.SetPixel(i, j, Color.FromArgb(red1, green1, blue1));
                }
            return true;

        }

        public static bool ConvertToNegative(Bitmap bit)
        {
            for (int i = 0; i < bit.Width; i++)
                for (int j = 0; j < bit.Height; j++)
                {
                    Color color1 = bit.GetPixel(i, j);
                    int a = color1.A;
                    int red1 = color1.R;
                    int green1 = color1.G;
                    int blue1 = color1.B;
                    red1 = 255 - red1;
                    green1 = 255 - green1;
                    blue1 = 255 - blue1;

                    bit.SetPixel(i, j, Color.FromArgb(a, red1, green1, blue1));
                }
            return true;
        }

        public static bool ConvertToSepia(Bitmap bit)
        {
            for (int i = 0; i < bit.Width; i++)
                for (int j = 0; j < bit.Height; j++)
                {
                    Color color1 = bit.GetPixel(i, j);
                    int a = color1.A;
                    int red1 = color1.R;
                    int green1 = color1.G;
                    int blue1 = color1.B;

                    int tr = (int)(0.393 * red1 + 0.769 * green1 + 0.189 * blue1);
                    int tg = (int)(0.349 * red1 + 0.686 * green1 + 0.168 * blue1);
                    int tb = (int)(0.272 * red1 + 0.534 * green1 + 0.131 * blue1);

                    if (tr > 255)
                    {
                        red1 = 255;
                    }
                    else
                    {
                        red1 = tr;
                    }

                    if (tg > 255)
                    {
                        green1 = 255;
                    }
                    else
                    {
                        green1 = tg;
                    }

                    if (tb > 255)
                    {
                        blue1 = 255;
                    }
                    else
                    {
                        blue1 = tb;
                    }

                    bit.SetPixel(i, j, Color.FromArgb(a, red1, green1, blue1));
                }
            return true;
        }

        public static bool ConvertToBlur(Bitmap bit)
        {
            for (int i = 2; i < bit.Width - 1; i++)
            {
                for (int j = 2; j < bit.Height - 1; j++)
                {
                    Color previousI = bit.GetPixel(i - 2, j);
                    Color previousJ = bit.GetPixel(i, j - 2);
                    Color nextI = bit.GetPixel(i + 1, j);
                    Color nextJ = bit.GetPixel(i, j + 1);

                    int red1 = (int)((previousI.R + nextI.R + previousJ.R + nextJ.R) / 4);
                    int green1 = (int)((previousI.G + nextI.G + previousJ.G + nextJ.G) / 4);
                    int blue1 = (int)((previousI.B + nextI.B + previousJ.B + nextJ.B) / 4);

                    bit.SetPixel(i, j, Color.FromArgb(red1, green1, blue1));
                }
            }
            return true;
        }

        public static bool RedGreenBlue(Bitmap bit, int nr)
        {
            Bitmap rbmp = new Bitmap(bit);
            Bitmap gbmp = new Bitmap(bit);
            Bitmap bbmp = new Bitmap(bit);

            for (int i = 0; i < bit.Height; i++)
            {
                for (int j = 0; j < bit.Width; j++)
                {
                    Color p = bit.GetPixel(j, i);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    rbmp.SetPixel(j, i, Color.FromArgb(a, r, 0, 0));
                    gbmp.SetPixel(j, i, Color.FromArgb(a, 0, g, 0));
                    bbmp.SetPixel(j, i, Color.FromArgb(a, 0, 0, b));
                }
            }

            switch (nr)
            {
                case 1:
                    bit = rbmp;
                    break;
                case 2:
                    bit = gbmp;
                    break;
                case 3:
                    bit = bbmp;
                    break;
            }
            return true;
        }

        public static bool ConvertToGrayScale(Bitmap bit)
        {
            for (int i = 0; i < bit.Width; i++)
                for (int j = 0; j < bit.Height; j++)
                {
                    Color color1 = bit.GetPixel(i, j);
                    int a = color1.A;
                    int r = color1.R;
                    int g = color1.G;
                    int b = color1.G;
                    int avg = (r + g + b) / 3;
                    bit.SetPixel(i, j, Color.FromArgb(a, avg, avg, avg));
                }
            return true;

        }

       
    }
}
