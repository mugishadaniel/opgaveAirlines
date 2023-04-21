using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace opAirlines
{
    public class Airline
    {

        public event EventHandler<FlightEventArgs> NewFlight;
        public void AddFlight(Flight flight)
        {
            if (NewFlight != null)
            {
                NewFlight(this, new FlightEventArgs(flight));
            }
        }

        public void VoegFlight()
        {
            using (StreamReader sr = File.OpenText(@"C:\Hogent\programmeren gevorderd\oefeningen\opgave airline (evalutie)\airlineData.txt"))
            {
                string input = null;
                string header = sr.ReadLine();
                while ((input = sr.ReadLine()) != null)
                {

                    string values = input;
                    string[] valuesArray = values.Split(',');
                    Flight flight = new Flight() { FlightNumber = Convert.ToInt32(valuesArray[0]), DepartureDate = Convert.ToDateTime(valuesArray[1]), SeatsSold = Convert.ToInt32(valuesArray[2]) };
                    Airplane airplane = new Airplane() { Name = valuesArray[3], FuelCost = Convert.ToDouble(valuesArray[4]), Seats = Convert.ToInt32(valuesArray[5]), Speed = Convert.ToDouble(valuesArray[6]) };
                    Route route = new Route() { Departure = valuesArray[7], Arrival = valuesArray[8], Distance = Convert.ToDouble(valuesArray[9]) };
                    flight.Route = route;
                    flight.Airplane = airplane;

                    AddFlight(flight);

                }
            }
        }
    }
}
