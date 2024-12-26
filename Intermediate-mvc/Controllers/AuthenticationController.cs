using Intermediate_mvc.Models.CurrentUser;
using Intermediate_mvc.Models.Entities;
using Intermediate_mvc.Models.Interfaces;
using Intermediate_mvc.Models.Service;
using Microsoft.AspNetCore.Mvc;

namespace Intermediate_mvc.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            IUserServices userServices = new UserServices();
            var user = userServices.GetAll();

            return View(user);
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserRegister(string name, string lastName, string password)
        {
            IUserServices userServices = new UserServices();
            userServices.Add(name, lastName, password);

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin(string name, string password)
        {

            IUserServices userServices = new UserServices();
            userServices.Login(name, password);
            return RedirectToAction("Index");

        }
    }
}
