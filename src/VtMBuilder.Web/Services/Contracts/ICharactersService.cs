using VtMBuilder.Contract;

namespace VtMBuilder.Web.Services.Contracts;

public interface ICharactersService
{
  Task<IEnumerable<CharacterDto>> GetCharacters();

}