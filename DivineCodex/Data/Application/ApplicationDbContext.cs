using DivineCodex.Data.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace DivineCodex.Data.Application;

internal class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }
    public DbSet<Question> Questions { get; set; }
}