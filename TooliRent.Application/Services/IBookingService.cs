using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooliRent.Application.DTOs;

namespace TooliRent.Application.Services
{
    public interface IBookingService
    {
        Task<Guid> CreateAsync(Guid memberId, BookingCreateDto dto);
        Task<BookingDto?> GetAsync(Guid id, Guid requesterId, bool isAdmin);
        Task<IReadOnlyList<BookingDto>> MyBookingsAsync(Guid memberId);
        Task CancelAsync(Guid id, Guid requesterId, bool isAdmin);
        Task PickUpAsync(Guid bookingId, Guid toolId);
        Task ReturnAsync(Guid bookingId, Guid toolId);
        Task<int> MarkOverduesAsync(DateTime nowUtc);
    }
}

