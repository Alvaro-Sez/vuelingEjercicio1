using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Domain;
using VuelingBooking.Enum.Domain;

namespace VuelingBooking.Application.Validate.Checks
{
    internal class CabinBagsValidation : ICheck
    {
        public IEnumerable<Flight> validate(IEnumerable<Flight> flightList, Request request)
        {
            foreach(var flight in flightList)
            {
                if(flight.State == FlightStatus.valid) 
                { 
                    if ( !flight.AllowCabinBags && request.HasBags())
                    {
                        flight.Invalidate(InvalidationType.bags);
                    }
                }
            }
            return flightList;
        }
    }
}
