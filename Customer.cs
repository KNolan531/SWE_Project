using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Customer
    {
       private String fName;
       private String lName; 
       private String phoneNum;
       private String street;
       private String city;
       private String state;
       private String zip;

        public Customer()
        {

        }     

        public Customer(String firstName,String lastName, String phNum, String st, String cit,String sta, String zipc) 
        {
            this.fName = firstName;
            this.lName = lastName;
            this.phoneNum = phNum;
            this.street = st;
            this.city = cit;
            this.state = sta;
            this.zip = zipc; 
        }








    }
}
