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
    public partial class Pizza_Choice : Form
    {
        public Pizza_Choice()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new BYO().Show();
            this.Close(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new SpecialtyPizza().Show();
            this.Close(); 
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new AccountPage().Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Order_Summ().Show();
            this.Close();
        }
    }
}
