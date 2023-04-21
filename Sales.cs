using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opAirlines
{
    public class Sales
    {
        public List<Flight> flights = new List<Flight>();
        public Dictionary<string, List<Flight>> flightsByRoute = new Dictionary<string, List<Flight>>();

        public void AddFlight(object source, FlightEventArgs args)
        {
            flights.Add(args.Flight);
        }


        //afdeling analyseert de verschillende vluchten en berekent per route de gemiddelde bezettingsgraad van een vlucht
        public void ShowRapport() //ShowRapport(int grenswaarde???)
        {
            //groepeer per route
            foreach (Flight flight in flights)
            {
                string route = flight.Route.Departure + "-" + flight.Route.Arrival;

                if (!flightsByRoute.ContainsKey(route))
                {
                    flightsByRoute[route] = new List<Flight>();
                }

                flightsByRoute[route].Add(flight);
            }

            Console.WriteLine("Sales - rapport Bezettingsgraad" + Environment.NewLine + "===============");


            foreach (KeyValuePair<string, List<Flight>> kvp in flightsByRoute)
            {
                string route = kvp.Key;
                List<Flight> routeFlights = kvp.Value;
                int totalSeats = 0;
                int totalOccupiedSeats = 0;

                foreach (Flight flight in routeFlights)
                {
                    totalSeats += flight.Airplane.Seats;
                    totalOccupiedSeats += flight.SeatsSold;
                }

                double averageOccupancy = (double)totalOccupiedSeats / totalSeats * 100;

                Console.WriteLine("Route: {0}", route);
                Console.WriteLine("Number of flights: {0}", routeFlights.Count);
                Console.WriteLine("Average occupancy: {0:f2}%", averageOccupancy);
                Console.WriteLine();
            }

        }


    }
}
