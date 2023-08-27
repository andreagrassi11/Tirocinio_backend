using System;
namespace TirocinioApi.DataStructure;

public class ShowRelRequest
{
    public string Place { get; set; } = null!;
    public string Date { get; set; } = null!;
    public int FK_Show { get; set; }
}

