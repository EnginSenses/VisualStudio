using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            string metin = textBox1.Text;
            string sifreli_metin="";
            for(i=0;i<=metin.Length-1;i++)
            {
                sifreli_metin = sifreli_metin + Convert.ToChar((Convert.ToInt32(metin[i]) + 17%255));
            }
            textBox2.Text = sifreli_metin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            string sifreli_metin=textBox2.Text;
            string cözüm="";
            for(i=0;i<=sifreli_metin.Length-1;i++)
            {
                cözüm = cözüm + Convert.ToChar((Convert.ToInt32(sifreli_metin[i])-17%255));
            }
            textBox3.Text = cözüm;
        }
    }
}
