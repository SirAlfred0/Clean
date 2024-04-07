using Clean.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clean.Infrastructure.Persistence;

internal class CleanDbContext(DbContextOptions<CleanDbContext> options) : DbContext(options)
{
    internal DbSet<Employment> Employments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employment>().Property(e => e.Id).HasConversion<long>();
    }
}
