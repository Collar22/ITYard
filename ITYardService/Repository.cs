using ITYardService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITYardService
{
    public class Repository<T> : IRepository<T> where T : EntityBase<Guid>
    {
        public Dictionary<Guid, T> entity = new Dictionary<Guid, T>();
        private Logger logger = new Logger();



        IEnumerable<T> IRepository<T>.All()
        {
            return entity.Values;
        }

        bool IRepository<T>.Delete(Guid id)
        {
            if (entity.ContainsKey(id))
            {
                return true;
            }
            return false;
        }

        T IRepository<T>.GetById(Guid id)
        {
            T current = null;
            if (entity.ContainsKey(id))
            {
                entity.TryGetValue(id, out current);
            }
            return current;
        }

        bool IRepository<T>.Insert(T item)
        {
            entity.Add(item.Id, item);
            return true;
        }

        bool IRepository<T>.Update(Guid id, T item)
        {
            if (entity.ContainsKey(id))
            {
                entity[id] = item;
                return true;
            }
            return false;
        }
    }
}
