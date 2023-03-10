using OctoDo.Domain.Models;

namespace OctoDo.Persistence.DTOs;

public class ActivityDto : ModelBase
{
    public int? Points { get; set; }
    public int? PlanId { get; set; }

    public bool IsDisabled { get; set; }
}
