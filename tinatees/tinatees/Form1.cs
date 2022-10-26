using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinatees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            label5.Show();
            label5.Text = "Shipping: " + monthCalendar1.SelectionRange.Start.AddDays(3).ToShortDateString();
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Price: $18";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Price: $20";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Price: $23";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Price: $26";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBox1.SelectedItems.Count == 1)
            //{
            //    BackColor = Color.Blue;
            //}
            //label5.Text = listBox1.GetItemText(listBox1.SelectedItem).ToString();
            if (listBox1.GetItemText(listBox1.SelectedItem).ToString() == "White")
            {
                BackColor = Color.Yellow;
            }
            if (listBox1.GetItemText(listBox1.SelectedItem).ToString() == "Red")
            {
                BackColor = Color.Red;
            }
            if (listBox1.GetItemText(listBox1.SelectedItem).ToString() == "Blue")
            {
                BackColor = Color.Blue;
            }

        }
    }
}
