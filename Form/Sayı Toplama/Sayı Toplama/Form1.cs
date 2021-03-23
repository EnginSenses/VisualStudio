using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam=0,bas,son,i;
            bas = Convert.ToInt32(textBox1.Text);
            son = Convert.ToInt32(textBox2.Text);
            for(i=bas;i<=son;i++)
            {
                toplam += i;
            }
            MessageBox.Show($"Toplam :{toplam}");
        }
    }
}
