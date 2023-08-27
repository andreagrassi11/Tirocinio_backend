using System;
namespace TirocinioApi.DataStructure;

public class AuthRequest
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}


