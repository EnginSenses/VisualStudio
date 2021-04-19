using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cümlede_karakter_arama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle;
            char karakter;
            int say = 0;
            cumle = textBox1.Text;
            karakter = Convert.ToChar(textBox2.Text);
            for(int i=0;i<=cumle.Length-1;i++)
            {
                if(cumle[i]==karakter)
                {
                    say++;
                }
            }
            MessageBox.Show(karakter +" Karakteri "+say +" Tane vardır.");
        }
    }
}
