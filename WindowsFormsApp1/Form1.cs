﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum sum=new sum();
            textBox1.Text=Convert.ToString(sum.add(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
            sum.aa = 12;
            textBox1.Text = Convert.ToString(sum.aa);
        }
    }
}
