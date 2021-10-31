using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalkBack.DAL.Interfaces;
using TalkBack.DAL.Models;
using TalkBack.Models.DbContext;

namespace TalkBack.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> users;

        public UserRepository(IOptions<UserDbConfig> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            var database = client.GetDatabase(options.Value.DatabaseName);
            users = database.GetCollection<User>(options.Value.UserCollection);
        }

        public IMongoCollection<User> GetUsers() => users;


        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
