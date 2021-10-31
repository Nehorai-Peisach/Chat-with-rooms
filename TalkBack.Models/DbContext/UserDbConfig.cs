using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkBack.Models.DbContext
{
    public class UserDbConfig
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
        public string UserCollection { get; set; }
    }
}
