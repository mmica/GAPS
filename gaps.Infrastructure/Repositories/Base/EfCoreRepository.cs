using gaps.Domain.Entities.Interfaces;
using Infrastructure;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace gaps.Infrastructure.Repositories.Base
{
    public class EfCoreRepository<TDbContext, TEntity, TKey> : Repository<TEntity>
        where TDbContext : ApplicationDbContext
        where TEntity : class, IEntity<TKey>
    {
        private readonly ApplicationDbContext dbContext;
        public EfCoreRepository(TDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task SaveAsync()
        {
            return dbContext.SaveChangesAsync();
        }

        public override async Task<TEntity> InsertAsync(TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            try
            {
                await dbContext.Set<TEntity>().AddAsync(entity);
                return entity;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        private bool disposed = false;
        protected async virtual Task Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    await dbContext.DisposeAsync();
            }
            this.disposed = true;
        }
        public async Task Dispose()
        {
            await Dispose(true);
        }
    }
}
