using Intermediate_mvc.Models.Entities;
using Intermediate_mvc.Models.Interfaces;
using Intermediate_mvc.Models.Repository;
using Microsoft.Identity.Client.Extensibility;

namespace Intermediate_mvc.Models.Service
{
    public class CategoryService : ICategoryServices
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }
        public void Add(string name)
        {
            if (name is not null) {

                Category category = new Category()
                {
                    Name = name,
                };
            categoryRepository.Add(category);
            
            }
        }

        public List<Category> GetAll()
        {
           return categoryRepository.GetAll();
        }

        public void Remove(int Id)
        {
            categoryRepository.Delet(Id);

        }
    }
}
