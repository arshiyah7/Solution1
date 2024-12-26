using Intermediate_mvc.Models.Entities;

namespace Intermediate_mvc.Models.Interfaces
{
    public interface ICategoryRepository
    {
        public void Delet(int id);
        public Category GetById(int id);
        public void Add(Category category);
        public List<Category> GetAll();
    }
}
