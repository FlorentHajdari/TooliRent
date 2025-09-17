using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooliRent.Domain.Enums;

namespace TooliRent.Domain.Entities
{
    public class Tool
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Brand { get; set; }
        public ToolStatus Status { get; set; } = ToolStatus.Available;
        public string? InventoryCode { get; set; }

        // Foreign key + navigation
        public Guid CategoryId { get; set; }
        public ToolCategory Category { get; set; } = default!;
    }
}

