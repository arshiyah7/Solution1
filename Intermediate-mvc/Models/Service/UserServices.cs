using Intermediate_mvc.Models.CurrentUser;
using Intermediate_mvc.Models.Entities;
using Intermediate_mvc.Models.Interfaces;
using Intermediate_mvc.Models.Repository;
using Microsoft.Identity.Client.Extensions.Msal;

namespace Intermediate_mvc.Models.Service
{
    public class UserServices : IUserServices
    {
        private readonly IUserRpository userRpository;
        public UserServices()
        {
            userRpository = new UserRepository();
        }

        public void Add(string name, string lastname, string password)
        {
            if (name != null && password != null) {

                User u = new User()
                {
                    Name = name,
                    LastName = lastname,
                    Password = password
                };

                userRpository.Add(u);

            }
            
        }

        public void ChangePassword(string oldPassword, string newPassword, int id)
        {
            userRpository.ChangePassword(newPassword, id, oldPassword);

        }

        public User Get(int id)
        {
            return userRpository.GetById(id);
        }

        public List<User> GetAll()
        {
            return userRpository.GetAll();
        }

        public void Login(string name, string password)
        {
            if (name != null && password != null)
            {

                if (userRpository.Login(name, password))
                {
                    var user = userRpository.GetByName(name);
                    OnUser.user = user;
                }

            }
        }

        public void Remove(int id)
        {
            userRpository.Remove(id);
        }
    }
}
