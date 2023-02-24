using Microsoft.EntityFrameworkCore;
using OctoDo.EntityFramework.DTOs;

namespace OctoDo.EntityFramework;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PlanDto> Plans => Set<PlanDto>();
    public DbSet<ActivityDto> Activities => Set<ActivityDto>();
    public DbSet<RoutineDto> Routines => Set<RoutineDto>();
    public DbSet<ToDoDto> ToDos => Set<ToDoDto>();
}