using Intermediate_mvc.Models.DB;
using Intermediate_mvc.Models.Entities;
using Intermediate_mvc.Models.Interfaces;

namespace Intermediate_mvc.Models.Repository
{
    public class UserRepository : IUserRpository
    {
        private readonly ShopDb shopDb;
        public UserRepository()
        {
            shopDb = new ShopDb();
        }
        public void Add(User user)
        {
            shopDb.users.Add(user);
            shopDb.SaveChanges();
        }

        public List<User> GetAll()
        {
           var users = shopDb.users.ToList();   
            return users;
        }

        public User GetById(int id)
        {
            var user = shopDb.users.FirstOrDefault(x => x.Id == id);
            if(user != null)
            {
                return user;
            }
            return null;
        }

        public void Remove(int id)
        {
          var user =  GetById(id);
            shopDb.Remove(user);
            shopDb.SaveChanges();

        }

        public void ChangePassword(string password , int id , string oldpass)
        {
           var user = shopDb.users.FirstOrDefault(u => u.Id == id);
            if (user != null) { 
            
             if(user.Password == oldpass)
                {
                    user.Password = password;
                    shopDb.SaveChanges();
                }
            
            
            }
        }

        public bool Login(string name, string password)
        {
            return shopDb.users.Any(u=>u.Name == name && u.Password == password);
        }

        public User GetByName(string name)
        {
            return shopDb.users.FirstOrDefault(u => u.Name == name);
        }
    }
}
