/* Customer Class - A basic container class to hold the data for 
 * each individual customer that has been inputted to the system via the database.  
 * 
 * 
 */


using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp3
{
    public class Customer
    {
        private String fName;
        private String lName;
        private String phoneNum;
        private String street;
        private String street2; //address line 2 (like apartment #s) 
        private String city;
        private String state;
        private String zip;
        private String aNotes; //address notes 
        

        //Default Constructor: sets an empty customer object. 
        public Customer()
        {

        }

        //Sets up initial customer info 
        public Customer(String firstName, String lastName, String phNum, String st, String cit, String sta, String zipc, String aNNotes)
        {
            this.fName = firstName;
            this.lName = lastName;
            this.phoneNum = phNum;
            this.street = st;
            this.city = cit;
            this.state = sta;
            this.zip = zipc;
            this.aNotes = aNNotes;
        }

        public String getFName()
        {
            return fName; 
        }

        public void setFname(String fn)
        {
            fName = fn; 
        }

        public String getlName()
        {
            return lName;
        }

        public void setlname(String ln)
        {
            lName = ln;
        }

        public String getPho()
        {
            return phoneNum; 
        }

        public void setPho(String po)
        {
            phoneNum = po; 
        }

        public String getStreet()
        {
            return street;
        }

        public void setStreet2(String st)
        {
            street2 = st;
        }

        public String getStreet2()
        {
            return street2;
        }

        public void setStreet(String st)
        {
            street = st;
        }

        public String getCity()
        {
            return city;
        }

        public void setCity(String cit)
        {
            city = cit;
        }

        public String getState()
        {
            return state;
        }

        public void setState(String ste)
        {
            state = ste;
        }

        public String getZip()
        {
            return zip;
        }

        public void setZip(String zp)
        {
            zip = zp;
        }

        public String getANotes()
        {
            return aNotes;
        }

        public void setAnotes(String st)
        {
            aNotes = st;
        }



        //Clears the account to setup a new customer in the system 
        public void clearAccount()
        {
            new Customer();   

        }




    }
}
