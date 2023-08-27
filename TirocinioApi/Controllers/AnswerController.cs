using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TirocinioApi.Data;
using TirocinioApi.DataStructure;
using TirocinioApi.Models;

namespace TirocinioApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class AnswerController : ControllerBase
{
    private readonly ApiContext _context;

    public AnswerController(ApiContext context)
    {
        _context = context;
    }

    //Get whit specific Id
    [HttpGet("TakeAnswer/{id:int}"), Authorize]
    public IActionResult TakeAnswer(int id)
    {
        var result = _context.Answer.Find(id);

        if (result == null)
            return NotFound();

        return new JsonResult(Ok(result));
    }

    //Get All for User
    [HttpGet("TakeAnswerRelQuestion/{questionId:int}"), Authorize]
    public IActionResult TakeAnswerRelQuestion(int questionId)
    {
        var result = _context.Answer
                .Where(a => a.FK_Question == questionId)
                .OrderBy(a => a.Id)
                .ToList();

        return new JsonResult(Ok(result));
    }

    [HttpPost, Authorize]
    public IActionResult CreateAnswer(AnswerRequest answer)
    {

        Answer castAnswer = new Answer
        {
            Description = answer.Description,
            FK_Question = answer.FK_Question
        };

        _context.Answer.Add(castAnswer);
        _context.SaveChanges();

        return new JsonResult(Ok(castAnswer));
    }

    [HttpPut, Authorize]
    public IActionResult EditAnswer(AnswerRequestModify answer)
    {
        var answerDb = _context.Answer.Find(answer.Id);

        if (answerDb == null)
            return NotFound();

        answerDb.Description = answer.Description;

        _context.SaveChanges();

        return new JsonResult(Ok(answerDb));
    }

    [HttpDelete("{id:int}"), Authorize]
    public IActionResult DeleteAnswer(int id)
    {
        var answerDb = _context.Answer.Find(id);

        if (answerDb == null)
            return NotFound();

        _context.Answer.Remove(answerDb);
        _context.SaveChanges();

        return new JsonResult(NoContent());
    }
}

