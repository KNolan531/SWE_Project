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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            Close();
            
        }

        private void label5_MouseDown_1(object sender, MouseEventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.Show();
            this.Close(); 
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Order_Type().Show(); 
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Log_In().Show();
            this.Close(); 
        }
    }
}
