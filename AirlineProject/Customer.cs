using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;

        public Customer(int id, string fName, string lName,string ph)
        {
            customerId = id;
            firstName = fName;
            lastName = lName;
            phone = ph;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getPhone()
        {
            return phone;
        }

        public int getCustomerID()
        {
            return customerId;
        }

        public string toString()
        {
            return "customerId: " + customerId + "firstName: " + firstName + "lastName: " + lastName + "phone: " + phone;
        }
    }
}


