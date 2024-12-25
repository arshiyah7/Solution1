using Intermediate_mvc.Models.Entities;

namespace Intermediate_mvc.Models.Interfaces
{
    public interface IProductRepository
    {
        public string Add(Product product);

        public void ChangePrice(int id , int price);
        public void Delete(int id);
        public Product GetById(int id);
        public List<Product> GetAll();
    }
}
