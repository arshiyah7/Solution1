using Intermediate_mvc.Models.Entities;

namespace Intermediate_mvc.Models.Interfaces
{
    public interface ICategoryServices
    {
        public void Add(string  name);
        public void Remove(int Id);
        public List<Category> GetAll();
    }
}
