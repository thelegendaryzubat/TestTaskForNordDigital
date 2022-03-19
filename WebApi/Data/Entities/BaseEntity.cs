using System.ComponentModel.DataAnnotations;

namespace WebApi.Data;

public class BaseEntity<TPrimaryKey> where TPrimaryKey : struct
{
    [Key]
    [Required]
    public TPrimaryKey Id { get; set; }
}