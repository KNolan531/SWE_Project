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
    public partial class SpecialtyPizza : Form
    {
        public SpecialtyPizza()
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

        private void label17_Click(object sender, EventArgs e)
        {
            /*This action should accept input from the check boxes under each pizza  
             * and add that pizza to the order to be displayed in order summary. 
             * 
             */

            MessageBox.Show("Successfully added pizza to your order!");
            new Menu().Show();
            this.Close(); 
        }
    }
}
