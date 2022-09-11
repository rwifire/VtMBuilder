using System.Net.Http.Json;
using VtMBuilder.Contract;
using VtMBuilder.Web.Services.Contracts;

namespace VtMBuilder.Web.Services;

public class CharactersService : ICharactersService
{
  private readonly HttpClient _httpClient;

  public CharactersService(HttpClient httpClient)
  {
    _httpClient = httpClient;
  }

  public async Task<IEnumerable<CharacterDto>> GetCharacters()
  {
    try
    {
      var characters = await _httpClient.GetFromJsonAsync<IEnumerable<CharacterDto>>("characters");
      return characters ?? new List<CharacterDto>();
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
  }
}