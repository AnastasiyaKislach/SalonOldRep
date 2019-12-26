using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Salon.Data.Entities;

namespace Salon.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext context)
        {
            _dbContext = context;
        }

        public IQueryable<TEntity> GetAll<TEntity>()
            where TEntity : class, IEntityBase
        {
            return _dbContext.Set<TEntity>().AsQueryable();
        }

        public async Task<TEntity> GetById<TEntity>(int id)
            where TEntity : class, IEntityBase
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task Create<TEntity>(TEntity entity)
            where TEntity : class, IEntityBase
        {
            var res = await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public Task Update<TEntity>(TEntity entity)
            where TEntity : class, IEntityBase
        {
            _dbContext.Set<TEntity>().Update(entity);

            return Task.CompletedTask;
        }

        public async Task Delete<TEntity>(int id)
            where TEntity : class, IEntityBase
        {
            var entity = await GetById<TEntity>(id);
            _dbContext.Set<TEntity>().Remove(entity);
        }
    }
}
