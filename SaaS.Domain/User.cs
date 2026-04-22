using System;
using System.Collections.Generic;
using System.Text;

public class User : BaseEntity
{
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; } // Admin
}
