using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TirocinioApi.Models;

namespace TirocinioApi.Data;

public class ApiContext : DbContext
{
    public DbSet<Show> Show { get; set; }
    public DbSet<Question> Question { get; set; }
    public DbSet<Answer> Answer { get; set; }

    public DbSet<ShowRealize> ShowRealize { get; set; }
    public DbSet<QuestionResult> QuestionResult { get; set; }
    public DbSet<AnswerResult> AnswerResult { get; set; }
    public DbSet<Result> Result { get; set; }
    public DbSet<UserShow> UserShow { get; set; }


    public ApiContext(DbContextOptions<ApiContext> options) : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=Iloveyou11");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}


