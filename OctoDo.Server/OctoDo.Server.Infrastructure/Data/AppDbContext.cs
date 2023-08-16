using Microsoft.EntityFrameworkCore;
using OctoDo.Server.Domain.Entities;

namespace OctoDo.Server.Infrastructure.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Activity>? Activity { get; set; }
    public DbSet<Routine>? Routine { get; set; }
    public DbSet<User>? User { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(u => u.Routines)
            .WithOne(r => r.User)
            .IsRequired();

        modelBuilder.Entity<Routine>()
            .HasMany(r => r.Activities)
            .WithOne(a => a.Routine)
            .IsRequired();
    }
}
