using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkBack.DAL.Models
{
    public class Chat
    {
        public int ChatId { get; set; }
        public User[] Users { get; set; }
        public List<Message> Messages { get; set; }
    }
}
