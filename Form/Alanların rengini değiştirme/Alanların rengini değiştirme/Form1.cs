using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alanların_rengini_değiştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control nesne in this.Controls)
            {
                if(nesne is TextBox)
                {
                    nesne.BackColor = Color.Black;
                    nesne.ForeColor = Color.White;
                }
                if(nesne is Label)
                { 
                    nesne.BackColor = Color.Yellow;
                    nesne.ForeColor = Color.Red;
                }
                if(nesne is Button)
                {
                    nesne.BackColor  = Color.GreenYellow;
                    nesne.ForeColor = Color.Purple;
                }
            }
        }
    }
}
