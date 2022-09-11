using Microsoft.AspNetCore.Components;
using VtMBuilder.Contract;
using VtMBuilder.Web.Services.Contracts;

namespace VtMBuilder.Web.Components;

public abstract class CharactersBase : ComponentBase
{
  [Inject]
  public ICharactersService CharacterService { get; set; }
  
  public IEnumerable<CharacterDto>? Characters { get; set; }

  protected override async Task OnInitializedAsync()
  {
    Characters = await CharacterService.GetCharacters();
  }
  
}