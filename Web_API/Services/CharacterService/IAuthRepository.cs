using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Services.CharacterService
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);

        Task<ServiceResponse<string>> Login(string username, string password);

        Task<bool> UserExists(string username);

    }
}
