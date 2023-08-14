namespace OctoDo.Server.Domain.Entities;
public class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool Enabled { get; set; }  = true;
}
