using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ApiTemplate.Data
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();

        TEntity GetFirstOrDefault(
            Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includes);

        IEnumerable<TEntity> GetWhere(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void AddInRange(IEnumerable<TEntity> entities);
        bool Exists(int id);
        bool Empty();
    }
}
