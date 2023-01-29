using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<Class>
    {
        List<Class> Get();
        Class Get(int id);
        void Create(Class obj);
        void Update(Class obj);
        void Delete(int id);

    }
}
