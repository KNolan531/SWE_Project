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
            String ap = "";
           
            /* -- Adding Wings to order! -- */

            if (wing10.Checked || wing20.Checked || wing30.Checked)
                if (wingSauce.SelectedIndex == -1)
                    MessageBox.Show("Please choose a wing sauce!!");
            if (wingSauce.SelectedIndex != -1)
                if (!wing10.Checked && !wing20.Checked && !wing30.Checked)
                {
                    MessageBox.Show("Please choose a wing count!");
                     
                }
                else
                {
                    
                    String wingCount;
                    double wingP = 0.00;
                    if (wing10.Checked)
                    {
                        wingCount = wing10.Text;
                        wingP = 8.99;
                    }
                    else if (wing20.Checked)
                    {
                        wingCount = wing20.Text;
                        wingP = 16.99;
                    }
                    else
                    {
                        wingCount = wing30.Text;
                        wingP = 24.99;
                    }
                    ap = wingSauce.Text + " Wings - " + wingCount;

                    Program.newOrder.addApp(ap);
                    Program.newOrder.addPrice(wingP);

                }

                        /* -- Adding House salad to order! -- */

                        if (smallHouse.Checked || largeHouse.Checked)
                        {
                            String salad;
                            double saladPrice;

                            if (smallHouse.Checked)
                            {
                                salad = smallHouse.Text;
                                saladPrice = 2.99;
                            }
                            else
                            {
                                salad = largeHouse.Text;
                                saladPrice = 5.99;
                            }

                            ap = "House Salad - " + salad;

                            Program.newOrder.addApp(ap);
                            Program.newOrder.addPrice(saladPrice);

                        }

                        /* -- Adding Ceasar salad to order! -- */

                        if (smallCeasar.Checked || largeCeasar.Checked)
                        {
                            String salad;
                            double saladPrice;

                            if (smallHouse.Checked)
                            {
                                salad = smallCeasar.Text;
                                saladPrice = 3.99;
                            }
                            else
                            {
                                salad = largeCeasar.Text;
                                saladPrice = 6.99;
                            }

                            ap = "Ceasar Salad - " + salad;

                            Program.newOrder.addApp(ap);
                            Program.newOrder.addPrice(saladPrice);

                        }

                        /* -- Adding Garlic Knots to order! -- */

                        if (smallGarlic.Checked || largeGarlic.Checked)
                        {
                            String g;
                            double gPrice;

                            if (smallGarlic.Checked)
                            {
                                g = smallGarlic.Text;
                                gPrice = 3.99;
                            }
                            else
                            {
                                g = largeGarlic.Text;
                                gPrice = 6.99;
                            }

                            ap = "Garlic Knots - " + g;

                            Program.newOrder.addApp(ap);
                            Program.newOrder.addPrice(gPrice);

                        }

                        /* -- Adding Mozzarella Sticks to order! -- */

                        if (smallMozz.Checked || largeMozz.Checked)
                        {
                            String mozz;
                            double mozzPrice;

                            if (smallMozz.Checked)
                            {
                                mozz = smallMozz.Text;
                                mozzPrice = 4.99;
                            }
                            else
                            {
                                mozz = largeMozz.Text;
                                mozzPrice = 8.69;
                            }

                            ap = "Mozzarella Sticks - " + mozz;

                            Program.newOrder.addApp(ap);
                            Program.newOrder.addPrice(mozzPrice);

                        }

                        /* -- Adding Fries to order! -- */

                        if (smallFries.Checked || largeFries.Checked)
                        {
                            String fries;
                            double friesPrice;

                            if (smallFries.Checked)
                            {
                                fries = smallFries.Text;
                                friesPrice = 1.99;
                            }
                            else
                            {
                                fries = largeFries.Text;
                                friesPrice = 3.49;
                            }

                            ap = "Fries - " + fries;

                            Program.newOrder.addApp(ap);
                            Program.newOrder.addPrice(friesPrice);

                        }

            if (!specNotes.Text.Equals(""))
                Program.newOrder.addApp("[Appetizer notes: " + specNotes.Text + "]");


            
            if (ap.Equals(""))
                MessageBox.Show("No appetizers selected!");
            else
            {
                MessageBox.Show("Successfully added to your order!");
                new Menu().Show();
                this.Close();
            }

            
               

           
    
        }
    }
}
