using gaps.Domain.Entities.Interfaces;
using Infrastructure;

namespace gaps.Infrastructure.Repositories.Base
{
    public class EfCoreRepository<TDbContext, TEntity, TKey>
        where TDbContext : ApplicationDbContext
        where TEntity : class, IEntity<TKey>
    {
        public EfCoreRepository(TDbContext dbContextProvider) { }
       
    }
}
