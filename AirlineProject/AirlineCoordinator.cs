using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class AirlineCoordinator
    {
        private FlightManager flightMan;
        private CustomerManager customerMan;

        public AirlineCoordinator(int custIdSeed, int maxCustomers, int maxFlights)
        {
            customerMan = new CustomerManager(custIdSeed, maxCustomers);
            flightMan = new FlightManager(maxFlights);
        }

        public bool addFlight(int flNo, string origin, string dest, int maxSeats)
        {
            return flightMan.addFlight(flNo, origin, dest, maxSeats);
        }

        public bool addCustomer(string cfName,string lName,string phone)
        {
            return customerMan.addCustomer(cfName, lName, phone);
        }

        public string flightList()
        {
            return flightMan.getFlightList();
        }

        public string customerList()
        {
            return customerMan.getCustomerList();
        }

        public bool deleteCustomer(int cId)
        {
            return customerMan.deleteCustomer(cId);
        }

        public bool deleteFlight(int flightNo)
        {
            return flightMan.deleteFlight(flightNo);
        }
    }
}




