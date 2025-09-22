using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooliRent.Domain.Enums;

namespace TooliRent.Application.DTOs
{
    public record ToolDto(
        Guid Id,
        string Name,
        string? Brand,
        string Category,
        ToolStatus Status,
        string? InventoryCode
    );

    public record ToolCreateDto(
        string Name,
        string? Brand,
        Guid CategoryId,
        string? InventoryCode
    );

    public record ToolUpdateDto(
        string Name,
        string? Brand,
        Guid CategoryId,
        ToolStatus Status,
        string? InventoryCode
    );

    public record CategoryDto(
        Guid Id,
        string Name,
        string? Description
    );

    public record CategoryCreateDto(
        string Name,
        string? Description
    );
}
