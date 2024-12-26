using Intermediate_mvc.Models.Interfaces;
using Intermediate_mvc.Models.Service;
using Microsoft.AspNetCore.Mvc;

namespace Intermediate_mvc.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            ICategoryServices categoryServices = new CategoryService();
            var services = categoryServices.GetAll();
            return View(services);
        }
    }
}
