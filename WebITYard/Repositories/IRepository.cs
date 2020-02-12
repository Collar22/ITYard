using System;
using System.Collections.Generic;
using System.Linq;

namespace WebITYard.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> All();
        T GetById(Guid id);
        Guid Insert(T entity);
        void InsertRange(IEnumerable<T> entities);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);

        void SaveChanges();
    }
}
