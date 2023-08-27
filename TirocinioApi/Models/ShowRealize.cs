using System;
namespace TirocinioApi.Models;

public class ShowRealize
{
    public int Id { get; set; }
    public string Place { get; set; } = null!;
    public DateTime Date { get; set; }
    public bool Do { get; set; }
    public int FK_Show { get; set; }
}

