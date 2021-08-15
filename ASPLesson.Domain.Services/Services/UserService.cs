using ASPLesson.Domain.Entity;
using ASPLesson.Domain.Interfaces.Interfaces;
using ASPLesson.Domain.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace ASPLesson.Domain.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AddUser(string name)
        {
            var user = await _userRepository.GetByName(name);

            if (user == null)
            {
                user = new User
                {
                    Name = name,
                    Age = new Random().Next(1, 120)
                };

                await _userRepository.Insert(user);

                return user;
            }

            return null;
        }
    }
}
