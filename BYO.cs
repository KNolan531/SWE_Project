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
    public partial class BYO : Form
    {
        public BYO()
        {
            InitializeComponent();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            new AccountPage().Show();
            this.Close();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            new Order_Summ().Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /* This click should collect the text from each drop down box and check box
             * and then place it on the order list. ie- med thin crust red sauce w/ beef and pepp.
             * The messagebox below will show if at least the first 3 drop down boxes are selected, if 
             * not then an error  message will pop up as shown below. 
             */

            if (sauce.SelectedIndex == -1 || size.SelectedIndex == -1 || crust.SelectedIndex == -1) 
                MessageBox.Show("Please select your crust, sauce and pizza size!");
           else
                MessageBox.Show("Successfully added Pizza to your order!"); 
        }
    }
}
