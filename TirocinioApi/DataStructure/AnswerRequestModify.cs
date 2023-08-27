using System;
using TirocinioApi.Models;

namespace TirocinioApi.DataStructure;

public class AnswerRequestModify
{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
}

