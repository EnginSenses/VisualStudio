using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faktöriyel_kuvvet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi,fakt=1;
            sayi = Convert.ToInt32(textBox1.Text);
            for(int i=1;i<=sayi;i++)
            {
                fakt = i * fakt;
            }
            textBox3.Text = fakt.ToString();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi, kuvvet,hesap=1;
            sayi = Convert.ToInt32(textBox1.Text);
            kuvvet = Convert.ToInt32(textBox2.Text);
            for(int i=1;i<=kuvvet ; i++)
            {
                hesap = hesap * sayi;
            }
            textBox4.Text = hesap.ToString();
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
