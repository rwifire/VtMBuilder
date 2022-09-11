using System.ComponentModel.DataAnnotations;

namespace VtMBuilder.DataAccess.Entities;

public class DisciplinePower
{
  [Key] public int Id { get; set; }
  [Required] public DisciplineDefinition Discipline { get; set; }
  [Required] public string Name { get; set; }
  [Required] public string Description { get; set; }
}