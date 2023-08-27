using System;
namespace TirocinioApi.Models;

public class AnswerResult
{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public int FK_QuestionResult { get; set; }
}

