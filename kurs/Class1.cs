using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;
namespace kurs
{
    public class pix_filter
    {
        public static Image Grayscale(Image im)
        {
            Bitmap Bmp = new Bitmap(im);
            for (int i = 0; i < Bmp.Width; i++)
            {

                for (int j = 0; j < Bmp.Height; j++)
                {
                    var col = Bmp.GetPixel(i, j);
                    int c = (col.R + col.G + col.B) / 3;
                    col = Color.FromArgb(c, c, c);
                    Bmp.SetPixel(i, j, col);
                }
            }
            im = (Image)Bmp;
            return im;
        }
        public static Image BandW(Image im)
        {
            Bitmap Bmp = new Bitmap(im);
            for (int i = 0; i < Bmp.Width; i++)
            {

                for (int j = 0; j < Bmp.Height; j++)
                {
                    var col = Bmp.GetPixel(i, j);
                    int c = (col.R + col.G + col.B) / 3;
                    if (c >= 256 / 2)
                    {
                        col = Color.FromArgb(255, 255, 255);
                    }
                    else col = Color.FromArgb(0, 0, 0);
                    Bmp.SetPixel(i, j, col);

                }
            }
            im = (Image)Bmp;
            return im;
        }

        public static Image Negat(Image im)
        {
            Bitmap Bmp = new Bitmap(im);
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    var col = Bmp.GetPixel(i, j);
                    col = Color.FromArgb(255 - col.R, 255 - col.G, 255 - col.B);
                    Bmp.SetPixel(i, j, col);
                }
            }
            im = (Image)Bmp;
            return im;
        }
        public static Image Chanel(Image im, int arg)
        {
            Bitmap Bmp = new Bitmap(im);
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    var col = Bmp.GetPixel(i, j);
                    switch (arg)
                    {
                        case 0:
                            col = Color.FromArgb(col.R, 0, 0);
                            break;
                        case 1:
                            col = Color.FromArgb(0, col.G, 0);
                            break;
                        case 2:
                            col = Color.FromArgb(0, 0, col.B);
                            break;

                        default:
                            throw new Exception("HHHHH");


                    }
                    Bmp.SetPixel(i, j, col);
                }
            }
            im = (Image)Bmp;
            return im;
        }


        public static Image Brightness(Image im, int arg)
        {
            Bitmap Bmp = new Bitmap(im);
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    var col = Bmp.GetPixel(i, j);

                    //100


                    int R = col.R + arg * 10;
                    int G = col.G + arg * 10;
                    int B = col.B + arg * 10;
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    col = Color.FromArgb(R, G, B);

                    Bmp.SetPixel(i, j, col);
                }
            }
            im = (Image)Bmp;
            return im;
        }


        public static Image Digital_noisw(Image im, int arg)
        {

            Random random = new Random();

            Bitmap Bmp = new Bitmap(im);
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    var col = Bmp.GetPixel(i, j);

                    //100


                    int R = col.R + random.Next(-arg * 10, arg * 10);
                    int G = col.G + random.Next(-arg * 10, arg * 10);
                    int B = col.B + random.Next(-arg * 10, arg * 10);
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    col = Color.FromArgb(R, G, B);

                    Bmp.SetPixel(i, j, col);
                }
            }
            im = (Image)Bmp;

            return im;
        }


        public static Image Sepia(Image im)
        {


            Bitmap Bmp = new Bitmap(im);
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    var col = Bmp.GetPixel(i, j);

                    //100

                    int R = (int)(col.R * 0.393 + col.G * 0.769 + col.B * 0.189);
                    int G = (int)(col.R * 0.349 + col.G * 0.686 + col.B * 0.168);
                    int B = (int)(col.R * 0.272 + col.G * 0.534 + col.B * 0.131);
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    col = Color.FromArgb(R, G, B);

                    Bmp.SetPixel(i, j, col);
                }
            }
            im = (Image)Bmp;

            return im;
        }


       



       /* public static Image Filter(Image im,string name,int size) {
            Bitmap Bmp = new Bitmap(im);
            int p = size / 2;
            float[,] matrix = new float[size,size];


            Color[,] arr = new Color[size, size];
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    for (int ii =0; ii < size; ii++) {
                        for (int jj = 0; jj < size; jj++)
                        {try { arr[i, j] = Bmp.GetPixel(i, j);
                                int R = (int)(col.R * 0.393 + col.G * 0.769 + col.B * 0.189);
                                int G = (int)(col.R * 0.349 + col.G * 0.686 + col.B * 0.168);
                                int B = (int)(col.R * 0.272 + col.G * 0.534 + col.B * 0.131);
                                if (R > 255) R = 255;
                                if (G > 255) G = 255;
                                if (B > 255) B = 255;
                                if (R < 0) R = 0;
                                if (G < 0) G = 0;
                                if (B < 0) B = 0;
                                col = Color.FromArgb(R, G, B);


                            }
                            catch{ arr[i, j] =Color.FromArgb(128,128,128); }





                        }


                    }





                    int R = (int)(col.R * 0.393 + col.G * 0.769 + col.B * 0.189);
                    int G = (int)(col.R * 0.349 + col.G * 0.686 + col.B * 0.168);
                    int B = (int)(col.R * 0.272 + col.G * 0.534 + col.B * 0.131);
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    col = Color.FromArgb(R, G, B);

                    Bmp.SetPixel(i, j, col);
                }
            }
            im = (Image)Bmp;

            return im;
             }

    */
    }
    
    
}
