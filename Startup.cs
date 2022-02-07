using Autofac;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Application.PriceConversion;
using VuelingBooking.Application.Validate.Checks;
using VuelingBooking.Application.Validate.Pipeline;
using VuelingBooking.Data.Currencies;
using VuelingBooking.Data.Rates;
using VuelingBooking.Flights.Data;

namespace VuelingBooking
{
    public static class Startup
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
           

            builder.RegisterType<PriceConverter>().As<IPriceConverter>();
            
            /*validations*/
            builder.RegisterType<CabinBagsValidation>().As<ICheck>();
            builder.RegisterType<PassengersCapacityValidation>().As<ICheck>();
            builder.RegisterType<PetsValidation>().As<ICheck>();
            builder.RegisterType<RouteMatchValidation>().As<ICheck>();

            /*validator*/
            builder.RegisterType<PipelineValidation>().As<IPipelineValidation>();

            /*services*/
            builder.RegisterType<CurrenciesService>().As<ICurrenciesService>();
            builder.RegisterType<FlightsService>().As<IFlightsService>();
            builder.RegisterType<RateService>().As<IRateService>();


            return builder.Build();
        }
    }
}
