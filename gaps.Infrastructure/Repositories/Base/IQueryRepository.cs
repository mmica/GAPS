using gaps.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace gaps.Infrastructure.Repositories.Base
{
    public interface IQueryRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
    {
        Task<TEntity> FindAsync(Expression<Func<TEntity>> predicate);
        Task<TEntity> GetAsync(Expression<Func<TEntity>> predicate);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetListAsync(IEnumerable<TKey> ids);
        Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity>> predicate);
        Task<TEntity> GetByIdAsync(TKey id);
    }
}
