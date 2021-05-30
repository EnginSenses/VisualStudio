using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte i;
            string[] dizi;
            dizi = textBox1.Text.Split(Convert.ToChar(textBox2.Text));
            for(i=0;i<=dizi.Length-1;i++)
            {
                listBox1.Items.Add(dizi[i].ToString());
            }
        }
    }
}
