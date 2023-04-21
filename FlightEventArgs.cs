using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opAirlines
{
    public class FlightEventArgs : EventArgs
    {
        public FlightEventArgs(Flight flight)
        {
            Flight = flight;
        }

        public Flight Flight { get;}
    }
}
