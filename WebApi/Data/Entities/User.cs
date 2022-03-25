using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApi.Data.Entities;

public class User : BaseEntity<Guid>
{
    [Required]
    [Column("username")]
    public string UserName { get; set; }
    [Required]
    [Column("password")]
    public string Password { get; set; }
    [JsonIgnore]
    public List<Todo> Todos { get; set; } = new();
}