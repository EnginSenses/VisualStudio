using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_ekleme_arama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte i;
            bool bul= false;
            for(i=0;i<=comboBox1.Items.Count-1;i++)
            if(Convert.ToInt32(comboBox1.Items[i])==Convert.ToInt32(textBox2.Text))
            {
                comboBox1.SelectedIndex = i;  
                bul = true;
                break;
            }
            if(bul==true)
            {
                MessageBox.Show("Aranan Değer "+(i+1)+". Sırada Bulundu");
            }
            if (bul == false)
            {
                MessageBox.Show("Aradığınız Değer Bulunamadı !");
            }
        }
    }
}
