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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Pizza_Choice().Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Drinks().Show();
            this.Close(); 
        }

        private void label11_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Appetizers().Show();
            this.Close(); 
        }

        private void label12_Click(object sender, EventArgs e)
        {
            new AccountPage().Show();
            this.Close();
        }
    }
}
