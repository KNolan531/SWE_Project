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
            String dk ="";
            double dpr = 0.00; 


            /* -- Adding Pepsi Drink to order -- */ 
            if(pCan.Checked || pBot.Checked || pLiter.Checked)
            {
                if (pCan.Checked)
                {
                    dk = pCan.Text;
                    dpr = 1.00;
                }
                if (pBot.Checked) 
                {
                    dk = pBot.Text;
                    dpr = 1.99; 
                }
                if (pLiter.Checked)
                {
                    dk = pLiter.Text;
                    dpr = 2.99; 
                }

                Program.newOrder.addDrink("Pepsi - " + dk);
                Program.newOrder.addPrice(dpr); 
    
            }

            /* -- Adding Diet Pepsi Drink to order -- */
            if (dpCan.Checked || dpBottle.Checked || dpLiter.Checked)
            {
                if (dpCan.Checked)
                {
                    dk = dpCan.Text;
                    dpr = 1.00;
                }
                if (dpBottle.Checked)
                {
                    dk = dpBottle.Text;
                    dpr = 1.99;
                }
                if (dpLiter.Checked)
                {
                    dk = dpLiter.Text;
                    dpr = 2.99;
                }

                Program.newOrder.addDrink("Diet Pepsi - " + dk);
                Program.newOrder.addPrice(dpr);

            }

            /* -- Adding Dr Pepper to order -- */
            if (pepCan.Checked || pepBottle.Checked || pepLiter.Checked)
            {
                if (pepCan.Checked)
                {
                    dk = pepCan.Text;
                    dpr = 1.00;
                }
                if (pepBottle.Checked)
                {
                    dk = pepBottle.Text;
                    dpr = 1.99;
                }
                if (pepLiter.Checked)
                {
                    dk = pepLiter.Text;
                    dpr = 2.99;
                }

                Program.newOrder.addDrink("Dr Pepper - " + dk);
                Program.newOrder.addPrice(dpr);

            }

            /* -- Adding Mountain Dew Drink to order -- */
            if (mdCan.Checked || mdBottle.Checked || mdLiter.Checked)
            {
                if (mdCan.Checked)
                {
                    dk = mdCan.Text;
                    dpr = 1.00;
                }
                if (mdBottle.Checked)
                {
                    dk = mdBottle.Text;
                    dpr = 1.99;
                }
                if (mdLiter.Checked)
                {
                    dk = mdLiter.Text;
                    dpr = 2.99;
                }

                Program.newOrder.addDrink("Mountain Dew - " + dk);
                Program.newOrder.addPrice(dpr);

            }

            /* -- Adding Sierra Mist to order -- */
            if (smCan.Checked || smBottle.Checked || smLiter.Checked)
            {
                if (smCan.Checked)
                {
                    dk = smCan.Text;
                    dpr = 1.00;
                }
                if (smBottle.Checked)
                {
                    dk = smBottle.Text;
                    dpr = 1.99;
                }
                if (smLiter.Checked)
                {
                    dk = smLiter.Text;
                    dpr = 2.99;
                }

                Program.newOrder.addDrink("Sierra Mist - " + dk);
                Program.newOrder.addPrice(dpr);

            }

            /* -- Adding Fruit Punch Drink to order -- */
            if (fpCan.Checked || fpBottle.Checked || fpLiter.Checked)
            {
                if (fpCan.Checked)
                {
                    dk = fpCan.Text;
                    dpr = 1.00;
                }
                if (fpBottle.Checked)
                {
                    dk = fpBottle.Text;
                    dpr = 1.99;
                }
                if (fpLiter.Checked)
                {
                    dk = fpLiter.Text;
                    dpr = 2.99;
                }

                Program.newOrder.addDrink("Fruit Punch - " + dk);
                Program.newOrder.addPrice(dpr);

            }


            if (dk.Equals(""))
                MessageBox.Show("No drink selected!");
            else
            {
                MessageBox.Show("Succesfully added to your order!");
                new Menu().Show();
                this.Close();
            }
        }
    }
}
