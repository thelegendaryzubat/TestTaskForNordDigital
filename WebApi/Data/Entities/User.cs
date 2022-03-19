using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Data;

public class User : BaseEntity<Guid>
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    public List<Todo> Todos { get; set; } = new();
}