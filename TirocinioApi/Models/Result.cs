using System;
using TirocinioApi.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TirocinioApi.Models;

public class Result
{
    public int Id { get; set; }
    public int IdShowRealized { get; set; }
    public int IdUserShow { get; set; }
    public int IdQuestionResult { get; set; }
    public int IdAnswerResult { get; set; }
    public DateTime Data { get; set; }
}

