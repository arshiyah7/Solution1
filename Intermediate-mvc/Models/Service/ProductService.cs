using Intermediate_mvc.Models.Entities;
using Intermediate_mvc.Models.Interfaces;
using Intermediate_mvc.Models.Repository;

namespace Intermediate_mvc.Models.Service
{
    public class ProductService : IProductServices
    {
        private readonly IProductServices services;
        private readonly IProductRepository productsRepository;
        public ProductService()
        {
            services = new ProductService();
            productsRepository = new ProductRepository();
        }
        public void Add(Product p)
        {

           
        }

        public void ChangePrice(int id, int price)
        {
            var p = productsRepository.GetById(id);
            productsRepository.ChangePrice(p.Id, price);
        }
    }
}
