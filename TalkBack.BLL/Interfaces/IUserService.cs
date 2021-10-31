using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalkBack.DAL.Models;

namespace TalkBack.BLL.Interfaces
{
    public interface IUserService
    {
        List<User> GetUsers();
        void Login(string username, string password);
        void Register(string username, string password);
        void Logout();
    }
}
