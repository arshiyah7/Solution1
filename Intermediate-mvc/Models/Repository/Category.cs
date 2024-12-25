using Intermediate_mvc.Models.DB;
using Intermediate_mvc.Models.Entities;
using Intermediate_mvc.Models.Interfaces;

namespace Intermediate_mvc.Models.Repository
{
    public class CategoryRepo : ICategory
    {
        private readonly ShopDb dbcontext;
        public CategoryRepo()
        {
            dbcontext = new ShopDb();
        }

        public void Delet(int id)
        {
           var p = dbcontext.Category.FirstOrDefault(c => c.Id == id);
            if (p != null) { 
            
                dbcontext.Category.Remove(p);
            
            }
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
