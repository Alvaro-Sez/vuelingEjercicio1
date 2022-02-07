using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Domain;
using VuelingBooking.Enum.Domain;

namespace VuelingBooking.UI
{
    public static class Reporter
    {
        public static void report(this IEnumerable<Flight> flightList)
        {
            Console.WriteLine("\n\n\nFlight List");
            foreach (var flight in flightList)
            {
                Console.WriteLine($"\n---------Flight Id: {flight.Id} ---------");
                Console.WriteLine($"Source: {flight.Source}");
                Console.WriteLine($"Destination: {flight.Destination}");
                Console.WriteLine($"This flight is {flight.State} for the request");

                if (flight.State == FlightStatus.valid)
                { 
                    Console.WriteLine($"Price per person: {flight.PricePerPerson}");
                    Console.WriteLine($"Animals allowed: {flight.AllowAnimals}");
                    Console.WriteLine($"Cabin bags allowed: {flight.AllowCabinBags}\n");
                }
                else
                {
                    Console.WriteLine($"Invalidated Reason: {flight.InvalidationReason}");
                    Console.WriteLine("\n"); 
                }
            }

        }

    }
}
