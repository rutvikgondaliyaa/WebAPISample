using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web_API.DTOS.Character;
using Web_API.DTOS.Wepon;
using Web_API.Models;
using Web_API.Services.WeponService;

namespace Web_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[Controller]")]
    public class WeponController : Controller
    {
        private readonly IWeponService _weponService;

        public WeponController(IWeponService weponService)
        {
            _weponService = weponService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> AddWepon(AddWeaponDTO newWepon)
        {
            return Ok(await _weponService.AddWepon(newWepon));
        }
    }
}
