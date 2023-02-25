using OctoDo.Domain.Models;

namespace OctoDo.Persistence.DTOs;
public class RoutineDto : ModelBase
{
    public DateTime? Date { get; set; }

    //public PlanDto? Plan { get; set; }
    public int? PlanId { get; set; }

    //public IEnumerable<ActivityDto?>? Activities { get; set; }
}
