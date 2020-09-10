using System.Threading.Tasks;
using GameAndChillAPI.Models;

namespace GameAndChillAPI.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

    }
}