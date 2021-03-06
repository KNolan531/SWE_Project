﻿using System;
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
    public partial class AccountPage : Form
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        private void AccountPage_Load(object sender, EventArgs e)
        {
            /* This page should load customer info into the customer info boxes if they are an existing customer. 
             * The other part of this Load function is to get info from a text file on customer's previous orders 
             * and load it into label 8 (right side of screen). I used the example below as a past order.  
             */


            textBox1.Text = Program.cust.getFName();
            textBox2.Text = Program.cust.getlName();

            if(Program.cust.getPho() == null)
            {
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
            {
                textBox3.Text = Program.cust.getPho().Substring(0, 3);
                textBox4.Text = Program.cust.getPho().Substring(3, 3);
                textBox5.Text = Program.cust.getPho().Substring(6, 4);
            }
            
            textBox6.Text = Program.cust.getStreet();
            textBox7.Text = Program.cust.getStreet2(); 
            textBox8.Text = Program.cust.getCity();
            textBox9.Text = Program.cust.getState();
            textBox10.Text = Program.cust.getZip();
            textBox11.Text = Program.cust.getANotes();

             



            label8.Text = "08/10/2019 - \t $41.28 - \t Mastercard ***1234";
            label8.Show(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

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

        private void label10_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Close(); 
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (textBox11.TextLength > 0)
                Program.cust.setAnotes(textBox11.Text);

            MessageBox.Show("Account Info Updated!");
            new Menu().Show();
            this.Close(); 
        }

        private void label9_Click(object sender, EventArgs e)
        {
            new Credit_Card().Show();
            this.Close();
        }
    }
}
