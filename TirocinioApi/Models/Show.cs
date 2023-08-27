using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace TirocinioApi.Models;

public class Show
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int Duration { get; set; }
    public string CoverImage { get; set; }
    public string UserId { get; set; }

    public Show(int Id)
    {
        this.Id = Id;
    }

    public Show()
    {
    }

    public Show(string Title, int Duration, string CoverImage, string UserId)
    {
        this.Title = Title;
        this.Duration = Duration;
        this.CoverImage = CoverImage;
        this.UserId = UserId;
    }
}


