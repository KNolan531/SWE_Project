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
    public partial class Credit_Card : Form
    {
        public Credit_Card()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Added!");
            new Menu().Show();
            this.Close(); 
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Added Credit Card!");
            new Menu().Show();
            this.Close(); 
        }
    }
}
