using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chi.Exhibition.Repository.Models;

public partial class UserEntity
{
    [Key]
    public string UserId { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? RefreshToken { get; set; }

    public string? Role { get; set; }
}
