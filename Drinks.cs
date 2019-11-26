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
    public partial class Drinks : Form
    {
        public Drinks()
        {
            InitializeComponent();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close(); 
        }

        private void label24_Click(object sender, EventArgs e)
        {
            new Order_Summ().Show();
            this.Close(); 
        }

        private void label25_Click(object sender, EventArgs e)
        {
            new AccountPage().Show();
            this.Close(); 
        }

        private void label26_Click(object sender, EventArgs e)
        {
            /* This action should save the drink(s) chosen by check mark and add 
             * it to the customer's order to be displayed on order summary page.  
            */
            MessageBox.Show("Succesfully added to your order!");
            new Menu().Show();
            this.Close(); 
        }
    }
}
