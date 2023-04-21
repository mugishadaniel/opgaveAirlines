using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace opAirlines
{
    public class Catering
    {
        public List<Flight> flights = new List<Flight>();
        public List<CateringOrder> Rapport = new List<CateringOrder>();



        public void AddFlight(object source,FlightEventArgs args)
        {
            flights.Add(args.Flight);
        }

        //rapport van de verschillende orders per luchthaven
        public void ShowRapport()
        {
            Console.WriteLine("Catering - rapport" + Environment.NewLine + "===============");


        }
    }


}
