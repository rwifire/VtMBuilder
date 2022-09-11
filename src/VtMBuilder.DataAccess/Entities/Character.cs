using System.ComponentModel.DataAnnotations;

namespace VtMBuilder.DataAccess.Entities;

public class Character
{
  [Key] public int Id { get; set; }

  [Required] public string Name { get; set; }

  [Required] public Edition Edition { get; set; }

  [Required] public Clan Clan { get; set; }

  [Required] public List<Discipline> Disciplines { get; set; }
}