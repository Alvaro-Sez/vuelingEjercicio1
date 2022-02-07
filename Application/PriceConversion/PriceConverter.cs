using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Data.Currencies;
using VuelingBooking.Data.Rates;
using VuelingBooking.Domain;

namespace VuelingBooking.Application.PriceConversion
{
    public class PriceConverter : IPriceConverter
    {
        private readonly ICurrenciesService _currenciesService;
        private readonly IRateService _rateservice;

        public PriceConverter(ICurrenciesService currenciesService, IRateService rateservice)
        {
            _currenciesService = currenciesService;
            _rateservice = rateservice;
        }
        public IEnumerable<Flight> ConvertPrices(IEnumerable<Flight> filteredFlightList, Request request)
        {
            string currency = GetCurrencyPerNationality(request.Nationality);
            double rate = GetRateValue(currency);

            foreach(Flight flight in filteredFlightList)
            {
                flight.PricePerPerson = flight.PricePerPerson * rate;
            }
            return filteredFlightList;
        }

        private double GetRateValue(string currency)
        {
            IEnumerable<Rate> rates = _rateservice.GetRates();
            Rate oRate = rates.First(x => x.To == currency);
            return oRate.RateValue;
        }

        private string GetCurrencyPerNationality(string nationality)
        {
            Dictionary<string, string> currenciesInfo = _currenciesService.GetCurrenciesInfo();
            return currenciesInfo[nationality];
        }
            

    }
}
