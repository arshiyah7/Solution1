using Intermediate_mvc.Models.Entities;

namespace Intermediate_mvc.Models.Interfaces
{
    public interface ICategory
    {
        public void Delet(int id);
        public Category GetById(int id);
    }
}
