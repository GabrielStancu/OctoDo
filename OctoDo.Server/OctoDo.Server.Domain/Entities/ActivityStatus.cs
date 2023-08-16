namespace OctoDo.Server.Domain.Entities;
public class ActivityStatus
{
    public Guid ActivityId { get; set; }
    public bool Completed { get; set; }
}
