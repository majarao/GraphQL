using GraphQL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }

    public DbSet<Pessoa> Pessoas { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Pessoa>().HasKey(p => p.Id);
    }
}
