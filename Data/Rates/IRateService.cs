using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Domain;

namespace VuelingBooking.Data.Rates
{
    public interface IRateService
    {
        public IEnumerable<Rate> GetRates();
    }
}
