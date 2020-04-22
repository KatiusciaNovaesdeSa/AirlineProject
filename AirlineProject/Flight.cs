using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int maxSeats; 
        private int numPassengers;
        private Customer[] customerList;
        private Customer[] tempCustomerList;


        public Flight(int flightNo, string orig,string dest,int mSeats)
        {
            flightNumber = flightNo;
            origin = orig;
            destination = dest;
            maxSeats = mSeats;
        }

        public int getFlightNumber()
        {
            return flightNumber;
        }

        public string getOrigin()
        {
            return origin;
        }

        public string getDestination()
        {
            return destination;
        }

        public int getMaxSeats()
        {
            return maxSeats;
        }

        public int getNumPassengers()
        {
            return numPassengers;
        }
        
        public bool addPassenger(Customer cust)
        {
            if(numPassengers>=maxSeats)
            {
                return false;
            }
            else
            {
                customerList[numPassengers] = cust;
                numPassengers++;
                return true;
            }
        }

        public int findPassenger(int custId)
        {
            for (int i = 0; i < numPassengers; i++)
            {
                if (customerList[i].getCustomerID() == custId)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool removePassenger(int custId)
        {
            if (findPassenger(custId) >= 0)
            {
                int counter = 0;
                for (int i = 0; i < numPassengers; i++)
                {
                    if (customerList[i].getCustomerID() != custId)
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

        public string getPassengerList()
        {
            string passengerList = "";
            for (int i = 0; i < numPassengers; i++)
            {
                if(customerList[i] != null)
                {
                    passengerList += customerList[i] + "\n";
                }
                
            }
            return passengerList;
        }

        public string toString()
        {
            return "flightNumber: " + flightNumber + "origin: " + origin + "destination: " + destination + "maxSeats: " + maxSeats + "numPassengers" + numPassengers;
        }
    }
}

