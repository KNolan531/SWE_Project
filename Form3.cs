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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter some text here")
            {
                textBox1.Text = "";
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            String[] newC = new string[10];
            String phoneNum = textBox3.Text + textBox4.Text + textBox5.Text;

            newC[0] = textBox1.Text;
            newC[1] = textBox2.Text;
            newC[2] = textBox3.Text + textBox4.Text + textBox5.Text;
            newC[3] = textBox6.Text;
            newC[4] = textBox7.Text;
            newC[5] = textBox8.Text;
            newC[6] = textBox9.Text;
            newC[7] = textBox10.Text; 

            Program.ci.addNewCust(newC);


            Program.cust.setFname(Program.ci.getFirstName(phoneNum));
            Program.cust.setlname(Program.ci.getLastName(phoneNum));
            Program.cust.setPho(Program.ci.getPhone(phoneNum));
            Program.cust.setStreet(Program.ci.getStreet(phoneNum));
            Program.cust.setStreet2(newC[7]); 
            Program.cust.setCity(Program.ci.getCity(phoneNum));
            Program.cust.setState(Program.ci.getState(phoneNum));
            Program.cust.setZip(Program.ci.getZipCode(phoneNum));
            Program.cust.setAnotes(""); 




            new Credit_Card().Show();
            this.Close(); 
        }
    }
}
