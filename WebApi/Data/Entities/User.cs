using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApi.Data.Entities;

public class User : BaseEntity<Guid>
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    [JsonIgnore]
    public List<Todo> Todos { get; set; } = new();
}