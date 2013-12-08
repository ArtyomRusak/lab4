using System;
using System.Linq;
using System.Linq.Expressions;
using Questionnaire.Core.Entities;

namespace Questionnaire.Core.InterfaceRepository
{
    public interface IRepository<TEntity, in TKey> : IRepository where TEntity : Entity
    {
        void Create(TEntity value);
        void Update(TEntity value);
        void Remove(TEntity value);
        TEntity GetEntityById(TKey id);
        TEntity Find(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> All();
        IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);
    }
}
