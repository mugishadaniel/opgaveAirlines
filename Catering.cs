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

            Dictionary<string, int> ordersPerAirport = new Dictionary<string, int>();

            // Loop through all flights
            //foreach (Flight flight in flights)
            //{
            //    // If catering was ordered for this flight
            //    if (flight.CateringOrdered)
            //    {
            //        // Add the number of catering orders to the corresponding airport in the dictionary
            //        if (ordersPerAirport.ContainsKey(flight.DepartureAirport))
            //        {
            //            ordersPerAirport[flight.DepartureAirport] += flight.NumberOfPassengers;
            //        }
            //        else
            //        {
            //            ordersPerAirport[flight.DepartureAirport] = flight.NumberOfPassengers;
            //        }
            //    }
            //}

            // Print the report
            Console.WriteLine("Catering orders report:");
            foreach (KeyValuePair<string, int> entry in ordersPerAirport)
            {
                Console.WriteLine($"- {entry.Key}: {entry.Value} orders");
            }
        }
    }


}
