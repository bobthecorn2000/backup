using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        string name;
        string address;
        string city;
        string state;
        string zip;
        int wtfiswrongwithyou;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            address = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            city = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            state = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            zip = textBox5.Text;
        }

        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            wtfiswrongwithyou = int.Parse(numericUpDown1.Text) + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = $"{name},{address},{city},{state},{zip},{wtfiswrongwithyou}\n {wtfiswrongwithyou * 39.95} \n why are you spending {wtfiswrongwithyou * 39.95:c} on blenders";
        }
    }
}
