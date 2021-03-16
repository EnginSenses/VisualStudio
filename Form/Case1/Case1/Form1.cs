using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            switch(listBox1.Text)
            {
                case "Sarı":this.BackColor = Color.Yellow; break;
                case "Kırmızı": this.BackColor = Color.Red; break;
                case "Mavi": this.BackColor = Color.Blue; break;
                case "Mor": this.BackColor = Color.Purple; break;
                case "Yeşil": this.BackColor = Color.Green; break;
                case "Siyah": this.BackColor = Color.Black; break;
                default: break;
            }
                

        }
    }
}
