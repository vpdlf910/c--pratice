using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Threading;


namespace 미래모빌리티
{
    public partial class Form1 : Form
    {
        List<Image> images = new List<Image>();
        int imgIdx = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users/rnrms/Downloads/picture1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(listBox1.items);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           if (imgIdx >= images.Count)
                    {
                        imgIdx = 0;
                    }
                    pictureBox1.Image = images[imgIdx];
                    imgIdx++;
        }
    }
}