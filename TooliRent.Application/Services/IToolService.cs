using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooliRent.Application.DTOs;

namespace TooliRent.Application.Services
{
    public interface IToolService
    {
        Task<IReadOnlyList<ToolDto>> ListAsync(string? category, string? status, bool? onlyAvailable);
        Task<ToolDto?> GetAsync(Guid id);
        Task<Guid> CreateAsync(ToolCreateDto dto);
        Task UpdateAsync(Guid id, ToolUpdateDto dto);
        Task DeleteAsync(Guid id);
    }
}

