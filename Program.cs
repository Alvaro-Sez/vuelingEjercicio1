using Autofac;
using System.Linq;
using System.Collections.Generic;
using VuelingBooking.Domain;
using VuelingBooking.Application.Validate.Pipeline;
using VuelingBooking.Application.PriceConversion;
using VuelingBooking.UI;

namespace VuelingBooking
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = Startup.Configure();

            Request request = new Request()
            {
                Source = "AAL",
                Destination = "CTA",
                Pets = 0,
                CabinBags = 0,
                Nationality = "Australia",
                NumPassengers = 120
            };

            var pipelineValidation = builder.Resolve<IPipelineValidation>();
            var priceConversor = builder.Resolve<IPriceConverter>();

            IEnumerable<Flight>filteredFlightList =  pipelineValidation.Filter(request);
            IEnumerable<Flight> priceConvertedFLightList = priceConversor.ConvertPrices(filteredFlightList, request);

            priceConvertedFLightList.report();
        }
    }
}
