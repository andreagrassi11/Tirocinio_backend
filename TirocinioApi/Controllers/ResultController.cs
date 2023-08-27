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

public class ResultController : ControllerBase
{
    private readonly ApiContext _context;

    public ResultController(ApiContext context)
    {
        _context = context;
    }

    //Get All for User
    [HttpGet("{IdShowRealized}/{IdQuestionResult}/{IdAnswerResult}"), Authorize]
    public IActionResult TakeAllResults(int IdShowRealized, int IdQuestionResult, int IdAnswerResult)
    {
        var result = _context.Result
                .Where(s => s.IdShowRealized == IdShowRealized
                    && s.IdQuestionResult == IdQuestionResult
                    && s.IdAnswerResult == IdAnswerResult)
                .OrderBy(s => s.IdAnswerResult)
                .ToList();

        if (result == null)
            return NotFound();

        return new JsonResult(Ok(result));
    }

    //Get All for User
    [HttpGet("{IdShowRealized}"), Authorize]
    public IActionResult TakeResultOfShow(int IdShowRealized)
    {
        var result = _context.Result
                .Where(s => s.IdShowRealized == IdShowRealized)
                .ToList();

        if (result == null)
            return NotFound();

        return new JsonResult(Ok(result));
    }
    
    //Create new result
    [HttpPost]
    public IActionResult CreateResult(ResultRequestCreate request)
    {
        Result castResult = new Result
        {
            IdShowRealized = request.IdShowRealized,
            IdUserShow = request.IdUserShow,
            IdQuestionResult = request.IdQuestionResult,
            IdAnswerResult = request.IdAnswerResult,
            Data = DateTime.UtcNow
        };

        _context.Result.Add(castResult);
        _context.SaveChanges();

        return new JsonResult(Ok(castResult));
    }
}

