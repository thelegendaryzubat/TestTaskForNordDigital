using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace WebApi.Data.Entities;

public class Todo : BaseEntity<Guid>
{
    [Required]
    [Column("title")]
    [MaxLength(256)]
    public string Title { get; set; }
    
    [Required]
    [Column("userid")]
    public Guid UserId { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(UserId))]
    public User User { get; set; }
}