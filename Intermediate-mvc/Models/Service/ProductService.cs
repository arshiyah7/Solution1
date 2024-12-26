using Intermediate_mvc.Models.Entities;
using Intermediate_mvc.Models.Interfaces;
using Intermediate_mvc.Models.Repository;

namespace Intermediate_mvc.Models.Service
{
    public class ProductService : IProductServices
    {
       
        private readonly IProductRepository productsRepository;
        public ProductService()
        {
            productsRepository = new ProductRepository();
        }
        public void Add(Product p)
        {
            productsRepository.Add(p);
           
        }

        public void ChangePrice(int id, int price)
        {
            var p = productsRepository.GetById(id);
            productsRepository.ChangePrice(p.Id, price);
        }

        public void Delete(int id)
        {
            productsRepository.Delete(id);
        }

        public List<Product> GetAll()
        {
         return productsRepository.GetAll();
        }
    }
}
