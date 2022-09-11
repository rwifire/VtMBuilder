using Microsoft.AspNetCore.Mvc;
using VtMBuilder.Contract;
using VtMBuilder.DataAccess.Entities;

namespace VtMBuilder.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CharactersController : ControllerBase
{
  [HttpGet]
  [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CharacterDto>))]
  public async Task<IActionResult> GetCharacters()
  {
    List<CharacterDto> characters = new List<CharacterDto>();
    var sampleClans = new[]
    {
      "Ventrue", "Brujah", "Malkavian", "Tremere", "Gangrel"
    };
    var sampleNames = new[]
    {
      "Henry", "Mark", "Steven", "Maria", "Julia"
    };
    var sampleSurNames = new[]
    {
      "Miller", "Wander", "Osler", "Rodgers", "Rodrigues"
    };
    
    for (int i = 0; i < 15; i++)
    {
      characters.Add(new CharacterDto()
      {
        CharacterId = Guid.NewGuid(),
        Name = sampleNames[new Random().Next(5)] + " " + sampleSurNames[new Random().Next(5)],
        ClanId = Guid.NewGuid(),
        ClanName = sampleClans[new Random().Next(5)],
        Edition = Edition.V5
      });
    }

    return new OkObjectResult(characters);
  }
}