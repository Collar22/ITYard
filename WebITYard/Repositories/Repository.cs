using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebITYard.DAL;

namespace WebITYard.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity<Guid>
    {
        private readonly DbContext dbContext;
        private readonly DbSet<T> dbSet;

        public Repository()
        {
            this.dbContext = new CustomerContext();
            dbSet = this.dbContext.Set<T>();
        }

        public IQueryable<T> All()
        {
            return this.dbSet;
        }

        public T GetById(Guid id)
        {
            return this.dbSet.Find(id);
        }

        public Guid Insert(T entity)
        {
            var id = Guid.NewGuid();
            entity.Id = id;
            this.dbSet.Add(entity);

            return id;
        }

        public void InsertRange(IEnumerable<T> entities)
        {
            this.dbSet.AddRange(entities);
        }

        public void Delete(T entity)
        {
            this.dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            this.dbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            this.dbSet.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            this.dbSet.UpdateRange(entities);
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }
    }
}
