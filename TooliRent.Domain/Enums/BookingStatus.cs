using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooliRent.Domain.Enums
{
    public enum BookingStatus
    {
        Draft = 0,
        Confirmed = 1,
        PickedUp = 2,
        Returned = 3,
        Cancelled = 4,
        Overdue = 5
    }
}

