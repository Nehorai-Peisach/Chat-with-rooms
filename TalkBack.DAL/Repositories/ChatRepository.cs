using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalkBack.DAL.DataBases;
using TalkBack.DAL.Interfaces;
using TalkBack.DAL.Models;

namespace TalkBack.DAL.Repositories
{
    public class ChatRepository : IRepository<Chat>
    {
        static string table = "AllChats";
        MyMongoDb db = new MyMongoDb("Chats");

        public void Add(Chat input)
        {
            var collection = db.Client.GetCollection<Chat>(table);
            collection.InsertOne(input);
        }

        public Chat Get(Guid id)
        {
            var collection = db.Client.GetCollection<Chat>(table);
            var filter = Builders<Chat>.Filter.Eq("ChatId", id);

            return collection.Find(filter).First();
        }

        public List<Chat> GetAll() => db.Client.GetCollection<Chat>(table).Find(new BsonDocument()).ToList();

        public void Remove(Guid id)
        {
            var collection = db.Client.GetCollection<Chat>(table);
            var filter = Builders<Chat>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }

        public void Update(Chat input,Guid id)
        {
            var collection = db.Client.GetCollection<Chat>(table);
            var filter = Builders<Chat>.Filter.Eq("Id", id);

            collection.ReplaceOne(filter,input);
        }
    }
}
