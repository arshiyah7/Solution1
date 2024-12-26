using Intermediate_mvc.Models.DB;
using Intermediate_mvc.Models.Entities;
using Intermediate_mvc.Models.Interfaces;

namespace Intermediate_mvc.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ShopDb dbcontext;
        public CategoryRepository()
        {
            dbcontext = new ShopDb();
        }
        public void Add(Category category)
        {
           dbcontext.Add(category);
            dbcontext.SaveChanges();
        }

        public void Delet(int id)
        {
           var p = dbcontext.Category.FirstOrDefault(c => c.Id == id);
            if (p != null) { 
            
                dbcontext.Category.Remove(p);
                dbcontext.SaveChanges();
            
            }
        }

        public List<Category> GetAll()
        {
            var categories = dbcontext.Category.ToList();   
            return categories;
        }

        public Category GetById(int id)
        {
           var c = dbcontext.Category.FirstOrDefault(c=> c.Id == id);
            if (c != null) { 
            
                return c;
            
            
            }
            return null; 
        }
    }
}
