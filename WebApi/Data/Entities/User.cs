using System.ComponentModel.DataAnnotations;

namespace WebApi.Data.Entities;

public class User : BaseEntity<Guid>
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    public List<Todo> Todos { get; set; } = new();
}