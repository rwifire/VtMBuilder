using Microsoft.AspNetCore.Components;
using VtMBuilder.Contract;

namespace VtMBuilder.Web.Components;

public class DisplayCharactersBase : ComponentBase
{
  [Parameter]
  public IEnumerable<CharacterDto> Characters { get; set; } = null!;
}