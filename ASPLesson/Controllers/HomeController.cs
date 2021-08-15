using ASPLesson.Domain.Services.Interfaces;
using ASPLesson.ViewModels.EntityViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPLesson.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CreateUser() => View();

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                //await _userService.AddUser(model.Name);

                return RedirectToAction("GetAllUsers", "Account");
            }

            return View();
        }


        public bool CheckNumberCard(string numberCard)
        {
            if (string.IsNullOrWhiteSpace(numberCard))
            {
                ModelState.AddModelError("Ошибка", "Имя не должно быть пустым");
            }

            // 4546 5432 5443 4554
            if (numberCard.Length == 19)
            {
                return true;
            }
            return false;
        }

        #region #5

        [HttpGet]
        public IActionResult CalculateInView()
        {
            ViewBag.ProgrammingLanguages = new List<string>() { "C#", "Java", "Python" };
            ViewData["ProgrammingLanguages2"] = new List<string> { "C++", "Pascal", "C" };

            return View();
        }

        #endregion
    }
}
