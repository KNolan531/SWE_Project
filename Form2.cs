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
    public partial class Form2 : Form
    {
        Form1 frm = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frm.Show(); 
            this.Close(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Existing_Cust().Show();
            this.Close(); 
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Order_Summ().Show(); 
            this.Close(); 
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new AccountPage().Show();
            this.Close(); 
        }
    }
}
