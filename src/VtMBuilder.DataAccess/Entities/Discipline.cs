using System.ComponentModel.DataAnnotations;

namespace VtMBuilder.DataAccess.Entities;

public class Discipline
{
  [Key]
  public int Id { get; set; }
  
  [Required]
  public DisciplineDefinition DisciplineDefinition { get; set; }

  [Required]
  public List<DisciplinePower> Powers { get; set; }
}