using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PTApi.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetSharedAppEntity(int? id);
        TEntity GetCompany(string companyId);
        TEntity Get(string id, string companyId);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
 
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);


        //IEnumerable<TEntity> GetAll(string companyId);
    }
}
