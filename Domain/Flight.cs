using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingBooking.Enum.Domain;

namespace VuelingBooking.Domain
{
    public class Flight
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Source { get; set; }
        public string Destination { get; set; }
        public FlightType Type { get; set; }
        public bool AllowAnimals { get; set; }
        public bool AllowCabinBags { get; set; }
        public double PricePerPerson { get; set; }
        public int PassengerCapacity { get; set; }
        public string InvalidationReason { get; set; }
        public FlightStatus State { get; set; } = FlightStatus.valid;

        public void Invalidate(InvalidationType invalidationReason)
        {
            switch (invalidationReason)
            {
                case  InvalidationType.bags:
                    State = FlightStatus.invalid;
                    setInvalid("Bags are not allowed");
                    break;
                case InvalidationType.pets:
                    State = FlightStatus.invalid;
                    setInvalid("Pets are not allowed");
                    break;
                case InvalidationType.route:
                    State = FlightStatus.invalid;
                    setInvalid("route does not match the request");
                    break;
                case InvalidationType.passengers:
                    State = FlightStatus.invalid;
                    setInvalid("passengers number exceded");
                    break;
            }
        }
        private void setInvalid(string message)
        {
            InvalidationReason = message;
            PricePerPerson = 0;
        }
        
    }
}
