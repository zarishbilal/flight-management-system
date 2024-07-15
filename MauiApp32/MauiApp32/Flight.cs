using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp32
{
    public class Flight
    {
        public string FlightCode { get; set; }
        public string Airline { get; set; }
        public string DepartureAirport { get; set; }
        public string DestinationAirport { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public decimal Cost { get; set; }
        public decimal Distance { get; set; }

    }

}
