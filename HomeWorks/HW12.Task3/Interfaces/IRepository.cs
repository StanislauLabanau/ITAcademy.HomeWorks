using System;
using System.Collections.Generic;

namespace HW12.Task3.Repositories
{
    interface IRepository<T> where T : class
    {
        void Create(T item);

        void Delete(Guid id);

        void Update(T item);

        T GetByID(Guid id);

        IEnumerable<T> GetAll();
    }
}
