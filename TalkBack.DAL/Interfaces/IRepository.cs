using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkBack.DAL.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T input);
        void Remove(Guid id);
        T Get(Guid id);
        List<T> GetAll();
        void Update(T input, Guid id);
    }
}
