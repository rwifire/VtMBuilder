using System.ComponentModel.DataAnnotations;

namespace VtMBuilder.DataAccess.Entities;

public class DisciplineDefinition
{
  [Key]
  public int Id { get; set; }
  
  [Required]
  public string Name { get; set; }
  
  [Required]
  public Edition Edition { get; set; }
}