using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Domain;

namespace VuelingBooking.Flights.Data
{
    public interface IFlightsService
    {
        public IEnumerable<Flight> GetFlights();
    }
}
