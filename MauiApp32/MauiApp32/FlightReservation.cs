using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp32
{


    public class Reservation
    {
        public string FlightNumber { get; set; }
        public string Airline { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public string Citizenship { get; set; }
        public int ReservationID { get; set; }
        public bool Status {get; set; }

        public Reservation(string flightNumber, string airline, string day, string time, decimal cost, string name, string citizenship, int reservationID)
        {
            FlightNumber = flightNumber;
            Airline = airline;
            Day = day;
            Time = time;
            Cost = cost;
            Name = name;
            Citizenship = citizenship;
            ReservationID = reservationID;

        }
    }
}

