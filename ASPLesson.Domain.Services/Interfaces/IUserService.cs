using ASPLesson.Domain.Entity;
using System.Threading.Tasks;

namespace ASPLesson.Domain.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> AddUser(string name);
    }
}
