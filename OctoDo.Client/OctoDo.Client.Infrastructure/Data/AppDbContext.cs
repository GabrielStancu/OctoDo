using Microsoft.EntityFrameworkCore;
using OctoDo.Client.Core.Models;

namespace OctoDo.Client.Infrastructure.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Routine>? Routine { get; set; }
    public DbSet<Activity>? Activity { get; set; }
    public DbSet<Completion>? Completion { get; set; }
    public DbSet<ActivityStatus>? ActivityStatus { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Routine>()
            .HasMany(r => r.Activities)
            .WithOne(a => a.Routine);

        modelBuilder.Entity<Routine>()
            .HasMany(r => r.Completions)
            .WithOne(c => c.Routine);

        modelBuilder.Entity<Activity>()
            .HasMany(a => a.ActivityStatuses)
            .WithOne(s => s.Activity);

        modelBuilder.Entity<Completion>()
            .HasMany(c => c.ActivityStatuses)
            .WithOne(s => s.Completion);
    }
}
