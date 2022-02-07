using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Domain;

namespace VuelingBooking.Application.Validate.Pipeline
{
    public interface IPipelineValidation
    {
        IEnumerable<Flight> Filter(Request request);
    }
}
