namespace OctoDo.Domain.Models;

public class Activity : ModelBase
{
    public int? Points { get; set; }
    public int PlanId { get; set; }
    public bool IsDisabled { get; set; }
}
