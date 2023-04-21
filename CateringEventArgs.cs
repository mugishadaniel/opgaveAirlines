using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opAirlines
{
    public class CateringEventArgs
    {
        public CateringEventArgs(CateringOrder cateringOrder)
        {
            CateringOrder = cateringOrder;
        }

        public CateringOrder CateringOrder { get; }
    }
}
