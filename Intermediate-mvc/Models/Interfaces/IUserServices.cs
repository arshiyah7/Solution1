using Intermediate_mvc.Models.Entities;

namespace Intermediate_mvc.Models.Interfaces
{
    public interface IUserServices
    {
        public User Get(int id);
        public List<User> GetAll();
        public void ChangePassword(string oldPassword, string newPassword , int id);
        public void Remove(int id);
        public void Add(string name , string lastname , string password);
        public void Login(string name, string password); 
    }
}
