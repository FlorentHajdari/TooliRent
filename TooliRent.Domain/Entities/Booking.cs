using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooliRent.Domain.Enums;

namespace TooliRent.Domain.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public DateTime StartUtc { get; set; }
        public DateTime EndUtc { get; set; }
        public BookingStatus Status { get; set; } = BookingStatus.Confirmed;

        // Navigation
        public ICollection<BookingItem> Items { get; set; } = new List<BookingItem>();
    }
}

