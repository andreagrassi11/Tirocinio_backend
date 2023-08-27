using System;
using TirocinioApi.Models;

namespace TirocinioApi.DataStructure;

public class AnswerRequest
{
    public string Description { get; set; } = null!;
    public int FK_Question { get; set; }
}

