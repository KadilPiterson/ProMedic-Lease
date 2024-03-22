﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetById(long id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(long id);
    }
}
