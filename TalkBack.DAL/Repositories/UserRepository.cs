using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using TalkBack.DAL.DataBases;
using TalkBack.DAL.Interfaces;
using TalkBack.DAL.Models;

namespace TalkBack.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        static string table = "AllUsers";
        MyMongoDb db = new MyMongoDb("Users");

        public void Add(User input)
        {
            var collection = db.Client.GetCollection<User>(table);
            collection.InsertOne(input);
        }

        public User Get(Guid id)
        {
            var collection = db.Client.GetCollection<User>(table);
            var filter = Builders<User>.Filter.Eq("UserId", id);

            return collection.Find(filter).First();
        }

        public List<User> GetAll() => db.Client.GetCollection<User>(table).Find(new BsonDocument()).ToList();

        public void Remove(Guid id)
        {
            var collection = db.Client.GetCollection<User>(table);
            var filter = Builders<User>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }

        public void Update(User input, Guid id)
        {
            var collection = db.Client.GetCollection<User>(table);
            var filter = Builders<User>.Filter.Eq("Id", id);

            collection.ReplaceOne(filter, input);
        }
    }
}
