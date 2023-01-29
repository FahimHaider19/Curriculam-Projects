using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<T>
    {
        List<T> Get();
        T Get(int id);
        bool Add(T obj);
        bool Update(T obj);
        bool Delete(int id);
    }
}
