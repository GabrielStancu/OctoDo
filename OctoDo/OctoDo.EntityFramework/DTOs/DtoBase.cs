using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace OctoDo.EntityFramework.DTOs;

public class DtoBase
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Description { get; set; }
}
