using OctoDo.Domain.Models;

namespace OctoDo.EntityFramework.DTOs;

public class ActivityDto : ModelBase
{
    public int? Points { get; set; }

    public PlanDto? Plan { get; set; }

    public IEnumerable<ToDoDto?>? ToDos { get; set; }

    public bool Disabled { get; set; }
}
