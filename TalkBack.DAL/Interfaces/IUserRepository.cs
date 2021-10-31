using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalkBack.DAL.Models;

namespace TalkBack.DAL.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        IMongoCollection<User> GetUsers();
    }
}
