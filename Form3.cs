using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter some text here")
            {
                textBox1.Text = "";
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /* This click needs to take all the info from the text boxes 
            * and save them into a text file to use as a customer db. After that I  
            * have set it already to load to Credit Card page next. 
            */

            new Credit_Card().Show();
            this.Close(); 
        }
    }
}
