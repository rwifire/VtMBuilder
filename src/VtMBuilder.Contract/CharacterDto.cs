using VtMBuilder.DataAccess.Entities;

namespace VtMBuilder.Contract;

public class CharacterDto
{
  public Guid CharacterId { get; set; }
  
  public string Name { get; set; }
  
  public string ClanName { get; set; }
  
  public Guid ClanId { get; set; }
  
  public Edition Edition { get; set; }
}