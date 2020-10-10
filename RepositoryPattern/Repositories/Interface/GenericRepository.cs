using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RepositoryPattern.Repositories.Interface
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        protected ShoppingContext Context;

        protected GenericRepository(ShoppingContext context)
        {
            this.Context = context;
        }

        public virtual T Add(T entity)
        {
            return Context
                .Add(entity)
                .Entity;
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>()
                .AsQueryable()
                .Where(predicate).ToList();
        }

        public virtual T Get(Guid id)
        {
            return Context.Find<T>(id);
        }

        public virtual IEnumerable<T> All()
        {
            return Context.Set<T>()
                .ToList();
        }

        public virtual T Update(T entity)
        {
            return Context.Update(entity)
                .Entity;
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
