using System.Collections.Generic;
using System.Threading.Tasks;
using Web_API.DTOS.Fight;
using Web_API.Models;

namespace Web_API.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDTO>> WeaponAttack(OneWeaponAttackDTO request);
        Task<ServiceResponse<AttackResultDTO>> SkillAttack(SkillAttackDTO request);
        Task<ServiceResponse<AttackResultDTO>> Fight(FightRequestDTO request);
        Task<ServiceResponse<List<HighScoreDTO>>> GetHighScore();
    
    }
}
