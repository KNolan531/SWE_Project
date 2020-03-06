/* Order Class - A container class to hold and/or keep track of the items in an order. 
 *  It will also keep count of how many of each item has been ordered and the  
 *  total overall price of the order. Finally it will have a method that can display the 
 *  order summary to the screen as the order is compiled. 
 * 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Order
    {
        private String[] pizza = new String[50];
        int pizzaCount,appCount,drinkCount = 0;
        private String[] drinks = new string[20];
        private String[] appetizers = new string[50];
        private double total = 0.00; 

        public Order()
        {
                  

        }

        public Order(String[] pz, String[] dk,  String[] app)
        {
            this.pizza = pz;
            this.drinks = dk;
            this.appetizers = app; 

        }

        public void addPizza(String p)
        {
            this.pizza[pizzaCount] = p;
            pizzaCount++; 
        }

        public void addApp(String a)
        {
            this.appetizers[appCount] = a;
            appCount++; 
        }

        public void addDrink(String d)
        {
            this.drinks[drinkCount] = d;
            drinkCount++; 
        }

        //Takes a value inputted by menu item page and adds it to the total. 
        public void addPrice(double p)
        {
            total += p; 
        }

        //Method resets the order to 0 to start fresh. 
        public void clearOrder()
        {
            this.appCount = 0;
            this.pizzaCount = 0;
            this.drinkCount = 0;
            this.total = 0.00; 


            pizza = new String[50];
            appetizers = new string[50];
            drinks = new string[20]; 

        }

        public String displayTotal()
        {

           return "The total pizzas is:" + pizzaCount + "\n The total apps is: " + appCount; 
        }

        //This method loops through each item type and prints the individual elements to the user 
        public String displayOrder()
        {
            String apps ="";
            String pizzas = "";
            String drink ="";
                           
              for (int i = 0; i < pizzaCount; i++)
              {                   
                pizzas += pizza[i] + "\n ------------------------- \n";
              }   
                                           
              for (int j = 0; j < appCount; j++)
              {
                apps += appetizers[j] + "\n ------------------------- \n";
              }
                             
              for (int k = 0; k < drinkCount; k++)
              {
                drink += drinks[k] + "\n ------------------------- \n";
              }


            String orderList = "";  
            orderList = pizzas + apps + drink  + "\n \n Total: $" + total;


            return orderList;
            

        }


    }
}
