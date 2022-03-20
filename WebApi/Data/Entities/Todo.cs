using System.ComponentModel.DataAnnotations;

namespace WebApi.Data.Entities;

public class Todo : BaseEntity<Guid>
{
    [Required]
    [MaxLength(256)]
    public string Title { get; set; }
    
    [Required]
    public Guid UserId { get; set; }
}