using ASPLesson.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPLesson.Domain.Interfaces.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Insert(User user);
        Task<User> Get(int id);

        Task<User> GetByName(string name);

        Task<IEnumerable<User>> Select();
    }
}
