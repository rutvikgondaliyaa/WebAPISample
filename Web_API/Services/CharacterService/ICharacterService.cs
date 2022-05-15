using System.Collections.Generic;
using System.Threading.Tasks;
using Web_API.DTOS.Character;
using Web_API.Models;

namespace Web_API.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);

        Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();

        Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);

        Task<ServiceResponse<GetCharacterDTO>> UpdateCharacter(UpdateCharacterDTO updateCharacter);

        Task<ServiceResponse<List<GetCharacterDTO>>> DeleteCharacter(int id);

        //Task<ServiceResponse<List<GetCharacterDTO>>> AddChracterSkill(AddCharacterSkillDTO newCharacterSkill);

    }
}
