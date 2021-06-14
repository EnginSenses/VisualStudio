using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Dosya Seç";
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter ="Jpg Dosyaları(*.jpg)|*.jpg| Bmp Dosyaları(*.bmp)|*.bmp";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = new Bitmap(openFileDialog1.OpenFile());
        }
    }
}
