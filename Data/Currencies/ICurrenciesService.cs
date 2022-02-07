using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Domain;

namespace VuelingBooking.Data.Currencies
{
    public interface ICurrenciesService
    {
        public Dictionary<string,string> GetCurrenciesInfo();
    }
}
