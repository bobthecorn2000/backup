using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sandwich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string part1;
        public string part2;
        public string part3;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          int x = listBox1.SelectedIndex;
          part1 = listBox1.Items[x].ToString();
            label1.Text = part1;
            listBox2.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = listBox2.SelectedIndex;
            part2 = listBox2.Items[x].ToString();
            listBox2.Hide();
            listBox3.Show();
            label1.Text = part1 + " on " + part2;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = listBox3.SelectedIndex;
            part3 = listBox3.Items[x].ToString();
            
            listBox3.Hide();
            label1.Text = part1 + " on " + part2 + " with " + part3;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
