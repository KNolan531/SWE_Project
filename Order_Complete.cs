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
    public partial class Order_Complete : Form
    {
        public Order_Complete()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Log_In().Show();
            this.Close(); 
        }
    }
}
