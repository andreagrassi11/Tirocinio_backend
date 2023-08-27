using System;
namespace TirocinioApi.Models;

public class Question
{
    public int Id { get; set; }
    public string Text { get; set; } = null!;
    public int FK_Show { get; set; }

    public Question()
    {
    }
}