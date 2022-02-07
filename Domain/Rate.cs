using System.Text.Json.Serialization;

namespace VuelingBooking.Domain
{
    public class Rate
    {
        [JsonPropertyName("to")]
        public string To { get; set; }
        [JsonPropertyName("rate")]
        public double RateValue { get; set; }
    }
}
