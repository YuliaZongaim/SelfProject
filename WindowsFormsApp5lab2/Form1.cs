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
    public partial class Form1 : Form
    {
       
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Volkswagen Golf");
            comboBox1.Items.Add("Volkswagen Passat");
            comboBox1.Items.Add("Volkswagen Polo");
            comboBox1.Items.Add("Volkswagen Touran");
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                
                Form4 f4 = new Form4();
                f4.ShowDialog();

            }
            if (comboBox1.SelectedIndex == 2)
            {
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                
                Form2 f = new Form2();
                f.ShowDialog();

            }

        }
    }
}
