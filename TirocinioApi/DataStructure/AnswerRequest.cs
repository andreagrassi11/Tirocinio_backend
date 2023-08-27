using System;
using TirocinioApi.Models;

namespace TirocinioApi.DataStructure;

public class AnswerResultRequest
{
    public string Description { get; set; } = null!;
    public int FK_QuestionResult { get; set; }
}

