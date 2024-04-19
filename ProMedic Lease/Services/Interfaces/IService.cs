using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IService<T>
    {
        void Add(T entity);
        T GetById(long id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(long id);
    }
}
