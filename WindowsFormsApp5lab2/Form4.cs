using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2000$");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Director director = new Director();
            VolkswagenBuilder vp = new VolkswagenPassat();
            director.Construct(vp);
            Volkswagen hm3 = vp.GetProduct();
            textBox1.Text = hm3.ListParts();
        }
    }
}
