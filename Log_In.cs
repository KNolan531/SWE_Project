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
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            String user ="";
            String pass ="";
            if (textBox1.Text != "")
                user = textBox1.Text;
            if (textBox2.Text != "")
                pass = textBox2.Text;
            if (user.Equals("KNolan") || user.Equals("KBonaby") || user.Equals("YWoo"))
            {
                if (user.Equals("KNolan"))
                    if (pass.Equals("password"))
                    {
                        new Form1().Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Invalid Password!!!");
                else if (user.Equals("KBonaby"))
                    if (pass.Equals("ksu1234"))
                    {
                        new Form1().Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Invalid Password!!!");
                else if (user.Equals("YWoo"))
                    if (pass.Equals("computer"))
                    {
                        new Form1().Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Invalid Password!!!");
            }
            else
                MessageBox.Show("Username not found!!");
        }
    }
}
