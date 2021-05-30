using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int arama = textBox1.Text.IndexOf(textBox2.Text);
            if (arama == 0)
            {
                MessageBox.Show("Aranan Kelime Girin !");
            }
            else if(arama ==-1)
            {
                MessageBox.Show("Aranan Kelime Bulunamadı !");
            }
            else
            {
                textBox1.SelectionStart = arama;
                textBox1.SelectionLength = textBox2.Text.Length;
                textBox1.Focus();
                MessageBox.Show("Aranan kelime bulundu konumu :"+ arama);
            }
        }
    }
}
