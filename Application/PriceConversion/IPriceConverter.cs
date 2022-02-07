using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Domain;

namespace VuelingBooking.Application.PriceConversion
{
    public interface IPriceConverter
    {
        public IEnumerable<Flight> ConvertPrices(IEnumerable<Flight> flights, Request request);
    }
}
