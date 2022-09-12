using VtMBuilder.Contract;

namespace VtMBuilder.Web.Models;

public class CharacterV5
{
  public string Name { get; set; }
  
  public string Chronicle { get; set; }
  
  public string Sire { get; set; }
  
  public string Concept { get; set; }
  
  public string Ambition { get; set; }
  
  public string Desire { get; set; }
  
  //TODO: Predator Type
  
  public ClanDto? Clan { get; set; }
  
  public int Generation { get; set; }
}