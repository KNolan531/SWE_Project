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
    public partial class Checkout : Form
    {
        public Checkout()
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

        private void label17_Click(object sender, EventArgs e)
        {
            //This goes to the order complete form. It throws a messagebox error if nothing is checked. 
            if (!cashPayment.Checked && !checkPayment.Checked && !creditCard.Checked)
                MessageBox.Show("No payment method selected!");
            if(cashPayment.Checked || checkPayment.Checked)
            {
                new Order_Complete().Show();
                this.Close();
            }
            else if (creditCard.Checked)
                    if (!newCard.Checked && !savedCard.Checked)
                        MessageBox.Show("Choose type of card to use!");
                    else
                    {
                        new Order_Complete().Show();
                        this.Close();
                    }
               
            


        }
    }
}
