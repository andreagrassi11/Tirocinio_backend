using System;
using TirocinioApi.Models;

namespace TirocinioApi.DataStructure;

public class UserShowRequest
{
    public string Email { get; set; } = null!;
    public int FK_ShowRealize { get; set; }
    public bool Privacy { get; set; }
}

