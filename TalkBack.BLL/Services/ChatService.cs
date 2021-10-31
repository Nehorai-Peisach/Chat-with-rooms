using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalkBack.BLL.Interfaces;
using TalkBack.DAL.Models;

namespace TalkBack.BLL.Services
{
    public class ChatService : IChatService
    {
        public void CreateChat()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetChat(User sender, User reciver)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
