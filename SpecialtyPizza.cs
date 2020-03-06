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

        public static Order p = new Order(); 
        
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
            
            String specP = "";
            double s = 10.99;
            double s2 = 9.99; 

            if (meatLovers.SelectedIndex > -1)
            {
                if (mCrust.SelectedIndex == -1)
                    MessageBox.Show("Please choose a crust!!!"); 
                else 
                    specP = mCrust.Text + " - " + "Meat Lovers" + " - " + meatLovers.Text;
                
                double i = 3 * meatLovers.SelectedIndex; 

                Program.newOrder.addPrice(s + i);
                Program.newOrder.addPizza(specP);

            }
            
            if (veggieLovers.SelectedIndex > -1)
            {
                if (vCrust.SelectedIndex == -1)
                    MessageBox.Show("Please choose a crust!!!");
                else
                    specP = vCrust.Text + " - " + "Veggie Lovers" + " - " + veggieLovers.Text;

                
                double i = 3 * veggieLovers.SelectedIndex;

                Program.newOrder.addPrice(s + i);
                Program.newOrder.addPizza(specP);
            }

            if (bbqChicken.SelectedIndex > -1)
            {
                if (bCrust.SelectedIndex == -1)
                    MessageBox.Show("Please choose a crust!!!");
                else
                    specP = bCrust.Text + " - " + "BBQ Chicken" + " - " + bbqChicken.Text ;

                
                double i = 3 * bbqChicken.SelectedIndex;

                Program.newOrder.addPrice(s + i);
                Program.newOrder.addPizza(specP);
            }

            if (hawaiian.SelectedIndex > -1)
            {
                if (hCrust.SelectedIndex == -1)
                    MessageBox.Show("Please choose a crust!!!");
                else
                    specP = hCrust.Text + " - " + "Hawaiian" + " - " + hawaiian.Text;


                double i = 3 * hawaiian.SelectedIndex;

                Program.newOrder.addPrice(s2 + i);
                Program.newOrder.addPizza(specP);
            }

            if (garlicChicken.SelectedIndex > -1)
            {
                if (gCrust.SelectedIndex == -1)
                    MessageBox.Show("Please choose a crust!!!");
                else
                    specP = gCrust.Text + " - " + "Garlic Chicken" + " - " + garlicChicken.Text;


                double i = 3 * garlicChicken.SelectedIndex;

                Program.newOrder.addPrice(s2 + i);
                Program.newOrder.addPizza(specP);
            }

            if (peppLovers.SelectedIndex > -1)
            {
                if (pCrust.SelectedIndex == -1)
                    MessageBox.Show("Please choose a crust!!!");
                else
                    specP =  pCrust.Text + " - " + "Pepperoni Lovers" + " - " + peppLovers.Text;


                double i = 3 * peppLovers.SelectedIndex;

                Program.newOrder.addPrice(s2 + i);
                Program.newOrder.addPizza(specP);
            }

                                          
            if (specP.Equals(""))
                MessageBox.Show("No pizzas selected!");
            else
            {
                MessageBox.Show("Successfully added pizza to your order!");
                new Menu().Show();
                this.Close();
            } 

            
        }
    }
}
