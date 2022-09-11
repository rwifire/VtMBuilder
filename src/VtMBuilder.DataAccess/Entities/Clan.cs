using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics;

namespace VtMBuilder.DataAccess.Entities;

public class Clan
{
  [Key]
  public int Id { get; set; }
  
  [Required]
  public string Name { get; set; }

  [Required]
  public ICollection<DisciplineDefinition> Disciplines { get; set; }

  [Required]
  public Edition Edition { get; set; }
}