using Microsoft.AspNetCore.Components;
using VtMBuilder.Contract;
using VtMBuilder.DataAccess.Entities;
using VtMBuilder.Web.Models;

namespace VtMBuilder.Web.Components;

public class CharacterBase : ComponentBase
{
  [Parameter]
  public CharacterV5 Character { get; set; } = null!;

  public ICollection<ClanDto> Clans { get; set; } = new List<ClanDto>();


  protected override void OnInitialized()
  {
    Clans.Add(new ClanDto()
    {
      Name = "Gangrel",
      Edition = Edition.V5,
    });
    
    Clans.Add(new ClanDto()
    {
      Name = "Malkavian",
      Edition = Edition.V5,
    });
  }
  
  protected void ClanSelectChanged(ChangeEventArgs e)
  {
    Character.Clan = Clans.First(c => c.Name == (string) e.Value!);
  }
}