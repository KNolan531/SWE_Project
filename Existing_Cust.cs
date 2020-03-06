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
    public partial class Existing_Cust : Form
    {
        public Existing_Cust()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close(); 
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            String phoneNum = textBox3.Text + textBox4.Text + textBox5.Text;
            bool found = true; 

            if(Program.ci.getFirstName(phoneNum).Equals("")) 
                found = false; 
            
           
           //Adds appropriate customer info to customer object. 
            if (textBox3.TextLength >0 && textBox4.TextLength > 0 && textBox5.TextLength > 0 && found == true)
            {
                Program.cust.setFname(Program.ci.getFirstName(phoneNum));
                Program.cust.setlname(Program.ci.getLastName(phoneNum));
                Program.cust.setPho(Program.ci.getPhone(phoneNum)); 
                Program.cust.setStreet(Program.ci.getStreet(phoneNum));
                Program.cust.setCity(Program.ci.getCity(phoneNum));
                Program.cust.setState(Program.ci.getState(phoneNum));
                Program.cust.setZip(Program.ci.getZipCode(phoneNum));

                new AccountPage().Show();

                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Customer not found!! Add new customer?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    new Form3().Show();
                    this.Close(); 
                }
                
            }
        }
    }
}
