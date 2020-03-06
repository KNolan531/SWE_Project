/* Customer Info Class - A class that connects to a database(in this case a file) and retrieves 
 * the individual customers' info. It then adds the customer info into an array of Customer objects 
 * that can be used to retrieve and search for individual customers. Finally, there is an addCustomer 
 * function where the user can add a new customer to the database(text file). 
 */
using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class CustomerInfo 
    {

        
        String file = @"C:\Users\Kev\source\repos\WindowsFormsApp3\peopledb.txt";
        String[] newFnames = new string[40];
        String[] newLname = new string[40];
        String[] phNums = new String[40];
        String[] custStreet = new string[40];
        String[] custCity = new string[40];
        String[] custState = new string[40];
        String[] custZip = new string[40];

        int count =0; 

        public CustomerInfo()
        {
            getCustomers();

        }

        //Reads the inputted text file and places the individual customer data into 
        public void getCustomers()
        {

            // Read a text file line by line.
            string[] lines = File.ReadAllLines(file);

            
            int i = 0; 
            foreach (string line in lines)
            {
                
                newFnames[i] = line.Split('*')[0];
                newLname[i] = line.Split('*')[1];
                phNums[i] = line.Split('*')[2];
                custStreet[i] = line.Split('*')[3];
                custCity[i] = line.Split('*')[4];
                custState[i] = line.Split('*')[5];
                custZip[i] = line.Split('*')[6];
                i++;
            }
            count = i; 
        }

        public String getFirstName(String phone)
        {
            String result = "";

            

            for (int i = 0; i < count; i++)
            {
                if (phNums[i].Equals(phone))
                    return newFnames[i]; 
            }
                


            return result; 
            
        }

        //This method takes in an array of strings that has been collected from the user and then inputs it into the DB/text file 
        public void addNewCust(String [] fn)
        {
            
                newFnames[count] = fn[0];
                newLname[count] = fn[1];
                phNums[count] = fn[2];
                custStreet[count] = fn[3];
                custCity[count] = fn[5];
                custState[count] = fn[6];
                custZip[count] = fn[7];

            using (StreamWriter sr = File.AppendText(file))
            {
                
                sr.Write("\n" + fn[0] + "*" + fn[1] + "*" + fn[2] + "*" + fn[3] + "*" + fn[4] + "*" + fn[5] + "*" + fn[6] + "*" + fn[7]);
                sr.Flush(); 
            }


            count++;
            
        }

        public String getLastName(String phone)
        {
            String result = "";

            for (int i = 0; i < count; i++)
            {
                if (phNums[i].Equals(phone))
                    return newLname[i];
            }
            return result;

        }

        public String getPhone(String phone)
        {
            return phone; 
        }

        public String getStreet(String phone)
        {
            String result = "";

            for (int i = 0; i < count; i++)
            {
                if (phNums[i].Equals(phone))
                    return custStreet[i];
            }
            return result;

        }

        public String getCity(String phone)
        {
            String result = "";

            for (int i = 0; i < count; i++)
            {
                if (phNums[i].Equals(phone))
                    return custCity[i];
            }
            return result;

        }

        public String getState(String phone)
        {
            String result = "";

            for (int i = 0; i < count; i++)
            {
                if (phNums[i].Equals(phone))
                    return custState[i];
            }
            return result;

        }

        public String getZipCode(String phone)
        {
            String result = "";

            for (int i = 0; i < count; i++)
            {
                if (phNums[i].Equals(phone))
                    return custZip[i];
            }
            return result;

        }




        /* This is simply a test method I used to make sure the file was 
         * reading in data correctly to the program. 
         */ 

        public String displayCustomer()
        {
            
            String custs = "";

            for (int i = 0; i < newFnames.Length; i++)
            {
                custs += newFnames[i] + "\t";
                custs += newLname[i] + "\n";
                custs += phNums[i] + "\n"; 
            }
                
            return custs;  
        }




    }
}
