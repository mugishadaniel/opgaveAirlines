namespace opAirlines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airline airline = new Airline();
            Catering catering = new Catering();
            Finance finance = new Finance();
            Sales sales = new Sales();


            airline.NewFlight += catering.AddFlight;
            airline.NewFlight += finance.AddFlight;
            airline.NewFlight += sales.AddFlight;

            airline.VoegFlight();

            sales.ShowRapport();
            Console.WriteLine("Totale brandstofkost " + finance.BerekenTotaleBrandstofkosten(2021));
        }
    }
}