using DivineCodex.Data.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace DivineCodex.Data.Application;

internal class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<AnswerVote> AnswerVotes { get; set; }
    public DbSet<Badge> Badges { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Reputation> Reputations { get; set; }

}