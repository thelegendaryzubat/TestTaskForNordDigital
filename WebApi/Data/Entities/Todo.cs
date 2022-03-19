using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Data;

public class Todo : BaseEntity<Guid>
{
    [Required]
    [MaxLength(256)]
    public string Title { get; set; }
    
    [Required]
    public Guid UserId { get; set; }
}