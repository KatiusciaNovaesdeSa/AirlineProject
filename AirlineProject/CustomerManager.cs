using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class CustomerManager
    {
        private static int currentCustNo;
        private int maxCustomer;
        private int numCustomers;
        private Customer[] customerList;
        private Customer[] tempCustomerList;

        public CustomerManager(int seed, int maxCust)
        {
            currentCustNo = seed;
            numCustomers = 0;
            maxCustomer = maxCust;
            customerList = new Customer[maxCust];
            tempCustomerList = new Customer[maxCust];
        }

        public bool addCustomer(string cfName, string lName, string phone)
        {
            if (numCustomers >= maxCustomer)
            {
                return false;
            }
            else
            {

                Customer CustA = new Customer(currentCustNo, cfName, lName, phone);
                currentCustNo++;

                customerList[numCustomers] = CustA;

                numCustomers++;
                return true;
            }
        }

        public int findCustomer(int cId)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (customerList[i].getCustomerID() == cId)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool customerExist(int cId)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (customerList[i].getCustomerID() == cId)
                {
                    return true;
                }
            }
            return false;
        }

        public Customer getCustomer(int cId)
        {
            int customerArray = findCustomer(cId);

            return customerList[customerArray];
        }

        public bool deleteCustomer(int cId)//todo how to delete
        {
            if(customerExist(cId) == true)
            {
                int counter = 0;
                for (int i = 0; i < numCustomers; i++)
                {
                    if (customerList[i].getCustomerID() != cId)
                    { 
                        tempCustomerList[counter] = customerList[i];
                        counter++;
                    }
                }

                customerList = tempCustomerList;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getCustomerList()
        {
            string customerListValue = "";
            for (int i = 0; i < numCustomers; i++)
            {
                if(customerList[i] != null)
                {
                    customerListValue += customerList[i].getCustomerID() + " - " + customerList[i].getFirstName() + " " + customerList[i].getLastName() + " - " + customerList[i].getPhone() + "\n";
                }
            }
            return customerListValue;
        }
    }
}
