using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TirocinioApi.Models;
using TirocinioApi.Data;
using TirocinioApi.DataStructure;
using Azure.Core;
using Microsoft.AspNetCore.Identity;

namespace TirocinioApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ShowController : ControllerBase
{
    private readonly ApiContext _context;

    public ShowController(ApiContext context)
    {
        _context = context;
    }

    //Get whit specific Id
    [HttpGet("{id:int}"), Authorize]
    public IActionResult TakeShow(int id)
    {
        var result = _context.Show.Find(id);

        if (result == null)
            return NotFound();

        return new JsonResult(Ok(result));
    }

    //Get All for User
    [HttpGet("{UserId}"), Authorize]
    public IActionResult TakeAllShowUser(string UserId)
    {
        var result = _context.Show
                .Where(s => s.UserId == UserId)
                .ToList();

        if (result == null)
            return NotFound();  

        return new JsonResult(Ok(result));
    }

    //Create new show
    [HttpPost, Authorize]
    public IActionResult CreateShow(ShowRequest show)
    {
        Show castshow = new Show
        {
            Title = show.Title,
            Duration = show.Duration,
            CoverImage = show.CoverImage,
            UserId = show.UserId
        };

        _context.Show.Add(castshow);
        _context.SaveChanges();

        int newShowId = castshow.Id;

        return new JsonResult(Ok(newShowId));
    }

    [HttpPut, Authorize]
    public IActionResult EditShow(ShowRequestModify show)
    {
        var showDb = _context.Show.Find(show.Id);

        if(showDb == null)
            return NotFound();

        showDb.Title = show.Title;
        showDb.Duration = show.Duration;

        _context.SaveChanges();

        return new JsonResult(Ok(showDb));
    }

    [HttpDelete("{id:int}"), Authorize]
    public IActionResult DeleteShow(int id)
    {
        var showDb = _context.Show.Find(id);

        if (showDb == null)
            return NotFound();

        _context.Show.Remove(showDb);
        _context.SaveChanges();

        return new JsonResult(NoContent());
    }
}

