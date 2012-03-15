using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using System.Drawing.Imaging;

namespace ThoughtWorks.QRCode.Codec.Data
{
    public class QRCodeBitmapImage : QRCodeImage
    {
         Bitmap image;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="image">Bitmap image/param>
        public QRCodeBitmapImage(Bitmap image)
        {
            this.image = image;
        }

        virtual public int Width
        {
            get
            {
                return image.Width;
            }

        }
        virtual public int Height
        {
            get
            {
                return image.Height;
            }

        }
     

        public virtual int getPixel(int x, int y)
        {
            return image.GetPixel(x, y).ToArgb();
        }

        public struct PixelData
        {
            public byte blue;
            public byte green;
            public byte red;
        }

        public int[][] GetPixels()
        {
            int width = image.Width;
            int height = image.Height;
            int[][] intImage = new int[width][];
            for (int i = 0; i < width; i++)
            {
                intImage[i] = new int[height];
            }
            unsafe
            {
                BitmapData bd = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format24bppRgb);
                int sourceWidth = image.Width * System.Runtime.InteropServices.Marshal.SizeOf(typeof(PixelData));
                if (sourceWidth % 4 != 0)
                    sourceWidth += (4 - (sourceWidth % 4));
                Byte* bitmapBaseByte;
                bitmapBaseByte = (Byte*)bd.Scan0.ToPointer();
                PixelData* pPixel;
                for (int y = 0; y < height; y++)
                {
                    pPixel = (PixelData*)(bitmapBaseByte + y * sourceWidth);
                    for (int x = 0; x < width; x++)
                    {
                        intImage[x][y] = (int)((0xff << 0x18) | (pPixel->red << 0x10) | (pPixel->green << 8) | pPixel->blue);
                        pPixel++;
                    }
                }

                image.UnlockBits(bd);
            }
            return intImage;

        }
    }
}
