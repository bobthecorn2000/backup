using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int clicks = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            button1.Text = Convert.ToString(clicks);
            if (clicks >= 11)
            {
                if (clicks >= 20)
                {

                    button1.Text = $"";
                    button1.BackColor = Color.Red;
                    button1.Width = 100;
                }
                else
                {
                    button1.Text = $"mmmmmm {Convert.ToString(clicks)} clicks";
                }
                
            }
            clicks++;
            progressBar1.Maximum = 20;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.PerformStep();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
