using System;
using System.Collections.Generic;
using VuelingBooking.Domain;
using VuelingBooking.Enum.Domain;

namespace VuelingBooking.Flights.Data
{
    public class FlightsService : IFlightsService
    {

        public IEnumerable<Flight> GetFlights()
        {
            List<string> vs = new List<string> { "LCG", "AAL", "AGA", "HBE", "AHO", "ALC", "LEI", "AMS", "ALG", "OVD", "ATH", "BJL", "BCN", "BRI", "BSL", "CTA", "EFL" };
            Random rnd = new Random();
            int[] numberPassengers = { 200, 220, 180 };
            List<Flight> flights = new List<Flight>();

            for (int i = 0; i < vs.Count; i++)
            {
                int randomNumber = rnd.Next(1, 4);
                Flight flight = new Flight
                {
                    AllowAnimals = (i % 2) == 0,
                    AllowCabinBags = (i % 2) == 1,
                    Source = vs[i],
                    Destination = vs[vs.Count - i - 1],
                    Type = (FlightType)randomNumber,
                    PricePerPerson = rnd.NextDouble() * 1000,
                    PassengerCapacity = numberPassengers[randomNumber-1]
                };
                flights.Add(flight);
            }
            return flights;
        }
    }
}
