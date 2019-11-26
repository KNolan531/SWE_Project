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
    public partial class Order_Summ : Form
    {
        public Order_Summ()
        {
            InitializeComponent();
        }

        private void Order_Summ_Load(object sender, EventArgs e)
        {
            /*This action event should load the current order summary when the form  
             * is opened. Right now I am temporarily using a created class called Order and calling it's 
             * setOrder method to display something to show how it should work. 
             */
            Order o = new Order();
            o.setOrder("Small Pepperoni Pizza");
            this.label1.Text = o.displayOrder(); 
            this.label1.Show();
           
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

        private void label6_Click(object sender, EventArgs e)
        {
            new Checkout().Show();
            this.Close(); 
        }

        private void label24_Click(object sender, EventArgs e)
        {
            new Order_Summ().Show();
            this.Close(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //This directs to the checkout form 
            new Checkout().Show();
            this.Close(); 
        }
    }
}
