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

public class AnswerResultController : ControllerBase
{
    private readonly ApiContext _context;

    public AnswerResultController(ApiContext context)
    {
        _context = context;
    }

    //Get whit specific Id
    [HttpGet("{QuestionRelId:int}"), Authorize]
    public IActionResult TakeAnswerResultShowRel(int QuestionRelId)
    {
        var result = _context.AnswerResult
                .Where(q => q.FK_QuestionResult == QuestionRelId)
                .OrderBy(q => q.Id)
                .ToList();

        return new JsonResult(Ok(result));
    }

    //Create new show
    [HttpPost, Authorize]
    public IActionResult CreateAnswerResult(AnswerResultRequest answer)
    {
        AnswerResult castAnswer = new AnswerResult
        {
            Description = answer.Description,
            FK_QuestionResult = answer.FK_QuestionResult
        };

        _context.AnswerResult.Add(castAnswer);
        _context.SaveChanges();

        return new JsonResult(Ok(castAnswer));
    }
}

