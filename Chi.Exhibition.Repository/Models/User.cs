using System;
using System.Collections.Generic;

namespace Chi.Exhibition.Repository.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? RefreshToken { get; set; }

    public string? Role { get; set; }
}
