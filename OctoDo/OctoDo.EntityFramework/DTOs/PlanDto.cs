using OctoDo.Domain.Models;

namespace OctoDo.EntityFramework.DTOs;
public class PlanDto : ModelBase
{
    public IEnumerable<ActivityDto?>? Activities { get; set; }

    public IEnumerable<RoutineDto?>? Routines { get; set; }

    public bool IsActive { get; set; }
}
