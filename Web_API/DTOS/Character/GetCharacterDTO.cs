using System.Collections.Generic;
using Web_API.DTOS.Skill;
using Web_API.DTOS.Wepon;
using Web_API.Models;

namespace Web_API.DTOS.Character
{
    public class GetCharacterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Rutvik";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgEnumClass Class { get; set; } = RpgEnumClass.Kinght;

        public GetWeponDTO Wepon{ get; set; }
        public List<GetSkillDTO> Skills{ get; set; }
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }

    }
}
