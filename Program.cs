﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class Program
    {
        public static Order newOrder = new Order();
        public static CustomerInfo ci = new CustomerInfo();
        public static Customer cust = new Customer(); 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            var main = new Log_In();
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            
            main.Show();
            Application.Run();
            

        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }


    }
}
