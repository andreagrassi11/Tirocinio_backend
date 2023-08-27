using System;
namespace TirocinioApi.Models;

public class UserShow
{
    public int Id { get; set; }
    public string Email { get; set; } = null!;
    public int FK_ShowRealize { get; set; }
    public bool Privacy { get; set; }
}

