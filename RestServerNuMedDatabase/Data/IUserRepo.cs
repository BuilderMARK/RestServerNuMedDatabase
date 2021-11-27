using System.Threading.Tasks;

namespace Database4Adult1.Domain
{
    public interface IUserRepo
    {
        Task<User> ValidateUser(string username, string password);

    }
}