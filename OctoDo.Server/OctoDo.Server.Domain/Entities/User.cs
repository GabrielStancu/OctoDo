namespace OctoDo.Server.Domain.Entities;
public class User : BaseEntity
{
    public string? Email { get; set; }
    public IEnumerable<Routine>? Routines { get; set; }
}
