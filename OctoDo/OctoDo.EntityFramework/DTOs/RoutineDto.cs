using OctoDo.Domain.Models;

namespace OctoDo.EntityFramework.DTOs;
public class RoutineDto : ModelBase
{
    public DateTime? Date { get; set; }

    public PlanDto? Plan { get; set; }

    public IEnumerable<ActivityDto?>? Activities { get; set; }
}
