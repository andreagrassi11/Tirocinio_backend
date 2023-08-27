using System;
namespace TirocinioApi.Models;

public class QuestionResult
{
    public int Id { get; set; }
    public string Text { get; set; } = null!;
    public int FK_ShowRealize { get; set; }
}