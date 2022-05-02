using gaps.Domain.Entities.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace gaps.Infrastructure.Repositories.Base
{
    /// <summary>
    /// Primary Repository to execut command in db 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        Task DeleteAsync(TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);
        Task DeleteManyAsync(IEnumerable<TEntity> entites, bool autoSave = false, CancellationToken cancellationToken = default);
        Task<TEntity> InsertAsync(TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);
        Task InsertManyAsync(IEnumerable<TEntity> entites, bool autoSave = false, CancellationToken cancellationToken = default);
        Task UpdateAsync(TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);
        Task UpdateManyAsync(IEnumerable<TEntity> entites, bool autoSave = false, CancellationToken cancellationToken = default);
    }
}
