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
            String toppings = "";
            double tp = 0.0; 
            String pz = "";
            double piz = 0.0;

            Control c = new Control();

            if(size.SelectedIndex != -1)
            {
                pz = crust.Text + " - " + size.Text + "\n" + sauce.Text;
                piz = 8.99 + (size.SelectedIndex * 3); 
            }

            foreach(var control in this.Controls)
            {
                if (control is CheckBox)
                    if (((CheckBox)control).Checked == true)
                    {
                        toppings += ((CheckBox)control).Text + ", ";
                        tp += 1.0; 
                    } 

            }

            if (!notes.Equals(""))
                toppings += "\n [Pizza Notes:" + notes.Text + "]";  

                                          
            if (sauce.SelectedIndex == -1 || size.SelectedIndex == -1 || crust.SelectedIndex == -1)
                MessageBox.Show("Please select your crust, sauce and pizza size!");
            else
            {
                Program.newOrder.addPizza(pz + "\n" + toppings);
                Program.newOrder.addPrice(piz + tp);
                MessageBox.Show("Successfully added Pizza to your order!");
                new Menu().Show(); 
                this.Close(); 
            }

            

        }

        private void notes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
