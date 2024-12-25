using Intermediate_mvc.Models.DB;
using Intermediate_mvc.Models.Entities;
using Intermediate_mvc.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using System.Reflection.Metadata.Ecma335;

namespace Intermediate_mvc.Models.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopDb dbContext;
        public ProductRepository()
        {
            dbContext = new ShopDb();
        }
        public string Add(Product product)
        {
        dbContext.Produc.Add(product);
            dbContext.SaveChanges();
            return product.Name;
        }

        public void ChangePrice(int id , int price)
        {
          var product = dbContext.Produc.FirstOrDefault(p=>p.Id == id);
           
            if(product is not null)
            {
                product.price = price;
            }
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
           var p = dbContext.Produc.FirstOrDefault(p => p.Id == id);
            dbContext.Remove(p);
            dbContext.SaveChanges();
        }

        public List<Product> GetAll()
        {
           var p = dbContext.Produc.ToList();
            return p;
        }

        public Product GetById(int id)
        {
           var p = dbContext.Produc.FirstOrDefault(p=>p.Id==id);
            return p;
        }
    }
}
