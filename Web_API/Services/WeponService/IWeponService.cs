using System.Threading.Tasks;
using Web_API.DTOS.Character;
using Web_API.DTOS.Wepon;
using Web_API.Models;

namespace Web_API.Services.WeponService
{
    public interface IWeponService
    {
        Task<ServiceResponse<GetCharacterDTO>> AddWepon(AddWeaponDTO newWepon);
    }
}
