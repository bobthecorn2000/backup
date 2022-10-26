using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bednbreakfast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)   {
                belleaireform belleAireForm = new belleaireform();     
                belleAireForm.ShowDialog();
                checkBox1.Checked = false;
            }
            
        }
        

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                linkform linkForm = new linkform();
                linkForm.ShowDialog();
                checkBox2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 linkForm = new Form3();
            linkForm.ShowDialog();
        }
    }
    }

