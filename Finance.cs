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



        //brandstofkosten de totale kost van de uitgevoerde vluchten per jaar
        public double BerekenTotaleBrandstofkosten(int jaar)
        {
            double totaleKosten = 0;

            foreach (Flight flight in flights)
            {
                if (flight.DepartureDate.Year == jaar)
                {
                    double kostenPer100Km = flight.Airplane.FuelCost;
                    double afstandInKm = flight.Route.Distance;
                    double kostenVoorVlucht = kostenPer100Km * afstandInKm * flight.SeatsSold;
                    totaleKosten += kostenVoorVlucht;
                }
            }

            return totaleKosten;
        }
        //catering geven we de kost mee per maand, maar maken we ook nog onderscheid per luchthaven (weglaten)
    }
}
