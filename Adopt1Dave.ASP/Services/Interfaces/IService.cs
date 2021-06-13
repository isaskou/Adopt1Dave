using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adopt1Dave.ASP.Services.Interfaces
{
    public interface IService<T,U>
        where T:class
        where U:class
    {
        IEnumerable<T> GetAll();
        U GetById(int id);
        void Insert(U form);
        void Update(U form);
        bool Delete(int id);

    }
}
