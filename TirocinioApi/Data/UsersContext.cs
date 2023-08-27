using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TirocinioApi.Data;

public class UsersContext : IdentityUserContext<IdentityUser>
{
    public UsersContext(DbContextOptions<UsersContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=Iloveyou11");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}