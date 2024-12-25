using Intermediate_mvc.Models.Entities;
using Intermediate_mvc.Models.Interfaces;
using Intermediate_mvc.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Intermediate_mvc.Controllers
{
    public class ShopContoroller : Controller
    {
        
        public IActionResult Index()
        {
            //IProductRepository rep = new ProductRepository();
            //List<Product> products = rep.GetAll();
            return View();
        }
    }
}
