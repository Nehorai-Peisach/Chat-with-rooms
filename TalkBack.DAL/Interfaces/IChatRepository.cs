using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalkBack.DAL.Models;

namespace TalkBack.DAL.Interfaces
{
    public interface IChatRepository
    {
        void AddMessage(Message message);
        List<Message> GetMessages(int chatId);
    }
}
