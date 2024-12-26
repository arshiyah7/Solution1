using Intermediate_mvc.Models.Entities;
using Intermediate_mvc.Models.Interfaces;
using Intermediate_mvc.Models.Repository;
using Intermediate_mvc.Models.Service;
using Microsoft.AspNetCore.Mvc;

namespace Intermediate_mvc.Controllers
{
    public class ShopController : Controller
    {

        public IActionResult Index()
        {
           IProductServices productServices = new ProductService();
            var service = productServices.GetAll();
            return View(service);
        }
    }
}
