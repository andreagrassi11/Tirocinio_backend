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

public class QuestionResultController : ControllerBase
{
    private readonly ApiContext _context;

    public QuestionResultController(ApiContext context)
    {
        _context = context;
    }

    //Get whit specific Id
    [HttpGet("TakeQuestionRelShow/{showId:int}"), Authorize]
    public IActionResult TakeQuestionResultShowRel(int showId)
    {
        var result = _context.QuestionResult
                .Where(q => q.FK_ShowRealize == showId)
                .OrderBy(q => q.Id)
                .ToList();

        return new JsonResult(Ok(result));
    }

    [HttpGet("TakeQuestion/{id:int}"), Authorize]
    public IActionResult TakeQuestionResult(int id)
    {
        var result = _context.QuestionResult.Find(id);

        if (result == null)
            return NotFound();

        return new JsonResult(Ok(result));
    }

    //Create new show
    [HttpPost, Authorize]
    public IActionResult CreateQuestionResult(QuestionResultRequest question)
    {
        QuestionResult castQuestion = new QuestionResult
        {
            Text = question.Text,
            FK_ShowRealize = question.FK_ShowReal
        };

        _context.QuestionResult.Add(castQuestion);
        _context.SaveChanges();

        return new JsonResult(Ok(castQuestion));
    }
}

