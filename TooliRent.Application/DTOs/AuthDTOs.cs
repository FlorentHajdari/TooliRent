using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooliRent.Application.DTOs
{
    public record RegisterRequest(
        string Email,
        string Password,
        string FullName
    );

    public record LoginRequest(
        string Email,
        string Password
    );

    public record AuthResponse(
        string AccessToken,
        DateTime ExpiresUtc,
        string Role
    );
}

