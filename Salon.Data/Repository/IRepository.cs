using System.Linq;
using System.Threading.Tasks;
using Salon.Data.Entities;

namespace Salon.Data.Repository
{
	public interface IRepository
	{
		IQueryable<TEntity> GetAll<TEntity>()
			where TEntity : class, IEntityBase;

		Task<TEntity> GetById<TEntity>(int id)
			where TEntity : class, IEntityBase;

		Task Create<TEntity>(TEntity entity)
			where TEntity : class, IEntityBase;

		Task Update<TEntity>(TEntity entity)
			where TEntity : class, IEntityBase;

		Task Delete<TEntity>(int id)
			where TEntity : class, IEntityBase;
	}
}
