using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Data;

public class BaseEntity<TPrimaryKey> where TPrimaryKey : struct
{
    [Key]
    [Required]
    [Column("id")]
    public TPrimaryKey Id { get; set; }
}