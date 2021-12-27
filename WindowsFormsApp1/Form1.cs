using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog open = new OpenFileDialog();
        String myFileName;
        private void button2_Click(object sender, EventArgs e)
        {

            if (myFileName != null)
            {
                Bitmap image2 = new Bitmap(myFileName, true);
                for (int x = 0; x < image2.Width; x++)
                {
                    for (int y = 0; y < image2.Height; y++)
                    {
                        Color clr = image2.GetPixel(x, y);
                        Color newclr = Color.FromArgb(clr.R, 0, 0);
                        image2.SetPixel(x, y, newclr);
                    }
                }
                pictureBox2.Image = image2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (myFileName != null)
            {
                Bitmap image2 = new Bitmap(myFileName, true);
                for (int x = 0; x < image2.Width; x++)
                {
                    for (int y = 0; y < image2.Height; y++)
                    {
                        Color clr = image2.GetPixel(x, y);
                        Color newclr = Color.FromArgb(0, clr.G, 0);
                        image2.SetPixel(x, y, newclr);
                    }
                }
                pictureBox2.Image = image2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (myFileName != null)
            {
                Bitmap image2 = new Bitmap(myFileName, true);
                for (int x = 0; x < image2.Width; x++)
                {
                    for (int y = 0; y < image2.Height; y++)
                    {
                        Color clr = image2.GetPixel(x, y);
                        Color newclr = Color.FromArgb(0, 0, clr.B);
                        image2.SetPixel(x, y, newclr);
                    }
                }
                pictureBox2.Image = image2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                myFileName = open.FileName;
                Bitmap image1 = new Bitmap(myFileName, true);
                Bitmap image2 = new Bitmap(myFileName, true);
                pictureBox1.Image = image1;
                for (int x = 0; x < image2.Width; x++)
                {
                    for (int y = 0; y < image2.Height; y++)
                    {
                        Color clr = image2.GetPixel(x, y);
                        //  Color newclr = Color.FromArgb(clr.R, 0, 0);
                        // image2.SetPixel(x, y, newclr);
                    }
                }
                pictureBox2.Image = image2;
                label1.Visible = true;
                label2.Visible = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (myFileName != null)
            {
                Bitmap image2 = new Bitmap(myFileName, true);
                pictureBox2.Image = image2;
            }
        }

    }
}
