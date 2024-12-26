using Intermediate_mvc.Models.Entities;

namespace Intermediate_mvc.Models.Interfaces
{
    public interface IUserRpository
    {
        public User GetById(int id);
        public List<User> GetAll();
        public void Remove(int id);
        public void Add(User user);
        public void ChangePassword(string password, int id, string oldPass);
        public bool Login(string name, string password);
        public User GetByName(string name);

    }
}
