using System;
namespace TirocinioApi.Models;

public class Answer
{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public int FK_Question { get; set; }
}

