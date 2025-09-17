using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooliRent.Domain.Entities
{
    public class BookingItem
    {
        public Guid Id { get; set; }

        // Foreign keys
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; } = default!;

        public Guid ToolId { get; set; }
        public Tool Tool { get; set; } = default!;

        public DateTime? PickedUpUtc { get; set; }
        public DateTime? ReturnedUtc { get; set; }
        public bool IsOverdue { get; set; }
    }
}

