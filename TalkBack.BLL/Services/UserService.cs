using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalkBack.BLL.Interfaces;
using TalkBack.DAL.Models;
using TalkBack.DAL.Repositories;

namespace TalkBack.BLL.Services
{
    public class UserService : IUserService
    {
        private UserRepository repo = new UserRepository();
        public List<User> GetUsers()
        {
            var collection = repo.GetAll();
            if (collection != null)
                return repo.GetAll();
            return new List<User>();
        }

        public void Register(string username, string password)
        {

        }

        public void Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        private bool CheckIfExist(User user)
        {
            var userInDb = repo.Get(user.UserId);
            if (user == userInDb)
                return true;
            return false;
        }
    }
}
