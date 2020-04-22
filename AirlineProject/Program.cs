using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AirlineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineCoordinator AirCord = new AirlineCoordinator(0, 2, 2);
            RunProgram(AirCord);
            Console.Clear();
            Console.WriteLine("Thank you for choose AirLine Project Company");
            Console.ReadKey();
        }

        public static void RunProgram(AirlineCoordinator AirCord)
        {
            int userChoice;
            MenuDisplay();

            Int32.TryParse(Console.ReadLine(), out userChoice);
            while (userChoice != 7)
            {

                switch (userChoice)
                {
                    case 1: AddFlightDisplay(AirCord);
                        break;
                    case 2:
                        AddCustomerDisplay(AirCord);
                        break;
                    case 3:
                        ViewFlightsDisplay(AirCord, true);
                        break;
                    case 4:
                        ViewCustomerDisplay(AirCord, true);
                        break;
                    case 5:
                        DeleteCustomerDisplay(AirCord);
                        break;
                    case 6:
                        DeleteFlightDisplay(AirCord);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Your choice is not valid, please select a valid choice.\n\n");
                        Console.WriteLine("Press any key to continue return to the main menu.");
                        Console.ReadKey();
                        break;
                }

                MenuDisplay();
                Int32.TryParse(Console.ReadLine(), out userChoice);
            }
        }

        public static void MenuDisplay()
        {
            Console.Clear();
            Console.WriteLine("AirLine Project Company.");
            Console.WriteLine("Please select a choice from the menu below");
            Console.WriteLine(" 1. Add Flight");
            Console.WriteLine(" 2. Add Customer");
            Console.WriteLine(" 3. View Flights");
            Console.WriteLine(" 4. View Customer");
            Console.WriteLine(" 5. Delete Customer");
            Console.WriteLine(" 6. Delete Flight");
            Console.WriteLine(" 7. Exit ");
        }

        public static void AddFlightDisplay(AirlineCoordinator AirCord)
        {
            int flightNumber;
            int maxSeats;
            string Origin;
            string Destination;

            Console.Clear();
            Console.WriteLine("......... Add Flight .........");

            Console.WriteLine("Please enter the flight number: ");
            Int32.TryParse(Console.ReadLine(), out flightNumber);

            Console.WriteLine("Please enter the maximum number of seats: ");
            Int32.TryParse(Console.ReadLine(), out maxSeats);

            Console.WriteLine("Please enter the port of Origin: ");
            Origin = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter the destination port: ");
            Destination = Convert.ToString(Console.ReadLine());


            if (AirCord.addFlight(flightNumber, Origin, Destination, maxSeats) == true)
            {
                Console.WriteLine("Flight succesfully added.");
            }
            else
            {
                Console.WriteLine("It is not allowed to add more flights, for futher information contact the support team.");
            }

            Console.WriteLine("Press any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void AddCustomerDisplay(AirlineCoordinator AirCord)
        {
            Console.Clear();
            Console.WriteLine("......... Add Customer .........");
            Console.WriteLine("Please enter a customer first name: ");
            string firstName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter a customer last name: ");
            string lastName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter a customer phone number: ");
            string phoneNumber = Convert.ToString(Console.ReadLine());


            if (AirCord.addCustomer(firstName, lastName, phoneNumber) == true)
            {
                Console.WriteLine("Customer succesfully added.");
            }
            else
            {
                Console.WriteLine("It is not allowed to add more customer, for futher information contact the support team.");
            }

            Console.WriteLine("Press any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void DeleteFlightDisplay(AirlineCoordinator AirCord)
        {
            Console.Clear();
            int flightId;
            ViewFlightsDisplay(AirCord, false);

            if (AirCord.flightList() != "")
            {
                Console.WriteLine("Please enter the flight id to delete the flight: ");
                Int32.TryParse(Console.ReadLine(), out flightId);


                if (AirCord.deleteFlight(flightId) == true)
                {
                    Console.WriteLine("Flight with id " + flightId + " deleted.");
                }
                else
                {
                    Console.WriteLine("Flight with id " + flightId + " was not found.");
                }
            }
            Console.WriteLine("Press any key to continue return to the main menu.");
            Console.ReadKey();

        }

        public static void DeleteCustomerDisplay(AirlineCoordinator AirCord)
        {
            Console.Clear();
            int customerId;

            ViewCustomerDisplay(AirCord, false);

            if (AirCord.customerList() != "")
            {
                Console.WriteLine("Please enter the customer id to delete the customer: ");
                Int32.TryParse(Console.ReadLine(), out customerId);

                if (AirCord.deleteCustomer(customerId) == true)
                {
                    Console.WriteLine("Customer with id " + customerId + " deleted.");
                }
                else
                {
                    Console.WriteLine("Customer with id " + customerId + " was not found.");
                }
            }
            Console.WriteLine("Press any key to continue return to the main menu.");
            Console.ReadKey();
        }


        public static void ViewFlightsDisplay(AirlineCoordinator AirCord, bool showReturnMenu)
        {
            Console.Clear();
            Console.WriteLine("......... Flight List .........");
            if(AirCord.flightList()== "")
            {
                Console.WriteLine("The system does not have flight added.");
            }
            else
            {
                Console.WriteLine(AirCord.flightList());
            }

            if(showReturnMenu == true)
            {
                Console.WriteLine("Press any key to continue return to the main menu.");
                Console.ReadKey();
            }
            
        }

        public static void ViewCustomerDisplay(AirlineCoordinator AirCord, bool showReturnMenu)
        {
            Console.Clear();
            Console.WriteLine("......... View Customer .........");

            if (AirCord.customerList() == "")
            {
                Console.WriteLine("The system does not have customer added.");
            }
            else
            {
                Console.WriteLine("Number - Full Name - Phone");
                Console.WriteLine(AirCord.customerList());
            }

            if (showReturnMenu == true)
            {
                Console.WriteLine("Press any key to continue return to the main menu.");
                Console.ReadKey();
            }
        }
    }
}

