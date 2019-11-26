using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Order
    {
        private String[] pizza;
        int pizzaCount = 0; 
        private String[] drinks;
        private String[] appetizers; 

        public Order()
        {
            pizza = new String[50];
            drinks = new string[20];
            appetizers = new string[50]; 

        }

        public Order(int p, int d, int a)
        {
            pizza = new String[p];
            drinks = new string[d];
            appetizers = new string[a];

        }

        public void setOrder(String p)
        {
            this.pizza[pizzaCount] = p;
            pizzaCount++; 
        }

        public String displayOrder()
        {
            String orderList ="";
            int count = 0; 

            if(pizza.Length != 0) 
                while(count < pizza.Length)
                {
                    orderList += pizza[count] + "\n";
                    count++; 
                }



            return orderList; 

        }


    }
}
