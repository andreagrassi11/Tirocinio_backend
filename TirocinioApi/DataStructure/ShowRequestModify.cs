using System;
namespace TirocinioApi.DataStructure;

public class ShowRequestModify
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int Duration { get; set; }
}

