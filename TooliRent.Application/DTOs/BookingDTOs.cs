using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooliRent.Application.DTOs
{
    public record BookingCreateDto(
        DateTime StartUtc,
        DateTime EndUtc,
        IList<Guid> ToolIds
    );

    public record BookingDto(
        Guid Id,
        DateTime StartUtc,
        DateTime EndUtc,
        string Status,
        IList<BookingItemDto> Items
    );

    public record BookingItemDto(
        Guid ToolId,
        string ToolName,
        DateTime? PickedUpUtc,
        DateTime? ReturnedUtc,
        bool IsOverdue
    );
}

