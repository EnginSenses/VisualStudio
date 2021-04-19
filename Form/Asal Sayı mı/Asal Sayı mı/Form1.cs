using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asal_Sayı_mı
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
            bool asalmı = true;
            int sayi = Convert.ToInt32(textBox1.Text);
            for(i=2;i<=sayi-1;i++)
            {
                if(sayi%i==0)
                {
                    asalmı = false;
                    break;
                }

            }
            if(asalmı==true)
            {
                MessageBox.Show("Asaldır");
            }
            else
            {
                MessageBox.Show("Asal değildir "+ i + " sayısı bu sayıyı böler ");
            }
        }
    }
}
