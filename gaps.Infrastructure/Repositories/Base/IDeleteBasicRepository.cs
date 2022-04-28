using gaps.Domain.Entities.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace gaps.Infrastructure.Repositories.Base
{
    public interface IDeleteBasicRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
    {
        /// <summary>
        /// Delete an Entity by id (Primary Key)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="autoSave"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task DeleteAsync(TKey id, bool autoSave = false, CancellationToken cancellationToken = default);
        Task DeleteManyAsync(IEnumerable<TKey> ids, bool autoSave = false, CancellationToken cancellationToken = default);
    }
}
