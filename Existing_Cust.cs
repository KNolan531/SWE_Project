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
    public partial class Existing_Cust : Form
    {
        public Existing_Cust()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close(); 
        }

        private void label5_Click(object sender, EventArgs e)
        {
            /* Method needed here to search text file for phone # taken from 3 boxes. If not 
             * found then dialog box appears as shown below. If found then it will go to account page 
             * that should be pre-filled with customer's info from text file. 
             */
            String phoneNum = textBox3.Text + textBox4.Text + textBox5.Text; 
           
           //This is just an example. (phoneNum.Equals) should be replaced with a method to search text file for phone #! 
            if (phoneNum.Equals("7701234567"))
            {
                new AccountPage().Show();
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Customer not found!! Add new customer?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    new Form3().Show();
                    this.Close(); 
                }
                
            }
        }
    }
}
