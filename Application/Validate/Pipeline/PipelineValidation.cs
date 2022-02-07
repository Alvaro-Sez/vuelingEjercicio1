using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Application.Validate.Checks;
using VuelingBooking.Domain;
using VuelingBooking.Flights.Data;

namespace VuelingBooking.Application.Validate.Pipeline
{
    public class PipelineValidation : IPipelineValidation
    {
        private readonly IEnumerable<ICheck> _checkList;
        private readonly IFlightsService _flightService;
        public PipelineValidation(IEnumerable<ICheck> checkList, IFlightsService flightsService)
        {
            _checkList = checkList;
            _flightService = flightsService;
        }
        public IEnumerable<Flight> Filter(Request request)
        {
            IEnumerable<Flight>flightList = _flightService.GetFlights();

            foreach (var check in _checkList)
            {
                flightList = check.validate(flightList, request);
            }
            return flightList;
        }
    }
}
