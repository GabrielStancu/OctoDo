namespace OctoDo.Server.Domain.Entities;
public class Completion : BaseEntity
{
    public Guid UserId { get; set; }
    public DateTime Date { get; set; }
    public IEnumerable<ActivityStatus>? ActivityStatuses { get; set; }
}
