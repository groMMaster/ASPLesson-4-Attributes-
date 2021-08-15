using ASPLesson.Domain.Interfaces.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ASPLesson.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userRepository.Get(id);
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            return View(await _userRepository.Select());
        }
    }
}
