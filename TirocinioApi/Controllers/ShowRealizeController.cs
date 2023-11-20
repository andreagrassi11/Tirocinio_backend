using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TirocinioApi.Models;
using TirocinioApi.Data;
using TirocinioApi.DataStructure;
using Azure.Core;
using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace TirocinioApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ShowRealizeController : ControllerBase
{
    private readonly ApiContext _context;

    public ShowRealizeController(ApiContext context)
    {
        _context = context;
    }

    //Get whit specific Id
    [HttpGet("{id:int}"), Authorize]
    public IActionResult TakeShowRealize(int id)
    {
        var result = _context.ShowRealize.Find(id);

        if (result == null)
        {
            return NotFound();
        }

        return new JsonResult(Ok(result));
    }

    //Get All for User
    [HttpGet("{UserId}"), Authorize]
    public IActionResult TakeAllShowRealize(string UserId)
    {
        var shows = _context.Show
                .Where(s => s.UserId == UserId)
                .ToList();

        List<CombinedShowData> combinedData = new List<CombinedShowData>();

        foreach (var show in shows)
        {
            var result = _context.ShowRealize
                .Where(u => u.FK_Show == show.Id)
                .ToList();

            if(result.Count != 0)
            {
                combinedData.Add(new CombinedShowData
                {
                    Show = show,
                    ShowRealizeList = result
                });
            }
        }

        if (combinedData == null)
        {
            return NotFound();
        }

        return new JsonResult(Ok(combinedData));
    }
    
    //Create new show
    [HttpPost, Authorize]
    public IActionResult CreateShowRel(ShowRelRequest showRel)
    {
        string inputDateString = showRel.Date;
        Console.WriteLine(inputDateString);
        DateTime parsedDateTime = DateTime.ParseExact(inputDateString, "yyyy-MM-dd", null);
        DateTime utcDateTime = DateTime.SpecifyKind(parsedDateTime, DateTimeKind.Utc);

        ShowRealize castshow = new ShowRealize
        {
            Place = showRel.Place,
            Date = utcDateTime,
            Do = false,
            FK_Show = showRel.FK_Show
        };

        _context.ShowRealize.Add(castshow);
        _context.SaveChanges();

        return new JsonResult(Ok(castshow));
    }

    [HttpPut("{showResId}"), Authorize]
    public IActionResult EditShowRel(int showResId)
    {
        var showDb = _context.ShowRealize.Find(showResId);

        if (showDb == null)
        {
            return NotFound();
        }

        showDb.Do = true;
        _context.SaveChanges();

        return new JsonResult(Ok(showDb));
    }

}

public class CombinedShowData
{
    public Show Show { get; set; }
    public List<ShowRealize> ShowRealizeList { get; set; }
}