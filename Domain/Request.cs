using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingBooking.Domain
{
    public class Request
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Pets { get; set; }
        public int CabinBags { get; set; }
        public string Nationality { get; set; }
        public int NumPassengers { get; set; }

        public bool HasBags()
        {
            if (CabinBags > 0) return true;
            return false;
        }
        public bool HasPets()
        {
            if (Pets > 0) return true;
            return false;
        }
    }
}
