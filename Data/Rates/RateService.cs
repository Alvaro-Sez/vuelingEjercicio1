using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using VuelingBooking.Domain;

namespace VuelingBooking.Data.Rates
{
    public class RateService : IRateService
    {
        public IEnumerable<Rate> GetRates()
        {
            var assembly = typeof(RateService).GetTypeInfo().Assembly;
            Stream resource = assembly.GetManifestResourceStream("VuelingBooking.Infraestructure.ratesdata.json");
            return JsonSerializer.DeserializeAsync<IEnumerable<Rate>>(resource).Result;
        }
    }
}
