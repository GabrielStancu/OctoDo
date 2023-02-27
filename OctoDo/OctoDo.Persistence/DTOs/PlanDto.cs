using OctoDo.Domain.Models;

namespace OctoDo.Persistence.DTOs;
public class PlanDto : ModelBase
{
    public bool IsDisabled { get; set; }

    public bool IsSelectedForToday { get; set; }
}
