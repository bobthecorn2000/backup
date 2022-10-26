using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Font small = new Font("arial", 8);
        Font medium = new Font("arial", 10);
        Font large = new Font("arial", 12);

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";
        }

        private void goodbyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Goodbye";
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = small;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = medium;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = large;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black; 

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
    }
}
