using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TooliRent.Infrastructure.Auth
{
    public class AppUser : IdentityUser<Guid>
    {
        public bool IsActive { get; set; } = true;
        public string? FullName { get; set; }
    }
}

