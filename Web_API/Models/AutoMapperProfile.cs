using AutoMapper;
using Web_API.DTOS.Character;
using Web_API.DTOS.Skill;
using Web_API.DTOS.Wepon;

namespace Web_API.Models
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDTO>();
            CreateMap<AddCharacterDTO, Character>();
            CreateMap<Weapon, GetWeponDTO>();
            CreateMap<Skill,GetSkillDTO>();
        }
    }
}
