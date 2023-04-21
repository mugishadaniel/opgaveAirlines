using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opAirlines
{
    public class Flight
    {
        public int FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public Route Route { get; set; }
        public int SeatsSold { get; set; }
        public Airplane Airplane { get; set; }
        public double MealCost { get; set; }

    }
}
