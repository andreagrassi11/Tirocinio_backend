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

public class QuestionController : ControllerBase
{
    private readonly ApiContext _context;

    public QuestionController(ApiContext context)
    {
        _context = context;
    }

    //Get whit specific Id
    [HttpGet("TakeQuestionRelShow/{showId:int}"), Authorize]
    public IActionResult TakeQuestionRelShow(int showId)
    {
        var result = _context.Question
                .Where(q => q.FK_Show == showId)
                .OrderBy(q => q.Id)
                .ToList();

        return new JsonResult(Ok(result));
    }

    [HttpGet("TakeQuestion/{id:int}"), Authorize]
    public IActionResult TakeQuestion(int id)
    {
        var result = _context.Question.Find(id);

        if (result == null)
            return NotFound();

        return new JsonResult(Ok(result));
    }

    //Create new show
    [HttpPost, Authorize]
    public IActionResult CreateQuestion(QuestionRequest question)
    {
        Question castQuestion = new Question
        {
            Text = question.Text,
            FK_Show = question.FK_Show
        };

        _context.Question.Add(castQuestion);
        _context.SaveChanges();

        int newQuestionId = castQuestion.Id;

        return new JsonResult(Ok(newQuestionId));
    }

    [HttpPut, Authorize]
    public IActionResult EditQuestion(QuestionRequestModify question)
    {
        var questionDb = _context.Question.Find(question.Id);

        if (questionDb == null)
            return NotFound();

        questionDb.Text = question.Text;

        _context.SaveChanges();

        return new JsonResult(Ok(questionDb));
    }

    [HttpDelete("{id:int}"), Authorize]
    public IActionResult DeleteQuestion(int id)
    {
        var questionDb = _context.Question.Find(id);

        if (questionDb == null)
            return NotFound();

        _context.Question.Remove(questionDb);
        _context.SaveChanges();

        return new JsonResult(NoContent());
    }
}

