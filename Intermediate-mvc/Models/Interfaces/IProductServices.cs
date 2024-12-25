using Intermediate_mvc.Models.Entities;

namespace Intermediate_mvc.Models.Interfaces
{
    public interface IProductServices
    {

        public void ChangePrice(int id, int price);

        public void Add(Product p);
    }
}
