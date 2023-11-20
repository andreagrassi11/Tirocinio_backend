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

public class UserShowController : ControllerBase
{
    private readonly ApiContext _context;

    public UserShowController(ApiContext context)
    {
        _context = context;
    }

    //Get All for User
    [HttpGet("{ShowRealizeId}"), Authorize]
    public IActionResult TakeAllUserShow(int ShowRealizeId)
    {
        var result = _context.UserShow
                .Where(s => s.FK_ShowRealize == ShowRealizeId)
                .ToList();

        if (result == null)
        {
            return NotFound();
        }

        return new JsonResult(Ok(result));
    }
    
    //Create new show
    [HttpPost]
    public IActionResult CreateUserShow(UserShowRequest user)
    {
        UserShow castuser = new UserShow
        {
            Email = user.Email,
            FK_ShowRealize = user.FK_ShowRealize,
            Privacy = user.Privacy
        };

        _context.UserShow.Add(castuser);
        _context.SaveChanges();

        return new JsonResult(Ok(castuser));
    }
}

