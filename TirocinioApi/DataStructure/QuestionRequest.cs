using System;
using TirocinioApi.Models;

namespace TirocinioApi.DataStructure;

public class QuestionRequest
{
    public string Text { get; set; } = null!;
    public int FK_Show { get; set; } 
}

