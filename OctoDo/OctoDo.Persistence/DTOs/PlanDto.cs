using OctoDo.Domain.Models;

namespace OctoDo.Persistence.DTOs;
public class PlanDto : ModelBase
{
    //public IEnumerable<ActivityDto?>? Activities { get; set; }

    //public IEnumerable<RoutineDto?>? Routines { get; set; }

    public bool IsDisabled { get; set; }
}
