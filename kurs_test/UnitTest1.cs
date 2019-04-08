using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
namespace kurs_test
{
    [TestClass]
    public class pix_filter_test
    {
        [TestMethod]
        public void GrayScale_test()
        {
           Image im= Image.FromFile("C:/Users/alex/Desktop/4 семестр/проектирование/ргр/kurs/kurs_test/4e790-samuraichamploolosmuertevideanos-blogspot-com20.jpg");
           im= kurs.pix_filter.Grayscale(im);
            Bitmap Bmp = new Bitmap(im);
            bool tr = true;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    if ((Bmp.GetPixel(i, j).R == Bmp.GetPixel(i, j).G)&& (Bmp.GetPixel(i, j).R == Bmp.GetPixel(i, j).B)) {
                        continue;



                    }
                    tr = false;
                    break;

                }
            }
           


            Assert.IsTrue(tr);

        }
        [TestMethod]
        public void BandW_test()
        {
            Image im = Image.FromFile("C:/Users/alex/Desktop/4 семестр/проектирование/ргр/kurs/kurs_test/4e790-samuraichamploolosmuertevideanos-blogspot-com20.jpg");
            im = kurs.pix_filter.BandW(im);
            Bitmap Bmp = new Bitmap(im);
            bool tr = true;
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = 0; j < Bmp.Height; j++)
                {
                    if ((Bmp.GetPixel(i, j).R == Bmp.GetPixel(i, j).G) && (Bmp.GetPixel(i, j).R == Bmp.GetPixel(i, j).B)&&((Bmp.GetPixel(i, j).R==0) ||(Bmp.GetPixel(i, j).R==255)))
                    {
                        continue;



                    }
                    tr = false;
                    break;

                }
            }
           


            Assert.IsTrue(tr);

        }

        [TestMethod]
        public void Negativ()
        {
            Image im1 = Image.FromFile("C:/Users/alex/Desktop/4 семестр/проектирование/ргр/kurs/kurs_test/4e790-samuraichamploolosmuertevideanos-blogspot-com20.jpg");
            Image im2 = kurs.pix_filter.Negat(im1);
            Bitmap Bmp1 = new Bitmap(im1);
            Bitmap Bmp2 = new Bitmap(im2);
            bool tr = true;
            for (int i = 0; i < Bmp2.Width; i++)
            {
                for (int j = 0; j < Bmp2.Height; j++)
                {

                    int R1 = Bmp1.GetPixel(i, j).R;
                    int R2 = Bmp2.GetPixel(i, j).R;
                    int G1 = Bmp1.GetPixel(i, j).G;
                    int G2 = Bmp2.GetPixel(i, j).G;
                    int B1 = Bmp1.GetPixel(i, j).B;
                    int B2 = Bmp2.GetPixel(i, j).B;
                    if ((R1==255-R2)||(G1==255-G2)||(B1==255-B2))
                    {
                        continue;



                    }
                    tr = false;
                    break;

                }
            }
            


            Assert.IsTrue(tr);

        }


        [TestMethod]
        public void Channel()
        {
            Image im1 = Image.FromFile("C:/Users/alex/Desktop/4 семестр/проектирование/ргр/kurs/kurs_test/4e790-samuraichamploolosmuertevideanos-blogspot-com20.jpg");
            Image im2 = kurs.pix_filter.Chanel(im1, 0);
            Bitmap Bmp2 = new Bitmap(im2);
            bool tr = true;
            for (int i = 0; i < Bmp2.Width; i++)
            {
                for (int j = 0; j < Bmp2.Height; j++)
                {

                 
                    int G2 = Bmp2.GetPixel(i, j).G;
                    int B2 = Bmp2.GetPixel(i, j).B;
                    if ((G2 == 0) &&(B2==0))
                    {
                        continue;



                    }
                    tr = false;
                    break;

                }
            }



            Assert.IsTrue(tr);

        }
        
    }
}
