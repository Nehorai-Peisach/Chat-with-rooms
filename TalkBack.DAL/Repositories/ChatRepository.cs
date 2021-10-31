using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalkBack.DAL.Interfaces;
using TalkBack.DAL.Models;

namespace TalkBack.DAL.Repositories
{
    public class ChatRepository : IChatRepository
    {
        public void AddMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetMessages(int chatId)
        {
            throw new NotImplementedException();
        }
    }
}
