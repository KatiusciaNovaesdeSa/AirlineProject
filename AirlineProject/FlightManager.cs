using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class FlightManager
    {

        private int maxFlights;
        private int numFlights;
        private Flight[] listFlight;
        private Flight[] tempListFlight;

        public FlightManager(int maxFlt)//todo
        {
            numFlights = 0;
            maxFlights = maxFlt;
            listFlight = new Flight[maxFlights];
        }

        public bool addFlight(int flNo,string origin, string dest, int maxSeats)
        {
            if (numFlights >= maxFlights)
            {
                return false;
            }
            else
            {
                Flight fl = new Flight(flNo, origin, dest, maxSeats);

                listFlight[numFlights] = fl;

                numFlights++;
                return true;
            }
        }

        private int findFlight(int flightNo)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (listFlight[i].getFlightNumber() == flightNo)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool FlightExist(int flightNo)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (listFlight[i].getFlightNumber() == flightNo)
                {
                    return true;
                }
            }
            return false;
        }

        public Flight getFlight(int flightNo)
        {
            int flightArray = findFlight(flightNo);

            return listFlight[flightArray];
        }

        public bool deleteFlight(int flightNo)
        {
            if (FlightExist(flightNo) == true)
            {
                int counter = 0;
                for (int i = 0; i < numFlights; i++)
                {
                    if (listFlight[i].getFlightNumber() != flightNo)
                    {
                        tempListFlight[counter] = listFlight[i];
                        counter++;
                    }
                }

                listFlight = tempListFlight;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getFlightList()
        {
            string ListFlights = "";
            for (int i = 0; i < numFlights; i++)
            {
                ListFlights += listFlight[i].getFlightNumber() + " from " + listFlight[i].getOrigin() + " to " + listFlight[i].getDestination() + "\n";
            }
            return ListFlights;
        }
    }
}