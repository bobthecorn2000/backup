using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bednbreakfast
{
    public partial class Form3 : Form
    {
        private const double CONT_BREAKFAST_PRICE = 6.00;  
        private const double FULL_BREAKFAST_PRICE = 9.95;  
        private const double DELUXE_BREAKFAST_PRICE = 16.50;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Price: " + CONT_BREAKFAST_PRICE.ToString("C"); 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Price: " +    CONT_BREAKFAST_PRICE .ToString("C");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Price: " + FULL_BREAKFAST_PRICE.ToString("C");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Price: " + DELUXE_BREAKFAST_PRICE.ToString("C");
        }
    }
}
