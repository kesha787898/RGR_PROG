using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;




namespace kurs
{
    public partial class Form1 : Form
    { Image im;

        public Form1()
        {
            InitializeComponent();
            Size= new System.Drawing.Size(100, 150);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenFile_dialog.ShowDialog() == DialogResult.Cancel)
                    throw new Exception("Отменено");
                string path = OpenFile_dialog.FileName;
                
                try
                {

                    im = Image.FromFile(path);
                    picture.Size=im.Size;
                       
                    picture.Image = im;
                    MessageBox.Show("File opened" + path);
                    this.Size = new System.Drawing.Size(300+im.Size.Width,300+ im.Size.Height);


                }
                catch { throw new Exception("Not Image"); }

            }
            catch (Exception exep)
            {
                MessageBox.Show("Warning " +exep.Message);

            }  


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //this.Size = new System.Drawing.Size(w -100, h -1000);

        }

        private void OpenFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {}

        private void GreyscaleButton_Click(object sender, EventArgs e)
        {



            try
            {
                im=pix_filter.Grayscale(im);
                picture.Image = im;
                MessageBox.Show("Grayscale");
            }

            catch (Exception exep) {
                MessageBox.Show("Warning " + exep.Message);


            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {




            try
            {
                im = pix_filter.BandW(im);
                picture.Image = im;
                MessageBox.Show("Black and White");
            }

            catch (Exception exep)
            {
                MessageBox.Show("Warning " + exep.Message);


            }
        }

        private void Negat_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                im = pix_filter.Negat(im);
                picture.Image = im;
                MessageBox.Show("Negativ");
            }

            catch (Exception exep)
            {
                MessageBox.Show("Warning " + exep.Message);


            }



        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Chanel_button_Click(object sender, EventArgs e)
        {
            try
            {
                im = pix_filter.Chanel(im, cahnels_bar.Value);
                picture.Image = im;
                MessageBox.Show("Chanel");
            }

            catch (Exception exep)
            {
                MessageBox.Show("Warning " + exep.Message);


            }
        }

        private void Sepia_button_Click(object sender, EventArgs e)
        {
            try
            {
                im = pix_filter.Sepia(im);
                picture.Image = im;
                MessageBox.Show("Sepia");
            }

            catch (Exception exep)
            {
                MessageBox.Show("Warning " + exep.Message);


            }

        }

        private void Brightness_bar_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                im = pix_filter.Brightness(im, Brightness_bar.Value);
                picture.Image = im;
            }

            catch (Exception exep)
            {
                MessageBox.Show("Warning " + exep.Message);


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_2(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RandNoiseBar_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                im = pix_filter.Digital_noisw(im, RandNoiseBar.Value);
                picture.Image = im;
                
            }

            catch (Exception exep)
            {
                MessageBox.Show("Warning " + exep.Message);


            }

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {/*код с условиями*/

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
