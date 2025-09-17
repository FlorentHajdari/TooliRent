using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooliRent.Domain.Enums
{
    public enum ToolStatus
    {
        Available = 0,
        Reserved = 1,
        CheckedOut = 2,
        Maintenance = 3,
        Retired = 4
    }
}

