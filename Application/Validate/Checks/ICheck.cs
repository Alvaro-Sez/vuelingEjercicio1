using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Domain;

namespace VuelingBooking.Application.Validate.Checks
{
    public interface ICheck
    {
        IEnumerable<Flight> validate(IEnumerable<Flight> flightList, Request request);
    }
}
