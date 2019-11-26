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
    public partial class Appetizers : Form
    {
        public Appetizers()
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

        private void label19_Click(object sender, EventArgs e)
        {
            /* This action should save the appetizer chosen by check mark and add 
             * it to the customer's order to be displayed on order summary page. It should 
             * throw an error message if one of the wing options is chosen, but no sauce is selected. 
            */

            if (wing10.Checked || wing20.Checked || wing30.Checked)
                if (wingSauce.SelectedIndex == -1)
                    MessageBox.Show("Please choose a wing sauce!!");
            else if (wingSauce.SelectedIndex != -1)
                    if (!wing10.Checked && !wing20.Checked && !wing30.Checked)
                    MessageBox.Show("Please choose a wing count!");
            else
                {
                    MessageBox.Show("Successfully added to your order!!");
                    new Menu().Show();
                    this.Close();
                }

           
    
        }
    }
}
