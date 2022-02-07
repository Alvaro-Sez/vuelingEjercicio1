using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingBooking.Data.Currencies
{
    public class CurrenciesService : ICurrenciesService
    {

        private Dictionary<string, string> _currencies = new Dictionary<string, string>()
        {
            { "Canada","CAD" },
            { "America","USD" },
            { "Australia","AUD" },
            { "China","RMB" },
            { "Inglaterra","GBP" },
        };

        public Dictionary<string, string> GetCurrenciesInfo()
        {
            return _currencies;
        }
    }
}
