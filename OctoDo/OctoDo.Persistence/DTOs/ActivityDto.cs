using OctoDo.Domain.Models;

namespace OctoDo.Persistence.DTOs;

public class ActivityDto : ModelBase
{
    public int? Points { get; set; }

    //public PlanDto? Plan { get; set; }
    public int? PlanId { get; set; }

    //public IEnumerable<ToDoDto?>? ToDos { get; set; }

    public bool IsDisabled { get; set; }
}
