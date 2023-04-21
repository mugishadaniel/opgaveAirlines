using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace opAirlines
{
    public class Finance
    {
        public List<Flight> flights = new List<Flight>();

        public void AddFlight(object source, FlightEventArgs args)
        {
            flights.Add(args.Flight);
        }


        //rapport voor de brandstofkosten als voor de catering kunnen worden gemaakt op jaarbasis

        //brandstofkosten de totale kost van de uitgevoerde vluchten per jaar

        //catering geven we de kost mee per maand, maar maken we ook nog onderscheid per luchthaven (weglaten)
    }
}
