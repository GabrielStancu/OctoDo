namespace OctoDo.Server.Domain.Entities;
public class Activity : BaseEntity
{
    public Guid RoutineId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Routine? Routine { get; set; }
}
