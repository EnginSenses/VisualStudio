﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string[] dizi;
            if (e.KeyCode==Keys.Enter)
            {
                dizi = textBox1.Text.Split(' ');
                MessageBox.Show("Cümlenin kelime sayısı :"+ dizi.Length.ToString());
            }
        }
    }
}
