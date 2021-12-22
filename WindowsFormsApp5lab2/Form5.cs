﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5lab2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1600$");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Director director = new Director();
            VolkswagenBuilder vpo = new VolkswagenPolo();
            director.Construct(vpo);
            Volkswagen hm4 = vpo.GetProduct();
            textBox1.Text = hm4.ListParts();
        }
    }
}
