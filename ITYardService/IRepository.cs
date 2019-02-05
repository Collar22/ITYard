using System;
using System.Collections.Generic;
using System.Text;

namespace ITYardService
{
    public interface IRepository<T>
    //interface IRepository<T> where T: EntityBase
    {
        IEnumerable<T> All();       
        bool Insert(T entity);
        T GetById(Guid id);
        bool Delete(Guid id);
        bool Update(Guid id, T entity);
    }
}
