using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean son = false;    
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Başla";
            timer1.Interval=100;
            hScrollBar1.Value = 1;
            hScrollBar1.LargeChange = 1;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBar1.Value == hScrollBar1.Maximum)
                son = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Başla")
            {
                button1.Text = "Durdur";
                timer1.Enabled = true;
            }
            else
            {
                button1.Text = "Başla";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(son==false)
            {
                label1.Text = hScrollBar1.Value.ToString();
                if(hScrollBar1.Value==100)
                {
                    son = true;
                    return;
                }
                hScrollBar1.Value = hScrollBar1.Value + 1;
            }
            else
            {
                label1.Text = hScrollBar1.Value.ToString();
                if (hScrollBar1.Value == 1)
                {
                    son = false;
                    return;
                }
                hScrollBar1.Value = hScrollBar1.Value - 1;
            }
        }
    }
}
