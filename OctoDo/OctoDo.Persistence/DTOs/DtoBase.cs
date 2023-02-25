using System.ComponentModel.DataAnnotations;
using SQLite;

namespace OctoDo.Persistence.DTOs;

public class DtoBase
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Description { get; set; }
}
