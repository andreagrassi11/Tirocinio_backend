using System;
namespace TirocinioApi.DataStructure;

public class ShowRequest
{
    public string Title { get; set; } = null!;
    public int Duration { get; set; }
    public string CoverImage { get; set; } = null!;
    public string UserId { get; set; } = null!;
}

