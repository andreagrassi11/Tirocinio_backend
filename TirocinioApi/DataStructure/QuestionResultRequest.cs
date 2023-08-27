using System;
using TirocinioApi.Models;

namespace TirocinioApi.DataStructure;

public class QuestionResultRequest
{
    public string Text { get; set; } = null!;
    public int FK_ShowReal { get; set; } 
}

