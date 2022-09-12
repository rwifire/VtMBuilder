using VtMBuilder.DataAccess.Entities;

namespace VtMBuilder.Contract;

public class ClanDto
{
  public string Name { get; set; }
  
  public List<DisciplineDefinitionDto> Disciplines { get; set; }
  
  public Edition Edition { get; set; }
}