using System;
using TirocinioApi.Models;

namespace TirocinioApi.DataStructure;

public class QuestionRequestModify
{
    public int Id { get; set; }
    public string Text { get; set; } = null!;
}

