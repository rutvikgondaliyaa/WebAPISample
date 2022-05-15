using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_API.Data;
using Web_API.DTOS.Character;
using Web_API.DTOS.Wepon;
using Web_API.Migrations;
using Web_API.Models;

namespace Web_API.Services.WeponService
{
    public class WeponService : IWeponService
    {
        private readonly DataContext _context;
        private readonly HttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public WeponService(DataContext context, HttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<GetCharacterDTO>> AddWepon(AddWeaponDTO newWepon)
        {
            var response = new ServiceResponse<GetCharacterDTO>();
            try
            {
                var character =  _context.Characters.FirstOrDefault(c => c.Id == newWepon.CharacterId &&
                        c.User.Id == int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)));
                if (character == null)
                {
                    response.Success = false;
                    response.Message = "Character not found";
                    return response;
                }
                var Wepon = new Weapon
                {
                    Name = newWepon.Name,
                    Damage = newWepon.Damage,
                    Character = character,
                };
                _context.Weapons.Add(Wepon);
                await _context.SaveChangesAsync();

                response.Data = _mapper.Map<GetCharacterDTO>(character);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
