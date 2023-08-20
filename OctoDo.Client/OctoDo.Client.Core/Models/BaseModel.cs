namespace OctoDo.Client.Core.Models;
public class BaseModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool Disabled { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
